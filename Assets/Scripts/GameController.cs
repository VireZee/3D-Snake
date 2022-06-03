using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private int s = 0;
    public Text scoreText;
    public void AddScore()
    {
        s++;
        scoreText.text = "Score: " + s;
    }
}