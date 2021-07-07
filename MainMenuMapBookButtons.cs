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

public class MainMenuMapBookButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Close Sketchbook Button
	public Button UIMapCloseButton;
	
	// Left-side Panel Buttons
	public Button UIMapMainButtonF1Off;
	public Button UIMapMainButtonF2Off;
	public Button UIMapMainButtonF3Off;
	public Button UIMapMainButtonG1Off;
	public Button UIMapMainButtonG2Off;
    public Button UIMapMainButtonG3Off;
	public Button UIMapMainButtonFBOff;
	public Button UIMapMainButtonF1On;
	public Button UIMapMainButtonF2On;
	public Button UIMapMainButtonF3On;
	public Button UIMapMainButtonG1On;
	public Button UIMapMainButtonG2On;
    public Button UIMapMainButtonG3On;
	public Button UIMapMainButtonFBOn;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Enabling Obejcts
	public MainMenuMapBookEnable MainCastleMapBookEnabling;
	public MainMenuMapBookEnable MainCastleMapBookF1Enabling;
	public MainMenuMapBookEnable MainCastleMapBookF2Enabling;
	public MainMenuMapBookEnable MainCastleMapBookF3Enabling;
	public MainMenuMapBookEnable MainCastleMapBookG1Enabling;
	public MainMenuMapBookEnable MainCastleMapBookG2Enabling;
    public MainMenuMapBookEnable MainCastleMapBookG3Enabling;
	public MainMenuMapBookEnable MainCastleMapBookFBEnabling;
	
	// Disabling Obejcts
	public MainMenuMapBookEnable MainCastleMapBookAllDisabling;
	public MainMenuMapBookEnable MainCastleMapBookF1Disabling;
	public MainMenuMapBookEnable MainCastleMapBookF2Disabling;
	public MainMenuMapBookEnable MainCastleMapBookF3Disabling;
	public MainMenuMapBookEnable MainCastleMapBookG1Disabling;
	public MainMenuMapBookEnable MainCastleMapBookG2Disabling;
    public MainMenuMapBookEnable MainCastleMapBookG3Disabling;
	public MainMenuMapBookEnable MainCastleMapBookFBDisabling;
	public MainMenuMapBookEnable MainCastleMapBookF1OffDisabling;
	public MainMenuMapBookEnable MainCastleMapBookF2OffDisabling;
	public MainMenuMapBookEnable MainCastleMapBookF3OffDisabling;
	public MainMenuMapBookEnable MainCastleMapBookG1OffDisabling;
	public MainMenuMapBookEnable MainCastleMapBookG2OffDisabling;
    public MainMenuMapBookEnable MainCastleMapBookG3OffDisabling;
	public MainMenuMapBookEnable MainCastleMapBookFBOffDisabling;
    public MainMenuMapBookEnable MainCastleMapBookTextDisabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		Button UIMapCloseButtonClick = UIMapCloseButton.GetComponent<Button>();
		Button UIMapMainButtonF1OffClick = UIMapMainButtonF1Off.GetComponent<Button>();
		Button UIMapMainButtonF2OffClick = UIMapMainButtonF2Off.GetComponent<Button>();
		Button UIMapMainButtonF3OffClick = UIMapMainButtonF3Off.GetComponent<Button>();
		Button UIMapMainButtonG1OffClick = UIMapMainButtonG1Off.GetComponent<Button>();
		Button UIMapMainButtonG2OffClick = UIMapMainButtonG2Off.GetComponent<Button>();
        Button UIMapMainButtonG3OffClick = UIMapMainButtonG3Off.GetComponent<Button>();
		Button UIMapMainButtonFBOffClick = UIMapMainButtonFBOff.GetComponent<Button>();
		Button UIMapMainButtonF1OnClick = UIMapMainButtonF1On.GetComponent<Button>();
		Button UIMapMainButtonF2OnClick = UIMapMainButtonF2On.GetComponent<Button>();
		Button UIMapMainButtonF3OnClick = UIMapMainButtonF3On.GetComponent<Button>();
		Button UIMapMainButtonG1OnClick = UIMapMainButtonG1On.GetComponent<Button>();
		Button UIMapMainButtonG2OnClick = UIMapMainButtonG2On.GetComponent<Button>();
        Button UIMapMainButtonG3OnClick = UIMapMainButtonG3On.GetComponent<Button>();
		Button UIMapMainButtonFBOnClick = UIMapMainButtonFBOn.GetComponent<Button>();
		
		UIMapCloseButtonClick.onClick.AddListener(UIMapCloseButtonClicking);
		UIMapMainButtonF1OffClick.onClick.AddListener(UIMapMainButtonF1OffClicking);
		UIMapMainButtonF2OffClick.onClick.AddListener(UIMapMainButtonF2OffClicking);
		UIMapMainButtonF3OffClick.onClick.AddListener(UIMapMainButtonF3OffClicking);
		UIMapMainButtonG1OffClick.onClick.AddListener(UIMapMainButtonG1OffClicking);
		UIMapMainButtonG2OffClick.onClick.AddListener(UIMapMainButtonG2OffClicking);
        UIMapMainButtonG3OffClick.onClick.AddListener(UIMapMainButtonG3OffClicking);
		UIMapMainButtonFBOffClick.onClick.AddListener(UIMapMainButtonFBOffClicking);
		UIMapMainButtonF1OnClick.onClick.AddListener(UIMapMainButtonF1OnClicking);
		UIMapMainButtonF2OnClick.onClick.AddListener(UIMapMainButtonF2OnClicking);
		UIMapMainButtonF3OnClick.onClick.AddListener(UIMapMainButtonF3OnClicking);
		UIMapMainButtonG1OnClick.onClick.AddListener(UIMapMainButtonG1OnClicking);
		UIMapMainButtonG2OnClick.onClick.AddListener(UIMapMainButtonG2OnClicking);
        UIMapMainButtonG3OnClick.onClick.AddListener(UIMapMainButtonG3OnClicking);
		UIMapMainButtonFBOnClick.onClick.AddListener(UIMapMainButtonFBOnClicking);
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
	public void DisableMapPages() {
		MainCastleMapBookF1Disabling.MainCastleMapBookF1Disable();
		MainCastleMapBookF2Disabling.MainCastleMapBookF2Disable();
		MainCastleMapBookF3Disabling.MainCastleMapBookF3Disable();
		MainCastleMapBookG1Disabling.MainCastleMapBookG1Disable();
		MainCastleMapBookG2Disabling.MainCastleMapBookG2Disable();
        MainCastleMapBookG3Disabling.MainCastleMapBookG3Disable();
		MainCastleMapBookFBDisabling.MainCastleMapBookFBDisable();
		MainCastleMapBookF1OffDisabling.MainCastleMapBookF1OffDisable();
		MainCastleMapBookF2OffDisabling.MainCastleMapBookF2OffDisable();
		MainCastleMapBookF3OffDisabling.MainCastleMapBookF3OffDisable();
		MainCastleMapBookG1OffDisabling.MainCastleMapBookG1OffDisable();
		MainCastleMapBookG2OffDisabling.MainCastleMapBookG2OffDisable();
        MainCastleMapBookG3OffDisabling.MainCastleMapBookG3OffDisable();
		MainCastleMapBookFBOffDisabling.MainCastleMapBookFBOffDisable();
        MainCastleMapBookTextDisabling.MainCastleMapBookTextDisable();
	}
	
	public void UIMapCloseButtonClicking() {
		MainCastleMapBookAllDisabling.MainCastleMapBookAllDisable();
	}
	
	// F1
	public void UIMapMainButtonF1OffClicking() {
		// Disable All
		DisableMapPages();
		
		// Show Off Pages
		MainCastleMapBookEnabling.MainCastleMapBookEnable();
		
		// Show Page F1
		MainCastleMapBookF1Enabling.MainCastleMapBookF1Enable();
	}
	
	public void UIMapMainButtonF1OnClicking() {
		// Disable All
		DisableMapPages();
		
		// Show Off Pages
		MainCastleMapBookEnabling.MainCastleMapBookEnable();
		
		// Show Page F1
		MainCastleMapBookF1Enabling.MainCastleMapBookF1Enable();
	}
	
	// F2
	public void UIMapMainButtonF2OffClicking() {
		// Disable All
		DisableMapPages();
		
		// Show Off Pages
		MainCastleMapBookEnabling.MainCastleMapBookEnable();
		
		// Show Page F2
		MainCastleMapBookF1Enabling.MainCastleMapBookF2Enable();
	}
	
	public void UIMapMainButtonF2OnClicking() {
		// Disable All
		DisableMapPages();
		
		// Show Off Pages
		MainCastleMapBookEnabling.MainCastleMapBookEnable();
		
		// Show Page F2
		MainCastleMapBookF1Enabling.MainCastleMapBookF2Enable();
	}
	
	// F3
	public void UIMapMainButtonF3OffClicking() {
		// Disable All
		DisableMapPages();
		
		// Show Off Pages
		MainCastleMapBookEnabling.MainCastleMapBookEnable();
		
		// Show Page F3
		MainCastleMapBookF1Enabling.MainCastleMapBookF3Enable();
	}
	
	public void UIMapMainButtonF3OnClicking() {
		// Disable All
		DisableMapPages();
		
		// Show Off Pages
		MainCastleMapBookEnabling.MainCastleMapBookEnable();
		
		// Show Page F3
		MainCastleMapBookF1Enabling.MainCastleMapBookF3Enable();
	}
	
	// G1
	public void UIMapMainButtonG1OffClicking() {
		// Disable All
		DisableMapPages();
		
		// Show Off Pages
		MainCastleMapBookEnabling.MainCastleMapBookEnable();
		
		// Show Page G1
		MainCastleMapBookF1Enabling.MainCastleMapBookG1Enable();
	}
	
	public void UIMapMainButtonG1OnClicking() {
		// Disable All
		DisableMapPages();
		
		// Show Off Pages
		MainCastleMapBookEnabling.MainCastleMapBookEnable();
		
		// Show Page G1
		MainCastleMapBookF1Enabling.MainCastleMapBookG1Enable();
	}
	
	// G2
	public void UIMapMainButtonG2OffClicking() {
		// Disable All
		DisableMapPages();
		
		// Show Off Pages
		MainCastleMapBookEnabling.MainCastleMapBookEnable();
		
		// Show Page G2
		MainCastleMapBookF1Enabling.MainCastleMapBookG2Enable();
	}
	
	public void UIMapMainButtonG2OnClicking() {
		// Disable All
		DisableMapPages();
		
		// Show Off Pages
		MainCastleMapBookEnabling.MainCastleMapBookEnable();
		
		// Show Page G2
		MainCastleMapBookF1Enabling.MainCastleMapBookG2Enable();
	}
    
    // G3
	public void UIMapMainButtonG3OffClicking() {
		// Disable All
		DisableMapPages();
		
		// Show Off Pages
		MainCastleMapBookEnabling.MainCastleMapBookEnable();
		
		// Show Page G3
		MainCastleMapBookF1Enabling.MainCastleMapBookG3Enable();
	}
	
	public void UIMapMainButtonG3OnClicking() {
		// Disable All
		DisableMapPages();
		
		// Show Off Pages
		MainCastleMapBookEnabling.MainCastleMapBookEnable();
		
		// Show Page G3
		MainCastleMapBookF1Enabling.MainCastleMapBookG3Enable();
	}
	
	// FB
	public void UIMapMainButtonFBOffClicking() {
		// Disable All
		DisableMapPages();
		
		// Show Off Pages
		MainCastleMapBookEnabling.MainCastleMapBookEnable();
		
		// Show Page FB
		MainCastleMapBookF1Enabling.MainCastleMapBookFBEnable();
	}
	
	public void UIMapMainButtonFBOnClicking() {
		// Disable All
		DisableMapPages();
		
		// Show Off Pages
		MainCastleMapBookEnabling.MainCastleMapBookEnable();
		
		// Show Page FB
		MainCastleMapBookF1Enabling.MainCastleMapBookFBEnable();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}