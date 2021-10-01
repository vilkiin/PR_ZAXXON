using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instanciador : MonoBehaviour
{

    float intervalo;
    [SerializeField] GameObject columna;
    [SerializeField] Transform instantiatePos;

    // Start is called before the first frame update
    void Start()
    {
        intervalo = 1f;
        StartCoroutine("CrearColumna");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerable CrearColumna()
    {

        while (true)
        {
            print("hola");
            
            Instantiate(columna, instantiatePos);
            
            yield return new WaitForSeconds(intervalo);


        }

    }



}
