using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Manager<GameManager>
{
    public PlayerData playerData;
    int miniGameCount = 2;
    public int[] miniGameSucessScore;

    protected override void Awake()
    {
        base.Awake();
        playerData = new PlayerData(miniGameCount); //세이브 로드 개발시 이 스트럭트 사용
        miniGameSucessScore = new int[] { 10, 0 };
    }

    public void MoveScene(int SceneIndex) //씬 전환시 이 메서드 사용해야 함. 개발자가 숙지해야 함.
    {
        playerData.lastSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (playerData.lastSceneIndex == 1) playerData.LastMainPosition = MainManager.Instance.player.transform.position;
        SceneManager.LoadScene(SceneIndex);
    }
}
