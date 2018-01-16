using UnityEngine;
using System.Collections;

public class MobTwoScript: MonoBehaviour 
{
	GameObject target;
	
	public float moveSpeed = -3.0f;
	
	
	// Use this for initialization
	void Start ()
	{
        target = GameObject.FindWithTag("mobTeamOne");
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.LookAt (target.transform);
		
		
		if (Vector3.Distance(this.transform.position, target.transform.position)<= 15.0f)
		{
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}
	}
}
