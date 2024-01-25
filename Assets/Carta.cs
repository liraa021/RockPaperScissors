using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour
{

    float counter = 0;
    public SpriteRenderer circulo;
    public List<Sprite> listaSprite = new List<Sprite>();



    void Start()
    {

        Debug.Log("Bem-vindo ao jogo");

        circulo.sprite = listaSprite[0];
        
    }


    void Update()
    {
        counter += 0.1f;

        transform.position = new Vector2 (counter, 0);

    }
}
