using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniOnePotal : InteractObject
{
    protected override void Awake()
    {
        base.Awake();
    }

    public override void Interact()
    {
        base.Interact();
        SceneManager.LoadScene(2);
    }

    public override void InteractReset()
    {
        base.InteractReset();
    }
}
