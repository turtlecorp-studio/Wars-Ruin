using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		if (col.isTrigger != true && col.gameObject.tag == ("Player")) {
			col.GetComponent<Player>().Damage (1);
			Destroy (gameObject); 
		}
	}
}

