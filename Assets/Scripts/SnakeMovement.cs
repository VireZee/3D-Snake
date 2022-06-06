using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Direction
{
    none, up, down, left, right, ins, outs
}
public class SnakeMovement : MonoBehaviour
{
    private int counterFrame;
    private Snake snake;
    private Direction directionBefore = Direction.none;
    // Start is called before the first frame update
    void Start()
    {
        snake = GetComponent<Snake>();
        Application.targetFrameRate = 30;
    }
    // Update is called once per frame
    void Update()
    {
        if (counterFrame > 10)
        {
            counterFrame = 0;
            snake.savePosition();
            switch (directionBefore)
            {
                case Direction.right:
                    transform.Translate(1, 0, 0);
                    break;
                case Direction.left:
                    transform.Translate(-1, 0, 0);
                    break;
                case Direction.up:
                    transform.Translate(0, 1, 0);
                    break;
                case Direction.down:
                    transform.Translate(0, -1, 0);
                    break;
                case Direction.ins:
                    transform.Translate(0, 0, 1);
                    break;
                case Direction.outs:
                    transform.Translate(0, 0, -1);
                    break;
            }
            snake.updatePosition();
        }
        else
        {
            counterFrame++;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (directionBefore != Direction.outs)
            {
                directionBefore = Direction.ins;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (directionBefore != Direction.right)
            {
                directionBefore = Direction.left;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (directionBefore != Direction.ins)
            {
                directionBefore = Direction.outs;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (directionBefore != Direction.left)
            {
                directionBefore = Direction.right;
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (directionBefore != Direction.down)
            {
                directionBefore = Direction.up;
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (directionBefore != Direction.up)
            {
                directionBefore = Direction.down;
            }
        }
        if (transform.position.x < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        if (transform.position.x > 4)
        {
            SceneManager.LoadScene("GameOver");
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