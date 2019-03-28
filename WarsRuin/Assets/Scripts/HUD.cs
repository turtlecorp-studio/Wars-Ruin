using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	public Sprite[] HealthBarSprite;
	public Image HealthBarUI;
	private Player player;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();



	}

	void Update ()
	{

		HealthBarUI.sprite = HealthBarSprite[player.curHealth];

	}

}


