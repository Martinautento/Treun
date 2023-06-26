using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    [SerializeField] public float vida = 100;
    //[SerializeField] public BarraVidaFunciones barraVida;



    private void Start() {
        //barraVida.InicializarBarraVida(vida);
    }
    /*public void HacerDaño(float daño){
        vida-=daño;
        barraVida.CambiarVidaActual(vida);
        if(vida<=0){
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "BalaFuegoNormal"){
            HacerDaño(2);
        }else if(collision.gameObject.tag == "BalaFuegoEsquina"){
            HacerDaño(5);
        }
    }*/
}
