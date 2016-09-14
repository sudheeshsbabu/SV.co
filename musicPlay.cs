using UnityEngine;
using System.Collections;

public class musicPlay : MonoBehaviour {

	public AudioClip winClip;
	public AudioClip backMusic;
	AudioSource startMusic;
	AudioSource playeraudio;
	static bool AudioBegin = false; 
	void Awake()
	{	
		startMusic = GetComponent<AudioSource> ();
		if (!AudioBegin) {
			startMusic.clip = backMusic;
			startMusic.Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		} 

	}
	/*public void playsound ()
	{
		playeraudio = GetComponent<AudioSource> ();
		playeraudio.clip = winClip;
		playeraudio.Play ();
       DontDestroyOnLoad (gameObject);

	}*/

}
