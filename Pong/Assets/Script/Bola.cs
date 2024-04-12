using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float velocidade = 10;
    void Start()
    {

        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector2(velocidade * x, velocidade * y);

    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision batida)
    {
        if ((batida.gameObject.name == "Left") || (batida.gameObject.name == "Right"))
        {
            transform.position = new Vector3(0, 1, 9);
            Start();
        }

        
    }
}
