using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour
{
	public bool lost;

	private WaveManager wavscr;
	private Animator anim;

	void Start ()
	{
		wavscr = gameObject.GetComponent<WaveManager> ();
		anim = GameObject.Find ("Canvas").GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (lost) {
			GameObject[] towers = GameObject.FindGameObjectsWithTag ("Tower");
			GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Enemy");
			GameObject[] projs = GameObject.FindGameObjectsWithTag ("Projectile");

			anim.SetTrigger("GameOver");
			wavscr.CancelInvoke ();

			for (int i = 0; i < towers.Length; i++) {
				Destroy (towers [i]);
			}

			for (int j = 0; j < enemies.Length; j++) {
				Destroy (enemies [j]);
			}

			for (int k = 0; k < projs.Length; k++) {
				Destroy (projs [k]);
			}
		}
	}

	public void Restart()
	{
		Application.LoadLevel(0);
	}
}
