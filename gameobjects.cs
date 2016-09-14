using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameobjects : MonoBehaviour {
    public static int currentscore;
    public static int highscore;

    public static int currentlevel=1;
    public static int unlockedlevel;

	float timeLeft=300.0f;
	public Text text;
	//public float startTime=300.0f;
//	public string currentTime;
	
	//public Text text;

	void update()
	{
		timeLeft -= Time.deltaTime;
		text.text = "Time Left:" + Mathf.Round(timeLeft);
	//startTime -= Time.deltaTime;
	//	currentTime = string.Format ("{0:0.0}", startTime);
	//	text.text = "Time Left:" + currentTime;
			/*if (startTime <= 0) {
				Application.LoadLevel(currentlevel);
			}*/
	}
   public static void completelevel()
        {
            currentlevel += 1;
            Application.LoadLevel(currentlevel);

            }


}
