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

public class MainMenuEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Bank Account
	public Image UIBankAccountField;
	public Text UIBankAccountTitle;
	public Text UIBankAccountText;
    public Image UIBankAccountClickedBackground;
    public Image UIBankAccountClickedField;
    public Text UIBankAccountClickedText;
    public Text UIBankAccountClickedButton;
	
	// Ghost & Art Button
	public Image UIGhostArtButton;
	public Text UIGhostArtText;
	
	// User Profile Button
	public Image UIUserProfile;
	
	// Castle Map Button
	public Image UICastleMap;
	
	// Your Own Gallery Button
	public Image UIYourOwnGallery;
	
	// Location Texts
	public Image UICurrentSceneField;
	public Text UIFloorNameText;
	public Text UIRoomNameText;
    public Image UICurrentSceneClickedBackground;
    public Image UICurrentSceneClickedField;
    public Text UICurrentSceneClickedText;
    public Text UICurrentSceneClickedButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
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
		MainBankEnable();
		MainGhostArtEnable();
		MainOthersEnable();
		MainLocationTextEnable();
        MainBankClickedDisable();
        MainCurrentSceneClickedDisable();
        
        // Firebase Auth
		PlayerAuthentication = FirebaseAuth.DefaultInstance;
        
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            FirebaseDatabase.DefaultInstance.GetReference("ChateauObjectives").Child(FirebaseAuthentication.NewPlayer.UserId).GetValueAsync().ContinueWith(playertask => {
                if (playertask.IsCanceled || playertask.IsFaulted) {
                    
                }

                else {
                    DataSnapshot ChateauSnapshot = playertask.Result;

                    DataFillingInformation.DBAllTimeObjectiveComplete01 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete01").Value.ToString();
                }
            });
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            FirebaseDatabase.DefaultInstance.GetReference("ChateauObjectives").Child(FirebaseAuthentication.CurrentPlayer.UserId).GetValueAsync().ContinueWith(playertask => {
                if (playertask.IsCanceled || playertask.IsFaulted) {
                    
                }

                else {
                    DataSnapshot ChateauSnapshot = playertask.Result;

                    DataFillingInformation.DBAllTimeObjectiveComplete01 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete01").Value.ToString();
                }
            });
        }
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		MainLocationSwitch();
        UnlockGalleryObjective();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void MainBankEnable() {
		UIBankAccountField.enabled = true;
		UIBankAccountTitle.enabled = true;
		UIBankAccountText.enabled = true;
	}
    
    public void MainBankClickedEnable() {
        UIBankAccountClickedBackground.enabled = true;
        UIBankAccountClickedField.enabled = true;
        UIBankAccountClickedText.enabled = true;
        UIBankAccountClickedButton.enabled = true;
    }
	
	public void MainGhostArtEnable() {
		UIGhostArtButton.enabled = true;
		UIGhostArtText.enabled = true;
	}
	
	public void MainOthersEnable() {
		UIUserProfile.enabled = true;
		UICastleMap.enabled = true;
	}
	
	public void MainLocationTextEnable() {
		UICurrentSceneField.enabled = true;
		UIFloorNameText.enabled = true;
		UIRoomNameText.enabled = true;
	}
    
    public void MainCurrentSceneClickedEnable() {
        UICurrentSceneClickedBackground.enabled = true;
        UICurrentSceneClickedField.enabled = true;
        UICurrentSceneClickedText.enabled = true;
        UICurrentSceneClickedButton.enabled = true;
    }
    
    public void MainYourOwnGalleryEnable() {
        UIYourOwnGallery.enabled = true;
    }
	
