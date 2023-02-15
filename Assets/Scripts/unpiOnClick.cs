using UnityEngine;

public class unpiOnClick : MonoBehaviour
{
    private Rigidbody2D fixation;
    public GameObject character;

    private void Start()
    {
        fixation = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown(){
        Debug.Log("Click!");
        // fixation.bodyType = RigidbodyType2D.Dynamic;
        // HingeJoint hingeJoint = character.GetComponent("HingeJoint");
        Destroy(character.GetComponent<HingeJoint2D>());
    }
}
