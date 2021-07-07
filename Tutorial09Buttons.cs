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

public class Tutorial09Buttons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    // Vasari
    public Button UITutorialPageVasariTextNext1;
    public Button UITutorialPageVasariTextNext1B;
    public Button UITutorialPageVasariTextNext2;
    public Button UITutorialPageVasariTextNext3;
    public Button UITutorialPageVasariTextNext4;
    public Button UITutorialPageVasariTextNext5;
    public Button UITutorialPageVasariTextNext6;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Load
    public SceneLoad Scene05Loading;
    
    // Vasari
    public Tutorial09Enable Tutorial09VasariText1BEnabling;
    public Tutorial09Enable Tutorial09VasariText2Enabling;
    public Tutorial09Enable Tutorial09VasariText3Enabling;
    public Tutorial09Enable Tutorial09VasariText4Enabling;
    public Tutorial09Enable Tutorial09VasariText5Enabling;
    public Tutorial09Enable Tutorial09VasariText6Enabling;
    
    public Tutorial09Enable Tutorial09VasariText1Disabling;
    public Tutorial09Enable Tutorial09VasariText1BDisabling;
    public Tutorial09Enable Tutorial09VasariText2Disabling;
    public Tutorial09Enable Tutorial09VasariText3Disabling;
    public Tutorial09Enable Tutorial09VasariText4Disabling;
    public Tutorial09Enable Tutorial09VasariText5Disabling;
    
    public Tutorial09Enable Tutorial09AlertEnabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Vasari Text 1 Button
        Button UITutorialPageVasariTextNext1Click = UITutorialPageVasariTextNext1.GetComponent<Button>();
		UITutorialPageVasariTextNext1Click.onClick.AddListener(UITutorialPageVasariTextNext1Clicking);
        
        // Vasari Text 1B Button
        Button UITutorialPageVasariTextNext1BClick = UITutorialPageVasariTextNext1B.GetComponent<Button>();
		UITutorialPageVasariTextNext1BClick.onClick.AddListener(UITutorialPageVasariTextNext1BClicking);
        
        // Vasari Text 2 Button
        Button UITutorialPageVasariTextNext2Click = UITutorialPageVasariTextNext2.GetComponent<Button>();
		UITutorialPageVasariTextNext2Click.onClick.AddListener(UITutorialPageVasariTextNext2Clicking);
        
        // Vasari Text 3 Button
        Button UITutorialPageVasariTextNext3Click = UITutorialPageVasariTextNext3.GetComponent<Button>();
		UITutorialPageVasariTextNext3Click.onClick.AddListener(UITutorialPageVasariTextNext3Clicking);
        
        // Vasari Text 4 Button
        Button UITutorialPageVasariTextNext4Click = UITutorialPageVasariTextNext4.GetComponent<Button>();
		UITutorialPageVasariTextNext4Click.onClick.AddListener(UITutorialPageVasariTextNext4Clicking);
        
        // Vasari Text 5 Button
        Button UITutorialPageVasariTextNext5Click = UITutorialPageVasariTextNext5.GetComponent<Button>();
		UITutorialPageVasariTextNext5Click.onClick.AddListener(UITutorialPageVasariTextNext5Clicking);
        
        // Vasari Text 6 Button
        Button UITutorialPageVasariTextNext6Click = UITutorialPageVasariTextNext6.GetComponent<Button>();
		UITutorialPageVasariTextNext6Click.onClick.AddListener(UITutorialPageVasariTextNext6Clicking);
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
    public void UITutorialPageVasariTextNext1Clicking() {
        Tutorial09VasariText1Disabling.Tutorial09VasariText1Disable();
        Tutorial09VasariText1BEnabling.Tutorial09VasariText1BEnable();
    }
    
    public void UITutorialPageVasariTextNext1BClicking() {
        Tutorial09VasariText1BDisabling.Tutorial09VasariText1BDisable();
        Tutorial09VasariText2Enabling.Tutorial09VasariText2Enable();
    }
    
    public void UITutorialPageVasariTextNext2Clicking() {
        Tutorial09VasariText2Disabling.Tutorial09VasariText2Disable();
        Tutorial09VasariText3Enabling.Tutorial09VasariText3Enable();
    }
    
    public void UITutorialPageVasariTextNext3Clicking() {
        Tutorial09VasariText3Disabling.Tutorial09VasariText3Disable();
        Tutorial09VasariText4Enabling.Tutorial09VasariText4Enable();
    }
    
    public void UITutorialPageVasariTextNext4Clicking() {
        Tutorial09VasariText4Disabling.Tutorial09VasariText4Disable();
        Tutorial09VasariText5Enabling.Tutorial09VasariText5Enable();
        Tutorial09AlertEnabling.Tutorial09AlertEnable();
    }
    
    public void UITutorialPageVasariTextNext5Clicking() {
        Tutorial09VasariText5Disabling.Tutorial09VasariText5Disable();
        Tutorial09VasariText6Enabling.Tutorial09VasariText6Enable();
    }
    
    public void UITutorialPageVasariTextNext6Clicking() {
        Scene05Loading.Scene05Load();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}