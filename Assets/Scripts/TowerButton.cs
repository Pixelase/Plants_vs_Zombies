using UnityEngine;
using System.Collections;

public class TowerButton : MonoBehaviour {
	
	private SetTower setscr;
	
	// Use this for initialization
	void Start () {
		setscr = GameObject.Find("MainCamera").GetComponent<SetTower>();
	}
	
	public void Click(int index)
	{
		setscr.Selected = index;
	}
}
