using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject[] powerUps;
    
    public float timerSpawn = 1;
    public float spawnRate = 60;

    public Transform DownIzq;
    public Transform DownDer;
    public Transform UpIzq;
    public Transform UpDer;
    public int randomPowerUP;
    public int cantEspadas = 0;



    void Start()
    {
        InvokeRepeating("spawn",timerSpawn,spawnRate);
    }
    public void spawn(){
        Vector3 spawnPosition = new Vector3(0,0,0);
        spawnPosition = new Vector3(Random.Range(DownIzq.position.x,DownDer.position.x),Random.Range(UpDer.position.y,DownIzq.position.y),0);
        //TRes chances para agarrar la espada
        if(cantEspadas<3){
            randomPowerUP=Random.Range(0,2);
            GameObject powerUp = Instantiate(powerUps[randomPowerUP],spawnPosition,gameObject.transform.rotation);
            if(randomPowerUP==1){
                cantEspadas++;
            }

        }else{
            randomPowerUP=Random.Range(0,2);
            if(randomPowerUP==1){
                randomPowerUP=2;
            }
            GameObject powerUp = Instantiate(powerUps[randomPowerUP],spawnPosition,gameObject.transform.rotation);
             
        }
    }
}
