using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMove : MonoBehaviour
{

    [SerializeField] float desplSpeed;
    float speed;
   // float limite = 10;
    float rotationSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        desplSpeed = 20f;
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        float desplX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * desplSpeed * desplX, Space.World);
        float desplY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * desplSpeed * desplY, Space.World);
        float desplR = Input.GetAxis("Rotation");
        transform.Rotate(0f, 0f, desplR * Time.deltaTime * -rotationSpeed);

       // transform.Translate(Vector3.forward * Time.deltaTime * speed);

        float posY = transform.position.y;
        float posX = transform.position.x;
        if (posX > 23f && desplX > 0)
        {
            transform.position = new Vector3(23f, transform.position.y, transform.position.z);

        }
        if (posX < -23f && desplX < 0)
        {
            transform.position = new Vector3(-23f, transform.position.y, transform.position.z);

        }
        if (posY > 10f && desplY > 0)
        {
            transform.position = new Vector3(transform.position.x, 10f, transform.position.z);

        }
        if (posY < 0.5f && desplY < 0)
        {
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);

        }
    }



   














}



