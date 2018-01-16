using UnityEngine;
using System.Collections;

public class MobOneScript: MonoBehaviour
{
    //public GameObject target;



    public float moveSpeed = 5f;

    public GameObject[] closestMob;

    //float distance = Vector3.Distance(this.transform.position, GameObject.FindGameObjectsWithTag("mobTeamTwo"));

    // Use this for initialization
    void Start ()
	{
        
      

        

	}
	
	// Update is called once per frame
	public void FixedUpdate ()
	{

        //public int closestMobDistance = Mathf.Min(this.transform.position, closestMob.transform.position);
        closestMob = GameObject.FindGameObjectsWithTag("mobTeamTwo");
        //target = GameObject.FindWithTag("mobTeamTwo");
        float distanceMin = float.MaxValue;
        int closestMobIndex = -1;

        for (int i = 0; i < closestMob.Length; i++)
        {

            //The above and below currently feed out the same information.

            float distCheck = Vector3.Distance(closestMob[i].transform.position, this.transform.position);

            if (distCheck < distanceMin)
            {
                distanceMin = distCheck;
                closestMobIndex = i;
            }
           // Debug.Log("Distance Check: " + closestMob[closestMobIndex]);
        }

        //transform.LookAt (target.transform);


        if (Vector3.Distance(this.transform.position, closestMob[closestMobIndex].transform.position)>= 5.0f)
		{
            transform.LookAt(closestMob[closestMobIndex].transform.position);
            transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}

	}


    /*
    private void FixedUpdate()
    {
        for (int i = 0; i < closestMob.Length; i++)
        {
            Debug.Log("Magnitude: " + Vector3.Distance(closestMob[i].transform.position, this.transform.position));
        }
    }
    */

}
