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

public class OptionsSceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Buttons
	public Button UIOptionsSignUpButton;
	public Button UIOptionsLogInButton;
	
	// Email Input
	public Text UIOptionsEmailInputText;
    public Text UIOptionsPasswordInputText;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	public FirebaseAuthentication FirebaseSigningUpNewPlayer;
	public FirebaseAuthentication FirebaseLoggingInPlayer;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		Button UIOptionsSignUpButtonClick = UIOptionsSignUpButton.GetComponent<Button>();
		Button UIOptionsLogInButtonClick = UIOptionsLogInButton.GetComponent<Button>();
		
		UIOptionsSignUpButtonClick.onClick.AddListener(UIOptionsSignUpButtonClicking);
		UIOptionsLogInButtonClick.onClick.AddListener(UIOptionsLogInButtonClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- BUTTONS FUNCTION ---------------
	public void UIOptionsSignUpButtonClicking() {
		DataFillingInformation.AuthLoggedOrSigned = 0;
		FirebaseSigningUpNewPlayer.FirebaseSignUpNewPlayer();
	}
	
	public void UIOptionsLogInButtonClicking() {
		DataFillingInformation.AuthLoggedOrSigned = 1;
		FirebaseLoggingInPlayer.FirebaseLogInPlayer();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}