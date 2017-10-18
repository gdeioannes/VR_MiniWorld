using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRStateManager : MonoBehaviour {

	public GvrViewer gvrViewer ;
	public GameObject gvrHead;
	public GameObject panel;
	public bool flagPanelToggle=true;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toggleVrSplit(){
		if(gvrViewer.VRModeEnabled){
			gvrViewer.VRModeEnabled=false;
		}else{
			gvrViewer.VRModeEnabled=true;
		}
	}

	public void toggleMouse(){
		if(gvrHead.GetComponent<GvrHead>().trackRotation){
			gvrHead.GetComponent<GvrHead>().trackRotation=false;
		}else{
			gvrHead.GetComponent<GvrHead>().trackRotation=true;
		}
	}

	public void togglePanel(){
		if(flagPanelToggle){
			panel.GetComponent<Animator>().Play("SlideRigth");
			flagPanelToggle=false;
		}else{
			panel.GetComponent<Animator>().Play("CloseRigth");
			flagPanelToggle=true;
		}
	}

}
