using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;
    private AudioSource audioSource;

    void Awake()
    {
        // Cek apakah instance sudah ada
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            // Ambil AudioSource dari objek ini
            audioSource = GetComponent<AudioSource>();

            // Pastikan musik langsung main (jika belum)
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            // Hancurkan duplikat jika sudah ada instance
            Destroy(gameObject);
        }
    }
}
