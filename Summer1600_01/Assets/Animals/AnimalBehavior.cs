using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehavior : MonoBehaviour
{

	public Animal AnimalInfo;

	void Start()
	{
		print(AnimalInfo.Health);
		print(AnimalInfo.LegCount);
		print(AnimalInfo.Strength);
		
	}

}
