using UnityEngine;

public class DataManager : MonoBehaviour
{
    public string username;

    // Encapsulation || ENCAPSULATION
    public static DataManager Instance { get; set; }

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
