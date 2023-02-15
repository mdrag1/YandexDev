using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinToRope : MonoBehaviour
{
    public GameObject character;
    public GameObject lastPartOfRope;

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Connected!");
        character.AddComponent<HingeJoint2D>();
        HingeJoint2D characterHingeJoint = character.GetComponent<HingeJoint2D>();
        characterHingeJoint.connectedBody = lastPartOfRope.GetComponent<Rigidbody2D>();
    }
}
