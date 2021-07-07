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

public class SaveGameEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image UISaveGameSaveButton;
    
    public Image UIProfileBookPageLeft;
	public Image UIMapBookPageLeft;
	public Image UIGhostArtBookPageLeft;
	public Image UIScrollBookPageLeft;
    public Image UIPauseGameBackground;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if ((UIProfileBookPageLeft.enabled == false) && (UIMapBookPageLeft.enabled == false) && (UIGhostArtBookPageLeft.enabled == false) && (UIScrollBookPageLeft.enabled == false) && (UIPauseGameBackground.enabled == false)) {
            SaveGameSaveEnable();
        }
        
        else {
            SaveGameSaveDisable();
        }
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
    public void SaveGameSaveEnable() {
        UISaveGameSaveButton.enabled = true;
    }
    
// --------------- DISABLE FUNCTIONS ---------------
    public void SaveGameSaveDisable() {
        UISaveGameSaveButton.enabled = false;
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}