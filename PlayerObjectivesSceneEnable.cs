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

public class PlayerObjectivesSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image UIPlayerObjectiveItemsBackground;
    public Image UIPlayerObjectiveItemsField;
    public Text UIPlayerObjectiveItemsText;
    public Text UIPlayerObjectiveItemsCloseButton;
    public Image UIPlayerObjectiveItemsMonthlyButton;
    public Text UIPlayerObjectiveItemsMonthlyButtonText;
    public Image UIPlayerObjectiveItemsAllTimeButton;
    public Text UIPlayerObjectiveItemsAllTimeButtonText;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		PlayerObjectiveItemsMainEnable();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
    public void PlayerObjectiveItemsMainEnable() {
        UIPlayerObjectiveItemsBackground.enabled = true;
        UIPlayerObjectiveItemsField.enabled = true;
        UIPlayerObjectiveItemsText.enabled = true;
        UIPlayerObjectiveItemsCloseButton.enabled = true;
        UIPlayerObjectiveItemsMonthlyButton.enabled = true;
        UIPlayerObjectiveItemsMonthlyButtonText.enabled = true;
        UIPlayerObjectiveItemsAllTimeButton.enabled = true;
        UIPlayerObjectiveItemsAllTimeButtonText.enabled = true;
    }
    
// --------------- DISABLE FUNCTIONS ---------------
    public void PlayerObjectiveItemsMainDisable() {
        UIPlayerObjectiveItemsBackground.enabled = false;
        UIPlayerObjectiveItemsField.enabled = false;
        UIPlayerObjectiveItemsText.enabled = false;
        UIPlayerObjectiveItemsCloseButton.enabled = false;
        UIPlayerObjectiveItemsMonthlyButton.enabled = false;
        UIPlayerObjectiveItemsMonthlyButtonText.enabled = false;
        UIPlayerObjectiveItemsAllTimeButton.enabled = false;
        UIPlayerObjectiveItemsAllTimeButtonText.enabled = false;
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}