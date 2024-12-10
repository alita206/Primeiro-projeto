using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D meuRb;
    [SerializeField] private float velocidade = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meuRb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            meuRb.velocity = Vector2.up * velocidade;
        
        }
        if (meuRb.velocity.y <- velocidade)
        { 
            meuRb.linearVelocity = Vector2.down * velocidade;
        }
        
    }
}
