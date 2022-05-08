using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum; 

   
    void Start()
    {

        ScoreNum = 0;
        MyscoreText.text = "Score : " + ScoreNum; 
        
    }

    private void OntriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "Bitcoin02")
        {
            ScoreNum += 1;
            Destroy(Coin.gameObject);
            MyscoreText.text = "Score" + ScoreNum;
        }
    }
   
}
