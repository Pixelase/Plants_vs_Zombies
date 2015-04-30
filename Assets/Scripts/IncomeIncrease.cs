using UnityEngine;
using System.Collections;

public class IncomeIncrease : MonoBehaviour {

	public float Cooldown;
	public float income;

	private float cd;
	private Money mscr;


	// Use this for initialization
	void Start () {
		mscr = GameObject.Find("GameLogic").GetComponent<Money>();
		cd = Cooldown + Random.Range(-2, 1);
	}
	
	// Update is called once per frame
	void Update () {
		if(cd > 0)
		{
			cd -= Time.deltaTime;
		}
		else
		{
			cd = Cooldown + Random.Range(-2, 1);
			mscr.money += income;
		}
	
	}
}
