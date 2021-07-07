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

public class StudioArtistInfoButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button UIStudioArtistInfoPageCloseButton;
    public Button UIStudioArtistInfoPageFollowButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	public SceneLoad Scene14Loading;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		Button UIStudioArtistInfoPageCloseButtonClick = UIStudioArtistInfoPageCloseButton.GetComponent<Button>();
        Button UIStudioArtistInfoPageFollowButtonClick = UIStudioArtistInfoPageFollowButton.GetComponent<Button>();
		
		UIStudioArtistInfoPageCloseButtonClick.onClick.AddListener(UIStudioArtistInfoPageCloseButtonClicking);
        UIStudioArtistInfoPageFollowButtonClick.onClick.AddListener(UIStudioArtistInfoPageFollowButtonClicking);
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
	public void UIStudioArtistInfoPageCloseButtonClicking() {
		Scene14Loading.Scene14Load();
	}
    
    public void UIStudioArtistInfoPageFollowButtonClicking() {
        Application.OpenURL(UpAndComingArtistInformation.UpAndComingArtistLink001);
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}