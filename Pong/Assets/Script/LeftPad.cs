using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pads : MonoBehaviour
{
    
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetAxisRaw("Vertical") > 0 && (transform.position.y<11))
        {
            transform.Translate(0, 0.1f, 0);
        }
        else if (Input.GetAxisRaw("Vertical") < 0 && (transform.position.y>-9))
        {
            transform.Translate(0, -0.1f, 0);
        }
        
    }
}
