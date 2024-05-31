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


 
    
     //FixedUpdate is used for physics calculations(movement of a game object). This method is in charge of moving the store in and out of view
    void FixedUpdate(){
        if(isOpening){
            //Lerp moves the objects between the first and second parameter and the speed is determined by the third parameter
            rb.transform.position = Vector2.Lerp(rb.transform.position, new Vector2(18.5f, 1), Time.deltaTime * 2f);
        }
        if(!isOpening){
            rb.transform.position = Vector2.Lerp(rb.transform.position, new Vector2(25, 1), Time.deltaTime * 2f);
        }
    }

    
    
    //OnMouseDown() registers mouseclicks
    private void OnMouseDown(){
        //isOpening is a bool, so that whenever the button is pressed it moves the store to the expected position and then changes isOpening's value so that the next time it's pressed it moves back to the original position
        if(isOpening == false){
        isOpening = true;

        }
        else
        {
        isOpening = false;
    
        }
    }
    
    
}


