using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public List<GameObject> body;
    public GameObject bodyPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddBody();
        }
    }
    public void CreateSnake()
    {
        AddBody();
    }
    public void AddBody()
    {
        var newBody = Instantiate(bodyPrefab);
        body.Add(newBody);
    }
}