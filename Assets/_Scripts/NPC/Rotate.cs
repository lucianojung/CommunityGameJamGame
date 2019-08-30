using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private float rotateTimer ;
    private float rotateNextSpawn;
    private bool flip = false;
    private bool stopRotate = false;


    private void Awake()
    {
        rotateTimer = Random.Range(4, 10);
        rotateNextSpawn = Random.Range(4, 10);
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldFlip() && stopRotate.Equals(false))
        {
            Flip();
        } 
    }

    // this will be called if the player enters the hitbox
    public void StopStartRotate(bool rotate)
    {
        stopRotate = rotate;
    }

    

    private void Flip()
    {
        flip = !flip;
        rotateNextSpawn = Time.time + rotateTimer;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    public bool ShouldFlip()
    {
        return Time.time >= rotateNextSpawn;
    }
}
