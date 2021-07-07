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

public class Tutorial06CButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    public Button UIArtworkPagesPurchaseButton;
    public Button UITutorialPageVasariTextNext1;
    public Button UITutorialPageVasariTextNext2;
    
    public Text UITutorialPageVasariText3;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Load
    public SceneLoad SceneTutorial08Loading;
    
    // Enable & Disable Objects
    public Tutorial06CEnable Tutorial06CVasariText2Enabling;
    public Tutorial06CEnable Tutorial06CVasariText3Enabling;
    
    public Tutorial06CEnable Tutorial06CVasariText1Disabling;
    public Tutorial06CEnable Tutorial06CVasariText2Disabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        // Purchase Button
        Button UIArtworkPagesPurchaseButtonClick = UIArtworkPagesPurchaseButton.GetComponent<Button>();
		UIArtworkPagesPurchaseButtonClick.onClick.AddListener(UIArtworkPagesPurchaseButtonClicking);
        
        // Vasari Text 1 Button
        Button UITutorialPageVasariTextNext1Click = UITutorialPageVasariTextNext1.GetComponent<Button>();
		UITutorialPageVasariTextNext1Click.onClick.AddListener(UITutorialPageVasariTextNext1Clicking);
        
        // Vasari Text 2 Button
        Button UITutorialPageVasariTextNext2Click = UITutorialPageVasariTextNext2.GetComponent<Button>();
		UITutorialPageVasariTextNext2Click.onClick.AddListener(UITutorialPageVasariTextNext2Clicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- BUTTON FUNCTIONS ---------------
    public void UIArtworkPagesPurchaseButtonClicking() {
        if (UITutorialPageVasariText3.enabled == true) {
            PlayerTutorialTracking.PlayerTutorialTrackingGhostArt = 1;
            PlayerTutorialTracking.PlayerTutorialTrackingObjectives = 1;
            SceneTutorial08Loading.SceneTutorial08Load();
        }
    }
    
    public void UITutorialPageVasariTextNext1Clicking() {
        Tutorial06CVasariText1Disabling.Tutorial06CVasariText1Disable();
        Tutorial06CVasariText2Enabling.Tutorial06CVasariText2Enable();
    }
    
    public void UITutorialPageVasariTextNext2Clicking() {
        Tutorial06CVasariText2Disabling.Tutorial06CVasariText2Disable();
        Tutorial06CVasariText3Enabling.Tutorial06CVasariText3Enable();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}