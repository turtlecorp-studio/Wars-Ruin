using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	GameObject CodePanel, closedDoor, openDoor, elevatorWall;

	public static bool isDoorOpen = false;
   // public static bool elevatorOn = false;

	//public Canvas codeCanvas;

	public float moveSpeed;
	public int curHealth;
	public int maxHealth = 8;
	


	private float _dashSpeed = 40;
	private float _dashTime = 1;
	private float _dashTimer;

	private Animator anim; 
	private Rigidbody2D myRigidbody;
	private bool playerMoving;
	private Vector2 lastMove;
    public GameObject deathScene;
	public GameObject mainCanvas;
	public static bool PlayerisDead = false;



	public bool canMove;
	
	


	// Use this for initialization
	void Start () {
		//codeCanvas.enabled = false;

		//player = GameObject.FindGameObjectWithTag ("Enemy").transform;
		//timeBtwShots = startTimeBtwShots;
		Time.timeScale = 1f;
		anim = GetComponent<Animator>();
		myRigidbody = GetComponent<Rigidbody2D> ();
		curHealth = maxHealth;


		CodePanel.SetActive (false);
		closedDoor.SetActive (true);
		openDoor.SetActive (false);
        Time.timeScale = 1f;
        //       elevatorWall.SetActive(false);
    }
	
	// Update is called once per frame
	private void Update ()
	{


		playerMoving = false;
		var h = Input.GetAxisRaw("Horizontal");
		var v = Input.GetAxisRaw("Vertical");

		if (Input.GetMouseButtonDown(1) && _dashTimer >= _dashTime)
		{
			_dashTimer = 0;
			
			anim.SetTrigger("Blink");
			h *= _dashSpeed;
			v *= _dashSpeed;
 
		}


	   	if (!canMove)
		{
			return;
		}

		if ( h != 0) {
			//transform.Translate (new Vector3 (Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
			myRigidbody.velocity = new Vector2 (h * moveSpeed, myRigidbody.velocity.y);
			playerMoving = true; 
			lastMove = new Vector2 (h, 0f);
		}	

		if ( v != 0) {
			//transform.Translate (new Vector3 (0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
			myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, v * moveSpeed);
			playerMoving = true;
			lastMove = new Vector2 (0f, v);
		}	

		if (h < 0.5f && h > -0.5f) {
			myRigidbody.velocity = new Vector2 (0f, myRigidbody.velocity.y);
		}
		if (v < 0.5f && v > -0.5f) { 
			myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, 0f);
		}

		if(curHealth > maxHealth)
		{
			curHealth = maxHealth;
		}

		if(curHealth <= 0){
			Die ();
		}


		_dashTimer += Time.deltaTime;

		anim.SetFloat ("MoveX", h);
		anim.SetFloat ("MoveY", v);
		anim.SetBool("PlayerMoving", playerMoving);
		anim.SetFloat("LastMoveX", lastMove.x);
		anim.SetFloat("LastMoveY", lastMove.y);


		if (isDoorOpen) {

			CodePanel.SetActive (false);
			closedDoor.SetActive (false);
			openDoor.SetActive (true);
		}

 
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals ("Codepad") && !isDoorOpen) 
		{
            //codeCanvas.enabled = true;
            CodePanel.SetActive (true);
			
		}
 /*       if (col.gameObject.name.Equals("EndMap") && !elevatorOn)
        {
            //elevator canvas.enabled = true;
            elevatorWall.SetActive(true);

        }*/
    }


    void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.name.Equals ("Codepad")) 
		{
            //codeCanvas.enabled = false;

            CodePanel.SetActive (false);
		}
 /*       if (col.gameObject.name.Equals("EndMap"))
        {
            //codeCanvas.enabled = false;

            elevatorWall.SetActive(false);
        }*/
    }

    public void Die()
	{
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);	
     deathScene.SetActive(true);
	 mainCanvas.SetActive(false);
	Time.timeScale = 0f;
	 PlayerisDead = true;
    }

	public void Retry() 
	{
        Debug.Log("Retry");
        Time.timeScale = 1.0f;
        PlayerisDead = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

	public void BacktoMainMenu()
	{
	   Time.timeScale = 1f;
       SceneManager.LoadScene("MainMenu");
	}
	public void Quit()
	{
		Application.Quit();
		Debug.Log("Quit");
	}
	

public void Damage(int dmg)

	{
		curHealth -= dmg;
	}

   
}
