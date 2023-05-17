using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float moveSpeed = 10.0f;
    private float leftSide = -10.0f;
    private float rightSide = 10.0f;
    private float topSide = 15.0f;
    private float botSide = 0.0f;
    public Transform projectileSpawnPoint;
    public GameObject projectilePrefab;
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
        }
        checkBorder();
        move();
    }

    void move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime  * moveSpeed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * moveSpeed);
    }
    void shoot()
    {
        Instantiate(projectilePrefab, projectileSpawnPoint.position,
            projectilePrefab.transform.rotation);
    }
    void checkBorder()
    {
        if (transform.position.x < leftSide)
        {
            transform.position = new Vector3(leftSide, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > rightSide)
        {
            transform.position = new Vector3(rightSide, transform.position.y, transform.position.z);
        }
        
        if (transform.position.z > topSide)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, topSide);
        }
        
        if (transform.position.z < botSide)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, botSide);
        }
    }
}
