using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCloseOnStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().Play("door_1_closed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
