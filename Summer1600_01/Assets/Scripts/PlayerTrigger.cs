using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;

public class PlayerTrigger : MonoBehaviour
{


	public FloatData HealthLevel;
	public FloatData EvilPower;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void OnTriggerEnter()
	{
		HealthLevel.Value -= EvilPower.Value;
	
	}

	
		
}

