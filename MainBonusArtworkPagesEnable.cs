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

public class MainBonusArtworkPagesEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    // UI Artworks F1 Added
	public Image UIArtworksF1AddedBackground;
	public Text UIArtworksF1AddedText;
	public Text UIArtworksF1AddedCloseButton;
	public Image UIArtworksButtonF101Added;
	public Text UIArtworksButtonF101AddedText;
	public Image UIArtworksButtonF102Added;
	public Text UIArtworksButtonF102AddedText;
	public Image UIArtworksButtonF103Added;
	public Text UIArtworksButtonF103AddedText;
	public Image UIArtworksButtonF104Added;
	public Text UIArtworksButtonF104AddedText;
	public Image UIArtworksButtonF105Added;
	public Text UIArtworksButtonF105AddedText;
	public Image UIArtworksButtonF106Added;
	public Text UIArtworksButtonF106AddedText;
	public Image UIArtworksButtonF107Added;
	public Text UIArtworksButtonF107AddedText;
	public Image UIArtworksButtonF108Added;
	public Text UIArtworksButtonF108AddedText;
    public Text UIArtworksF1AddedCopyText;
    
    // UI Artworks F2 Added
	public Image UIArtworksF2AddedBackground;
	public Text UIArtworksF2AddedText;
	public Text UIArtworksF2AddedCloseButton;
	public Image UIArtworksButtonF201Added;
	public Text UIArtworksButtonF201AddedText;
	public Image UIArtworksButtonF202Added;
	public Text UIArtworksButtonF202AddedText;
	public Image UIArtworksButtonF203Added;
	public Text UIArtworksButtonF203AddedText;
	public Image UIArtworksButtonF204Added;
	public Text UIArtworksButtonF204AddedText;
	public Image UIArtworksButtonF205Added;
	public Text UIArtworksButtonF205AddedText;
	public Image UIArtworksButtonF206Added;
	public Text UIArtworksButtonF206AddedText;
	public Image UIArtworksButtonF207Added;
	public Text UIArtworksButtonF207AddedText;
	public Image UIArtworksButtonF208Added;
	public Text UIArtworksButtonF208AddedText;
    public Text UIArtworksF2AddedCopyText;
    
    // UI Artworks F3 Added
	public Image UIArtworksF3AddedBackground;
	public Text UIArtworksF3AddedText;
	public Text UIArtworksF3AddedCloseButton;
	public Image UIArtworksButtonF301Added;
	public Text UIArtworksButtonF301AddedText;
	public Image UIArtworksButtonF302Added;
	public Text UIArtworksButtonF302AddedText;
	public Image UIArtworksButtonF303Added;
	public Text UIArtworksButtonF303AddedText;
	public Image UIArtworksButtonF304Added;
	public Text UIArtworksButtonF304AddedText;
	public Image UIArtworksButtonF305Added;
	public Text UIArtworksButtonF305AddedText;
	public Image UIArtworksButtonF306Added;
	public Text UIArtworksButtonF306AddedText;
	public Image UIArtworksButtonF307Added;
	public Text UIArtworksButtonF307AddedText;
	public Image UIArtworksButtonF308Added;
	public Text UIArtworksButtonF308AddedText;
    public Text UIArtworksF3AddedCopyText;
    
    // UI Artworks G1 Added
	public Image UIArtworksG1AddedBackground;
	public Text UIArtworksG1AddedText;
	public Text UIArtworksG1AddedCloseButton;
	public Image UIArtworksButtonG101Added;
	public Text UIArtworksButtonG101AddedText;
	public Image UIArtworksButtonG102Added;
	public Text UIArtworksButtonG102AddedText;
	public Image UIArtworksButtonG103Added;
	public Text UIArtworksButtonG103AddedText;
	public Image UIArtworksButtonG104Added;
	public Text UIArtworksButtonG104AddedText;
	public Image UIArtworksButtonG105Added;
	public Text UIArtworksButtonG105AddedText;
	public Image UIArtworksButtonG106Added;
	public Text UIArtworksButtonG106AddedText;
	public Image UIArtworksButtonG107Added;
	public Text UIArtworksButtonG107AddedText;
	public Image UIArtworksButtonG108Added;
	public Text UIArtworksButtonG108AddedText;
    public Text UIArtworksG1AddedCopyText;
    
    // UI Artworks G2 Added
	public Image UIArtworksG2AddedBackground;
	public Text UIArtworksG2AddedText;
	public Text UIArtworksG2AddedCloseButton;
	public Image UIArtworksButtonG201Added;
	public Text UIArtworksButtonG201AddedText;
	public Image UIArtworksButtonG202Added;
	public Text UIArtworksButtonG202AddedText;
	public Image UIArtworksButtonG203Added;
	public Text UIArtworksButtonG203AddedText;
	public Image UIArtworksButtonG204Added;
	public Text UIArtworksButtonG204AddedText;
	public Image UIArtworksButtonG205Added;
	public Text UIArtworksButtonG205AddedText;
	public Image UIArtworksButtonG206Added;
	public Text UIArtworksButtonG206AddedText;
	public Image UIArtworksButtonG207Added;
	public Text UIArtworksButtonG207AddedText;
	public Image UIArtworksButtonG208Added;
	public Text UIArtworksButtonG208AddedText;
    public Text UIArtworksG2AddedCopyText;
    
    // UI Artworks G3 Added
	public Image UIArtworksG3AddedBackground;
	public Text UIArtworksG3AddedText;
	public Text UIArtworksG3AddedCloseButton;
	public Image UIArtworksButtonG301Added;
	public Text UIArtworksButtonG301AddedText;
	public Image UIArtworksButtonG302Added;
	public Text UIArtworksButtonG302AddedText;
	public Image UIArtworksButtonG303Added;
	public Text UIArtworksButtonG303AddedText;
	public Image UIArtworksButtonG304Added;
	public Text UIArtworksButtonG304AddedText;
	public Image UIArtworksButtonG305Added;
	public Text UIArtworksButtonG305AddedText;
	public Image UIArtworksButtonG306Added;
	public Text UIArtworksButtonG306AddedText;
	public Image UIArtworksButtonG307Added;
	public Text UIArtworksButtonG307AddedText;
	public Image UIArtworksButtonG308Added;
	public Text UIArtworksButtonG308AddedText;
    public Text UIArtworksG3AddedCopyText;
    
    // UI Artworks FB Added
	public Image UIArtworksFBAddedBackground;
	public Text UIArtworksFBAddedText;
	public Text UIArtworksFBAddedCloseButton;
	public Image UIArtworksButtonFB01Added;
	public Text UIArtworksButtonFB01AddedText;
	public Image UIArtworksButtonFB02Added;
	public Text UIArtworksButtonFB02AddedText;
	public Image UIArtworksButtonFB03Added;
	public Text UIArtworksButtonFB03AddedText;
	public Image UIArtworksButtonFB04Added;
	public Text UIArtworksButtonFB04AddedText;
	public Image UIArtworksButtonFB05Added;
	public Text UIArtworksButtonFB05AddedText;
	public Image UIArtworksButtonFB06Added;
	public Text UIArtworksButtonFB06AddedText;
	public Image UIArtworksButtonFB07Added;
	public Text UIArtworksButtonFB07AddedText;
	public Image UIArtworksButtonFB08Added;
	public Text UIArtworksButtonFB08AddedText;
    public Image UIArtworksButtonFB09Added;
	public Text UIArtworksButtonFB09AddedText;
    public Image UIArtworksButtonFB10Added;
	public Text UIArtworksButtonFB10AddedText;
    public Text UIArtworksFBAddedCopyText;
	
