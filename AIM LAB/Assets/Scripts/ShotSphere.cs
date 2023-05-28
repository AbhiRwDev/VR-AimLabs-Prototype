using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSphere : MonoBehaviour
{
    public GameManager gamemanager;
    public GameObject particle;
    public float Timer;
    private void Start()
    {
        gamemanager = FindObjectOfType<GameManager>();
    }
    private void Update()
    {
        if(gamemanager.Difficulty=="Hard")
        {
            Timer -= Time.deltaTime;
            if(Timer<=0)
            {
                gamemanager.SpawnRandom();
                Timer = 3f;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Bullet"))
        {
            gamemanager.ShotSphereincrease();
            Timer = 3f;
            Instantiate(particle,transform.position,Quaternion.identity);
            gamemanager.SpawnRandom();
            
        }
    }
}
