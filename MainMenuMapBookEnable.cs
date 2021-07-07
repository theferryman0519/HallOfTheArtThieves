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

public class MainMenuMapBookEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Sketchbook Background Images
	public Image UIMapBookPageLeft;
	public Image UIMapBookPageRight;
	
	// Left-side Buttons
	public Text UIMapTitleMain;
	public Image UIMapMainButtonF1Off;
	public Image UIMapMainButtonF2Off;
	public Image UIMapMainButtonF3Off;
	public Image UIMapMainButtonG1Off;
	public Image UIMapMainButtonG2Off;
    public Image UIMapMainButtonG3Off;
	public Image UIMapMainButtonFBOff;
	public Image UIMapMainButtonF1On;
	public Image UIMapMainButtonF2On;
	public Image UIMapMainButtonF3On;
	public Image UIMapMainButtonG1On;
	public Image UIMapMainButtonG2On;
    public Image UIMapMainButtonG3On;
	public Image UIMapMainButtonFBOn;
	public Image UIMapMainButtonF2Mute;
	public Image UIMapMainButtonF3Mute;
	public Image UIMapMainButtonG1Mute;
	public Image UIMapMainButtonG2Mute;
    public Image UIMapMainButtonG3Mute;
	public Image UIMapMainButtonFBMute;
	
	// Close Button
	public Image UIMapBookCloseButton;
	public Text UIMapBookCloseButtonText;
	
	// Castle Map Buttons
	public Text UIMapTitle;
	public Image UIMapRoomAF1;
	public Image UIMapRoomBF1;
	public Image UIMapRoomCF1;
	public Image UIMapRoomDF1;
	public Image UIMapRoomEF1;
	public Image UIMapRoomAF2;
	public Image UIMapRoomBF2;
	public Image UIMapRoomCF2;
	public Image UIMapRoomDF2;
	public Image UIMapRoomEF2;
	public Image UIMapRoomAF3;
	public Image UIMapRoomBF3;
	public Image UIMapRoomCF3;
	public Image UIMapRoomDF3;
	public Image UIMapRoomAG1;
	public Image UIMapRoomBG1;
	public Image UIMapRoomCG1;
	public Image UIMapRoomDG1;
	public Image UIMapRoomAG2;
	public Image UIMapRoomBG2;
	public Image UIMapRoomCG2;
	public Image UIMapRoomDG2;
    public Image UIMapRoomAG3;
	public Image UIMapRoomBG3;
	public Image UIMapRoomCG3;
	public Image UIMapRoomDG3;
	public Image UIMapRoomAFB;
	public Image UIMapRoomBFB;
	public Image UIMapRoomCFB;
	public Image UIMapRoomDFB;
    
    // Map Text
    public Text UIMapText;
	
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
		MainCastleMapBookAllDisable();
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING FUNCTIONS ---------------
	public void MainCastleMapBookEnable() {
		UIMapBookPageLeft.enabled = true;
		UIMapBookPageRight.enabled = true;
		UIMapTitleMain.enabled = true;
		UIMapBookCloseButton.enabled = true;
		UIMapBookCloseButtonText.enabled = true;
		MainCastleMapBookF1OffEnable();
		
		if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 0) {
			UIMapMainButtonF2Mute.enabled = true;
			UIMapMainButtonF2Off.enabled = false;
		}
		
		if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 1) {
			UIMapMainButtonF2Mute.enabled = false;
			UIMapMainButtonF2Off.enabled = true;
		}
		
		if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 0) {
			UIMapMainButtonF3Mute.enabled = true;
			UIMapMainButtonF3Off.enabled = false;
		}
		
		if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 1) {
			UIMapMainButtonF3Mute.enabled = false;
			UIMapMainButtonF3Off.enabled = true;
		}
		
		if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 0) {
			UIMapMainButtonG1Mute.enabled = true;
			UIMapMainButtonG1Off.enabled = false;
		}
		
		if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 1) {
			UIMapMainButtonG1Mute.enabled = false;
			UIMapMainButtonG1Off.enabled = true;
		}
		
		if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 0) {
			UIMapMainButtonG2Mute.enabled = true;
			UIMapMainButtonG2Off.enabled = false;
		}
		
		if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 1) {
			UIMapMainButtonG2Mute.enabled = false;
			UIMapMainButtonG2Off.enabled = true;
		}
        
        if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 0) {
			UIMapMainButtonG3Mute.enabled = true;
			UIMapMainButtonG3Off.enabled = false;
		}
		
		if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 1) {
			UIMapMainButtonG3Mute.enabled = false;
			UIMapMainButtonG3Off.enabled = true;
		}
		
		if (int.Parse(DataFillingInformation.DBBasementUnlock) == 0) {
			UIMapMainButtonFBMute.enabled = true;
			UIMapMainButtonFBOff.enabled = false;
		}
		
		if (int.Parse(DataFillingInformation.DBBasementUnlock) == 1) {
			UIMapMainButtonFBMute.enabled = false;
			UIMapMainButtonFBOff.enabled = true;
		}
	}
	
	public void MainCastleMapBookF1Enable() {
		UIMapTitle.enabled = true;
		UIMapTitle.text ="Map Info: First Floor";
		UIMapMainButtonF1On.enabled = true;
		UIMapRoomAF1.enabled = true;
		UIMapRoomBF1.enabled = true;
		UIMapRoomCF1.enabled = true;
		UIMapRoomDF1.enabled = true;
		UIMapRoomEF1.enabled = true;
	}
	
	public void MainCastleMapBookF2Enable() {
		UIMapTitle.enabled = true;
		UIMapTitle.text ="Map Info: Second Floor";
		UIMapMainButtonF2On.enabled = true;
		UIMapRoomAF2.enabled = true;
		UIMapRoomBF2.enabled = true;
		UIMapRoomCF2.enabled = true;
		UIMapRoomDF2.enabled = true;
		UIMapRoomEF2.enabled = true;
	}
	
	public void MainCastleMapBookF3Enable() {
		UIMapTitle.enabled = true;
		UIMapTitle.text ="Map Info: Third Floor";
		UIMapMainButtonF3On.enabled = true;
		UIMapRoomAF3.enabled = true;
		UIMapRoomBF3.enabled = true;
		UIMapRoomCF3.enabled = true;
		UIMapRoomDF3.enabled = true;
	}
	
	public void MainCastleMapBookG1Enable() {
		UIMapTitle.enabled = true;
		UIMapTitle.text ="Map Info: First Garden";
		UIMapMainButtonG1On.enabled = true;
		UIMapRoomAG1.enabled = true;
		UIMapRoomBG1.enabled = true;
		UIMapRoomCG1.enabled = true;
		UIMapRoomDG1.enabled = true;
	}
	
	public void MainCastleMapBookG2Enable() {
		UIMapTitle.enabled = true;
		UIMapTitle.text ="Map Info: Second Garden";
		UIMapMainButtonG2On.enabled = true;
		UIMapRoomAG2.enabled = true;
		UIMapRoomBG2.enabled = true;
		UIMapRoomCG2.enabled = true;
		UIMapRoomDG2.enabled = true;
	}
    
    public void MainCastleMapBookG3Enable() {
		UIMapTitle.enabled = true;
		UIMapTitle.text ="Map Info: Third Garden";
		UIMapMainButtonG3On.enabled = true;
		UIMapRoomAG3.enabled = true;
		UIMapRoomBG3.enabled = true;
		UIMapRoomCG3.enabled = true;
		UIMapRoomDG3.enabled = true;
	}
	
	public void MainCastleMapBookFBEnable() {
		UIMapTitle.enabled = true;
		UIMapTitle.text ="Map Info: Basement";
		UIMapMainButtonFBOn.enabled = true;
		UIMapRoomAFB.enabled = true;
		UIMapRoomBFB.enabled = true;
		UIMapRoomCFB.enabled = true;
		UIMapRoomDFB.enabled = true;
	}
	
	public void MainCastleMapBookF1OffEnable() {
		UIMapMainButtonF1Off.enabled = true;
	}
    
    public void MainCastleMapBookTextEnable() {
        UIMapText.enabled = true;
    }
	
