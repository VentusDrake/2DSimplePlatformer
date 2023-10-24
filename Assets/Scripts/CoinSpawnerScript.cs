using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnerScript : MonoBehaviour
{
    public GameObject[] coinSpawnPoints;
    public GameObject coinPrefab;
    public bool coinSpawned = false;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        spawnCoin();
        coinSpawned = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!coinSpawned)
        {
            spawnCoin();
            coinSpawned = true;
        }
    }

    void spawnCoin()
    {
        index = Random.Range(0, coinSpawnPoints.Length);
        Instantiate(coinPrefab, new Vector3(coinSpawnPoints[index].transform.position.x, coinSpawnPoints[index].transform.position.y, 0), transform.rotation);
    }
}
