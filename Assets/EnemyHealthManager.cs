using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int HP;
    public GameObject deathEffect;
    public GameObject star4Animation;



    public void DamageToEnemy(int dmg)
    {
        HP -= dmg;
        if (HP <= 0)
        {
            Die();
            Star();
        }
    }

    void Die()
    {
        GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(gameObject);
    }

    void Star()
    {
        GameObject effect1 = Instantiate(star4Animation, transform.position, Quaternion.identity);
    }
}
