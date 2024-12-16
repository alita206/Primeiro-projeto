using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Random = UnityEngine.Random;
using UnityEngine.UI;
using TMPro;



public class GameController : MonoBehaviour
{
    [SerializeField] private float timeMin = 1f;
    [SerializeField] private float timeMax = 3f;
    [SerializeField] private float timer = 1f;
    [SerializeField] private GameObject obstaculo;
    [SerializeField] private Vector3 posicao;
    [SerializeField] private float posMin = -3.58f;
    [SerializeField] private float posMax = 1.3f;
    [SerializeField] private float meuX = 12.64f;
    [SerializeField] private TextMeshProUGUI levelText;

    //variavel do level
    private int level = 1;

    //variavel de nivel
    [SerializeField] private float proximoLevel = 10f;

    //Variavel dos pontos 
    private float pontos = 0f;

    //variavel do ponto/canvas
    [SerializeField] private TextMeshProUGUI pontosTexto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { //aumentar os pontos
        SistemaDePonto();
        CriandoObstaculo();
        GanhaLevel();
    }

    private void SistemaDePonto()
    {
        pontos += Time.deltaTime;
        Debug.Log(MathF.Round(pontos));
        //passando os pontos para text
        pontosTexto.text = Mathf.Round(pontos).ToString();
    }

    //ganhando o level
    private void GanhaLevel() 
    {
        //passando o level para o texto do level 
        levelText.text = level.ToString();

        // se os pontos for maiores que proximo level então eu aumento o valor do level e depois dobro a quantidade de ponto pro proximo level
        if (pontos > proximoLevel) 
        {
            level++;
            proximoLevel = proximoLevel * 2;
        }

    }

    private void CriandoObstaculo()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Debug.Log("criando");

            timer = Random.Range(timeMax / level , timeMin / level);
      

            posicao.x = meuX;

            posicao.y = Random.Range(posMin, posMax);
            Instantiate(obstaculo, posicao, Quaternion.identity);
        }
    }

    public int Dificuldade()
    {

        return level;

    }
}
