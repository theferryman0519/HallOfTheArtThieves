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

public class MainBonusArtworkPageButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// UI Artworks F1 Added
    public Button UIArtworksF1AddedCloseButton;
    public Button UIArtworksButtonF101Added;
    public Button UIArtworksButtonF102Added;
    public Button UIArtworksButtonF103Added;
    public Button UIArtworksButtonF104Added;
    public Button UIArtworksButtonF105Added;
    public Button UIArtworksButtonF106Added;
    public Button UIArtworksButtonF107Added;
    public Button UIArtworksButtonF108Added;
    
    // UI Artworks F2 Added
    public Button UIArtworksF2AddedCloseButton;
    public Button UIArtworksButtonF201Added;
    public Button UIArtworksButtonF202Added;
    public Button UIArtworksButtonF203Added;
    public Button UIArtworksButtonF204Added;
    public Button UIArtworksButtonF205Added;
    public Button UIArtworksButtonF206Added;
    public Button UIArtworksButtonF207Added;
    public Button UIArtworksButtonF208Added;
    
    // UI Artworks F3 Added
    public Button UIArtworksF3AddedCloseButton;
    public Button UIArtworksButtonF301Added;
    public Button UIArtworksButtonF302Added;
    public Button UIArtworksButtonF303Added;
    public Button UIArtworksButtonF304Added;
    public Button UIArtworksButtonF305Added;
    public Button UIArtworksButtonF306Added;
    public Button UIArtworksButtonF307Added;
    public Button UIArtworksButtonF308Added;
    
    // UI Artworks G1 Added
    public Button UIArtworksG1AddedCloseButton;
    public Button UIArtworksButtonG101Added;
    public Button UIArtworksButtonG102Added;
    public Button UIArtworksButtonG103Added;
    public Button UIArtworksButtonG104Added;
    public Button UIArtworksButtonG105Added;
    public Button UIArtworksButtonG106Added;
    public Button UIArtworksButtonG107Added;
    public Button UIArtworksButtonG108Added;
    
    // UI Artworks G2 Added
    public Button UIArtworksG2AddedCloseButton;
    public Button UIArtworksButtonG201Added;
    public Button UIArtworksButtonG202Added;
    public Button UIArtworksButtonG203Added;
    public Button UIArtworksButtonG204Added;
    public Button UIArtworksButtonG205Added;
    public Button UIArtworksButtonG206Added;
    public Button UIArtworksButtonG207Added;
    public Button UIArtworksButtonG208Added;
    
    // UI Artworks G3 Added
    public Button UIArtworksG3AddedCloseButton;
    public Button UIArtworksButtonG301Added;
    public Button UIArtworksButtonG302Added;
    public Button UIArtworksButtonG303Added;
    public Button UIArtworksButtonG304Added;
    public Button UIArtworksButtonG305Added;
    public Button UIArtworksButtonG306Added;
    public Button UIArtworksButtonG307Added;
    public Button UIArtworksButtonG308Added;
    
    // UI Artworks FB Added
    public Button UIArtworksFBAddedCloseButton;
    public Button UIArtworksButtonFB01Added;
    public Button UIArtworksButtonFB02Added;
    public Button UIArtworksButtonFB03Added;
    public Button UIArtworksButtonFB04Added;
    public Button UIArtworksButtonFB05Added;
    public Button UIArtworksButtonFB06Added;
    public Button UIArtworksButtonFB07Added;
    public Button UIArtworksButtonFB08Added;
    public Button UIArtworksButtonFB09Added;
    public Button UIArtworksButtonFB10Added;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Enable Pages
    public MainBonusArtworkPagesEnable ArtworksPageF1AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageF2AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageF3AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageG1AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageG2AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageG3AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageFBAddedEnabling;
    
    // Disable Pages
    public MainBonusArtworkPagesEnable ArtworksPageF1AddedDisabling;
    public MainBonusArtworkPagesEnable ArtworksPageF2AddedDisabling;
    public MainBonusArtworkPagesEnable ArtworksPageF3AddedDisabling;
    public MainBonusArtworkPagesEnable ArtworksPageG1AddedDisabling;
    public MainBonusArtworkPagesEnable ArtworksPageG2AddedDisabling;
    public MainBonusArtworkPagesEnable ArtworksPageG3AddedDisabling;
    public MainBonusArtworkPagesEnable ArtworksPageFBAddedDisabling;
    
    // Load Artwork Info Scene
	public SceneLoad Scene37BLoading;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Artwork Page F1
		Button UIArtworksF1AddedCloseButtonClick = UIArtworksF1AddedCloseButton.GetComponent<Button>();
        Button UIArtworksButtonF101AddedClick = UIArtworksButtonF101Added.GetComponent<Button>();
        Button UIArtworksButtonF102AddedClick = UIArtworksButtonF102Added.GetComponent<Button>();
        Button UIArtworksButtonF103AddedClick = UIArtworksButtonF103Added.GetComponent<Button>();
        Button UIArtworksButtonF104AddedClick = UIArtworksButtonF104Added.GetComponent<Button>();
        Button UIArtworksButtonF105AddedClick = UIArtworksButtonF105Added.GetComponent<Button>();
        Button UIArtworksButtonF106AddedClick = UIArtworksButtonF106Added.GetComponent<Button>();
        Button UIArtworksButtonF107AddedClick = UIArtworksButtonF107Added.GetComponent<Button>();
        Button UIArtworksButtonF108AddedClick = UIArtworksButtonF108Added.GetComponent<Button>();
        
        UIArtworksF1AddedCloseButtonClick.onClick.AddListener(UIArtworksF1AddedCloseButtonClicking);
        UIArtworksButtonF101AddedClick.onClick.AddListener(UIArtworksButtonF101AddedClicking);
        UIArtworksButtonF102AddedClick.onClick.AddListener(UIArtworksButtonF102AddedClicking);
        UIArtworksButtonF103AddedClick.onClick.AddListener(UIArtworksButtonF103AddedClicking);
        UIArtworksButtonF104AddedClick.onClick.AddListener(UIArtworksButtonF104AddedClicking);
        UIArtworksButtonF105AddedClick.onClick.AddListener(UIArtworksButtonF105AddedClicking);
        UIArtworksButtonF106AddedClick.onClick.AddListener(UIArtworksButtonF106AddedClicking);
        UIArtworksButtonF107AddedClick.onClick.AddListener(UIArtworksButtonF107AddedClicking);
        UIArtworksButtonF108AddedClick.onClick.AddListener(UIArtworksButtonF108AddedClicking);
        
        // Artwork Page F2
		Button UIArtworksF2AddedCloseButtonClick = UIArtworksF2AddedCloseButton.GetComponent<Button>();
        Button UIArtworksButtonF201AddedClick = UIArtworksButtonF201Added.GetComponent<Button>();
        Button UIArtworksButtonF202AddedClick = UIArtworksButtonF202Added.GetComponent<Button>();
        Button UIArtworksButtonF203AddedClick = UIArtworksButtonF203Added.GetComponent<Button>();
        Button UIArtworksButtonF204AddedClick = UIArtworksButtonF204Added.GetComponent<Button>();
        Button UIArtworksButtonF205AddedClick = UIArtworksButtonF205Added.GetComponent<Button>();
        Button UIArtworksButtonF206AddedClick = UIArtworksButtonF206Added.GetComponent<Button>();
        Button UIArtworksButtonF207AddedClick = UIArtworksButtonF207Added.GetComponent<Button>();
        Button UIArtworksButtonF208AddedClick = UIArtworksButtonF208Added.GetComponent<Button>();
        
        UIArtworksF2AddedCloseButtonClick.onClick.AddListener(UIArtworksF2AddedCloseButtonClicking);
        UIArtworksButtonF201AddedClick.onClick.AddListener(UIArtworksButtonF201AddedClicking);
        UIArtworksButtonF202AddedClick.onClick.AddListener(UIArtworksButtonF202AddedClicking);
        UIArtworksButtonF203AddedClick.onClick.AddListener(UIArtworksButtonF203AddedClicking);
        UIArtworksButtonF204AddedClick.onClick.AddListener(UIArtworksButtonF204AddedClicking);
        UIArtworksButtonF205AddedClick.onClick.AddListener(UIArtworksButtonF205AddedClicking);
        UIArtworksButtonF206AddedClick.onClick.AddListener(UIArtworksButtonF206AddedClicking);
        UIArtworksButtonF207AddedClick.onClick.AddListener(UIArtworksButtonF207AddedClicking);
        UIArtworksButtonF208AddedClick.onClick.AddListener(UIArtworksButtonF208AddedClicking);
        
        // Artwork Page F3
		Button UIArtworksF3AddedCloseButtonClick = UIArtworksF3AddedCloseButton.GetComponent<Button>();
        Button UIArtworksButtonF301AddedClick = UIArtworksButtonF301Added.GetComponent<Button>();
        Button UIArtworksButtonF302AddedClick = UIArtworksButtonF302Added.GetComponent<Button>();
        Button UIArtworksButtonF303AddedClick = UIArtworksButtonF303Added.GetComponent<Button>();
        Button UIArtworksButtonF304AddedClick = UIArtworksButtonF304Added.GetComponent<Button>();
        Button UIArtworksButtonF305AddedClick = UIArtworksButtonF305Added.GetComponent<Button>();
        Button UIArtworksButtonF306AddedClick = UIArtworksButtonF306Added.GetComponent<Button>();
        Button UIArtworksButtonF307AddedClick = UIArtworksButtonF307Added.GetComponent<Button>();
        Button UIArtworksButtonF308AddedClick = UIArtworksButtonF308Added.GetComponent<Button>();
        
        UIArtworksF3AddedCloseButtonClick.onClick.AddListener(UIArtworksF3AddedCloseButtonClicking);
        UIArtworksButtonF301AddedClick.onClick.AddListener(UIArtworksButtonF301AddedClicking);
        UIArtworksButtonF302AddedClick.onClick.AddListener(UIArtworksButtonF302AddedClicking);
        UIArtworksButtonF303AddedClick.onClick.AddListener(UIArtworksButtonF303AddedClicking);
        UIArtworksButtonF304AddedClick.onClick.AddListener(UIArtworksButtonF304AddedClicking);
        UIArtworksButtonF305AddedClick.onClick.AddListener(UIArtworksButtonF305AddedClicking);
        UIArtworksButtonF306AddedClick.onClick.AddListener(UIArtworksButtonF306AddedClicking);
        UIArtworksButtonF307AddedClick.onClick.AddListener(UIArtworksButtonF307AddedClicking);
        UIArtworksButtonF308AddedClick.onClick.AddListener(UIArtworksButtonF308AddedClicking);
        
        // Artwork Page G1
		Button UIArtworksG1AddedCloseButtonClick = UIArtworksG1AddedCloseButton.GetComponent<Button>();
        Button UIArtworksButtonG101AddedClick = UIArtworksButtonG101Added.GetComponent<Button>();
        Button UIArtworksButtonG102AddedClick = UIArtworksButtonG102Added.GetComponent<Button>();
        Button UIArtworksButtonG103AddedClick = UIArtworksButtonG103Added.GetComponent<Button>();
        Button UIArtworksButtonG104AddedClick = UIArtworksButtonG104Added.GetComponent<Button>();
        Button UIArtworksButtonG105AddedClick = UIArtworksButtonG105Added.GetComponent<Button>();
        Button UIArtworksButtonG106AddedClick = UIArtworksButtonG106Added.GetComponent<Button>();
        Button UIArtworksButtonG107AddedClick = UIArtworksButtonG107Added.GetComponent<Button>();
        Button UIArtworksButtonG108AddedClick = UIArtworksButtonG108Added.GetComponent<Button>();
        
        UIArtworksG1AddedCloseButtonClick.onClick.AddListener(UIArtworksG1AddedCloseButtonClicking);
        UIArtworksButtonG101AddedClick.onClick.AddListener(UIArtworksButtonG101AddedClicking);
        UIArtworksButtonG102AddedClick.onClick.AddListener(UIArtworksButtonG102AddedClicking);
        UIArtworksButtonG103AddedClick.onClick.AddListener(UIArtworksButtonG103AddedClicking);
        UIArtworksButtonG104AddedClick.onClick.AddListener(UIArtworksButtonG104AddedClicking);
        UIArtworksButtonG105AddedClick.onClick.AddListener(UIArtworksButtonG105AddedClicking);
        UIArtworksButtonG106AddedClick.onClick.AddListener(UIArtworksButtonG106AddedClicking);
        UIArtworksButtonG107AddedClick.onClick.AddListener(UIArtworksButtonG107AddedClicking);
        UIArtworksButtonG108AddedClick.onClick.AddListener(UIArtworksButtonG108AddedClicking);
        
        // Artwork Page G2
		Button UIArtworksG2AddedCloseButtonClick = UIArtworksG2AddedCloseButton.GetComponent<Button>();
        Button UIArtworksButtonG201AddedClick = UIArtworksButtonG201Added.GetComponent<Button>();
        Button UIArtworksButtonG202AddedClick = UIArtworksButtonG202Added.GetComponent<Button>();
        Button UIArtworksButtonG203AddedClick = UIArtworksButtonG203Added.GetComponent<Button>();
        Button UIArtworksButtonG204AddedClick = UIArtworksButtonG204Added.GetComponent<Button>();
        Button UIArtworksButtonG205AddedClick = UIArtworksButtonG205Added.GetComponent<Button>();
        Button UIArtworksButtonG206AddedClick = UIArtworksButtonG206Added.GetComponent<Button>();
        Button UIArtworksButtonG207AddedClick = UIArtworksButtonG207Added.GetComponent<Button>();
        Button UIArtworksButtonG208AddedClick = UIArtworksButtonG208Added.GetComponent<Button>();
        
        UIArtworksG2AddedCloseButtonClick.onClick.AddListener(UIArtworksG2AddedCloseButtonClicking);
        UIArtworksButtonG201AddedClick.onClick.AddListener(UIArtworksButtonG201AddedClicking);
        UIArtworksButtonG202AddedClick.onClick.AddListener(UIArtworksButtonG202AddedClicking);
        UIArtworksButtonG203AddedClick.onClick.AddListener(UIArtworksButtonG203AddedClicking);
        UIArtworksButtonG204AddedClick.onClick.AddListener(UIArtworksButtonG204AddedClicking);
        UIArtworksButtonG205AddedClick.onClick.AddListener(UIArtworksButtonG205AddedClicking);
        UIArtworksButtonG206AddedClick.onClick.AddListener(UIArtworksButtonG206AddedClicking);
        UIArtworksButtonG207AddedClick.onClick.AddListener(UIArtworksButtonG207AddedClicking);
        UIArtworksButtonG208AddedClick.onClick.AddListener(UIArtworksButtonG208AddedClicking);
        
        // Artwork Page G3
		Button UIArtworksG3AddedCloseButtonClick = UIArtworksG3AddedCloseButton.GetComponent<Button>();
        Button UIArtworksButtonG301AddedClick = UIArtworksButtonG301Added.GetComponent<Button>();
        Button UIArtworksButtonG302AddedClick = UIArtworksButtonG302Added.GetComponent<Button>();
        Button UIArtworksButtonG303AddedClick = UIArtworksButtonG303Added.GetComponent<Button>();
        Button UIArtworksButtonG304AddedClick = UIArtworksButtonG304Added.GetComponent<Button>();
        Button UIArtworksButtonG305AddedClick = UIArtworksButtonG305Added.GetComponent<Button>();
        Button UIArtworksButtonG306AddedClick = UIArtworksButtonG306Added.GetComponent<Button>();
        Button UIArtworksButtonG307AddedClick = UIArtworksButtonG307Added.GetComponent<Button>();
        Button UIArtworksButtonG308AddedClick = UIArtworksButtonG308Added.GetComponent<Button>();
        
        UIArtworksG3AddedCloseButtonClick.onClick.AddListener(UIArtworksG3AddedCloseButtonClicking);
        UIArtworksButtonG301AddedClick.onClick.AddListener(UIArtworksButtonG301AddedClicking);
        UIArtworksButtonG302AddedClick.onClick.AddListener(UIArtworksButtonG302AddedClicking);
        UIArtworksButtonG303AddedClick.onClick.AddListener(UIArtworksButtonG303AddedClicking);
        UIArtworksButtonG304AddedClick.onClick.AddListener(UIArtworksButtonG304AddedClicking);
        UIArtworksButtonG305AddedClick.onClick.AddListener(UIArtworksButtonG305AddedClicking);
        UIArtworksButtonG306AddedClick.onClick.AddListener(UIArtworksButtonG306AddedClicking);
        UIArtworksButtonG307AddedClick.onClick.AddListener(UIArtworksButtonG307AddedClicking);
        UIArtworksButtonG308AddedClick.onClick.AddListener(UIArtworksButtonG308AddedClicking);
        
        // Artwork Page FB
		Button UIArtworksFBAddedCloseButtonClick = UIArtworksFBAddedCloseButton.GetComponent<Button>();
        Button UIArtworksButtonFB01AddedClick = UIArtworksButtonFB01Added.GetComponent<Button>();
        Button UIArtworksButtonFB02AddedClick = UIArtworksButtonFB02Added.GetComponent<Button>();
        Button UIArtworksButtonFB03AddedClick = UIArtworksButtonFB03Added.GetComponent<Button>();
        Button UIArtworksButtonFB04AddedClick = UIArtworksButtonFB04Added.GetComponent<Button>();
        Button UIArtworksButtonFB05AddedClick = UIArtworksButtonFB05Added.GetComponent<Button>();
        Button UIArtworksButtonFB06AddedClick = UIArtworksButtonFB06Added.GetComponent<Button>();
        Button UIArtworksButtonFB07AddedClick = UIArtworksButtonFB07Added.GetComponent<Button>();
        Button UIArtworksButtonFB08AddedClick = UIArtworksButtonFB08Added.GetComponent<Button>();
        Button UIArtworksButtonFB09AddedClick = UIArtworksButtonFB09Added.GetComponent<Button>();
        Button UIArtworksButtonFB10AddedClick = UIArtworksButtonFB10Added.GetComponent<Button>();
        
        UIArtworksFBAddedCloseButtonClick.onClick.AddListener(UIArtworksFBAddedCloseButtonClicking);
        UIArtworksButtonFB01AddedClick.onClick.AddListener(UIArtworksButtonFB01AddedClicking);
        UIArtworksButtonFB02AddedClick.onClick.AddListener(UIArtworksButtonFB02AddedClicking);
        UIArtworksButtonFB03AddedClick.onClick.AddListener(UIArtworksButtonFB03AddedClicking);
        UIArtworksButtonFB04AddedClick.onClick.AddListener(UIArtworksButtonFB04AddedClicking);
        UIArtworksButtonFB05AddedClick.onClick.AddListener(UIArtworksButtonFB05AddedClicking);
        UIArtworksButtonFB06AddedClick.onClick.AddListener(UIArtworksButtonFB06AddedClicking);
        UIArtworksButtonFB07AddedClick.onClick.AddListener(UIArtworksButtonFB07AddedClicking);
        UIArtworksButtonFB08AddedClick.onClick.AddListener(UIArtworksButtonFB08AddedClicking);
        UIArtworksButtonFB09AddedClick.onClick.AddListener(UIArtworksButtonFB09AddedClicking);
        UIArtworksButtonFB10AddedClick.onClick.AddListener(UIArtworksButtonFB10AddedClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- BUTTONS FUNCTION ---------------
    // F1
    public void UIArtworksF1AddedCloseButtonClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Main Artworks Page
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 1;
    }
    
    public void UIArtworksButtonF101AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 1001;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF102AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 1002;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF103AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 1003;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF104AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 1004;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF105AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 1005;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF106AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 1006;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF107AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 1007;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF108AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 1008;
		Scene37BLoading.Scene37BLoad();
    }
    
    // F2
    public void UIArtworksF2AddedCloseButtonClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Main Artworks Page
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 2;
    }
    
    public void UIArtworksButtonF201AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 2001;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF202AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 2002;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF203AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 2003;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF204AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 2004;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF205AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 2005;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF206AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 2006;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF207AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 2007;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF208AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 2008;
		Scene37BLoading.Scene37BLoad();
    }
    
    // F3
    public void UIArtworksF3AddedCloseButtonClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Main Artworks Page
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 3;
    }
    
    public void UIArtworksButtonF301AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 3001;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF302AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 3002;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF303AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 3003;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF304AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 3004;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF305AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 3005;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF306AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 3006;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF307AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 3007;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonF308AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 3008;
		Scene37BLoading.Scene37BLoad();
    }
    
    // G1
    public void UIArtworksG1AddedCloseButtonClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Main Artworks Page
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 4;
    }
    
    public void UIArtworksButtonG101AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 4001;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG102AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 4002;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG103AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 4003;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG104AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 4004;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG105AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 4005;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG106AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 4006;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG107AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 4007;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG108AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 4008;
		Scene37BLoading.Scene37BLoad();
    }
    
    // G2
    public void UIArtworksG2AddedCloseButtonClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Main Artworks Page
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 5;
    }
    
    public void UIArtworksButtonG201AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 5001;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG202AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 5002;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG203AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 5003;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG204AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 5004;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG205AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 5005;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG206AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 5006;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG207AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 5007;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG208AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 5008;
		Scene37BLoading.Scene37BLoad();
    }
    
    // G3
    public void UIArtworksG3AddedCloseButtonClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Main Artworks Page
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 7;
    }
    
    public void UIArtworksButtonG301AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 7001;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG302AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 7002;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG303AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 7003;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG304AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 7004;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG305AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 7005;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG306AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 7006;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG307AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 7007;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonG308AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 7008;
		Scene37BLoading.Scene37BLoad();
    }
    
    // FB
    public void UIArtworksFBAddedCloseButtonClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Main Artworks Page
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 6;
    }
    
    public void UIArtworksButtonFB01AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 6001;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonFB02AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 6002;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonFB03AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 6003;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonFB04AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 6004;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonFB05AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 6005;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonFB06AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 6006;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonFB07AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 6007;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonFB08AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 6008;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonFB09AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 6009;
		Scene37BLoading.Scene37BLoad();
    }
    
    public void UIArtworksButtonFB10AddedClicking() {
        // Disable All
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        
        ArtworksPageF1AddedDisabling.ArtworksPageF1AddedDisable();
        ArtworksPageF2AddedDisabling.ArtworksPageF2AddedDisable();
        ArtworksPageF3AddedDisabling.ArtworksPageF3AddedDisable();
        ArtworksPageG1AddedDisabling.ArtworksPageG1AddedDisable();
        ArtworksPageG2AddedDisabling.ArtworksPageG2AddedDisable();
        ArtworksPageG3AddedDisabling.ArtworksPageG3AddedDisable();
        ArtworksPageFBAddedDisabling.ArtworksPageFBAddedDisable();
        
        // Load Artwork Page
        MainArtworkPageButtons.IdentifyArtworkButton = 6010;
		Scene37BLoading.Scene37BLoad();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}