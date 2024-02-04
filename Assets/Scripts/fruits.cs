using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruits : MonoBehaviour
{

    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2 (0, 10);
        rb.angularVelocity = 100;
    }
    void Update()
    {
        if (transform.position.y <-7)
        {
            Die();
        }
    }

    void Die()
    {
        print(":(");
        Destroy(gameObject);
    }
}
