using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{

    public float speed;
    private Transform player;
    private Vector2 target;


    // Use this for initialization
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector2(player.position.x, player.position.y);

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.isTrigger != true && col.gameObject.tag == ("Player"))
        {
            col.GetComponent<PlayerController>().Damage(1);
            Destroy(gameObject);

        } else if (col.gameObject.tag == "wall") {
            Destroy(gameObject);
        }
    }



}