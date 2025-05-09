using UnityEngine;
using UnityEngine.SceneManagement;

public class ProvinsiButtonManager : MonoBehaviour
{
    private void LoadSceneAndDestroyMusic(string sceneName)
    {
        GameObject musicPlayer = GameObject.FindWithTag("MusicPlayer");
        if (musicPlayer != null)
        {
            Destroy(musicPlayer);
        }
        SceneManager.LoadScene(sceneName);
    }

    public void PindahKeDenpasar() => LoadSceneAndDestroyMusic("Denpasar");
    public void PindahKeBanten() => LoadSceneAndDestroyMusic("Banten");
    public void PindahKeDIY() => LoadSceneAndDestroyMusic("DIY");
    public void PindahKeJakarta() => LoadSceneAndDestroyMusic("Jakarta");
    public void PindahKeJawaBarat() => LoadSceneAndDestroyMusic("JawaBarat");
    public void PindahKeJateng() => LoadSceneAndDestroyMusic("Jateng");
    public void PindahKeJatim() => LoadSceneAndDestroyMusic("Jatim");
    public void PindahKeKalbar() => LoadSceneAndDestroyMusic("Kalbar");
    public void PindahKeKaltim() => LoadSceneAndDestroyMusic("Kaltim");
    public void PindahKeKalsel() => LoadSceneAndDestroyMusic("Kalsel");
    public void PindahKeKalut() => LoadSceneAndDestroyMusic("Kalut");
    public void PindahKeKalteng() => LoadSceneAndDestroyMusic("Kalteng");
    public void PindahKeMalukuu() => LoadSceneAndDestroyMusic("Malukuu");
    public void PindahKeMalukuUtara() => LoadSceneAndDestroyMusic("MalukuUtara");
    public void PindahKentt() => LoadSceneAndDestroyMusic("ntt");
    public void PindahKentb() => LoadSceneAndDestroyMusic("ntb");
    public void PindahKePapuaTengah() => LoadSceneAndDestroyMusic("PapuaTengah");
    public void PindahKePapuaBarat() => LoadSceneAndDestroyMusic("PapuaBarat");
    public void PindahKePapuaSelatan() => LoadSceneAndDestroyMusic("PapuaSelatan");
    public void PindahKePapuaPegunungan() => LoadSceneAndDestroyMusic("PapuaPegunungan");
    public void PindahKePapuaBaratDaya() => LoadSceneAndDestroyMusic("PapuaBaratDaya");
    public void PindahKePapuaa() => LoadSceneAndDestroyMusic("Papuaa");
    public void PindahKeSulawesiSelatan() => LoadSceneAndDestroyMusic("SulawesiSelatan");
    public void PindahKeSulawesiBarat() => LoadSceneAndDestroyMusic("SulawesiBarat");
    public void PindahKeSulawesiTengah() => LoadSceneAndDestroyMusic("SulawesiTengah");
    public void PindahKeGorontalo() => LoadSceneAndDestroyMusic("Gorontalo");
    public void PindahKeSulawesiTenggara() => LoadSceneAndDestroyMusic("SulawesiTenggara");
    public void PindahKeSulawesiUtara() => LoadSceneAndDestroyMusic("SulawesiUtara");
    public void PindahKeBengkulu() => LoadSceneAndDestroyMusic("Bengkulu");
    public void PindahKeAceh() => LoadSceneAndDestroyMusic("Aceh");
    public void PindahKeSumateraUtara() => LoadSceneAndDestroyMusic("SumateraUtara");
    public void PindahKeSumateraBarat() => LoadSceneAndDestroyMusic("SumateraBarat");
    public void PindahKeRiau() => LoadSceneAndDestroyMusic("Riau");
    public void PindahKeSumateraSelatan() => LoadSceneAndDestroyMusic("SumateraSelatan");
    public void PindahKeJambi() => LoadSceneAndDestroyMusic("Jambi");
    public void PindahKeLampung() => LoadSceneAndDestroyMusic("Lampung");
}
