using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class timer : MonoBehaviour
{
	float timeLeft = 10.0f;

	public Text text;



	void Update()
	{
		timeLeft -= Time.deltaTime;
		text.text = "Time Left:" + Mathf.Round(timeLeft);
		if(timeLeft < 0)
		{
			Application.LoadLevel(gameobjects.currentlevel);
		}
	}
}


