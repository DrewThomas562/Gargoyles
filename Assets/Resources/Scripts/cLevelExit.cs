﻿
using UnityEngine;

public class cLevelExit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //OnTriggerEnter2D is sent when another object enters a trigger collider attached to this object (2D physics only).
    private void OnTriggerEnter2D(Collider2D other){
        //Check if the tag of the trigger collided with is Exit.
        if (other.tag == "Player"){
            Invoke("AdvanceLevel",0.5f);
        }
    }

    private void AdvanceLevel() {
        Application.LoadLevel(cGameManager.instance.sceneToLoad);
    }
}
