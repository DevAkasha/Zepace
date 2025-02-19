using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniOnePotal : InteractObject
{
    public override void Interact()
    {
        base.Interact();
        SceneManager.LoadScene(2);
    }
}
