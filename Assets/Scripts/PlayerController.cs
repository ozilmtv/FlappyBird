using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gemaManager;
    private Rigidbody2D playerRB;
    public float Velocity = 1;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            playerRB.velocity = Vector2.up * Velocity;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gemaManager.GameOver();
    }


}

