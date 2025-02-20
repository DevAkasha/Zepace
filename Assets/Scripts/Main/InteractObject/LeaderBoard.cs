using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoard : InteractObject
{
    //유니티 값을 로직에 적용하기 위한 필드
    [SerializeField] int leaderBoardindex;

    public override void Interact()
    {
        base.Interact();
        MainUIManager.Instance.OpenLeaderBoard(leaderBoardindex);
    }
}

