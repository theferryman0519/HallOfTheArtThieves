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

public class Tutorial05Buttons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    public Button UITutorialPageVasariTextNext1;
    public Button UITutorialPageVasariTextNext2;
    public Button UITutorialPageVasariTextNext3;
    public Button UITutorialPageVasariTextNext4;
    public Button UITutorialPageVasariTextNext5;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Load
    public SceneLoad SceneTutorial08Loading;
    
    // Enable & Disable Objects
    public Tutorial05Enable Tutorial05MapVasariText1Disabling;
    public Tutorial05Enable Tutorial05MapVasariText2Disabling;
    public Tutorial05Enable Tutorial05MapVasariText3Disabling;
    public Tutorial05Enable Tutorial05MapVasariText4Disabling;
    
    public Tutorial05Enable Tutorial05MapVasariText2Enabling;
    public Tutorial05Enable Tutorial05MapVasariText3Enabling;
    public Tutorial05Enable Tutorial05MapVasariText4Enabling;
    public Tutorial05Enable Tutorial05MapVasariText5Enabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        // Vasari Text 1 Button
        Button UITutorialPageVasariTextNext1Click = UITutorialPageVasariTextNext1.GetComponent<Button>();
		UITutorialPageVasariTextNext1Click.onClick.AddListener(UITutorialPageVasariTextNext1Clicking);
        
        // Vasari Text 2 Button
        Button UITutorialPageVasariTextNext2Click = UITutorialPageVasariTextNext2.GetComponent<Button>();
		UITutorialPageVasariTextNext2Click.onClick.AddListener(UITutorialPageVasariTextNext2Clicking);
        
        // Vasari Text 3 Button
        Button UITutorialPageVasariTextNext3Click = UITutorialPageVasariTextNext3.GetComponent<Button>();
		UITutorialPageVasariTextNext3Click.onClick.AddListener(UITutorialPageVasariTextNext3Clicking);
        
        // Vasari Text 4 Button
        Button UITutorialPageVasariTextNext4Click = UITutorialPageVasariTextNext4.GetComponent<Button>();
		UITutorialPageVasariTextNext4Click.onClick.AddListener(UITutorialPageVasariTextNext4Clicking);
        
        // Vasari Text 5 Button
        Button UITutorialPageVasariTextNext5Click = UITutorialPageVasariTextNext5.GetComponent<Button>();
		UITutorialPageVasariTextNext5Click.onClick.AddListener(UITutorialPageVasariTextNext5Clicking);
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
    public void UITutorialPageVasariTextNext1Clicking() {
        Tutorial05MapVasariText1Disabling.Tutorial05MapVasariText1Disable();
        Tutorial05MapVasariText2Enabling.Tutorial05MapVasariText2Enable();
    }
    
    public void UITutorialPageVasariTextNext2Clicking() {
        Tutorial05MapVasariText2Disabling.Tutorial05MapVasariText2Disable();
        Tutorial05MapVasariText3Enabling.Tutorial05MapVasariText3Enable();
    }
    
    public void UITutorialPageVasariTextNext3Clicking() {
        Tutorial05MapVasariText3Disabling.Tutorial05MapVasariText3Disable();
        Tutorial05MapVasariText4Enabling.Tutorial05MapVasariText4Enable();
    }
    
    public void UITutorialPageVasariTextNext4Clicking() {
        Tutorial05MapVasariText4Disabling.Tutorial05MapVasariText4Disable();
        Tutorial05MapVasariText5Enabling.Tutorial05MapVasariText5Enable();
    }
    
    public void UITutorialPageVasariTextNext5Clicking() {
        PlayerTutorialTracking.PlayerTutorialTrackingProfile = 1;
        SceneTutorial08Loading.SceneTutorial08Load();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}