using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class instructionScreen : MonoBehaviour
{
	public void start()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
	}
}
