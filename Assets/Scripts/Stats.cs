using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stats : MonoBehaviour
{
    [Header("References")]
    [SerializeField] TextMeshProUGUI currencyUI;
    [SerializeField] TextMeshProUGUI scoreUI;

    private void OnGUI(){
        currencyUI.text = "Currency: " + LevelManager.main.currency.ToString();
        scoreUI.text = "Score: " + LevelManager.main.score.ToString();
    }

    public void SetSelected(){
        
    }

}
