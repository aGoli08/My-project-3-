using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChanger : MonoBehaviour
{
    //my code

    private bool speed;
    //changes the speed of the game if you think it's going to slow
    public void OnMouseDown(){
        //if it's false, speed reverts to normal
        if(speed == false){
            EnemyMovement.moveSpeed /= 0.5f; 
            Bullet.bulletSpeed /= 2;
            
            speed = true;
        }
        //if speed is true, speeds up the game speed
        else{
            Bullet.bulletSpeed *= 2f;
            EnemyMovement.moveSpeed *= 0.5f;
            speed = false;
        }
    }

}


