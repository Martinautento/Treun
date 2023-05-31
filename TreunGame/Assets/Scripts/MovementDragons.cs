using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDragons : MonoBehaviour
{
    public float velocidadMovimiento=1;
    public Transform[] puntosMovimiento;
    public float distanciaMinima=0.2f;
    private int numeroAleatorio;
    private SpriteRenderer spriterenderer;

    void Start()
    {
        numeroAleatorio = Random.Range(0,puntosMovimiento.Length);
        spriterenderer = GetComponent<SpriteRenderer>();
        Girar();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[numeroAleatorio].position,velocidadMovimiento*Time.deltaTime);
        if(Vector2.Distance(transform.position,puntosMovimiento[numeroAleatorio].position)<distanciaMinima){
            numeroAleatorio = Random.Range(0,puntosMovimiento.Length);
            Girar();
        }
    }

    private void Girar(){
        if(transform.position.x<puntosMovimiento[numeroAleatorio].position.x){
            spriterenderer.flipX=true;
        }else{
            spriterenderer.flipX=false;
        }
    }
}
