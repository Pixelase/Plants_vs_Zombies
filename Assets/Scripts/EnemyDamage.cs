using UnityEngine;
using System.Collections;

public class EnemyDamage : MonoBehaviour {

	private EnemyMove movscr;
	public float damage;
	public float Cooldown;
	private float cd;

	// Use this for initialization
	void Start () {
		movscr = gameObject.GetComponent<EnemyMove>();
	}
	
	// Update is called once per frame
	void Update () {
		if(cd > 0)
		{
			cd -= Time.deltaTime;
		}
		RaycastHit hit;
		if(Physics.Raycast(transform.position, Vector3.left, out hit, 0.5F))
		{
			if(hit.transform.tag == "Tower")
			{
				if(cd <= 0)
				{
					Health hscr = hit.transform.gameObject.GetComponent<Health>();
					hscr.health -= damage;
					cd = Cooldown;
				}
				
			}
			else if(hit.transform.tag == "House")
			{
				//Lose game;
			}
			movscr.canMove = false;
		}
		else if(movscr.canMove == false)
		{
			movscr.canMove = true;
		}
	}
}
