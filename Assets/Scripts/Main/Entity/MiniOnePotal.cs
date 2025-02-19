using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniOnePotal : InteractObject
{
    public override void Interact()
    {
        base.Interact();
        GameManager.Instance.MoveScene(2);
    }
}
