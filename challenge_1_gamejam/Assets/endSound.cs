using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class endSound : MonoBehaviour
{
    public AudioSource audio;
    public GameObject player;
    // Start is called before the first frame update
    

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player") {
            audio.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
