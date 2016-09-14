using UnityEngine;
using System.Collections;

public class levelManager : MonoBehaviour {

    public void loadScene(string name)
    {	
        Application.LoadLevel(name);
    }
	public void quitgame()
	{
		Application.Quit();

	}


}
