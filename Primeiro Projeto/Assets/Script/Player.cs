using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D meuRb;
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private float Max = 5.5f;
    [SerializeField] private float Min = -5.5f;
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
        Morrendo();
        
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

    private void Morrendo() 
    {
        if (transform.position.y > Max || transform.position.y < Min) 
        {

            SceneManager.LoadScene(0);
        }
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("bati");
        SceneManager.LoadScene(0); 
        

    }
}
