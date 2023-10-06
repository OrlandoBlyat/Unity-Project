using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float lastMoveSpeed;
    public float walkSpeed = 4;
    public float sprintSpeed = 7;
    public float nerfSpeed = 2;
    public Rigidbody2D rb;
    public Animator animator;
    public Transform FirePoint;
    Vector2 movement;

    void Update()
    {
        
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //Importing input for animator
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        //sqrMagnitude is supposedly more optimal???
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            animator.SetFloat("LastHor", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("LastVer", Input.GetAxisRaw("Vertical"));
        }
    }
    //Fixed update for no jittering while moving.
    void FixedUpdate() {


        Debug.Log(moveSpeed);
        // Nerf that diagonal nonsense.
        if(movement.x != 0 && movement.y != 0) {
            moveSpeed = moveSpeed -nerfSpeed;
        }
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //Reset the movement speed, cracked solution but... 
        moveSpeed = 4;
    }
}