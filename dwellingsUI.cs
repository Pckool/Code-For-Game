using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dwellingsUI : MonoBehaviour
{

    public Canvas control;

    //public Canvas inputHolder;

    private void OnMouseUpAsButton()
    {
        control.enabled = true;
        //inputHolder.enabled = !inputHolder.enabled;
    }

    private void OnMouseEnter()
    {
        

    }

    private void OnMouseExit()
    {
        

    }

    // Use this for initialization
    void Start()
    {
        control = GetComponentInChildren<Canvas>();
        control.enabled = false;

        //inputHolder.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {

    }
}
