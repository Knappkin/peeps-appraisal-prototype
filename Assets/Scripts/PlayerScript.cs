using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Vector2 movementVector;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");

        Vector2 newPos = (Vector2)transform.position + movementVector.normalized * speed * Time.deltaTime;
        transform.position = newPos;
    }
}
