using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using Firebase;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Unity.Editor;

public class CreditsPageEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image UICreditsPageBackground;
	public Image UICreditsPageField;
	public Text UICreditsPageText;
	public Text UICreditsPageCloseButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		UICreditsPageEnable();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTION ---------------
	public void UICreditsPageEnable() {
		UICreditsPageBackground.enabled = true;
		UICreditsPageField.enabled = true;
		UICreditsPageText.enabled = true;
		UICreditsPageCloseButton.enabled = true;
	}
	
// --------------- DISABLE FUNCTION ---------------
	public void UICreditsPageDisable() {
		UICreditsPageBackground.enabled = false;
		UICreditsPageField.enabled = false;
		UICreditsPageText.enabled = false;
		UICreditsPageCloseButton.enabled = false;
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}