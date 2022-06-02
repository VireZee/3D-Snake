using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public List<GameObject> listBody;
    public GameObject bodyPrefab;
    private Vector3 positionBefore;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void CreateSnake()
    {
        AddBody();
    }
    private void AddBody()
    {
        var newBody = Instantiate(bodyPrefab);
        listBody.Add(newBody);
    }
    public void savePosition()
    {
        positionBefore = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
    public void updatePosition()
    {
        var lastPosition = new Vector3(positionBefore.x, positionBefore.y, positionBefore.z);
        foreach (var body in listBody)
        {
            var bodyPosition = new Vector3(body.transform.position.x, body.transform.position.y, body.transform.position.z);
            body.transform.position = new Vector3(lastPosition.x, lastPosition.y, lastPosition.z);
            lastPosition = new Vector3(bodyPosition.x, bodyPosition.y, bodyPosition.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        AudioController.instance.PlaySFX(0);
        CreateSnake();
    }
}