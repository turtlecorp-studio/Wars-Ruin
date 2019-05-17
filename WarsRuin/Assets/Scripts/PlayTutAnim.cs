using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTutAnim : MonoBehaviour
{
    public Animation tutorialAnimation;
    public GameObject tutorialCard;

    private void Start()
    {
        tutorialCard.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            tutorialCard.SetActive(true);
            tutorialAnimation = tutorialCard.GetComponent<Animation>();
            tutorialAnimation.Play("PlayerThoughtsIn");
            tutorialAnimation.Play("TutorialCard");
        }
    }
}
