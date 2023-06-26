using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class ButtonsMenuGameOver : MonoBehaviour
{
    [SerializeField] private GameObject menuGameOver;
    private BarraVidaFunciones vidaJugador;

    private void Start() {
        vidaJugador = GameObject.FindGameObjectWithTag("Player").GetComponent<BarraVidaFunciones>();
        vidaJugador.MuerteJugador += ActivarMenu;
    }

    private void ActivarMenu(object sender, EventArgs e){
        menuGameOver.SetActive(true);
        Time.timeScale = 0f;
    }

    public void EscenaJuego(){
        SceneManager.LoadScene("Juego");
    }
    public void EscenaCreditos(){
        SceneManager.LoadScene("Creditos");
    }
    public void BackToMenu(){
        SceneManager.LoadScene("Menu");
    }
    public void Exit(){
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }
}