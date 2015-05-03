using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WaveText : MonoBehaviour {
	
	private Text text;
	private WaveManager wavescr;
	
	// Use this for initialization
	void Start () {
		text = GetComponent <Text> ();
		wavescr = GameObject.Find("GameLogic").GetComponent<WaveManager>();
	}

	void FixedUpdate () {
		text.text = "Wave " + (float)(wavescr.wavesCount + 1);
	}
}
