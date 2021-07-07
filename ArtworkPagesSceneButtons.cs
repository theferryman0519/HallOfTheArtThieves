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

public class ArtworkPagesSceneButtons : MonoBehaviour {
		
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
            if (MainArtworkPageButtons.IdentifyArtworkButton == 101) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF101;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF101 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF101").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 102) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF102;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF102 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF102").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 103) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF103;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF103 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF103").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 104) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF104;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF104 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF104").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 105) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF105;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF105 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF105").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 106) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF106;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF106 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF106").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 107) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF107;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF107 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF107").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 108) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF108;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF108 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF108").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 109) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF109;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF109 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF109").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 110) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF110;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF110 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF110").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 111) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF111;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF111 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF111").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 112) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF112;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF112 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF112").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 113) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF113;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF113 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF113").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 114) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF114;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF114 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF114").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 115) {
                Scene39Loading.Scene39Load();
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 201) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF201;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF201 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF201").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 202) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF202;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF202 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF202").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 203) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF203;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF203 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF203").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 204) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF204;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF204 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF204").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 205) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF205;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF205 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF205").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 206) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF206;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF206 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF206").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 207) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF207;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF207 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF207").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 208) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF208;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF208 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF208").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 209) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF209;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF209 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF209").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 210) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF210;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF210 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF210").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 211) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF211;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF211 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF211").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 212) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF212;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF212 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF212").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 213) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF213;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF213 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF213").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 214) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF214;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF214 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF214").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 215) {
                Scene39Loading.Scene39Load();
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 301) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF301;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF301 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF301").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 302) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF302;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF302 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF302").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 303) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF303;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF303 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF303").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 304) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF304;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF304 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF304").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 305) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF305;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF305 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF305").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 306) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF306;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF306 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF306").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 307) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF307;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF307 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF307").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 308) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF308;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF308 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF308").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 309) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF309;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF309 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF309").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 310) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF310;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF310 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF310").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 311) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF311;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF311 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF311").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 312) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF312;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF312 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF312").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 313) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF313;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF313 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF313").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 314) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF314;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF314 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF314").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 315) {
                Scene39Loading.Scene39Load();
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 401) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG101;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG101 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG101").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 402) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG102;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG102 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG102").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 403) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG103;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG103 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG103").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 404) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG104;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG104 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG104").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 405) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG105;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG105 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG105").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 406) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG106;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG106 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG106").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 407) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG107;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG107 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG107").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 408) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG108;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG108 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG108").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 409) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG109;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG109 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG109").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 410) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG110;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG110 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG110").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 411) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG111;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG111 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG111").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 412) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG112;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG112 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG112").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 413) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG113;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG113 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG113").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 414) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG114;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG114 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG114").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 415) {
                Scene39Loading.Scene39Load();
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 501) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG201;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG201 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG201").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 502) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG202;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG202 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG202").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 503) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG203;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG203 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG203").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 504) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG204;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG204 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG204").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 505) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG205;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG205 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG205").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 506) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG206;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG206 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG206").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 507) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG207;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG207 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG207").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 508) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG208;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG208 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG208").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 509) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG209;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG209 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG209").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 510) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG210;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG210 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG210").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 511) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG211;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG211 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG211").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 512) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG212;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG212 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG212").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 513) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG213;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG213 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG213").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 514) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG214;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG214 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG214").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 515) {
                Scene39Loading.Scene39Load();
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 701) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG301;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG301 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG301").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 702) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG302;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG302 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG302").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 703) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG303;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG303 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG303").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 704) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG304;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG304 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG304").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 705) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG305;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG305 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG305").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 706) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG306;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG306 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG306").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 707) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG307;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG307 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG307").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 708) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG308;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG308 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG308").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 709) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG309;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG309 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG309").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 710) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG310;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG310 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG310").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 711) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG311;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG311 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG311").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 712) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG312;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG312 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG312").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 713) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG313;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG313 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG313").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 714) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG314;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG314 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG314").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 715) {
                Scene39Loading.Scene39Load();
            }
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            if (MainArtworkPageButtons.IdentifyArtworkButton == 101) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF101;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF101 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF101").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 102) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF102;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF102 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF102").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 103) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF103;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF103 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF103").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 104) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF104;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF104 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF104").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 105) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF105;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF105 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF105").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 106) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF106;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF106 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF106").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 107) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF107;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF107 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF107").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 108) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF108;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF108 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF108").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 109) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF109;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF109 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF109").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 110) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF110;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF110 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF110").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 111) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF111;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF111 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF111").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 112) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF112;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF112 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF112").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 113) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF113;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF113 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF113").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 114) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF114;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF114 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF114").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 115) {
                Scene39Loading.Scene39Load();
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 201) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF201;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF201 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF201").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 202) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF202;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF202 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF202").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 203) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF203;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF203 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF203").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 204) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF204;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF204 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF204").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 205) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF205;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF205 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF205").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 206) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF206;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF206 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF206").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 207) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF207;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF207 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF207").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 208) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF208;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF208 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF208").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 209) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF209;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF209 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF209").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 210) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF210;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF210 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF210").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 211) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF211;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF211 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF211").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 212) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF212;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF212 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF212").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 213) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF213;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF213 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF213").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 214) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF214;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF214 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF214").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 215) {
                Scene39Loading.Scene39Load();
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 301) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF301;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF301 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF301").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 302) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF302;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF302 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF302").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 303) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF303;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF303 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF303").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 304) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF304;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF304 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF304").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 305) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF305;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF305 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF305").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 306) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF306;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF306 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF306").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 307) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF307;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF307 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF307").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 308) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF308;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF308 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF308").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 309) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF309;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF309 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF309").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 310) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF310;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF310 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF310").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 311) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF311;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF311 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF311").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 312) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF312;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF312 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF312").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 313) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF313;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF313 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF313").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 314) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostF314;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseF314 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF314").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 315) {
                Scene39Loading.Scene39Load();
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 401) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG101;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG101 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG101").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 402) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG102;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG102 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG102").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 403) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG103;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG103 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG103").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 404) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG104;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG104 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG104").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 405) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG105;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG105 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG105").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 406) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG106;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG106 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG106").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 407) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG107;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG107 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG107").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 408) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG108;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG108 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG108").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 409) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG109;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG109 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG109").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 410) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG110;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG110 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG110").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 411) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG111;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG111 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG111").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 412) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG112;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG112 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG112").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 413) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG113;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG113 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG113").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 414) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG114;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG114 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG114").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 415) {
                Scene39Loading.Scene39Load();
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 501) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG201;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG201 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG201").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 502) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG202;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG202 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG202").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 503) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG203;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG203 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG203").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 504) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG204;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG204 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG204").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 505) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG205;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG205 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG205").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 506) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG206;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG206 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG206").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 507) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG207;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG207 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG207").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 508) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG208;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG208 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG208").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 509) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG209;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG209 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG209").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 510) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG210;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG210 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG210").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 511) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG211;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG211 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG211").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 512) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG212;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG212 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG212").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 513) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG213;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG213 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG213").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 514) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG214;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG214 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG214").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 515) {
                Scene39Loading.Scene39Load();
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 701) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG301;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG301 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG301").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 702) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG302;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG302 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG302").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 703) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG303;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG303 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG303").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 704) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG304;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG304 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG304").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 705) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG305;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG305 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG305").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 706) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG306;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG306 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG306").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 707) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG307;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG307 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG307").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 708) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG308;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG308 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG308").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 709) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG309;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG309 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG309").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 710) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG310;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG310 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG310").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 711) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG311;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG311 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG311").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 712) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG312;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG312 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG312").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 713) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG313;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG313 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG313").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 714) {
                ArtworkPurchaseAmount = int.Parse(DataFillingInformation.DBBankAccountAmount);
                ArtworkPurchaseAmount = ArtworkPurchaseAmount - ArtworkInformation.ArtPieceLoanCostG314;
                DataFillingInformation.DBBankAccountAmount = ArtworkPurchaseAmount.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(ArtworkPurchaseAmount);
                
                ArtworkPurchaseNumber = 1;
                DataFillingInformation.DBArtworkPurchaseG314 = ArtworkPurchaseNumber.ToString();
                FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG314").SetValueAsync(ArtworkPurchaseNumber);
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 715) {
                Scene39Loading.Scene39Load();
            }
        }
    }
    
    public void UIArtworkPagesLearnButtonClicking() {
        if (MainArtworkPageButtons.IdentifyArtworkButton == 101) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF101);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 102) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF102);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 103) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF103);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 104) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF104);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 105) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF105);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 106) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF106);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 107) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF107);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 108) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF108);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 109) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF109);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 110) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF110);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 111) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF111);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 112) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF112);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 113) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF113);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 114) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF114);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 115) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF115);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 201) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF201);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 202) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF202);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 203) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF203);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 204) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF204);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 205) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF205);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 206) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF206);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 207) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF207);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 208) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF208);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 209) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF209);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 210) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF210);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 211) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF211);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 212) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF212);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 213) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF213);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 214) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF214);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 215) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF215);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 301) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF301);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 302) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF302);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 303) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF303);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 304) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF304);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 305) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF305);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 306) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF306);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 307) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF307);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 308) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF308);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 309) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF309);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 310) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF310);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 311) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF311);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 312) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF312);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 313) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF313);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 314) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF314);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 315) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF315);
        }
       
        if (MainArtworkPageButtons.IdentifyArtworkButton == 401) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG101);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 402) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG102);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 403) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG103);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 404) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG104);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 405) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG105);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 406) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG106);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 407) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG107);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 408) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG108);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 409) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG109);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 410) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG110);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 411) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG111);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 412) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG112);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 413) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG113);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 414) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG114);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 415) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG115);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 501) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG201);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 502) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG202);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 503) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG203);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 504) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG204);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 505) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG205);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 506) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG206);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 507) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG207);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 508) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG208);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 509) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG209);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 510) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG210);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 511) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG211);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 512) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG212);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 513) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG213);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 514) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG214);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 515) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG215);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 701) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG301);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 702) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG302);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 703) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG303);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 704) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG304);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 705) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG305);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 706) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG306);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 707) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG307);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 708) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG308);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 709) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG309);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 710) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG310);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 711) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG311);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 712) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG312);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 713) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG313);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 714) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG314);
        }
        
        if (MainArtworkPageButtons.IdentifyArtworkButton == 715) {
            Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG315);
        }
    }
        
    public void UIArtworkPagesBackButtonClicking() {
        Scene36Loading.Scene36Load();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}