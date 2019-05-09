using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgruthQuest : MonoBehaviour
{
    public GameObject questText;
    public GameObject agruthIntro;

    // Start is called before the first frame update
    void Start()
    {
        questText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (agruthIntro == null)
        {
            questText.SetActive(true);
        }
    }
}
