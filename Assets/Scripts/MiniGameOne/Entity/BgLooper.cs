using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgLooper : MonoBehaviour
{
    int numBgCount = 5;
    int obstacleCount = 0;
    Vector3 obstacleLastPostion = Vector3.zero;

    void Start()
    {
        Obstacle[] obstacles = GameObject.FindObjectsOfType<Obstacle>();
        obstacleLastPostion = obstacles[0].transform.position;
        obstacleCount = obstacles.Length;

        for (int i = 0; i < obstacleCount; i++)
        {
            obstacleLastPostion = obstacles[i].SetRandomPlace(obstacleLastPostion, obstacleCount);
        } 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggerd" + collision.name);

        if (collision.CompareTag("BackGround"))
        {
            float widthOfBgObject = ((BoxCollider2D)collision).size.x;
            Vector3 pos = collision.transform.position;

            pos.x += widthOfBgObject*numBgCount;
            collision.transform.position = pos;
            return;
        }

        Obstacle obstacle = collision.GetComponent<Obstacle>();
        if (obstacle)
        {
            obstacleLastPostion = obstacle.SetRandomPlace(obstacleLastPostion, obstacleCount);
        }
    }
}
