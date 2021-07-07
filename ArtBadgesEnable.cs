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

public class ArtBadgesEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image UIArtBadgeStudent;
    public Image UIArtBadgeEnthusiast;
    public Image UIArtBadgeApprentice;
    public Image UIArtBadgePatron;
    public Image UIArtBadgeMaster;
    public Image UIArtBadgeCollector;
    public Image UIArtBadgeHistorian;
    
    public Image UIArtBadgesClickedBackground;
    public Image UIArtBadgesClickedField;
    public Text UIArtBadgesClickedText;
    public Text UIArtBadgesClickedButton;
	
// --------------- PRIVATE VARIABLES ---------------
	private int TotalArtworkNumber;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	// Auth
	private FirebaseAuth PlayerAuthentication;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Firebase Auth
		PlayerAuthentication = FirebaseAuth.DefaultInstance;
        
        TotalArtworkNumber = (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF1)) + (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF2)) + (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF3)) + (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG1)) + (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG2)) + (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedFB)) + (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedFBonus));
        
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
           FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBNumberOfArtworksCollected").SetValueAsync(TotalArtworkNumber);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
           FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBNumberOfArtworksCollected").SetValueAsync(TotalArtworkNumber);
        }
        
        ArtBadgesClickedDisable();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if (TotalArtworkNumber < 1) {
			ArtBadgesAllDisable();
		}
		
		if (TotalArtworkNumber >= 1 && TotalArtworkNumber <= 14) {
			ArtBadgesAllDisable();
            UIArtBadgeStudent.enabled = true;
            UIArtBadgesClickedText.text = "Your current rank is Art Student. Only " + (15 - TotalArtworkNumber) + " more works of art until you reach Art Enthusiast. Keep up the great work!";
		}
		
		if (TotalArtworkNumber >= 15 && TotalArtworkNumber <= 34) {
			ArtBadgesAllDisable();
            UIArtBadgeEnthusiast.enabled = true;
            UIArtBadgesClickedText.text = "Your current rank is Art Enthusiast. Only " + (30 - TotalArtworkNumber) + " more works of art until you reach Art Apprentice. Keep up the great work!";
		}
		
		if (TotalArtworkNumber >= 35 && TotalArtworkNumber <= 64) {
			ArtBadgesAllDisable();
            UIArtBadgeApprentice.enabled = true;
            UIArtBadgesClickedText.text = "Your current rank is Art Apprentice. Only " + (45 - TotalArtworkNumber) + " more works of art until you reach Art Patron. Keep up the great work!";
		}
		
		if (TotalArtworkNumber >= 65 && TotalArtworkNumber <= 99) {
			ArtBadgesAllDisable();
            UIArtBadgePatron.enabled = true;
            UIArtBadgesClickedText.text = "Your current rank is Art Patron. Only " + (60 - TotalArtworkNumber) + " more works of art until you reach Art Master. Keep up the great work!";
		}
		
		if (TotalArtworkNumber >= 100 && TotalArtworkNumber <= 139) {
			ArtBadgesAllDisable();
            UIArtBadgeMaster.enabled = true;
            UIArtBadgesClickedText.text = "Your current rank is Art Master. Only " + (75 - TotalArtworkNumber) + " more works of art until you reach Art Collector. Keep up the great work!";
		}
		
		if (TotalArtworkNumber >= 140 && TotalArtworkNumber <= 172) {
			ArtBadgesAllDisable();
            UIArtBadgeCollector.enabled = true;
            UIArtBadgesClickedText.text = "Your current rank is Art Collector. Only " + (100 - TotalArtworkNumber) + " more works of art until you reach Art Historian. Keep up the great work!";
		}
		
		if (TotalArtworkNumber >= 173) {
			ArtBadgesAllDisable();
            UIArtBadgeHistorian.enabled = true;
            UIArtBadgesClickedText.text = "Your current rank is Art Historian. Congratulations! Be sure to learn about all the works you have collected!";
		}
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
    public void ArtBadgesClickedEnable() {
        UIArtBadgesClickedBackground.enabled = true;
        UIArtBadgesClickedField.enabled = true;
        UIArtBadgesClickedText.enabled = true;
        UIArtBadgesClickedButton.enabled = true;
    }
    
// --------------- DISABLE FUNCTIONS ---------------
    public void ArtBadgesAllDisable() {
        UIArtBadgeStudent.enabled = false;
        UIArtBadgeEnthusiast.enabled = false;
        UIArtBadgeApprentice.enabled = false;
        UIArtBadgePatron.enabled = false;
        UIArtBadgeMaster.enabled = false;
        UIArtBadgeCollector.enabled = false;
        UIArtBadgeHistorian.enabled = false;
    }
    
    public void ArtBadgesClickedDisable() {
        UIArtBadgesClickedBackground.enabled = false;
        UIArtBadgesClickedField.enabled = false;
        UIArtBadgesClickedText.enabled = false;
        UIArtBadgesClickedButton.enabled = false;
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}