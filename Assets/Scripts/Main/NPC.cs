using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : InteractObject
{
    private string info = "오른쪽에 포탈이 있어";
    private Image infoImage;
    private Text infoText;

    protected override void Awake()
    {
        base.Awake();
        infoImage = GetComponentInChildren<Image>();
        Debug.Log("[NPC] Awake 실행됨");
        infoText = GetComponentInChildren<Text>();
    }
    public override void Interact()
    {
        base.Interact();
        infoImage.gameObject.SetActive(true);
        infoText.text = info;
    }

    public override void InteractReset()
    {
        base.InteractReset();
        infoImage.gameObject.SetActive(false);
        infoText.text = "";
    }

}
