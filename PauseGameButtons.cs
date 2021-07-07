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

public class PauseGameButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button UIPauseGamePlayButton;
    public Button UIPauseGamePauseButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	public PauseGameEnable PauseGamePausedEnabling;
    public PauseGameEnable PauseGamePausedDisabling;
    
    public SaveGameEnable SaveGameSaveDisabling;
    public SaveGameEnable SaveGameSaveEnabling;
    
    // Playing Pausing Timers
    public PausingPlayingTimers AllTimersPausing;
    public PausingPlayingTimers AllTimersPlaying;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		Button UIPauseGamePlayButtonClick = UIPauseGamePlayButton.GetComponent<Button>();
        Button UIPauseGamePauseButtonClick = UIPauseGamePauseButton.GetComponent<Button>();
		
		UIPauseGamePlayButtonClick.onClick.AddListener(UIPauseGamePlayButtonClicking);
        UIPauseGamePauseButtonClick.onClick.AddListener(UIPauseGamePauseButtonClicking);
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
    public void UIPauseGamePlayButtonClicking() {
        PauseGamePausedDisabling.PauseGamePausedDisable();
        AllTimersPlaying.AllTimersPlay();
        SaveGameSaveEnabling.SaveGameSaveEnable();
    }
    
    public void UIPauseGamePauseButtonClicking() {
        PauseGamePausedEnabling.PauseGamePausedEnable();
        AllTimersPausing.AllTimersPause();
        SaveGameSaveDisabling.SaveGameSaveDisable();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}