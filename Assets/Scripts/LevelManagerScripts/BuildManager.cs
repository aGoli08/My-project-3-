using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager main;

    [Header("References")]
    [SerializeField] public Tower[] bloonPrefabs;

    private int currentSelectedBloon;

    private int selectedTower = 0;

    private void Awake(){
        main = this;
    }

    public Tower GetSelectedTower(){
        return bloonPrefabs[selectedTower];
    }

    public void SetSelectedTower(int sTower){
        selectedTower = sTower;
    }
}
