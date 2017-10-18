using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public static SoundManager _instance;
	private AudioSource[] sounds;
	private AudioSource fire;

	// Use this for initialization
	void Awake () {
		if(_instance != null && _instance != this)
		{
			// If that is the case, we destroy other instances
			Destroy(gameObject);
		}

		// Here we save our singleton instance
		_instance = this;

		// Furthermore we make sure that we don't destroy between scenes (this is optional)
		DontDestroyOnLoad(gameObject);

		sounds=this.GetComponents<AudioSource>();
	}

	
	// Update is called once per frame
	void Update () {

	}


	public void soundControl(){
		if(AudioListener.volume==1){
			AudioListener.volume=0;
		}else{
			AudioListener.volume=1;
		}
	}


}
