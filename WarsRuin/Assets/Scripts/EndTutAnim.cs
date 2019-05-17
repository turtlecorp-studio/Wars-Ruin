using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTutAnim : MonoBehaviour
{
    public Animation tutorialAnimation;
    public GameObject tutorialCard;
    public GameObject tutorialStarter;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            tutorialCard.SetActive(true);
            tutorialAnimation = tutorialCard.GetComponent<Animation>();
            tutorialAnimation.Play("EndTutorialCard");
            tutorialAnimation.Play("PlayerThoughtsOut");
            Destroy(tutorialStarter);
            Destroy(this.gameObject, 0.5f);
        }
    }
}
