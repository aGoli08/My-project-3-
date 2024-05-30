using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    //values responsible for modify the characteristics of the enemy

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;

    //the point that the enemy is traveling to, this will be changed after point is reached so that it moves on to the next point
    private Transform target;
    private int pathIndex = 0;
    private void Start(){
        //each point in the path is part of an array, so this will go through each point
        target = LevelManager.main.path[pathIndex];
    }
    private void Update(){
        //checks distance if the enemy has reached the target
        if(Vector2.Distance(target.position, transform.position) <= 0.1f){
            pathIndex++;

            //at the end of the array and the end of the path enemy will be destroyed
            if(pathIndex == LevelManager.main.path.Length){
                EnemySpawner.onEnemyDestroy.Invoke();
                Destroy(gameObject);
                return;
            }
            //so that the target does not become a null value
            else{
                target = LevelManager.main.path[pathIndex];
            }
        }
    }

    //so that the code knows where to move
    private void FixedUpdate(){
        Vector2 direction = (target.position - transform.position).normalized;

        rb.velocity = direction * moveSpeed;
    }
}
