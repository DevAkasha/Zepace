using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public MainCamera mainCamera;
    public Player player;
    public Vector2 mapMinBound = new Vector2( -7, -3 );
    public Vector2 mapMaxBound = new Vector2( 7, 14 );

    private void Start()
    {
        mainCamera.Init(player.transform, mapMinBound, mapMaxBound);
    }

}
