using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed; 

    private Rigidbody myRigidbody;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    private Camera mainCamera;

    public int maxHealth = 10;
    public int curHealth;


    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;

        myRigidbody = GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<Camera>();

       
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * moveSpeed;

        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);

       
        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }

        if (curHealth <= 0)
        {
            Die();
        }
    }

     void FixedUpdate()
    {
        myRigidbody.velocity = moveVelocity;
    }
    

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("Bullet"))
        {
            curHealth -= 1;
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void Damage(int dmg)

    {
        curHealth -= dmg;
    }
}
