using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingPlayer : MonoBehaviour
{
    private void Start()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "groundSpikes")
        {
            Debug.Log("You Died!");
            Destroy(gameObject);
            Time.timeScale = 0f;
        } else if (collision.gameObject.tag == "fallingSpikes")
        {
            Debug.Log("You Died!");
            Destroy(gameObject);
            Time.timeScale = 0f;
        }
    }
}
