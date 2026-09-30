using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{

//     How it works:
// ○	GetComponent<PlayerMovement>() finds the script you wrote in Task 2 on the same GameObject.
// ○	SetFloat("CharacterSpeed", …) sends the Rigidbody's speed to the blend tree every frame, so Idle, Walking and Running blend automatically as the character speeds up and slows down.
// ○	SetBool("IsGrounded", movement.IsGrounded) passes the raycast result to the Animator, which triggers the Falling transitions from Task 5.
// ○	SetTrigger("doRoll") fires the roll when you release Fire1 (left mouse button or left Ctrl).
// ○	The parameter names in the strings must match the Animator parameters exactly, including capital letters.


    private Animator animator; //animation
    private PlayerMovement movement;  // to read isGrounded
    private Rigidbody rb; //read player movement speed

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        movement = GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("CharacterSpeed", rb.linearVelocity.magnitude);

        animator.SetBool("IsGrounded", movement.IsGrounded);

        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("doRoll");
        }
    }
}
