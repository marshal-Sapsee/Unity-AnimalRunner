using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;

    private float lowerBound = -10.0f;
    
    private float rightBound = 25.0f;
    
    private float leftBound = -25.0f;
    
    private GameManager gameManager;

    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            //gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            //gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x < leftBound)
        {
            //gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
