using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCloseOnStart : MonoBehaviour

{
    public String state;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().Play(state);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
