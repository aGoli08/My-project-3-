using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
   public static LevelManager main;

    public Transform startPoint;
    public Transform[] path;

    public int currency;

    public int score;

    public int healthPoints;

    private void Awake(){
        main = this;
    }

    private void Start(){
        currency = 625;
        score = 0;
    }
    //my method
    public void scoreIncrease(int points){
        score += points;
    }
    //my method
    public void isGameOver(){
        
    }


    public void IncreaseCurrency(int amount){
        currency += amount;
    }

    public bool SpendCurrency(int amount){
        if(amount <= currency){
            currency -= amount;
            return true;
        }
        else{
            Debug.Log("Not ENough" + currency);
            return false;
        }

    }



}
