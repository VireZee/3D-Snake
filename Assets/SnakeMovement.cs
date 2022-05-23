using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            transform.Translate(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.Translate(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0, 0, -1);
        }
        if (transform.position.x < 0)
        {
            transform.Translate(1, 0, 0);
        }
        if (transform.position.x > 4)
        {
            transform.Translate(-1, 0, 0);
        }
        if (transform.position.y < 0)
        {
            transform.Translate(0, 1, 0);
        }
        if (transform.position.y > 4)
        {
            transform.Translate(0, -1, 0);
        }
        if (transform.position.z < 0)
        {
            transform.Translate(0, 0, 1);
        }
        if (transform.position.z > 4)
        {
            transform.Translate(0, 0, -1);
        }
    }
}