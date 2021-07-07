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

public class GameStoreSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    public Image UIPurchaseItemsBackground;
    public Image UIPurchaseItemsField;
    public Text UIPurchaseItemsText;
    public Text UIPurchaseItemsCloseButton;
    
    public Image UIPurchaseItemsBasementBuy;
    public Image UIPurchaseItems10KCoinsBuy;
    public Image UIPurchaseItems50KCoinsBuy;
    public Image UIPurchaseItems100KCoinsBuy;
    public Image UIPurchaseItems500KCoinsBuy;
    public Image UIPurchaseItems1MCoinsBuy;
    public Image UIPurchaseItems2MCoinsBuy;
    public Image UIPurchaseItemsF115Buy;
    public Image UIPurchaseItemsF215Buy;
    public Image UIPurchaseItemsF315Buy;
    public Image UIPurchaseItemsG115Buy;
    public Image UIPurchaseItemsG215Buy;
    public Image UIPurchaseItemsG315Buy;
    public Image UIPurchaseItemsFB15Buy;
    
    public Image UIPurchaseItemsBasementPurchased;
    public Image UIPurchaseItemsF115Purchased;
    public Image UIPurchaseItemsF215Purchased;
    public Image UIPurchaseItemsF315Purchased;
    public Image UIPurchaseItemsG115Purchased;
    public Image UIPurchaseItemsG215Purchased;
    public Image UIPurchaseItemsG315Purchased;
    public Image UIPurchaseItemsFB15Purchased;
    
    public Image UIPurchaseItemsF115Unavailable;
    public Image UIPurchaseItemsF215Unavailable;
    public Image UIPurchaseItemsF315Unavailable;
    public Image UIPurchaseItemsG115Unavailable;
    public Image UIPurchaseItemsG215Unavailable;
    public Image UIPurchaseItemsG315Unavailable;
    public Image UIPurchaseItemsFB15Unavailable;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int StoreBasementPurchased;
    public static int StoreF115Purchased;
    public static int StoreF215Purchased;
    public static int StoreF315Purchased;
    public static int StoreG115Purchased;
    public static int StoreG215Purchased;
    public static int StoreG315Purchased;
    public static int StoreFB15Purchased;
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
        // Static String Matching
        if (int.Parse(DataFillingInformation.DBBasementUnlock) == 0) {
            StoreBasementPurchased = 0;
        }
        
        if (int.Parse(DataFillingInformation.DBBasementUnlock) == 1) {
            StoreBasementPurchased = 1;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF115) == 0) {
            StoreF115Purchased = 0;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF115) >= 1) {
            StoreF115Purchased = 1;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF215) == 0) {
            StoreF215Purchased = 0;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF215) >= 1) {
            StoreF215Purchased = 1;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF315) == 0) {
            StoreF315Purchased = 0;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF315) >= 1) {
            StoreF315Purchased = 1;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG115) == 0) {
            StoreG115Purchased = 0;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG115) >= 1) {
            StoreG115Purchased = 1;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG215) == 0) {
            StoreG215Purchased = 0;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG215) >= 1) {
            StoreG215Purchased = 1;
        }
        
         if (int.Parse(DataFillingInformation.DBArtworkPurchaseG315) == 0) {
            StoreG315Purchased = 0;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG315) >= 1) {
            StoreG315Purchased = 1;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB15) == 0) {
            StoreFB15Purchased = 0;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB15) >= 1) {
            StoreFB15Purchased = 1;
        }
        
        // Showing Items
        PurchaseItemsMainEnable();
		PurchaseItems10KCoinsBuyEnable();
        PurchaseItems50KCoinsBuyEnable();
        PurchaseItems100KCoinsBuyEnable();
        PurchaseItems500KCoinsBuyEnable();
        PurchaseItems1MCoinsBuyEnable();
        PurchaseItems2MCoinsBuyEnable();
        
        // Basement & FB15
        if (StoreBasementPurchased == 0) {
            // Enabled
            PurchaseItemsFB15UnavailableEnable();
            PurchaseItemsBasementBuyEnable();
            
            // Disabled
            PurchaseItemsFB15BuyDisable();
            PurchaseItemsFB15PurchasedDisable();
            PurchaseItemsBasementPurchasedDisable();
        }
        
        if (StoreBasementPurchased == 1) {
            // Enabled
            PurchaseItemsBasementPurchasedEnable();
            
            // Disabled
            PurchaseItemsBasementBuyDisable();
            
            if (StoreFB15Purchased == 0) {
                // Enabled
                PurchaseItemsFB15BuyEnable();

                // Disabled
                PurchaseItemsFB15UnavailableDisable();
                PurchaseItemsFB15PurchasedDisable();
            }
            
            if (StoreFB15Purchased == 1) {
                // Enabled
                PurchaseItemsFB15PurchasedEnable();

                // Disabled
                PurchaseItemsFB15UnavailableDisable();
                PurchaseItemsFB15BuyDisable();
            }
        }
        
        // F115
        if (StoreF115Purchased == 0) {
            // Enabled
            PurchaseItemsF115BuyEnable();

            // Disabled
            PurchaseItemsF115UnavailableDisable();
            PurchaseItemsF115PurchasedDisable();
        }

        if (StoreF115Purchased == 1) {
            // Enabled
            PurchaseItemsF115PurchasedEnable();

            // Disabled
            PurchaseItemsF115UnavailableDisable();
            PurchaseItemsF115BuyDisable();
        }
        
        // F215
        if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 0) {
            // Enabled
            PurchaseItemsF215UnavailableEnable();
            
            // Disabled
            PurchaseItemsF215BuyDisable();
            PurchaseItemsF215PurchasedDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 1) {
            if (StoreF215Purchased == 0) {
                // Enabled
                PurchaseItemsF215BuyEnable();

                // Disabled
                PurchaseItemsF215UnavailableDisable();
                PurchaseItemsF215PurchasedDisable();
            }
            
            if (StoreF215Purchased == 1) {
                // Enabled
                PurchaseItemsF215PurchasedEnable();

                // Disabled
                PurchaseItemsF215UnavailableDisable();
                PurchaseItemsF215BuyDisable();
            }
        }
        
        // F315
        if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 0) {
            // Enabled
            PurchaseItemsF315UnavailableEnable();
            
            // Disabled
            PurchaseItemsF315BuyDisable();
            PurchaseItemsF315PurchasedDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 1) {
            if (StoreF315Purchased == 0) {
                // Enabled
                PurchaseItemsF315BuyEnable();

                // Disabled
                PurchaseItemsF315UnavailableDisable();
                PurchaseItemsF315PurchasedDisable();
            }
            
            if (StoreF315Purchased == 1) {
                // Enabled
                PurchaseItemsF315PurchasedEnable();

                // Disabled
                PurchaseItemsF315UnavailableDisable();
                PurchaseItemsF315BuyDisable();
            }
        }
        
        // G115
        if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 0) {
            // Enabled
            PurchaseItemsG115UnavailableEnable();
            
            // Disabled
            PurchaseItemsG115BuyDisable();
            PurchaseItemsG115PurchasedDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 1) {
            if (StoreG115Purchased == 0) {
                // Enabled
                PurchaseItemsG115BuyEnable();

                // Disabled
                PurchaseItemsG115UnavailableDisable();
                PurchaseItemsG115PurchasedDisable();
            }
            
            if (StoreG115Purchased == 1) {
                // Enabled
                PurchaseItemsG115PurchasedEnable();

                // Disabled
                PurchaseItemsG115UnavailableDisable();
                PurchaseItemsG115BuyDisable();
            }
        }
        
        // G215
        if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 0) {
            // Enabled
            PurchaseItemsG215UnavailableEnable();
            
            // Disabled
            PurchaseItemsG215BuyDisable();
            PurchaseItemsG215PurchasedDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 1) {
            if (StoreG215Purchased == 0) {
                // Enabled
                PurchaseItemsG215BuyEnable();

                // Disabled
                PurchaseItemsG215UnavailableDisable();
                PurchaseItemsG215PurchasedDisable();
            }
            
            if (StoreG215Purchased == 1) {
                // Enabled
                PurchaseItemsG215PurchasedEnable();

                // Disabled
                PurchaseItemsG215UnavailableDisable();
                PurchaseItemsG215BuyDisable();
            }
        }
        
        // G315
        if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 0) {
            // Enabled
            PurchaseItemsG315UnavailableEnable();
            
            // Disabled
            PurchaseItemsG315BuyDisable();
            PurchaseItemsG315PurchasedDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 1) {
            if (StoreG315Purchased == 0) {
                // Enabled
                PurchaseItemsG315BuyEnable();

                // Disabled
                PurchaseItemsG315UnavailableDisable();
                PurchaseItemsG315PurchasedDisable();
            }
            
            if (StoreG315Purchased == 1) {
                // Enabled
                PurchaseItemsG315PurchasedEnable();

                // Disabled
                PurchaseItemsG315UnavailableDisable();
                PurchaseItemsG315BuyDisable();
            }
        }
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
    public void PurchaseItemsMainEnable() {
        UIPurchaseItemsBackground.enabled = true;
        UIPurchaseItemsField.enabled = true;
        UIPurchaseItemsText.enabled = true;
        UIPurchaseItemsCloseButton.enabled = true;
    }
    
    public void PurchaseItemsBasementBuyEnable() {
        UIPurchaseItemsBasementBuy.enabled = true;
    }
    
    public void PurchaseItems10KCoinsBuyEnable() {
        UIPurchaseItems10KCoinsBuy.enabled = true;
    }
    
    public void PurchaseItems50KCoinsBuyEnable() {
        UIPurchaseItems50KCoinsBuy.enabled = true;
    }
    
    public void PurchaseItems100KCoinsBuyEnable() {
        UIPurchaseItems100KCoinsBuy.enabled = true;
    }
    
    public void PurchaseItems500KCoinsBuyEnable() {
        UIPurchaseItems500KCoinsBuy.enabled = true;
    }
    
    public void PurchaseItems1MCoinsBuyEnable() {
        UIPurchaseItems1MCoinsBuy.enabled = true;
    }
    
    public void PurchaseItems2MCoinsBuyEnable() {
        UIPurchaseItems2MCoinsBuy.enabled = true;
    }
    
    public void PurchaseItemsF115BuyEnable() {
        UIPurchaseItemsF115Buy.enabled = true;
    }
    
    public void PurchaseItemsF215BuyEnable() {
        UIPurchaseItemsF215Buy.enabled = true;
    }
    
    public void PurchaseItemsF315BuyEnable() {
        UIPurchaseItemsF315Buy.enabled = true;
    }
    
    public void PurchaseItemsG115BuyEnable() {
        UIPurchaseItemsG115Buy.enabled = true;
    }
    
    public void PurchaseItemsG215BuyEnable() {
        UIPurchaseItemsG215Buy.enabled = true;
    }
    
    public void PurchaseItemsG315BuyEnable() {
        UIPurchaseItemsG315Buy.enabled = true;
    }
    
    public void PurchaseItemsFB15BuyEnable() {
        UIPurchaseItemsFB15Buy.enabled = true;
    }
    
    public void PurchaseItemsBasementPurchasedEnable() {
        UIPurchaseItemsBasementPurchased.enabled = true;
    }
    
    public void PurchaseItemsF115PurchasedEnable() {
        UIPurchaseItemsF115Purchased.enabled = true;
    }
    
    public void PurchaseItemsF215PurchasedEnable() {
        UIPurchaseItemsF215Purchased.enabled = true;
    }
    
    public void PurchaseItemsF315PurchasedEnable() {
        UIPurchaseItemsF315Purchased.enabled = true;
    }
    
    public void PurchaseItemsG115PurchasedEnable() {
        UIPurchaseItemsG115Purchased.enabled = true;
    }
    
    public void PurchaseItemsG215PurchasedEnable() {
        UIPurchaseItemsG215Purchased.enabled = true;
    }
    
    public void PurchaseItemsG315PurchasedEnable() {
        UIPurchaseItemsG315Purchased.enabled = true;
    }
    
    public void PurchaseItemsFB15PurchasedEnable() {
        UIPurchaseItemsFB15Purchased.enabled = true;
    }
    
    public void PurchaseItemsF115UnavailableEnable() {
        UIPurchaseItemsF115Unavailable.enabled = true;
    }
    
    public void PurchaseItemsF215UnavailableEnable() {
        UIPurchaseItemsF215Unavailable.enabled = true;
    }
    
    public void PurchaseItemsF315UnavailableEnable() {
        UIPurchaseItemsF315Unavailable.enabled = true;
    }
    
    public void PurchaseItemsG115UnavailableEnable() {
        UIPurchaseItemsG115Unavailable.enabled = true;
    }
    
    public void PurchaseItemsG215UnavailableEnable() {
        UIPurchaseItemsG215Unavailable.enabled = true;
    }
    
    public void PurchaseItemsG315UnavailableEnable() {
        UIPurchaseItemsG315Unavailable.enabled = true;
    }
    
    public void PurchaseItemsFB15UnavailableEnable() {
        UIPurchaseItemsFB15Unavailable.enabled = true;
    }
    
