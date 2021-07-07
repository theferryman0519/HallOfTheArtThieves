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

public class PlayerObjectivesSceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button UIPlayerObjectiveItemsCloseButton;
    public Button UIPlayerObjectiveItemsMonthlyButton;
    public Button UIPlayerObjectiveItemsAllTimeButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	// Auth
	private FirebaseAuth PlayerAuthentication;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Playing Pausing Timers
    public PausingPlayingTimers AllTimersPausing;
    
    // Scene Load
    public SceneLoad Scene05Loading;
    
    // Enable Objects
    public AllTimeObjectivesSceneEnable AllTimeObjectiveItemsMainEnabling;
    public AllTimeObjectivesSceneEnable AllTimeObjectiveItemsButtonsEnabling;
    public MonthlyObjectiveItemsSceneEnable IndividualMonthlyObjectiveItemsMainEnabling;
    public MonthlyObjectiveItemsSceneEnable IndividualMonthlyObjectiveItemsButtonsEnabling;
    public MonthlyObjectiveItemsSceneEnable IndividualMonthlyObjectiveItemsFieldEnabling;
    
    // Disable Objects
    public PlayerObjectivesSceneEnable PlayerObjectiveItemsMainDisabling;
    public MonthlyObjectiveItemsSceneEnable IndividualMonthlyObjectiveItemsAllDisabling;
    public AllTimeObjectivesSceneEnable AllTimeObjectiveItemsAllDisabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Firebase Auth
		PlayerAuthentication = FirebaseAuth.DefaultInstance;
        
        // Pause All Timers
        AllTimersPausing.AllTimersPause();
        
        // Close Button
		Button UIPlayerObjectiveItemsCloseButtonClick = UIPlayerObjectiveItemsCloseButton.GetComponent<Button>();
		UIPlayerObjectiveItemsCloseButtonClick.onClick.AddListener(UIPlayerObjectiveItemsCloseButtonClicking);
        
        // Monthly Objectives Button
		Button UIPlayerObjectiveItemsMonthlyButtonClick = UIPlayerObjectiveItemsMonthlyButton.GetComponent<Button>();
		UIPlayerObjectiveItemsMonthlyButtonClick.onClick.AddListener(UIPlayerObjectiveItemsMonthlyButtonClicking);
        
        // All-Time Objectives Button
		Button UIPlayerObjectiveItemsAllTimeButtonClick = UIPlayerObjectiveItemsAllTimeButton.GetComponent<Button>();
		UIPlayerObjectiveItemsAllTimeButtonClick.onClick.AddListener(UIPlayerObjectiveItemsAllTimeButtonClicking);
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
    public void UIPlayerObjectiveItemsCloseButtonClicking() {
        Scene05Loading.Scene05Load();
    }
    
    public void UIPlayerObjectiveItemsMonthlyButtonClicking() {
        // Disable Objects
        PlayerObjectiveItemsMainDisabling.PlayerObjectiveItemsMainDisable();
        IndividualMonthlyObjectiveItemsAllDisabling.IndividualMonthlyObjectiveItemsAllDisable();
        AllTimeObjectiveItemsAllDisabling.AllTimeObjectiveItemsAllDisable();

        // Enable Objects
        IndividualMonthlyObjectiveItemsMainEnabling.IndividualMonthlyObjectiveItemsMainEnable();
        IndividualMonthlyObjectiveItemsButtonsEnabling.IndividualMonthlyObjectiveItemsButtonsEnable();
        IndividualMonthlyObjectiveItemsFieldEnabling.IndividualMonthlyObjectiveItemsFieldEnable();
        MonthlyObjectiveItemsSceneEnable.EventObjectiveNumber = int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber);
    }
    
    public void UIPlayerObjectiveItemsAllTimeButtonClicking() {
        // Disable Objects
        PlayerObjectiveItemsMainDisabling.PlayerObjectiveItemsMainDisable();
        IndividualMonthlyObjectiveItemsAllDisabling.IndividualMonthlyObjectiveItemsAllDisable();
        AllTimeObjectiveItemsAllDisabling.AllTimeObjectiveItemsAllDisable();

        // Enable Objects
        AllTimeObjectiveItemsMainEnabling.AllTimeObjectiveItemsMainEnable();
        AllTimeObjectiveItemsButtonsEnabling.AllTimeObjectiveItemsButtonsEnable();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}