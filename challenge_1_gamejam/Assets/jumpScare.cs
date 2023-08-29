using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jumpScare : MonoBehaviour
{
    //public GameObject jumpScareImg;
    // Start is called before the first frame update
    void Start()
    {
       // jumpScareImg.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
           // jumpScareImg.SetActive(true);  
            Debug.Log("BOOOO"); 
            StartCoroutine(disableImage());     
        }
    }

    IEnumerator disableImage() {
        yield return new WaitForSeconds(2);
           // jumpScareImg.SetActive(false);
        
    }
    // Update is called once per frame
    
}
