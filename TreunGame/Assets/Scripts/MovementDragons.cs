/*
- Movimiento de los dragones por los puntos aleatorios
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDragons : MonoBehaviour
{
    public float velocidadMovimiento=1;
    // Array de puntos de movimiento.
    public Transform[] puntosMovimiento;
    public float distanciaMinima=0.2f;
    private int numeroAleatorio;
    // Componente SpriteRenderer asociado al objeto.
    private SpriteRenderer spriterenderer;

    void Start()
    {
        // Genera un número aleatorio para seleccionar un punto de movimiento.
        numeroAleatorio = Random.Range(0,puntosMovimiento.Length);
        // Obtiene el componente SpriteRenderer adjunto al objeto y lo asigna a "spriterenderer".
        spriterenderer = GetComponent<SpriteRenderer>();
        Girar();
    }

    void Update()
    {
        // Mueve el objeto hacia el punto de movimiento actual con una velocidad determinada.
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[numeroAleatorio].position,velocidadMovimiento*Time.deltaTime);
        // Comprueba si el objeto ha llegado al punto de movimiento actual.
        if(Vector2.Distance(transform.position,puntosMovimiento[numeroAleatorio].position)<distanciaMinima){
            // Genera un nuevo número aleatorio para seleccionar un nuevo punto de movimiento.
            numeroAleatorio = Random.Range(0,puntosMovimiento.Length);
            Girar();
        }
    }

    // Método privado para girar el objeto en función de su posición y el punto de movimiento actual.
    private void Girar(){
        // Comprueba si la posición del objeto es menor que la posición del punto de movimiento actual en el eje x.
        if(transform.position.x<puntosMovimiento[numeroAleatorio].position.x){
            // Voltea horizontalmente el SpriteRenderer para que el objeto mire hacia la derecha.
            spriterenderer.flipX=true;
        }else{
            // No voltea horizontalmente el SpriteRenderer para que el objeto mire hacia la izquierda.
            spriterenderer.flipX=false;
        }
    }
}
