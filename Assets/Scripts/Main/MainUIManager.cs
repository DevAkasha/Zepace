using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIManager : Manager<MainUIManager>
{
    protected override bool IsPersistent => false;

    [SerializeField] Image miniGameOneResultView;

    protected override void Awake()
    {
        base.Awake();
        miniGameOneResultView.gameObject.SetActive(false);
    }

    void Start()
    {
        if (GameManager.Instance.playerData.lastSceneIndex == 2) OpenMiniGameOneResultView();

    }

    void OpenMiniGameOneResultView()
    {


        miniGameOneResultView.gameObject.SetActive(true);
    }
}
