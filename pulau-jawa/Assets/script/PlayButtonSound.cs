using UnityEngine;

public class ButtonClickSound : MonoBehaviour
{
    public AudioSource clickSound; // Drag AudioSource ke sini lewat Inspector

    public void PlayClickSound()
    {
        if (clickSound != null)
        {
            clickSound.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource belum di-assign!");
        }
    }
}
