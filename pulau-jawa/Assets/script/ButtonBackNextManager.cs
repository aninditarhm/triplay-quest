using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBackNextManager : MonoBehaviour
{   
    public void PindahKePeta()
    {
        SceneManager.LoadScene("peta");
    }

    public void PindahKeSumatera()
    {
        SceneManager.LoadScene("Sumatera");
    }

    public void PindahKeKalimantan()
    {
        SceneManager.LoadScene("Kalimantan");
    }

    public void PindahKeSulawesi()
    {
        SceneManager.LoadScene("Sulawesi");
    }

    public void PindahKePapua()
    {
        SceneManager.LoadScene("Papua");
    }

    public void PindahKeJawa()
    {
        SceneManager.LoadScene("Jawa");
    }
     public void PindahKeBali()
    {
        SceneManager.LoadScene("Bali");
    }
    public void PindahKeNusaTenggara()
    {
        SceneManager.LoadScene("Nusa Tenggara");
    }
    public void PindahKeMaluku()
    {
        SceneManager.LoadScene("Maluku");
    }
    
}