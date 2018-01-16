using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forgeLights : MonoBehaviour
{
    public Canvas control;

    public Light lForgeLight;

    private void OnMouseUpAsButton()
    {
        control.enabled = true;
    }

    private void OnMouseEnter()
    {
        lForgeLight.intensity = 3.0f;
    
    }

    private void OnMouseExit()
    {
        lForgeLight.intensity = 1.0f;
    
    }

    // Use this for initialization
    void Start ()
    {
        control = GetComponent<Canvas>();
        control.enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void Awake()
    {
        
    }
}
