using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Move : MonoBehaviour
{


    Animator Ch05_nonPBR;
    public float IsWalking=0f;
    public float WalkingRight=0f;
    public float WalkingLeft=0f;
    public float IsWalkingBackward=0f;
    public float Swimming=0f;
    public float Jumping=0f;
    public float JumpForward=0f;
    public float Running=0f;
    // Start is called before the first frame update
    void Start()
    {
        Ch05_nonPBR=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Ch05_nonPBR.SetFloat("IsWalking", IsWalking);
        Ch05_nonPBR.SetFloat("IsWalkingBackward", IsWalkingBackward);
        Ch05_nonPBR.SetFloat("Swimming", Swimming);
        Ch05_nonPBR.SetFloat("WalkingLeft", WalkingLeft);
        Ch05_nonPBR.SetFloat("WalkingRight", WalkingRight);
        Ch05_nonPBR.SetFloat("Jumping", Jumping);
        Ch05_nonPBR.SetFloat("JumpForward", JumpForward);
        Ch05_nonPBR.SetFloat("Running", Running);
        if(Input.GetKeyDown(KeyCode.W) ||Input.GetKeyDown(KeyCode.UpArrow) ){
        
            IsWalking=1f;
            Ch05_nonPBR.SetFloat("IsWalking", 1f);
        }
        if(Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.DownArrow) ){
            IsWalkingBackward=1f;
            Ch05_nonPBR.SetFloat("IsWalkingBackward", 1f);
        }
        if(Input.GetKeyDown(KeyCode.E)){
            Swimming=1f;
            Ch05_nonPBR.SetFloat("Swimming", 1f);
        }

        if(Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.RightArrow)){
            WalkingRight=1f;
            Ch05_nonPBR.SetFloat("WalkingRight", 1f);
        }
        if(Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.LeftArrow)){
            WalkingLeft=1f;
            Ch05_nonPBR.SetFloat("WalkingLeft", 1f);
        }

        if(Input.GetKeyDown(KeyCode.Space) ){
        
            JumpForward=1f;
            Ch05_nonPBR.SetFloat("JumpForward", 1f);
        }
         if(Input.GetKeyDown(KeyCode.LeftShift) ){
        
            Running=1f;
            Ch05_nonPBR.SetFloat("Running", 1f);
        }
        /*
        if(Input.GetKeyDown(KeyCode.Space) ){
            if( (Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow))){
                Jumping=0f;
                IsWalking=0f;
                JumpForward=1f;
                Ch05_nonPBR.SetFloat("JumpForward", 1f);
            }
        }*/

        if(!Input.anyKey){
            WalkingLeft=0f;
            Running=0f;
            //Jumping=0f;
            JumpForward=0f;
            WalkingRight=0f;
            IsWalking=0f;
            IsWalkingBackward=0f;
            Swimming=0f;
        }

       
        
    }
}
