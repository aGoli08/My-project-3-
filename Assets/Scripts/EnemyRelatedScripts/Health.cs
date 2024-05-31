using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
   [Header("Attributes")]
   [SerializeField] public static int hitPoints = 2;
   [SerializeField] private int money = 115;
   [SerializeField] private int scorePoints = 15;
   

   private bool isDestroyed = false;

   public void TakeDamage(int dmg){
    hitPoints -= dmg;
    

    if(hitPoints <= 0 && !isDestroyed){
        EnemySpawner.onEnemyDestroy.Invoke();
        LevelManager.main.IncreaseCurrency(money);
        LevelManager.main.scoreIncrease(scorePoints);
        isDestroyed = true;
        Destroy(gameObject);
    }
    
}
}
