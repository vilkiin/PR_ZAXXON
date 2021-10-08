using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 70f;

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        float posz = transform.position.z;
        ; if (posz > 195.7f)
        {

            Destroy(gameObject);

        }


    }

    private void OnTriggerEnter(Collider other)
    {


        Destroy(other.gameObject);
        Destroy(gameObject);


    }



}
