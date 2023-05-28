using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 2f;
    public int damage = 1;

    private Rigidbody rb;
    private float timer;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
        timer = lifetime;
    }

    private void Update()
    {
        // Reduce the timer
        timer -= Time.deltaTime;

        // Destroy the bullet after the lifetime has expired
        if (timer <= 0f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider)
        {
            Destroy(gameObject);
        }
      
    }
}
