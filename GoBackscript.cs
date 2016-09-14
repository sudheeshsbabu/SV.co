using UnityEngine;
using System.Collections;

public class GoBackscript : MonoBehaviour {

	public void loadScene(string name)
	{	
		Application.LoadLevel(name);

	}
}
