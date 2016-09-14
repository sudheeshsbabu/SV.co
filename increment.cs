using UnityEngine;
using System.Collections;
public class increment : MonoBehaviour {

	public void loadScene(string name)
	{	
		gameobjects.currentlevel++;
		Application.LoadLevel(name);

	}
}