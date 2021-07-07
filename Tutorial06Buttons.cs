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

public class Tutorial06Buttons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    public Button UIMapMainButtonF1Off;
    public Button UIGhostArtImageGhostAF1;
    public Button UIGhostArtInfoGhostLearnLink;
    public Button UIMapMainButtonArtOff;
    
    public Button UITutorialPageVasariTextNext1;
    public Button UITutorialPageVasariTextNext3;
    public Button UITutorialPageVasariTextNext4;
    
    public Text UITutorialPageVasariText2;
    public Text UITutorialPageVasariText5;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Load
    public SceneLoad SceneTutorial06BLoading;
    
    // Enable & Disable Objects
    public Tutorial06Enable Tutorial06GhostArtF1OffDisabling;
    public Tutorial06Enable Tutorial06GhostArtF1OffEnabling;
    
    public Tutorial06Enable Tutorial06GhostArtInfoDisabling;
    
    public Tutorial06Enable Tutorial06GhostArtGhostInfoEnabling;
    public Tutorial06Enable Tutorial06GhostArtGhostInfoTextEnabling;
    public Tutorial06Enable Tutorial06GhostArtGhostInfoTextDisabling;
    
    public Tutorial06Enable Tutorial06GhostArtBierstadtEnabling;
    
    public Tutorial06Enable Tutorial06MapVasariText1Disabling;
    public Tutorial06Enable Tutorial06MapVasariText2Disabling;
    public Tutorial06Enable Tutorial06MapVasariText3Disabling;
    public Tutorial06Enable Tutorial06MapVasariText4Disabling;
    
    public Tutorial06Enable Tutorial06MapVasariText2Enabling;
    public Tutorial06Enable Tutorial06MapVasariText3Enabling;
    public Tutorial06Enable Tutorial06MapVasariText4Enabling;
    public Tutorial06Enable Tutorial06MapVasariText5Enabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        // F1 Button
        Button UIMapMainButtonF1OffClick = UIMapMainButtonF1Off.GetComponent<Button>();
		UIMapMainButtonF1OffClick.onClick.AddListener(UIMapMainButtonF1OffClicking);
        
        // Bierstadt Button
        Button UIGhostArtImageGhostAF1Click = UIGhostArtImageGhostAF1.GetComponent<Button>();
		UIGhostArtImageGhostAF1Click.onClick.AddListener(UIGhostArtImageGhostAF1Clicking);
        
        // Learn Link Button
        Button UIGhostArtInfoGhostLearnLinkClick = UIGhostArtInfoGhostLearnLink.GetComponent<Button>();
		UIGhostArtInfoGhostLearnLinkClick.onClick.AddListener(UIGhostArtInfoGhostLearnLinkClicking);
        
        // Vasari Text 1 Button
        Button UITutorialPageVasariTextNext1Click = UITutorialPageVasariTextNext1.GetComponent<Button>();
		UITutorialPageVasariTextNext1Click.onClick.AddListener(UITutorialPageVasariTextNext1Clicking);
        
        // Vasari Text 3 Button
        Button UITutorialPageVasariTextNext3Click = UITutorialPageVasariTextNext3.GetComponent<Button>();
		UITutorialPageVasariTextNext3Click.onClick.AddListener(UITutorialPageVasariTextNext3Clicking);
        
        // Vasari Text 4 Button
        Button UITutorialPageVasariTextNext4Click = UITutorialPageVasariTextNext4.GetComponent<Button>();
		UITutorialPageVasariTextNext4Click.onClick.AddListener(UITutorialPageVasariTextNext4Clicking);
        
        // Art Button
        Button UIMapMainButtonArtOffClick = UIMapMainButtonArtOff.GetComponent<Button>();
		UIMapMainButtonArtOffClick.onClick.AddListener(UIMapMainButtonArtOffClicking);
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
        if (UITutorialPageVasariText2.enabled == true) {
            Tutorial06GhostArtF1OffDisabling.Tutorial06GhostArtF1OffDisable();
            Tutorial06GhostArtF1OffEnabling.Tutorial06GhostArtF1OffEnable();
            Tutorial06GhostArtInfoDisabling.Tutorial06GhostArtInfoDisable();
            Tutorial06GhostArtGhostInfoEnabling.Tutorial06GhostArtGhostInfoEnable();
            Tutorial06GhostArtGhostInfoTextEnabling.Tutorial06GhostArtGhostInfoTextEnable();
        }
    }
    
    public void UIGhostArtImageGhostAF1Clicking() {
        if (UITutorialPageVasariText2.enabled == true) {
            Tutorial06GhostArtGhostInfoTextDisabling.Tutorial06GhostArtGhostInfoTextDisable();
            Tutorial06GhostArtBierstadtEnabling.Tutorial06GhostArtBierstadtEnable();
            Tutorial06MapVasariText2Disabling.Tutorial06MapVasariText2Disable();
            Tutorial06MapVasariText3Enabling.Tutorial06MapVasariText3Enable();
        }
    }
    
    public void UIGhostArtInfoGhostLearnLinkClicking() {
        if (UITutorialPageVasariText2.enabled == true) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF1A);
        }
    }
    
    public void UITutorialPageVasariTextNext1Clicking() {
        Tutorial06MapVasariText1Disabling.Tutorial06MapVasariText1Disable();
        Tutorial06MapVasariText2Enabling.Tutorial06MapVasariText2Enable();
    }
    
    public void UITutorialPageVasariTextNext3Clicking() {
        Tutorial06MapVasariText3Disabling.Tutorial06MapVasariText3Disable();
        Tutorial06MapVasariText4Enabling.Tutorial06MapVasariText4Enable();
    }
    
    public void UITutorialPageVasariTextNext4Clicking() {
        Tutorial06MapVasariText4Disabling.Tutorial06MapVasariText4Disable();
        Tutorial06MapVasariText5Enabling.Tutorial06MapVasariText5Enable();
    }
    
    public void UIMapMainButtonArtOffClicking() {
        if (UITutorialPageVasariText5.enabled == true) {
            SceneTutorial06BLoading.SceneTutorial06BLoad();
        }
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}