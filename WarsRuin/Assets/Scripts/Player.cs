using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 4f;

    public Image healthSlider;
    public float maxHealth = 100;
    private float curHealth;

    Vector3 forward, right;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;

        forward = Camera.main.transform.forward; //Our forward = forward vector of camera
        forward.y = 0; //Y value always set to 0
        forward = Vector3.Normalize(forward); //Keeps the vectors direction 
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward; //Creating a rotation for right vector

    }

    public void TakeDamage(float amount)
    {
        curHealth -= amount;
        healthSlider.fillAmount = curHealth / maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
            Move();
    }

    void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("HorizontalKey"), 0, Input.GetAxis("VerticalKey"));
        Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis("HorizontalKey");
        Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("VerticalKey");

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        transform.forward = heading;
        transform.position += rightMovement;
        transform.position += upMovement;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("Bullet"))
        {
            curHealth -= 1;
        }
    }
}
