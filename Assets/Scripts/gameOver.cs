using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
	public void startAgain() 
	{
		Debug.Log("start again clicked");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}
	
	public void quit()
	{
		Debug.Log("quit clicked");
		Application.Quit();
	}
}
