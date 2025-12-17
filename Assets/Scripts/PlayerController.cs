using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
Vector2 movement = Vector2.zero;
[SerializeField]
float speed = 3;
     
Animator animera;     
     
     void Start()
    {
        //variablen anim har datatypen Animator
        animera = GetComponent<Animator>();
    }
    void Update()
    {
        transform.Translate(movement * Time.deltaTime * speed);
        
    }

    void OnMove(InputValue value)
    {
        Vector2 vector = value.Get<Vector2>();
        movement = Vector2.one * vector;
        print(vector);

        //if(movement.magnitude == 0)
        if(movement == Vector2.zero)
        {
            animera.Play("Idle");
        }
        else if(movement.y < 0)
        {
            animera.Play("WalkDown");
        }
        else if(movement.y > 0)
        {
            animera.Play("WalkUp");
        }
        else if(movement.x > 0)
        {
            animera.Play("WalkRight");
        }
        else if(movement.x < 0)
        {
            animera.Play("WalkLeft");
        }
    }
}
