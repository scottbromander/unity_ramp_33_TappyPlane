using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameEndBehaviour : MonoBehaviour {

	/// <summary>
	/// Stops the player from quitting the game until a certain amount of time has passed.
	/// </summary>
	private bool canQuit = false;

	// Use this for initialization
	void Start () {
		StartCoroutine (DelayQuit ());
		GameController controller = GameObject.Find("GameController").GetComponent<GameController>();
		controller.CancelInvoke ();
	}
	
	/// <summary>
	/// Checks if the player presses space or clicks the
	/// mouse. If we can restart, we will
	/// </summary>
	void Update () {
		if ((Input.GetKeyUp ("space") || Input.GetMouseButtonDown (0)) && canQuit) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}

	/// <summary>
	/// Delays the player being able to restart instantly
	/// </summary>
	/// <returns>How long to wait before being called again</returns>
	IEnumerator DelayQuit(){
		yield return new WaitForSeconds (.5f);
		canQuit = true;
	}
}
