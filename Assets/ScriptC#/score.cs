using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Text Affichescore;
    private int ScoreNum;
   
    void Start()
    {
        ScoreNum = 0;
        Affichescore.text = "Score : " + ScoreNum;


    }

    private void OnTriggerEnter2D(Collider2D coin)

    {
        if (coin.tag == "coin")
        {
            ScoreNum += 1;
            Destroy(coin.gameObject);
            Affichescore.text = "Score" + ScoreNum;

        }

    }
   
}
