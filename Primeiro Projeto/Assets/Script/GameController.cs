using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GameController : MonoBehaviour
{
    [SerializeField] private float timer = 1f;
    [SerializeField] private GameObject obstaculo;
    [SerializeField] private Vector3 posicao;
    [SerializeField] private float posMin = -3.58f;
    [SerializeField] private float posMax = 1.3f;
    [SerializeField] private float meuX = 12.64f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 )
        {
            Debug.Log("criando");
            timer = 1f;

            posicao.x = meuX;
            posicao.y = Random.Range( posMin, posMax );
            Instantiate(obstaculo, posicao, Quaternion.identity);
        }
    }
}
