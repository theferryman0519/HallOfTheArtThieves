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

public class ArtworkPagesSceneButtonsB : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button UIArtworkPagesPurchaseButton;
    public Button UIArtworkPagesLearnButton;
    public Button UIArtworkPagesBackButton;
	
// --------------- PRIVATE VARIABLES ---------------
	private int ArtworkPurchaseAmount;
    private int ArtworkPurchaseNumber;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	// Auth
	private FirebaseAuth PlayerAuthentication;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Load Main Artwork Page
    public SceneLoad Scene36Loading;
    public SceneLoad Scene39Loading;
    
    // Success Sound
    public SoundMusicPlaying SuccessSoundPlaying;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		Button UIArtworkPagesPurchaseButtonClick = UIArtworkPagesPurchaseButton.GetComponent<Button>();
        Button UIArtworkPagesLearnButtonClick = UIArtworkPagesLearnButton.GetComponent<Button>();
        Button UIArtworkPagesBackButtonClick = UIArtworkPagesBackButton.GetComponent<Button>();
		
		UIArtworkPagesPurchaseButtonClick.onClick.AddListener(UIArtworkPagesPurchaseButtonClicking);
        UIArtworkPagesLearnButtonClick.onClick.AddListener(UIArtworkPagesLearnButtonClicking);
        UIArtworkPagesBackButtonClick.onClick.AddListener(UIArtworkPagesBackButtonClicking);
        
        // Firebase Auth
		PlayerAuthentication = FirebaseAuth.DefaultInstance;
        
        ArtworkPurchaseNumber = 0;
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
    public void UIArtworkPagesPurchaseButtonClicking() {
        SuccessSoundPlaying.SuccessSoundPlay();
        
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            if (MainArtworkPageButtons.IdentifyArtworkButton == 601) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB01;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB01 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB01").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 602) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB02;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB02 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB02").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 603) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB03;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB03 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB03").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 604) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB04;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB04 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB04").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 605) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB05;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB05 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB05").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 606) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB06;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB06 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB06").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 607) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB07;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB07 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB07").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 608) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB08;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB08 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB08").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 609) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB09;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB09 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB09").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 610) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB10;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB10 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB10").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 611) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB11;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB11 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB11").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 612) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB12;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB12 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB12").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 613) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB13;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB13 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB13").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 614) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB14;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB14 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB14").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 615) {
                Scene39Loading.Scene39Load();
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1001) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF101Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF101Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF101Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1002) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF102Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF102Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF102Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1003) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF103Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF103Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF103Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1004) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF104Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF104Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF104Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1005) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF105Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF105Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF105Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1006) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF106Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF106Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF106Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1007) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF107Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF107Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF107Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1008) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF108Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF108Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF108Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2001) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF201Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF201Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF201Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2002) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF202Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF202Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF202Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2003) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF203Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF203Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF203Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2004) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF204Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF204Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF204Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2005) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF205Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF205Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF205Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2006) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF206Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF206Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF206Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2007) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF207Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF207Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF207Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2008) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF208Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF208Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF208Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3001) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF301Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF301Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF301Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3002) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF302Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF302Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF302Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3003) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF303Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF303Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF303Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3004) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF304Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF304Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF304Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3005) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF305Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF305Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF305Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3006) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF306Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF306Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF306Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3007) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF307Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF307Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF307Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3008) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF308Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF308Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF308Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4001) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG101Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG101Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG101Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4002) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG102Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG102Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG102Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4003) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG103Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG103Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG103Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4004) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG104Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG104Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG104Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4005) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG105Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG105Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG105Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4006) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG106Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG106Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG106Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4007) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG107Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG107Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG107Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4008) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG108Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG108Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG108Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5001) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG201Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG201Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG201Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5002) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG202Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG202Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG202Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5003) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG203Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG203Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG203Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5004) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG204Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG204Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG204Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5005) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG205Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG205Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG205Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5006) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG206Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG206Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG206Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5007) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG207Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG207Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG207Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5008) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG208Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG208Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG208Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6001) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG301Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG301Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG301Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6002) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG302Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG302Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG302Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6003) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG303Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG303Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG303Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6004) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG304Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG304Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG304Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6005) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG305Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG305Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG305Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6006) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG306Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG306Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG306Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6007) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG307Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG307Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG307Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6008) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG308Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG308Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG308Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7001) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB01Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB01Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB01Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7002) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB02Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB02Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB02Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7003) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB03Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB03Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB03Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7004) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB04Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB04Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB04Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7005) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB05Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB05Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB05Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7006) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB06Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB06Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB06Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7007) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB07Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB07Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB07Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7008) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB08Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB08Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB08Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7009) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB09Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB09Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB09Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7010) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB10Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB10Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB10Added").SetValueAsync(ArtworkPurchaseNumber);
            }
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            if (MainArtworkPageButtons.IdentifyArtworkButton == 601) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB01;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB01 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB01").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 602) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB02;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB02 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB02").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 603) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB03;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB03 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB03").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 604) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB04;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB04 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB04").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 605) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB05;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB05 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB05").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 606) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB06;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB06 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB06").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 607) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB07;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB07 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB07").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 608) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB08;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB08 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB08").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 609) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB09;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB09 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB09").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 610) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB10;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB10 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB10").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 611) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB11;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB11 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB11").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 612) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB12;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB12 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB12").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 613) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB13;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB13 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB13").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 614) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB14;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB14 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB14").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 615) {
                Scene39Loading.Scene39Load();
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1001) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF101Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF101Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF101Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1002) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF102Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF102Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF102Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1003) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF103Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF103Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF103Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1004) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF104Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF104Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF104Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1005) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF105Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF105Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF105Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1006) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF106Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF106Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF106Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1007) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF107Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF107Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF107Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1008) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF108Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF108Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF108Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2001) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF201Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF201Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF201Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2002) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF202Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF202Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF202Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2003) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF203Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF203Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF203Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2004) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF204Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF204Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF204Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2005) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF205Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF205Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF205Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2006) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF206Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF206Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF206Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2007) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF207Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF207Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF207Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2008) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF208Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF208Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF208Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3001) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF301Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF301Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF301Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3002) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF302Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF302Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF302Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3003) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF303Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF303Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF303Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3004) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF304Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF304Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF304Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3005) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF305Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF305Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF305Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3006) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF306Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF306Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF306Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3007) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF307Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF307Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF307Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3008) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF308Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF308Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF308Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4001) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG101Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG101Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG101Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4002) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG102Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG102Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG102Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4003) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG103Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG103Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG103Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4004) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG104Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG104Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG104Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4005) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG105Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG105Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG105Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4006) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG106Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG106Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG106Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4007) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG107Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG107Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG107Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4008) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG108Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG108Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG108Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5001) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG201Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG201Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG201Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5002) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG202Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG202Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG202Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5003) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG203Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG203Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG203Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5004) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG204Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG204Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG204Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5005) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG205Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG205Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG205Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5006) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG206Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG206Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG206Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5007) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG207Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG207Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG207Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5008) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG208Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG208Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG208Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6001) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG301Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG301Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG301Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6002) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG302Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG302Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG302Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6003) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG303Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG303Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG303Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6004) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG304Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG304Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG304Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6005) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG305Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG305Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG305Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6006) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG306Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG306Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG306Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6007) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG307Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG307Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG307Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6008) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG308Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG308Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG308Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7001) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB01Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB01Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB01Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7002) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB02Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB02Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB02Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7003) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB03Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB03Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB03Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7004) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB04Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB04Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB04Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7005) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB05Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB05Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB05Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7006) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB06Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB06Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB06Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7007) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB07Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB07Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB07Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7008) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB08Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB08Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB08Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7009) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB09Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB09Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB09Added").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7010) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostFB10Added;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseFB10Added = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB10Added").SetValueAsync(ArtworkPurchaseNumber);
            }
        }
    }
    
    public void UIArtworkPagesLearnButtonClicking() {
        if (MainArtworkPageButtons.IdentifyArtworkButton == 601) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB01);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 602) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB02);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 603) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB03);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 604) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB04);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 605) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB05);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 606) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB06);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 607) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB07);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 608) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB08);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 609) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB09);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 610) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB10);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 611) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB11);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 612) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB12);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 613) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB13);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 614) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB14);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 615) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB15);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 1001) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF101Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 1002) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF102Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 1003) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF103Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 1004) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF104Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 1005) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF105Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 1006) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF106Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 1007) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF107Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 1008) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF108Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 2001) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF201Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 2002) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF202Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 2003) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF203Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 2004) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF204Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 2005) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF205Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 2006) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF206Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 2007) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF207Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 2008) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF208Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 3001) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF301Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 3002) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF302Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 3003) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF303Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 3004) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF304Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 3005) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF305Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 3006) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF306Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 3007) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF307Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 3008) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF308Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 4001) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG101Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 4002) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG102Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 4003) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG103Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 4004) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG104Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 4005) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG105Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 4006) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG106Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 4007) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG107Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 4008) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG108Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 5001) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG201Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 5002) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG202Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 5003) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG203Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 5004) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG204Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 5005) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG205Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 5006) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG206Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 5007) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG207Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 5008) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG208Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 6001) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG301Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 6002) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG302Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 6003) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG303Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 6004) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG304Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 6005) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG305Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 6006) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG306Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 6007) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG307Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 6008) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG308Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 7001) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB01Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 7002) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB02Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 7003) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB03Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 7004) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB04Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 7005) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB05Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 7006) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB06Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 7007) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB07Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 7008) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB08Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 7009) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB09Added);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 7010) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB10Added);
        }
    }
        
    public void UIArtworkPagesBackButtonClicking() {
        Scene36Loading.Scene36Load();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}