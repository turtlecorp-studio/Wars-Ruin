using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int curHealthEnemy;
    public int maxHealthEnemy = 3;

    // Start is called before the first frame update
    void Start()
    {
        curHealthEnemy = maxHealthEnemy;
    }

    // Update is called once per frame
    void Update()
    {
        if (curHealthEnemy > maxHealthEnemy)
        {
            curHealthEnemy = maxHealthEnemy;
        }

        if (curHealthEnemy <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void Damage(int dmg)

    {
        curHealthEnemy -= dmg;
    }
}
