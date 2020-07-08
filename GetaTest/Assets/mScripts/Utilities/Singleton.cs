using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    [SerializeField] private bool dontDestroyOnLoad = false;

    private static T instance = null;
    public static T Instance { get => instance; }

    protected virtual void Awake()
    {
        if (Instance == null)
        {
            instance = this as T;
        }
        else
        {
            if (dontDestroyOnLoad)
                Destroy(gameObject);
            else
                Destroy(this);
        }

        if (dontDestroyOnLoad)
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
