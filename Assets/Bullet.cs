using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
   

    public int DamageToEnemy;



    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(gameObject);
        
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyHealthManager>().DamageToEnemy(DamageToEnemy);
            Destroy(gameObject);

        }

        
    }
}
