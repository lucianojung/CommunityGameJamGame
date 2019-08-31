using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScreen : MonoBehaviour
{
    public GameObject finishScreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            finishScreen.SetActive(true);
            Time.timeScale = 0f;

        }
    }
}
