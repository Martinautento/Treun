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

    [SerializeField] private GameObject menuPausa;

    public void Pausa()
    {
        MovePlayer.isPaused = !MovePlayer.isPaused;
        Time.timeScale = 1f; // Reanuda el tiempo del juego
        menuPausa.SetActive(false);
    }
    

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
}