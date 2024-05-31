using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SelectedTower : MonoBehaviour
{
    //my code
    
    [Header("Attributes")]
    //BuildManager contains an array holding each tower prefab so in the Unity Inspector I can set it to an index which inturn refers to a certain tower.
    [SerializeField] private int tow; 

    //OnMouseDown() method registers mouseclicks
    private void OnMouseDown(){
        Debug.Log("SelectedTowerRan");
        //You always have some sort of selected tower, but by pressing on the Tower buttons you change that
        BuildManager.main.SetSelectedTower(tow);
        
    }
}
