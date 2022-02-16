using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheider : MonoBehaviour
{

    [SerializeField] Material mat;
    [SerializeField]  float speed;


    // Start is called before the first frame update
    void Start()
    {
        speed = -16f;
       
    }

    // Update is called once per frame
    void Update()
    {
        mat.SetFloat("Vector1_36714c9cee7b422984024c19eb3681ce", speed);
    }
}
