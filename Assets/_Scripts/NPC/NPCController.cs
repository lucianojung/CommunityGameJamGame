using UnityEngine;

namespace Assets._Scripts.NPC
{
    class NPCController : MonoBehaviour
    {
        private BoxCollider2D boxCollider2D;
        [SerializeField]
        private LayerMask playerlayerMask;
        private Rotate rotate;

        private bool LookDirection = false;
        // hier interaktion ausführen

        private void Awake()
        {
            boxCollider2D = GetComponent<BoxCollider2D>();
            rotate = GetComponent<Rotate>();
        }

        private void Update()
        {

            if (IsLookingAtPlayer() == true)
            {
                rotate.StopStartRotate(true);
            }
            else if (IsLookingAtPlayer() == false)
            {
                rotate.StopStartRotate(false);
            }
        }



        private void OnTriggerEnter2D(Collider2D collision)
        {
            // hier interaktionen vlt aufrufen
        }

        private bool IsLookingAtPlayer()
        {
            var rayCast = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, new Vector2(transform.localScale.x, 0), 1.5f, playerlayerMask);
            Debug.DrawRay(transform.position, new Vector3(transform.localScale.x, 0), Color.green);
            return rayCast.collider != null;
        }


    }
}
