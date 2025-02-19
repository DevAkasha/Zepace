using UnityEngine;

public class MainManager : Manager<MainManager>
{
    protected override bool IsPersistent => false;
    
    public MainCamera mainCamera;
    public Player player;
    public Vector2 mapMinBound = new Vector2(-7, -3);
    public Vector2 mapMaxBound = new Vector2(7, 14);

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        mainCamera.Init(player.transform, mapMinBound, mapMaxBound);
    }

}
