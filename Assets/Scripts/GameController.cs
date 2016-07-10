using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	[HideInInspector]
	/// <summary>
	/// Affects how fast objcets with the RepeatingBackground Behavior script move.
	/// </summary>
	public static float speedModifier;

	[Header("Obstacle Information")]

	[Tooltip("The obstacle that we will spawn")]
	public GameObject obstacleReference;

	[Tooltip("Min Y value for the obstacle")]
	public float obstacleMinY = -1.3f;

	[Tooltip("Max Y value for the obstacle")]
	public float obstacleMaxY = 1.3f;

	private static Text scoreText;
	private static int score;

	// Use this for initialization
	void Start () {
		speedModifier = 1.0f;
		gameObject.AddComponent<GameStartBehaviour> ();
	}

	/// <summary>
	/// Creates an Obstacle an initializes its position
	/// </summary>
	void CreateObstacle() {
		Instantiate (obstacleReference, new Vector3 (RepeatingBackground.ScrollWidth, 
			Random.Range (obstacleMinY, obstacleMaxY), 0.0f), Quaternion.identity);
	}

	public static int Score {
		get {
			return score;
		} set {
			score = value;
			scoreText.text = score.ToString ();
		}
	}

}
