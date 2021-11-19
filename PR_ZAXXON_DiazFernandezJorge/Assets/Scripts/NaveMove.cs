using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NaveMove : MonoBehaviour
{
    public GameObject disparo;
    public Transform navePos;
    [SerializeField] float desplSpeed;
    public float speed;
    [SerializeField] GameObject nave;
    // float limite = 10;
    float rotationSpeed = 100;
    Obstaculos obstaculos;

    // Start is called before the first frame update
    void Start()
    {
        Golpes.vida = 3;
        desplSpeed = 20f;
         speed = 80f;

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

        float desplZ = 1f;
        Vector3 despl = new Vector3(0, 0, desplZ);
        Vector3 destPos = navePos.position;
        if (Input.GetButtonDown("Disparo"))
        {
            Instantiate(disparo, destPos, Quaternion.identity);
            destPos = destPos + despl;


        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(disparo, destPos, Quaternion.identity);
            destPos = destPos + despl;


        }



    }

    private void OnTriggerEnter(Collider other)
    {
        print("he chocado con " + other.gameObject.tag);
        if (other.gameObject.tag == "Arbol")
        {
            Golpes.vida--;
            Destroy(other.gameObject);
            if (Golpes.vida == 0)
            {
                nave.SetActive(false);
                speed = 0f;
                desplSpeed = 0f;
                StartCoroutine("Morir");


            }


        }

        //Destroy(gameObject);
        // nave.SetActive (false);


    }

    IEnumerator Morir()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("GameOver");
        }
    
    }












}



