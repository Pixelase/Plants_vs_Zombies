using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public float Cooldown;
	public GameObject projectile;

	private float cd;

	// Use this for initialization
	void Start () {
		cd = Cooldown;	
	}
	
	// Update is called once per frame
	void Update () {
		if(cd > 0)
		{
			cd -= Time.deltaTime;
		}
		else
		{
			RaycastHit hit;
			if(Physics.Raycast(transform.position, Vector3.right, out hit, 15))
			{
				if(hit.transform.tag == "Enemy")
				{			
					cd = Cooldown;
					Instantiate(projectile, transform.position, Quaternion.identity);
				}
			}
		}
	}
}
