using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCircleEnemy : MonoBehaviour
{
	[Header("Projectile Settings")]
	public int numberofProjectiles;
	public float projectileSpeed;
	public GameObject ProjectilePrefab;

	private float timeBtwShots;
	public float startTimeBtwShots;

	[Header("Private Variables")]
	private Vector3 startPoint;
	private const float radius = 1F;

	void Update()
	{
		if (timeBtwShots <= 0)
		{

			startPoint = transform.position;
			SpawnProjectile(numberofProjectiles);
			timeBtwShots = startTimeBtwShots;
			}
			else
			{
			timeBtwShots -= Time.deltaTime;
		}
	}

	private void SpawnProjectile(int _numberofProjectiles)
	{
		float angleStep = 360f / _numberofProjectiles;
		float angle = 0f;

		for (int i = 0; i <= _numberofProjectiles - 1; i++)
		{
			float projectileDirXPosition = startPoint.x + Mathf.Sin((angle * Mathf.PI) / 180) * radius;
			float projectileDirYPosition = startPoint.y + Mathf.Cos((angle * Mathf.PI) / 180) * radius;

			Vector3 projectileVector = new Vector3(projectileDirXPosition, projectileDirYPosition, 0);
			Vector3 projectileMoveDirection = (projectileVector - startPoint).normalized * projectileSpeed;

			GameObject tmpObj = Instantiate(ProjectilePrefab, startPoint, Quaternion.identity);
			tmpObj.GetComponent<Rigidbody2D>().velocity = new Vector3(projectileMoveDirection.x, 0, projectileMoveDirection.y);

			angle += angleStep;
		}
	}
}
	