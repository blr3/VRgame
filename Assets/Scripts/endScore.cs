using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endScore : MonoBehaviour
{
	public Text totalScore;
	
    void Update()
    {
		totalScore.text = PlayerPrefs.GetInt("TotalPoints").ToString();
    }
}
