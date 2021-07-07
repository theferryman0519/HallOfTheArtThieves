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

public class MainMenuProfileBookEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image UIProfileBookPageLeft;
	public Image UIProfileBookPageRight;
	public Text UIProfileTitleMain;
	
	public Text UIProfilePlayerNameTitle;
	public Text UIProfilePlayerNameText;
	public Text UIProfileEmailTitle;
	public Text UIProfileEmailText;
	public Text UIProfileCoinTitle;
	public Text UIProfileCoinText;
	public Text UIProfileArtAmountTitle;
	public Text UIProfileArtAmountText;
	public Text UIProfileRankTitle;
	public Text UIProfileRankText;
	public Text UIProfileArtistTitle;
	public Text UIProfileArtistText;
		
	public Text UIProfileTitle;
	public Text UIProfileTutorialButton;
	public Text UIProfileCreditsButton;
	public Text UIProfileContactButton;
	
	public Image UIProfileCloseButton;
	public Text UIProfileCloseButtonText;
    
    public Image UIProfileBookSoundsOff;
    public Image UIProfileBookSoundsOn;
    
    public Image UIProfileBookStoreButton;
    public Text UIProfileBookStoreButtonText;
	
// --------------- PRIVATE VARIABLES ---------------
	private int CoinAmount;
	
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
        
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).GetValueAsync().ContinueWith(playertask => {
                if (playertask.IsCanceled || playertask.IsFaulted) {
                    
                }

                else {
                    DataSnapshot ChateauSnapshot = playertask.Result;

                    DataFillingInformation.DBPlayerName = ChateauSnapshot.Child("DBPlayerName").Value.ToString();
                    DataFillingInformation.DBPlayerEmail = ChateauSnapshot.Child("DBPlayerEmail").Value.ToString();
                    DataFillingInformation.DBPlayerFavArtist = ChateauSnapshot.Child("DBPlayerFavArtist").Value.ToString();
                    DataFillingInformation.DBBankAccountAmount = ChateauSnapshot.Child("DBBankAccountAmount").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollected = ChateauSnapshot.Child("DBNumberOfArtworksCollected").Value.ToString();
                }
            });
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).GetValueAsync().ContinueWith(playertask => {
                if (playertask.IsCanceled || playertask.IsFaulted) {
                    
                }

                else {
                    DataSnapshot ChateauSnapshot = playertask.Result;

                    DataFillingInformation.DBPlayerName = ChateauSnapshot.Child("DBPlayerName").Value.ToString();
                    DataFillingInformation.DBPlayerEmail = ChateauSnapshot.Child("DBPlayerEmail").Value.ToString();
                    DataFillingInformation.DBPlayerFavArtist = ChateauSnapshot.Child("DBPlayerFavArtist").Value.ToString();
                    DataFillingInformation.DBBankAccountAmount = ChateauSnapshot.Child("DBBankAccountAmount").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollected = ChateauSnapshot.Child("DBNumberOfArtworksCollected").Value.ToString();
                }
            });
        }
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		MainProfileBookAllDisable();
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		MainProfileFillInfo();
        MainProfileBookSoundsEnable();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void MainProfileBookAllEnable() {
		UIProfileBookPageLeft.enabled = true;
		UIProfileBookPageRight.enabled = true;
		UIProfileTitleMain.enabled = true;
		UIProfilePlayerNameTitle.enabled = true;
		UIProfilePlayerNameText.enabled = true;
		UIProfileEmailTitle.enabled = true;
		UIProfileEmailText.enabled = true;
		UIProfileCoinTitle.enabled = true;
		UIProfileCoinText.enabled = true;
		UIProfileArtAmountTitle.enabled = true;
		UIProfileArtAmountText.enabled = true;
		UIProfileRankTitle.enabled = true;
		UIProfileRankText.enabled = true;
		UIProfileArtistTitle.enabled = true;
		UIProfileArtistText.enabled = true;
		UIProfileTitle.enabled = true;
		UIProfileTutorialButton.enabled = true;
		UIProfileCreditsButton.enabled = true;
		UIProfileContactButton.enabled = true;
		UIProfileCloseButton.enabled = true;
		UIProfileCloseButtonText.enabled = true;
        UIProfileBookStoreButton.enabled = true;
        UIProfileBookStoreButtonText.enabled = true;
	}
    
    public void MainProfileBookSoundsEnable() {
        if (UIProfileBookPageLeft.enabled == true) {
            if (OpeningMusic.MusicIsMute == 0) {
                UIProfileBookSoundsOff.enabled = true;
                UIProfileBookSoundsOn.enabled = false;
            }

            if (OpeningMusic.MusicIsMute == 1) {
                UIProfileBookSoundsOff.enabled = false;
                UIProfileBookSoundsOn.enabled = true;
            }
        }
    }
	
