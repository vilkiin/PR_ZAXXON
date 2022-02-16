using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedesL : MonoBehaviour
{
    float speed;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        speed = GameObject.Find("InitGame").GetComponent<InitGame>().speed;
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        float posz = transform.position.z;
        ; if (posz < -20f)
        {

            Destroy(gameObject);

        }


    }





}
