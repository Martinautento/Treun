using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBala : MonoBehaviour
{
    public float velocidad = 5;
    public GameObject Bala;
    float time = 0.0f;

    void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);
        time += Time.deltaTime;
        if(time>2){
            Destroy(Bala);
        }
    }
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Dragon"){
            Destroy(Bala);
        }
    }
}
