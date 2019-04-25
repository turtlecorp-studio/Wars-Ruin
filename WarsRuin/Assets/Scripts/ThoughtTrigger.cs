using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThoughtTrigger : MonoBehaviour
{
    public GameObject playerThoughtPanel;

    // Start is called before the first frame update
    void Start()
    {
        playerThoughtPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        other.gameObject.tag = "Player";
            Destroy(playerThoughtPanel);
            
    }
}
