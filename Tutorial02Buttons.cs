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

public class Tutorial02Buttons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button UITutorialPageButtonPrevious;
    public Button UITutorialPageButtonNext;
    public Button UITutorialPageButtonSkip;
    public Button UITutorialPageVasariTextNext1;
    public Button UITutorialPageVasariTextNext2;
    public Button UITutorialPageVasariTextNext3;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Loading
    public SceneLoad SceneTutorial01Loading;
    public SceneLoad SceneTutorial03Loading;
    public SceneLoad Scene05Loading;
    
    // Enable & Disable Objects
    public Tutorial02Enable Tutorial02VasariText2Enabling;
    public Tutorial02Enable Tutorial02VasariText3Enabling;
    public Tutorial02Enable Tutorial02VasariText4Enabling;
    public Tutorial02Enable Tutorial02ButtonsEnabling;
    
    public Tutorial02Enable Tutorial02VasariText1Disabling;
    public Tutorial02Enable Tutorial02VasariText2Disabling;
    public Tutorial02Enable Tutorial02VasariText3Disabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Previous Button
        Button UITutorialPageButtonPreviousClick = UITutorialPageButtonPrevious.GetComponent<Button>();
		UITutorialPageButtonPreviousClick.onClick.AddListener(UITutorialPageButtonPreviousClicking);
        
        // Next Button
        Button UITutorialPageButtonNextClick = UITutorialPageButtonNext.GetComponent<Button>();
		UITutorialPageButtonNextClick.onClick.AddListener(UITutorialPageButtonNextClicking);
        
        // Skip Button
        Button UITutorialPageButtonSkipClick = UITutorialPageButtonSkip.GetComponent<Button>();
		UITutorialPageButtonSkipClick.onClick.AddListener(UITutorialPageButtonSkipClicking);
        
        // Vasari Next 1 Button
        Button UITutorialPageVasariTextNext1Click = UITutorialPageVasariTextNext1.GetComponent<Button>();
		UITutorialPageVasariTextNext1Click.onClick.AddListener(UITutorialPageVasariTextNext1Clicking);
        
        // Vasari Next 2 Button
        Button UITutorialPageVasariTextNext2Click = UITutorialPageVasariTextNext2.GetComponent<Button>();
		UITutorialPageVasariTextNext2Click.onClick.AddListener(UITutorialPageVasariTextNext2Clicking);
        
        // Vasari Next 3 Button
        Button UITutorialPageVasariTextNext3Click = UITutorialPageVasariTextNext3.GetComponent<Button>();
		UITutorialPageVasariTextNext3Click.onClick.AddListener(UITutorialPageVasariTextNext3Clicking);
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
    public void UITutorialPageButtonPreviousClicking() {
        SceneTutorial01Loading.SceneTutorial01Load();
    }
    
    public void UITutorialPageButtonNextClicking() {
        SceneTutorial03Loading.SceneTutorial03Load();
    }
    
    public void UITutorialPageButtonSkipClicking() {
        Scene05Loading.Scene05Load();
    }
    
    public void UITutorialPageVasariTextNext1Clicking() {
        Tutorial02VasariText1Disabling.Tutorial02VasariText1Disable();
        Tutorial02VasariText2Enabling.Tutorial02VasariText2Enable();
    }
    
    public void UITutorialPageVasariTextNext2Clicking() {
        Tutorial02VasariText2Disabling.Tutorial02VasariText2Disable();
        Tutorial02VasariText3Enabling.Tutorial02VasariText3Enable();
    }
    
    public void UITutorialPageVasariTextNext3Clicking() {
        Tutorial02VasariText3Disabling.Tutorial02VasariText3Disable();
        Tutorial02VasariText4Enabling.Tutorial02VasariText4Enable();
        Tutorial02ButtonsEnabling.Tutorial02ButtonsEnable();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}