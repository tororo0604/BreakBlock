﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockScript : MonoBehaviour {

    public GameMaster gameMaster;
    public ScoreScript scoreScript;

    // Start is called before the first frame update
    void Start () {
        gameMaster.blockNum++;
    }

    // Update is called once per frame
    void Update () {

    }

    void OnCollisionEnter (Collision collision) {
        //       if(collision.gameObject.tag == "ball"){
        gameMaster.blockNum--;
        scoreScript.addScore();
        Destroy (gameObject);
        //       }
    }
}