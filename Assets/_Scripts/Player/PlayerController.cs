using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;
    private SpriteRenderer spriteRenderer;


    [SerializeField]
    private float speed = 3f;
    [SerializeField]
    private float jumpVelocity = 4f;


    private void Awake()
    {
        
    }

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        HandleMovement();

    }

    private void HandleMovement()
    {
        // Raycast down und nach spriterendere ausrichtung und zu shcauen ob auf boden und ob eine
        // wand vor einem ist
        // wenn boden false und wand true dann mit Taste Strg festhalten


        // W
        // Jump

        // S
        // Crouch

        // A
        // minus X


        // D
        // plus X

        // Space
        // Dash

        // Strg
        // Festhalten

        // E
        // Interact

        // F 
        // Punch

    }

    private void Flip()
    {
        spriteRenderer.flipX = true;
    }


   
}
