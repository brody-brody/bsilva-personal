using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCollectible : MonoBehaviour
{

	public ScoreScript score;
    private const int maxSteps = 1;
	private void OnTriggerEnter2D(Collider2D other)
	{
		RepositionCollectible();
	}
	
	void RepositionCollectible()
	{
		float newX, newY;
		Vector2 newPos = new Vector2();
		for (int i = 0; i < maxSteps; i++) 
		{
			newX = Random.Range(-9, 9);
			newY = Random.Range(-3, 3);
			newPos = new Vector2(newX, newY);
		}
		transform.position = newPos;
		
		score.AddScore();
	}
}