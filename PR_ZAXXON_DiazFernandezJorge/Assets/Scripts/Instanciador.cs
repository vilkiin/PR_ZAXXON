using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instanciador : MonoBehaviour
{

    float intervalo;
    [SerializeField] GameObject[] obstaculos;
    [SerializeField] Transform instantiatePos;

    // Start is called before the first frame update
    void Start()
    {
        intervalo = 0.5f;
        StartCoroutine("CrearColumna");
        
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
            Vector3 newPos = new Vector3(randomX, instantiatePos.position.y, instantiatePos.position.z);
            Instantiate(obstaculos[numAl], newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);


        }


    }





    














}
