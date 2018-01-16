using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public int maxHealth;
    public int CurrentHealth { get; set; }

    // Use this for initialization
    void Awake () {
        CurrentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (CurrentHealth <= 0) {
            Death();

        }
	}

    void Death() {
        // This is the method for death.
        // Soon enough it may contain the call for an animation
        Debug.Log("This should be dead.");

    }
}
