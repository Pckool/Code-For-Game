using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// This is literally only code for moving to the center and stopping at the specified center point/ center box
/// </summary>
public class MoveToMiddle : MonoBehaviour {
    private NavMeshAgent navMeshAgent;
    public Combat attScript;

    // Use this for initialization
    void Awake () {
        navMeshAgent = GetComponent<NavMeshAgent>();
        //inCenter = false;
        attScript = gameObject.GetComponent<Combat>();

        RunToMiddle();
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void RunToMiddle() {
        if (attScript.Attacking == false)
            navMeshAgent.destination = new Vector3(0, gameObject.transform.position.y, 0);
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Center"))
        {
            Physics.IgnoreCollision(gameObject.GetComponentInChildren<SphereCollider>(), collision.collider);
            Debug.Log("I am in the center");
        }
    }
}
