using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBolaFuego : MonoBehaviour
{
    public float velocidad = 4;
    public GameObject Bala;
    float time = 0.0f;

    void Update()
    {
        transform.Translate(Vector2.down * velocidad * Time.deltaTime);
        time += Time.deltaTime;
        if(time>2){
            Destroy(Bala);
        }
    }
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            Destroy(Bala);
        }
    }
}