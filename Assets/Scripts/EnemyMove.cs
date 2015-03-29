using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	public float MovementSpeed;
	
	// Update is called once per frame
	void Update () {

		transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);	
	}
}
