using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitGame : MonoBehaviour
{
    [SerializeField] Text score;
    public static int puntos;
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
        score.text = "score: " + puntos;
    }

    // Update is called once per frame
    void Update()
    {
        
    
    

    }
    private void OnTriggerEnter(Collider other)
    {
        puntos++;
        score.text = "score: " + puntos;
    }
}

