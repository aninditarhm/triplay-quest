using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public string category; // Jawa or Sumatra
    public float fallSpeed = 5f; // Kecepatan jatuh

    void Update()
    {
        // Pastikan objek mulai jatuh dari tengah atas layar
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime); // Jatuh ke bawah
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Deteksi jika objek jatuh ke tong Jawa atau Sumatra
        if (other.CompareTag("TongJawa") && category == "Jawa" || other.CompareTag("TongSumatra") && category == "Sumatra")
        {
            GameManager.instance.AddScore(); // Tambah skor jika benar
            Destroy(gameObject);  // Hapus objek
        }
        else if (other.CompareTag("TongJawa") || other.CompareTag("TongSumatra"))
        {
            GameManager.instance.LoseLife(); // Kurangi nyawa jika salah
            Destroy(gameObject);  // Hapus objek
        }
    }
}