using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using System.Threading;
public class PlayerMobileController : MonoBehaviour {

	public float moveForce = 5f, boostMultiplier = 2f;
	public GameObject deathParticles;
	public AudioClip deathclip;
	public AudioClip winClip;
	AudioSource playeraudio;
	musicPlay playmusic=new musicPlay();
	Rigidbody myBody;
	Vector3 spawn;
	void Start () {
		myBody = this.GetComponent<Rigidbody> ();
		spawn = transform.position;
		playeraudio = GetComponent<AudioSource>();
			
	}
	

	void FixedUpdate () {
	
		Vector3 movevec = new Vector3 (CrossPlatformInputManager.GetAxis("Horizontal"), 0, CrossPlatformInputManager.GetAxis("Vertical"));

		if (GetComponent<Rigidbody>().velocity.magnitude < moveForce)
		{ GetComponent<Rigidbody>().AddForce(movevec *moveForce); }

		//bool isBoosting = CrossPlatformInputManager.GetButton("BOOST");
		//Debug.Log (isBoosting ? boostMultiplier : 1f);

	//	myBody.AddForce (movevec * (isBoosting ? boostMultiplier : 1f));

		if(transform.position.y<-2)
			die();
		
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.transform.tag =="enemy")
		{
			die(); 
		}


	}
	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag =="goal")
		{


			gameobjects.completelevel();
		}

	}

	void die()
	{
		Instantiate(deathParticles, transform.position, Quaternion.Euler(-90, 90, 90));
		transform.position = spawn;
        playeraudio.clip = deathclip;
		playeraudio.Play ();
	}



}
