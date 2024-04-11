﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Render : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        StartCrashSequence();    
    }

    void StartCrashSequence()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }
}
