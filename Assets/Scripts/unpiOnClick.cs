using UnityEngine;

public class unpiOnClick : MonoBehaviour
{
    private Rigidbody2D fixation;

    private void Start()
    {
        fixation = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown(){
        Debug.Log("Click!");
        fixation.bodyType = RigidbodyType2D.Dynamic;
    }
}
