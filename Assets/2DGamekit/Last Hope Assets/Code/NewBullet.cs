using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBullet : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.name.Equals("Ellen")) || (collision.name.Equals("InfoPost (2)")) || (collision.name.Equals("InfoPost (1)")) || (collision.name.Equals("InfoPost")))
        {

        }else
        {
            EnemyHealth enemy = collision.GetComponent<EnemyHealth>();
            if (enemy != null)
            {
                enemy.TakeDamage(100);
            }

            Debug.Log(collision.name);
            Destroy(gameObject);
        }
    }
}
