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

public class SignUpProfileSceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Buttons
	public Button UIProfileCreateProfileButton;
    public Button UIProfileFavArtistInput;
	
	// Name & Fav Artist Input
	public Text UIProfileFirstNameInputText;
    public Text UIProfileFavArtistInputPlaceText;
	
// --------------- PRIVATE VARIABLES ---------------
	private string UpdatingPlayerFirstName;
    private string UpdatingPlayerFavArtist;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	private FirebaseAuth PlayerAuthentication;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	public SceneLoad SceneTutorial01Loading;
    public SceneLoad Scene38Loading;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		Button UIProfileCreateProfileButtonClick = UIProfileCreateProfileButton.GetComponent<Button>();
        Button UIProfileFavArtistInputClick = UIProfileFavArtistInput.GetComponent<Button>();
		
		UIProfileCreateProfileButtonClick.onClick.AddListener(UIProfileCreateProfileButtonClicking);
        UIProfileFavArtistInputClick.onClick.AddListener(UIProfileFavArtistInputClicking);
		
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
	public void UIProfileCreateProfileButtonClicking() {
		UpdatingPlayerFirstName = UIProfileFirstNameInputText.text.ToString();
        UpdatingPlayerFavArtist = UIProfileFavArtistInputPlaceText.text.ToString();
		FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBPlayerName").SetValueAsync(UpdatingPlayerFirstName);
        FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBPlayerFavArtist").SetValueAsync(UpdatingPlayerFavArtist);
		
		UpdatingPlayerFirstName = DataFillingInformation.DBPlayerName;
        UpdatingPlayerFavArtist = DataFillingInformation.DBPlayerFavArtist;
		
		SceneTutorial01Loading.SceneTutorial01Load();
	}
    
    public void UIProfileFavArtistInputClicking() {
        Scene38Loading.Scene38Load();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}