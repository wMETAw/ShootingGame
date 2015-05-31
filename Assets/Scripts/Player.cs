using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// speed
	public float speed = 5;
	
	// GameObject
	public GameObject bullet;

	// start is coroutin
	IEnumerator Start () { 

		while (true) {

			// bullet is player pos
			Instantiate (bullet, transform.position, transform.rotation);

			// wait 0.05
			yield return new WaitForSeconds (0.05f);
		}
	
	}
	
	// Update is called once per frame
	void Update () {

		 // right left
		float x = Input.GetAxisRaw ("Horizontal");

		// up down
		float y = Input.GetAxisRaw ("Vertical");

		// move vector
		Vector2 direction = new Vector2 (x, y).normalized;

		// vector * speed
		rigidbody2D.velocity = direction * speed;
	}
}
