using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfSliders : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;
    [SerializeField] Text volumenText;
    float volumen;
    [SerializeField] Slider efectosSlider;
    [SerializeField] Text efectosText;
    float efectos;
    [SerializeField] Slider brilloSlider;
    [SerializeField] Text brilloText;
    float brillo;
    // Start is called before the first frame update
    void Start()
    {
        volumenText.text = "Volumen:" + volumeSlider.value;
        efectosText.text = "Efectos:" + efectosSlider.value;
        brilloText.text = "Brillo:" + brilloSlider.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SubirVolumen()
    {
        volumen = (volumeSlider.value);
        volumenText.text = "Volumen:" + volumen;
        
        
    }
    public void SubirEfectos()
    {
        efectos = (efectosSlider.value);
        efectosText.text = "Efectos:" + efectos;

    }
    public void SubirBrillo()
    {
        brillo = (brilloSlider.value);
        brilloText.text = "Brillo:" + brillo;

    }
}

