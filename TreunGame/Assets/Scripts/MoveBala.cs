using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBala : MonoBehaviour
{
    public float velocidad = 5;
    //private float dañoArco;
    //private float dañoEspada;
    //private float dañoPatitos;

    void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);
    }

    //HACER QUE FUNCIONEN LAS COLISIONES
    public void OnTriggerEnter2D(Collider2D collider) {
        if(collider.CompareTag("Dragon")){ //en su momento añadir daño a torre y dragones
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject,0.5f);
            //Hacer daño
        }else if(collider.CompareTag("Finish")){
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject,0.5f);
        }
    }
}
