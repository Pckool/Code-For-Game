using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memberManager : MonoBehaviour
{

    public Canvas control;

    //public Canvas inputHolder;



    private void OnMouseEnter()
    {


    }

    private void OnMouseExit()
    {


    }

    // Use this for initialization
    void Start()
    {
        control = GetComponentInParent<Canvas>();
        control.enabled = false;

        //inputHolder.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.enabled == true)
        {
            control.enabled = true;
        }
        else if (this.enabled == false)
        {
            control.enabled = false;
        }
    }

    private void Awake()
    {

    }
}
