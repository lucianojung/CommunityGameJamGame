using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinzel_Manager : MonoBehaviour
{
    private readonly int MODULO = 2500;
    private int time_iterator = 0;
    private System.Random r;

    public Renderer blender_Renderer;

    // Start is called before the first frame update
    void Start()
    {
        //blender_Renderer = GetComponent<Renderer>();
        r = new System.Random();
        //register observable Objects
    }

    // Update is called once per frame
    void Update()
    {
        time_iterator = getAndIncrementTime();
        if (time_iterator%MODULO == 0)
        {
            //Debug.Log("Blinzelt bei : " + time_iterator);
            blender_Renderer.enabled = true;
        } else
        {
            blender_Renderer.enabled = false;
        }
    }

    int getAndIncrementTime()
    {
        int max = Math.Min(MODULO - (time_iterator % MODULO), 10);
        time_iterator += r.Next(1, max);

        return time_iterator;
    }
}
