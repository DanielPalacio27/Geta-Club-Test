using System.Linq;
using UnityEngine;

public abstract class ScriptableSingleton<T> : ScriptableObject where T : ScriptableObject
{
    protected static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                var type = typeof(T);
                var instances = Resources.LoadAll<T>(string.Empty);
                _instance = instances.FirstOrDefault();
            }
            return _instance;
        }
    }
}