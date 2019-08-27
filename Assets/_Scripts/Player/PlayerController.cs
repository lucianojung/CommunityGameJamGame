using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;

    public float speed;

    private void Awake()
    {
        rigidbody2D = transform.GetComponent<Rigidbody2D>();
        Debug.Log("player");
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("player");
            float jumVelocity = 10f;
            rigidbody2D.velocity = Vector2.up * jumVelocity;
        }
    }

}
