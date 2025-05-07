using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void AdindaNext()
    {
        SceneManager.LoadScene("CreditAnindita");
    }

    public void AninditaPrevious()
    {
        SceneManager.LoadScene("CreditAdinda");
    }

    public void AninditaNext()
    {
        SceneManager.LoadScene("CreditChallista");
    }

    public void ChallistaPrevious()
    {
        SceneManager.LoadScene("CreditAnindita");
    }

    public void ChallistaNext()
    {
        SceneManager.LoadScene("CreditHasna");
    }

    public void HasnaPrevious()
    {
        SceneManager.LoadScene("CreditChallista");
    }

    public void HasnaNext()
    {
        SceneManager.LoadScene("CreditSalwa");
    }

    public void SalwaPrevious()
    {
        SceneManager.LoadScene("CreditHasna");
    }
}
