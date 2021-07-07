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

public class SignUpSceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Buttons
	public Button UINewsletterSignUpYesButton;
	public Button UINewsletterSignUpNoButton;
	
// --------------- PRIVATE VARIABLES ---------------
	private int SettingNewsletterButton;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	private FirebaseAuth PlayerAuthentication;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Loading Scenes
	public SceneLoad Scene03Loading;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		Button UINewsletterSignUpYesButtonClick = UINewsletterSignUpYesButton.GetComponent<Button>();
		Button UINewsletterSignUpNoButtonClick = UINewsletterSignUpNoButton.GetComponent<Button>();
		
		UINewsletterSignUpYesButtonClick.onClick.AddListener(UINewsletterSignUpYesButtonClicking);
		UINewsletterSignUpNoButtonClick.onClick.AddListener(UINewsletterSignUpNoButtonClicking);
		
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
	public void UINewsletterSignUpYesButtonClicking() {
		SettingNewsletterButton = 1;
		FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBNewsletterSubscription").SetValueAsync(SettingNewsletterButton);
		
		SettingNewsletterButton = int.Parse(DataFillingInformation.DBNewsletterSubscription);
		
		Scene03Loading.Scene03Load();
	}
	
	public void UINewsletterSignUpNoButtonClicking() {
		SettingNewsletterButton = 0;
		FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBNewsletterSubscription").SetValueAsync(SettingNewsletterButton);
		
		SettingNewsletterButton = int.Parse(DataFillingInformation.DBNewsletterSubscription);
		
		Scene03Loading.Scene03Load();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}