/*
- Manejo de botones en el menu de Game Over
- Activa el menú de game over cuando el jugador muere
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class ButtonsMenuGameOver : MonoBehaviour
{
    [SerializeField] private GameObject menuGameOver;
    // Variable para almacenar una referencia a un script llamado "BarraVidaFunciones" adjunto al objeto jugador.
    private BarraVidaFunciones vidaJugador;

    private void Start() {
        // Busca el objeto con la etiqueta "Player" y obtiene el componente "BarraVidaFunciones" adjunto a él, asignándolo a "vidaJugador".
        vidaJugador = GameObject.FindGameObjectWithTag("Player").GetComponent<BarraVidaFunciones>();
        // Suscribe el método "ActivarMenu" al evento "MuerteJugador" del script "vidaJugador".
        vidaJugador.MuerteJugador += ActivarMenu;
    }

    private void ActivarMenu(object sender, EventArgs e){
        // Activa el objeto "menuGameOver" para mostrar el menú de Game Over.
        menuGameOver.SetActive(true);
        // Detiene el tiempo en el juego estableciendo Time.timeScale en 0.
        Time.timeScale = 0f;
    }

    public void EscenaJuego(){
        //Dirige a la escena de juego, es decir, reinicia la escena
        SceneManager.LoadScene("Juego");
    }
    public void EscenaCreditos(){
        //Dirige a la escena de creditos
        SceneManager.LoadScene("Creditos");
    }
    public void BackToMenu(){
        //Dirige a la escena del menu
        SceneManager.LoadScene("Menu");
    }
    public void Exit(){
        #if UNITY_EDITOR
        //si está en el editor de unity, desactiva el modo de juego
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        //cierra la aplicacion
                Application.Quit();
        #endif
    }
}