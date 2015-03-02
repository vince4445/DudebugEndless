using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {

	public Vector2 jumpforce = new Vector2(0,300);
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && rigidbody2D.transform.position.y < 0) {
						print ("hey");
						rigidbody2D.velocity = Vector2.zero;
						rigidbody2D.AddForce(jumpforce);

				}
	}
}
