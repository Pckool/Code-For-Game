using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaylightRandomizer : MonoBehaviour {


	void Start ()
    {
        //new Quaternion(50, UnityEngine.Random.Range(-50, 17), 0, 0);
    }

    private void Awake()
    {
        transform.Rotate(0, UnityEngine.Random.Range(0, -67), 0);

        //transform.rotation = Quaternion.AngleAxis(UnityEngine.Random.Range(-50, 17), Vector3.up);
        //transform.rotation = Quaternion.Euler(UnityEngine.Random.Range(-50, 17), 0, 0);
        //new Quaternion(50, UnityEngine.Random.Range(-50, 17), 0, 0);
    }

    void FixedUpdate ()
    {
        //transform.Rotate(0, UnityEngine.Random.Range(0, -67), 0);
        //transform.rotation = Quaternion.AngleAxis(UnityEngine.Random.Range(-50, 17), Vector3.up);
    }
}
