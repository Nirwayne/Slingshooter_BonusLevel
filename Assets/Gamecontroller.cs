using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gamecontroller : MonoBehaviour {

	// canvas with: countdown, score, ItemsGot ( blue, red)
	public GameObject go_objective;
	private Text txt_objective;


	public GameObject blueIcon;
	private Image img_blueIcon;

	public GameObject redIcon;
	private Image img_redIcon;

	public GameObject go_Score;
	private Text txt_Score;
	private int score;
	public GameObject go_countdown;
	private int countdown;

	public GameObject trees;


	void Awake() {
		img_blueIcon = blueIcon.GetComponent<Image>();
		img_redIcon = redIcon.GetComponent<Image>();

		txt_Score = go_Score.GetComponent<Text>();
		txt_objective = go_objective.GetComponent<Text>();
	}
	// find the blue item
	// greyed blue and red icon

	// now find the red item
	// full blue, greyed red icon

	// activate the yellow item
	// full blue and red icon

	public void blueActive() {
		// set blueIcon image to full opacity
		//img_blueIcon.color.a = 1f;
	}
	public void redActive() {
		// set redIcon image to full opacity
		//img_redIcon.color.a = 1f;
	}
	public void yellowActive() {
		// enable GameObject with trees
	}
	
	// "Destroy as many trees as you can within the timelimit.
	// They'll be destroyed short after they hit the ground or fall off from the arena."
	// - show countdown 5 secs big, then set countdown to 60 seconds, add score to canvas


}
