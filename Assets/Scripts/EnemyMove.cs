using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	public float MovementSpeed;
	public bool canMove;
	
	// Update is called once per frame
	void Update () {
		if(canMove)
		{
			transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);	
		}
	}
}
