using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePotal : InteractObject
{
    //유니티 값을 로직에 적용하기 위한 필드
    [SerializeField] int potalIndex;

    public override void Interact()
    {
        base.Interact();
        GameManager.Instance.MoveScene(potalIndex);
    }
}
