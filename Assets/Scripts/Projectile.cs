using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float MovementSpeed;
	public float Damage;
	public Vector3 initpos;
	public GameObject explosion;

	// Use this for initialization
	void Start () {
		initpos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * MovementSpeed * Time.deltaTime);
		if(Vector3.Distance(transform.position, initpos) > 20)
		{
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.tag == "Enemy")
		{
			col.GetComponent<Health>().health -= Damage;
			//Create Particles
			Destroy(gameObject);
		}
	}
}
