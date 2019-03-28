using UnityEngine;

public class HealthPickup : MonoBehaviour {

Player player;
public int healthBonus; 

void Awake() {

	player = FindObjectOfType<Player>();
	
}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			if (player.curHealth < player.maxHealth)
			{
				Destroy(gameObject);
				player.curHealth = player.curHealth + healthBonus;
			}
		}
	}
}




