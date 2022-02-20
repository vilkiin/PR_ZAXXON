using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedesL : MonoBehaviour
{
    float speed;
    InitGame initGame;
    // Start is called before the first frame update
    void Start()
    {

        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.right * Time.deltaTime * initGame.speed);

        float posz = transform.position.z;
        ; if (posz < -25f)
        {

            Destroy(gameObject);

        }


    }





}
