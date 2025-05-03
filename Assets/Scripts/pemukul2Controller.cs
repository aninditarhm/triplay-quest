using UnityEngine;

public class Pemukul2Controller : MonoBehaviour
{
    public float speed = 5f;
    public float minX = 0f;  // Batas kiri X (garis tengah atau 0)
    public float maxX = 7f;  // Batas kanan X (misalnya, kanan)
    
    public float minY = -3.5f; // Batas bawah Y
    public float maxY = 3.5f;  // Batas atas Y

    void Update()
    {
        // Gerakan horizontal (maju mundur)
        float inputHorizontal = Input.GetAxis("Pemukul 2 Horizontal");
        Vector3 moveHorizontal = new Vector3(inputHorizontal * speed * Time.deltaTime, 0, 0);
        transform.position += moveHorizontal;

        // Gerakan vertikal (naik turun)
        float inputVertical = Input.GetAxis("Pemukul 2 Vertical");
        Vector3 moveVertical = new Vector3(0, inputVertical * speed * Time.deltaTime, 0);
        transform.position += moveVertical;

        // Membatasi gerakan agar pemukul tidak keluar batas horizontal
        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);

        // Membatasi gerakan agar pemukul tidak keluar batas vertikal
        float clampedY = Mathf.Clamp(transform.position.y, minY, maxY);
        transform.position = new Vector3(transform.position.x, clampedY, transform.position.z);
    }
}
