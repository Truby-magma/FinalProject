﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("gameover", LoadSceneMode.Single);
    }
}