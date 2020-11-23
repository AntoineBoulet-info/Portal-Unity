using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateDoor : MonoBehaviour
{
    public GameObject door;
    
    void OnTriggerEnter(Collider other) 
    {
        door.transform.position += new Vector3 (0, 110, 0);
    }

}
