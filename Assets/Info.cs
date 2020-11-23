using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public GameObject panel;

    private void OnTriggerEnter(Collider other) {
        panel.SetActive(true);
    }

    private void OnTriggerExit(Collider other) {
        panel.SetActive(false);    
    }
}
