using UnityEngine;

public class UnpiOnClick : MonoBehaviour
{
    private Rigidbody2D _fixation;
    [SerializeField] private GameObject character;

    private void Start()
    {
        _fixation = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown(){
        Debug.Log("Click!");
        Destroy(character.GetComponent<HingeJoint2D>());
    }
}
