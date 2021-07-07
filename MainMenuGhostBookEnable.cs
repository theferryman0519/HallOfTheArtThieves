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

public class MainMenuGhostBookEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Sketchbook Background Images
	public Image UIGhostArtBookPageLeft;
	public Image UIGhostArtBookPageRight;
	
	// Left-side Buttons
	public Text UIGhostArtInfoTitleMain;
	public Image UIGhostArtInfoMainButtonF1Off;
	public Image UIGhostArtInfoMainButtonF2Off;
	public Image UIGhostArtInfoMainButtonF3Off;
	public Image UIGhostArtInfoMainButtonG1Off;
	public Image UIGhostArtInfoMainButtonG2Off;
    public Image UIGhostArtInfoMainButtonG3Off;
	public Image UIGhostArtInfoMainButtonFBOff;
	public Image UIGhostArtInfoMainButtonArtOff;
	public Image UIGhostArtInfoMainButtonF1On;
	public Image UIGhostArtInfoMainButtonF2On;
	public Image UIGhostArtInfoMainButtonF3On;
	public Image UIGhostArtInfoMainButtonG1On;
	public Image UIGhostArtInfoMainButtonG2On;
    public Image UIGhostArtInfoMainButtonG3On;
	public Image UIGhostArtInfoMainButtonFBOn;
	public Image UIGhostArtInfoMainButtonArtOn;
	
	// Close Button
	public Image UIGhostArtBookCloseButton;
	public Text UIGhostArtBookCloseButtonText;
	
	// Ghost Sprite Images
	public Image UIGhostArtImageGhostAF1;
	public Image UIGhostArtImageGhostBF1;
	public Image UIGhostArtImageGhostCF1;
	public Image UIGhostArtImageGhostDF1;
	public Image UIGhostArtImageGhostEF1;
	public Image UIGhostArtImageGhostAF2;
	public Image UIGhostArtImageGhostBF2;
	public Image UIGhostArtImageGhostCF2;
	public Image UIGhostArtImageGhostDF2;
	public Image UIGhostArtImageGhostEF2;
	public Image UIGhostArtImageGhostAF3;
	public Image UIGhostArtImageGhostBF3;
	public Image UIGhostArtImageGhostCF3;
	public Image UIGhostArtImageGhostDF3;
	public Image UIGhostArtImageGhostEF3;
	public Image UIGhostArtImageGhostAG1;
	public Image UIGhostArtImageGhostBG1;
	public Image UIGhostArtImageGhostCG1;
	public Image UIGhostArtImageGhostDG1;
	public Image UIGhostArtImageGhostEG1;
	public Image UIGhostArtImageGhostAG2;
	public Image UIGhostArtImageGhostBG2;
	public Image UIGhostArtImageGhostCG2;
	public Image UIGhostArtImageGhostDG2;
	public Image UIGhostArtImageGhostEG2;
    public Image UIGhostArtImageGhostAG3;
	public Image UIGhostArtImageGhostBG3;
	public Image UIGhostArtImageGhostCG3;
	public Image UIGhostArtImageGhostDG3;
	public Image UIGhostArtImageGhostEG3;
	public Image UIGhostArtImageGhostAFB;
	public Image UIGhostArtImageGhostBFB;
	public Image UIGhostArtImageGhostCFB;
	public Image UIGhostArtImageGhostDFB;
	public Image UIGhostArtImageGhostEFB;
	
	// Ghost Information
	public Text UIGhostArtInfoTitle;
	public Text UIGhostArtInfoGhostName;
	public Text UIGhostArtInfoGhostLocation;
	public Text UIGhostArtInfoGhostTheftTimer;
	public Text UIGhostArtInfoGhostTheftAmount;
	public Text UIGhostArtInfoGhostBirthYear;
	public Text UIGhostArtInfoGhostDeathYear;
	public Text UIGhostArtInfoGhostPeriod;
	public Text UIGhostArtInfoGhostNation;
    public Text UIGhostArtInfoGhostLearnLink;
    public Text UIGhostArtInfoGhostClickAmount;
    
    // Disclaimer Texts
    public Text UIGhostArtInfoText;
    public Text UIGhostArtInfoGhostText;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		FMainUIGhostArtAllDisable();
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING FUNCTIONS ---------------
	public void FMainUIGhostArtBookEnable() {
		UIGhostArtBookPageLeft.enabled = true;
		UIGhostArtBookPageRight.enabled = true;
		UIGhostArtInfoTitleMain.enabled = true;
		UIGhostArtBookCloseButton.enabled = true;
		UIGhostArtBookCloseButtonText.enabled = true;
		FMainUIGhostArtF1OffEnable();
		FMainUIGhostArtF2OffEnable();
		FMainUIGhostArtF3OffEnable();
		FMainUIGhostArtG1OffEnable();
		FMainUIGhostArtG2OffEnable();
        FMainUIGhostArtG3OffEnable();
		FMainUIGhostArtFBOffEnable();
		FMainUIGhostArtArtOffEnable();
        FMainUIGhostArtInfoTextEnable();
	}
	
	public void FMainUIGhostArtInfoTitleEnable() {
		UIGhostArtInfoTitle.enabled = true;
	}
	
	public void FMainUIGhostArtPageTextEnable() {
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
	}
	
	public void FMainUIGhostArtF1GhostImagesEnable() {
		UIGhostArtInfoMainButtonF1On.enabled = true;
		UIGhostArtImageGhostAF1.enabled = true;
		UIGhostArtImageGhostBF1.enabled = true;
		UIGhostArtImageGhostCF1.enabled = true;
		UIGhostArtImageGhostDF1.enabled = true;
		UIGhostArtImageGhostEF1.enabled = true;
	}
	
	public void FMainUIGhostArtF2GhostImagesEnable() {
		UIGhostArtInfoMainButtonF2On.enabled = true;
		UIGhostArtImageGhostAF2.enabled = true;
		UIGhostArtImageGhostBF2.enabled = true;
		UIGhostArtImageGhostCF2.enabled = true;
		UIGhostArtImageGhostDF2.enabled = true;
		UIGhostArtImageGhostEF2.enabled = true;
	}
	
	public void FMainUIGhostArtF3GhostImagesEnable() {
		UIGhostArtInfoMainButtonF3On.enabled = true;
		UIGhostArtImageGhostAF3.enabled = true;
		UIGhostArtImageGhostBF3.enabled = true;
		UIGhostArtImageGhostCF3.enabled = true;
		UIGhostArtImageGhostDF3.enabled = true;
		UIGhostArtImageGhostEF3.enabled = true;
	}
	
	public void FMainUIGhostArtG1GhostImagesEnable() {
		UIGhostArtInfoMainButtonG1On.enabled = true;
		UIGhostArtImageGhostAG1.enabled = true;
		UIGhostArtImageGhostBG1.enabled = true;
		UIGhostArtImageGhostCG1.enabled = true;
		UIGhostArtImageGhostDG1.enabled = true;
		UIGhostArtImageGhostEG1.enabled = true;
	}
	
	public void FMainUIGhostArtG2GhostImagesEnable() {
		UIGhostArtInfoMainButtonG2On.enabled = true;
		UIGhostArtImageGhostAG2.enabled = true;
		UIGhostArtImageGhostBG2.enabled = true;
		UIGhostArtImageGhostCG2.enabled = true;
		UIGhostArtImageGhostDG2.enabled = true;
		UIGhostArtImageGhostEG2.enabled = true;
	}
    
    public void FMainUIGhostArtG3GhostImagesEnable() {
		UIGhostArtInfoMainButtonG3On.enabled = true;
		UIGhostArtImageGhostAG3.enabled = true;
		UIGhostArtImageGhostBG3.enabled = true;
		UIGhostArtImageGhostCG3.enabled = true;
		UIGhostArtImageGhostDG3.enabled = true;
		UIGhostArtImageGhostEG3.enabled = true;
	}
	
	public void FMainUIGhostArtFBGhostImagesEnable() {
		UIGhostArtInfoMainButtonFBOn.enabled = true;
		UIGhostArtImageGhostAFB.enabled = true;
		UIGhostArtImageGhostBFB.enabled = true;
		UIGhostArtImageGhostCFB.enabled = true;
		UIGhostArtImageGhostDFB.enabled = true;
		UIGhostArtImageGhostEFB.enabled = true;
	}
	
	public void FMainUIGhostArtArtPageEnable() {
		UIGhostArtInfoMainButtonArtOn.enabled = true;
	}
	
	public void FMainUIGhostArtF1OffEnable() {
		UIGhostArtInfoMainButtonF1Off.enabled = true;
	}
	
	public void FMainUIGhostArtF2OffEnable() {
		UIGhostArtInfoMainButtonF2Off.enabled = true;
	}
	
	public void FMainUIGhostArtF3OffEnable() {
		UIGhostArtInfoMainButtonF3Off.enabled = true;
	}
	
	public void FMainUIGhostArtG1OffEnable() {
		UIGhostArtInfoMainButtonG1Off.enabled = true;
	}
	
	public void FMainUIGhostArtG2OffEnable() {
		UIGhostArtInfoMainButtonG2Off.enabled = true;
	}
    
    public void FMainUIGhostArtG3OffEnable() {
		UIGhostArtInfoMainButtonG3Off.enabled = true;
	}
	
	public void FMainUIGhostArtFBOffEnable() {
		UIGhostArtInfoMainButtonFBOff.enabled = true;
	}
	
	public void FMainUIGhostArtArtOffEnable() {
		UIGhostArtInfoMainButtonArtOff.enabled = true;
	}
    
    public void FMainUIGhostArtInfoTextEnable() {
        UIGhostArtInfoText.enabled = true;
    }
    
    public void FMainUIGhostArtInfoGhostTextEnable() {
        UIGhostArtInfoGhostText.enabled = true;
    }
	
