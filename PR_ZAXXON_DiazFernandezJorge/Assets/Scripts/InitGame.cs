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

    // Start is called before the first frame update

    public  float speed = 80f;
    void Start()
    {
        puntos = 0;
        score.text = "score: " + puntos;
        speed = 80f;
        desplSpeed = 20f;
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

   
    public IEnumerator Morir()
    {
        while (true)
        {
            print("gameOver");
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("GameOver");
        }

    }
}

