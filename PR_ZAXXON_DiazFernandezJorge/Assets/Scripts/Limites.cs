using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Limites : MonoBehaviour
{
    
    public float intervalo;
    [SerializeField] GameObject columna;
    [SerializeField] Transform instantiatePos;

    // Start is called before the first frame update
    void Start()
    {
        intervalo = 0.23f;
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

            
            Vector3 newPos = new Vector3(instantiatePos.position.x, instantiatePos.position.y, instantiatePos.position.z);
            Instantiate(columna, newPos, columna.transform.rotation);

            yield return new WaitForSeconds(intervalo);


        }


    }


}