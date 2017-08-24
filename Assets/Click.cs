using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour {

	public Text num;
	public Text score;
	public Text who_win;

	int number = 0;

	int num_one = 0;
	int num_two = 0;

	int num_one_score = 0;
	int num_two_score = 0;

	int check = 0;


	public void change(){
		number = Random.Range (0, 10);
		check += 1;

		if (check % 2 == 1) {
			num_one = number;
		} else {
			num_two = number;

			if (num_one > num_two) {
				who_win.text = "player one wins!";
				num_one_score += 1;
				score.text = num_one_score.ToString () + "    _    " + num_two_score.ToString();
			} else if (num_two > num_one) {
				who_win.text = "player two wins!";
				num_two_score += 1;
				score.text = num_one_score.ToString () + "    _    " + num_two_score.ToString();
			} else {
				who_win.text = "fair";
			}

		}



		num.text = number.ToString ();

	}

}
