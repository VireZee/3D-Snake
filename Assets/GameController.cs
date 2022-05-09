using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    int s = 0;
    int t = 1;
    public Text scoreText;
    public Object tail;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore()
    {
        Debug.Log("Tambah Score");
        s++;
        scoreText.text = "Score: " + s;
    }
    public void AddTail()
    {
        Debug.Log("Tambah Ekor");
        t++;
    }
}