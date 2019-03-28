using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour {

	public Animator Anim;
	public Image Img;

	public void Scene1()
	{
		//SceneManager.LoadScene(1);
		StartCoroutine(Fade());
	}

	IEnumerator Fade()
	{
		Anim.SetBool("Fade", true);
		yield return new WaitUntil(() => Img.color.a == 1);
		SceneManager.LoadScene(1);


	}
	
	
}
