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

public class MainMenuButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button UIGhostArtButton;
	public Button UIUserProfile;
	public Button UICastleMap;
	public Button UIYourOwnGallery;
    
    // Bank Account
    public Button UIBankAccountField;
    public Button UIBankAccountTitle;
    public Button UIBankAccountText;
    public Button UIBankAccountClickedButton;
    
    // Current Scene
    public Button UICurrentSceneField;
    public Button UIFloorNameText;
    public Button UIRoomNameText;
    public Button UICurrentSceneClickedButton;
	
// --------------- PRIVATE VARIABLES ---------------
	private int LogInTipNumber;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	// Auth
	private FirebaseAuth PlayerAuthentication;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Ghost Book
	public MainMenuGhostBookEnable FMainUIGhostArtBookEnabling;
	
	// Map Book
	public MainMenuMapBookEnable MainCastleMapBookEnabling;
    public MainMenuMapBookEnable MainCastleMapBookTextEnabling;
	
	// Profile Book
	public MainMenuProfileBookEnable MainProfileBookAllEnabling;
	
	// Disable All
	public MainMenuGhostBookEnable FMainUIGhostArtAllDisabling;
	public MainMenuMapBookEnable MainCastleMapBookAllDisabling;
	public MainMenuProfileBookEnable MainProfileBookAllDisabling;
	public MainMenuScrollBookEnable MainScrollBookAllDisabling;
    
    // Bank Account
    public MainMenuEnable MainBankClickedEnabling;
    public MainMenuEnable MainBankClickedDisabling;
    
    // Current Scene
    public MainMenuEnable MainCurrentSceneClickedEnabling;
    public MainMenuEnable MainCurrentSceneClickedDisabling;
    
    // Own Gallery
    public SceneLoad Scene41Loading;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        // Firebase Auth
		PlayerAuthentication = FirebaseAuth.DefaultInstance;
        
		Button UIGhostArtButtonClick = UIGhostArtButton.GetComponent<Button>();
		Button UIUserProfileClick = UIUserProfile.GetComponent<Button>();
		Button UICastleMapClick = UICastleMap.GetComponent<Button>();
		Button UIYourOwnGalleryClick = UIYourOwnGallery.GetComponent<Button>();
		
		UIGhostArtButtonClick.onClick.AddListener(UIGhostArtButtonClicking);
		UIUserProfileClick.onClick.AddListener(UIUserProfileClicking);
		UICastleMapClick.onClick.AddListener(UICastleMapClicking);
		UIYourOwnGalleryClick.onClick.AddListener(UIYourOwnGalleryClicking);
        
        // Bank Account
        Button UIBankAccountFieldClick = UIBankAccountField.GetComponent<Button>();
		UIBankAccountFieldClick.onClick.AddListener(UIBankAccountFieldClicking);
        
        Button UIBankAccountTitleClick = UIBankAccountTitle.GetComponent<Button>();
		UIBankAccountTitleClick.onClick.AddListener(UIBankAccountTitleClicking);
        
        Button UIBankAccountTextClick = UIBankAccountText.GetComponent<Button>();
		UIBankAccountTextClick.onClick.AddListener(UIBankAccountTextClicking);
        
        Button UIBankAccountClickedButtonClick = UIBankAccountClickedButton.GetComponent<Button>();
		UIBankAccountClickedButtonClick.onClick.AddListener(UIBankAccountClickedButtonClicking);
        
        // Current Scene
        Button UICurrentSceneFieldClick = UICurrentSceneField.GetComponent<Button>();
		UICurrentSceneFieldClick.onClick.AddListener(UICurrentSceneFieldClicking);
        
        Button UIFloorNameTextClick = UIFloorNameText.GetComponent<Button>();
		UIFloorNameTextClick.onClick.AddListener(UIFloorNameTextClicking);
        
        Button UIRoomNameTextClick = UIRoomNameText.GetComponent<Button>();
		UIRoomNameTextClick.onClick.AddListener(UIRoomNameTextClicking);
        
        Button UICurrentSceneClickedButtonClick = UICurrentSceneClickedButton.GetComponent<Button>();
		UICurrentSceneClickedButtonClick.onClick.AddListener(UICurrentSceneClickedButtonClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- DISABLE ALL BOOKS FUNCTIONS ---------------
	public void UIAllBooksDisable() {
		FMainUIGhostArtAllDisabling.FMainUIGhostArtAllDisable();
		MainCastleMapBookAllDisabling.MainCastleMapBookAllDisable();
		MainProfileBookAllDisabling.MainProfileBookAllDisable();
		MainScrollBookAllDisabling.MainScrollBookAllDisable();
	}
	
// --------------- BUTTON FUNCTIONS ---------------
	public void UIGhostArtButtonClicking() {
		// Disable All Books
		UIAllBooksDisable();
		
		// Enable Book
		FMainUIGhostArtBookEnabling.FMainUIGhostArtBookEnable();
	}
	
	public void UIUserProfileClicking() {
		// Disable All Books
		UIAllBooksDisable();
		
		// Enable Book
		MainProfileBookAllEnabling.MainProfileBookAllEnable();
	}
	
	public void UICastleMapClicking() {
		// Disable All Books
		UIAllBooksDisable();
		
		// Enable Book
		MainCastleMapBookEnabling.MainCastleMapBookEnable();
        MainCastleMapBookTextEnabling.MainCastleMapBookTextEnable();
        
        // Change Next Log In Tip & Hint
        LogInTipNumber = int.Parse(DataFillingInformation.DBLogInTipsHints);
        LogInTipNumber = LogInTipNumber + 1;
        
        if (LogInTipNumber >= 13) {
            LogInTipNumber = 1;
        }
        FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBLogInTipsHints").SetValueAsync(LogInTipNumber);
        
        DataFillingInformation.DBLogInTipsHints = LogInTipNumber.ToString();
	}
	
	public void UIYourOwnGalleryClicking() {
		// Disable All Books
		UIAllBooksDisable();
		
		// Open Own Gallery
		Scene41Loading.Scene41Load();
	}
    
    public void UIBankAccountFieldClicking() {
        MainBankClickedEnabling.MainBankClickedEnable();
    }
    
    public void UIBankAccountTitleClicking() {
        MainBankClickedEnabling.MainBankClickedEnable();
    }
    
    public void UIBankAccountTextClicking() {
        MainBankClickedEnabling.MainBankClickedEnable();
    }
    
    public void UIBankAccountClickedButtonClicking() {
        MainBankClickedDisabling.MainBankClickedDisable();
    }
    
    public void UICurrentSceneFieldClicking() {
        MainCurrentSceneClickedEnabling.MainCurrentSceneClickedEnable();
    }
    
    public void UIFloorNameTextClicking() {
        MainCurrentSceneClickedEnabling.MainCurrentSceneClickedEnable();
    }
    
    public void UIRoomNameTextClicking() {
        MainCurrentSceneClickedEnabling.MainCurrentSceneClickedEnable();
    }
    
    public void UICurrentSceneClickedButtonClicking() {
        MainCurrentSceneClickedDisabling.MainCurrentSceneClickedDisable();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}