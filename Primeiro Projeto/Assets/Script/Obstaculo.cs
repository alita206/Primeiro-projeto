using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private GameObject eu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(eu, 6f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * velocidade;
    }
}