// --------------- DISABLE FUNCTIONS ---------------
	public void MainBankDisable() {
		UIBankAccountField.enabled = false;
		UIBankAccountTitle.enabled = false;
		UIBankAccountText.enabled = false;
	}
    
    public void MainBankClickedDisable() {
        UIBankAccountClickedBackground.enabled = false;
        UIBankAccountClickedField.enabled = false;
        UIBankAccountClickedText.enabled = false;
        UIBankAccountClickedButton.enabled = false;
    }
	
	public void MainGhostArtDisable() {
		UIGhostArtButton.enabled = false;
		UIGhostArtText.enabled = false;
	}
	
	public void MainOthersDisable() {
		UIUserProfile.enabled = false;
		UICastleMap.enabled = false;
	}
	
	public void MainLocationTextDisable() {
		UICurrentSceneField.enabled = false;
		UIFloorNameText.enabled = false;
		UIRoomNameText.enabled = false;
	}
    
    public void MainCurrentSceneClickedDisable() {
        UICurrentSceneClickedBackground.enabled = false;
        UICurrentSceneClickedField.enabled = false;
        UICurrentSceneClickedText.enabled = false;
        UICurrentSceneClickedButton.enabled = false;
    }
    
    public void MainYourOwnGalleryDisable() {
        UIYourOwnGallery.enabled = false;
    }
	
