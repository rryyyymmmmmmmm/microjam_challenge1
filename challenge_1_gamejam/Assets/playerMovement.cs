using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private float dirX = 0f, dirY = 0f;
    private Rigidbody2D player;
    private const float SPEED = 4f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirY = Input.GetAxisRaw("Vertical");
        dirX = Input.GetAxisRaw("Horizontal");

        player.velocity = new Vector2(dirX*SPEED, dirY*SPEED);
    }
}