// --------------- PRIVATE VARIABLES ---------------
	private Color ArtworkBoughtColorOff;
    private Color ArtworkBoughtColorOn;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	private FirebaseAuth PlayerAuthentication;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Firebase Auth
		PlayerAuthentication = FirebaseAuth.DefaultInstance;
        
        ArtworkBoughtColorOff = new Color(0.15f, 0.36f, 0.45f, 1.0f);
        ArtworkBoughtColorOn = new Color(0.01f, 0.73f, 0.91f, 1.0f);
        
        ArtworkPagesAddedAllDisable();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		BoughtAddedButtonsColor();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING OBJECTS FUNCTION ---------------
    public void ArtworksPageF1AddedEnable() {
        UIArtworksF1AddedBackground.enabled = true;
        UIArtworksF1AddedText.enabled = true;
        UIArtworksF1AddedCloseButton.enabled = true;
        UIArtworksButtonF101Added.enabled = true;
        UIArtworksButtonF101AddedText.enabled = true;
        UIArtworksButtonF102Added.enabled = true;
        UIArtworksButtonF102AddedText.enabled = true;
        UIArtworksButtonF103Added.enabled = true;
        UIArtworksButtonF103AddedText.enabled = true;
        UIArtworksButtonF104Added.enabled = true;
        UIArtworksButtonF104AddedText.enabled = true;
        UIArtworksButtonF105Added.enabled = true;
        UIArtworksButtonF105AddedText.enabled = true;
        UIArtworksButtonF106Added.enabled = true;
        UIArtworksButtonF106AddedText.enabled = true;
        UIArtworksButtonF107Added.enabled = true;
        UIArtworksButtonF107AddedText.enabled = true;
        UIArtworksButtonF108Added.enabled = true;
        UIArtworksButtonF108AddedText.enabled = true;
        UIArtworksF1AddedCopyText.enabled = true;
    }
    
    public void ArtworksPageF2AddedEnable() {
        UIArtworksF2AddedBackground.enabled = true;
        UIArtworksF2AddedText.enabled = true;
        UIArtworksF2AddedCloseButton.enabled = true;
        UIArtworksButtonF201Added.enabled = true;
        UIArtworksButtonF201AddedText.enabled = true;
        UIArtworksButtonF202Added.enabled = true;
        UIArtworksButtonF202AddedText.enabled = true;
        UIArtworksButtonF203Added.enabled = true;
        UIArtworksButtonF203AddedText.enabled = true;
        UIArtworksButtonF204Added.enabled = true;
        UIArtworksButtonF204AddedText.enabled = true;
        UIArtworksButtonF205Added.enabled = true;
        UIArtworksButtonF205AddedText.enabled = true;
        UIArtworksButtonF206Added.enabled = true;
        UIArtworksButtonF206AddedText.enabled = true;
        UIArtworksButtonF207Added.enabled = true;
        UIArtworksButtonF207AddedText.enabled = true;
        UIArtworksButtonF208Added.enabled = true;
        UIArtworksButtonF208AddedText.enabled = true;
        UIArtworksF2AddedCopyText.enabled = true;
    }
    
    public void ArtworksPageF3AddedEnable() {
        UIArtworksF3AddedBackground.enabled = true;
        UIArtworksF3AddedText.enabled = true;
        UIArtworksF3AddedCloseButton.enabled = true;
        UIArtworksButtonF301Added.enabled = true;
        UIArtworksButtonF301AddedText.enabled = true;
        UIArtworksButtonF302Added.enabled = true;
        UIArtworksButtonF302AddedText.enabled = true;
        UIArtworksButtonF303Added.enabled = true;
        UIArtworksButtonF303AddedText.enabled = true;
        UIArtworksButtonF304Added.enabled = true;
        UIArtworksButtonF304AddedText.enabled = true;
        UIArtworksButtonF305Added.enabled = true;
        UIArtworksButtonF305AddedText.enabled = true;
        UIArtworksButtonF306Added.enabled = true;
        UIArtworksButtonF306AddedText.enabled = true;
        UIArtworksButtonF307Added.enabled = true;
        UIArtworksButtonF307AddedText.enabled = true;
        UIArtworksButtonF308Added.enabled = true;
        UIArtworksButtonF308AddedText.enabled = true;
        UIArtworksF3AddedCopyText.enabled = true;
    }
    
    public void ArtworksPageG1AddedEnable() {
        UIArtworksG1AddedBackground.enabled = true;
        UIArtworksG1AddedText.enabled = true;
        UIArtworksG1AddedCloseButton.enabled = true;
        UIArtworksButtonG101Added.enabled = true;
        UIArtworksButtonG101AddedText.enabled = true;
        UIArtworksButtonG102Added.enabled = true;
        UIArtworksButtonG102AddedText.enabled = true;
        UIArtworksButtonG103Added.enabled = true;
        UIArtworksButtonG103AddedText.enabled = true;
        UIArtworksButtonG104Added.enabled = true;
        UIArtworksButtonG104AddedText.enabled = true;
        UIArtworksButtonG105Added.enabled = true;
        UIArtworksButtonG105AddedText.enabled = true;
        UIArtworksButtonG106Added.enabled = true;
        UIArtworksButtonG106AddedText.enabled = true;
        UIArtworksButtonG107Added.enabled = true;
        UIArtworksButtonG107AddedText.enabled = true;
        UIArtworksButtonG108Added.enabled = true;
        UIArtworksButtonG108AddedText.enabled = true;
        UIArtworksG1AddedCopyText.enabled = true;
    }
    
    public void ArtworksPageG2AddedEnable() {
        UIArtworksG2AddedBackground.enabled = true;
        UIArtworksG2AddedText.enabled = true;
        UIArtworksG2AddedCloseButton.enabled = true;
        UIArtworksButtonG201Added.enabled = true;
        UIArtworksButtonG201AddedText.enabled = true;
        UIArtworksButtonG202Added.enabled = true;
        UIArtworksButtonG202AddedText.enabled = true;
        UIArtworksButtonG203Added.enabled = true;
        UIArtworksButtonG203AddedText.enabled = true;
        UIArtworksButtonG204Added.enabled = true;
        UIArtworksButtonG204AddedText.enabled = true;
        UIArtworksButtonG205Added.enabled = true;
        UIArtworksButtonG205AddedText.enabled = true;
        UIArtworksButtonG206Added.enabled = true;
        UIArtworksButtonG206AddedText.enabled = true;
        UIArtworksButtonG207Added.enabled = true;
        UIArtworksButtonG207AddedText.enabled = true;
        UIArtworksButtonG208Added.enabled = true;
        UIArtworksButtonG208AddedText.enabled = true;
        UIArtworksG2AddedCopyText.enabled = true;
    }
    
    public void ArtworksPageG3AddedEnable() {
        UIArtworksG3AddedBackground.enabled = true;
        UIArtworksG3AddedText.enabled = true;
        UIArtworksG3AddedCloseButton.enabled = true;
        UIArtworksButtonG301Added.enabled = true;
        UIArtworksButtonG301AddedText.enabled = true;
        UIArtworksButtonG302Added.enabled = true;
        UIArtworksButtonG302AddedText.enabled = true;
        UIArtworksButtonG303Added.enabled = true;
        UIArtworksButtonG303AddedText.enabled = true;
        UIArtworksButtonG304Added.enabled = true;
        UIArtworksButtonG304AddedText.enabled = true;
        UIArtworksButtonG305Added.enabled = true;
        UIArtworksButtonG305AddedText.enabled = true;
        UIArtworksButtonG306Added.enabled = true;
        UIArtworksButtonG306AddedText.enabled = true;
        UIArtworksButtonG307Added.enabled = true;
        UIArtworksButtonG307AddedText.enabled = true;
        UIArtworksButtonG308Added.enabled = true;
        UIArtworksButtonG308AddedText.enabled = true;
        UIArtworksG3AddedCopyText.enabled = true;
    }
    
    public void ArtworksPageFBAddedEnable() {
        UIArtworksFBAddedBackground.enabled = true;
        UIArtworksFBAddedText.enabled = true;
        UIArtworksFBAddedCloseButton.enabled = true;
        UIArtworksButtonFB01Added.enabled = true;
        UIArtworksButtonFB01AddedText.enabled = true;
        UIArtworksButtonFB02Added.enabled = true;
        UIArtworksButtonFB02AddedText.enabled = true;
        UIArtworksButtonFB03Added.enabled = true;
        UIArtworksButtonFB03AddedText.enabled = true;
        UIArtworksButtonFB04Added.enabled = true;
        UIArtworksButtonFB04AddedText.enabled = true;
        UIArtworksButtonFB05Added.enabled = true;
        UIArtworksButtonFB05AddedText.enabled = true;
        UIArtworksButtonFB06Added.enabled = true;
        UIArtworksButtonFB06AddedText.enabled = true;
        UIArtworksButtonFB07Added.enabled = true;
        UIArtworksButtonFB07AddedText.enabled = true;
        UIArtworksButtonFB08Added.enabled = true;
        UIArtworksButtonFB08AddedText.enabled = true;
        UIArtworksFBAddedCopyText.enabled = true;
    }
    
