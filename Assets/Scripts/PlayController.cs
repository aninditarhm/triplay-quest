using UnityEngine;
using UnityEngine.UI;

public class PlayController : MonoBehaviour
{
    public float moveSpeed = 800f; // Kecepatan gerak
    private RectTransform rectTransform;
    private float minX, maxX;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();

        // Batas kiri-kanan berdasarkan Canvas (Canvas pixel width)
        float canvasWidth = rectTransform.parent.GetComponent<RectTransform>().rect.width;
        float playerWidth = rectTransform.rect.width;

        minX = -(canvasWidth / 2) + (playerWidth / 2);
        maxX = (canvasWidth / 2) - (playerWidth / 2);
    }

    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(input, 0, 0) * moveSpeed * Time.deltaTime;
        rectTransform.anchoredPosition += new Vector2(move.x, 0);

        // Clamp posisi agar tidak keluar dari layar
        float clampedX = Mathf.Clamp(rectTransform.anchoredPosition.x, minX, maxX);
        rectTransform.anchoredPosition = new Vector2(clampedX, rectTransform.anchoredPosition.y);
    }
}
