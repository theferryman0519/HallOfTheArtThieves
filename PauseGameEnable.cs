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

public class PauseGameEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image UIPauseGameBackground;
    public Image UIPauseGamePlayButton;
    public Text UIPauseGameText;
    
    public Image UIPauseGamePauseButton;
    
    public Image UIProfileBookPageLeft;
	public Image UIMapBookPageLeft;
	public Image UIGhostArtBookPageLeft;
	public Image UIScrollBookPageLeft;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		PauseGamePausedDisable();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if ((UIProfileBookPageLeft.enabled == false) && (UIMapBookPageLeft.enabled == false) && (UIGhostArtBookPageLeft.enabled == false) && (UIScrollBookPageLeft.enabled == false) && (UIPauseGameBackground.enabled == false)) {
            PauseGameButtonEnable();
        }
        
        else {
            PauseGameButtonDisable();
        }
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
    public void PauseGamePausedEnable() {
        UIPauseGameBackground.enabled = true;
        UIPauseGamePlayButton.enabled = true;
        UIPauseGameText.enabled = true;
    }
    
    public void PauseGameButtonEnable() {
        UIPauseGamePauseButton.enabled = true;
    }
    
// --------------- DISABLE FUNCTIONS ---------------
    public void PauseGamePausedDisable() {
        UIPauseGameBackground.enabled = false;
        UIPauseGamePlayButton.enabled = false;
        UIPauseGameText.enabled = false;
    }
    
    public void PauseGameButtonDisable() {
        UIPauseGamePauseButton.enabled = false;
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}