using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace RG
{
    public class ClickToMove : MonoBehaviour {

        private Animator anim;
        private NavMeshAgent navMeshAgent;
        private Transform targetedEnemy;
        private Ray shootRay;
        private RaycastHit shootHit;
        private bool walking;
        private bool enemyClicked;
        private float nextFire;

        // Use this for initialization
        void Awake () {
            anim = GetComponent<Animator>();
            navMeshAgent = GetComponent<NavMeshAgent>();

	    }
	
	    // Update is called once per frame
	    void Update () {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Input.GetButtonDown("Fire2")){
                if (Physics.Raycast(ray, out hit, 1000)){
                    if (hit.collider.CompareTag("Enemy"))
                    {
                        targetedEnemy = hit.transform;
                        enemyClicked = true;
                    }
                    else
                    {
                        walking = true;
                        enemyClicked = false;
                        navMeshAgent.destination = hit.point;
                        navMeshAgent.isStopped = false;
                    }
                }
            }
	    }
    }
}

