using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoard : InteractObject
{
    [SerializeField] int leaderBoardindex;
    public override void Interact()
    {
        base.Interact();
        MainUIManager.Instance.OpenLeaderBoard(leaderBoardindex);
    }
}

