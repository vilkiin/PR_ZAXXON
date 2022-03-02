using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InitGame : MonoBehaviour
{
    [SerializeField] Text score;
    public static int puntos;
    public GameObject navecita;
    public float desplSpeed;
    public static int numero = 0;
    public static int minuto = 0;
    public static int hora = 0;
    // Start is called before the first frame update

    public float speed = 80f;
    void Start()
    {
        puntos = 0;
        score.text = "score: " + puntos;
        speed = 80f;
        desplSpeed = 20f;
        StartCoroutine("contador");
    }

    // Update is called once per frame
    void Update()
    {
        if (Golpes.vida == 0)
        {
            StopCoroutine("contador");
        }



    }
    private void OnTriggerEnter(Collider other)
    {
        puntos++;
        score.text = "score: " + puntos;
    }


    public IEnumerator Morir()
    {
        while (true)
        {
            
            print("gameOver");
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("GameOver");
        }

    }
    IEnumerator contador()
    {
       
        
        
        while (true)
        {
            print(hora.ToString("D2") + ":" + minuto.ToString("D2") + ":" + numero.ToString("D2"));
            numero++;
            score.text = "Tiempo Sobrevivido " + hora.ToString("D2") + ":" + minuto.ToString("D2") + ":" + numero.ToString("D2");
            yield return new WaitForSeconds(1f);

            if (numero == 20)
                if (numero == 60)
                {
                    numero = 0;
                    minuto++;

                }
            if (minuto == 60)
            {

                minuto = 0;
                hora++;
            }
            if (hora == 23)
            {
                hora = 0;


            }
        }
    }
}

