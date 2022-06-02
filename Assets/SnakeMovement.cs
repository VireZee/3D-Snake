using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    none, up, down, left, right, ins, outs
}
public class SnakeMovement : MonoBehaviour
{
    private Snake snake;
    private Direction directionBefore = Direction.none;
    // Start is called before the first frame update
    void Start()
    {
        snake = GetComponent<Snake>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (directionBefore != Direction.outs)
            {
                snake.savePosition();
                transform.Translate(0, 0, 1);
                snake.updatePosition();
                directionBefore = Direction.ins;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (directionBefore != Direction.right)
            {
                snake.savePosition();
                transform.Translate(-1, 0, 0);
                snake.updatePosition();
                directionBefore = Direction.left;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (directionBefore != Direction.ins)
            {
                snake.savePosition();
                transform.Translate(0, 0, -1);
                snake.updatePosition();
                directionBefore = Direction.outs;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (directionBefore != Direction.left)
            {
                snake.savePosition();
                transform.Translate(1, 0, 0);
                snake.updatePosition();
                directionBefore = Direction.right;
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (directionBefore != Direction.down)
            {
                snake.savePosition();
                transform.Translate(0, 1, 0);
                snake.updatePosition();
                directionBefore = Direction.up;
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (directionBefore != Direction.up)
            {
                snake.savePosition();
                transform.Translate(0, -1, 0);
                snake.updatePosition();
                directionBefore = Direction.down;
            }
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
}