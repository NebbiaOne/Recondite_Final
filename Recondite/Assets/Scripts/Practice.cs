using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour 
{
	public float coffeeTemperature = 85;
	public float hotLimitTemperature = 75;
	public float coldLimitTemperature = 30;

	void Start () 
	{
		
	}
	
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();

		coffeeTemperature -= Time.deltaTime * 5;
		
	}

	void TemperatureTest () {
		if(coffeeTemperature > hotLimitTemperature) 
		{
			Debug.Log ("Coffee too hot");
		}
		else if(coffeeTemperature < coldLimitTemperature)
		{
			Debug.Log("Coffee too cold");
		}
		else
		{
			Debug.Log("Coffee just right");
		}
	}}


