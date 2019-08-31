using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;

    private bool isFocus = false;
    private Transform player;
    public LayerMask lazyMask;
    public CircleCollider2D collider1;

    public virtual void Interact()
    {
        //this Methode is ment to be overitten
        Debug.Log("INTERACT");
    }

    void Update()
    {
        bool playerInDistance = Physics2D.OverlapCircle(transform.position, collider1.radius, lazyMask);
        if (playerInDistance)
        {
                Interact();
        }

    }


    //old code
    public void OnFocused (Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
    }

    public void OnDefocused ()
    {
        isFocus = false;
        player = null;
    }
}
