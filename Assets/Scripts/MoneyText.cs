using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoneyText : MonoBehaviour {

	private Text text;
	private Money mscr;

	// Use this for initialization
	void Start () {
		text = GetComponent <Text> ();
		mscr = GameObject.Find("GameLogic").GetComponent<Money>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Money: " + mscr.money;
	}
}
