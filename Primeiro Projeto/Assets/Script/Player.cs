using UnityEngine;
using UnityEngine.SceneManagement;

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
        Subir();
        veloz();
        
    }
    public void Subir() 
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            meuRb.linearVelocity = Vector2.up * velocidade;

        }


    }

    public void veloz()
    { 
     if (meuRb.linearVelocity.y <- velocidade)
        { 
            meuRb.linearVelocity = Vector2.down * velocidade;
        }
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("bati");
        SceneManager.LoadScene(0); }
}
