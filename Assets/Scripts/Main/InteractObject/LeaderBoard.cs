using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoard : InteractObject
{
    //����Ƽ ���� ������ �����ϱ� ���� �ʵ�
    [SerializeField] int leaderBoardindex;

    public override void Interact()
    {
        base.Interact();
        MainUIManager.Instance.OpenLeaderBoard(leaderBoardindex);
    }
}