// --------------- DISABLING OBJECTS FUNCTION ---------------
    public void ArtworkPagesAddedAllDisable() {
        ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisable();
    }
    
    public void ArtworksPageF1AddedDisable() {
        UIArtworksF1AddedBackground.enabled = false;
        UIArtworksF1AddedText.enabled = false;
        UIArtworksF1AddedCloseButton.enabled = false;
        UIArtworksButtonF101Added.enabled = false;
        UIArtworksButtonF101AddedText.enabled = false;
        UIArtworksButtonF102Added.enabled = false;
        UIArtworksButtonF102AddedText.enabled = false;
        UIArtworksButtonF103Added.enabled = false;
        UIArtworksButtonF103AddedText.enabled = false;
        UIArtworksButtonF104Added.enabled = false;
        UIArtworksButtonF104AddedText.enabled = false;
        UIArtworksButtonF105Added.enabled = false;
        UIArtworksButtonF105AddedText.enabled = false;
        UIArtworksButtonF106Added.enabled = false;
        UIArtworksButtonF106AddedText.enabled = false;
        UIArtworksButtonF107Added.enabled = false;
        UIArtworksButtonF107AddedText.enabled = false;
        UIArtworksButtonF108Added.enabled = false;
        UIArtworksButtonF108AddedText.enabled = false;
        UIArtworksF1AddedCopyText.enabled = false;
    }
    
    public void ArtworksPageF2AddedDisable() {
        UIArtworksF2AddedBackground.enabled = false;
        UIArtworksF2AddedText.enabled = false;
        UIArtworksF2AddedCloseButton.enabled = false;
        UIArtworksButtonF201Added.enabled = false;
        UIArtworksButtonF201AddedText.enabled = false;
        UIArtworksButtonF202Added.enabled = false;
        UIArtworksButtonF202AddedText.enabled = false;
        UIArtworksButtonF203Added.enabled = false;
        UIArtworksButtonF203AddedText.enabled = false;
        UIArtworksButtonF204Added.enabled = false;
        UIArtworksButtonF204AddedText.enabled = false;
        UIArtworksButtonF205Added.enabled = false;
        UIArtworksButtonF205AddedText.enabled = false;
        UIArtworksButtonF206Added.enabled = false;
        UIArtworksButtonF206AddedText.enabled = false;
        UIArtworksButtonF207Added.enabled = false;
        UIArtworksButtonF207AddedText.enabled = false;
        UIArtworksButtonF208Added.enabled = false;
        UIArtworksButtonF208AddedText.enabled = false;
        UIArtworksF2AddedCopyText.enabled = false;
    }
    
    public void ArtworksPageF3AddedDisable() {
        UIArtworksF3AddedBackground.enabled = false;
        UIArtworksF3AddedText.enabled = false;
        UIArtworksF3AddedCloseButton.enabled = false;
        UIArtworksButtonF301Added.enabled = false;
        UIArtworksButtonF301AddedText.enabled = false;
        UIArtworksButtonF302Added.enabled = false;
        UIArtworksButtonF302AddedText.enabled = false;
        UIArtworksButtonF303Added.enabled = false;
        UIArtworksButtonF303AddedText.enabled = false;
        UIArtworksButtonF304Added.enabled = false;
        UIArtworksButtonF304AddedText.enabled = false;
        UIArtworksButtonF305Added.enabled = false;
        UIArtworksButtonF305AddedText.enabled = false;
        UIArtworksButtonF306Added.enabled = false;
        UIArtworksButtonF306AddedText.enabled = false;
        UIArtworksButtonF307Added.enabled = false;
        UIArtworksButtonF307AddedText.enabled = false;
        UIArtworksButtonF308Added.enabled = false;
        UIArtworksButtonF308AddedText.enabled = false;
        UIArtworksF3AddedCopyText.enabled = false;
    }
    
    public void ArtworksPageG1AddedDisable() {
        UIArtworksG1AddedBackground.enabled = false;
        UIArtworksG1AddedText.enabled = false;
        UIArtworksG1AddedCloseButton.enabled = false;
        UIArtworksButtonG101Added.enabled = false;
        UIArtworksButtonG101AddedText.enabled = false;
        UIArtworksButtonG102Added.enabled = false;
        UIArtworksButtonG102AddedText.enabled = false;
        UIArtworksButtonG103Added.enabled = false;
        UIArtworksButtonG103AddedText.enabled = false;
        UIArtworksButtonG104Added.enabled = false;
        UIArtworksButtonG104AddedText.enabled = false;
        UIArtworksButtonG105Added.enabled = false;
        UIArtworksButtonG105AddedText.enabled = false;
        UIArtworksButtonG106Added.enabled = false;
        UIArtworksButtonG106AddedText.enabled = false;
        UIArtworksButtonG107Added.enabled = false;
        UIArtworksButtonG107AddedText.enabled = false;
        UIArtworksButtonG108Added.enabled = false;
        UIArtworksButtonG108AddedText.enabled = false;
        UIArtworksG1AddedCopyText.enabled = false;
    }
    
    public void ArtworksPageG2AddedDisable() {
        UIArtworksG2AddedBackground.enabled = false;
        UIArtworksG2AddedText.enabled = false;
        UIArtworksG2AddedCloseButton.enabled = false;
        UIArtworksButtonG201Added.enabled = false;
        UIArtworksButtonG201AddedText.enabled = false;
        UIArtworksButtonG202Added.enabled = false;
        UIArtworksButtonG202AddedText.enabled = false;
        UIArtworksButtonG203Added.enabled = false;
        UIArtworksButtonG203AddedText.enabled = false;
        UIArtworksButtonG204Added.enabled = false;
        UIArtworksButtonG204AddedText.enabled = false;
        UIArtworksButtonG205Added.enabled = false;
        UIArtworksButtonG205AddedText.enabled = false;
        UIArtworksButtonG206Added.enabled = false;
        UIArtworksButtonG206AddedText.enabled = false;
        UIArtworksButtonG207Added.enabled = false;
        UIArtworksButtonG207AddedText.enabled = false;
        UIArtworksButtonG208Added.enabled = false;
        UIArtworksButtonG208AddedText.enabled = false;
        UIArtworksG2AddedCopyText.enabled = false;
    }
    
    public void ArtworksPageG3AddedDisable() {
        UIArtworksG3AddedBackground.enabled = false;
        UIArtworksG3AddedText.enabled = false;
        UIArtworksG3AddedCloseButton.enabled = false;
        UIArtworksButtonG301Added.enabled = false;
        UIArtworksButtonG301AddedText.enabled = false;
        UIArtworksButtonG302Added.enabled = false;
        UIArtworksButtonG302AddedText.enabled = false;
        UIArtworksButtonG303Added.enabled = false;
        UIArtworksButtonG303AddedText.enabled = false;
        UIArtworksButtonG304Added.enabled = false;
        UIArtworksButtonG304AddedText.enabled = false;
        UIArtworksButtonG305Added.enabled = false;
        UIArtworksButtonG305AddedText.enabled = false;
        UIArtworksButtonG306Added.enabled = false;
        UIArtworksButtonG306AddedText.enabled = false;
        UIArtworksButtonG307Added.enabled = false;
        UIArtworksButtonG307AddedText.enabled = false;
        UIArtworksButtonG308Added.enabled = false;
        UIArtworksButtonG308AddedText.enabled = false;
        UIArtworksG3AddedCopyText.enabled = false;
    }
    
    public void ArtworksPageFBAddedDisable() {
        UIArtworksFBAddedBackground.enabled = false;
        UIArtworksFBAddedText.enabled = false;
        UIArtworksFBAddedCloseButton.enabled = false;
        UIArtworksButtonFB01Added.enabled = false;
        UIArtworksButtonFB01AddedText.enabled = false;
        UIArtworksButtonFB02Added.enabled = false;
        UIArtworksButtonFB02AddedText.enabled = false;
        UIArtworksButtonFB03Added.enabled = false;
        UIArtworksButtonFB03AddedText.enabled = false;
        UIArtworksButtonFB04Added.enabled = false;
        UIArtworksButtonFB04AddedText.enabled = false;
        UIArtworksButtonFB05Added.enabled = false;
        UIArtworksButtonFB05AddedText.enabled = false;
        UIArtworksButtonFB06Added.enabled = false;
        UIArtworksButtonFB06AddedText.enabled = false;
        UIArtworksButtonFB07Added.enabled = false;
        UIArtworksButtonFB07AddedText.enabled = false;
        UIArtworksButtonFB08Added.enabled = false;
        UIArtworksButtonFB08AddedText.enabled = false;
        UIArtworksFBAddedCopyText.enabled = false;
    }
    
