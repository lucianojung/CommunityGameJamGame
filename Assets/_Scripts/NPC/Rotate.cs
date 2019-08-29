using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private float rotateTimer ;
    private float rotateNextSpawn;
    private bool flip = false;


    private void Awake()
    {
        rotateTimer = Random.Range(0, 10);
        rotateNextSpawn = Random.Range(0, 10);
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldSpawn())
        {
            Flip();
        } 
    }

    private void Flip()
    {
        flip = !flip;
        rotateNextSpawn = Time.time + rotateTimer;
        spriteRenderer.flipX = flip;
    }

    private bool ShouldSpawn()
    {
        return Time.time >= rotateNextSpawn;
    }
}
