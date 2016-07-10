using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	[HideInInspector]
	/// <summary>
	/// Affects how fast objcets with the RepeatingBackground Behavior script move.
	/// </summary>
	public static float speedModifier;

	// Use this for initialization
	void Start () {
		speedModifier = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
