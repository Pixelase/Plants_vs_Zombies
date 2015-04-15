using UnityEngine;
using System.Collections;

public class EnemyDamage : MonoBehaviour
{

	public float damage;
	public float Cooldown;

	private float cd;
	private EnemyMove movscr;
	private Animator anim;

	// Use this for initialization
	void Start ()
	{
		movscr = gameObject.GetComponent<EnemyMove> ();
		anim = gameObject.GetComponentInChildren<Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (cd > 0) {
			cd -= Time.deltaTime;
		}
		RaycastHit hit;
		if (Physics.Raycast (transform.position, Vector3.left, out hit, 0.5F)) {
			if (hit.transform.tag == "Tower") {
				if (cd <= 0) {
					if (anim != null) {
						anim.SetBool ("hasTower", true);
					}

					Health hscr = hit.transform.gameObject.GetComponent<Health> ();
					hscr.health -= damage;
					cd = Cooldown;
				}				
			} else if (hit.transform.tag == "House") {
				GameObject.Find ("GameLogic").GetComponent<GameOver> ().lost = true;
			}
			movscr.canMove = false;
		} else if (movscr.canMove == false) {
			movscr.canMove = true;
			if(anim != null){
				anim.SetBool("hasTower", false);
			}
		}
	}
}