// --------------- DISABLE FUNCTIONS ---------------
    public void PurchaseItemsMainDisable() {
        UIPurchaseItemsBackground.enabled = false;
        UIPurchaseItemsField.enabled = false;
        UIPurchaseItemsText.enabled = false;
        UIPurchaseItemsCloseButton.enabled = false;
    }
    
    public void PurchaseItemsBasementBuyDisable() {
        UIPurchaseItemsBasementBuy.enabled = false;
    }
    
    public void PurchaseItems10KCoinsBuyDisable() {
        UIPurchaseItems10KCoinsBuy.enabled = false;
    }
    
    public void PurchaseItems50KCoinsBuyDisable() {
        UIPurchaseItems50KCoinsBuy.enabled = false;
    }
    
    public void PurchaseItems100KCoinsBuyDisable() {
        UIPurchaseItems100KCoinsBuy.enabled = false;
    }
    
    public void PurchaseItems500KCoinsBuyDisable() {
        UIPurchaseItems500KCoinsBuy.enabled = false;
    }
    
    public void PurchaseItems1MCoinsBuyDisable() {
        UIPurchaseItems1MCoinsBuy.enabled = false;
    }
    
    public void PurchaseItems2MCoinsBuyDisable() {
        UIPurchaseItems2MCoinsBuy.enabled = false;
    }
    
    public void PurchaseItemsF115BuyDisable() {
        UIPurchaseItemsF115Buy.enabled = false;
    }
    
    public void PurchaseItemsF215BuyDisable() {
        UIPurchaseItemsF215Buy.enabled = false;
    }
    
    public void PurchaseItemsF315BuyDisable() {
        UIPurchaseItemsF315Buy.enabled = false;
    }
    
    public void PurchaseItemsG115BuyDisable() {
        UIPurchaseItemsG115Buy.enabled = false;
    }
    
    public void PurchaseItemsG215BuyDisable() {
        UIPurchaseItemsG215Buy.enabled = false;
    }
    
    public void PurchaseItemsG315BuyDisable() {
        UIPurchaseItemsG315Buy.enabled = false;
    }
    
    public void PurchaseItemsFB15BuyDisable() {
        UIPurchaseItemsFB15Buy.enabled = false;
    }
    
    public void PurchaseItemsBasementPurchasedDisable() {
        UIPurchaseItemsBasementPurchased.enabled = false;
    }
    
    public void PurchaseItemsF115PurchasedDisable() {
        UIPurchaseItemsF115Purchased.enabled = false;
    }
    
    public void PurchaseItemsF215PurchasedDisable() {
        UIPurchaseItemsF215Purchased.enabled = false;
    }
    
    public void PurchaseItemsF315PurchasedDisable() {
        UIPurchaseItemsF315Purchased.enabled = false;
    }
    
    public void PurchaseItemsG115PurchasedDisable() {
        UIPurchaseItemsG115Purchased.enabled = false;
    }
    
    public void PurchaseItemsG215PurchasedDisable() {
        UIPurchaseItemsG215Purchased.enabled = false;
    }
    
    public void PurchaseItemsG315PurchasedDisable() {
        UIPurchaseItemsG315Purchased.enabled = false;
    }
    
    public void PurchaseItemsFB15PurchasedDisable() {
        UIPurchaseItemsFB15Purchased.enabled = false;
    }
    
    public void PurchaseItemsF115UnavailableDisable() {
        UIPurchaseItemsF115Unavailable.enabled = false;
    }
    
    public void PurchaseItemsF215UnavailableDisable() {
        UIPurchaseItemsF215Unavailable.enabled = false;
    }
    
    public void PurchaseItemsF315UnavailableDisable() {
        UIPurchaseItemsF315Unavailable.enabled = false;
    }
    
    public void PurchaseItemsG115UnavailableDisable() {
        UIPurchaseItemsG115Unavailable.enabled = false;
    }
    
    public void PurchaseItemsG215UnavailableDisable() {
        UIPurchaseItemsG215Unavailable.enabled = false;
    }
    
    public void PurchaseItemsG315UnavailableDisable() {
        UIPurchaseItemsG315Unavailable.enabled = false;
    }
    
    public void PurchaseItemsFB15UnavailableDisable() {
        UIPurchaseItemsFB15Unavailable.enabled = false;
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}