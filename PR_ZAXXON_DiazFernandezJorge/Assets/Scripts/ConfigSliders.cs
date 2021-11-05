using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ConfigSliders : MonoBehaviour
{
    public static float volumen;
    public static float efectos;
    public static float brillo;

    [SerializeField] Slider mySlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SubirVolumen()
    {
        volumen = (mySlider.value);
    }
}
