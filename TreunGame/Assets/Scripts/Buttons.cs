/*
- Funcionalidades de los botones
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public void EscenaJuego(){
        //carga la escena de juego
        SceneManager.LoadScene("Juego");
    }
    public void EscenaCreditos(){
        //carga la escena de creditos
        SceneManager.LoadScene("Creditos");
    }
    public void BackToMenu(){
        //carga la escena de menu
        SceneManager.LoadScene("Menu");
    }
    public void Exit(){
        #if UNITY_EDITOR
        //si está en el editor de Unity desactiva el modo de juego
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        //cierra la aplicación
                Application.Quit();
        #endif
    }
}
