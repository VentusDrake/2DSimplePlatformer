using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpikeScript : MonoBehaviour
{
    public float fallingSpeed;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            Destroy(gameObject);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        fallingSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.down * fallingSpeed * Time.deltaTime);
    }
}
