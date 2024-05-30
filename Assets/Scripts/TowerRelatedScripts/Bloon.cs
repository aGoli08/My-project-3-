using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Bloon : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private LayerMask enemyMask;
    [SerializeField] private GameObject bulletPrefab;
    
    [SerializeField] private Transform firePoint;


    [Header("Attributes")]
    [SerializeField] private float range = 2f;
    [SerializeField] private float bps = 1f;
   

    private float timeUntilFire;
    private Transform target;

    private void Update(){
        if (target == null){
            FindTarget();
            return;
        }

        if(!CheckTargetIsInRange()){
           target = null;
        }
        else{
            timeUntilFire += Time.deltaTime;

            if(timeUntilFire > 1f / bps){
                Shoot();
                timeUntilFire = 0f;
            }
        }
    }

    private void Shoot(){
        GameObject bulletObj = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Bullet bulletScript = bulletObj.GetComponent<Bullet>();
        bulletScript.SetTarget(target);
    }

    private bool CheckTargetIsInRange(){
        return Vector2.Distance(transform.position, target.position) <= range;
    }

    private void FindTarget(){
        RaycastHit2D[] hits = Physics2D.CircleCastAll(transform.position, range, (Vector2)transform.position, 0f, enemyMask);

        if(hits.Length > 0){
            target = hits[0].transform;
        }
    }

    private void OnDrawGizmosSelected(){
        Handles.color = Color.cyan;
        Handles.DrawWireDisc(transform.position, transform.forward, range);
    }
}
