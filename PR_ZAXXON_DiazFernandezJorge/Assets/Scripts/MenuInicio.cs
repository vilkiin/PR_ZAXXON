using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void LoadScene(string sceneName)
    {

        SceneManager.LoadScene("Tematica");
    }


    public void Jungla()
    {
        SceneManager.LoadScene("Juego");

    }

    public void Desierto()
    {
        SceneManager.LoadScene("JuegoDesierto");

    }
    public void Nieve()
    {
        SceneManager.LoadScene("JuegoNieve");

    }

    public void Configuracion()
    {
        SceneManager.LoadScene("Configuracion");

    }

    public void Inicio()
    {
        SceneManager.LoadScene("Menu");

    }
}

