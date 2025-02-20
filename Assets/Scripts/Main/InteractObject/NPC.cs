using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : InteractObject
{
    //대화창을 열고 대화내용을 보여주기 위한 필드
    private string speechContents = "오른쪽에 포탈이 있어";
    private Image speechView;
    private Text speechText;

    protected override void Awake()
    {
        base.Awake();
        speechView = GetComponentInChildren<Image>();
        speechText = GetComponentInChildren<Text>();
    }
    public override void Interact()
    {
        base.Interact();
        speechView.gameObject.SetActive(true);
        speechText.text = speechContents;
    }

    public override void InteractReset()
    {
        base.InteractReset();
        speechView.gameObject.SetActive(false);
        speechText.text = "";
    }

}
