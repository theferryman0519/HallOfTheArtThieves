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

public class MainMenuGhostBookButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Close Sketchbook Button
	public Button UIGhostArtBookCloseButton;
	
	// Left-side Panel Buttons
	public Button UIGhostArtInfoMainButtonF1Off;
	public Button UIGhostArtInfoMainButtonF2Off;
	public Button UIGhostArtInfoMainButtonF3Off;
	public Button UIGhostArtInfoMainButtonG1Off;
	public Button UIGhostArtInfoMainButtonG2Off;
    public Button UIGhostArtInfoMainButtonG3Off;
	public Button UIGhostArtInfoMainButtonFBOff;
	public Button UIGhostArtInfoMainButtonArtOff;
	public Button UIGhostArtInfoMainButtonF1On;
	public Button UIGhostArtInfoMainButtonF2On;
	public Button UIGhostArtInfoMainButtonF3On;
	public Button UIGhostArtInfoMainButtonG1On;
	public Button UIGhostArtInfoMainButtonG2On;
    public Button UIGhostArtInfoMainButtonG3On;
	public Button UIGhostArtInfoMainButtonFBOn;
	public Button UIGhostArtInfoMainButtonArtOn;
	
	// Filling In Text Information
	public Text UIGhostArtInfoTitle;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Enable Objects
	public MainMenuGhostBookEnable FMainUIGhostArtF1GhostImagesEnabling;
	public MainMenuGhostBookEnable FMainUIGhostArtF2GhostImagesEnabling;
	public MainMenuGhostBookEnable FMainUIGhostArtF3GhostImagesEnabling;
	public MainMenuGhostBookEnable FMainUIGhostArtG1GhostImagesEnabling;
	public MainMenuGhostBookEnable FMainUIGhostArtG2GhostImagesEnabling;
    public MainMenuGhostBookEnable FMainUIGhostArtG3GhostImagesEnabling;
	public MainMenuGhostBookEnable FMainUIGhostArtFBGhostImagesEnabling;
	public MainMenuGhostBookEnable FMainUIGhostArtArtPageEnabling;
	public MainMenuGhostBookEnable FMainUIGhostArtPageTextEnabling;
	public MainMenuGhostBookEnable FMainUIGhostArtF1OffEnabling;
	public MainMenuGhostBookEnable FMainUIGhostArtF2OffEnabling;
	public MainMenuGhostBookEnable FMainUIGhostArtF3OffEnabling;
	public MainMenuGhostBookEnable FMainUIGhostArtG1OffEnabling;
	public MainMenuGhostBookEnable FMainUIGhostArtG2OffEnabling;
    public MainMenuGhostBookEnable FMainUIGhostArtG3OffEnabling;
	public MainMenuGhostBookEnable FMainUIGhostArtFBOffEnabling;
	public MainMenuGhostBookEnable FMainUIGhostArtArtOffEnabling;
	public MainMenuGhostBookEnable FMainUIGhostArtInfoTitleEnabling;
    public MainMenuGhostBookEnable FMainUIGhostArtInfoTextEnabling;
    public MainMenuGhostBookEnable FMainUIGhostArtInfoGhostTextEnabling;
	
	// Disable Objects
	public MainMenuGhostBookEnable FMainUIGhostArtAllDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtF1GhostImagesDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtF2GhostImagesDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtF3GhostImagesDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtG1GhostImagesDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtG2GhostImagesDisabling;
    public MainMenuGhostBookEnable FMainUIGhostArtG3GhostImagesDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtFBGhostImagesDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtArtPageDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtPageTextDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtF1OffDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtF2OffDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtF3OffDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtG1OffDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtG2OffDisabling;
    public MainMenuGhostBookEnable FMainUIGhostArtG3OffDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtFBOffDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtArtOffDisabling;
	public MainMenuGhostBookEnable FMainUIGhostArtInfoTitleDisabling;
    public MainMenuGhostBookEnable FMainUIGhostArtInfoTextDisabling;
    public MainMenuGhostBookEnable FMainUIGhostArtInfoGhostTextDisabling;
		
	// Load Art Book
	public SceneLoad Scene36Loading;
    
    // Playing Pausing Timers
    public PausingPlayingTimers AllTimersPausing;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		Button UIGhostArtBookCloseButtonClick = UIGhostArtBookCloseButton.GetComponent<Button>();
		Button UIGhostArtInfoMainButtonF1OffClick = UIGhostArtInfoMainButtonF1Off.GetComponent<Button>();
		Button UIGhostArtInfoMainButtonF2OffClick = UIGhostArtInfoMainButtonF2Off.GetComponent<Button>();
		Button UIGhostArtInfoMainButtonF3OffClick = UIGhostArtInfoMainButtonF3Off.GetComponent<Button>();
		Button UIGhostArtInfoMainButtonG1OffClick = UIGhostArtInfoMainButtonG1Off.GetComponent<Button>();
		Button UIGhostArtInfoMainButtonG2OffClick = UIGhostArtInfoMainButtonG2Off.GetComponent<Button>();
        Button UIGhostArtInfoMainButtonG3OffClick = UIGhostArtInfoMainButtonG3Off.GetComponent<Button>();
		Button UIGhostArtInfoMainButtonFBOffClick = UIGhostArtInfoMainButtonFBOff.GetComponent<Button>();
		Button UIGhostArtInfoMainButtonArtOffClick = UIGhostArtInfoMainButtonArtOff.GetComponent<Button>();
		Button UIGhostArtInfoMainButtonF1OnClick = UIGhostArtInfoMainButtonF1On.GetComponent<Button>();
		Button UIGhostArtInfoMainButtonF2OnClick = UIGhostArtInfoMainButtonF2On.GetComponent<Button>();
		Button UIGhostArtInfoMainButtonF3OnClick = UIGhostArtInfoMainButtonF3On.GetComponent<Button>();
		Button UIGhostArtInfoMainButtonG1OnClick = UIGhostArtInfoMainButtonG1On.GetComponent<Button>();
		Button UIGhostArtInfoMainButtonG2OnClick = UIGhostArtInfoMainButtonG2On.GetComponent<Button>();
        Button UIGhostArtInfoMainButtonG3OnClick = UIGhostArtInfoMainButtonG3On.GetComponent<Button>();
		Button UIGhostArtInfoMainButtonFBOnClick = UIGhostArtInfoMainButtonFBOn.GetComponent<Button>();
		Button UIGhostArtInfoMainButtonArtOnClick = UIGhostArtInfoMainButtonArtOn.GetComponent<Button>();
		
		UIGhostArtBookCloseButtonClick.onClick.AddListener(UIGhostArtBookCloseButtonClicking);
		UIGhostArtInfoMainButtonF1OffClick.onClick.AddListener(UIGhostArtInfoMainButtonF1OffClicking);
		UIGhostArtInfoMainButtonF2OffClick.onClick.AddListener(UIGhostArtInfoMainButtonF2OffClicking);
		UIGhostArtInfoMainButtonF3OffClick.onClick.AddListener(UIGhostArtInfoMainButtonF3OffClicking);
		UIGhostArtInfoMainButtonG1OffClick.onClick.AddListener(UIGhostArtInfoMainButtonG1OffClicking);
		UIGhostArtInfoMainButtonG2OffClick.onClick.AddListener(UIGhostArtInfoMainButtonG2OffClicking);
        UIGhostArtInfoMainButtonG3OffClick.onClick.AddListener(UIGhostArtInfoMainButtonG3OffClicking);
		UIGhostArtInfoMainButtonFBOffClick.onClick.AddListener(UIGhostArtInfoMainButtonFBOffClicking);
		UIGhostArtInfoMainButtonArtOffClick.onClick.AddListener(UIGhostArtInfoMainButtonArtOffClicking);
		UIGhostArtInfoMainButtonF1OnClick.onClick.AddListener(UIGhostArtInfoMainButtonF1OnClicking);
		UIGhostArtInfoMainButtonF2OnClick.onClick.AddListener(UIGhostArtInfoMainButtonF2OnClicking);
		UIGhostArtInfoMainButtonF3OnClick.onClick.AddListener(UIGhostArtInfoMainButtonF3OnClicking);
		UIGhostArtInfoMainButtonG1OnClick.onClick.AddListener(UIGhostArtInfoMainButtonG1OnClicking);
		UIGhostArtInfoMainButtonG2OnClick.onClick.AddListener(UIGhostArtInfoMainButtonG2OnClicking);
        UIGhostArtInfoMainButtonG3OnClick.onClick.AddListener(UIGhostArtInfoMainButtonG3OnClicking);
		UIGhostArtInfoMainButtonFBOnClick.onClick.AddListener(UIGhostArtInfoMainButtonFBOnClicking);
		UIGhostArtInfoMainButtonArtOnClick.onClick.AddListener(UIGhostArtInfoMainButtonArtOnClicking);
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
	public void UIGhostArtBookCloseButtonClicking() {
		FMainUIGhostArtAllDisabling.FMainUIGhostArtAllDisable();
	}
	
	public void UIGhostArtInfoMainButtonF1OffClicking() {
		// Disbale All Other Pages
		FMainUIGhostArtF1GhostImagesDisabling.FMainUIGhostArtF1GhostImagesDisable();
		FMainUIGhostArtF2GhostImagesDisabling.FMainUIGhostArtF2GhostImagesDisable();
		FMainUIGhostArtF3GhostImagesDisabling.FMainUIGhostArtF3GhostImagesDisable();
		FMainUIGhostArtG1GhostImagesDisabling.FMainUIGhostArtG1GhostImagesDisable();
		FMainUIGhostArtG2GhostImagesDisabling.FMainUIGhostArtG2GhostImagesDisable();
        FMainUIGhostArtG3GhostImagesDisabling.FMainUIGhostArtG3GhostImagesDisable();
		FMainUIGhostArtFBGhostImagesDisabling.FMainUIGhostArtFBGhostImagesDisable();
		FMainUIGhostArtPageTextDisabling.FMainUIGhostArtPageTextDisable();
		FMainUIGhostArtF1OffEnabling.FMainUIGhostArtF1OffEnable();
		FMainUIGhostArtF2OffEnabling.FMainUIGhostArtF2OffEnable();
		FMainUIGhostArtF3OffEnabling.FMainUIGhostArtF3OffEnable();
		FMainUIGhostArtG1OffEnabling.FMainUIGhostArtG1OffEnable();
		FMainUIGhostArtG2OffEnabling.FMainUIGhostArtG2OffEnable();
        FMainUIGhostArtG3OffEnabling.FMainUIGhostArtG3OffEnable();
		FMainUIGhostArtFBOffEnabling.FMainUIGhostArtFBOffEnable();
		FMainUIGhostArtArtOffEnabling.FMainUIGhostArtArtOffEnable();
		FMainUIGhostArtInfoTitleDisabling.FMainUIGhostArtInfoTitleDisable();
        FMainUIGhostArtInfoTextDisabling.FMainUIGhostArtInfoTextDisable();
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
		
		// Enable This Page
		FMainUIGhostArtF1OffDisabling.FMainUIGhostArtF1OffDisable();
		FMainUIGhostArtF1GhostImagesEnabling.FMainUIGhostArtF1GhostImagesEnable();
		FMainUIGhostArtInfoTitleEnabling.FMainUIGhostArtInfoTitleEnable();
		UIGhostArtInfoTitle.text = "Ghost Info: " + "First Floor";
        FMainUIGhostArtInfoGhostTextEnabling.FMainUIGhostArtInfoGhostTextEnable();
	}
	
	public void UIGhostArtInfoMainButtonF2OffClicking() {
		// Disbale All Other Pages
		FMainUIGhostArtF1GhostImagesDisabling.FMainUIGhostArtF1GhostImagesDisable();
		FMainUIGhostArtF2GhostImagesDisabling.FMainUIGhostArtF2GhostImagesDisable();
		FMainUIGhostArtF3GhostImagesDisabling.FMainUIGhostArtF3GhostImagesDisable();
		FMainUIGhostArtG1GhostImagesDisabling.FMainUIGhostArtG1GhostImagesDisable();
		FMainUIGhostArtG2GhostImagesDisabling.FMainUIGhostArtG2GhostImagesDisable();
        FMainUIGhostArtG3GhostImagesDisabling.FMainUIGhostArtG3GhostImagesDisable();
		FMainUIGhostArtFBGhostImagesDisabling.FMainUIGhostArtFBGhostImagesDisable();
		FMainUIGhostArtPageTextDisabling.FMainUIGhostArtPageTextDisable();
		FMainUIGhostArtF1OffEnabling.FMainUIGhostArtF1OffEnable();
		FMainUIGhostArtF2OffEnabling.FMainUIGhostArtF2OffEnable();
		FMainUIGhostArtF3OffEnabling.FMainUIGhostArtF3OffEnable();
		FMainUIGhostArtG1OffEnabling.FMainUIGhostArtG1OffEnable();
		FMainUIGhostArtG2OffEnabling.FMainUIGhostArtG2OffEnable();
        FMainUIGhostArtG3OffEnabling.FMainUIGhostArtG3OffEnable();
		FMainUIGhostArtFBOffEnabling.FMainUIGhostArtFBOffEnable();
		FMainUIGhostArtArtOffEnabling.FMainUIGhostArtArtOffEnable();
		FMainUIGhostArtInfoTitleDisabling.FMainUIGhostArtInfoTitleDisable();
        FMainUIGhostArtInfoTextDisabling.FMainUIGhostArtInfoTextDisable();
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
		
		// Enable This Page
		FMainUIGhostArtF2OffDisabling.FMainUIGhostArtF2OffDisable();
		FMainUIGhostArtF2GhostImagesEnabling.FMainUIGhostArtF2GhostImagesEnable();
		FMainUIGhostArtInfoTitleEnabling.FMainUIGhostArtInfoTitleEnable();
		UIGhostArtInfoTitle.text = "Ghost Info: " + "Second Floor";
        FMainUIGhostArtInfoGhostTextEnabling.FMainUIGhostArtInfoGhostTextEnable();
	}
	
	public void UIGhostArtInfoMainButtonF3OffClicking() {
		// Disbale All Other Pages
		FMainUIGhostArtF1GhostImagesDisabling.FMainUIGhostArtF1GhostImagesDisable();
		FMainUIGhostArtF2GhostImagesDisabling.FMainUIGhostArtF2GhostImagesDisable();
		FMainUIGhostArtF3GhostImagesDisabling.FMainUIGhostArtF3GhostImagesDisable();
		FMainUIGhostArtG1GhostImagesDisabling.FMainUIGhostArtG1GhostImagesDisable();
		FMainUIGhostArtG2GhostImagesDisabling.FMainUIGhostArtG2GhostImagesDisable();
        FMainUIGhostArtG3GhostImagesDisabling.FMainUIGhostArtG3GhostImagesDisable();
		FMainUIGhostArtFBGhostImagesDisabling.FMainUIGhostArtFBGhostImagesDisable();
		FMainUIGhostArtPageTextDisabling.FMainUIGhostArtPageTextDisable();
		FMainUIGhostArtF1OffEnabling.FMainUIGhostArtF1OffEnable();
		FMainUIGhostArtF2OffEnabling.FMainUIGhostArtF2OffEnable();
		FMainUIGhostArtF3OffEnabling.FMainUIGhostArtF3OffEnable();
		FMainUIGhostArtG1OffEnabling.FMainUIGhostArtG1OffEnable();
		FMainUIGhostArtG2OffEnabling.FMainUIGhostArtG2OffEnable();
        FMainUIGhostArtG3OffEnabling.FMainUIGhostArtG3OffEnable();
		FMainUIGhostArtFBOffEnabling.FMainUIGhostArtFBOffEnable();
		FMainUIGhostArtArtOffEnabling.FMainUIGhostArtArtOffEnable();
		FMainUIGhostArtInfoTitleDisabling.FMainUIGhostArtInfoTitleDisable();
        FMainUIGhostArtInfoTextDisabling.FMainUIGhostArtInfoTextDisable();
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
		
		// Enable This Page
		FMainUIGhostArtF3OffDisabling.FMainUIGhostArtF3OffDisable();
		FMainUIGhostArtF3GhostImagesEnabling.FMainUIGhostArtF3GhostImagesEnable();
		FMainUIGhostArtInfoTitleEnabling.FMainUIGhostArtInfoTitleEnable();
		UIGhostArtInfoTitle.text = "Ghost Info: " + "Third Floor";
        FMainUIGhostArtInfoGhostTextEnabling.FMainUIGhostArtInfoGhostTextEnable();
	}
	
	public void UIGhostArtInfoMainButtonG1OffClicking() {
		// Disbale All Other Pages
		FMainUIGhostArtF1GhostImagesDisabling.FMainUIGhostArtF1GhostImagesDisable();
		FMainUIGhostArtF2GhostImagesDisabling.FMainUIGhostArtF2GhostImagesDisable();
		FMainUIGhostArtF3GhostImagesDisabling.FMainUIGhostArtF3GhostImagesDisable();
		FMainUIGhostArtG1GhostImagesDisabling.FMainUIGhostArtG1GhostImagesDisable();
		FMainUIGhostArtG2GhostImagesDisabling.FMainUIGhostArtG2GhostImagesDisable();
        FMainUIGhostArtG3GhostImagesDisabling.FMainUIGhostArtG3GhostImagesDisable();
		FMainUIGhostArtFBGhostImagesDisabling.FMainUIGhostArtFBGhostImagesDisable();
		FMainUIGhostArtPageTextDisabling.FMainUIGhostArtPageTextDisable();
		FMainUIGhostArtF1OffEnabling.FMainUIGhostArtF1OffEnable();
		FMainUIGhostArtF2OffEnabling.FMainUIGhostArtF2OffEnable();
		FMainUIGhostArtF3OffEnabling.FMainUIGhostArtF3OffEnable();
		FMainUIGhostArtG1OffEnabling.FMainUIGhostArtG1OffEnable();
		FMainUIGhostArtG2OffEnabling.FMainUIGhostArtG2OffEnable();
        FMainUIGhostArtG3OffEnabling.FMainUIGhostArtG3OffEnable();
		FMainUIGhostArtFBOffEnabling.FMainUIGhostArtFBOffEnable();
		FMainUIGhostArtArtOffEnabling.FMainUIGhostArtArtOffEnable();
		FMainUIGhostArtInfoTitleDisabling.FMainUIGhostArtInfoTitleDisable();
        FMainUIGhostArtInfoTextDisabling.FMainUIGhostArtInfoTextDisable();
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
		
		// Enable This Page
		FMainUIGhostArtG1OffDisabling.FMainUIGhostArtG1OffDisable();
		FMainUIGhostArtG1GhostImagesEnabling.FMainUIGhostArtG1GhostImagesEnable();
		FMainUIGhostArtInfoTitleEnabling.FMainUIGhostArtInfoTitleEnable();
		UIGhostArtInfoTitle.text = "Ghost Info: " + "First Garden";
        FMainUIGhostArtInfoGhostTextEnabling.FMainUIGhostArtInfoGhostTextEnable();
	}
	
	public void UIGhostArtInfoMainButtonG2OffClicking() {
		// Disbale All Other Pages
		FMainUIGhostArtF1GhostImagesDisabling.FMainUIGhostArtF1GhostImagesDisable();
		FMainUIGhostArtF2GhostImagesDisabling.FMainUIGhostArtF2GhostImagesDisable();
		FMainUIGhostArtF3GhostImagesDisabling.FMainUIGhostArtF3GhostImagesDisable();
		FMainUIGhostArtG1GhostImagesDisabling.FMainUIGhostArtG1GhostImagesDisable();
		FMainUIGhostArtG2GhostImagesDisabling.FMainUIGhostArtG2GhostImagesDisable();
        FMainUIGhostArtG3GhostImagesDisabling.FMainUIGhostArtG3GhostImagesDisable();
		FMainUIGhostArtFBGhostImagesDisabling.FMainUIGhostArtFBGhostImagesDisable();
		FMainUIGhostArtPageTextDisabling.FMainUIGhostArtPageTextDisable();
		FMainUIGhostArtF1OffEnabling.FMainUIGhostArtF1OffEnable();
		FMainUIGhostArtF2OffEnabling.FMainUIGhostArtF2OffEnable();
		FMainUIGhostArtF3OffEnabling.FMainUIGhostArtF3OffEnable();
		FMainUIGhostArtG1OffEnabling.FMainUIGhostArtG1OffEnable();
		FMainUIGhostArtG2OffEnabling.FMainUIGhostArtG2OffEnable();
        FMainUIGhostArtG3OffEnabling.FMainUIGhostArtG3OffEnable();
		FMainUIGhostArtFBOffEnabling.FMainUIGhostArtFBOffEnable();
		FMainUIGhostArtArtOffEnabling.FMainUIGhostArtArtOffEnable();
		FMainUIGhostArtInfoTitleDisabling.FMainUIGhostArtInfoTitleDisable();
        FMainUIGhostArtInfoTextDisabling.FMainUIGhostArtInfoTextDisable();
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
		
		// Enable This Page
		FMainUIGhostArtG2OffDisabling.FMainUIGhostArtG2OffDisable();
		FMainUIGhostArtG2GhostImagesEnabling.FMainUIGhostArtG2GhostImagesEnable();
		FMainUIGhostArtInfoTitleEnabling.FMainUIGhostArtInfoTitleEnable();
		UIGhostArtInfoTitle.text = "Ghost Info: " + "Second Garden";
        FMainUIGhostArtInfoGhostTextEnabling.FMainUIGhostArtInfoGhostTextEnable();
	}
    
    public void UIGhostArtInfoMainButtonG3OffClicking() {
		// Disbale All Other Pages
		FMainUIGhostArtF1GhostImagesDisabling.FMainUIGhostArtF1GhostImagesDisable();
		FMainUIGhostArtF2GhostImagesDisabling.FMainUIGhostArtF2GhostImagesDisable();
		FMainUIGhostArtF3GhostImagesDisabling.FMainUIGhostArtF3GhostImagesDisable();
		FMainUIGhostArtG1GhostImagesDisabling.FMainUIGhostArtG1GhostImagesDisable();
		FMainUIGhostArtG2GhostImagesDisabling.FMainUIGhostArtG2GhostImagesDisable();
        FMainUIGhostArtG3GhostImagesDisabling.FMainUIGhostArtG3GhostImagesDisable();
		FMainUIGhostArtFBGhostImagesDisabling.FMainUIGhostArtFBGhostImagesDisable();
		FMainUIGhostArtPageTextDisabling.FMainUIGhostArtPageTextDisable();
		FMainUIGhostArtF1OffEnabling.FMainUIGhostArtF1OffEnable();
		FMainUIGhostArtF2OffEnabling.FMainUIGhostArtF2OffEnable();
		FMainUIGhostArtF3OffEnabling.FMainUIGhostArtF3OffEnable();
		FMainUIGhostArtG1OffEnabling.FMainUIGhostArtG1OffEnable();
		FMainUIGhostArtG2OffEnabling.FMainUIGhostArtG2OffEnable();
        FMainUIGhostArtG3OffEnabling.FMainUIGhostArtG3OffEnable();
		FMainUIGhostArtFBOffEnabling.FMainUIGhostArtFBOffEnable();
		FMainUIGhostArtArtOffEnabling.FMainUIGhostArtArtOffEnable();
		FMainUIGhostArtInfoTitleDisabling.FMainUIGhostArtInfoTitleDisable();
        FMainUIGhostArtInfoTextDisabling.FMainUIGhostArtInfoTextDisable();
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
		
		// Enable This Page
		FMainUIGhostArtG3OffDisabling.FMainUIGhostArtG3OffDisable();
		FMainUIGhostArtG3GhostImagesEnabling.FMainUIGhostArtG3GhostImagesEnable();
		FMainUIGhostArtInfoTitleEnabling.FMainUIGhostArtInfoTitleEnable();
		UIGhostArtInfoTitle.text = "Ghost Info: " + "Third Garden";
        FMainUIGhostArtInfoGhostTextEnabling.FMainUIGhostArtInfoGhostTextEnable();
	}
	
	public void UIGhostArtInfoMainButtonFBOffClicking() {
		// Disbale All Other Pages
		FMainUIGhostArtF1GhostImagesDisabling.FMainUIGhostArtF1GhostImagesDisable();
		FMainUIGhostArtF2GhostImagesDisabling.FMainUIGhostArtF2GhostImagesDisable();
		FMainUIGhostArtF3GhostImagesDisabling.FMainUIGhostArtF3GhostImagesDisable();
		FMainUIGhostArtG1GhostImagesDisabling.FMainUIGhostArtG1GhostImagesDisable();
		FMainUIGhostArtG2GhostImagesDisabling.FMainUIGhostArtG2GhostImagesDisable();
        FMainUIGhostArtG3GhostImagesDisabling.FMainUIGhostArtG3GhostImagesDisable();
		FMainUIGhostArtFBGhostImagesDisabling.FMainUIGhostArtFBGhostImagesDisable();
		FMainUIGhostArtPageTextDisabling.FMainUIGhostArtPageTextDisable();
		FMainUIGhostArtF1OffEnabling.FMainUIGhostArtF1OffEnable();
		FMainUIGhostArtF2OffEnabling.FMainUIGhostArtF2OffEnable();
		FMainUIGhostArtF3OffEnabling.FMainUIGhostArtF3OffEnable();
		FMainUIGhostArtG1OffEnabling.FMainUIGhostArtG1OffEnable();
		FMainUIGhostArtG2OffEnabling.FMainUIGhostArtG2OffEnable();
        FMainUIGhostArtG3OffEnabling.FMainUIGhostArtG3OffEnable();
		FMainUIGhostArtFBOffEnabling.FMainUIGhostArtFBOffEnable();
		FMainUIGhostArtArtOffEnabling.FMainUIGhostArtArtOffEnable();
		FMainUIGhostArtInfoTitleDisabling.FMainUIGhostArtInfoTitleDisable();
        FMainUIGhostArtInfoTextDisabling.FMainUIGhostArtInfoTextDisable();
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
		
		// Enable This Page
		FMainUIGhostArtFBOffDisabling.FMainUIGhostArtFBOffDisable();
		FMainUIGhostArtFBGhostImagesEnabling.FMainUIGhostArtFBGhostImagesEnable();
		FMainUIGhostArtInfoTitleEnabling.FMainUIGhostArtInfoTitleEnable();
		UIGhostArtInfoTitle.text = "Ghost Info: " + "Basement";
        FMainUIGhostArtInfoGhostTextEnabling.FMainUIGhostArtInfoGhostTextEnable();
	}
	
	public void UIGhostArtInfoMainButtonArtOffClicking() {
        AllTimersPausing.AllTimersPause();
		Scene36Loading.Scene36Load();
	}
	
	public void UIGhostArtInfoMainButtonF1OnClicking() {
		// Disbale All Other Pages
		FMainUIGhostArtF1GhostImagesDisabling.FMainUIGhostArtF1GhostImagesDisable();
		FMainUIGhostArtF2GhostImagesDisabling.FMainUIGhostArtF2GhostImagesDisable();
		FMainUIGhostArtF3GhostImagesDisabling.FMainUIGhostArtF3GhostImagesDisable();
		FMainUIGhostArtG1GhostImagesDisabling.FMainUIGhostArtG1GhostImagesDisable();
		FMainUIGhostArtG2GhostImagesDisabling.FMainUIGhostArtG2GhostImagesDisable();
        FMainUIGhostArtG3GhostImagesDisabling.FMainUIGhostArtG3GhostImagesDisable();
		FMainUIGhostArtFBGhostImagesDisabling.FMainUIGhostArtFBGhostImagesDisable();
		FMainUIGhostArtPageTextDisabling.FMainUIGhostArtPageTextDisable();
		FMainUIGhostArtInfoTitleDisabling.FMainUIGhostArtInfoTitleDisable();
		FMainUIGhostArtF1OffEnabling.FMainUIGhostArtF1OffEnable();
        FMainUIGhostArtInfoTextDisabling.FMainUIGhostArtInfoTextDisable();
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
        // Enable Objects
        FMainUIGhostArtInfoTextEnabling.FMainUIGhostArtInfoTextEnable();
	}
	
	public void UIGhostArtInfoMainButtonF2OnClicking() {
		// Disbale All Other Pages
		FMainUIGhostArtF1GhostImagesDisabling.FMainUIGhostArtF1GhostImagesDisable();
		FMainUIGhostArtF2GhostImagesDisabling.FMainUIGhostArtF2GhostImagesDisable();
		FMainUIGhostArtF3GhostImagesDisabling.FMainUIGhostArtF3GhostImagesDisable();
		FMainUIGhostArtG1GhostImagesDisabling.FMainUIGhostArtG1GhostImagesDisable();
		FMainUIGhostArtG2GhostImagesDisabling.FMainUIGhostArtG2GhostImagesDisable();
        FMainUIGhostArtG3GhostImagesDisabling.FMainUIGhostArtG3GhostImagesDisable();
		FMainUIGhostArtFBGhostImagesDisabling.FMainUIGhostArtFBGhostImagesDisable();
		FMainUIGhostArtPageTextDisabling.FMainUIGhostArtPageTextDisable();
		FMainUIGhostArtInfoTitleDisabling.FMainUIGhostArtInfoTitleDisable();
		FMainUIGhostArtF2OffEnabling.FMainUIGhostArtF2OffEnable();
        FMainUIGhostArtInfoTextDisabling.FMainUIGhostArtInfoTextDisable();
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
        // Enable Objects
        FMainUIGhostArtInfoTextEnabling.FMainUIGhostArtInfoTextEnable();
	}
	
	public void UIGhostArtInfoMainButtonF3OnClicking() {
		// Disbale All Other Pages
		FMainUIGhostArtF1GhostImagesDisabling.FMainUIGhostArtF1GhostImagesDisable();
		FMainUIGhostArtF2GhostImagesDisabling.FMainUIGhostArtF2GhostImagesDisable();
		FMainUIGhostArtF3GhostImagesDisabling.FMainUIGhostArtF3GhostImagesDisable();
		FMainUIGhostArtG1GhostImagesDisabling.FMainUIGhostArtG1GhostImagesDisable();
		FMainUIGhostArtG2GhostImagesDisabling.FMainUIGhostArtG2GhostImagesDisable();
        FMainUIGhostArtG3GhostImagesDisabling.FMainUIGhostArtG3GhostImagesDisable();
		FMainUIGhostArtFBGhostImagesDisabling.FMainUIGhostArtFBGhostImagesDisable();
		FMainUIGhostArtPageTextDisabling.FMainUIGhostArtPageTextDisable();
		FMainUIGhostArtInfoTitleDisabling.FMainUIGhostArtInfoTitleDisable();
		FMainUIGhostArtF3OffEnabling.FMainUIGhostArtF3OffEnable();
        FMainUIGhostArtInfoTextDisabling.FMainUIGhostArtInfoTextDisable();
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
        // Enable Objects
        FMainUIGhostArtInfoTextEnabling.FMainUIGhostArtInfoTextEnable();
	}
	
	public void UIGhostArtInfoMainButtonG1OnClicking() {
		// Disbale All Other Pages
		FMainUIGhostArtF1GhostImagesDisabling.FMainUIGhostArtF1GhostImagesDisable();
		FMainUIGhostArtF2GhostImagesDisabling.FMainUIGhostArtF2GhostImagesDisable();
		FMainUIGhostArtF3GhostImagesDisabling.FMainUIGhostArtF3GhostImagesDisable();
		FMainUIGhostArtG1GhostImagesDisabling.FMainUIGhostArtG1GhostImagesDisable();
		FMainUIGhostArtG2GhostImagesDisabling.FMainUIGhostArtG2GhostImagesDisable();
        FMainUIGhostArtG3GhostImagesDisabling.FMainUIGhostArtG3GhostImagesDisable();
		FMainUIGhostArtFBGhostImagesDisabling.FMainUIGhostArtFBGhostImagesDisable();
		FMainUIGhostArtPageTextDisabling.FMainUIGhostArtPageTextDisable();
		FMainUIGhostArtInfoTitleDisabling.FMainUIGhostArtInfoTitleDisable();
		FMainUIGhostArtG1OffEnabling.FMainUIGhostArtG1OffEnable();
        FMainUIGhostArtInfoTextDisabling.FMainUIGhostArtInfoTextDisable();
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
        // Enable Objects
        FMainUIGhostArtInfoTextEnabling.FMainUIGhostArtInfoTextEnable();
	}
	
	public void UIGhostArtInfoMainButtonG2OnClicking() {
		// Disbale All Other Pages
		FMainUIGhostArtF1GhostImagesDisabling.FMainUIGhostArtF1GhostImagesDisable();
		FMainUIGhostArtF2GhostImagesDisabling.FMainUIGhostArtF2GhostImagesDisable();
		FMainUIGhostArtF3GhostImagesDisabling.FMainUIGhostArtF3GhostImagesDisable();
		FMainUIGhostArtG1GhostImagesDisabling.FMainUIGhostArtG1GhostImagesDisable();
		FMainUIGhostArtG2GhostImagesDisabling.FMainUIGhostArtG2GhostImagesDisable();
        FMainUIGhostArtG3GhostImagesDisabling.FMainUIGhostArtG3GhostImagesDisable();
		FMainUIGhostArtFBGhostImagesDisabling.FMainUIGhostArtFBGhostImagesDisable();
		FMainUIGhostArtPageTextDisabling.FMainUIGhostArtPageTextDisable();
		FMainUIGhostArtInfoTitleDisabling.FMainUIGhostArtInfoTitleDisable();
		FMainUIGhostArtG2OffEnabling.FMainUIGhostArtG2OffEnable();
        FMainUIGhostArtInfoTextDisabling.FMainUIGhostArtInfoTextDisable();
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
        // Enable Objects
        FMainUIGhostArtInfoTextEnabling.FMainUIGhostArtInfoTextEnable();
	}
    
    public void UIGhostArtInfoMainButtonG3OnClicking() {
		// Disbale All Other Pages
		FMainUIGhostArtF1GhostImagesDisabling.FMainUIGhostArtF1GhostImagesDisable();
		FMainUIGhostArtF2GhostImagesDisabling.FMainUIGhostArtF2GhostImagesDisable();
		FMainUIGhostArtF3GhostImagesDisabling.FMainUIGhostArtF3GhostImagesDisable();
		FMainUIGhostArtG1GhostImagesDisabling.FMainUIGhostArtG1GhostImagesDisable();
		FMainUIGhostArtG2GhostImagesDisabling.FMainUIGhostArtG2GhostImagesDisable();
        FMainUIGhostArtG3GhostImagesDisabling.FMainUIGhostArtG3GhostImagesDisable();
		FMainUIGhostArtFBGhostImagesDisabling.FMainUIGhostArtFBGhostImagesDisable();
		FMainUIGhostArtPageTextDisabling.FMainUIGhostArtPageTextDisable();
		FMainUIGhostArtInfoTitleDisabling.FMainUIGhostArtInfoTitleDisable();
		FMainUIGhostArtG3OffEnabling.FMainUIGhostArtG3OffEnable();
        FMainUIGhostArtInfoTextDisabling.FMainUIGhostArtInfoTextDisable();
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
        // Enable Objects
        FMainUIGhostArtInfoTextEnabling.FMainUIGhostArtInfoTextEnable();
	}
	
	public void UIGhostArtInfoMainButtonFBOnClicking() {
		// Disbale All Other Pages
		FMainUIGhostArtF1GhostImagesDisabling.FMainUIGhostArtF1GhostImagesDisable();
		FMainUIGhostArtF2GhostImagesDisabling.FMainUIGhostArtF2GhostImagesDisable();
		FMainUIGhostArtF3GhostImagesDisabling.FMainUIGhostArtF3GhostImagesDisable();
		FMainUIGhostArtG1GhostImagesDisabling.FMainUIGhostArtG1GhostImagesDisable();
		FMainUIGhostArtG2GhostImagesDisabling.FMainUIGhostArtG2GhostImagesDisable();
        FMainUIGhostArtG3GhostImagesDisabling.FMainUIGhostArtG3GhostImagesDisable();
		FMainUIGhostArtFBGhostImagesDisabling.FMainUIGhostArtFBGhostImagesDisable();
		FMainUIGhostArtPageTextDisabling.FMainUIGhostArtPageTextDisable();
		FMainUIGhostArtInfoTitleDisabling.FMainUIGhostArtInfoTitleDisable();
		FMainUIGhostArtFBOffEnabling.FMainUIGhostArtFBOffEnable();
        FMainUIGhostArtInfoTextDisabling.FMainUIGhostArtInfoTextDisable();
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
        // Enable Objects
        FMainUIGhostArtInfoTextEnabling.FMainUIGhostArtInfoTextEnable();
	}
	
	public void UIGhostArtInfoMainButtonArtOnClicking() {
        AllTimersPausing.AllTimersPause();
		Scene36Loading.Scene36Load();
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 0;
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}