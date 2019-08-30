using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class changeOpacity : MonoBehaviour
{

    float timeLeft;
    [SerializeField]
    float nexttimeLeft;
    Color newColor;

    private Image Image;
    void Start()
    {
        nexttimeLeft = Random.Range(2, 6);
        timeLeft = nexttimeLeft;
        Image = GetComponent<Image>();
        newColor = Image.color;
    }

    void Update()
    {
        if (timeLeft <= Time.deltaTime)
        {
            Change();
        }
        else
        {
            Image.color = Color.Lerp(Image.color, newColor, Time.deltaTime / timeLeft);
            timeLeft -= Time.deltaTime;
        }

    }

    // 0.9 - 0.3
    private void Change()
    {
        Image.color = newColor;
        //Image.color = new Color(Image.color.r, Image.color.g, Image.color.b, nextAlphaValue);
        newColor = new Color(Random.Range(0.3f, 1f), Random.Range(0.3f, 1f), Random.Range(0.3f, 1f), Random.Range(0.3f, 0.9f));
        timeLeft = nexttimeLeft = Random.Range(2, 6);
    }

}
