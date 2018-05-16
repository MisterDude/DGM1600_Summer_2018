using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class StartAndUpdate : MonoBehaviour
{

	public float Speed;
	public int PowerLevel;
	public string String;
    	
	// Use this for initialization
	void Start () {
		//transform.Rotate(0,Speed,0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Speed,Speed,Speed);
		//transform.Translate(Speed,0,0);
	}
}
