using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 5;
    public float slowDown = 2;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;

    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //Stuff for animation

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        //sqrMagnitude is supposedly more optimal???
        animator.SetFloat("Speed", movement.sqrMagnitude);

        //Brain-dead stupid solution pretty sure, but it works.
        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1) {
            animator.SetFloat("LastHor",  Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("LastVer",  Input.GetAxisRaw("Vertical"));
        }
        
    }
    //Fixed update for no jittering while moving.
    void FixedUpdate() {

        // Nerf that diagonal nonsense.
        if(movement.x != 0 && movement.y != 0) {
            moveSpeed = moveSpeed -slowDown;
        }

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //Reset the movement speed, cracked solution but... 
        //This isn't gonna bite me in the ass for sure!
        moveSpeed = 5;  

        //Flip the character the way it is facing.
        //Not 100% sure how I figured this out, but it works. For now..

        //Update 29.9-23 - This fucked up camera stuff...
        //Update 3.10-23 - Deprecated as of now, using assetpack. 
        /*
         if (movement.x < 0 && facingRight)
        {
            facingRight = false;
            sprite.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (movement.x > 0 && !facingRight)
        {
            facingRight = true;
            sprite.transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        */
    }
}