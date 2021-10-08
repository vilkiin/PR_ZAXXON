using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadTiempo : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    bool moving = true;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float tt = Time.time;
        /*if (moving = true)
        {
            transform.position

        }*/
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (tt >= 10)
        {
            moving = false;
            print("hola, mi posicion en z es" + transform.position.z);

        }
        else
        {
            print(Mathf.Round(tt));

        }
    }
}
