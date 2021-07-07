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

public class ArtBadgesButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button UIArtBadgeStudent;
    public Button UIArtBadgeEnthusiast;
    public Button UIArtBadgeApprentice;
    public Button UIArtBadgePatron;
    public Button UIArtBadgeMaster;
    public Button UIArtBadgeCollector;
    public Button UIArtBadgeHistorian;
    public Button UIArtBadgesClickedButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	public ArtBadgesEnable ArtBadgesClickedDisabling;
    public ArtBadgesEnable ArtBadgesClickedEnabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Student
        Button UIArtBadgeStudentClick = UIArtBadgeStudent.GetComponent<Button>();
		UIArtBadgeStudentClick.onClick.AddListener(UIArtBadgeStudentClicking);
        
        // Enthusiast
        Button UIArtBadgeEnthusiastClick = UIArtBadgeEnthusiast.GetComponent<Button>();
		UIArtBadgeEnthusiastClick.onClick.AddListener(UIArtBadgeEnthusiastClicking);
        
        // Apprentice
        Button UIArtBadgeApprenticeClick = UIArtBadgeApprentice.GetComponent<Button>();
		UIArtBadgeApprenticeClick.onClick.AddListener(UIArtBadgeApprenticeClicking);
        
        // Patron
        Button UIArtBadgePatronClick = UIArtBadgePatron.GetComponent<Button>();
		UIArtBadgePatronClick.onClick.AddListener(UIArtBadgePatronClicking);
        
        // Master
        Button UIArtBadgeMasterClick = UIArtBadgeMaster.GetComponent<Button>();
		UIArtBadgeMasterClick.onClick.AddListener(UIArtBadgeMasterClicking);
        
        // Collector
        Button UIArtBadgeCollectorClick = UIArtBadgeCollector.GetComponent<Button>();
		UIArtBadgeCollectorClick.onClick.AddListener(UIArtBadgeCollectorClicking);
        
        // Historian
        Button UIArtBadgeHistorianClick = UIArtBadgeHistorian.GetComponent<Button>();
		UIArtBadgeHistorianClick.onClick.AddListener(UIArtBadgeHistorianClicking);
        
        // Clicked Button
        Button UIArtBadgesClickedButtonClick = UIArtBadgesClickedButton.GetComponent<Button>();
		UIArtBadgesClickedButtonClick.onClick.AddListener(UIArtBadgesClickedButtonClicking);
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
    public void UIArtBadgeStudentClicking() {
        ArtBadgesClickedEnabling.ArtBadgesClickedEnable();
    }
    
    public void UIArtBadgeEnthusiastClicking() {
        ArtBadgesClickedEnabling.ArtBadgesClickedEnable();
    }
    
    public void UIArtBadgeApprenticeClicking() {
        ArtBadgesClickedEnabling.ArtBadgesClickedEnable();
    }
    
    public void UIArtBadgePatronClicking() {
        ArtBadgesClickedEnabling.ArtBadgesClickedEnable();
    }
    
    public void UIArtBadgeMasterClicking() {
        ArtBadgesClickedEnabling.ArtBadgesClickedEnable();
    }
    
    public void UIArtBadgeCollectorClicking() {
        ArtBadgesClickedEnabling.ArtBadgesClickedEnable();
    }
    
    public void UIArtBadgeHistorianClicking() {
        ArtBadgesClickedEnabling.ArtBadgesClickedEnable();
    }
    
    public void UIArtBadgesClickedButtonClicking() {
        ArtBadgesClickedDisabling.ArtBadgesClickedDisable();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}