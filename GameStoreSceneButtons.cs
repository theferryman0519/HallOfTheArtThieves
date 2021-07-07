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

public class GameStoreSceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button UIPurchaseItemsCloseButton;
	
// --------------- PRIVATE VARIABLES ---------------
	private int PrivateStoreBank;
    private int ArtworkPurchaseNumber;
    private int FloorArtworkNumber;
    private int CurrentArtworkNumber;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	// Auth
	private FirebaseAuth PlayerAuthentication;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Playing Pausing Timers
    public PausingPlayingTimers AllTimersPausing;
    
    // Scene Load
    public SceneLoad Scene05Loading;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        // Firebase Auth
		PlayerAuthentication = FirebaseAuth.DefaultInstance;
        
        // Pause All Timers
        AllTimersPausing.AllTimersPause();
        
        // Artwork Purchase Number
        ArtworkPurchaseNumber = 0;
        
        // Close Button
		Button UIPurchaseItemsCloseButtonClick = UIPurchaseItemsCloseButton.GetComponent<Button>();
		UIPurchaseItemsCloseButtonClick.onClick.AddListener(UIPurchaseItemsCloseButtonClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		PrivateStoreBank = int.Parse(DataFillingInformation.DBBankAccountAmount);
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- BUTTON FUNCTIONS ---------------
    public void UIPurchaseItemsCloseButtonClicking() {
        Scene05Loading.Scene05Load();
    }
    
    public void UIPurchaseItemsBasementBuyClicking(UnityEngine.Purchasing.Product product) {
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            GameStoreSceneEnable.StoreBasementPurchased = 1;
            DataFillingInformation.DBBasementUnlock = 1.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBasementUnlock").SetValueAsync(GameStoreSceneEnable.StoreBasementPurchased);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            GameStoreSceneEnable.StoreBasementPurchased = 1;
            DataFillingInformation.DBBasementUnlock = 1.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBasementUnlock").SetValueAsync(GameStoreSceneEnable.StoreBasementPurchased);
        }
    }
    
    public void UIPurchaseItems10KCoinsBuyClicking(UnityEngine.Purchasing.Product product) {
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            PrivateStoreBank = PrivateStoreBank + 10000;
            DataFillingInformation.DBBankAccountAmount = PrivateStoreBank.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(PrivateStoreBank);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            PrivateStoreBank = PrivateStoreBank + 10000;
            DataFillingInformation.DBBankAccountAmount = PrivateStoreBank.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(PrivateStoreBank);
        }
    }
    
    public void UIPurchaseItems50KCoinsBuyClicking(UnityEngine.Purchasing.Product product) {
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            PrivateStoreBank = PrivateStoreBank + 50000;
            DataFillingInformation.DBBankAccountAmount = PrivateStoreBank.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(PrivateStoreBank);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            PrivateStoreBank = PrivateStoreBank + 50000;
            DataFillingInformation.DBBankAccountAmount = PrivateStoreBank.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(PrivateStoreBank);
        }
    }
    
    public void UIPurchaseItems100KCoinsBuyClicking(UnityEngine.Purchasing.Product product) {
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            PrivateStoreBank = PrivateStoreBank + 100000;
            DataFillingInformation.DBBankAccountAmount = PrivateStoreBank.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(PrivateStoreBank);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            PrivateStoreBank = PrivateStoreBank + 100000;
            DataFillingInformation.DBBankAccountAmount = PrivateStoreBank.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(PrivateStoreBank);
        }
    }
    
    public void UIPurchaseItems500KCoinsBuyClicking(UnityEngine.Purchasing.Product product) {
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            PrivateStoreBank = PrivateStoreBank + 500000;
            DataFillingInformation.DBBankAccountAmount = PrivateStoreBank.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(PrivateStoreBank);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            PrivateStoreBank = PrivateStoreBank + 500000;
            DataFillingInformation.DBBankAccountAmount = PrivateStoreBank.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(PrivateStoreBank);
        }
    }
    
    public void UIPurchaseItems1MCoinsBuyClicking(UnityEngine.Purchasing.Product product) {
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            PrivateStoreBank = PrivateStoreBank + 1000000;
            DataFillingInformation.DBBankAccountAmount = PrivateStoreBank.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(PrivateStoreBank);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            PrivateStoreBank = PrivateStoreBank + 1000000;
            DataFillingInformation.DBBankAccountAmount = PrivateStoreBank.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(PrivateStoreBank);
        }
    }
    
    public void UIPurchaseItems2MCoinsBuyClicking(UnityEngine.Purchasing.Product product) {
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            PrivateStoreBank = PrivateStoreBank + 2000000;
            DataFillingInformation.DBBankAccountAmount = PrivateStoreBank.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(PrivateStoreBank);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            PrivateStoreBank = PrivateStoreBank + 2000000;
            DataFillingInformation.DBBankAccountAmount = PrivateStoreBank.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBankAccountAmount").SetValueAsync(PrivateStoreBank);
        }
    }
    
    public void UIPurchaseItemsF115BuyClicking(UnityEngine.Purchasing.Product product) {
        GameStoreSceneEnable.StoreF115Purchased = 1;
        DataFillingInformation.DBArtworkPurchaseF115 = 1.ToString();
        
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            ArtworkPurchaseNumber = 1;
            DataFillingInformation.DBArtworkPurchaseF115 = ArtworkPurchaseNumber.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF115").SetValueAsync(ArtworkPurchaseNumber);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            ArtworkPurchaseNumber = 1;
            DataFillingInformation.DBArtworkPurchaseF115 = ArtworkPurchaseNumber.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF115").SetValueAsync(ArtworkPurchaseNumber);
        }
    }
    
    public void UIPurchaseItemsF215BuyClicking(UnityEngine.Purchasing.Product product) {
        GameStoreSceneEnable.StoreF215Purchased = 1;
        DataFillingInformation.DBArtworkPurchaseF215 = 1.ToString();
        
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            ArtworkPurchaseNumber = 1;
            DataFillingInformation.DBArtworkPurchaseF215 = ArtworkPurchaseNumber.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF215").SetValueAsync(ArtworkPurchaseNumber);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            ArtworkPurchaseNumber = 1;
            DataFillingInformation.DBArtworkPurchaseF215 = ArtworkPurchaseNumber.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF215").SetValueAsync(ArtworkPurchaseNumber);
        }
    }
    
    public void UIPurchaseItemsF315BuyClicking(UnityEngine.Purchasing.Product product) {
        GameStoreSceneEnable.StoreF315Purchased = 1;
        DataFillingInformation.DBArtworkPurchaseF315 = 1.ToString();
        
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            ArtworkPurchaseNumber = 1;
            DataFillingInformation.DBArtworkPurchaseF315 = ArtworkPurchaseNumber.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseF315").SetValueAsync(ArtworkPurchaseNumber);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            ArtworkPurchaseNumber = 1;
            DataFillingInformation.DBArtworkPurchaseF315 = ArtworkPurchaseNumber.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseF315").SetValueAsync(ArtworkPurchaseNumber);
        }
    }
    
    public void UIPurchaseItemsG115BuyClicking(UnityEngine.Purchasing.Product product) {
        GameStoreSceneEnable.StoreG115Purchased = 1;
        DataFillingInformation.DBArtworkPurchaseG115 = 1.ToString();
        
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            ArtworkPurchaseNumber = 1;
            DataFillingInformation.DBArtworkPurchaseG115 = ArtworkPurchaseNumber.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG115").SetValueAsync(ArtworkPurchaseNumber);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            ArtworkPurchaseNumber = 1;
            DataFillingInformation.DBArtworkPurchaseG115 = ArtworkPurchaseNumber.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG115").SetValueAsync(ArtworkPurchaseNumber);
        }
    }
    
    public void UIPurchaseItemsG215BuyClicking(UnityEngine.Purchasing.Product product) {
        GameStoreSceneEnable.StoreG215Purchased = 1;
        DataFillingInformation.DBArtworkPurchaseG215 = 1.ToString();
        
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            ArtworkPurchaseNumber = 1;
            DataFillingInformation.DBArtworkPurchaseG215 = ArtworkPurchaseNumber.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG215").SetValueAsync(ArtworkPurchaseNumber);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            ArtworkPurchaseNumber = 1;
            DataFillingInformation.DBArtworkPurchaseG215 = ArtworkPurchaseNumber.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG215").SetValueAsync(ArtworkPurchaseNumber);
        }
    }
    
    public void UIPurchaseItemsG315BuyClicking(UnityEngine.Purchasing.Product product) {
        GameStoreSceneEnable.StoreG315Purchased = 1;
        DataFillingInformation.DBArtworkPurchaseG315 = 1.ToString();
        
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            ArtworkPurchaseNumber = 1;
            DataFillingInformation.DBArtworkPurchaseG315 = ArtworkPurchaseNumber.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseG315").SetValueAsync(ArtworkPurchaseNumber);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            ArtworkPurchaseNumber = 1;
            DataFillingInformation.DBArtworkPurchaseG315 = ArtworkPurchaseNumber.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseG315").SetValueAsync(ArtworkPurchaseNumber);
        }
    }
    
    public void UIPurchaseItemsFB15BuyClicking(UnityEngine.Purchasing.Product product) {
        GameStoreSceneEnable.StoreFB15Purchased = 1;
        DataFillingInformation.DBArtworkPurchaseFB15 = 1.ToString();
        
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            ArtworkPurchaseNumber = 1;
            DataFillingInformation.DBArtworkPurchaseFB15 = ArtworkPurchaseNumber.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkPurchaseFB15").SetValueAsync(ArtworkPurchaseNumber);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            ArtworkPurchaseNumber = 1;
            DataFillingInformation.DBArtworkPurchaseFB15 = ArtworkPurchaseNumber.ToString();
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkPurchaseFB15").SetValueAsync(ArtworkPurchaseNumber);
        }
    }
    
    public void UIPurchaseItemsFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason) {
        Debug.Log("Purchase failed");
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}