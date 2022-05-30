using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    private Snake snake;
    private string directionBefore;
    // Start is called before the first frame update
    void Start()
    {
        snake = GetComponent<Snake>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            snake.savePosition();
            transform.Translate(0, 1, 0);
            snake.updatePosition();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            snake.savePosition();
            transform.Translate(-1, 0, 0);
            snake.updatePosition();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            snake.savePosition();
            transform.Translate(0, -1, 0);
            snake.updatePosition();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            snake.savePosition();
            transform.Translate(1, 0, 0);
            snake.updatePosition();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            snake.savePosition();
            transform.Translate(0, 0, 1);
            snake.updatePosition();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            snake.savePosition();
            transform.Translate(0, 0, -1);
            snake.updatePosition();
        }
        if (transform.position.x < 0)
        {
            snake.savePosition();
            transform.Translate(1, 0, 0);
            snake.updatePosition();
        }
        if (transform.position.x > 4)
        {
            snake.savePosition();
            transform.Translate(-1, 0, 0);
            snake.updatePosition();
        }
        if (transform.position.y < 0)
        {
            snake.savePosition();
            transform.Translate(0, 1, 0);
            snake.updatePosition();
        }
        if (transform.position.y > 4)
        {
            snake.savePosition();
            transform.Translate(0, -1, 0);
            snake.updatePosition();
        }
        if (transform.position.z < 0)
        {
            snake.savePosition();
            transform.Translate(0, 0, 1);
            snake.updatePosition();
        }
        if (transform.position.z > 4)
        {
            snake.savePosition();
            transform.Translate(0, 0, -1);
            snake.updatePosition();
        }
    }
    private void saveDirection()
    {
        directionBefore = 
    }
}