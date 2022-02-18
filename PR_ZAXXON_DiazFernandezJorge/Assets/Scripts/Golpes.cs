using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Golpes : MonoBehaviour
{
    
    [SerializeField] Image lifesImage;
    [SerializeField] Sprite[] lifesSprite;
    public static int vida =3 ;
    InitGame initGame;
    NaveMove naveMove;
    public float desplSpeed;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        // vida = 0;
        // lifesImage.sprite = lifesSprite[vida];
        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (vida >= 0 && vida < lifesSprite.Length)
        {
            lifesImage.sprite = lifesSprite[vida];
            print(vida);
        }
      
       
        
    }
   


}
