using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotScript : MonoBehaviour
{
    

    [Header("References")]
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Color hoverColor;

    private GameObject tower;
    private Color startColor;

    private void Start(){
        startColor = sr.color;
    }
    private void OnMouseEnter(){
        sr.color = sr.color;
    }

    private void OnMouseExit(){
        sr.color = startColor;
    }

    private void OnMouseDown(){
        Debug.Log("SomethingHappened");
        if (tower != null){
            return;
        }

        Tower tempTower = BuildManager.main.GetSelectedTower();

        if(tempTower.cost > LevelManager.main.currency){
            Debug.Log("Cannot Afford");
            return;
        }
        LevelManager.main.SpendCurrency(tempTower.cost);
        tower = Instantiate(tempTower.prefab, transform.position, Quaternion.identity);
        
    }
}
