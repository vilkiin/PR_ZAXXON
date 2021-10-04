using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aleatorio : MonoBehaviour
{

    public GameObject prefab;
   // public float gridX = 5f;
   // public float gridY = 5f;
   // public float spacing = 2f;
    public Transform initPos;
    float desplX = 1f; 


    // Start is called before the first frame update
    void Start()
    {
        Vector3 destPos = initPos.position;
        Vector3 despl = new Vector3(desplX, 0, 0) ;
       
        for ( int n = 0; n < 10; n++)
        {
            Instantiate(prefab, destPos, Quaternion.identity);
            destPos = destPos + despl;


        }
        
        
        
        /*
        for (int y = 0; y < gridY; y++)
        {
            for (int x = 0; x < gridX; x++)
            {
                Vector3 pos = new Vector3(x, 0, y) * spacing;
                Instantiate(prefab, pos, Quaternion.identity);
            }




        }
        */
      
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
