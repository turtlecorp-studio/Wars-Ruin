using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject interactionObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Space) && other.tag == "Player")
        {
            interactionObject.SetActive(true);
        }
        else
        {
            interactionObject.SetActive(false);
        }
    }
}
