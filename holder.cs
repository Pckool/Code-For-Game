using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holder : MonoBehaviour {

    public Canvas inputHolder;

    

    void OnMouseUp()
    {

        inputHolder.enabled = true;

    }

    // Use this for initialization
    void Start () {

        inputHolder = GetComponentInChildren<Canvas>();
        inputHolder.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
