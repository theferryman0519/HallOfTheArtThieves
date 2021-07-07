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

public class LogInErrorSceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Buttons
	public Button UILogInErrorNoticeRequestButton;
	public Button UILogInErrorNoticeBackButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	private FirebaseAuth PlayerAuthentication;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Loading Scenes
	public SceneLoad Scene01Loading;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		Button UILogInErrorNoticeRequestButtonClick = UILogInErrorNoticeRequestButton.GetComponent<Button>();
		Button UILogInErrorNoticeBackButtonClick = UILogInErrorNoticeBackButton.GetComponent<Button>();
		
		UILogInErrorNoticeRequestButtonClick.onClick.AddListener(UILogInErrorNoticeRequestButtonClicking);
		UILogInErrorNoticeBackButtonClick.onClick.AddListener(UILogInErrorNoticeBackButtonClicking);
		
		// Firebase Auth
		PlayerAuthentication = FirebaseAuth.DefaultInstance;
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
	public void UILogInErrorNoticeRequestButtonClicking() {
		PlayerAuthentication.SendPasswordResetEmailAsync(DataFillingInformation.AuthPlayerEmail).ContinueWith(task => {
			if (task.IsCanceled || task.IsFaulted) {
				return;
			}
			
			else {
				
			}
		});
	}
	
	public void UILogInErrorNoticeBackButtonClicking() {
		Scene01Loading.Scene01Load();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}