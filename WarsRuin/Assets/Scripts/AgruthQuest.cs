using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgruthQuest : MonoBehaviour
{
    public GameObject questText;
    public GameObject agruthIntro;
    public GameObject pathBlockers;
    public GameObject lockedNotifications;

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
            pathBlockers.SetActive(false);
            Destroy(lockedNotifications);
        }
    }
}
