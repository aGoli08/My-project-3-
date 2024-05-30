using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SelectedTower : MonoBehaviour
{
    //my code
    
    [Header("Attributes")]
    [SerializeField] private int tow;

    private void OnMouseDown(){
        Debug.Log("SelectedTowerRan");
        BuildManager.main.SetSelectedTower(tow);
        
    }
}
