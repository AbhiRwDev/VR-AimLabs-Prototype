using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMesh ScoreCounter, TimerCounter;
    public float Timer, Score;
    public string Difficulty;
    public GameObject DifficultyPanel, ShotSphere;
    public bool gamestarted=false;
    public float MinX, MaxX, MinY, MaxY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gamestarted)
        {
            Timer -= Time.deltaTime;
            ScoreCounter.text = Score.ToString("00");
            TimerCounter.text = Timer.ToString("00");
           
            if (Timer <= 0)
            {
                gamestarted = false;
                Gamereset();
            }
        }
    }
    public void SetDifficulty(string Diff)
    {
        Difficulty = Diff;
        SpawnRandom();
        DifficultyPanel.SetActive(false);
        gamestarted = true;
    }
    public void SpawnRandom()
    {
        ShotSphere.transform.position = new Vector3(Random.Range(MinX,MaxX),Random.Range(MinY,MaxY),ShotSphere.transform.position.z);
        ShotSphere.SetActive(true);
    }
    public void ShotSphereincrease()
    {
        Score++;
    }
    public void Gamereset()
    {
        DifficultyPanel.SetActive(true);
        ShotSphere.SetActive(false);
       
        Timer = 120;
        Difficulty = "";
    }
}
