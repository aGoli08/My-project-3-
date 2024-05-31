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
        healthPoints = 100;
    }
    //my method, increases the score whenever a enemy is killed
    public void scoreIncrease(int points){
        score += points;
    }
    //referenced in enemy movement, decreases health when enemy makes it past all towers
    public void healthDecrease(int hP){
        healthPoints -= hP;
    }
    //if the players healthpoints are completely depleted, will end the game
    public void isGameOver(){
        if(healthPoints <= 0){
            Debug.Log("GAME OVER");
           
        }
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
            Debug.Log("Not Enough" + currency);
            return false;
        }

    }



}
