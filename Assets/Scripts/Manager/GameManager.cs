using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Manager<GameManager>
{
    public PlayerData playerData;
    public int miniGameOneSucessScore = 10;
    public int miniGameTwoSucessScore = 0;

    protected override void Awake()
    {
        base.Awake();
        playerData = new PlayerData(); //세이브 로드 개발시 이 스트럭트 사용
    }

    public void MoveScene(int SceneIndex) //씬 전환시 이 메서드 사용해야 함. 개발자가 숙지해야 함.
    {
        playerData.lastSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (playerData.lastSceneIndex == 1) playerData.LastMainPosition = MainManager.Instance.player.transform.position;
        SceneManager.LoadScene(SceneIndex);
    }
}
