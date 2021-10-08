using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Reiniciar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Reiniciar el juego con la tecla R
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Juego");
        }
    }
}
