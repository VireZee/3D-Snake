using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Snake : MonoBehaviour
{
    public List<GameObject> listBody;
    public GameObject bodyPrefab;
    private Vector3 positionBefore;
    private AudioSource[] audioSources;
    private void CreateSnake()
    {
        AddBody();
    }
    private void AddBody()
    {
        var newBody = Instantiate(bodyPrefab);
        listBody.Add(newBody);
        updatePosition();
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
        if (other.tag == "Food")
        {
            AudioController.instance.PlaySFX(0);
            CreateSnake();
        }
        if (other.tag == "Over")
        {
            AudioController.instance.PlaySFX(1);
            SceneManager.LoadScene("GameOver");
            audioSources[1].volume = 5;
        }
    }
}