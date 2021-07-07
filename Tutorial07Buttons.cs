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

public class Tutorial07Buttons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    // Main
    public Button UIPlayerObjectiveItemsAllTimeButton;
    public Button UITutorialPageVasariTextNext1;
    public Button UITutorialPageVasariTextNext2;
    
    public Text UITutorialPageVasariText3;
    
    // All Time
    public Button UIAllTimeObjectivesItem01;
    public Button UIAllTimeObjectiveItemsFieldClaimPrizeText;
    public Button UITutorialPageVasariTextNext1AllTime;
    public Button UITutorialPageVasariTextNext4AllTime;
    
    public Text UITutorialPageVasariText2AllTime;
    public Text UITutorialPageVasariText3AllTime;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Load
    public SceneLoad SceneTutorial09Loading;
    
    // Enable & Disable Objects
    public Tutorial07Enable Tutorial07MainDisabling;
    public Tutorial07Enable Tutorial07MainVasariFieldDisabling;
    public Tutorial07Enable Tutorial07MainVasariText3Disabling;
    public Tutorial07Enable Tutorial07AllTimeMainEnabling;
    public Tutorial07Enable Tutorial07AllTimeVasariFieldEnabling;
    public Tutorial07Enable Tutorial07AllTimeVasariText1Enabling;
    
    public Tutorial07Enable Tutorial07MainVasariText2Enabling;
    public Tutorial07Enable Tutorial07MainVasariText3Enabling;
    
    public Tutorial07Enable Tutorial07MainVasariText1Disabling;
    public Tutorial07Enable Tutorial07MainVasariText2Disabling;
    
    public Tutorial07Enable Tutorial07AllTimeMainDisabling;
    public Tutorial07Enable Tutorial07AllTimeFieldEnabling;
    public Tutorial07Enable Tutorial07AllTimeCompleteEnabling;
    
    public Tutorial07Enable Tutorial07AllTimeCompleteDisabling;
    public Tutorial07Enable Tutorial07AllTimeClaimPrizeEnabling;
    public Tutorial07Enable Tutorial07AllTimeClaimPrizeDisabling;
    
    public Tutorial07Enable Tutorial07AllTimeVasariText2Enabling;
    public Tutorial07Enable Tutorial07AllTimeVasariText3Enabling;
    public Tutorial07Enable Tutorial07AllTimeVasariText4Enabling;
    
    public Tutorial07Enable Tutorial07AllTimeVasariText1Disabling;
    public Tutorial07Enable Tutorial07AllTimeVasariText2Disabling;
    public Tutorial07Enable Tutorial07AllTimeVasariText3Disabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        // All Time Option Button
        Button UIPlayerObjectiveItemsAllTimeButtonClick = UIPlayerObjectiveItemsAllTimeButton.GetComponent<Button>();
		UIPlayerObjectiveItemsAllTimeButtonClick.onClick.AddListener(UIPlayerObjectiveItemsAllTimeButtonClicking);
        
        // Vasari Main Text 1 Button
        Button UITutorialPageVasariTextNext1Click = UITutorialPageVasariTextNext1.GetComponent<Button>();
		UITutorialPageVasariTextNext1Click.onClick.AddListener(UITutorialPageVasariTextNext1Clicking);
        
        // Vasari Main Text 2 Button
        Button UITutorialPageVasariTextNext2Click = UITutorialPageVasariTextNext2.GetComponent<Button>();
		UITutorialPageVasariTextNext2Click.onClick.AddListener(UITutorialPageVasariTextNext2Clicking);
        
        // All Time 01 Button
        Button UIAllTimeObjectivesItem01Click = UIAllTimeObjectivesItem01.GetComponent<Button>();
		UIAllTimeObjectivesItem01Click.onClick.AddListener(UIAllTimeObjectivesItem01Clicking);
        
        // Claim Prize Button
        Button UIAllTimeObjectiveItemsFieldClaimPrizeTextClick = UIAllTimeObjectiveItemsFieldClaimPrizeText.GetComponent<Button>();
		UIAllTimeObjectiveItemsFieldClaimPrizeTextClick.onClick.AddListener(UIAllTimeObjectiveItemsFieldClaimPrizeTextClicking);
        
        // Vasari All Time Text 1 Button
        Button UITutorialPageVasariTextNext1AllTimeClick = UITutorialPageVasariTextNext1AllTime.GetComponent<Button>();
		UITutorialPageVasariTextNext1AllTimeClick.onClick.AddListener(UITutorialPageVasariTextNext1AllTimeClicking);
        
        // Vasari All Time Text 4 Button
        Button UITutorialPageVasariTextNext4AllTimeClick = UITutorialPageVasariTextNext4AllTime.GetComponent<Button>();
		UITutorialPageVasariTextNext4AllTimeClick.onClick.AddListener(UITutorialPageVasariTextNext4AllTimeClicking);
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
    public void UIPlayerObjectiveItemsAllTimeButtonClicking() {
        if (UITutorialPageVasariText3.enabled == true) {
            Tutorial07MainDisabling.Tutorial07MainDisable();
            Tutorial07MainVasariFieldDisabling.Tutorial07MainVasariFieldDisable();
            Tutorial07MainVasariText3Disabling.Tutorial07MainVasariText3Disable();
            Tutorial07AllTimeMainEnabling.Tutorial07AllTimeMainEnable();
            Tutorial07AllTimeVasariFieldEnabling.Tutorial07AllTimeVasariFieldEnable();
            Tutorial07AllTimeVasariText1Enabling.Tutorial07AllTimeVasariText1Enable();
        }
    }
    
    public void UITutorialPageVasariTextNext1Clicking() {
        Tutorial07MainVasariText1Disabling.Tutorial07MainVasariText1Disable();
        Tutorial07MainVasariText2Enabling.Tutorial07MainVasariText2Enable();
    }
    
    public void UITutorialPageVasariTextNext2Clicking() {
        Tutorial07MainVasariText2Disabling.Tutorial07MainVasariText2Disable();
        Tutorial07MainVasariText3Enabling.Tutorial07MainVasariText3Enable();
    }
    
    public void UIAllTimeObjectivesItem01Clicking() {
        if (UITutorialPageVasariText2AllTime.enabled == true) {
            Tutorial07AllTimeMainDisabling.Tutorial07AllTimeMainDisable();
            Tutorial07AllTimeFieldEnabling.Tutorial07AllTimeFieldEnable();
            Tutorial07AllTimeClaimPrizeEnabling.Tutorial07AllTimeClaimPrizeEnable();
            Tutorial07AllTimeVasariText2Disabling.Tutorial07AllTimeVasariText2Disable();
            Tutorial07AllTimeVasariText3Enabling.Tutorial07AllTimeVasariText3Enable();
        }
    }
    
    public void UIAllTimeObjectiveItemsFieldClaimPrizeTextClicking() {
        if (UITutorialPageVasariText3AllTime.enabled == true) {
            Tutorial07AllTimeCompleteEnabling.Tutorial07AllTimeCompleteEnable();
            Tutorial07AllTimeClaimPrizeDisabling.Tutorial07AllTimeClaimPrizeDisable();
            Tutorial07AllTimeVasariText3Disabling.Tutorial07AllTimeVasariText3Disable();
            Tutorial07AllTimeVasariText4Enabling.Tutorial07AllTimeVasariText4Enable();
        }
    }
    
    public void UITutorialPageVasariTextNext1AllTimeClicking() {
        Tutorial07AllTimeVasariText1Disabling.Tutorial07AllTimeVasariText1Disable();
        Tutorial07AllTimeVasariText2Enabling.Tutorial07AllTimeVasariText2Enable();
    }
    
    public void UITutorialPageVasariTextNext4AllTimeClicking() {
        PlayerTutorialTracking.PlayerTutorialTrackingObjectives = 2;
        SceneTutorial09Loading.SceneTutorial09Load();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}