using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

	public GameObject vrBtn;
	public GameObject optionBtn;

	// Use this for initialization
	void Start () {
		hidePanel();
	}

	public void showPanel(){
		optionBtn.SetActive(true);
		vrBtn.SetActive(false);
	}

	public void hidePanel(){
		optionBtn.SetActive(false);
		vrBtn.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
