using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space) & gameObject.GetComponent<Slide>()._grounded){
            MakeJump();
        }
    }

    private void MakeJump(){
        Debug.Log("Jump!");
        gameObject.GetComponent<Slide>()._velocity.y += 5;
    }
}
