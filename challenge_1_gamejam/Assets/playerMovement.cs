using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private float dirX = 0f, dirY = 0f;
    private Rigidbody2D player;
    public float SPEED ;
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

        player.position += new Vector2(dirX/SPEED, dirY/SPEED); 

        //player.velocity = new Vector2(dirX*SPEED, dirY*SPEED);
    }
}