// --------------- DISABLE FUNCTIONS ---------------
	public void MainProfileBookAllDisable() {
		UIProfileBookPageLeft.enabled = false;
		UIProfileBookPageRight.enabled = false;
		UIProfileTitleMain.enabled = false;
		UIProfilePlayerNameTitle.enabled = false;
		UIProfilePlayerNameText.enabled = false;
		UIProfileEmailTitle.enabled = false;
		UIProfileEmailText.enabled = false;
		UIProfileCoinTitle.enabled = false;
		UIProfileCoinText.enabled = false;
		UIProfileArtAmountTitle.enabled = false;
		UIProfileArtAmountText.enabled = false;
		UIProfileRankTitle.enabled = false;
		UIProfileRankText.enabled = false;
		UIProfileArtistTitle.enabled = false;
		UIProfileArtistText.enabled = false;
		UIProfileTitle.enabled = false;
		UIProfileTutorialButton.enabled = false;
		UIProfileCreditsButton.enabled = false;
		UIProfileContactButton.enabled = false;
		UIProfileCloseButton.enabled = false;
		UIProfileCloseButtonText.enabled = false;
        UIProfileBookSoundsOff.enabled = false;
        UIProfileBookSoundsOn.enabled = false;
        UIProfileBookStoreButton.enabled = false;
        UIProfileBookStoreButtonText.enabled = false;
	}
	
// --------------- FILLING FUNCTIONS ---------------
	public void MainProfileFillInfo() {
		UIProfilePlayerNameText.text = DataFillingInformation.DBPlayerName;
		UIProfileEmailText.text = DataFillingInformation.DBPlayerEmail;
		
		CoinAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
		UIProfileCoinText.text = CoinAmount.ToString("#,#");
		
		UIProfileArtAmountText.text = DataFillingInformation.DBNumberOfArtworksCollected;
		
		if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollected) < 1) {
			UIProfileRankText.text = "No Rank Yet";
		}
		
		if ((int.Parse(DataFillingInformation.DBNumberOfArtworksCollected) >= 1) && (int.Parse(DataFillingInformation.DBNumberOfArtworksCollected) < 14)) {
			UIProfileRankText.text = "Art Student";
		}
		
		if ((int.Parse(DataFillingInformation.DBNumberOfArtworksCollected) >= 15) && (int.Parse(DataFillingInformation.DBNumberOfArtworksCollected) < 29)) {
			UIProfileRankText.text = "Art Enthusiast";
		}
		
		if ((int.Parse(DataFillingInformation.DBNumberOfArtworksCollected) >= 30) && (int.Parse(DataFillingInformation.DBNumberOfArtworksCollected) < 44)) {
			UIProfileRankText.text = "Art Apprentice";
		}
		
		if ((int.Parse(DataFillingInformation.DBNumberOfArtworksCollected) >= 45) && (int.Parse(DataFillingInformation.DBNumberOfArtworksCollected) < 59)) {
			UIProfileRankText.text = "Art Patron";
		}
		
		if ((int.Parse(DataFillingInformation.DBNumberOfArtworksCollected) >= 60) && (int.Parse(DataFillingInformation.DBNumberOfArtworksCollected) < 74)) {
			UIProfileRankText.text = "Art Master";
		}
		
		if ((int.Parse(DataFillingInformation.DBNumberOfArtworksCollected) >= 75) && (int.Parse(DataFillingInformation.DBNumberOfArtworksCollected) < 89)) {
			UIProfileRankText.text = "Art Collector";
		}
		
		if ((int.Parse(DataFillingInformation.DBNumberOfArtworksCollected) >= 90)) {
			UIProfileRankText.text = "Art Historian";
		}
		
		UIProfileArtistText.text = DataFillingInformation.DBPlayerFavArtist;
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}