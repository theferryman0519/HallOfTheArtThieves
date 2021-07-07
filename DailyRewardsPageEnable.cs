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

public class DailyRewardsPageEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image UIDailyRewardsPageBackground;
	public Image UIDailyRewardsPageField;
	public Text UIDailyRewardsPageText;
	public Text UIDailyRewardsPageCloseButton;
	
// --------------- PRIVATE VARIABLES ---------------
	private int DailyRewardsDaysNumber;
    private int DailyRewardsCoinNumber;
    private int BankAccountNumber;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	// Auth
	private FirebaseAuth PlayerAuthentication;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		UIDailyRewardsPageEnable();
        
        DailyRewardsDaysNumber = int.Parse(DataFillingInformation.DBPlayerLogInDays);
        BankAccountNumber = int.Parse(DataFillingInformation.DBBankAccountAmount);
        
        DailyRewardsDayAmount();
        DailyRewardsCoinAmount();
        
        BankAccountNumber = BankAccountNumber + DailyRewardsCoinNumber;
        DataFillingInformation.DBBankAccountAmount = BankAccountNumber.ToString();
        FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBPlayerLogInDays").SetValueAsync(DailyRewardsDaysNumber);
        FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(BankAccountNumber);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
        if (DailyRewardsDaysNumber == 1) {
            UIDailyRewardsPageText.text = DataFillingInformation.DBPlayerName + ", you have come back to the Château " + DailyRewardsDaysNumber.ToString() + " time. As your guide, I will give you " + DailyRewardsCoinNumber.ToString("#,#") + " coins to assist you on your journey. While learning about art, I will try collecting more coins. Come back again for a larger reward!";
        }
        
        if ((DailyRewardsDaysNumber >= 2) && (DailyRewardsDaysNumber < 10)) {
            UIDailyRewardsPageText.text = DataFillingInformation.DBPlayerName + ", you have come back to the Château " + DailyRewardsDaysNumber.ToString() + " times in a row. As your guide, I will give you " + DailyRewardsCoinNumber.ToString("#,#") + " coins to assist you on your journey. While learning about art, I will try collecting more coins. Come back again for a larger reward!";
        }
        
        if ((DailyRewardsDaysNumber == 10)) {
            UIDailyRewardsPageText.text = DataFillingInformation.DBPlayerName + ", you have come back to the Château " + DailyRewardsDaysNumber.ToString() + " times in a row. As your guide, I will give you " + DailyRewardsCoinNumber.ToString("#,#") + " coins to assist you on your journey. I do not have any more coins right now, as the ghosts have found me out. Your reward counter will now reset.";
        }
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTION ---------------
	public void UIDailyRewardsPageEnable() {
		UIDailyRewardsPageBackground.enabled = true;
		UIDailyRewardsPageField.enabled = true;
		UIDailyRewardsPageText.enabled = true;
		UIDailyRewardsPageCloseButton.enabled = true;
	}
	
// --------------- DISABLE FUNCTION ---------------
	public void UIDailyRewardsPageDisable() {
		UIDailyRewardsPageBackground.enabled = false;
		UIDailyRewardsPageField.enabled = false;
		UIDailyRewardsPageText.enabled = false;
		UIDailyRewardsPageCloseButton.enabled = false;
	}
    
// --------------- DAILY REWARD DAY FUNCTION ---------------
    public void DailyRewardsDayAmount() {
        DailyRewardsDaysNumber = DailyRewardsDaysNumber + 1;
        DataFillingInformation.DBPlayerLogInDays = DailyRewardsDaysNumber.ToString();
        
        if (DailyRewardsDaysNumber == 11) {
            DailyRewardsDaysNumber = 1;
            DataFillingInformation.DBPlayerLogInDays = DailyRewardsDaysNumber.ToString();
        }
    }
    
// --------------- DAILY REWARD COIN FUNCTION ---------------
    public void DailyRewardsCoinAmount() {
        DailyRewardsCoinNumber = 1000 * DailyRewardsDaysNumber;
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}