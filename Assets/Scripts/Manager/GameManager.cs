using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Manager<GameManager>
{
    public PlayerData playerData;
    public int miniGameOwnSucessScore = 10;
    

    protected override void Awake()
    {
        base.Awake();

        //tryLoad playerData;
        //else 
        playerData = new PlayerData();

    }

    public void MoveScene(int SceneIndex)
    {
        playerData.lastSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (playerData.lastSceneIndex == 1) playerData.LastMainPosition = MainManager.Instance.player.transform.position;
        SceneManager.LoadScene(SceneIndex);
    }
}
