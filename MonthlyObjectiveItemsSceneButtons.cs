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

public class MonthlyObjectiveItemsSceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button UIMonthlyObjectiveItemsBackButton;
    public Button UIMonthlyObjectiveItemsCloseButton;
    public Button UIMonthlyObjectiveItemsNumber1;
    public Button UIMonthlyObjectiveItemsNumber2;
    public Button UIMonthlyObjectiveItemsNumber3;
    public Button UIMonthlyObjectiveItemsNumber4;
    public Button UIMonthlyObjectiveItemsNumber5;
    public Button UIMonthlyObjectiveItemsFieldClaimPrizeText;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Load
    public SceneLoad Scene05Loading;
    
    // Scene Objects
    public MonthlyObjectiveItemsSceneEnable IndividualMonthlyObjectiveItemsFieldEnabling;
    
    public MonthlyObjectiveItemsSceneEnable IndividualMonthlyObjectiveItemsFieldDisabling;
    
    // Enable Objects
    public PlayerObjectivesSceneEnable PlayerObjectiveItemsMainEnabling;
    
    // Disable Objects
    public PlayerObjectivesSceneEnable PlayerObjectiveItemsMainDisabling;
    public MonthlyObjectiveItemsSceneEnable IndividualMonthlyObjectiveItemsAllDisabling;
    public AllTimeObjectivesSceneEnable AllTimeObjectiveItemsAllDisabling;
    
    // Objective Rewards
    public EventObjectiveRewards EventObjectiveRewards101Prize;
    public EventObjectiveRewards EventObjectiveRewards102Prize;
    public EventObjectiveRewards EventObjectiveRewards103Prize;
    public EventObjectiveRewards EventObjectiveRewards104Prize;
    public EventObjectiveRewards EventObjectiveRewards105Prize;
    public EventObjectiveRewards EventObjectiveRewards201Prize;
    public EventObjectiveRewards EventObjectiveRewards202Prize;
    public EventObjectiveRewards EventObjectiveRewards203Prize;
    public EventObjectiveRewards EventObjectiveRewards204Prize;
    public EventObjectiveRewards EventObjectiveRewards205Prize;
    public EventObjectiveRewards EventObjectiveRewards301Prize;
    public EventObjectiveRewards EventObjectiveRewards302Prize;
    public EventObjectiveRewards EventObjectiveRewards303Prize;
    public EventObjectiveRewards EventObjectiveRewards304Prize;
    public EventObjectiveRewards EventObjectiveRewards305Prize;
    public EventObjectiveRewards EventObjectiveRewards401Prize;
    public EventObjectiveRewards EventObjectiveRewards402Prize;
    public EventObjectiveRewards EventObjectiveRewards403Prize;
    public EventObjectiveRewards EventObjectiveRewards404Prize;
    public EventObjectiveRewards EventObjectiveRewards405Prize;
    public EventObjectiveRewards EventObjectiveRewards501Prize;
    public EventObjectiveRewards EventObjectiveRewards502Prize;
    public EventObjectiveRewards EventObjectiveRewards503Prize;
    public EventObjectiveRewards EventObjectiveRewards504Prize;
    public EventObjectiveRewards EventObjectiveRewards505Prize;
    public EventObjectiveRewards EventObjectiveRewards601Prize;
    public EventObjectiveRewards EventObjectiveRewards602Prize;
    public EventObjectiveRewards EventObjectiveRewards603Prize;
    public EventObjectiveRewards EventObjectiveRewards604Prize;
    public EventObjectiveRewards EventObjectiveRewards605Prize;
    
    // Success Sound
    public SoundMusicPlaying SuccessSoundPlaying;

	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Back Button
		Button UIMonthlyObjectiveItemsBackButtonClick = UIMonthlyObjectiveItemsBackButton.GetComponent<Button>();
		UIMonthlyObjectiveItemsBackButtonClick.onClick.AddListener(UIMonthlyObjectiveItemsBackButtonClicking);
        
        // Close Button
		Button UIMonthlyObjectiveItemsCloseButtonClick = UIMonthlyObjectiveItemsCloseButton.GetComponent<Button>();
		UIMonthlyObjectiveItemsCloseButtonClick.onClick.AddListener(UIMonthlyObjectiveItemsCloseButtonClicking);
        
        // Number1 Button
		Button UIMonthlyObjectiveItemsNumber1Click = UIMonthlyObjectiveItemsNumber1.GetComponent<Button>();
		UIMonthlyObjectiveItemsNumber1Click.onClick.AddListener(UIMonthlyObjectiveItemsNumber1Clicking);
        
        // Number2 Button
		Button UIMonthlyObjectiveItemsNumber2Click = UIMonthlyObjectiveItemsNumber2.GetComponent<Button>();
		UIMonthlyObjectiveItemsNumber2Click.onClick.AddListener(UIMonthlyObjectiveItemsNumber2Clicking);
        
        // Number3 Button
		Button UIMonthlyObjectiveItemsNumber3Click = UIMonthlyObjectiveItemsNumber3.GetComponent<Button>();
		UIMonthlyObjectiveItemsNumber3Click.onClick.AddListener(UIMonthlyObjectiveItemsNumber3Clicking);
        
        // Number4 Button
		Button UIMonthlyObjectiveItemsNumber4Click = UIMonthlyObjectiveItemsNumber4.GetComponent<Button>();
		UIMonthlyObjectiveItemsNumber4Click.onClick.AddListener(UIMonthlyObjectiveItemsNumber4Clicking);
        
        // Number5 Button
		Button UIMonthlyObjectiveItemsNumber5Click = UIMonthlyObjectiveItemsNumber5.GetComponent<Button>();
		UIMonthlyObjectiveItemsNumber5Click.onClick.AddListener(UIMonthlyObjectiveItemsNumber5Clicking);
        
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
    public void UIMonthlyObjectiveItemsBackButtonClicking() {
        // Disable Objects
        PlayerObjectiveItemsMainDisabling.PlayerObjectiveItemsMainDisable();
        IndividualMonthlyObjectiveItemsAllDisabling.IndividualMonthlyObjectiveItemsAllDisable();
        AllTimeObjectiveItemsAllDisabling.AllTimeObjectiveItemsAllDisable();
        
        // Enable Objects
        PlayerObjectiveItemsMainEnabling.PlayerObjectiveItemsMainEnable();
    }
    
    public void UIMonthlyObjectiveItemsCloseButtonClicking() {
        Scene05Loading.Scene05Load();
    }
    
    public void UIMonthlyObjectiveItemsNumber1Clicking() {
        // Enable Objects
        IndividualMonthlyObjectiveItemsFieldEnabling.IndividualMonthlyObjectiveItemsFieldEnable();
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 1) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 2)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 101;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 3) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 4)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 201;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 5) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 6)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 301;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 7) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 8)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 401;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 9) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 10)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 501;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 11) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 12)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 601;
        }
    }
    
    public void UIMonthlyObjectiveItemsNumber2Clicking() {
        // Enable Objects
        IndividualMonthlyObjectiveItemsFieldEnabling.IndividualMonthlyObjectiveItemsFieldEnable();
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 1) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 2)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 102;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 3) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 4)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 202;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 5) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 6)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 302;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 7) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 8)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 402;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 9) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 10)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 502;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 11) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 12)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 602;
        }
    }
    
    public void UIMonthlyObjectiveItemsNumber3Clicking() {
        // Enable Objects
        IndividualMonthlyObjectiveItemsFieldEnabling.IndividualMonthlyObjectiveItemsFieldEnable();
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 1) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 2)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 103;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 3) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 4)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 203;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 5) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 6)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 303;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 7) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 8)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 403;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 9) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 10)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 503;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 11) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 12)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 603;
        }
    }
    
    public void UIMonthlyObjectiveItemsNumber4Clicking() {
        // Enable Objects
        IndividualMonthlyObjectiveItemsFieldEnabling.IndividualMonthlyObjectiveItemsFieldEnable();
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 1) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 2)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 104;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 3) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 4)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 204;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 5) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 6)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 304;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 7) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 8)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 404;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 9) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 10)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 504;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 11) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 12)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 604;
        }
    }
    
    public void UIMonthlyObjectiveItemsNumber5Clicking() {
        // Enable Objects
        IndividualMonthlyObjectiveItemsFieldEnabling.IndividualMonthlyObjectiveItemsFieldEnable();
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 1) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 2)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 105;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 3) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 4)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 205;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 5) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 6)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 305;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 7) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 8)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 405;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 9) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 10)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 505;
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 11) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 12)) {
            MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber = 605;
        }
    }
    
    public void UIMonthlyObjectiveItemsFieldClaimPrizeTextClicking() {
        SuccessSoundPlaying.SuccessSoundPlay();
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 1) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 2)) {
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 101) {
                EventObjectiveRewards101Prize.EventObjectiveRewards101();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 102) {
                EventObjectiveRewards102Prize.EventObjectiveRewards102();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 103) {
                EventObjectiveRewards103Prize.EventObjectiveRewards103();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 104) {
                EventObjectiveRewards104Prize.EventObjectiveRewards104();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 105) {
                EventObjectiveRewards105Prize.EventObjectiveRewards105();
            }
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 3) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 4)) {
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 201) {
                EventObjectiveRewards201Prize.EventObjectiveRewards201();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 202) {
                EventObjectiveRewards202Prize.EventObjectiveRewards202();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 203) {
                EventObjectiveRewards203Prize.EventObjectiveRewards203();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 204) {
                EventObjectiveRewards204Prize.EventObjectiveRewards204();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 205) {
                EventObjectiveRewards205Prize.EventObjectiveRewards205();
            }
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 5) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 6)) {
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 301) {
                EventObjectiveRewards301Prize.EventObjectiveRewards301();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 302) {
                EventObjectiveRewards302Prize.EventObjectiveRewards302();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 303) {
                EventObjectiveRewards303Prize.EventObjectiveRewards303();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 304) {
                EventObjectiveRewards304Prize.EventObjectiveRewards304();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 305) {
                EventObjectiveRewards305Prize.EventObjectiveRewards305();
            }
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 7) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 8)) {
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 401) {
                EventObjectiveRewards401Prize.EventObjectiveRewards401();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 402) {
                EventObjectiveRewards402Prize.EventObjectiveRewards402();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 403) {
                EventObjectiveRewards403Prize.EventObjectiveRewards403();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 404) {
                EventObjectiveRewards404Prize.EventObjectiveRewards404();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 405) {
                EventObjectiveRewards405Prize.EventObjectiveRewards405();
            }
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 9) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 10)) {
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 501) {
                EventObjectiveRewards501Prize.EventObjectiveRewards501();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 502) {
                EventObjectiveRewards502Prize.EventObjectiveRewards502();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 503) {
                EventObjectiveRewards503Prize.EventObjectiveRewards503();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 504) {
                EventObjectiveRewards504Prize.EventObjectiveRewards504();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 505) {
                EventObjectiveRewards505Prize.EventObjectiveRewards505();
            }
        }
        
        if ((int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 11) || (int.Parse(MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber) == 12)) {
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 601) {
                EventObjectiveRewards601Prize.EventObjectiveRewards601();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 602) {
                EventObjectiveRewards602Prize.EventObjectiveRewards602();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 603) {
                EventObjectiveRewards603Prize.EventObjectiveRewards603();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 604) {
                EventObjectiveRewards604Prize.EventObjectiveRewards604();
            }
            
            if (MonthlyObjectiveItemsSceneEnable.IndividualEventObjectiveNumber == 605) {
                EventObjectiveRewards605Prize.EventObjectiveRewards605();
            }
        }
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}