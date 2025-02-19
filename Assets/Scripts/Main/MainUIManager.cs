using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIManager : Manager<MainUIManager>
{
    protected override bool IsPersistent => false;
    bool isMiniGameOwnResult;

    [SerializeField] Image miniGameOneResultView;
    [SerializeField] Text miniGameOneResult;
    [SerializeField] Text miniGameOneBestScore;

    GameManager gameManager;

    protected override void Awake()
    {
        base.Awake();
        gameManager = GameManager.Instance;
        miniGameOneResultView.gameObject.SetActive(false);
        isMiniGameOwnResult = gameManager.miniGameOwnSucessScore <= gameManager.playerData.MiniGameOneBestScore;
    }

    void Start()
    {
        if (gameManager.playerData.lastSceneIndex == 2) OpenMiniGameOneResultView();
    }

    void OpenMiniGameOneResultView()
    {
        miniGameOneResult.text = isMiniGameOwnResult ? "Success" : "Fail";
        miniGameOneBestScore.text = gameManager.playerData.MiniGameOneBestScore.ToString();
        miniGameOneResultView.gameObject.SetActive(true);
        Invoke(nameof(HideMiniGameOneResultView), 2f);
    }
    void HideMiniGameOneResultView()
    {
        miniGameOneResultView.gameObject.SetActive(false);
    }
}
