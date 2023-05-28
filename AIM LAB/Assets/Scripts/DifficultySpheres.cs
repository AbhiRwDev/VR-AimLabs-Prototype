using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySpheres : MonoBehaviour
{
    public string difficulty;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Bullet"))
        {
            FindObjectOfType<GameManager>().SetDifficulty(difficulty);
            transform.parent.gameObject.SetActive(false);
        }
    }
}
