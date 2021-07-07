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

public class Tutorial06BButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    // Opening Buttons
    public Button UIOpeningArtworksF1Off;
    public Button UITutorialPageVasariTextNext1;
    
    // F1 Buttons
    public Button UIArtworksButtonF101;
    public Button UITutorialPageVasariTextNext1F1;
    public Button UITutorialPageVasariTextNext2F1;
    
    // UI
    public Text UITutorialPageVasariText2;
    public Text UITutorialPageVasariText3F1;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Load
    public SceneLoad SceneTutorial06CLoading;
    
    // Enable & Disable Objects
    public Tutorial06BEnable Tutorial06BOpeningVasariText1Disabling;
    public Tutorial06BEnable Tutorial06BOpeningVasariText2Enabling;
    
    public Tutorial06BEnable Tutorial06BOpeningDisabling;
    public Tutorial06BEnable Tutorial06BOpeningVasariFieldDisabling;
    public Tutorial06BEnable Tutorial06BOpeningVasariText2Disabling;
    public Tutorial06BEnable Tutorial06BF1MainEnabling;
    public Tutorial06BEnable Tutorial06BF1VasariFieldEnabling;
    public Tutorial06BEnable Tutorial06BF1VasariText1Enabling;
    
    public Tutorial06BEnable Tutorial06BF1VasariText1Disabling;
    public Tutorial06BEnable Tutorial06BF1VasariText2Disabling;
    
    public Tutorial06BEnable Tutorial06BF1VasariText2Enabling;
    public Tutorial06BEnable Tutorial06BF1VasariText3Enabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        // F1 Click Button
        Button UIOpeningArtworksF1OffClick = UIOpeningArtworksF1Off.GetComponent<Button>();
		UIOpeningArtworksF1OffClick.onClick.AddListener(UIOpeningArtworksF1OffClicking);
        
        // Vasari Opening Text 1 Button
        Button UITutorialPageVasariTextNext1Click = UITutorialPageVasariTextNext1.GetComponent<Button>();
		UITutorialPageVasariTextNext1Click.onClick.AddListener(UITutorialPageVasariTextNext1Clicking);
        
        // F101 Button
        Button UIArtworksButtonF101Click = UIArtworksButtonF101.GetComponent<Button>();
		UIArtworksButtonF101Click.onClick.AddListener(UIArtworksButtonF101Clicking);
        
        // Vasari F1 Text 1 Button
        Button UITutorialPageVasariTextNext1F1Click = UITutorialPageVasariTextNext1F1.GetComponent<Button>();
		UITutorialPageVasariTextNext1F1Click.onClick.AddListener(UITutorialPageVasariTextNext1F1Clicking);
        
        // Vasari F1 Text 2 Button
        Button UITutorialPageVasariTextNext2F1Click = UITutorialPageVasariTextNext2F1.GetComponent<Button>();
		UITutorialPageVasariTextNext2F1Click.onClick.AddListener(UITutorialPageVasariTextNext2F1Clicking);
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
    public void UIOpeningArtworksF1OffClicking() {
        if (UITutorialPageVasariText2.enabled == true) {
            Tutorial06BOpeningDisabling.Tutorial06BOpeningDisable();
            Tutorial06BOpeningVasariFieldDisabling.Tutorial06BOpeningVasariFieldDisable();
            Tutorial06BOpeningVasariText2Disabling.Tutorial06BOpeningVasariText2Disable();

            Tutorial06BF1MainEnabling.Tutorial06BF1MainEnable();
            Tutorial06BF1VasariFieldEnabling.Tutorial06BF1VasariFieldEnable();
            Tutorial06BF1VasariText1Enabling.Tutorial06BF1VasariText1Enable();
        }
    }
    
    public void UITutorialPageVasariTextNext1Clicking() {
        Tutorial06BOpeningVasariText1Disabling.Tutorial06BOpeningVasariText1Disable();
        Tutorial06BOpeningVasariText2Enabling.Tutorial06BOpeningVasariText2Enable();
    }
    
    public void UIArtworksButtonF101Clicking() {
        if (UITutorialPageVasariText3F1.enabled == true) {
            SceneTutorial06CLoading.SceneTutorial06CLoad();
        }
    }
    
    public void UITutorialPageVasariTextNext1F1Clicking() {
        Tutorial06BF1VasariText1Disabling.Tutorial06BF1VasariText1Disable();
        Tutorial06BF1VasariText2Enabling.Tutorial06BF1VasariText2Enable();
    }
    
    public void UITutorialPageVasariTextNext2F1Clicking() {
        Tutorial06BF1VasariText2Disabling.Tutorial06BF1VasariText2Disable();
        Tutorial06BF1VasariText3Enabling.Tutorial06BF1VasariText3Enable();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}