using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public Animator anim;
  

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

        if (hor + ver != 0)
        {
            anim.SetBool("ShouldWalk", true);
        } else
        {
            anim.SetBool("ShouldWalk", false);
        }
    }

    
}
