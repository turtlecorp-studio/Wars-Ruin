using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

	public GameObject bullet;
	private float _bulletAcceleration = 60000f;
	private List<GameObject> _bulletClones = new List<GameObject> ();
	private List<float> _bulletAirTimers = new List<float> ();

	private float _cooldown = 0.4f;
	private float _cooldownTimer;

	private float _airTime = 3f;
	private float _airTimer;

	public bool canShoot;

	private void Update()
	{

		if (!canShoot)
		{
			return;
		}

		if (Input.GetMouseButtonDown (0) && _cooldownTimer >= _cooldown)
		{
			Vector2 mousePosition = Input.mousePosition;
			mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);
			mousePosition = (mousePosition - new Vector2(transform.position.x, transform.position.y)).normalized;
			var newBullet = Instantiate (bullet);
			newBullet.transform.position = new Vector3(transform.position.x, transform.position.y, -2f);
			newBullet.GetComponent<Rigidbody2D> ().AddForce (mousePosition * _bulletAcceleration * Time.deltaTime);

			_bulletClones.Add (newBullet);
			_bulletAirTimers.Add (0f);
			_cooldownTimer = 0f;
		}
			
		for (int i = 0; i < _bulletClones.Count; i++) {
			if (_bulletAirTimers [i] > _airTime) {
				Destroy (_bulletClones [i]);
				_bulletClones.RemoveAt (i);
				_bulletAirTimers.RemoveAt (i);
			}
			else {
				_bulletAirTimers [i] += Time.deltaTime;
			}
		}

		_cooldownTimer += Time.deltaTime;
	}
}

 
