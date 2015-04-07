using UnityEngine;
using System.Collections;

public class TileTaken : MonoBehaviour {
	public bool isTaken;
	public GameObject Tower;


	void Start()
	{
		isTaken = false;
	}

	void Update()
	{
		if(Tower != null)
		{
			if(Tower.GetComponent<Health>().health <= 0)
			{
				isTaken = false;
			}
		}
	}
}
