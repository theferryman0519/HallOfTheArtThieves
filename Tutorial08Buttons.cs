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

public class Tutorial08Buttons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    public Text UITutorialPageVasariText13;
    
	// UI
    public Button UIObjectivesField;
    public Button UIGhostArtButton;
    public Button UIUserProfile;
    public Button UICastleMap;
    
    // Vasari
    public Button UITutorialPageVasariText13Map;
    public Button UITutorialPageVasariText13Profile;
    public Button UITutorialPageVasariText13GhostArt;
    public Button UITutorialPageVasariText13Objectives;
    public Button UITutorialPageVasariTextNext14;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Load
    public SceneLoad SceneTutorial04Loading;
    public SceneLoad SceneTutorial05Loading;
    public SceneLoad SceneTutorial06Loading;
    public SceneLoad SceneTutorial07Loading;
    public SceneLoad SceneTutorial08Loading;
    
    // Vasari
    public Tutorial08Enable Tutorial08VasariText13Enabling;
    public Tutorial08Enable Tutorial08VasariText14Enabling;
    
    public Tutorial08Enable Tutorial08VasariText13Disabling;
    public Tutorial08Enable Tutorial08VasariText14Disabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Objectives Button
        Button UIObjectivesFieldClick = UIObjectivesField.GetComponent<Button>();
		UIObjectivesFieldClick.onClick.AddListener(UIObjectivesFieldClicking);
        
        // Ghost & Art Button
        Button UIGhostArtButtonClick = UIGhostArtButton.GetComponent<Button>();
		UIGhostArtButtonClick.onClick.AddListener(UIGhostArtButtonClicking);
        
        // Profile Button
        Button UIUserProfileClick = UIUserProfile.GetComponent<Button>();
		UIUserProfileClick.onClick.AddListener(UIUserProfileClicking);
        
        // Map Button
        Button UICastleMapClick = UICastleMap.GetComponent<Button>();
		UICastleMapClick.onClick.AddListener(UICastleMapClicking);
                
        // Vasari 13 Map Button
        Button UITutorialPageVasariText13MapClick = UITutorialPageVasariText13Map.GetComponent<Button>();
		UITutorialPageVasariText13MapClick.onClick.AddListener(UITutorialPageVasariText13MapClicking);
        
        // Vasari 13 Profile Button
        Button UITutorialPageVasariText13ProfileClick = UITutorialPageVasariText13Profile.GetComponent<Button>();
		UITutorialPageVasariText13ProfileClick.onClick.AddListener(UITutorialPageVasariText13ProfileClicking);
        
        // Vasari 13 Ghost & Art Button
        Button UITutorialPageVasariText13GhostArtClick = UITutorialPageVasariText13GhostArt.GetComponent<Button>();
		UITutorialPageVasariText13GhostArtClick.onClick.AddListener(UITutorialPageVasariText13GhostArtClicking);
        
        // Vasari 13 Objectives Button
        Button UITutorialPageVasariText13ObjectivesClick = UITutorialPageVasariText13Objectives.GetComponent<Button>();
		UITutorialPageVasariText13ObjectivesClick.onClick.AddListener(UITutorialPageVasariText13ObjectivesClicking);
        
        // Vasari Next 14 Button
        Button UITutorialPageVasariTextNext14Click = UITutorialPageVasariTextNext14.GetComponent<Button>();
		UITutorialPageVasariTextNext14Click.onClick.AddListener(UITutorialPageVasariTextNext14Clicking);
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
    public void UIObjectivesFieldClicking() {
        if (UITutorialPageVasariText13.enabled == true) {
            if (PlayerTutorialTracking.PlayerTutorialTrackingObjectives == 1) {
                SceneTutorial07Loading.SceneTutorial07Load();
            }
        }
    }
    
    public void UIGhostArtButtonClicking() {
        if (UITutorialPageVasariText13.enabled == true) {
            if (PlayerTutorialTracking.PlayerTutorialTrackingGhostArt == 0) {
                SceneTutorial06Loading.SceneTutorial06Load();
            }
        }
    }
    
    public void UIUserProfileClicking() {
        if (UITutorialPageVasariText13.enabled == true) {
            if (PlayerTutorialTracking.PlayerTutorialTrackingProfile == 0) {
                SceneTutorial05Loading.SceneTutorial05Load();
            }
        }
    }
    
    public void UICastleMapClicking() {
        if (UITutorialPageVasariText13.enabled == true) {
            if (PlayerTutorialTracking.PlayerTutorialTrackingMap == 0) {
                SceneTutorial04Loading.SceneTutorial04Load();
            }
        }
    }
        
    public void UITutorialPageVasariText13MapClicking() {
        if (PlayerTutorialTracking.PlayerTutorialTrackingMap == 0) {
            SceneTutorial04Loading.SceneTutorial04Load();
        }
    }
    
    public void UITutorialPageVasariText13ProfileClicking() {
        if (PlayerTutorialTracking.PlayerTutorialTrackingProfile == 0) {
            SceneTutorial05Loading.SceneTutorial05Load();
        }
    }
    
    public void UITutorialPageVasariText13GhostArtClicking() {
        if (PlayerTutorialTracking.PlayerTutorialTrackingGhostArt == 0) {
            SceneTutorial06Loading.SceneTutorial06Load();
        }
    }
    
    public void UITutorialPageVasariText13ObjectivesClicking() {
        if (PlayerTutorialTracking.PlayerTutorialTrackingObjectives == 1) {
            SceneTutorial07Loading.SceneTutorial07Load();
        }
    }
    
    public void UITutorialPageVasariTextNext14Clicking() {
        SceneTutorial08Loading.SceneTutorial08Load();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}