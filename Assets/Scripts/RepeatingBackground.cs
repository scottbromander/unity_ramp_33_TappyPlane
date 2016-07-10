using UnityEngine;

public class RepeatingBackground : MonoBehaviour {
	[Tooltip("How fast the speed should be")]
	public float scrollSpeed;

	/// <summary>
	/// How far to move to until the image is offscreen
	/// </summary>
	public const float ScrollWidth = 8; //bg width / pixels per unit;

	/// <summary>
	/// Called at a fixed time rate, moves the objects and if they are off screen to the things.
	/// </summary>
	private void FixedUpdate() {
		Vector3 pos = transform.position;

		pos.x -= scrollSpeed * Time.deltaTime;

		if(transform.position.x < -ScrollWidth){
			Offscreen (ref pos);
		}

		transform.position = pos;
	}

	/// <summary>
	/// Called whenever the object this is attached to goes completely off-screen
	/// </summary>
	protected virtual void Offscreen(ref Vector3 pos){
		pos.x += 2 * ScrollWidth;
	}
}