// --------------- PURCHASED COLORS FUNCTION ---------------
     public void BoughtAddedButtonsColor() {
        // F1
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF101Added) == 0) {
            UIArtworksButtonF101Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF101Added) >= 1) {
            UIArtworksButtonF101Added.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF102Added) == 0) {
            UIArtworksButtonF102Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF102Added) >= 1) {
            UIArtworksButtonF102Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF103Added) == 0) {
            UIArtworksButtonF103Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF103Added) >= 1) {
            UIArtworksButtonF103Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF104Added) == 0) {
            UIArtworksButtonF104Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF104Added) >= 1) {
            UIArtworksButtonF104Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF105Added) == 0) {
            UIArtworksButtonF105Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF105Added) >= 1) {
            UIArtworksButtonF105Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF106Added) == 0) {
            UIArtworksButtonF106Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF106Added) >= 1) {
            UIArtworksButtonF106Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF107Added) == 0) {
            UIArtworksButtonF107Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF107Added) >= 1) {
            UIArtworksButtonF107Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF108Added) == 0) {
            UIArtworksButtonF108Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF108Added) >= 1) {
            UIArtworksButtonF108Added.color = ArtworkBoughtColorOn;
        }
         
        // F2
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF201Added) == 0) {
            UIArtworksButtonF201Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF201Added) >= 1) {
            UIArtworksButtonF201Added.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF202Added) == 0) {
            UIArtworksButtonF202Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF202Added) >= 1) {
            UIArtworksButtonF202Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF203Added) == 0) {
            UIArtworksButtonF203Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF203Added) >= 1) {
            UIArtworksButtonF203Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF204Added) == 0) {
            UIArtworksButtonF204Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF204Added) >= 1) {
            UIArtworksButtonF204Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF205Added) == 0) {
            UIArtworksButtonF205Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF205Added) >= 1) {
            UIArtworksButtonF205Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF206Added) == 0) {
            UIArtworksButtonF206Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF206Added) >= 1) {
            UIArtworksButtonF206Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF207Added) == 0) {
            UIArtworksButtonF207Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF207Added) >= 1) {
            UIArtworksButtonF207Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF208Added) == 0) {
            UIArtworksButtonF208Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF208Added) >= 1) {
            UIArtworksButtonF208Added.color = ArtworkBoughtColorOn;
        }
         
        // F3
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF301Added) == 0) {
            UIArtworksButtonF301Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF301Added) >= 1) {
            UIArtworksButtonF301Added.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF302Added) == 0) {
            UIArtworksButtonF302Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF302Added) >= 1) {
            UIArtworksButtonF302Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF303Added) == 0) {
            UIArtworksButtonF303Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF303Added) >= 1) {
            UIArtworksButtonF303Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF304Added) == 0) {
            UIArtworksButtonF304Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF304Added) >= 1) {
            UIArtworksButtonF304Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF305Added) == 0) {
            UIArtworksButtonF305Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF305Added) >= 1) {
            UIArtworksButtonF305Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF306Added) == 0) {
            UIArtworksButtonF306Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF306Added) >= 1) {
            UIArtworksButtonF306Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF307Added) == 0) {
            UIArtworksButtonF307Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF307Added) >= 1) {
            UIArtworksButtonF307Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF308Added) == 0) {
            UIArtworksButtonF308Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF308Added) >= 1) {
            UIArtworksButtonF308Added.color = ArtworkBoughtColorOn;
        }
         
        // G1
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG101Added) == 0) {
            UIArtworksButtonG101Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG101Added) >= 1) {
            UIArtworksButtonG101Added.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG102Added) == 0) {
            UIArtworksButtonG102Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG102Added) >= 1) {
            UIArtworksButtonG102Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG103Added) == 0) {
            UIArtworksButtonG103Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG103Added) >= 1) {
            UIArtworksButtonG103Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG104Added) == 0) {
            UIArtworksButtonG104Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG104Added) >= 1) {
            UIArtworksButtonG104Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG105Added) == 0) {
            UIArtworksButtonG105Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG105Added) >= 1) {
            UIArtworksButtonG105Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG106Added) == 0) {
            UIArtworksButtonG106Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG106Added) >= 1) {
            UIArtworksButtonG106Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG107Added) == 0) {
            UIArtworksButtonG107Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG107Added) >= 1) {
            UIArtworksButtonG107Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG108Added) == 0) {
            UIArtworksButtonG108Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG108Added) >= 1) {
            UIArtworksButtonG108Added.color = ArtworkBoughtColorOn;
        }
         
        // G2
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG201Added) == 0) {
            UIArtworksButtonG201Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG201Added) >= 1) {
            UIArtworksButtonG201Added.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG202Added) == 0) {
            UIArtworksButtonG202Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG202Added) >= 1) {
            UIArtworksButtonG202Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG203Added) == 0) {
            UIArtworksButtonG203Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG203Added) >= 1) {
            UIArtworksButtonG203Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG204Added) == 0) {
            UIArtworksButtonG204Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG204Added) >= 1) {
            UIArtworksButtonG204Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG205Added) == 0) {
            UIArtworksButtonG205Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG205Added) >= 1) {
            UIArtworksButtonG205Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG206Added) == 0) {
            UIArtworksButtonG206Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG206Added) >= 1) {
            UIArtworksButtonG206Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG207Added) == 0) {
            UIArtworksButtonG207Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG207Added) >= 1) {
            UIArtworksButtonG207Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG208Added) == 0) {
            UIArtworksButtonG208Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG208Added) >= 1) {
            UIArtworksButtonG208Added.color = ArtworkBoughtColorOn;
        }
         
        // G3
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG301Added) == 0) {
            UIArtworksButtonG301Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG301Added) >= 1) {
            UIArtworksButtonG301Added.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG302Added) == 0) {
            UIArtworksButtonG302Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG302Added) >= 1) {
            UIArtworksButtonG302Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG303Added) == 0) {
            UIArtworksButtonG303Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG303Added) >= 1) {
            UIArtworksButtonG303Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG304Added) == 0) {
            UIArtworksButtonG304Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG304Added) >= 1) {
            UIArtworksButtonG304Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG305Added) == 0) {
            UIArtworksButtonG305Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG305Added) >= 1) {
            UIArtworksButtonG305Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG306Added) == 0) {
            UIArtworksButtonG306Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG306Added) >= 1) {
            UIArtworksButtonG306Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG307Added) == 0) {
            UIArtworksButtonG307Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG307Added) >= 1) {
            UIArtworksButtonG307Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG308Added) == 0) {
            UIArtworksButtonG308Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG308Added) >= 1) {
            UIArtworksButtonG308Added.color = ArtworkBoughtColorOn;
        }
         
        // FB
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB01Added) == 0) {
            UIArtworksButtonFB01Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB01Added) >= 1) {
            UIArtworksButtonFB01Added.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB02Added) == 0) {
            UIArtworksButtonFB02Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB02Added) >= 1) {
            UIArtworksButtonFB02Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB03Added) == 0) {
            UIArtworksButtonFB03Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB03Added) >= 1) {
            UIArtworksButtonFB03Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB04Added) == 0) {
            UIArtworksButtonFB04Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB04Added) >= 1) {
            UIArtworksButtonFB04Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB05Added) == 0) {
            UIArtworksButtonFB05Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB05Added) >= 1) {
            UIArtworksButtonFB05Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB06Added) == 0) {
            UIArtworksButtonFB06Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB06Added) >= 1) {
            UIArtworksButtonFB06Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB07Added) == 0) {
            UIArtworksButtonFB07Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB07Added) >= 1) {
            UIArtworksButtonFB07Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB08Added) == 0) {
            UIArtworksButtonFB08Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB08Added) >= 1) {
            UIArtworksButtonFB08Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB09Added) == 0) {
            UIArtworksButtonFB09Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB09Added) >= 1) {
            UIArtworksButtonFB09Added.color = ArtworkBoughtColorOn;
        }
         
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB10Added) == 0) {
            UIArtworksButtonFB10Added.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB10Added) >= 1) {
            UIArtworksButtonFB10Added.color = ArtworkBoughtColorOn;
        }
     }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}