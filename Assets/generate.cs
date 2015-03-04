using UnityEngine;
using System.Collections;

public class generate : MonoBehaviour {

	public GameObject rocks;
	private int score = 0;

	void Start () {
		InvokeRepeating ("CreateObsticle", 1f, 1.5f);

	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void CreateObsticle() {
		Instantiate (rocks);
		score++;
		print (score);
       }

}