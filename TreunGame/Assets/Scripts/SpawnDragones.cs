using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDragones : MonoBehaviour
{
    public GameObject[] dragones;
    public Transform DownIzq;
    public Transform DownDer;
    public Transform UpIzq;
    public Transform UpDer;
    
    public float timerSpawn = 1;
    public float spawnRate = 20;

    private int cantDragones=6;
    private int randomDragon;

    void Start()
    {
        InvokeRepeating("spawn",timerSpawn,spawnRate);
    }
    public void spawn(){
        if(cantDragones>0){
            Vector3 spawnPosition = new Vector3(0,0,0);
            spawnPosition = new Vector3(Random.Range(DownIzq.position.x,DownDer.position.x),Random.Range(UpDer.position.y,DownIzq.position.y),0);
            randomDragon=Random.Range(0,1);
            GameObject dragon = Instantiate(dragones[randomDragon],spawnPosition,gameObject.transform.rotation);
            cantDragones--;
        }
    }
}
