using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawnScript : MonoBehaviour
{
    public GameObject fallingSpike;
    public Transform playerPosition;
    public float spawnRate;
    private float timer = 0f;
    private float playerPositionOffset = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        spawnSpike();
        spawnRate = 1.2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        } else
        {
            spawnSpike();
            timer = 0f;
        }

        
    }

    void spawnSpike()
    {
        Instantiate(fallingSpike, new Vector3(playerPosition.position.x - playerPositionOffset, transform.position.y, 0), transform.rotation);
    }
}