// --------------- DISABLING FUNCTIONS ---------------
	public void MainCastleMapBookAllDisable() {
		MainCastleMapBookDisable();
		MainCastleMapBookF1Disable();
		MainCastleMapBookF2Disable();
		MainCastleMapBookF3Disable();
		MainCastleMapBookG1Disable();
		MainCastleMapBookG2Disable();
        MainCastleMapBookG3Disable();
		MainCastleMapBookFBDisable();
		MainCastleMapBookF1OffDisable();
		MainCastleMapBookF2OffDisable();
		MainCastleMapBookF3OffDisable();
		MainCastleMapBookG1OffDisable();
		MainCastleMapBookG2OffDisable();
        MainCastleMapBookG3OffDisable();
		MainCastleMapBookFBOffDisable();
        MainCastleMapBookTextDisable();
	}
	
	public void MainCastleMapBookDisable() {
		UIMapBookPageLeft.enabled = false;
		UIMapBookPageRight.enabled = false;
		UIMapTitleMain.enabled = false;
		UIMapBookCloseButton.enabled = false;
		UIMapBookCloseButtonText.enabled = false;
	}
	
	public void MainCastleMapBookF1Disable() {
		UIMapTitle.enabled = false;
		UIMapMainButtonF1On.enabled = false;
		UIMapRoomAF1.enabled = false;
		UIMapRoomBF1.enabled = false;
		UIMapRoomCF1.enabled = false;
		UIMapRoomDF1.enabled = false;
		UIMapRoomEF1.enabled = false;
	}
	
	public void MainCastleMapBookF2Disable() {
		UIMapTitle.enabled = false;
		UIMapMainButtonF2On.enabled = false;
		UIMapRoomAF2.enabled = false;
		UIMapRoomBF2.enabled = false;
		UIMapRoomCF2.enabled = false;
		UIMapRoomDF2.enabled = false;
		UIMapRoomEF2.enabled = false;
	}
	
	public void MainCastleMapBookF3Disable() {
		UIMapTitle.enabled = false;
		UIMapMainButtonF3On.enabled = false;
		UIMapRoomAF3.enabled = false;
		UIMapRoomBF3.enabled = false;
		UIMapRoomCF3.enabled = false;
		UIMapRoomDF3.enabled = false;
	}
	
	public void MainCastleMapBookG1Disable() {
		UIMapTitle.enabled = false;
		UIMapMainButtonG1On.enabled = false;
		UIMapRoomAG1.enabled = false;
		UIMapRoomBG1.enabled = false;
		UIMapRoomCG1.enabled = false;
		UIMapRoomDG1.enabled = false;
	}
	
	public void MainCastleMapBookG2Disable() {
		UIMapTitle.enabled = false;
		UIMapMainButtonG2On.enabled = false;
		UIMapRoomAG2.enabled = false;
		UIMapRoomBG2.enabled = false;
		UIMapRoomCG2.enabled = false;
		UIMapRoomDG2.enabled = false;
	}
    
    public void MainCastleMapBookG3Disable() {
		UIMapTitle.enabled = false;
		UIMapMainButtonG3On.enabled = false;
		UIMapRoomAG3.enabled = false;
		UIMapRoomBG3.enabled = false;
		UIMapRoomCG3.enabled = false;
		UIMapRoomDG3.enabled = false;
	}
	
	public void MainCastleMapBookFBDisable() {
		UIMapTitle.enabled = false;
		UIMapMainButtonFBOn.enabled = false;
		UIMapRoomAFB.enabled = false;
		UIMapRoomBFB.enabled = false;
		UIMapRoomCFB.enabled = false;
		UIMapRoomDFB.enabled = false;
	}
	
	public void MainCastleMapBookF1OffDisable() {
		UIMapMainButtonF1Off.enabled = false;
	}
	
	public void MainCastleMapBookF2OffDisable() {
		UIMapMainButtonF2Off.enabled = false;
		UIMapMainButtonF2Mute.enabled = false;
	}
	
	public void MainCastleMapBookF3OffDisable() {
		UIMapMainButtonF3Off.enabled = false;
		UIMapMainButtonF3Mute.enabled = false;
	}
	
	public void MainCastleMapBookG1OffDisable() {
		UIMapMainButtonG1Off.enabled = false;
		UIMapMainButtonG1Mute.enabled = false;
	}
	
	public void MainCastleMapBookG2OffDisable() {
		UIMapMainButtonG2Off.enabled = false;
		UIMapMainButtonG2Mute.enabled = false;
	}
    
    public void MainCastleMapBookG3OffDisable() {
		UIMapMainButtonG3Off.enabled = false;
		UIMapMainButtonG3Mute.enabled = false;
	}
	
	public void MainCastleMapBookFBOffDisable() {
		UIMapMainButtonFBOff.enabled = false;
		UIMapMainButtonFBMute.enabled = false;
	}
    
    public void MainCastleMapBookTextDisable() {
        UIMapText.enabled = false;
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}