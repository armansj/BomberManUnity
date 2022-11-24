using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectorBomb : MonoBehaviour
{
    public Text myScore;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb")
        {
            IncreaseScore();
            target.gameObject.SetActive(false);
        }   
    }
    void IncreaseScore()
    {
        score++;
        myScore.text = "Score: " + score;
    }
}
