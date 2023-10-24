using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    public CoinSpawnerScript coinSpawnerScript;
    public PlayerMovement playerScore;

    private void Start()
    {
        coinSpawnerScript = GameObject.FindGameObjectWithTag("coinLogic").GetComponent<CoinSpawnerScript>();
        playerScore = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            coinSpawnerScript.coinSpawned = false;
            playerScore.addScore();
            checkScore(playerScore.score);
        }     
    }
    private void checkScore(int score)
    {
        if (score >= 5)
        {
            Time.timeScale = 0f;
            Debug.Log("You WON!!!");
        }
    }
}
