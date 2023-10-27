using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other) 
	{
		Debug.Log("OnTriggerEnter2D");
	}
	
	private void OnTriggerExit2D(Collider2D other) 
	{
		Debug.Log("OnTriggerExit2D");
	}
	
	private void OnTriggerStay2D(Collider2D other) 
	{
		Debug.Log("OnTriggerStay2D");
	}
	
}
