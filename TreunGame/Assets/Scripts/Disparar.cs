using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{

    public Transform controladorDisparo;
    public GameObject[] balas;

    void Update(){
        if(Input.GetKey("e")||Input.GetKey("space")){
            Disparo();
        }
    }

    public void Disparo(){
        Instantiate(balas[Random.Range(0,balas.Length)], controladorDisparo.position, controladorDisparo.rotation);
    }
}
