using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class HealthBehavior : MonoBehaviour
{
	public FloatData HealthLevel;
	public Image HealthImage;

	void Start()
	{
		HealthImage = GetComponent<Image>();
	}

	// Update is called once per frame
	void Update ()
	{
		HealthImage.fillAmount = HealthLevel.Value;
	}
}
