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

public class ObjectiveAlertsButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button UIObjectiveAlertsPanel;
    public Text UIObjectiveAlertsText;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Load Scene
    public SceneLoad Scene40Loading;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		Button UIObjectiveAlertsPanelClick = UIObjectiveAlertsPanel.GetComponent<Button>();
		UIObjectiveAlertsPanelClick.onClick.AddListener(UIObjectiveAlertsPanelClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- BUTTON FUNCTION ---------------
    public void UIObjectiveAlertsPanelClicking() {
        if ((UIObjectiveAlertsText.text.Contains(ObjectiveInformation.AllTimeObjectiveTitle01)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.AllTimeObjectiveTitle02)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.AllTimeObjectiveTitle03)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.AllTimeObjectiveTitle04)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.AllTimeObjectiveTitle05)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.AllTimeObjectiveTitle06)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.AllTimeObjectiveTitle07)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.AllTimeObjectiveTitle08)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.AllTimeObjectiveTitle09)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.AllTimeObjectiveTitle10)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.AllTimeObjectiveTitle11)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.AllTimeObjectiveTitle12)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.AllTimeObjectiveTitle13)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.AllTimeObjectiveTitle14)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.AllTimeObjectiveTitle15))) {
            // Load Scene
            Scene40Loading.Scene40Load();
        }
        
        if ((UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle011)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle012)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle013)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle014)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle015)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle021)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle022)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle023)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle024)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle025)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle031)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle032)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle033)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle034)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle035)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle041)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle042)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle043)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle044)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle045)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle051)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle052)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle053)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle054)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle055)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle061)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle062)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle063)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle064)) || (UIObjectiveAlertsText.text.Contains(ObjectiveInformation.EventObjectiveTitle065))) {
            // Load Scene
            Scene40Loading.Scene40Load();
        }
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}