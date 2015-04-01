using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public float Cooldown;
	public GameObject projectile;
	public bool hasEnemy;

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
		RaycastHit hit;
		if(Physics.Raycast(transform.position, Vector3.right, out hit, 15F))
		{
			if(hit.transform.tag == "Enemy")
			{	
				if(cd <= 0)
				{
					cd = Cooldown;
					Instantiate(projectile, transform.position, Quaternion.identity);
				}
				hasEnemy = true;

			}
			else if(hit.transform.tag == "Tower")
			{
				Shoot sscr = hit.transform.gameObject.GetComponent<Shoot>();
				if(sscr.hasEnemy)
				{
					hasEnemy = true;
				}
				else
				{
					hasEnemy = false;
				}
			}
			else
			{
				hasEnemy = false;
			}
		}
		else
		{
			hasEnemy = false;
		}

		if(hasEnemy)
		{
			if(cd <= 0)
			{
				cd = Cooldown;
				Instantiate(projectile, transform.position, Quaternion.identity);
			}
		}

	}
}
