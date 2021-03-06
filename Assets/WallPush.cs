using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPush : MonoBehaviour {


	public GameObject wallTrap;
	public Transform target;
	public bool inZone = false;

	// Use this for initialization
	void Start () 
	{
		
	}

	// Update is called once per frame
	void Update () 
	{
		if (inZone == true) {	
			transform.position = Vector3.MoveTowards (transform.position, target.position, 1f * Time.deltaTime);
			wallTrap.transform.position = new Vector3 (2.94f, 0.68f, 31.63f);
		}

	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			inZone = true;
		}
	}
	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			inZone = false;
		}
	}
}
