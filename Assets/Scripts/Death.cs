using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	public bool isTower;
	private Health hscr;
	private Money mscr;
	private EnemyStats escr;

	// Use this for initialization
	void Start () {
		hscr = gameObject.GetComponent<Health>();
		mscr = GameObject.Find("GameLogic").GetComponent<Money>();
		if(!isTower)
		{
			escr = gameObject.GetComponent<EnemyStats>();
		}
	}
	
	// Update is called once per frame
	void Update () {

		if(hscr.health <= 0)
		{
			if(isTower)
			{
				Destroy(gameObject);
			}
			else
			{
				mscr.money += escr.Worth;
				Destroy(gameObject);
			}
		}
	
	}
}
