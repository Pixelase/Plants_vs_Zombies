using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	public float MovementSpeed;
	public bool canMove;

	private Animator anim;

	void Start()
	{
		anim = gameObject.GetComponentInChildren<Animator>();
	}

	// Update is called once per frame
	void Update () {
		if(canMove)
		{
			if(anim != null)
			{
				anim.SetBool("canMove", true);
			}

			transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);	
		}
		else if(anim != null)
		{		
			anim.SetBool("canMove", false);
		}
	}
}
