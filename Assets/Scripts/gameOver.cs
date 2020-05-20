using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
	public void startAgain()
	{
		// Jump to main game scene
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}

	public void quit()
	{
		Application.Quit();
	}
}
