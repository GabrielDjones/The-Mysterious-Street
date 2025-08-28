using UnityEngine;

public class Player : MonoBehaviour
{
    private float eixoX;
    private float eixoY;
    public float speed;
    public GameObject bullet;
    private Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>(); 
    }


    void Update()
    {
        eixoX = Input.GetAxisRaw("Horizontal");
        eixoY = Input.GetAxisRaw("Vertical");

        body.linearVelocity = new Vector2(eixoX, eixoY) * speed;

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
