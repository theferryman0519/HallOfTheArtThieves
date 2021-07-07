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

public class AllTimeObjectivesSceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button UIAllTimeObjectivesBackButton;
    public Button UIAllTimeObjectivesCloseButton;
    public Text UIAllTimeObjectivesItemsFieldBackButton;
    
    public Button UIAllTimeObjectivesItems01;
    public Button UIAllTimeObjectivesItems02;
    public Button UIAllTimeObjectivesItems03;
    public Button UIAllTimeObjectivesItems04;
    public Button UIAllTimeObjectivesItems05;
    public Button UIAllTimeObjectivesItems06;
    public Button UIAllTimeObjectivesItems07;
    public Button UIAllTimeObjectivesItems08;
    public Button UIAllTimeObjectivesItems09;
    public Button UIAllTimeObjectivesItems10;
    public Button UIAllTimeObjectivesItems11;
    public Button UIAllTimeObjectivesItems12;
    public Button UIAllTimeObjectivesItems13;
    public Button UIAllTimeObjectivesItems14;
    public Button UIAllTimeObjectivesItems15;
    
    public Button UIMonthlyObjectiveItemsFieldClaimPrizeText;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int AllTimeObjectiveNumber;
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Load
    public SceneLoad Scene05Loading;
    
    // Enable Objects
    public PlayerObjectivesSceneEnable PlayerObjectiveItemsMainEnabling;
    
    public AllTimeObjectivesSceneEnable AllTimeObjectiveItemsMainEnabling;
    public AllTimeObjectivesSceneEnable AllTimeObjectiveItemsButtonsEnabling;
    public AllTimeObjectivesSceneEnable AllTimeObjectiveItemsFieldEnabling;
    
    // Disable Objects
    public PlayerObjectivesSceneEnable PlayerObjectiveItemsMainDisabling;
    public MonthlyObjectiveItemsSceneEnable IndividualMonthlyObjectiveItemsAllDisabling;
    public AllTimeObjectivesSceneEnable AllTimeObjectiveItemsAllDisabling;
    
    public AllTimeObjectivesSceneEnable AllTimeObjectiveItemsButtonsDisabling;
    public AllTimeObjectivesSceneEnable AllTimeObjectiveItemsFieldDisabling;
    
    // Objective Rewards
    public AllTimeObjectiveRewards AllTimeObjectiveRewards01Prize;
    public AllTimeObjectiveRewards AllTimeObjectiveRewards02Prize;
    public AllTimeObjectiveRewards AllTimeObjectiveRewards03Prize;
    public AllTimeObjectiveRewards AllTimeObjectiveRewards04Prize;
    public AllTimeObjectiveRewards AllTimeObjectiveRewards05Prize;
    public AllTimeObjectiveRewards AllTimeObjectiveRewards06Prize;
    public AllTimeObjectiveRewards AllTimeObjectiveRewards07Prize;
    public AllTimeObjectiveRewards AllTimeObjectiveRewards08Prize;
    public AllTimeObjectiveRewards AllTimeObjectiveRewards09Prize;
    public AllTimeObjectiveRewards AllTimeObjectiveRewards10Prize;
    public AllTimeObjectiveRewards AllTimeObjectiveRewards11Prize;
    public AllTimeObjectiveRewards AllTimeObjectiveRewards12Prize;
    public AllTimeObjectiveRewards AllTimeObjectiveRewards13Prize;
    public AllTimeObjectiveRewards AllTimeObjectiveRewards14Prize;
    public AllTimeObjectiveRewards AllTimeObjectiveRewards15Prize;
    
    // Success Sound
    public SoundMusicPlaying SuccessSoundPlaying;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Back Button
		Button UIAllTimeObjectivesBackButtonClick = UIAllTimeObjectivesBackButton.GetComponent<Button>();
		UIAllTimeObjectivesBackButtonClick.onClick.AddListener(UIAllTimeObjectivesBackButtonClicking);
        
        // Close Button
		Button UIAllTimeObjectivesCloseButtonClick = UIAllTimeObjectivesCloseButton.GetComponent<Button>();
		UIAllTimeObjectivesCloseButtonClick.onClick.AddListener(UIAllTimeObjectivesCloseButtonClicking);
        
        // Objective 01 Button
		Button UIAllTimeObjectivesItems01Click = UIAllTimeObjectivesItems01.GetComponent<Button>();
		UIAllTimeObjectivesItems01Click.onClick.AddListener(UIAllTimeObjectivesItems01Clicking);
                
        // Objective 02 Button
		Button UIAllTimeObjectivesItems02Click = UIAllTimeObjectivesItems02.GetComponent<Button>();
		UIAllTimeObjectivesItems02Click.onClick.AddListener(UIAllTimeObjectivesItems02Clicking);
        
        // Objective 03 Button
		Button UIAllTimeObjectivesItems03Click = UIAllTimeObjectivesItems03.GetComponent<Button>();
		UIAllTimeObjectivesItems03Click.onClick.AddListener(UIAllTimeObjectivesItems03Clicking);
        
        // Objective 04 Button
		Button UIAllTimeObjectivesItems04Click = UIAllTimeObjectivesItems04.GetComponent<Button>();
		UIAllTimeObjectivesItems04Click.onClick.AddListener(UIAllTimeObjectivesItems04Clicking);
        
        // Objective 05 Button
		Button UIAllTimeObjectivesItems05Click = UIAllTimeObjectivesItems05.GetComponent<Button>();
		UIAllTimeObjectivesItems05Click.onClick.AddListener(UIAllTimeObjectivesItems05Clicking);
        
        // Objective 06 Button
		Button UIAllTimeObjectivesItems06Click = UIAllTimeObjectivesItems06.GetComponent<Button>();
		UIAllTimeObjectivesItems06Click.onClick.AddListener(UIAllTimeObjectivesItems06Clicking);
        
        // Objective 07 Button
		Button UIAllTimeObjectivesItems07Click = UIAllTimeObjectivesItems07.GetComponent<Button>();
		UIAllTimeObjectivesItems07Click.onClick.AddListener(UIAllTimeObjectivesItems07Clicking);
        
        // Objective 08 Button
		Button UIAllTimeObjectivesItems08Click = UIAllTimeObjectivesItems08.GetComponent<Button>();
		UIAllTimeObjectivesItems08Click.onClick.AddListener(UIAllTimeObjectivesItems08Clicking);
        
        // Objective 09 Button
		Button UIAllTimeObjectivesItems09Click = UIAllTimeObjectivesItems09.GetComponent<Button>();
		UIAllTimeObjectivesItems09Click.onClick.AddListener(UIAllTimeObjectivesItems09Clicking);
        
        // Objective 10 Button
		Button UIAllTimeObjectivesItems10Click = UIAllTimeObjectivesItems10.GetComponent<Button>();
		UIAllTimeObjectivesItems10Click.onClick.AddListener(UIAllTimeObjectivesItems10Clicking);
        
        // Objective 11 Button
		Button UIAllTimeObjectivesItems11Click = UIAllTimeObjectivesItems11.GetComponent<Button>();
		UIAllTimeObjectivesItems11Click.onClick.AddListener(UIAllTimeObjectivesItems11Clicking);
        
        // Objective 12 Button
		Button UIAllTimeObjectivesItems12Click = UIAllTimeObjectivesItems12.GetComponent<Button>();
		UIAllTimeObjectivesItems12Click.onClick.AddListener(UIAllTimeObjectivesItems12Clicking);
        
        // Objective 13 Button
		Button UIAllTimeObjectivesItems13Click = UIAllTimeObjectivesItems13.GetComponent<Button>();
		UIAllTimeObjectivesItems13Click.onClick.AddListener(UIAllTimeObjectivesItems13Clicking);
        
        // Objective 14 Button
		Button UIAllTimeObjectivesItems14Click = UIAllTimeObjectivesItems14.GetComponent<Button>();
		UIAllTimeObjectivesItems14Click.onClick.AddListener(UIAllTimeObjectivesItems14Clicking);
        
        // Objective 15 Button
		Button UIAllTimeObjectivesItems15Click = UIAllTimeObjectivesItems15.GetComponent<Button>();
		UIAllTimeObjectivesItems15Click.onClick.AddListener(UIAllTimeObjectivesItems15Clicking);
        
        // All Time Back Button
		Button UIAllTimeObjectivesItemsFieldBackButtonClick = UIAllTimeObjectivesItemsFieldBackButton.GetComponent<Button>();
		UIAllTimeObjectivesItemsFieldBackButtonClick.onClick.AddListener(UIAllTimeObjectivesItemsFieldBackButtonClicking);
        
        // Claim Prize Button
        Button UIMonthlyObjectiveItemsFieldClaimPrizeTextClick = UIMonthlyObjectiveItemsFieldClaimPrizeText.GetComponent<Button>();
		UIMonthlyObjectiveItemsFieldClaimPrizeTextClick.onClick.AddListener(UIMonthlyObjectiveItemsFieldClaimPrizeTextClicking);
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
    public void UIAllTimeObjectivesBackButtonClicking() {
        // Disable Objects
        PlayerObjectiveItemsMainDisabling.PlayerObjectiveItemsMainDisable();
        IndividualMonthlyObjectiveItemsAllDisabling.IndividualMonthlyObjectiveItemsAllDisable();
        AllTimeObjectiveItemsAllDisabling.AllTimeObjectiveItemsAllDisable();
        
        // Enable Objects
        PlayerObjectiveItemsMainEnabling.PlayerObjectiveItemsMainEnable();
    }
    
    public void UIAllTimeObjectivesCloseButtonClicking() {
        Scene05Loading.Scene05Load();
    }
    
    public void UIAllTimeObjectivesItems01Clicking() {
        // Disable Objects
        AllTimeObjectiveItemsButtonsDisabling.AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisabling.AllTimeObjectiveItemsFieldDisable();
        
        // Enable Objects
        AllTimeObjectiveNumber = 01;
        AllTimeObjectiveItemsFieldEnabling.AllTimeObjectiveItemsFieldEnable();
    }
    
    public void UIAllTimeObjectivesItems02Clicking() {
        // Disable Objects
        AllTimeObjectiveItemsButtonsDisabling.AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisabling.AllTimeObjectiveItemsFieldDisable();
        
        // Enable Objects
        AllTimeObjectiveNumber = 02;
        AllTimeObjectiveItemsFieldEnabling.AllTimeObjectiveItemsFieldEnable();
    }
    
    public void UIAllTimeObjectivesItems03Clicking() {
        // Disable Objects
        AllTimeObjectiveItemsButtonsDisabling.AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisabling.AllTimeObjectiveItemsFieldDisable();
        
        // Enable Objects
        AllTimeObjectiveNumber = 03;
        AllTimeObjectiveItemsFieldEnabling.AllTimeObjectiveItemsFieldEnable();
    }
    
    public void UIAllTimeObjectivesItems04Clicking() {
        // Disable Objects
        AllTimeObjectiveItemsButtonsDisabling.AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisabling.AllTimeObjectiveItemsFieldDisable();
        
        // Enable Objects
        AllTimeObjectiveNumber = 04;
        AllTimeObjectiveItemsFieldEnabling.AllTimeObjectiveItemsFieldEnable();
    }
    
    public void UIAllTimeObjectivesItems05Clicking() {
        // Disable Objects
        AllTimeObjectiveItemsButtonsDisabling.AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisabling.AllTimeObjectiveItemsFieldDisable();
        
        // Enable Objects
        AllTimeObjectiveNumber = 05;
        AllTimeObjectiveItemsFieldEnabling.AllTimeObjectiveItemsFieldEnable();
    }
    
    public void UIAllTimeObjectivesItems06Clicking() {
        // Disable Objects
        AllTimeObjectiveItemsButtonsDisabling.AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisabling.AllTimeObjectiveItemsFieldDisable();
        
        // Enable Objects
        AllTimeObjectiveNumber = 06;
        AllTimeObjectiveItemsFieldEnabling.AllTimeObjectiveItemsFieldEnable();
    }
    
    public void UIAllTimeObjectivesItems07Clicking() {
        // Disable Objects
        AllTimeObjectiveItemsButtonsDisabling.AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisabling.AllTimeObjectiveItemsFieldDisable();
        
        // Enable Objects
        AllTimeObjectiveNumber = 07;
        AllTimeObjectiveItemsFieldEnabling.AllTimeObjectiveItemsFieldEnable();
    }
    
    public void UIAllTimeObjectivesItems08Clicking() {
        // Disable Objects
        AllTimeObjectiveItemsButtonsDisabling.AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisabling.AllTimeObjectiveItemsFieldDisable();
        
        // Enable Objects
        AllTimeObjectiveNumber = 08;
        AllTimeObjectiveItemsFieldEnabling.AllTimeObjectiveItemsFieldEnable();
    }
    
    public void UIAllTimeObjectivesItems09Clicking() {
        // Disable Objects
        AllTimeObjectiveItemsButtonsDisabling.AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisabling.AllTimeObjectiveItemsFieldDisable();
        
        // Enable Objects
        AllTimeObjectiveNumber = 09;
        AllTimeObjectiveItemsFieldEnabling.AllTimeObjectiveItemsFieldEnable();
    }
    
    public void UIAllTimeObjectivesItems10Clicking() {
        // Disable Objects
        AllTimeObjectiveItemsButtonsDisabling.AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisabling.AllTimeObjectiveItemsFieldDisable();
        
        // Enable Objects
        AllTimeObjectiveNumber = 10;
        AllTimeObjectiveItemsFieldEnabling.AllTimeObjectiveItemsFieldEnable();
    }
    
    public void UIAllTimeObjectivesItems11Clicking() {
        // Disable Objects
        AllTimeObjectiveItemsButtonsDisabling.AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisabling.AllTimeObjectiveItemsFieldDisable();
        
        // Enable Objects
        AllTimeObjectiveNumber = 11;
        AllTimeObjectiveItemsFieldEnabling.AllTimeObjectiveItemsFieldEnable();
    }
    
    public void UIAllTimeObjectivesItems12Clicking() {
        // Disable Objects
        AllTimeObjectiveItemsButtonsDisabling.AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisabling.AllTimeObjectiveItemsFieldDisable();
        
        // Enable Objects
        AllTimeObjectiveNumber = 12;
        AllTimeObjectiveItemsFieldEnabling.AllTimeObjectiveItemsFieldEnable();
    }
    
    public void UIAllTimeObjectivesItems13Clicking() {
        // Disable Objects
        AllTimeObjectiveItemsButtonsDisabling.AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisabling.AllTimeObjectiveItemsFieldDisable();
        
        // Enable Objects
        AllTimeObjectiveNumber = 13;
        AllTimeObjectiveItemsFieldEnabling.AllTimeObjectiveItemsFieldEnable();
    }
    
    public void UIAllTimeObjectivesItems14Clicking() {
        // Disable Objects
        AllTimeObjectiveItemsButtonsDisabling.AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisabling.AllTimeObjectiveItemsFieldDisable();
        
        // Enable Objects
        AllTimeObjectiveNumber = 14;
        AllTimeObjectiveItemsFieldEnabling.AllTimeObjectiveItemsFieldEnable();
    }
    
    public void UIAllTimeObjectivesItems15Clicking() {
        // Disable Objects
        AllTimeObjectiveItemsButtonsDisabling.AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisabling.AllTimeObjectiveItemsFieldDisable();
        
        // Enable Objects
        AllTimeObjectiveNumber = 15;
        AllTimeObjectiveItemsFieldEnabling.AllTimeObjectiveItemsFieldEnable();
    }
    
    public void UIAllTimeObjectivesItemsFieldBackButtonClicking() {
        // Disable Objects
        PlayerObjectiveItemsMainDisabling.PlayerObjectiveItemsMainDisable();
        IndividualMonthlyObjectiveItemsAllDisabling.IndividualMonthlyObjectiveItemsAllDisable();
        AllTimeObjectiveItemsAllDisabling.AllTimeObjectiveItemsAllDisable();
        
        // Enable Objects
        AllTimeObjectiveItemsMainEnabling.AllTimeObjectiveItemsMainEnable();
        AllTimeObjectiveItemsButtonsEnabling.AllTimeObjectiveItemsButtonsEnable();
    }
    
    public void UIMonthlyObjectiveItemsFieldClaimPrizeTextClicking() {
        SuccessSoundPlaying.SuccessSoundPlay();
        
        if (AllTimeObjectiveNumber == 01) {
            AllTimeObjectiveRewards01Prize.AllTimeObjectiveRewards01();
        }
        
        if (AllTimeObjectiveNumber == 02) {
            AllTimeObjectiveRewards02Prize.AllTimeObjectiveRewards02();
        }
        
        if (AllTimeObjectiveNumber == 03) {
            AllTimeObjectiveRewards03Prize.AllTimeObjectiveRewards03();
        }
        
        if (AllTimeObjectiveNumber == 04) {
            AllTimeObjectiveRewards04Prize.AllTimeObjectiveRewards04();
        }
        
        if (AllTimeObjectiveNumber == 05) {
            AllTimeObjectiveRewards05Prize.AllTimeObjectiveRewards05();
        }
        
        if (AllTimeObjectiveNumber == 06) {
            AllTimeObjectiveRewards06Prize.AllTimeObjectiveRewards06();
        }
        
        if (AllTimeObjectiveNumber == 07) {
            AllTimeObjectiveRewards07Prize.AllTimeObjectiveRewards07();
        }
        
        if (AllTimeObjectiveNumber == 08) {
            AllTimeObjectiveRewards08Prize.AllTimeObjectiveRewards08();
        }
        
        if (AllTimeObjectiveNumber == 09) {
            AllTimeObjectiveRewards09Prize.AllTimeObjectiveRewards09();
        }
        
        if (AllTimeObjectiveNumber == 10) {
            AllTimeObjectiveRewards10Prize.AllTimeObjectiveRewards10();
        }
        
        if (AllTimeObjectiveNumber == 11) {
            AllTimeObjectiveRewards11Prize.AllTimeObjectiveRewards11();
        }
        
        if (AllTimeObjectiveNumber == 12) {
            AllTimeObjectiveRewards12Prize.AllTimeObjectiveRewards12();
        }
        
        if (AllTimeObjectiveNumber == 13) {
            AllTimeObjectiveRewards13Prize.AllTimeObjectiveRewards13();
        }
        
        if (AllTimeObjectiveNumber == 14) {
            AllTimeObjectiveRewards14Prize.AllTimeObjectiveRewards14();
        }
        
        if (AllTimeObjectiveNumber == 15) {
            AllTimeObjectiveRewards15Prize.AllTimeObjectiveRewards15();
        }
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}