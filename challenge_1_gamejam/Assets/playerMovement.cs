using System.Collections;
using System.Collections.Generic;
using System.Threading;

using UnityEditor.Rendering;
using UnityEngine;

public class playerMovement : MonoBehaviour
{


    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);


    }
}
