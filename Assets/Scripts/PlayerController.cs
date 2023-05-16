using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float moveSpeed = 10.0f;
    private float leftSide = -10.0f;
    private float rightSide = 10.0f;
    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftSide)
        {
            transform.position = new Vector3(leftSide, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > rightSide)
        {
            transform.position = new Vector3(rightSide, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime  * moveSpeed);
    }
}
