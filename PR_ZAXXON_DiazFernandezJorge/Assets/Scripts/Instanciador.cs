using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instanciador : MonoBehaviour
{

    float intervalo;
    [SerializeField] GameObject[] obstaculos;
    [SerializeField] Transform instantiatePos;

    [SerializeField] int intervaloParedes = 13;
   

    float limiteR = 24f;
    float limiteL = -24f;

    
    // Start is called before the first frame update
    void Start()
    {
        intervalo = 0.2f;
        StartCoroutine("CrearColumna");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Golpes.vida == 0)
        {
            StopCoroutine("CrearColumna");
        }
    }

    IEnumerator CrearColumna()
    {
        int waitWall = intervaloParedes;
        int numAl;
        while (true)
        {
            if(waitWall > 0)
            {
                numAl = Random.Range(0, 9);
            }
            else
            {
                numAl = Random.Range(0, obstaculos.Length);
            }
            
            float randomX = Random.Range(-24f, 24f);
            if (obstaculos[numAl].tag != "Pared" && obstaculos[numAl].tag != "ParedIzq" && obstaculos[numAl].tag != "ParedDer")
            {
                randomX = Random.Range(-24f, 24f);
                waitWall--;
            }
            else
            {
                waitWall = intervaloParedes;
                randomX = 0f;
            }
            
            Vector3 newPos = new Vector3(randomX, instantiatePos.position.y, instantiatePos.position.z);
            Instantiate(obstaculos[numAl], newPos, Quaternion.identity);
            print(obstaculos[numAl].tag + " - " + randomX);

            yield return new WaitForSeconds(intervalo);


        }


    }
   

}
