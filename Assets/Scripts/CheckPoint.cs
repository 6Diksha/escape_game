using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint : MonoBehaviour
{

    
    [SerializeField]
    private GameObject capsule;
   // public AudioSource audio;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            capsule.SetActive(false);
        }
    }
}