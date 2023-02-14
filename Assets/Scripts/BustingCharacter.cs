using UnityEngine;

public class BustingCharacter : MonoBehaviour
{
    private Rigidbody2D charactersRB;
    public float impulse = 10f;

    void Start()
    {
        charactersRB = GetComponent<Rigidbody2D>();
        charactersRB.velocity = new Vector2(impulse, charactersRB.velocity.y);
    }
}
