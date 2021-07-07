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

public class Tutorial04Buttons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button UIMapMainButtonF1Off;
    public Button UIMapRoomCF1;
    
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
    public Tutorial04Enable Tutorial04MapF1OffDisabling;
    public Tutorial04Enable Tutorial04MapF1OnEnabling;
    
    public Tutorial04Enable Tutorial04MapIntroTextDisabling;
    public Tutorial04Enable Tutorial04MapF1FloorEnabling;
    
    public Tutorial04Enable Tutorial04MapVasariText1Disabling;
    public Tutorial04Enable Tutorial04MapVasariText2Disabling;
    
    public Tutorial04Enable Tutorial04MapVasariText2Enabling;
    public Tutorial04Enable Tutorial04MapVasariText3Enabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// F1 Off Button
        Button UIMapMainButtonF1OffClick = UIMapMainButtonF1Off.GetComponent<Button>();
		UIMapMainButtonF1OffClick.onClick.AddListener(UIMapMainButtonF1OffClicking);
        
        // Foyer Button
        Button UIMapRoomCF1Click = UIMapRoomCF1.GetComponent<Button>();
		UIMapRoomCF1Click.onClick.AddListener(UIMapRoomCF1Clicking);
        
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
    public void UIMapMainButtonF1OffClicking() {
        if (UITutorialPageVasariText3.enabled == true) {
            Tutorial04MapF1OffDisabling.Tutorial04MapF1OffDisable();
            Tutorial04MapF1OnEnabling.Tutorial04MapF1OnEnable();
            Tutorial04MapIntroTextDisabling.Tutorial04MapIntroTextDisable();
            Tutorial04MapF1FloorEnabling.Tutorial04MapF1FloorEnable();
        }
    }
    
    public void UIMapRoomCF1Clicking() {
        PlayerTutorialTracking.PlayerTutorialTrackingMap = 1;
        SceneTutorial08Loading.SceneTutorial08Load();
    }
    
    public void UITutorialPageVasariTextNext1Clicking() {
        Tutorial04MapVasariText1Disabling.Tutorial04MapVasariText1Disable();
        Tutorial04MapVasariText2Enabling.Tutorial04MapVasariText2Enable();
    }
    
    public void UITutorialPageVasariTextNext2Clicking() {
        Tutorial04MapVasariText2Disabling.Tutorial04MapVasariText2Disable();
        Tutorial04MapVasariText3Enabling.Tutorial04MapVasariText3Enable();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}