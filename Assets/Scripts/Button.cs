using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 
public class Button : MonoBehaviour
{
    //all my code

    private bool isOpening;
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;


 
    

    void FixedUpdate(){
        if(isOpening){
            rb.transform.position = Vector2.Lerp(rb.transform.position, new Vector2(15, 1), Time.deltaTime * 2f);
        }
        if(!isOpening){
            rb.transform.position = Vector2.Lerp(rb.transform.position, new Vector2(20, 1), Time.deltaTime * 2f);
        }
    }

    
    

    private void OnMouseDown(){
        if(isOpening == false){
        isOpening = true;

        }
        else
        {
        isOpening = false;
    
        }
    }
    
    
}


