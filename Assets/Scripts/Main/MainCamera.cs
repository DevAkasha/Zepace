using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    //target을 따라가기 위한 필드
    public Transform target;
    public float speed = 5f;

    //영역을 제한하기 위한 필드
    Vector2 minBound; // x,y 최소값 
    Vector2 maxBound; // x,y 최대값
    int positionZ = -10;

    public void Init(Transform target, Vector2 minBound, Vector2 maxBound)
    {
        this.target = target;
        this.minBound = minBound;
        this.maxBound = maxBound;
    }

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, positionZ);
        Vector3 position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);

        position.x = Mathf.Clamp(position.x, minBound.x, maxBound.x);
        position.y = Mathf.Clamp(position.y, minBound.y, maxBound.y);

        transform.position = position;
    }
}
