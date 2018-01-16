using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Combat : MonoBehaviour {

    public bool meleeTroop;
    public bool Attacking { get; set; }
    private SphereCollider detector;
    private NavMeshAgent navMeshAgent;
    public GameObject targetedEnemy;
    private Rigidbody rigbody;

    public float detectionRadius;
    public float fireRate;
    private float nextFire;
    public int damage;

    // Testing sword attack prefab spawn. Comment out if desired.
    public Rigidbody swordSlashBasic;
    public Transform characterPosition;


    // Use this for initialization
    void Awake () {
        detector = gameObject.GetComponentInChildren<SphereCollider>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        rigbody = gameObject.GetComponent<Rigidbody>();
        Attacking = false;
    }
	
	// Update is called once per frame
	void Update () {
        // Sets attacking to off if there is no enemy targeted/enemy targeted is dead (removed from the scene)
        if (targetedEnemy == null)
            Attacking = false;
        

        // When attacking
        if (Attacking) {
            // If it is a melee troop
            if (meleeTroop) {
                // If we are moving at 3.5 speed
                if (navMeshAgent.speed == 3.5) {
                    // speed it up 
                    navMeshAgent.speed = 5;
                }

                // if we have reached the attack threshold radius, and the timer allows an attack: then attack
                if (detector.radius <= 1.5 && Time.time > nextFire) {
                    Attack(damage);
                    nextFire = Time.time + fireRate;

                    //Lines for instantiating attack prefabs.
                    Instantiate(swordSlashBasic, characterPosition.position, characterPosition.rotation);


                }
            }
            // if not a melee troop
            else {
                if (Time.time > nextFire) {
                    Attack(damage);
                    nextFire = Time.time + fireRate;
                }
            }

        }
        // When not attacking
        else if (Attacking == false){
            // If it is a melee troop
            if (meleeTroop) {
                detector.radius = detectionRadius;
                rigbody.freezeRotation = false;
                if (navMeshAgent.speed == 5) {
                    // speed it up 
                    navMeshAgent.speed = 3.5F;
                }
            }
            // if not a melee troop
            else {

            }
                

        }
        
	}

    private void OnTriggerEnter(Collider other) {
        // check for enemy game tag
        if (other.CompareTag("Enemy")){
            if (targetedEnemy == null)
                targetedEnemy = other.gameObject; // stored the enemy found in targetedEnemy

            // You are now attacking
            Attacking = true;

            // If it is a melee troop
            if (meleeTroop) {
                navMeshAgent.destination = targetedEnemy.GetComponent<Transform>().position;

                // if the detector has a radius greater than 1.5
                if (detector.radius > 1.5)
                    detector.radius = Vector3.Distance(gameObject.transform.position, other.transform.position) - 1F;
                // if the detector does not have a radius greater than 1.5
                else {
                    navMeshAgent.destination = gameObject.transform.localPosition;
                    rigbody.freezeRotation = true;
                }
            }
            // if not a melee troop
            else {
                navMeshAgent.destination = gameObject.transform.localPosition;
                rigbody.freezeRotation = true;
            }

        }
    }

    public void Attack( int damage ) {
        GameObject damageMe = targetedEnemy;
        Health healthOfTarget = damageMe.GetComponent<Health>();
        healthOfTarget.CurrentHealth = healthOfTarget.CurrentHealth - damage;
    }
}
