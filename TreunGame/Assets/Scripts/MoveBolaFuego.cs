/*
- Mueve las bolas de fuego hacia abajo
- Destruye las bolas de fuego
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBolaFuego : MonoBehaviour
{
    public float velocidad = 4;
    public GameObject Bala;
    float time = 0.0f;

    void Update()
    {
        // Mueve el objeto hacia abajo según la velocidad y el tiempo transcurrido desde el último fotograma.
        transform.Translate(Vector2.down * velocidad * Time.deltaTime);
        // Aumenta el tiempo según el tiempo transcurrido desde el último fotograma.
        time += Time.deltaTime;
        // Comprueba si el tiempo es mayor a 2 segundos.
        if(time>2){
            Destroy(Bala);
        }
    }
    void OnTriggerEnter2D(Collider2D collision){
        // Comprueba si la etiqueta del objeto colisionado es "Player".
        if(collision.gameObject.tag == "Player"){
            Destroy(Bala);
        }
    }
}