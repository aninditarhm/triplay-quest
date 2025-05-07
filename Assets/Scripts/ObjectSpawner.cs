using System.Collections;  // Pastikan menggunakan IEnumerator
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] jawaObjects;   // Array untuk item Jawa
    public GameObject[] sumatraObjects;  // Array untuk item Sumatra
    public float spawnRate = 1f;        // Waktu antar spawn objek
    private bool isObjectFalling = false;  // Mengatur apakah ada objek yang sedang jatuh

    void Start()
    {
        // Mulai coroutine untuk spawn objek
        StartCoroutine(SpawnObject());
    }

    // Coroutine untuk spawn objek satu per satu
    IEnumerator SpawnObject()
    {
        while (true)
        {
            // Tunggu hingga objek sebelumnya sampai ke tong
            if (!isObjectFalling)
            {
                GameObject selectedObject;

                // Pilih objek secara acak (Jawa atau Sumatra)
                if (Random.Range(0, 2) == 0)
                {
                    // Pilih objek Jawa secara acak
                    selectedObject = jawaObjects[Random.Range(0, jawaObjects.Length)];
                }
                else
                {
                    // Pilih objek Sumatra secara acak
                    selectedObject = sumatraObjects[Random.Range(0, sumatraObjects.Length)];
                }

                // Tentukan posisi spawn di tengah atas layar
                Vector3 spawnPosition = new Vector3(0f, 6f, 0f);  // Posisi X = 0 (tengah), Y = 6 (atas layar)

                // Spawn objek
                GameObject newObject = Instantiate(selectedObject, spawnPosition, Quaternion.identity);
                newObject.GetComponent<FallingObject>().category = selectedObject.CompareTag("Jawa") ? "Jawa" : "Sumatra";

                // Set isObjectFalling ke true agar tidak spawn objek baru sebelum objek sebelumnya selesai
                isObjectFalling = true;

                // Tunggu sampai objek jatuh ke tong dan selesai
                yield return new WaitUntil(() => newObject == null);  // Tunggu hingga objek dihapus
                isObjectFalling = false;  // Set kembali isObjectFalling ke false untuk spawn berikutnya
            }

            // Menunggu waktu spawn berikutnya
            yield return new WaitForSeconds(spawnRate);
        }
    }
}