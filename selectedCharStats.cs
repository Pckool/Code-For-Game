using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class selectedCharStats : MonoBehaviour {


    
    public int healthCurrent = 1;
    public int healthMaximum = 1;
    public int exp = 1;
    public int expNext = 2;
    public int strength = 1;
    public int aim = 1;
    public int will = 1;
    public int rank = 1;
    public string charClass = "None";
    public string charName = "Chungus";

    Text readoutStats;




    //Text statsList;

    //Button randomizer;

	// Use this for initialization
	void Start () {
        readoutStats = GetComponent<Text>();
	}

    private void Awake()
    {
        //statsList = GetComponent<Text>();
    }

    private void OnMouseUpAsButton()
    {

    }

    // Update is called once per frame
    void Update () {
        //if (Input.GetKeyUp(KeyCode.Space))
        Debug.Log(charName + "     " + charClass + " " + rank + "\n" + "Health: " + healthCurrent + "/" + healthMaximum + "     " + "Exp: " + exp + "/" + expNext + "     " + "Strength: " + strength + "     " + "Aim: " + aim + "     " + "Will: " + will);

        
        //(charName + "     " + charClass + " " + rank + "\n" + "Health: " + healthCurrent + "/" + healthMaximum + "     " + "Exp: " + exp + "/" + expNext + "     " + "Strength: " + strength + "     " + "Aim: " + aim + "     " + "Will: " + will);

        

    }

    
    
}
