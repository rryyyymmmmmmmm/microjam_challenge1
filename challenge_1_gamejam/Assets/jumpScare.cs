using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class jumpScare : MonoBehaviour
{
    public GameObject jumpScareImg;
    public GameObject current;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
       jumpScareImg.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player") {
            Transform tempTrans = jumpScareImg.transform;
            tempTrans.position = other.transform.position;
            var jumpScareTemp = Instantiate(jumpScareImg, tempTrans);
            jumpScareTemp.SetActive(true);
            jumpScareImg.SetActive(true);
            audio.Play();
            Debug.Log(jumpScareTemp.layer); 
            StartCoroutine(disableImage());     
        }
    }
    IEnumerator disableImage() {
        yield return new WaitForSeconds(2);
           jumpScareImg.SetActive(false);
        
    }
    // Update is called once per frame
}
