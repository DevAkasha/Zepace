using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePotal : InteractObject
{
    //����Ƽ ���� ������ �����ϱ� ���� �ʵ�
    [SerializeField] int potalIndex;

    public override void Interact()
    {
        base.Interact();
        GameManager.Instance.MoveScene(potalIndex);
    }
}
