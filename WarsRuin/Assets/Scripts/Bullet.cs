using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 25f;
    public float lifeDuration = 0.5f;

    private float lifeTimer;

    void Start()
    {
        lifeTimer = lifeDuration;
    }

    public void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == ("Player"))
        {
            other.GetComponent<Player>().Damage(1);
            Debug.Log("Collided");
            Destroy(gameObject);
        }

        else if (other.gameObject.tag == ("Enemy"))
        {
            other.GetComponent<EnemyController>().Damage(1);
            Debug.Log("Collided with enemy");
            Destroy(gameObject);
        }
    }

    /*void OnTriggerEnter(Collider col)
	{
		if (col.isTrigger != true && col.gameObject.tag == ("Player")) {
			col.GetComponent<Player>().Damage (1);
			Destroy(gameObject); 
		}
	} */
}

