using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
	public Transform camera;
	public Transform cube;
	public Text scoreText;
	public Text levelText;
	public Text levelPointsText;

	public int levelTwoVal, levelThreeVal;
    // Start is called before the first frame update
    void Start()
    {
        levelTwoVal = camera.GetComponent<paintDroplets>().levelTwoVal;
		levelThreeVal = camera.GetComponent<paintDroplets>().levelThreeVal;
    }

    // Update is called once per frame
    void Update()
    {
		if (cube != null) {
			int score = cube.GetComponent<cubeControl>().totalScore;
			int level = 1;
			if (score >= levelThreeVal) {
				level = 3;
			}
			else if (score >= levelTwoVal) {
				level = 2;
			}
			int levelPoints = 1;
			if (level == 2) {
				levelPoints = 2;
			}
			else if (level == 3) {
				levelPoints = 5;
			}
			scoreText.text = score.ToString();
			levelText.text = level.ToString();
			levelPointsText.text = levelPoints.ToString();
		}
    }
}
