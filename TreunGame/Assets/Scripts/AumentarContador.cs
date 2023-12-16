/*
- Aumenta el contador de dragones
- Avisa cuando ganas y despliega el menu correspondiente
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AumentarContador : MonoBehaviour
{
    // Declaración de una variable entera pública y estática llamada "x" e inicializada en 0.
    public static int x = 0;
    // Declaración de una variable de tipo Text llamada "textoContador"
    Text textoContador;
    // Declaración de un GameObject privado que se mostrará en el Inspector de Unity.
    [SerializeField] private GameObject menuVictory;

    private void Start() {
        // Obtiene el componente de texto adjunto al objeto y lo asigna a la variable "textoContador".
        textoContador = GetComponent<Text>();
    //activa el menú de victoria y detiene el tiempo en el juego.
    }
    private void ActivarYouWIN(){
        // Activa el objeto "menuVictory".
        menuVictory.SetActive(true);
        // Detiene el tiempo en el juego estableciendo Time.timeScale en 0.
        Time.timeScale = 0f;
    }
    private void Update() {
        if(x<100){
            // Actualiza el texto del componente "textoContador" con el valor actual de "x" concatenado con "/100".
            textoContador.text = x + "/100";
        }else{
            // Si el valor de "x" es igual o mayor a 100.
            // Establece el texto del componente "textoContador" en "100/100".
            textoContador.text = "100/100";
            // Llama al método "ActivarYouWIN" para mostrar el menú de victoria.
            ActivarYouWIN();
            x=0;
            textoContador.text = x + "/100";
        }
    }
}