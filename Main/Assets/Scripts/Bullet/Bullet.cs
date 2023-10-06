using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
        //Debug.Log("BulletCreated");
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Handle enemy hit
            Destroy(collision.gameObject);
            Destroy(gameObject); // Destroy the projectile
        }
        else {
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
