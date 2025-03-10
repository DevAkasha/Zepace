using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float hignPosY = 1f;
    float lowPosY = -1f;

    float holeSizeMin = 1f;
    float holeSizeMax = 3f;

    [SerializeField] Transform topObject;
    [SerializeField] Transform bottomObject;

    float widthPadding = 4f;

    MiniGameOneManager miniGameOneManager;

    private void Start()
    {
        miniGameOneManager = MiniGameOneManager.Instance;
    }

    public Vector3 SetRandomPlace(Vector3 lastPosition, int obstacleCount)
    {
        float holeSize = Random.Range(holeSizeMin, holeSizeMax);
        float halfHoleSize = holeSize / 2;

        topObject.localPosition = new Vector3(0, halfHoleSize);
        bottomObject.localPosition = new Vector3(0, -halfHoleSize);

        Vector3 placePosition = lastPosition + new Vector3(widthPadding, 0);
        placePosition.y = Random.Range(lowPosY,hignPosY);

        transform.position = placePosition;

        return placePosition;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerOne playerOne = collision.GetComponent<PlayerOne>();
        if (playerOne != null) miniGameOneManager.AddScore(1);
    }
}
