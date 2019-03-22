using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 125f;
    public float lifeDuration = 1f;

    public int dmgBullet = 1;

    private float lifeTime;



    // Start is called before the first frame update
    void Start()
    {
        lifeTime = lifeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;

        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        
    }
}
