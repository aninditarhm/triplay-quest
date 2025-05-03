using UnityEngine;
public class BallController : MonoBehaviour
{
    public int force;
    Rigidbody2D rigid;
    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Vector2 arah = new Vector2(2, 0).normalized;
        rigid.AddForce(arah * force, ForceMode2D.Impulse); // Ini hanya dipanggil sekali
    }
    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "TepiKanan")
        {
            ResetBall();
            Invoke("ArahKiri", 1f);
        }
        if (coll.gameObject.name == "TepiKiri") 
        {
            ResetBall();
            Invoke("ArahKanan", 1f);
        }
        
        // Untuk pemukul, tetap sama
        if (coll.gameObject.tag == "Pemukul")
        {
            Debug.Log("Bola terkena pemukul!");
            // Tambahkan efek pantulan, perubahan arah, dll di sini
            Vector2 direction = (coll.transform.position - transform.position).normalized;
            rigid.AddForce(direction * force, ForceMode2D.Impulse);
        }

        // Untuk pemukul, tetap sama
    }

    void ArahKanan()
    {
        Vector2 arah = new Vector2(2, 0).normalized;
        rigid.AddForce(arah * force, ForceMode2D.Impulse);
    }

    void ArahKiri()
    {
        Vector2 arah = new Vector2(-2, 0).normalized;
        rigid.AddForce(arah * force, ForceMode2D.Impulse);
    }
    void ResetBall()
    {
        transform.localPosition = new Vector2(0, 0);
        rigid.linearVelocity = Vector2.zero;
    }
}

