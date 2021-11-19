using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{

    float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = GameObject.Find("Nave").GetComponent<NaveMove>().speed;
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        
        float posz = transform.position.z;
;        if (posz < -20f)
        {

            Destroy(gameObject);

        }


    }

    



}
