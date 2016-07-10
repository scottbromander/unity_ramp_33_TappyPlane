using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBehaviour : MonoBehaviour {

	[Tooltip("The force which is added when the player jumps")]
	public Vector2 jumpForce = new Vector2 (0, 300);

	/// <summary>
	/// If we have been hit, we can no longer jump
	/// </summary>
	private bool beenHit;

	private Rigidbody2D rigidBody2D;

	// Use this for initialization
	void Start () {
		rigidBody2D = GetComponent<Rigidbody2D> ();
	}

	void LateUpdate(){
		if ((Input.GetKeyUp (KeyCode.Space) || Input.GetMouseButton (0)) && !beenHit) {
			rigidBody2D.velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce (jumpForce);
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		beenHit = true;

		GetComponent<Animator> ().speed = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
