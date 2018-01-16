using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Melee : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;

    public Rigidbody swordSlashBasic;

    // Use this for initialization
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("I see an Enemy");
            
        }
    }
}
