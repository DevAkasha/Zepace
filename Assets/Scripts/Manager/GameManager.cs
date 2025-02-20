using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Manager<GameManager>
{
    //Use this Struct when deveploping Save&Load
    public PlayerData playerData;
    int miniGameCount = 2;
    public int[] miniGameSucessScore;

    protected override void Awake()
    {
        base.Awake();
        //Load timing
        playerData = new PlayerData(miniGameCount); 
        miniGameSucessScore = new int[] { 10, 0 };
    }

    //This method must be used when switching scenes
    public void MoveScene(int SceneIndex)
    {
        playerData.lastSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (playerData.lastSceneIndex == 1) playerData.LastMainPosition = MainManager.Instance.player.transform.position;
        SceneManager.LoadScene(SceneIndex);
    }
}
