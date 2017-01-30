using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dev_Testing : MonoBehaviour {
    //Spawning Trigger
    public GameObject obj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(obj);
        }
	}
}
