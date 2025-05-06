using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void ChooseGame()
    {
        SceneManager.LoadScene("Play");
    }

    public void ExitToExitScene()
    {
        SceneManager.LoadScene("Exit");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Game1()
    {
        SceneManager.LoadScene("Game1");
    }

    public void Game2()
    {
        SceneManager.LoadScene("Game2");
    }

    public void Game3()
    {
        SceneManager.LoadScene("Game3");
    }
}
