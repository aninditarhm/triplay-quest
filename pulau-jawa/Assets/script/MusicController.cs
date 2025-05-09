using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    private static MusicController instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // Ganti angka "2" di bawah sesuai index atau nama scene ketiga (misal scene baju adat)
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            Destroy(gameObject); // Musik berhenti di Scene ke-3
        }
    }
}
