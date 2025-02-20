using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct PlayerData
{
    public int lastSceneIndex;
    public Vector3 LastMainPosition;

    public int[] MiniGameBestScore;

    public PlayerData(int miniGameCount)
    {
        lastSceneIndex = 0;
        LastMainPosition = Vector3.zero;
        MiniGameBestScore = new int [miniGameCount];
    }
}
