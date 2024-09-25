using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Singleton;

    public string Name;

    private void Awake()
    {
        if(Singleton != null)
        {
            Destroy(gameObject);
            return;
        }

        Singleton = this;
        DontDestroyOnLoad(gameObject);
    }
}
