/*
- Funcionalidades de los botones
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void CambioEscena(string Nombre)
    {
        //Usando "SceneManager" cambiamos de escena mandando el nombre de la escena como parametro
        SceneManager.LoadScene(Nombre);
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
