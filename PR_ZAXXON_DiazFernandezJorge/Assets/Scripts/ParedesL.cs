using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedesL : MonoBehaviour
{
    float speed;

    // Start is called before the first frame update
    void Start()
    {

        speed = GameObject.Find("InitGame").GetComponent<InitGame>().speed;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        float posz = transform.position.z;
        ; if (posz < -25f)
        {

            Destroy(gameObject);

        }


    }





}
