using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetGame : MonoBehaviour
{
	public void RestartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

	}

	void Update()
	{
		if (Input.GetButtonDown("Fire3"))
		{
			RestartGame();
		}
	}
}
