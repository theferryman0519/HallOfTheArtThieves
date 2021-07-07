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

public class Tutorial03Buttons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    public Text UITutorialPageVasariText13;
    
	// UI
    public Button UIObjectivesField;
    public Button UIGhostArtButton;
    public Button UIUserProfile;
    public Button UICastleMap;
    
    // Vasari
    public Button UITutorialPageVasariTextNext1;
    public Button UITutorialPageVasariTextNext3;
    public Button UITutorialPageVasariTextNext4;
    public Button UITutorialPageVasariTextNext5;
    public Button UITutorialPageVasariTextNext6;
    public Button UITutorialPageVasariTextNext7;
    public Button UITutorialPageVasariTextNext8;
    public Button UITutorialPageVasariTextNext9;
    public Button UITutorialPageVasariTextNext10;
    public Button UITutorialPageVasariTextNext11;
    public Button UITutorialPageVasariTextNext12;
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
    
    // Enabling & Disabling Objects
    public Tutorial03Enable Tutorial03ObjectivesEnabling;
    public Tutorial03Enable Tutorial03BankAccountEnabling;
    public Tutorial03Enable Tutorial03CurrentSceneEnabling;
    public Tutorial03Enable Tutorial03GhostArtEnabling;
    public Tutorial03Enable Tutorial03ProfileEnabling;
    public Tutorial03Enable Tutorial03MapEnabling;
    public Tutorial03Enable Tutorial03SavePauseEnabling;
    
    // Vasari
    public Tutorial03Enable Tutorial03VasariText1Enabling;
    public Tutorial03Enable Tutorial03VasariText2Enabling;
    public Tutorial03Enable Tutorial03VasariText3Enabling;
    public Tutorial03Enable Tutorial03VasariText4Enabling;
    public Tutorial03Enable Tutorial03VasariText5Enabling;
    public Tutorial03Enable Tutorial03VasariText6Enabling;
    public Tutorial03Enable Tutorial03VasariText7Enabling;
    public Tutorial03Enable Tutorial03VasariText8Enabling;
    public Tutorial03Enable Tutorial03VasariText9Enabling;
    public Tutorial03Enable Tutorial03VasariText10Enabling;
    public Tutorial03Enable Tutorial03VasariText11Enabling;
    public Tutorial03Enable Tutorial03VasariText12Enabling;
    public Tutorial03Enable Tutorial03VasariText13Enabling;
    public Tutorial03Enable Tutorial03VasariText14Enabling;
    
    public Tutorial03Enable Tutorial03VasariText1Disabling;
    public Tutorial03Enable Tutorial03VasariText2Disabling;
    public Tutorial03Enable Tutorial03VasariText3Disabling;
    public Tutorial03Enable Tutorial03VasariText4Disabling;
    public Tutorial03Enable Tutorial03VasariText5Disabling;
    public Tutorial03Enable Tutorial03VasariText6Disabling;
    public Tutorial03Enable Tutorial03VasariText7Disabling;
    public Tutorial03Enable Tutorial03VasariText8Disabling;
    public Tutorial03Enable Tutorial03VasariText9Disabling;
    public Tutorial03Enable Tutorial03VasariText10Disabling;
    public Tutorial03Enable Tutorial03VasariText11Disabling;
    public Tutorial03Enable Tutorial03VasariText12Disabling;
    public Tutorial03Enable Tutorial03VasariText13Disabling;
    public Tutorial03Enable Tutorial03VasariText14Disabling;
	
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
        
        // Vasari Next 1 Button
        Button UITutorialPageVasariTextNext1Click = UITutorialPageVasariTextNext1.GetComponent<Button>();
		UITutorialPageVasariTextNext1Click.onClick.AddListener(UITutorialPageVasariTextNext1Clicking);
        
        // Vasari Next 3 Button
        Button UITutorialPageVasariTextNext3Click = UITutorialPageVasariTextNext3.GetComponent<Button>();
		UITutorialPageVasariTextNext3Click.onClick.AddListener(UITutorialPageVasariTextNext3Clicking);
        
        // Vasari Next 4 Button
        Button UITutorialPageVasariTextNext4Click = UITutorialPageVasariTextNext4.GetComponent<Button>();
		UITutorialPageVasariTextNext4Click.onClick.AddListener(UITutorialPageVasariTextNext4Clicking);
        
        // Vasari Next 5 Button
        Button UITutorialPageVasariTextNext5Click = UITutorialPageVasariTextNext5.GetComponent<Button>();
		UITutorialPageVasariTextNext5Click.onClick.AddListener(UITutorialPageVasariTextNext5Clicking);
        
        // Vasari Next 6 Button
        Button UITutorialPageVasariTextNext6Click = UITutorialPageVasariTextNext6.GetComponent<Button>();
		UITutorialPageVasariTextNext6Click.onClick.AddListener(UITutorialPageVasariTextNext6Clicking);
        
        // Vasari Next 7 Button
        Button UITutorialPageVasariTextNext7Click = UITutorialPageVasariTextNext7.GetComponent<Button>();
		UITutorialPageVasariTextNext7Click.onClick.AddListener(UITutorialPageVasariTextNext7Clicking);
        
        // Vasari Next 8 Button
        Button UITutorialPageVasariTextNext8Click = UITutorialPageVasariTextNext8.GetComponent<Button>();
		UITutorialPageVasariTextNext8Click.onClick.AddListener(UITutorialPageVasariTextNext8Clicking);
        
        // Vasari Next 9 Button
        Button UITutorialPageVasariTextNext9Click = UITutorialPageVasariTextNext9.GetComponent<Button>();
		UITutorialPageVasariTextNext9Click.onClick.AddListener(UITutorialPageVasariTextNext9Clicking);
        
        // Vasari Next 10 Button
        Button UITutorialPageVasariTextNext10Click = UITutorialPageVasariTextNext10.GetComponent<Button>();
		UITutorialPageVasariTextNext10Click.onClick.AddListener(UITutorialPageVasariTextNext10Clicking);
        
        // Vasari Next 11 Button
        Button UITutorialPageVasariTextNext11Click = UITutorialPageVasariTextNext11.GetComponent<Button>();
		UITutorialPageVasariTextNext11Click.onClick.AddListener(UITutorialPageVasariTextNext11Clicking);
        
        // Vasari Next 12 Button
        Button UITutorialPageVasariTextNext12Click = UITutorialPageVasariTextNext12.GetComponent<Button>();
		UITutorialPageVasariTextNext12Click.onClick.AddListener(UITutorialPageVasariTextNext12Clicking);
        
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
            SceneTutorial07Loading.SceneTutorial07Load();
        }
    }
    
    public void UIGhostArtButtonClicking() {
        if (UITutorialPageVasariText13.enabled == true) {
            SceneTutorial06Loading.SceneTutorial06Load();
        }
    }
    
    public void UIUserProfileClicking() {
        if (UITutorialPageVasariText13.enabled == true) {
            SceneTutorial05Loading.SceneTutorial05Load();
        }
    }
    
    public void UICastleMapClicking() {
        if (UITutorialPageVasariText13.enabled == true) {
            SceneTutorial04Loading.SceneTutorial04Load();
        }
    }
    
    public void UITutorialPageVasariTextNext1Clicking() {
        Tutorial03VasariText1Disabling.Tutorial03VasariText1Disable();
        Tutorial03VasariText2Enabling.Tutorial03VasariText2Enable();
    }
    
    public void UITutorialPageVasariTextNext3Clicking() {
        Tutorial03VasariText3Disabling.Tutorial03VasariText3Disable();
        Tutorial03VasariText4Enabling.Tutorial03VasariText4Enable();
    }
    
    public void UITutorialPageVasariTextNext4Clicking() {
        Tutorial03VasariText4Disabling.Tutorial03VasariText4Disable();
        Tutorial03VasariText5Enabling.Tutorial03VasariText5Enable();
        Tutorial03CurrentSceneEnabling.Tutorial03CurrentSceneEnable();
    }
    
    public void UITutorialPageVasariTextNext5Clicking() {
        Tutorial03VasariText5Disabling.Tutorial03VasariText5Disable();
        Tutorial03VasariText6Enabling.Tutorial03VasariText6Enable();
        Tutorial03BankAccountEnabling.Tutorial03BankAccountEnable();
    }
    
    public void UITutorialPageVasariTextNext6Clicking() {
        Tutorial03VasariText6Disabling.Tutorial03VasariText6Disable();
        Tutorial03VasariText7Enabling.Tutorial03VasariText7Enable();
        Tutorial03GhostArtEnabling.Tutorial03GhostArtEnable();
    }
    
    public void UITutorialPageVasariTextNext7Clicking() {
        Tutorial03VasariText7Disabling.Tutorial03VasariText7Disable();
        Tutorial03VasariText8Enabling.Tutorial03VasariText8Enable();
        Tutorial03ProfileEnabling.Tutorial03ProfileEnable();
    }
    
    public void UITutorialPageVasariTextNext8Clicking() {
        Tutorial03VasariText8Disabling.Tutorial03VasariText8Disable();
        Tutorial03VasariText9Enabling.Tutorial03VasariText9Enable();
        Tutorial03MapEnabling.Tutorial03MapEnable();
    }
    
    public void UITutorialPageVasariTextNext9Clicking() {
        Tutorial03VasariText9Disabling.Tutorial03VasariText9Disable();
        Tutorial03VasariText10Enabling.Tutorial03VasariText10Enable();
    }
    
    public void UITutorialPageVasariTextNext10Clicking() {
        Tutorial03VasariText10Disabling.Tutorial03VasariText10Disable();
        Tutorial03VasariText11Enabling.Tutorial03VasariText11Enable();
        Tutorial03ObjectivesEnabling.Tutorial03ObjectivesEnable();
    }
    
    public void UITutorialPageVasariTextNext11Clicking() {
        Tutorial03VasariText11Disabling.Tutorial03VasariText11Disable();
        Tutorial03VasariText12Enabling.Tutorial03VasariText12Enable();
        Tutorial03SavePauseEnabling.Tutorial03SavePauseEnable();
    }
    
    public void UITutorialPageVasariTextNext12Clicking() {
        PlayerTutorialTracking.PlayerTutorialTrackingMap = 0;
        PlayerTutorialTracking.PlayerTutorialTrackingProfile = 0;
        PlayerTutorialTracking.PlayerTutorialTrackingGhostArt = 0;
        PlayerTutorialTracking.PlayerTutorialTrackingObjectives = 0;
        SceneTutorial08Loading.SceneTutorial08Load();
    }
    
    public void UITutorialPageVasariText13MapClicking() {
        SceneTutorial04Loading.SceneTutorial04Load();
    }
    
    public void UITutorialPageVasariText13ProfileClicking() {
        SceneTutorial05Loading.SceneTutorial05Load();
    }
    
    public void UITutorialPageVasariText13GhostArtClicking() {
        SceneTutorial06Loading.SceneTutorial06Load();
    }
    
    public void UITutorialPageVasariText13ObjectivesClicking() {
        SceneTutorial07Loading.SceneTutorial07Load();
    }
    
    public void UITutorialPageVasariTextNext14Clicking() {
        SceneTutorial08Loading.SceneTutorial08Load();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}