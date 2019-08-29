using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Assets._Scripts.Player
{
    class PlayerMovement : MonoBehaviour
    {

        [SerializeField]
        private LayerMask plattformslayerMask;
        private Rigidbody2D rigidbody2D;
        private SpriteRenderer spriteRenderer;
        private BoxCollider2D boxCollider2D;
        private Animator animator;
        private PlayerController controller;



        public float speed;
        public float jumpVelocity;

        private bool jump = false;
        private bool crouch = false;
        private bool isgrounded = false;
        private bool isFacingRight = false;

        [Header("Events")]
        [Space]

        public UnityEvent OnLandEvent;


        private void Awake()
        {
            if (OnLandEvent == null)
            {
                OnLandEvent = new UnityEvent();
            }

        }

        private void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            rigidbody2D = GetComponent<Rigidbody2D>();
            boxCollider2D = GetComponent<BoxCollider2D>();
            animator = GetComponent<Animator>();
            controller = GetComponent<PlayerController>();
        }


        private void Update()
        {
            HandleMovement();
            
        }

        private void FixedUpdate()
        {
            
            if (IsGrounded() == true)
            {
                OnLandEvent.Invoke();
            }
        }

        private void HandleMovement()
        {
            float moveY = 0f;
            float horizontalMove = 0f;
            // Raycast down und nach spriterendere ausrichtung und zu shcauen ob auf boden und ob eine
            // wand vor einem ist
            // wenn boden false und wand true dann mit Taste Strg festhalten


            // W
            // Jump
            if (IsGrounded() && Input.GetKey(KeyCode.W))
            {
                rigidbody2D.velocity = Vector2.up * jumpVelocity;
                animator.SetBool("jump", true);
                //animator.SetBool("crouch", false);
                //if (crouch == true)
                //{
                //    crouch = false;
                //}
            }

            // S
            // Crouch
            //if (Input.GetKeyDown(KeyCode.S))
            //{
            //    boxCollider2D.enabled = crouch;
            //    crouch = !crouch;
            //    animator.SetBool("crouch", crouch);

            //    if (crouch == true)
            //    {
            //        animator.SetBool("crouch", false);
            //        crouch = false;
            //    }
            //}

            // Move with A and D
            horizontalMove = Input.GetAxisRaw("Horizontal");
            animator.SetFloat("speed", Mathf.Abs(horizontalMove));
            if (horizontalMove > 0 && isFacingRight)
            {
                Flip();
            }
            // Otherwise if the input is moving the player left and the player is facing right...
            else if (horizontalMove < 0 && !isFacingRight)
            {
                Flip();
            }


            // Space
            // Dash
            if (Input.GetKey(KeyCode.Space))
            {

            }

            // Strg
            // Festhalten

            // E
            // Interact
            if (Input.GetKey(KeyCode.E))
            {

            }

            // F 
            // Punch
            if (Input.GetKey(KeyCode.F))
            {
                animator.SetBool("punch", true);
            }

            Vector3 moveDir = new Vector3(horizontalMove, moveY);
            transform.position += moveDir * speed * Time.deltaTime;

        }

        private bool IsGrounded()
        {
            var rayCast = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, .1f, plattformslayerMask);
            return rayCast.collider != null;
        }
        private void Flip()
        {
            isFacingRight = !isFacingRight;
            //Vector3 theScale = transform.localScale;
            //theScale.x *= -1;
            //transform.localScale = theScale;
            this.spriteRenderer.flipX = isFacingRight;
        }

        public void OnLanding()
        {
            animator.SetBool("jump", false);
        }


    }
}
