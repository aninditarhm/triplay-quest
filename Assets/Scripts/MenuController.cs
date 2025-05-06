using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Play");
    }
    public void ExitToExitScene()
    {
        SceneManager.LoadScene("Exit");
    }
}
