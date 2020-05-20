using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class welcomeScreen : MonoBehaviour
{
	public void start()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void instructions()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
		Debug.Log("should be going to instructions");
	}
}
