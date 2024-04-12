using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical2") > 0 && (transform.position.y < 11))
        {
            transform.Translate(0, 0.1f, 0);
        }
        else if (Input.GetAxisRaw("Vertical2") < 0 && (transform.position.y > -9))
        {
            transform.Translate(0, -0.1f, 0);
        }
    }
}
