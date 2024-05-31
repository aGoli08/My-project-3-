using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stats : MonoBehaviour
{
    //my code

    //a bunch of variables to hold text boxes that will display all stats

    [Header("References")]
    [SerializeField] TextMeshProUGUI currencyUI;
    [SerializeField] TextMeshProUGUI scoreUI;
    [SerializeField] TextMeshProUGUI healthUI;
    [SerializeField] TextMeshProUGUI waveUI;


    //method used to aid in displaying stats
    private void OnGUI(){
        //displaying of stats
        currencyUI.text = "Currency: " + LevelManager.main.currency.ToString();
        scoreUI.text = "Score: " + LevelManager.main.score.ToString();
        healthUI.text = "Health: " + LevelManager.main.healthPoints.ToString(); 
        waveUI.text = "Wave: " + EnemySpawner.currentWave.ToString();

    }

    

}
