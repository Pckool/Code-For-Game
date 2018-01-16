using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atributes : MonoBehaviour {
    public enum TresholdAction {
        Run, Keep_Going
    }
    public TresholdAction current;

    public string CharName { get; set; }
    public string currentCharName;

    private int MaxAtrbPoints;

    public int currentStrength;
    public int currentAccuracy;
    public int currentWillpower;
    public int currentHunger;

    private Health charHealth;
    private float willPwrPerctg;

    // Initialization
    void Awake () {
        // For now we will set the max willpower and hunger here, but it should be a global variable
        MaxAtrbPoints = 7;

        // ensures characters can never go over the max atribute
        if (currentAccuracy > MaxAtrbPoints) {
            currentAccuracy = MaxAtrbPoints;
        }
        if (currentStrength > MaxAtrbPoints) {
            currentStrength = MaxAtrbPoints;
        }
        if (currentHunger > MaxAtrbPoints) {
            currentHunger = MaxAtrbPoints;
        }
        if (currentWillpower > MaxAtrbPoints) {
            currentWillpower = MaxAtrbPoints;
        }
        charHealth = gameObject.GetComponent<Health>();

        CharName = currentCharName;

    }
	
	// Update is called once per frame
	void Update () {
        WillpowerUpdate();
    }

    private void WillpowerUpdate() {
        /*
         * if you have 0 willpower, you have a chance to retriet at % health
         * if you have 5 willpower, you have a chance to retreat at % health
         * if you have 7 willpower, you have a chance to retreat at % health
         */
        if ( willPwrPerctg != ((float)currentWillpower / (float)MaxAtrbPoints) ) {
            willPwrPerctg = ((float)currentWillpower / (float)MaxAtrbPoints);
            Debug.Log(willPwrPerctg);
        }
            
        // Checks if the current health meets the willpower theshold for an action to be used.
        if (charHealth.CurrentHealth < charHealth.maxHealth - (willPwrPerctg * charHealth.maxHealth)) {

        }
    }
    
}
