using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorIntro : MonoBehaviour
{
    public GameObject door;
    
    void OnTriggerEnter(Collider other) 
    {
        door.transform.position += new Vector3 (0, 4, 0);
    }

    void OnTriggerExit(Collider other) {
        door.transform.position -= new Vector3 (0, 4, 0);
        
    }

}
