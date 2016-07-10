using UnityEngine;
using System.Collections;

public class GameStartBehaviour : MonoBehaviour {

	/// <summary>
	/// A reference to the player object
	/// </summary>
	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Plane");
		player.GetComponent<Rigidbody2D> ().isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)){
			GameController controller = GetComponent<GameController>();
			controller.InvokeRepeating("CreateObstacle", 1f, 1.5f);

			player.GetComponent<Rigidbody2D>().isKinematic = false;

			Destroy(this);
		}
	}
}