// --------------- DISABLING FUNCTIONS ---------------
	public void FMainUIGhostArtAllDisable() {
		FMainUIGhostArtBookDisable();
		FMainUIGhostArtInfoTitleDisable();
		FMainUIGhostArtPageTextDisable();
		FMainUIGhostArtF1GhostImagesDisable();
		FMainUIGhostArtF2GhostImagesDisable();
		FMainUIGhostArtF3GhostImagesDisable();
		FMainUIGhostArtG1GhostImagesDisable();
		FMainUIGhostArtG2GhostImagesDisable();
        FMainUIGhostArtG3GhostImagesDisable();
		FMainUIGhostArtFBGhostImagesDisable();
		FMainUIGhostArtArtPageDisable();
		FMainUIGhostArtF1OffDisable();
		FMainUIGhostArtF2OffDisable();
		FMainUIGhostArtF3OffDisable();
		FMainUIGhostArtG1OffDisable();
		FMainUIGhostArtG2OffDisable();
        FMainUIGhostArtG3OffDisable();
		FMainUIGhostArtFBOffDisable();
		FMainUIGhostArtArtOffDisable();
        FMainUIGhostArtInfoTextDisable();
        FMainUIGhostArtInfoGhostTextDisable();
	}
	
	public void FMainUIGhostArtBookDisable() {
		UIGhostArtBookPageLeft.enabled = false;
		UIGhostArtBookPageRight.enabled = false;
		UIGhostArtInfoTitleMain.enabled = false;
		UIGhostArtInfoMainButtonF1Off.enabled = false;
		UIGhostArtInfoMainButtonF2Off.enabled = false;
		UIGhostArtInfoMainButtonF3Off.enabled = false;
		UIGhostArtInfoMainButtonG1Off.enabled = false;
		UIGhostArtInfoMainButtonG2Off.enabled = false;
        UIGhostArtInfoMainButtonG3Off.enabled = false;
		UIGhostArtInfoMainButtonFBOff.enabled = false;
		UIGhostArtInfoMainButtonArtOff.enabled = false;
		UIGhostArtBookCloseButton.enabled = false;
		UIGhostArtBookCloseButtonText.enabled = false;
	}
	
	public void FMainUIGhostArtInfoTitleDisable() {
		UIGhostArtInfoTitle.enabled = false;
	}
	
	public void FMainUIGhostArtPageTextDisable() {
		UIGhostArtInfoGhostName.enabled = false;
		UIGhostArtInfoGhostLocation.enabled = false;
		UIGhostArtInfoGhostTheftTimer.enabled = false;
		UIGhostArtInfoGhostTheftAmount.enabled = false;
		UIGhostArtInfoGhostBirthYear.enabled = false;
		UIGhostArtInfoGhostDeathYear.enabled = false;
		UIGhostArtInfoGhostPeriod.enabled = false;
		UIGhostArtInfoGhostNation.enabled = false;
        UIGhostArtInfoGhostLearnLink.enabled = false;
        UIGhostArtInfoGhostClickAmount.enabled = false;
	}
	
	public void FMainUIGhostArtF1GhostImagesDisable() {
		UIGhostArtInfoMainButtonF1On.enabled = false;
		UIGhostArtImageGhostAF1.enabled = false;
		UIGhostArtImageGhostBF1.enabled = false;
		UIGhostArtImageGhostCF1.enabled = false;
		UIGhostArtImageGhostDF1.enabled = false;
		UIGhostArtImageGhostEF1.enabled = false;
	}
	
	public void FMainUIGhostArtF2GhostImagesDisable() {
		UIGhostArtInfoMainButtonF2On.enabled = false;
		UIGhostArtImageGhostAF2.enabled = false;
		UIGhostArtImageGhostBF2.enabled = false;
		UIGhostArtImageGhostCF2.enabled = false;
		UIGhostArtImageGhostDF2.enabled = false;
		UIGhostArtImageGhostEF2.enabled = false;
	}
	
	public void FMainUIGhostArtF3GhostImagesDisable() {
		UIGhostArtInfoMainButtonF3On.enabled = false;
		UIGhostArtImageGhostAF3.enabled = false;
		UIGhostArtImageGhostBF3.enabled = false;
		UIGhostArtImageGhostCF3.enabled = false;
		UIGhostArtImageGhostDF3.enabled = false;
		UIGhostArtImageGhostEF3.enabled = false;
	}
	
	public void FMainUIGhostArtG1GhostImagesDisable() {
		UIGhostArtInfoMainButtonG1On.enabled = false;
		UIGhostArtImageGhostAG1.enabled = false;
		UIGhostArtImageGhostBG1.enabled = false;
		UIGhostArtImageGhostCG1.enabled = false;
		UIGhostArtImageGhostDG1.enabled = false;
		UIGhostArtImageGhostEG1.enabled = false;
	}
	
	public void FMainUIGhostArtG2GhostImagesDisable() {
		UIGhostArtInfoMainButtonG2On.enabled = false;
		UIGhostArtImageGhostAG2.enabled = false;
		UIGhostArtImageGhostBG2.enabled = false;
		UIGhostArtImageGhostCG2.enabled = false;
		UIGhostArtImageGhostDG2.enabled = false;
		UIGhostArtImageGhostEG2.enabled = false;
	}
    
    public void FMainUIGhostArtG3GhostImagesDisable() {
		UIGhostArtInfoMainButtonG3On.enabled = false;
		UIGhostArtImageGhostAG3.enabled = false;
		UIGhostArtImageGhostBG3.enabled = false;
		UIGhostArtImageGhostCG3.enabled = false;
		UIGhostArtImageGhostDG3.enabled = false;
		UIGhostArtImageGhostEG3.enabled = false;
	}
	
	public void FMainUIGhostArtFBGhostImagesDisable() {
		UIGhostArtInfoMainButtonFBOn.enabled = false;
		UIGhostArtImageGhostAFB.enabled = false;
		UIGhostArtImageGhostBFB.enabled = false;
		UIGhostArtImageGhostCFB.enabled = false;
		UIGhostArtImageGhostDFB.enabled = false;
		UIGhostArtImageGhostEFB.enabled = false;
	}
	
	public void FMainUIGhostArtArtPageDisable() {
		UIGhostArtInfoMainButtonArtOn.enabled = false;
	}
	
	public void FMainUIGhostArtF1OffDisable() {
		UIGhostArtInfoMainButtonF1Off.enabled = false;
	}
	
	public void FMainUIGhostArtF2OffDisable() {
		UIGhostArtInfoMainButtonF2Off.enabled = false;
	}
	
	public void FMainUIGhostArtF3OffDisable() {
		UIGhostArtInfoMainButtonF3Off.enabled = false;
	}
	
	public void FMainUIGhostArtG1OffDisable() {
		UIGhostArtInfoMainButtonG1Off.enabled = false;
	}
	
	public void FMainUIGhostArtG2OffDisable() {
		UIGhostArtInfoMainButtonG2Off.enabled = false;
	}
    
    public void FMainUIGhostArtG3OffDisable() {
		UIGhostArtInfoMainButtonG3Off.enabled = false;
	}
	
	public void FMainUIGhostArtFBOffDisable() {
		UIGhostArtInfoMainButtonFBOff.enabled = false;
	}
	
	public void FMainUIGhostArtArtOffDisable() {
		UIGhostArtInfoMainButtonArtOff.enabled = false;
	}
    
    public void FMainUIGhostArtInfoTextDisable() {
        UIGhostArtInfoText.enabled = false;
    }
    
    public void FMainUIGhostArtInfoGhostTextDisable() {
        UIGhostArtInfoGhostText.enabled = false;
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}