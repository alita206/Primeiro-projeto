using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private Renderer fundo;

    private float xOffset = 0f;
    private Vector2 texturaoffset;
    private float velocidade = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //pegando o fundo
        fundo = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        xOffset += Time.deltaTime  * velocidade ;

        //passando o x para a textura 
        texturaoffset.x = xOffset;
        // movendo o offset x do meu renderer
        fundo.material.mainTextureOffset = texturaoffset ;

    }
}
