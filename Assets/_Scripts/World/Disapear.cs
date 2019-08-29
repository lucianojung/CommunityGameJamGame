using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disapear : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
