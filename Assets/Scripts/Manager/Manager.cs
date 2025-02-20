using UnityEngine;

//Singleton pattern that can be set to DontDestroyOnLoad
public abstract class Manager<T> : MonoBehaviour where T : Manager<T>
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<T>();

                if (instance == null)
                {
                    GameObject singleton = new GameObject(typeof(T).Name);
                    instance = singleton.AddComponent<T>();
                }
            }
            return instance;
        }
    }

    protected virtual bool isPersistent => true;

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = (T)this;

            if (isPersistent)
            {
                DontDestroyOnLoad(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}