using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instanciador : MonoBehaviour
{

    float intervalo;
    [SerializeField] GameObject[] obstaculos;
    [SerializeField] Transform instantiatePos;
    [SerializeField] Transform instantiatePos2;
    [SerializeField] Transform instantiatePos3;

    float limiteR = 24f;
    float limiteL = -24f;
    // Start is called before the first frame update
    void Start()
    {
        intervalo = 0.5f;
        StartCoroutine("CrearColumna");
        //StartCoroutine("CrearColumna2");
        //StartCoroutine("CrearColumna3");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CrearColumna()
    {

        while (true)
        {
            int numAl = Random.Range(0, obstaculos.Length);
            float randomX = Random.Range(-24f, 24f);
            if (obstaculos[numAl].tag != "Pared")
            {
                randomX = Random.Range(-24f, 24f);
            }
            else
            {
                randomX = 0f;
            }
            Vector3 newPos = new Vector3(randomX, instantiatePos.position.y, instantiatePos.position.z);
            Instantiate(obstaculos[numAl], newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);


        }


    }
    IEnumerator CrearColumna2()
    {

        while (true)
        {
            int numAl = Random.Range(0, obstaculos.Length);
            float randomX = Random.Range(-24f, 24f);
            if (obstaculos[numAl].tag != "pared")
            {
                randomX = Random.Range(-24f, 24f);
            }
            else
            {
                randomX = 0f;
            }
            Vector3 newPos = new Vector3(randomX, instantiatePos2.position.y, instantiatePos2.position.z);
            Instantiate(obstaculos[numAl], newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);


        }


    }

    IEnumerator CrearColumna3()
    {

        while (true)
        {
            int numAl = Random.Range(0, obstaculos.Length);
            float randomX = Random.Range(-24f, 24f);
            if (obstaculos[numAl].tag != "pared")
            {
                randomX = Random.Range(-24f, 24f);
            }
            else
            {
                randomX = 0f;
            }
            Vector3 newPos = new Vector3(randomX, instantiatePos3.position.y, instantiatePos3.position.z);
            Instantiate(obstaculos[numAl], newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);


        }


    }

















}
