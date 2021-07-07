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

public class SignUpErrorSceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Buttons
	public Button UISignUpErrorNoticeContactButton;
	public Button UISignUpErrorNoticeBackButton;
	
// --------------- PRIVATE VARIABLES ---------------
	// Error Email Strings
	private string ErrorEmail = "arthistorian@halloftheartthieves.com";
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Loading Scenes
	public SceneLoad Scene01Loading;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		Button UISignUpErrorNoticeContactButtonClick = UISignUpErrorNoticeContactButton.GetComponent<Button>();
		Button UISignUpErrorNoticeBackButtonClick = UISignUpErrorNoticeBackButton.GetComponent<Button>();
		
		UISignUpErrorNoticeContactButtonClick.onClick.AddListener(UISignUpErrorNoticeContactButtonClicking);
		UISignUpErrorNoticeBackButtonClick.onClick.AddListener(UISignUpErrorNoticeBackButtonClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- BUTTON FUNCTION ---------------
	public void UISignUpErrorNoticeContactButtonClicking() {
		Application.OpenURL("mailto:" + ErrorEmail);
	}
	
	public void UISignUpErrorNoticeBackButtonClicking() {
		Scene01Loading.Scene01Load();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}