using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField] private float velocidade = 4f;
    [SerializeField] private GameObject eu;
    [SerializeField] private GameController game;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(eu, 6f);
        game = FindObjectOfType<GameController>();

        

    }

    // Update is called once per frame
    void Update()
    {
        velocidade = 4f + game.Dificuldade();

        transform.position += Vector3.left * Time.deltaTime * velocidade;
        Debug.Log(game.Dificuldade());
    }
}
