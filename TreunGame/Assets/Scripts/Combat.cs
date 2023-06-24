using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float maximoVida;
    [SerializeField] private BarraVidaFunciones barraVida;

    private void Start() {
        vida = maximoVida;
        barraVida.InicializarBarraVida(vida);
    }
    public void HacerDaño(float daño){
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
    }
}
