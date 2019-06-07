using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgruthQuest : MonoBehaviour
{
    public GameObject dialogEnd;
    public GameObject questLight;
    public GameObject questNotify;
    public GameObject pathBlockers;
    public GameObject lockedNotifications;

    // Start is called before the first frame update
    void Start()
    {
        questNotify.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogEnd == null)
        {
            questNotify.SetActive(true);
            pathBlockers.SetActive(false);
            Destroy(questLight);
            Destroy(lockedNotifications);
        }
    }
}