// --------------- LOCATION FUNCTIONS ---------------
	public void MainLocationSwitch() {
		// ---------- F1
		if (SceneManager.GetActiveScene().name.Contains("05F1FoyerScene")) {
			UIFloorNameText.text = "First Floor";
			UIRoomNameText.text = "Foyer";
            UICurrentSceneClickedText.text = "Welcome to the Foyer of the Château du Voleur! There are no ghosts within the Foyer, but the scroll will aid your quest.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("06F1BilliardsRoomScene")) {
			UIFloorNameText.text = "First Floor";
			UIRoomNameText.text = "Billiards Room";
            UICurrentSceneClickedText.text = "Welcome to the Billiards Room of the Château du Voleur! Bierstadt and Donatello call this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("07F1DiningRoomScene")) {
			UIFloorNameText.text = "First Floor";
			UIRoomNameText.text = "Dining Room";
            UICurrentSceneClickedText.text = "Welcome to the Dining Room of the Château du Voleur! Da Vinci calls this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("08F1KitchenScene")) {
			UIFloorNameText.text = "First Floor";
			UIRoomNameText.text = "Kitchen";
            UICurrentSceneClickedText.text = "Welcome to the Kitchen of the Château du Voleur! Kandinsky calls this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("09F1LoungeScene")) {
			UIFloorNameText.text = "First Floor";
			UIRoomNameText.text = "Lounge";
            UICurrentSceneClickedText.text = "Welcome to the Lounge of the Château du Voleur! O'Keeffe calls this room home.";
		}
		
		// ---------- F2
		if (SceneManager.GetActiveScene().name.Contains("10F2FirstBedroomScene")) {
			UIFloorNameText.text = "Second Floor";
			UIRoomNameText.text = "First Bedroom";
            UICurrentSceneClickedText.text = "Welcome to the First Bedroom of the Château du Voleur! Dürer calls this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("11F2SecondBedroomScene")) {
			UIFloorNameText.text = "Second Floor";
			UIRoomNameText.text = "Second Bedroom";
            UICurrentSceneClickedText.text = "Welcome to the Second Bedroom of the Château du Voleur! Degas calls this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("12F2ParlorScene")) {
			UIFloorNameText.text = "Second Floor";
			UIRoomNameText.text = "Parlor";
            UICurrentSceneClickedText.text = "Welcome to the Parlor of the Château du Voleur! Pollock calls this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("13F2LibraryScene")) {
			UIFloorNameText.text = "Second Floor";
			UIRoomNameText.text = "Library";
            UICurrentSceneClickedText.text = "Welcome to the Library of the Château du Voleur! Cassatt calls this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("14F2StudioScene")) {
			UIFloorNameText.text = "Second Floor";
			UIRoomNameText.text = "Studio";
            UICurrentSceneClickedText.text = "Welcome to the Studio of the Château du Voleur! Raphael calls this room home.";
		}
        
        // ---------- F3
		if (SceneManager.GetActiveScene().name.Contains("15F3ThirdBedroomScene")) {
			UIFloorNameText.text = "Third Floor";
			UIRoomNameText.text = "Third Bedroom";
            UICurrentSceneClickedText.text = "Welcome to the Third Bedroom of the Château du Voleur! Canova calls this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("16F3FourthBedroomScene")) {
			UIFloorNameText.text = "Third Floor";
			UIRoomNameText.text = "Fourth Bedroom";
            UICurrentSceneClickedText.text = "Welcome to the Fourth Bedroom of the Château du Voleur! Manet calls this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("17F3BalconyScene")) {
			UIFloorNameText.text = "Third Floor";
			UIRoomNameText.text = "Balcony";
            UICurrentSceneClickedText.text = "Welcome to the Balcony of the Château du Voleur! Van Ruisdael and Michelangelo call this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("18F3StudyScene")) {
			UIFloorNameText.text = "Third Floor";
			UIRoomNameText.text = "Study";
            UICurrentSceneClickedText.text = "Welcome to the Study of the Château du Voleur! Lichtenstein calls this room home.";
		}
        
        // ---------- G1
		if (SceneManager.GetActiveScene().name.Contains("19G1RoseGardenScene")) {
			UIFloorNameText.text = "First Garden";
			UIRoomNameText.text = "Rose Garden";
            UICurrentSceneClickedText.text = "Welcome to the Rose Garden of the Château du Voleur! Van Hemessen and Kahlo call this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("20G1DaisyGardenScene")) {
			UIFloorNameText.text = "First Garden";
			UIRoomNameText.text = "Daisy Garden";
            UICurrentSceneClickedText.text = "Welcome to the Daisy Garden of the Château du Voleur! Botticelli calls this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("21G1LilyPondScene")) {
			UIFloorNameText.text = "First Garden";
			UIRoomNameText.text = "Lily Pond";
            UICurrentSceneClickedText.text = "Welcome to the Lily Pond of the Château du Voleur! Cézanne calls this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("22G1TulipGardenScene")) {
			UIFloorNameText.text = "First Garden";
			UIRoomNameText.text = "Tulip Garden";
            UICurrentSceneClickedText.text = "Welcome to the Tulip Garden of the Château du Voleur! Van Eyck calls this room home.";
		}
        
        // ---------- G2
		if (SceneManager.GetActiveScene().name.Contains("23G2KoiPondScene")) {
			UIFloorNameText.text = "Second Garden";
			UIRoomNameText.text = "Koi Pond";
            UICurrentSceneClickedText.text = "Welcome to the Koi Pond of the Château du Voleur! Monet calls this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("24G2HedgeMazeScene")) {
			UIFloorNameText.text = "Second Garden";
			UIRoomNameText.text = "Hedge Maze";
            UICurrentSceneClickedText.text = "Welcome to the Hedge Maze of the Château du Voleur! Braque calls this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("25G2StablesScene")) {
			UIFloorNameText.text = "Second Garden";
			UIRoomNameText.text = "Stables";
            UICurrentSceneClickedText.text = "Welcome to the Stables of the Château du Voleur! Vermeer and Rubens call this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("26G2SunflowerGardenScene")) {
			UIFloorNameText.text = "Second Garden";
			UIRoomNameText.text = "Sunflower Garden";
            UICurrentSceneClickedText.text = "Welcome to the Sunflower Garden of the Château du Voleur! Van Gogh calls this room home.";
		}
        
        // ---------- FB
		if (SceneManager.GetActiveScene().name.Contains("27FBDungeonScene")) {
			UIFloorNameText.text = "Basement";
			UIRoomNameText.text = "Dungeon";
            UICurrentSceneClickedText.text = "Welcome to the Dungeon of the Château du Voleur! Caravaggio calls this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("28FBServantsQuarterScene")) {
			UIFloorNameText.text = "Basement";
			UIRoomNameText.text = "Servant's Quarter";
            UICurrentSceneClickedText.text = "Welcome to the Servant's Quarter of the Château du Voleur! Dalí calls this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("29FBArmoryScene")) {
			UIFloorNameText.text = "Basement";
			UIRoomNameText.text = "Armory";
            UICurrentSceneClickedText.text = "Welcome to the Armory of the Château du Voleur! Munch and David call this room home.";
		}
		
		if (SceneManager.GetActiveScene().name.Contains("30FBWineCellarScene")) {
			UIFloorNameText.text = "Basement";
			UIRoomNameText.text = "Wine Cellar";
            UICurrentSceneClickedText.text = "Welcome to the Wine Cellar of the Château du Voleur! Picasso calls this room home.";
		}
        
        // ---------- Gallery
        if (SceneManager.GetActiveScene().name.Contains("41Gallery01Scene")) {
			UIFloorNameText.text = "Your Gallery";
			UIRoomNameText.text = "First Room";
            UICurrentSceneClickedText.text = "Welcome to the First Gallery Room of the Château du Voleur! You may view your collected works of art here.";
		}
        
        if (SceneManager.GetActiveScene().name.Contains("42Gallery02Scene")) {
			UIFloorNameText.text = "Your Gallery";
			UIRoomNameText.text = "Second Room";
            UICurrentSceneClickedText.text = "Welcome to the Second Gallery Room of the Château du Voleur! You may view your collected works of art here.";
		}
        
        if (SceneManager.GetActiveScene().name.Contains("43Gallery03Scene")) {
			UIFloorNameText.text = "Your Gallery";
			UIRoomNameText.text = "Third Room";
            UICurrentSceneClickedText.text = "Welcome to the Third Gallery Room of the Château du Voleur! You may view your collected works of art here.";
		}
        
        if (SceneManager.GetActiveScene().name.Contains("44Gallery04Scene")) {
			UIFloorNameText.text = "Your Gallery";
			UIRoomNameText.text = "Fourth Room";
            UICurrentSceneClickedText.text = "Welcome to the Fourth Gallery Room of the Château du Voleur! You may view your collected works of art here.";
		}
        
        if (SceneManager.GetActiveScene().name.Contains("45Gallery05Scene")) {
			UIFloorNameText.text = "Your Gallery";
			UIRoomNameText.text = "Fifth Room";
            UICurrentSceneClickedText.text = "Welcome to the Fifth Gallery Room of the Château du Voleur! You may view your collected works of art here.";
		}
        
        if (SceneManager.GetActiveScene().name.Contains("46Gallery06Scene")) {
			UIFloorNameText.text = "Your Gallery";
			UIRoomNameText.text = "Sixth Room";
            UICurrentSceneClickedText.text = "Welcome to the Sixth Gallery Room of the Château du Voleur! You may view your collected works of art here.";
		}
        
        if (SceneManager.GetActiveScene().name.Contains("47Gallery07Scene")) {
			UIFloorNameText.text = "Your Gallery";
			UIRoomNameText.text = "Seventh Room";
            UICurrentSceneClickedText.text = "Welcome to the Seventh Gallery Room of the Château du Voleur! You may view your collected works of art here.";
		}
        
        if (SceneManager.GetActiveScene().name.Contains("48Gallery08Scene")) {
			UIFloorNameText.text = "Your Gallery";
			UIRoomNameText.text = "Eighth Room";
            UICurrentSceneClickedText.text = "Welcome to the Eighth Gallery Room of the Château du Voleur! You may view your collected works of art here.";
		}
        
        if (SceneManager.GetActiveScene().name.Contains("49Gallery09Scene")) {
			UIFloorNameText.text = "Your Gallery";
			UIRoomNameText.text = "Ninth Room";
            UICurrentSceneClickedText.text = "Welcome to the Ninth Gallery Room of the Château du Voleur! You may view your collected works of art here.";
		}
        
        if (SceneManager.GetActiveScene().name.Contains("50Gallery10Scene")) {
			UIFloorNameText.text = "Your Gallery";
			UIRoomNameText.text = "Tenth Room";
            UICurrentSceneClickedText.text = "Welcome to the Tenth Gallery Room of the Château du Voleur! You may view your collected works of art here.";
		}
        
        if (SceneManager.GetActiveScene().name.Contains("51Gallery11Scene")) {
			UIFloorNameText.text = "Your Gallery";
			UIRoomNameText.text = "Eleventh Room";
            UICurrentSceneClickedText.text = "Welcome to the Eleventh Gallery Room of the Château du Voleur! You may view your collected works of art here.";
		}
        
        if (SceneManager.GetActiveScene().name.Contains("52Gallery12Scene")) {
			UIFloorNameText.text = "Your Gallery";
			UIRoomNameText.text = "Twelfth Room";
            UICurrentSceneClickedText.text = "Welcome to the Twelfth Gallery Room of the Château du Voleur! You may view your collected works of art here.";
		}
	}
    
// --------------- GALLERY UNLOCK FUNCTIONS ---------------
    public void UnlockGalleryObjective() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete01) < 2) {
            MainYourOwnGalleryDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete01) == 2) {
            MainYourOwnGalleryEnable();
        }
    }
    	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}