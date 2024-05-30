using System;
using UnityEngine;

[Serializable]
public class Tower
{
   public string name;
   public int cost;
   public GameObject prefab;

   public Tower(string n, int c, GameObject p){
    name  = n;
    cost = c;
    prefab = p;
   }
}
