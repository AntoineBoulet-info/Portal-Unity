using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal2 : MonoBehaviour
{
    public GameObject portal;
    
    void OnTriggerEnter(Collider other) 
    {
        portal.SetActive(true);
    }

}
