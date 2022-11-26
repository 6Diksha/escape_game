using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    public GameObject flag;
    Vector3 spawnPoint;
    public GameObject deathParticles;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint=gameObject.transform.position;
    }
    

    

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("CheckPoint")){
            spawnPoint = other.transform.position;
        
        }
    }
    void OnCollisionEnter(Collision other){
        if(other.transform.tag == "Enemy"){
            Instantiate(deathParticles,transform.position,Quaternion.identity);
            
            transform.position=spawnPoint;
        }
    }
}
