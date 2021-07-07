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

public class Tutorial01Buttons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button UITutorialPageButtonPrevious;
    public Button UITutorialPageButtonNext;
    public Button UITutorialPageButtonSkip;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Loading
    public SceneLoad SceneTutorial02Loading;
    public SceneLoad Scene05Loading;
	
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
        
    }
    
    public void UITutorialPageButtonNextClicking() {
        SceneTutorial02Loading.SceneTutorial02Load();
    }
    
    public void UITutorialPageButtonSkipClicking() {
        Scene05Loading.Scene05Load();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}