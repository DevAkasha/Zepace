using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePotal : InteractObject
{
    [SerializeField] int potalIndex;
    public override void Interact()
    {
        base.Interact();
        GameManager.Instance.MoveScene(potalIndex);
    }
}
