using UnityEngine;

public class CharacterAcceleration : MonoBehaviour
{
    private Rigidbody2D charactersRB;
    [SerializeField] private float impulse = 10f;

    void Start()
    {
        charactersRB = GetComponent<Rigidbody2D>();
        charactersRB.velocity = new Vector2(impulse, charactersRB.velocity.y);
    }
}
