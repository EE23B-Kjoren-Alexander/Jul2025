using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
Vector2 movement = Vector2.zero;
[SerializeField]
float speed = 3;
     
Animator anim;     
     
     void Start()
    {
        //variablen anim har datatypen Animator
        anim = GetComponent<Animator>();
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

        if(movement.magnitude == 0)
        {
            anim.Play("Idle");
        }
        else if(movement.y < 0)
        {
            anim.Play("WalkDown");
        }
        else if(movement.y > 0)
        {
            anim.Play("WalkUp");
        }
    }
}
