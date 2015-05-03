using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{

	public KeyCode pauseKey;
	public KeyCode exitKey;

	private bool isPaused;

	// Use this for initialization
	void Start ()
	{
		isPaused = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (pauseKey)) {
			Pause ();
		}

		if (Input.GetKeyDown (exitKey)) {
			Exit ();
		}
	}

	void Pause ()
	{
		if (isPaused) {
			isPaused = false;
			Time.timeScale = 1;
		} else {
			isPaused = true;
			Time.timeScale = 0;
		}
	}

	void Exit ()
	{
		Application.Quit ();
	}
}
