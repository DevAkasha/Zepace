using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : InteractObject
{
    //��ȭâ�� ���� ��ȭ������ �����ֱ� ���� �ʵ�
    private string speechContents = "�����ʿ� ��Ż�� �־�";
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
