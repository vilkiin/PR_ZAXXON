using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuInicio : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    


    public void Escenas(int escena)
    {
        SceneManager.LoadScene(escena);

    }

    
    public void salir()
    {
        
       Application.Quit();
        
    }
}

