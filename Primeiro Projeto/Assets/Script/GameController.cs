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
            Debug.Log("oi");
            timer = 1f;

            posicao.x = 12.64f;
            posicao.y = Random.Range( posMin, posMax );
            Instantiate(obstaculo, posicao, Quaternion.identity);
        }
    }
}
