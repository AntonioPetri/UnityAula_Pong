using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bola : MonoBehaviour
{
    public float velocidade = 10;
    public TMP_Text pontuacaoEsquerda, pontuacaoDireita;
    int pontoEsquerda = 0, pontoDireita = 0;
    void Start()
    {

        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector2(velocidade * x, velocidade * y);
        pontuacaoEsquerda.SetText(pontoEsquerda.ToString());
        pontuacaoDireita.SetText(pontoDireita.ToString());
    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision batida)
    {
        if (batida.gameObject.name == "Left")
        {
            transform.position = new Vector3(0, 1, 9);
            pontoDireita++;
            Start();
        }
        else if (batida.gameObject.name == "Right")
        {
            transform.position = new Vector3(0, 1, 9);
            pontoEsquerda++;
            Start();
        }



    }
}
