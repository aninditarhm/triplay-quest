using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] jawaObjects;
    public GameObject[] sumatraObjects;
    public float spawnRate = 1f;

    void Start()
    {
        InvokeRepeating("SpawnObject", 1f, spawnRate);
    }

    void SpawnObject()
    {
        GameObject selectedObject;

        if (Random.Range(0, 2) == 0)
        {
            selectedObject = jawaObjects[Random.Range(0, jawaObjects.Length)];
        }
        else
        {
            selectedObject = sumatraObjects[Random.Range(0, sumatraObjects.Length)];
        }

        Vector3 spawnPosition = new Vector3(Random.Range(-7f, 7f), 6f, 0); // Posisi acak pada sumbu X dan Y
        Instantiate(selectedObject, spawnPosition, Quaternion.identity);
    }
}