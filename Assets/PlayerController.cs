using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
Vector2 movement = Vector2.zero;
[SerializeField]
float speed = 3;
     void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(movement * Time.deltaTime);
        
    }

    void OnMove(InputValue value)
    {
        Vector2 vector = value.Get<Vector2>();
        movement = Vector2.one * vector;
        print(vector);
    }
}
