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

public class MainArtworkPageEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// UI Opening Artworks
	public Image UIOpeningArtworksBackground;
	public Image UIOpeningArtworksField;
	public Text UIOpeningArtworksText;
	public Text UIOpeningArtworksCloseButton;
	public Image UIOpeningArtworksF1Off;
	public Image UIOpeningArtworksF2Off;
	public Image UIOpeningArtworksF3Off;
	public Image UIOpeningArtworksG1Off;
	public Image UIOpeningArtworksG2Off;
    public Image UIOpeningArtworksG3Off;
	public Image UIOpeningArtworksFBOff;
	public Image UIOpeningArtworksF2Mute;
	public Image UIOpeningArtworksF3Mute;
	public Image UIOpeningArtworksG1Mute;
	public Image UIOpeningArtworksG2Mute;
    public Image UIOpeningArtworksG3Mute;
	public Image UIOpeningArtworksFBMute;
    public Text UIOpeningArtworksCollectTextF1;
    public Text UIOpeningArtworksCollectTextF2;
    public Text UIOpeningArtworksCollectTextF3;
    public Text UIOpeningArtworksCollectTextG1;
    public Text UIOpeningArtworksCollectTextG2;
    public Text UIOpeningArtworksCollectTextG3;
    public Text UIOpeningArtworksCollectTextFB;
	
	// UI Artworks F1
	public Image UIArtworksF1Background;
	public Text UIArtworksF1Text;
	public Text UIArtworksF1CloseButton;
	public Image UIArtworksF1F1On;
	public Image UIArtworksF1F2Off;
	public Image UIArtworksF1F3Off;
	public Image UIArtworksF1G1Off;
	public Image UIArtworksF1G2Off;
    public Image UIArtworksF1G3Off;
	public Image UIArtworksF1FBOff;
	public Image UIArtworksF1F2Mute;
	public Image UIArtworksF1F3Mute;
	public Image UIArtworksF1G1Mute;
	public Image UIArtworksF1G2Mute;
    public Image UIArtworksF1G3Mute;
	public Image UIArtworksF1FBMute;
	public Image UIArtworksButtonF101;
	public Text UIArtworksButtonF101Text;
	public Image UIArtworksButtonF102;
	public Text UIArtworksButtonF102Text;
	public Image UIArtworksButtonF103;
	public Text UIArtworksButtonF103Text;
	public Image UIArtworksButtonF104;
	public Text UIArtworksButtonF104Text;
	public Image UIArtworksButtonF105;
	public Text UIArtworksButtonF105Text;
	public Image UIArtworksButtonF106;
	public Text UIArtworksButtonF106Text;
	public Image UIArtworksButtonF107;
	public Text UIArtworksButtonF107Text;
	public Image UIArtworksButtonF108;
	public Text UIArtworksButtonF108Text;
	public Image UIArtworksButtonF109;
	public Text UIArtworksButtonF109Text;
	public Image UIArtworksButtonF110;
	public Text UIArtworksButtonF110Text;
	public Image UIArtworksButtonF111;
	public Text UIArtworksButtonF111Text;
	public Image UIArtworksButtonF112;
	public Text UIArtworksButtonF112Text;
	public Image UIArtworksButtonF113;
	public Text UIArtworksButtonF113Text;
	public Image UIArtworksButtonF114;
	public Text UIArtworksButtonF114Text;
	public Image UIArtworksButtonF115;
	public Text UIArtworksButtonF115Text;
	
	// UI Artworks F2
	public Image UIArtworksF2Background;
	public Text UIArtworksF2Text;
	public Text UIArtworksF2CloseButton;
	public Image UIArtworksF2F2On;
	public Image UIArtworksF2F1Off;
	public Image UIArtworksF2F3Off;
	public Image UIArtworksF2G1Off;
	public Image UIArtworksF2G2Off;
    public Image UIArtworksF2G3Off;
	public Image UIArtworksF2FBOff;
	public Image UIArtworksF2F3Mute;
	public Image UIArtworksF2G1Mute;
	public Image UIArtworksF2G2Mute;
    public Image UIArtworksF2G3Mute;
	public Image UIArtworksF2FBMute;
	public Image UIArtworksButtonF201;
	public Text UIArtworksButtonF201Text;
	public Image UIArtworksButtonF202;
	public Text UIArtworksButtonF202Text;
	public Image UIArtworksButtonF203;
	public Text UIArtworksButtonF203Text;
	public Image UIArtworksButtonF204;
	public Text UIArtworksButtonF204Text;
	public Image UIArtworksButtonF205;
	public Text UIArtworksButtonF205Text;
	public Image UIArtworksButtonF206;
	public Text UIArtworksButtonF206Text;
	public Image UIArtworksButtonF207;
	public Text UIArtworksButtonF207Text;
	public Image UIArtworksButtonF208;
	public Text UIArtworksButtonF208Text;
	public Image UIArtworksButtonF209;
	public Text UIArtworksButtonF209Text;
	public Image UIArtworksButtonF210;
	public Text UIArtworksButtonF210Text;
	public Image UIArtworksButtonF211;
	public Text UIArtworksButtonF211Text;
	public Image UIArtworksButtonF212;
	public Text UIArtworksButtonF212Text;
	public Image UIArtworksButtonF213;
	public Text UIArtworksButtonF213Text;
	public Image UIArtworksButtonF214;
	public Text UIArtworksButtonF214Text;
	public Image UIArtworksButtonF215;
	public Text UIArtworksButtonF215Text;
	
	// UI Artworks F3
	public Image UIArtworksF3Background;
	public Text UIArtworksF3Text;
	public Text UIArtworksF3CloseButton;
	public Image UIArtworksF3F3On;
	public Image UIArtworksF3F1Off;
	public Image UIArtworksF3F2Off;
	public Image UIArtworksF3G1Off;
	public Image UIArtworksF3G2Off;
    public Image UIArtworksF3G3Off;
	public Image UIArtworksF3FBOff;
	public Image UIArtworksF3F2Mute;
	public Image UIArtworksF3G1Mute;
	public Image UIArtworksF3G2Mute;
    public Image UIArtworksF3G3Mute;
	public Image UIArtworksF3FBMute;
	public Image UIArtworksButtonF301;
	public Text UIArtworksButtonF301Text;
	public Image UIArtworksButtonF302;
	public Text UIArtworksButtonF302Text;
	public Image UIArtworksButtonF303;
	public Text UIArtworksButtonF303Text;
	public Image UIArtworksButtonF304;
	public Text UIArtworksButtonF304Text;
	public Image UIArtworksButtonF305;
	public Text UIArtworksButtonF305Text;
	public Image UIArtworksButtonF306;
	public Text UIArtworksButtonF306Text;
	public Image UIArtworksButtonF307;
	public Text UIArtworksButtonF307Text;
	public Image UIArtworksButtonF308;
	public Text UIArtworksButtonF308Text;
	public Image UIArtworksButtonF309;
	public Text UIArtworksButtonF309Text;
	public Image UIArtworksButtonF310;
	public Text UIArtworksButtonF310Text;
	public Image UIArtworksButtonF311;
	public Text UIArtworksButtonF311Text;
	public Image UIArtworksButtonF312;
	public Text UIArtworksButtonF312Text;
	public Image UIArtworksButtonF313;
	public Text UIArtworksButtonF313Text;
	public Image UIArtworksButtonF314;
	public Text UIArtworksButtonF314Text;
	public Image UIArtworksButtonF315;
	public Text UIArtworksButtonF315Text;
	
	// UI Artworks G1
	public Image UIArtworksG1Background;
	public Text UIArtworksG1Text;
	public Text UIArtworksG1CloseButton;
	public Image UIArtworksG1G1On;
	public Image UIArtworksG1F1Off;
	public Image UIArtworksG1F2Off;
	public Image UIArtworksG1F3Off;
	public Image UIArtworksG1G2Off;
    public Image UIArtworksG1G3Off;
	public Image UIArtworksG1FBOff;
	public Image UIArtworksG1F2Mute;
	public Image UIArtworksG1F3Mute;
	public Image UIArtworksG1G2Mute;
    public Image UIArtworksG1G3Mute;
	public Image UIArtworksG1FBMute;
	public Image UIArtworksButtonG101;
	public Text UIArtworksButtonG101Text;
	public Image UIArtworksButtonG102;
	public Text UIArtworksButtonG102Text;
	public Image UIArtworksButtonG103;
	public Text UIArtworksButtonG103Text;
	public Image UIArtworksButtonG104;
	public Text UIArtworksButtonG104Text;
	public Image UIArtworksButtonG105;
	public Text UIArtworksButtonG105Text;
	public Image UIArtworksButtonG106;
	public Text UIArtworksButtonG106Text;
	public Image UIArtworksButtonG107;
	public Text UIArtworksButtonG107Text;
	public Image UIArtworksButtonG108;
	public Text UIArtworksButtonG108Text;
	public Image UIArtworksButtonG109;
	public Text UIArtworksButtonG109Text;
	public Image UIArtworksButtonG110;
	public Text UIArtworksButtonG110Text;
	public Image UIArtworksButtonG111;
	public Text UIArtworksButtonG111Text;
	public Image UIArtworksButtonG112;
	public Text UIArtworksButtonG112Text;
	public Image UIArtworksButtonG113;
	public Text UIArtworksButtonG113Text;
	public Image UIArtworksButtonG114;
	public Text UIArtworksButtonG114Text;
	public Image UIArtworksButtonG115;
	public Text UIArtworksButtonG115Text;
	
	// UI Artworks G2
	public Image UIArtworksG2Background;
	public Text UIArtworksG2Text;
	public Text UIArtworksG2CloseButton;
	public Image UIArtworksG2G2On;
	public Image UIArtworksG2F1Off;
	public Image UIArtworksG2F2Off;
	public Image UIArtworksG2F3Off;
	public Image UIArtworksG2G1Off;
    public Image UIArtworksG2G3Off;
	public Image UIArtworksG2FBOff;
	public Image UIArtworksG2F2Mute;
	public Image UIArtworksG2F3Mute;
	public Image UIArtworksG2G1Mute;
    public Image UIArtworksG2G3Mute;
	public Image UIArtworksG2FBMute;
	public Image UIArtworksButtonG201;
	public Text UIArtworksButtonG201Text;
	public Image UIArtworksButtonG202;
	public Text UIArtworksButtonG202Text;
	public Image UIArtworksButtonG203;
	public Text UIArtworksButtonG203Text;
	public Image UIArtworksButtonG204;
	public Text UIArtworksButtonG204Text;
	public Image UIArtworksButtonG205;
	public Text UIArtworksButtonG205Text;
	public Image UIArtworksButtonG206;
	public Text UIArtworksButtonG206Text;
	public Image UIArtworksButtonG207;
	public Text UIArtworksButtonG207Text;
	public Image UIArtworksButtonG208;
	public Text UIArtworksButtonG208Text;
	public Image UIArtworksButtonG209;
	public Text UIArtworksButtonG209Text;
	public Image UIArtworksButtonG210;
	public Text UIArtworksButtonG210Text;
	public Image UIArtworksButtonG211;
	public Text UIArtworksButtonG211Text;
	public Image UIArtworksButtonG212;
	public Text UIArtworksButtonG212Text;
	public Image UIArtworksButtonG213;
	public Text UIArtworksButtonG213Text;
	public Image UIArtworksButtonG214;
	public Text UIArtworksButtonG214Text;
	public Image UIArtworksButtonG215;
	public Text UIArtworksButtonG215Text;
    
    // UI Artworks G3
	public Image UIArtworksG3Background;
	public Text UIArtworksG3Text;
	public Text UIArtworksG3CloseButton;
	public Image UIArtworksG3G3On;
	public Image UIArtworksG3F1Off;
	public Image UIArtworksG3F2Off;
	public Image UIArtworksG3F3Off;
	public Image UIArtworksG3G1Off;
    public Image UIArtworksG3G2Off;
	public Image UIArtworksG3FBOff;
	public Image UIArtworksG3F2Mute;
	public Image UIArtworksG3F3Mute;
	public Image UIArtworksG3G1Mute;
    public Image UIArtworksG3G2Mute;
	public Image UIArtworksG3FBMute;
	public Image UIArtworksButtonG301;
	public Text UIArtworksButtonG301Text;
	public Image UIArtworksButtonG302;
	public Text UIArtworksButtonG302Text;
	public Image UIArtworksButtonG303;
	public Text UIArtworksButtonG303Text;
	public Image UIArtworksButtonG304;
	public Text UIArtworksButtonG304Text;
	public Image UIArtworksButtonG305;
	public Text UIArtworksButtonG305Text;
	public Image UIArtworksButtonG306;
	public Text UIArtworksButtonG306Text;
	public Image UIArtworksButtonG307;
	public Text UIArtworksButtonG307Text;
	public Image UIArtworksButtonG308;
	public Text UIArtworksButtonG308Text;
	public Image UIArtworksButtonG309;
	public Text UIArtworksButtonG309Text;
	public Image UIArtworksButtonG310;
	public Text UIArtworksButtonG310Text;
	public Image UIArtworksButtonG311;
	public Text UIArtworksButtonG311Text;
	public Image UIArtworksButtonG312;
	public Text UIArtworksButtonG312Text;
	public Image UIArtworksButtonG313;
	public Text UIArtworksButtonG313Text;
	public Image UIArtworksButtonG314;
	public Text UIArtworksButtonG314Text;
	public Image UIArtworksButtonG315;
	public Text UIArtworksButtonG315Text;
	
	// UI Artworks FB
	public Image UIArtworksFBBackground;
	public Text UIArtworksFBText;
	public Text UIArtworksFBCloseButton;
	public Image UIArtworksFBFBOn;
	public Image UIArtworksFBF1Off;
	public Image UIArtworksFBF2Off;
	public Image UIArtworksFBF3Off;
	public Image UIArtworksFBG1Off;
	public Image UIArtworksFBG2Off;
    public Image UIArtworksFBG3Off;
	public Image UIArtworksFBF2Mute;
	public Image UIArtworksFBF3Mute;
	public Image UIArtworksFBG1Mute;
	public Image UIArtworksFBG2Mute;
    public Image UIArtworksFBG3Mute;
	public Image UIArtworksButtonFB01;
	public Text UIArtworksButtonFB01Text;
	public Image UIArtworksButtonFB02;
	public Text UIArtworksButtonFB02Text;
	public Image UIArtworksButtonFB03;
	public Text UIArtworksButtonFB03Text;
	public Image UIArtworksButtonFB04;
	public Text UIArtworksButtonFB04Text;
	public Image UIArtworksButtonFB05;
	public Text UIArtworksButtonFB05Text;
	public Image UIArtworksButtonFB06;
	public Text UIArtworksButtonFB06Text;
	public Image UIArtworksButtonFB07;
	public Text UIArtworksButtonFB07Text;
	public Image UIArtworksButtonFB08;
	public Text UIArtworksButtonFB08Text;
	public Image UIArtworksButtonFB09;
	public Text UIArtworksButtonFB09Text;
	public Image UIArtworksButtonFB10;
	public Text UIArtworksButtonFB10Text;
	public Image UIArtworksButtonFB11;
	public Text UIArtworksButtonFB11Text;
	public Image UIArtworksButtonFB12;
	public Text UIArtworksButtonFB12Text;
	public Image UIArtworksButtonFB13;
	public Text UIArtworksButtonFB13Text;
	public Image UIArtworksButtonFB14;
	public Text UIArtworksButtonFB14Text;
	public Image UIArtworksButtonFB15;
	public Text UIArtworksButtonFB15Text;
    
    // Bonus Texts
    public Text UIArtworksF1BonusText;
    public Text UIArtworksF2BonusText;
    public Text UIArtworksF3BonusText;
    public Text UIArtworksG1BonusText;
    public Text UIArtworksG2BonusText;
    public Text UIArtworksG3BonusText;
    public Text UIArtworksFBBonusText;
	
// --------------- PRIVATE VARIABLES ---------------
	private Color ArtworkBoughtColorOff;
    private Color ArtworkBoughtColorOn;
    
    private int FloorArtworkNumberF1;
    private int FloorArtworkNumberF2;
    private int FloorArtworkNumberF3;
    private int FloorArtworkNumberG1;
    private int FloorArtworkNumberG2;
    private int FloorArtworkNumberG3;
    private int FloorArtworkNumberFB;
	
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
        
        ArtworkBoughtColorOff = new Color(0.15f, 0.36f, 0.45f, 1.0f);
        ArtworkBoughtColorOn = new Color(0.01f, 0.73f, 0.91f, 1.0f);
        
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).GetValueAsync().ContinueWith(playertask => {
                if (playertask.IsCanceled || playertask.IsFaulted) {
                    
                }

                else {
                    DataSnapshot ChateauSnapshot = playertask.Result;

                    DataFillingInformation.DBSecondFloorUnlock = ChateauSnapshot.Child("DBSecondFloorUnlock").Value.ToString();
                    DataFillingInformation.DBThirdFloorUnlock = ChateauSnapshot.Child("DBThirdFloorUnlock").Value.ToString();
                    DataFillingInformation.DBFirstGardenUnlock = ChateauSnapshot.Child("DBFirstGardenUnlock").Value.ToString();
                    DataFillingInformation.DBSecondGardenUnlock = ChateauSnapshot.Child("DBSecondGardenUnlock").Value.ToString();
                    DataFillingInformation.DBThirdGardenUnlock = ChateauSnapshot.Child("DBThirdGardenUnlock").Value.ToString();
                    DataFillingInformation.DBBasementUnlock = ChateauSnapshot.Child("DBBasementUnlock").Value.ToString();
                    
                    DataFillingInformation.DBNumberOfArtworksCollectedF1 = ChateauSnapshot.Child("DBNumberOfArtworksCollectedF1").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedF2 = ChateauSnapshot.Child("DBNumberOfArtworksCollectedF2").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedF3 = ChateauSnapshot.Child("DBNumberOfArtworksCollectedF3").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedG1 = ChateauSnapshot.Child("DBNumberOfArtworksCollectedG1").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedG2 = ChateauSnapshot.Child("DBNumberOfArtworksCollectedG2").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedG3 = ChateauSnapshot.Child("DBNumberOfArtworksCollectedG3").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedFB = ChateauSnapshot.Child("DBNumberOfArtworksCollectedFB").Value.ToString();
                }
            });
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).GetValueAsync().ContinueWith(playertask => {
                if (playertask.IsCanceled || playertask.IsFaulted) {
                    
                }

                else {
                    DataSnapshot ChateauSnapshot = playertask.Result;

                    DataFillingInformation.DBSecondFloorUnlock = ChateauSnapshot.Child("DBSecondFloorUnlock").Value.ToString();
                    DataFillingInformation.DBThirdFloorUnlock = ChateauSnapshot.Child("DBThirdFloorUnlock").Value.ToString();
                    DataFillingInformation.DBFirstGardenUnlock = ChateauSnapshot.Child("DBFirstGardenUnlock").Value.ToString();
                    DataFillingInformation.DBSecondGardenUnlock = ChateauSnapshot.Child("DBSecondGardenUnlock").Value.ToString();
                    DataFillingInformation.DBThirdGardenUnlock = ChateauSnapshot.Child("DBThirdGardenUnlock").Value.ToString();
                    DataFillingInformation.DBBasementUnlock = ChateauSnapshot.Child("DBBasementUnlock").Value.ToString();
                    
                    DataFillingInformation.DBNumberOfArtworksCollectedF1 = ChateauSnapshot.Child("DBNumberOfArtworksCollectedF1").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedF2 = ChateauSnapshot.Child("DBNumberOfArtworksCollectedF2").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedF3 = ChateauSnapshot.Child("DBNumberOfArtworksCollectedF3").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedG1 = ChateauSnapshot.Child("DBNumberOfArtworksCollectedG1").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedG2 = ChateauSnapshot.Child("DBNumberOfArtworksCollectedG2").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedG3 = ChateauSnapshot.Child("DBNumberOfArtworksCollectedG3").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedFB = ChateauSnapshot.Child("DBNumberOfArtworksCollectedFB").Value.ToString();
                }
            });
        }
        
		OpeningArtworksEnable();
		ArtworksPageF1Disable();
		ArtworksPageF2Disable();
		ArtworksPageF3Disable();
		ArtworksPageG1Disable();
		ArtworksPageG2Disable();
        ArtworksPageG3Disable();
		ArtworksPageFBDisable();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
        OpenArtworksSecondaryFloorsEnable();
        OpenArtworksSecondaryFloorsF1Enable();
        OpenArtworksSecondaryFloorsF2Enable();
        OpenArtworksSecondaryFloorsF3Enable();
        OpenArtworksSecondaryFloorsG1Enable();
        OpenArtworksSecondaryFloorsG2Enable();
        OpenArtworksSecondaryFloorsG3Enable();
        OpenArtworksSecondaryFloorsFBEnable();
        BoughtButtonsColor();
        
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF1) <= 15) {
            UIOpeningArtworksCollectTextF1.text = DataFillingInformation.DBNumberOfArtworksCollectedF1 + " out of 15" + "\n" + "Artworks Collected";
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF1) > 15) {
            UIOpeningArtworksCollectTextF1.text = DataFillingInformation.DBNumberOfArtworksCollectedF1 + " out of 23" + "\n" + "Artworks Collected";
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF2) <= 15) {
            UIOpeningArtworksCollectTextF2.text = DataFillingInformation.DBNumberOfArtworksCollectedF2 + " out of 15" + "\n" + "Artworks Collected";
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF2) > 15) {
            UIOpeningArtworksCollectTextF2.text = DataFillingInformation.DBNumberOfArtworksCollectedF2 + " out of 23" + "\n" + "Artworks Collected";
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF3) <= 15) {
            UIOpeningArtworksCollectTextF3.text = DataFillingInformation.DBNumberOfArtworksCollectedF3 + " out of 15" + "\n" + "Artworks Collected";
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF3) > 15) {
            UIOpeningArtworksCollectTextF3.text = DataFillingInformation.DBNumberOfArtworksCollectedF3 + " out of 23" + "\n" + "Artworks Collected";
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG1) <= 15) {
            UIOpeningArtworksCollectTextG1.text = DataFillingInformation.DBNumberOfArtworksCollectedG1 + " out of 15" + "\n" + "Artworks Collected";
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG1) > 15) {
            UIOpeningArtworksCollectTextG1.text = DataFillingInformation.DBNumberOfArtworksCollectedG1 + " out of 23" + "\n" + "Artworks Collected";
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG2) <= 15) {
            UIOpeningArtworksCollectTextG2.text = DataFillingInformation.DBNumberOfArtworksCollectedG2 + " out of 15" + "\n" + "Artworks Collected";
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG2) > 15) {
            UIOpeningArtworksCollectTextG2.text = DataFillingInformation.DBNumberOfArtworksCollectedG2 + " out of 23" + "\n" + "Artworks Collected";
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG3) <= 15) {
            UIOpeningArtworksCollectTextG3.text = DataFillingInformation.DBNumberOfArtworksCollectedG3 + " out of 15" + "\n" + "Artworks Collected";
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG3) > 15) {
            UIOpeningArtworksCollectTextG3.text = DataFillingInformation.DBNumberOfArtworksCollectedG3 + " out of 23" + "\n" + "Artworks Collected";
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedFB) <= 15) {
            UIOpeningArtworksCollectTextFB.text = DataFillingInformation.DBNumberOfArtworksCollectedFB + " out of 15" + "\n" + "Artworks Collected";
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedFB) > 15) {
            UIOpeningArtworksCollectTextFB.text = DataFillingInformation.DBNumberOfArtworksCollectedFB + " out of 25" + "\n" + "Artworks Collected";
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF1) > 23) {
            FloorArtworkNumberF1 = 23;
            DataFillingInformation.DBNumberOfArtworksCollectedF1 = FloorArtworkNumberF1.ToString();
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF2) > 23) {
            FloorArtworkNumberF2 = 23;
            DataFillingInformation.DBNumberOfArtworksCollectedF2 = FloorArtworkNumberF2.ToString();
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF3) > 23) {
            FloorArtworkNumberF3 = 23;
            DataFillingInformation.DBNumberOfArtworksCollectedF3 = FloorArtworkNumberF3.ToString();
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG1) > 23) {
            FloorArtworkNumberG1 = 23;
            DataFillingInformation.DBNumberOfArtworksCollectedG1 = FloorArtworkNumberG1.ToString();
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG2) > 23) {
            FloorArtworkNumberG2 = 23;
            DataFillingInformation.DBNumberOfArtworksCollectedG2 = FloorArtworkNumberG2.ToString();
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG3) > 23) {
            FloorArtworkNumberG3 = 23;
            DataFillingInformation.DBNumberOfArtworksCollectedG3 = FloorArtworkNumberG3.ToString();
        }
        
        if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedFB) > 25) {
            FloorArtworkNumberFB = 25;
            DataFillingInformation.DBNumberOfArtworksCollectedFB = FloorArtworkNumberFB.ToString();
        }
        
        F1BonusArtworkUnlock();
        F2BonusArtworkUnlock();
        F3BonusArtworkUnlock();
        G1BonusArtworkUnlock();
        G2BonusArtworkUnlock();
        G3BonusArtworkUnlock();
        FBBonusArtworkUnlock();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTION ---------------
	public void OpeningArtworksEnable() {
		UIOpeningArtworksBackground.enabled = true;
		UIOpeningArtworksField.enabled = true;
		UIOpeningArtworksText.enabled = true;
		UIOpeningArtworksCloseButton.enabled = true;
		UIOpeningArtworksF1Off.enabled = true;
        UIOpeningArtworksCollectTextF1.enabled = true;
        UIOpeningArtworksCollectTextF2.enabled = true;
        UIOpeningArtworksCollectTextF3.enabled = true;
        UIOpeningArtworksCollectTextG1.enabled = true;
        UIOpeningArtworksCollectTextG2.enabled = true;
        UIOpeningArtworksCollectTextG3.enabled = true;
        UIOpeningArtworksCollectTextFB.enabled = true;
    }
    
    public void OpenArtworksSecondaryFloorsEnable() {
        if (UIOpeningArtworksBackground.enabled == true) {
            if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 0) {
                UIOpeningArtworksF2Mute.enabled = true;
                UIOpeningArtworksF2Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 1) {
                UIOpeningArtworksF2Mute.enabled = false;
                UIOpeningArtworksF2Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 0) {
                UIOpeningArtworksF3Mute.enabled = true;
                UIOpeningArtworksF3Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 1) {
                UIOpeningArtworksF3Mute.enabled = false;
                UIOpeningArtworksF3Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 0) {
                UIOpeningArtworksG1Mute.enabled = true;
                UIOpeningArtworksG1Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 1) {
                UIOpeningArtworksG1Mute.enabled = false;
                UIOpeningArtworksG1Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 0) {
                UIOpeningArtworksG2Mute.enabled = true;
                UIOpeningArtworksG2Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 1) {
                UIOpeningArtworksG2Mute.enabled = false;
                UIOpeningArtworksG2Off.enabled = true;
            }
            
            if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 0) {
                UIOpeningArtworksG3Mute.enabled = true;
                UIOpeningArtworksG3Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 1) {
                UIOpeningArtworksG3Mute.enabled = false;
                UIOpeningArtworksG3Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBBasementUnlock) == 0) {
                UIOpeningArtworksFBMute.enabled = true;
                UIOpeningArtworksFBOff.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBBasementUnlock) == 1) {
                UIOpeningArtworksFBMute.enabled = false;
                UIOpeningArtworksFBOff.enabled = true;
            }
        }
        
        if (UIOpeningArtworksBackground.enabled == false) {
            UIOpeningArtworksF2Mute.enabled = false;
            UIOpeningArtworksF2Off.enabled = false;
            UIOpeningArtworksF3Mute.enabled = false;
            UIOpeningArtworksF3Off.enabled = false;
            UIOpeningArtworksG1Mute.enabled = false;
            UIOpeningArtworksG1Off.enabled = false;
            UIOpeningArtworksG2Mute.enabled = false;
            UIOpeningArtworksG2Off.enabled = false;
            UIOpeningArtworksG3Mute.enabled = false;
            UIOpeningArtworksG3Off.enabled = false;
            UIOpeningArtworksFBMute.enabled = false;
            UIOpeningArtworksFBOff.enabled = false;
        }
	}
    
    public void OpenArtworksSecondaryFloorsF1Enable() {
        if (UIArtworksF1Background.enabled == true) {
            if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 0) {
                UIArtworksF1F2Mute.enabled = true;
                UIArtworksF1F2Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 1) {
                UIArtworksF1F2Mute.enabled = false;
                UIArtworksF1F2Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 0) {
                UIArtworksF1F3Mute.enabled = true;
                UIArtworksF1F3Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 1) {
                UIArtworksF1F3Mute.enabled = false;
                UIArtworksF1F3Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 0) {
                UIArtworksF1G1Mute.enabled = true;
                UIArtworksF1G1Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 1) {
                UIArtworksF1G1Mute.enabled = false;
                UIArtworksF1G1Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 0) {
                UIArtworksF1G2Mute.enabled = true;
                UIArtworksF1G2Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 1) {
                UIArtworksF1G2Mute.enabled = false;
                UIArtworksF1G2Off.enabled = true;
            }
            
            if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 0) {
                UIArtworksF1G3Mute.enabled = true;
                UIArtworksF1G3Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 1) {
                UIArtworksF1G3Mute.enabled = false;
                UIArtworksF1G3Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBBasementUnlock) == 0) {
                UIArtworksF1FBMute.enabled = true;
                UIArtworksF1FBOff.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBBasementUnlock) == 1) {
                UIArtworksF1FBMute.enabled = false;
                UIArtworksF1FBOff.enabled = true;
            }
        }
        
        if (UIArtworksF1Background.enabled == false) {
            UIArtworksF1F2Mute.enabled = false;
            UIArtworksF1F2Off.enabled = false;
            UIArtworksF1F3Mute.enabled = false;
            UIArtworksF1F3Off.enabled = false;
            UIArtworksF1G1Mute.enabled = false;
            UIArtworksF1G1Off.enabled = false;
            UIArtworksF1G2Mute.enabled = false;
            UIArtworksF1G2Off.enabled = false;
            UIArtworksF1G3Mute.enabled = false;
            UIArtworksF1G3Off.enabled = false;
            UIArtworksF1FBMute.enabled = false;
            UIArtworksF1FBOff.enabled = false;
        }
    }
    
    public void OpenArtworksSecondaryFloorsF2Enable() {
        if (UIArtworksF2Background.enabled == true) {
            if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 0) {
                UIArtworksF2F3Mute.enabled = true;
                UIArtworksF2F3Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 1) {
                UIArtworksF2F3Mute.enabled = false;
                UIArtworksF2F3Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 0) {
                UIArtworksF2G1Mute.enabled = true;
                UIArtworksF2G1Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 1) {
                UIArtworksF2G1Mute.enabled = false;
                UIArtworksF2G1Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 0) {
                UIArtworksF2G2Mute.enabled = true;
                UIArtworksF2G2Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 1) {
                UIArtworksF2G2Mute.enabled = false;
                UIArtworksF2G2Off.enabled = true;
            }
            
            if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 0) {
                UIArtworksF2G3Mute.enabled = true;
                UIArtworksF2G3Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 1) {
                UIArtworksF2G3Mute.enabled = false;
                UIArtworksF2G3Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBBasementUnlock) == 0) {
                UIArtworksF2FBMute.enabled = true;
                UIArtworksF2FBOff.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBBasementUnlock) == 1) {
                UIArtworksF2FBMute.enabled = false;
                UIArtworksF2FBOff.enabled = true;
            }
        }
        
        if (UIArtworksF2Background.enabled == false) {
            UIArtworksF2F3Mute.enabled = false;
            UIArtworksF2F3Off.enabled = false;
            UIArtworksF2G1Mute.enabled = false;
            UIArtworksF2G1Off.enabled = false;
            UIArtworksF2G2Mute.enabled = false;
            UIArtworksF2G2Off.enabled = false;
            UIArtworksF2G3Mute.enabled = false;
            UIArtworksF2G3Off.enabled = false;
            UIArtworksF2FBMute.enabled = false;
            UIArtworksF2FBOff.enabled = false;
        }
    }
    
    public void OpenArtworksSecondaryFloorsF3Enable() {
        if (UIArtworksF3Background.enabled == true) {
            if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 0) {
                UIArtworksF3F2Mute.enabled = true;
                UIArtworksF3F2Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 1) {
                UIArtworksF3F2Mute.enabled = false;
                UIArtworksF3F2Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 0) {
                UIArtworksF3G1Mute.enabled = true;
                UIArtworksF3G1Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 1) {
                UIArtworksF3G1Mute.enabled = false;
                UIArtworksF3G1Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 0) {
                UIArtworksF3G2Mute.enabled = true;
                UIArtworksF3G2Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 1) {
                UIArtworksF3G2Mute.enabled = false;
                UIArtworksF3G2Off.enabled = true;
            }
            
            if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 0) {
                UIArtworksF3G3Mute.enabled = true;
                UIArtworksF3G3Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 1) {
                UIArtworksF3G3Mute.enabled = false;
                UIArtworksF3G3Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBBasementUnlock) == 0) {
                UIArtworksF3FBMute.enabled = true;
                UIArtworksF3FBOff.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBBasementUnlock) == 1) {
                UIArtworksF3FBMute.enabled = false;
                UIArtworksF3FBOff.enabled = true;
            }
        }
        
        if (UIArtworksF3Background.enabled == false) {
            UIArtworksF3F2Mute.enabled = false;
            UIArtworksF3F2Off.enabled = false;
            UIArtworksF3G1Mute.enabled = false;
            UIArtworksF3G1Off.enabled = false;
            UIArtworksF3G2Mute.enabled = false;
            UIArtworksF3G2Off.enabled = false;
            UIArtworksF3G3Mute.enabled = false;
            UIArtworksF3G3Off.enabled = false;
            UIArtworksF3FBMute.enabled = false;
            UIArtworksF3FBOff.enabled = false;
        }
    }
    
    public void OpenArtworksSecondaryFloorsG1Enable() {
        if (UIArtworksG1Background.enabled == true) {
            if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 0) {
                UIArtworksG1F2Mute.enabled = true;
                UIArtworksG1F2Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 1) {
                UIArtworksG1F2Mute.enabled = false;
                UIArtworksG1F2Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 0) {
                UIArtworksG1F3Mute.enabled = true;
                UIArtworksG1F3Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 1) {
                UIArtworksG1F3Mute.enabled = false;
                UIArtworksG1F3Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 0) {
                UIArtworksG1G2Mute.enabled = true;
                UIArtworksG1G2Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 1) {
                UIArtworksG1G2Mute.enabled = false;
                UIArtworksG1G2Off.enabled = true;
            }
            
            if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 0) {
                UIArtworksG1G3Mute.enabled = true;
                UIArtworksG1G3Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 1) {
                UIArtworksG1G3Mute.enabled = false;
                UIArtworksG1G3Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBBasementUnlock) == 0) {
                UIArtworksG1FBMute.enabled = true;
                UIArtworksG1FBOff.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBBasementUnlock) == 1) {
                UIArtworksG1FBMute.enabled = false;
                UIArtworksG1FBOff.enabled = true;
            }
        }
        
        if (UIArtworksG1Background.enabled == false) {
            UIArtworksG1F2Mute.enabled = false;
            UIArtworksG1F2Off.enabled = false;
            UIArtworksG1F3Mute.enabled = false;
            UIArtworksG1F3Off.enabled = false;
            UIArtworksG1G2Mute.enabled = false;
            UIArtworksG1G2Off.enabled = false;
            UIArtworksG1G3Mute.enabled = false;
            UIArtworksG1G3Off.enabled = false;
            UIArtworksG1FBMute.enabled = false;
            UIArtworksG1FBOff.enabled = false;
        }
    }
    
    public void OpenArtworksSecondaryFloorsG2Enable() {
        if (UIArtworksG2Background.enabled == true) {
            if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 0) {
                UIArtworksG2F2Mute.enabled = true;
                UIArtworksG2F2Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 1) {
                UIArtworksG2F2Mute.enabled = false;
                UIArtworksG2F2Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 0) {
                UIArtworksG2F3Mute.enabled = true;
                UIArtworksG2F3Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 1) {
                UIArtworksG2F3Mute.enabled = false;
                UIArtworksG2F3Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 0) {
                UIArtworksG2G1Mute.enabled = true;
                UIArtworksG2G1Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 1) {
                UIArtworksG2G1Mute.enabled = false;
                UIArtworksG2G1Off.enabled = true;
            }
            
            if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 0) {
                UIArtworksG2G3Mute.enabled = true;
                UIArtworksG2G3Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 1) {
                UIArtworksG2G3Mute.enabled = false;
                UIArtworksG2G3Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBBasementUnlock) == 0) {
                UIArtworksG2FBMute.enabled = true;
                UIArtworksG2FBOff.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBBasementUnlock) == 1) {
                UIArtworksG2FBMute.enabled = false;
                UIArtworksG2FBOff.enabled = true;
            }
        }
        
        if (UIArtworksG2Background.enabled == false) {
            UIArtworksG2F2Mute.enabled = false;
            UIArtworksG2F2Off.enabled = false;
            UIArtworksG2F3Mute.enabled = false;
            UIArtworksG2F3Off.enabled = false;
            UIArtworksG2G1Mute.enabled = false;
            UIArtworksG2G1Off.enabled = false;
            UIArtworksG2G3Mute.enabled = false;
            UIArtworksG2G3Off.enabled = false;
            UIArtworksG2FBMute.enabled = false;
            UIArtworksG2FBOff.enabled = false;
        }
    }
    
    public void OpenArtworksSecondaryFloorsG3Enable() {
        if (UIArtworksG3Background.enabled == true) {
            if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 0) {
                UIArtworksG3F2Mute.enabled = true;
                UIArtworksG3F2Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 1) {
                UIArtworksG3F2Mute.enabled = false;
                UIArtworksG3F2Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 0) {
                UIArtworksG3F3Mute.enabled = true;
                UIArtworksG3F3Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 1) {
                UIArtworksG3F3Mute.enabled = false;
                UIArtworksG3F3Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 0) {
                UIArtworksG3G1Mute.enabled = true;
                UIArtworksG3G1Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 1) {
                UIArtworksG3G1Mute.enabled = false;
                UIArtworksG3G1Off.enabled = true;
            }
            
            if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 0) {
                UIArtworksG3G2Mute.enabled = true;
                UIArtworksG3G2Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 1) {
                UIArtworksG3G2Mute.enabled = false;
                UIArtworksG3G2Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBBasementUnlock) == 0) {
                UIArtworksG3FBMute.enabled = true;
                UIArtworksG3FBOff.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBBasementUnlock) == 1) {
                UIArtworksG3FBMute.enabled = false;
                UIArtworksG3FBOff.enabled = true;
            }
        }
        
        if (UIArtworksG3Background.enabled == false) {
            UIArtworksG3F2Mute.enabled = false;
            UIArtworksG3F2Off.enabled = false;
            UIArtworksG3F3Mute.enabled = false;
            UIArtworksG3F3Off.enabled = false;
            UIArtworksG3G1Mute.enabled = false;
            UIArtworksG3G1Off.enabled = false;
            UIArtworksG3G2Mute.enabled = false;
            UIArtworksG3G2Off.enabled = false;
            UIArtworksG3FBMute.enabled = false;
            UIArtworksG3FBOff.enabled = false;
        }
    }
    
    public void OpenArtworksSecondaryFloorsFBEnable() {
        if (UIArtworksFBBackground.enabled == true) {
            if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 0) {
                UIArtworksFBF2Mute.enabled = true;
                UIArtworksFBF2Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBSecondFloorUnlock) == 1) {
                UIArtworksFBF2Mute.enabled = false;
                UIArtworksFBF2Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 0) {
                UIArtworksFBF3Mute.enabled = true;
                UIArtworksFBF3Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBThirdFloorUnlock) == 1) {
                UIArtworksFBF3Mute.enabled = false;
                UIArtworksFBF3Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 0) {
                UIArtworksFBG1Mute.enabled = true;
                UIArtworksFBG1Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 1) {
                UIArtworksFBG1Mute.enabled = false;
                UIArtworksFBG1Off.enabled = true;
            }

            if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 0) {
                UIArtworksFBG2Mute.enabled = true;
                UIArtworksFBG2Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 1) {
                UIArtworksFBG2Mute.enabled = false;
                UIArtworksFBG2Off.enabled = true;
            }
            
            if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 0) {
                UIArtworksFBG3Mute.enabled = true;
                UIArtworksFBG3Off.enabled = false;
            }

            if (int.Parse(DataFillingInformation.DBThirdGardenUnlock) == 1) {
                UIArtworksFBG3Mute.enabled = false;
                UIArtworksFBG3Off.enabled = true;
            }
        }
        
        if (UIArtworksFBBackground.enabled == false) {
            UIArtworksFBF2Mute.enabled = false;
            UIArtworksFBF2Off.enabled = false;
            UIArtworksFBF3Mute.enabled = false;
            UIArtworksFBF3Off.enabled = false;
            UIArtworksFBG1Mute.enabled = false;
            UIArtworksFBG1Off.enabled = false;
            UIArtworksFBG2Mute.enabled = false;
            UIArtworksFBG2Off.enabled = false;
            UIArtworksFBG3Mute.enabled = false;
            UIArtworksFBG3Off.enabled = false;
        }
    }
	
	public void ArtworksPageF1Enable() {
		UIArtworksF1Background.enabled = true;
		UIArtworksF1Text.enabled = true;
		UIArtworksF1CloseButton.enabled = true;
		UIArtworksF1F1On.enabled = true;		
		UIArtworksButtonF101.enabled = true;
		UIArtworksButtonF101Text.enabled = true;
		UIArtworksButtonF102.enabled = true;
		UIArtworksButtonF102Text.enabled = true;
		UIArtworksButtonF103.enabled = true;
		UIArtworksButtonF103Text.enabled = true;
		UIArtworksButtonF104.enabled = true;
		UIArtworksButtonF104Text.enabled = true;
		UIArtworksButtonF105.enabled = true;
		UIArtworksButtonF105Text.enabled = true;
		UIArtworksButtonF106.enabled = true;
		UIArtworksButtonF106Text.enabled = true;
		UIArtworksButtonF107.enabled = true;
		UIArtworksButtonF107Text.enabled = true;
		UIArtworksButtonF108.enabled = true;
		UIArtworksButtonF108Text.enabled = true;
		UIArtworksButtonF109.enabled = true;
		UIArtworksButtonF109Text.enabled = true;
		UIArtworksButtonF110.enabled = true;
		UIArtworksButtonF110Text.enabled = true;
		UIArtworksButtonF111.enabled = true;
		UIArtworksButtonF111Text.enabled = true;
		UIArtworksButtonF112.enabled = true;
		UIArtworksButtonF112Text.enabled = true;
		UIArtworksButtonF113.enabled = true;
		UIArtworksButtonF113Text.enabled = true;
		UIArtworksButtonF114.enabled = true;
		UIArtworksButtonF114Text.enabled = true;
		UIArtworksButtonF115.enabled = true;
		UIArtworksButtonF115Text.enabled = true;
	}
	
	public void ArtworksPageF2Enable() {
		UIArtworksF2Background.enabled = true;
		UIArtworksF2Text.enabled = true;
		UIArtworksF2CloseButton.enabled = true;
		UIArtworksF2F2On.enabled = true;
		UIArtworksF2F1Off.enabled = true;		
		UIArtworksButtonF201.enabled = true;
		UIArtworksButtonF201Text.enabled = true;
		UIArtworksButtonF202.enabled = true;
		UIArtworksButtonF202Text.enabled = true;
		UIArtworksButtonF203.enabled = true;
		UIArtworksButtonF203Text.enabled = true;
		UIArtworksButtonF204.enabled = true;
		UIArtworksButtonF204Text.enabled = true;
		UIArtworksButtonF205.enabled = true;
		UIArtworksButtonF205Text.enabled = true;
		UIArtworksButtonF206.enabled = true;
		UIArtworksButtonF206Text.enabled = true;
		UIArtworksButtonF207.enabled = true;
		UIArtworksButtonF207Text.enabled = true;
		UIArtworksButtonF208.enabled = true;
		UIArtworksButtonF208Text.enabled = true;
		UIArtworksButtonF209.enabled = true;
		UIArtworksButtonF209Text.enabled = true;
		UIArtworksButtonF210.enabled = true;
		UIArtworksButtonF210Text.enabled = true;
		UIArtworksButtonF211.enabled = true;
		UIArtworksButtonF211Text.enabled = true;
		UIArtworksButtonF212.enabled = true;
		UIArtworksButtonF212Text.enabled = true;
		UIArtworksButtonF213.enabled = true;
		UIArtworksButtonF213Text.enabled = true;
		UIArtworksButtonF214.enabled = true;
		UIArtworksButtonF214Text.enabled = true;
		UIArtworksButtonF215.enabled = true;
		UIArtworksButtonF215Text.enabled = true;
	}
	
	public void ArtworksPageF3Enable() {
		UIArtworksF3Background.enabled = true;
		UIArtworksF3Text.enabled = true;
		UIArtworksF3CloseButton.enabled = true;
		UIArtworksF3F3On.enabled = true;
		UIArtworksF3F1Off.enabled = true;		
		UIArtworksButtonF301.enabled = true;
		UIArtworksButtonF301Text.enabled = true;
		UIArtworksButtonF302.enabled = true;
		UIArtworksButtonF302Text.enabled = true;
		UIArtworksButtonF303.enabled = true;
		UIArtworksButtonF303Text.enabled = true;
		UIArtworksButtonF304.enabled = true;
		UIArtworksButtonF304Text.enabled = true;
		UIArtworksButtonF305.enabled = true;
		UIArtworksButtonF305Text.enabled = true;
		UIArtworksButtonF306.enabled = true;
		UIArtworksButtonF306Text.enabled = true;
		UIArtworksButtonF307.enabled = true;
		UIArtworksButtonF307Text.enabled = true;
		UIArtworksButtonF308.enabled = true;
		UIArtworksButtonF308Text.enabled = true;
		UIArtworksButtonF309.enabled = true;
		UIArtworksButtonF309Text.enabled = true;
		UIArtworksButtonF310.enabled = true;
		UIArtworksButtonF310Text.enabled = true;
		UIArtworksButtonF311.enabled = true;
		UIArtworksButtonF311Text.enabled = true;
		UIArtworksButtonF312.enabled = true;
		UIArtworksButtonF312Text.enabled = true;
		UIArtworksButtonF313.enabled = true;
		UIArtworksButtonF313Text.enabled = true;
		UIArtworksButtonF314.enabled = true;
		UIArtworksButtonF314Text.enabled = true;
		UIArtworksButtonF315.enabled = true;
		UIArtworksButtonF315Text.enabled = true;
	}
	
	public void ArtworksPageG1Enable() {
		UIArtworksG1Background.enabled = true;
		UIArtworksG1Text.enabled = true;
		UIArtworksG1CloseButton.enabled = true;
		UIArtworksG1G1On.enabled = true;
		UIArtworksG1F1Off.enabled = true;		
		UIArtworksButtonG101.enabled = true;
		UIArtworksButtonG101Text.enabled = true;
		UIArtworksButtonG102.enabled = true;
		UIArtworksButtonG102Text.enabled = true;
		UIArtworksButtonG103.enabled = true;
		UIArtworksButtonG103Text.enabled = true;
		UIArtworksButtonG104.enabled = true;
		UIArtworksButtonG104Text.enabled = true;
		UIArtworksButtonG105.enabled = true;
		UIArtworksButtonG105Text.enabled = true;
		UIArtworksButtonG106.enabled = true;
		UIArtworksButtonG106Text.enabled = true;
		UIArtworksButtonG107.enabled = true;
		UIArtworksButtonG107Text.enabled = true;
		UIArtworksButtonG108.enabled = true;
		UIArtworksButtonG108Text.enabled = true;
		UIArtworksButtonG109.enabled = true;
		UIArtworksButtonG109Text.enabled = true;
		UIArtworksButtonG110.enabled = true;
		UIArtworksButtonG110Text.enabled = true;
		UIArtworksButtonG111.enabled = true;
		UIArtworksButtonG111Text.enabled = true;
		UIArtworksButtonG112.enabled = true;
		UIArtworksButtonG112Text.enabled = true;
		UIArtworksButtonG113.enabled = true;
		UIArtworksButtonG113Text.enabled = true;
		UIArtworksButtonG114.enabled = true;
		UIArtworksButtonG114Text.enabled = true;
		UIArtworksButtonG115.enabled = true;
		UIArtworksButtonG115Text.enabled = true;
	}
	
	public void ArtworksPageG2Enable() {
		UIArtworksG2Background.enabled = true;
		UIArtworksG2Text.enabled = true;
		UIArtworksG2CloseButton.enabled = true;
		UIArtworksG2G2On.enabled = true;
		UIArtworksG2F1Off.enabled = true;		
		UIArtworksButtonG201.enabled = true;
		UIArtworksButtonG201Text.enabled = true;
		UIArtworksButtonG202.enabled = true;
		UIArtworksButtonG202Text.enabled = true;
		UIArtworksButtonG203.enabled = true;
		UIArtworksButtonG203Text.enabled = true;
		UIArtworksButtonG204.enabled = true;
		UIArtworksButtonG204Text.enabled = true;
		UIArtworksButtonG205.enabled = true;
		UIArtworksButtonG205Text.enabled = true;
		UIArtworksButtonG206.enabled = true;
		UIArtworksButtonG206Text.enabled = true;
		UIArtworksButtonG207.enabled = true;
		UIArtworksButtonG207Text.enabled = true;
		UIArtworksButtonG208.enabled = true;
		UIArtworksButtonG208Text.enabled = true;
		UIArtworksButtonG209.enabled = true;
		UIArtworksButtonG209Text.enabled = true;
		UIArtworksButtonG210.enabled = true;
		UIArtworksButtonG210Text.enabled = true;
		UIArtworksButtonG211.enabled = true;
		UIArtworksButtonG211Text.enabled = true;
		UIArtworksButtonG212.enabled = true;
		UIArtworksButtonG212Text.enabled = true;
		UIArtworksButtonG213.enabled = true;
		UIArtworksButtonG213Text.enabled = true;
		UIArtworksButtonG214.enabled = true;
		UIArtworksButtonG214Text.enabled = true;
		UIArtworksButtonG215.enabled = true;
		UIArtworksButtonG215Text.enabled = true;
	}
    
    public void ArtworksPageG3Enable() {
		UIArtworksG3Background.enabled = true;
		UIArtworksG3Text.enabled = true;
		UIArtworksG3CloseButton.enabled = true;
		UIArtworksG3G3On.enabled = true;
		UIArtworksG3F1Off.enabled = true;		
		UIArtworksButtonG301.enabled = true;
		UIArtworksButtonG301Text.enabled = true;
		UIArtworksButtonG302.enabled = true;
		UIArtworksButtonG302Text.enabled = true;
		UIArtworksButtonG303.enabled = true;
		UIArtworksButtonG303Text.enabled = true;
		UIArtworksButtonG304.enabled = true;
		UIArtworksButtonG304Text.enabled = true;
		UIArtworksButtonG305.enabled = true;
		UIArtworksButtonG305Text.enabled = true;
		UIArtworksButtonG306.enabled = true;
		UIArtworksButtonG306Text.enabled = true;
		UIArtworksButtonG307.enabled = true;
		UIArtworksButtonG307Text.enabled = true;
		UIArtworksButtonG308.enabled = true;
		UIArtworksButtonG308Text.enabled = true;
		UIArtworksButtonG309.enabled = true;
		UIArtworksButtonG309Text.enabled = true;
		UIArtworksButtonG310.enabled = true;
		UIArtworksButtonG310Text.enabled = true;
		UIArtworksButtonG311.enabled = true;
		UIArtworksButtonG311Text.enabled = true;
		UIArtworksButtonG312.enabled = true;
		UIArtworksButtonG312Text.enabled = true;
		UIArtworksButtonG313.enabled = true;
		UIArtworksButtonG313Text.enabled = true;
		UIArtworksButtonG314.enabled = true;
		UIArtworksButtonG314Text.enabled = true;
		UIArtworksButtonG315.enabled = true;
		UIArtworksButtonG315Text.enabled = true;
	}
	
	public void ArtworksPageFBEnable() {
		UIArtworksFBBackground.enabled = true;
		UIArtworksFBText.enabled = true;
		UIArtworksFBCloseButton.enabled = true;
		UIArtworksFBFBOn.enabled = true;
		UIArtworksFBF1Off.enabled = true;		
		UIArtworksButtonFB01.enabled = true;
		UIArtworksButtonFB01Text.enabled = true;
		UIArtworksButtonFB02.enabled = true;
		UIArtworksButtonFB02Text.enabled = true;
		UIArtworksButtonFB03.enabled = true;
		UIArtworksButtonFB03Text.enabled = true;
		UIArtworksButtonFB04.enabled = true;
		UIArtworksButtonFB04Text.enabled = true;
		UIArtworksButtonFB05.enabled = true;
		UIArtworksButtonFB05Text.enabled = true;
		UIArtworksButtonFB06.enabled = true;
		UIArtworksButtonFB06Text.enabled = true;
		UIArtworksButtonFB07.enabled = true;
		UIArtworksButtonFB07Text.enabled = true;
		UIArtworksButtonFB08.enabled = true;
		UIArtworksButtonFB08Text.enabled = true;
		UIArtworksButtonFB09.enabled = true;
		UIArtworksButtonFB09Text.enabled = true;
		UIArtworksButtonFB10.enabled = true;
		UIArtworksButtonFB10Text.enabled = true;
		UIArtworksButtonFB11.enabled = true;
		UIArtworksButtonFB11Text.enabled = true;
		UIArtworksButtonFB12.enabled = true;
		UIArtworksButtonFB12Text.enabled = true;
		UIArtworksButtonFB13.enabled = true;
		UIArtworksButtonFB13Text.enabled = true;
		UIArtworksButtonFB14.enabled = true;
		UIArtworksButtonFB14Text.enabled = true;
		UIArtworksButtonFB15.enabled = true;
		UIArtworksButtonFB15Text.enabled = true;
	}
	
// --------------- DISABLE FUNCTION ---------------
	public void MainArtworksPageAllDisable() {
		OpeningArtworksDisable();
		ArtworksPageF1Disable();
		ArtworksPageF2Disable();
		ArtworksPageF3Disable();
		ArtworksPageG1Disable();
		ArtworksPageG2Disable();
        ArtworksPageG3Disable();
		ArtworksPageFBDisable();
	}
	
	public void OpeningArtworksDisable() {
		UIOpeningArtworksBackground.enabled = false;
		UIOpeningArtworksField.enabled = false;
		UIOpeningArtworksText.enabled = false;
		UIOpeningArtworksCloseButton.enabled = false;
        UIOpeningArtworksCollectTextF1.enabled = false;
        UIOpeningArtworksCollectTextF2.enabled = false;
        UIOpeningArtworksCollectTextF3.enabled = false;
        UIOpeningArtworksCollectTextG1.enabled = false;
        UIOpeningArtworksCollectTextG2.enabled = false;
        UIOpeningArtworksCollectTextG3.enabled = false;
        UIOpeningArtworksCollectTextFB.enabled = false;
		UIOpeningArtworksF1Off.enabled = false;
		UIOpeningArtworksF2Mute.enabled = false;
		UIOpeningArtworksF2Off.enabled = false;
		UIOpeningArtworksF2Mute.enabled = false;
		UIOpeningArtworksF2Off.enabled = false;
		UIOpeningArtworksF3Mute.enabled = false;
		UIOpeningArtworksF3Off.enabled = false;
		UIOpeningArtworksF3Mute.enabled = false;
		UIOpeningArtworksF3Off.enabled = false;
		UIOpeningArtworksG1Mute.enabled = false;
		UIOpeningArtworksG1Off.enabled = false;
		UIOpeningArtworksG1Mute.enabled = false;
		UIOpeningArtworksG1Off.enabled = false;
		UIOpeningArtworksG2Mute.enabled = false;
		UIOpeningArtworksG2Off.enabled = false;
		UIOpeningArtworksG2Mute.enabled = false;
		UIOpeningArtworksG2Off.enabled = false;
        UIOpeningArtworksG3Mute.enabled = false;
		UIOpeningArtworksG3Off.enabled = false;
		UIOpeningArtworksG3Mute.enabled = false;
		UIOpeningArtworksG3Off.enabled = false;
		UIOpeningArtworksFBMute.enabled = false;
		UIOpeningArtworksFBOff.enabled = false;
		UIOpeningArtworksFBMute.enabled = false;
		UIOpeningArtworksFBOff.enabled = false;
	}
	
	public void ArtworksPageF1Disable() {
		UIArtworksF1Background.enabled = false;
		UIArtworksF1Text.enabled = false;
		UIArtworksF1CloseButton.enabled = false;
		UIArtworksF1F1On.enabled = false;
		UIOpeningArtworksF2Mute.enabled = false;
		UIOpeningArtworksF2Off.enabled = false;
		UIOpeningArtworksF2Mute.enabled = false;
		UIOpeningArtworksF2Off.enabled = false;
		UIOpeningArtworksF3Mute.enabled = false;
		UIOpeningArtworksF3Off.enabled = false;
		UIOpeningArtworksF3Mute.enabled = false;
		UIOpeningArtworksF3Off.enabled = false;
		UIOpeningArtworksG1Mute.enabled = false;
		UIOpeningArtworksG1Off.enabled = false;
		UIOpeningArtworksG1Mute.enabled = false;
		UIOpeningArtworksG1Off.enabled = false;
		UIOpeningArtworksG2Mute.enabled = false;
		UIOpeningArtworksG2Off.enabled = false;
		UIOpeningArtworksG2Mute.enabled = false;
		UIOpeningArtworksG2Off.enabled = false;
        UIOpeningArtworksG3Mute.enabled = false;
		UIOpeningArtworksG3Off.enabled = false;
		UIOpeningArtworksG3Mute.enabled = false;
		UIOpeningArtworksG3Off.enabled = false;
		UIOpeningArtworksFBMute.enabled = false;
		UIOpeningArtworksFBOff.enabled = false;
		UIOpeningArtworksFBMute.enabled = false;
		UIOpeningArtworksFBOff.enabled = false;
		UIArtworksButtonF101.enabled = false;
		UIArtworksButtonF101Text.enabled = false;
		UIArtworksButtonF102.enabled = false;
		UIArtworksButtonF102Text.enabled = false;
		UIArtworksButtonF103.enabled = false;
		UIArtworksButtonF103Text.enabled = false;
		UIArtworksButtonF104.enabled = false;
		UIArtworksButtonF104Text.enabled = false;
		UIArtworksButtonF105.enabled = false;
		UIArtworksButtonF105Text.enabled = false;
		UIArtworksButtonF106.enabled = false;
		UIArtworksButtonF106Text.enabled = false;
		UIArtworksButtonF107.enabled = false;
		UIArtworksButtonF107Text.enabled = false;
		UIArtworksButtonF108.enabled = false;
		UIArtworksButtonF108Text.enabled = false;
		UIArtworksButtonF109.enabled = false;
		UIArtworksButtonF109Text.enabled = false;
		UIArtworksButtonF110.enabled = false;
		UIArtworksButtonF110Text.enabled = false;
		UIArtworksButtonF111.enabled = false;
		UIArtworksButtonF111Text.enabled = false;
		UIArtworksButtonF112.enabled = false;
		UIArtworksButtonF112Text.enabled = false;
		UIArtworksButtonF113.enabled = false;
		UIArtworksButtonF113Text.enabled = false;
		UIArtworksButtonF114.enabled = false;
		UIArtworksButtonF114Text.enabled = false;
		UIArtworksButtonF115.enabled = false;
		UIArtworksButtonF115Text.enabled = false;
	}
	
	public void ArtworksPageF2Disable() {
		UIArtworksF2Background.enabled = false;
		UIArtworksF2Text.enabled = false;
		UIArtworksF2CloseButton.enabled = false;
		UIArtworksF2F2On.enabled = false;
		UIArtworksF2F1Off.enabled = false;
		UIOpeningArtworksF3Mute.enabled = false;
		UIOpeningArtworksF3Off.enabled = false;
		UIOpeningArtworksF3Mute.enabled = false;
		UIOpeningArtworksF3Off.enabled = false;
		UIOpeningArtworksG1Mute.enabled = false;
		UIOpeningArtworksG1Off.enabled = false;
		UIOpeningArtworksG1Mute.enabled = false;
		UIOpeningArtworksG1Off.enabled = false;
		UIOpeningArtworksG2Mute.enabled = false;
		UIOpeningArtworksG2Off.enabled = false;
		UIOpeningArtworksG2Mute.enabled = false;
		UIOpeningArtworksG2Off.enabled = false;
        UIOpeningArtworksG3Mute.enabled = false;
		UIOpeningArtworksG3Off.enabled = false;
		UIOpeningArtworksG3Mute.enabled = false;
		UIOpeningArtworksG3Off.enabled = false;
		UIOpeningArtworksFBMute.enabled = false;
		UIOpeningArtworksFBOff.enabled = false;
		UIOpeningArtworksFBMute.enabled = false;
		UIOpeningArtworksFBOff.enabled = false;
		UIArtworksButtonF201.enabled = false;
		UIArtworksButtonF201Text.enabled = false;
		UIArtworksButtonF202.enabled = false;
		UIArtworksButtonF202Text.enabled = false;
		UIArtworksButtonF203.enabled = false;
		UIArtworksButtonF203Text.enabled = false;
		UIArtworksButtonF204.enabled = false;
		UIArtworksButtonF204Text.enabled = false;
		UIArtworksButtonF205.enabled = false;
		UIArtworksButtonF205Text.enabled = false;
		UIArtworksButtonF206.enabled = false;
		UIArtworksButtonF206Text.enabled = false;
		UIArtworksButtonF207.enabled = false;
		UIArtworksButtonF207Text.enabled = false;
		UIArtworksButtonF208.enabled = false;
		UIArtworksButtonF208Text.enabled = false;
		UIArtworksButtonF209.enabled = false;
		UIArtworksButtonF209Text.enabled = false;
		UIArtworksButtonF210.enabled = false;
		UIArtworksButtonF210Text.enabled = false;
		UIArtworksButtonF211.enabled = false;
		UIArtworksButtonF211Text.enabled = false;
		UIArtworksButtonF212.enabled = false;
		UIArtworksButtonF212Text.enabled = false;
		UIArtworksButtonF213.enabled = false;
		UIArtworksButtonF213Text.enabled = false;
		UIArtworksButtonF214.enabled = false;
		UIArtworksButtonF214Text.enabled = false;
		UIArtworksButtonF215.enabled = false;
		UIArtworksButtonF215Text.enabled = false;
	}
	
	public void ArtworksPageF3Disable() {
		UIArtworksF3Background.enabled = false;
		UIArtworksF3Text.enabled = false;
		UIArtworksF3CloseButton.enabled = false;
		UIArtworksF3F3On.enabled = false;
		UIArtworksF3F1Off.enabled = false;
		UIOpeningArtworksF2Mute.enabled = false;
		UIOpeningArtworksF2Off.enabled = false;
		UIOpeningArtworksF2Mute.enabled = false;
		UIOpeningArtworksF2Off.enabled = false;
		UIOpeningArtworksG1Mute.enabled = false;
		UIOpeningArtworksG1Off.enabled = false;
		UIOpeningArtworksG1Mute.enabled = false;
		UIOpeningArtworksG1Off.enabled = false;
		UIOpeningArtworksG2Mute.enabled = false;
		UIOpeningArtworksG2Off.enabled = false;
		UIOpeningArtworksG2Mute.enabled = false;
		UIOpeningArtworksG2Off.enabled = false;
        UIOpeningArtworksG3Mute.enabled = false;
		UIOpeningArtworksG3Off.enabled = false;
		UIOpeningArtworksG3Mute.enabled = false;
		UIOpeningArtworksG3Off.enabled = false;
		UIOpeningArtworksFBMute.enabled = false;
		UIOpeningArtworksFBOff.enabled = false;
		UIOpeningArtworksFBMute.enabled = false;
		UIOpeningArtworksFBOff.enabled = false;
		UIArtworksButtonF301.enabled = false;
		UIArtworksButtonF301Text.enabled = false;
		UIArtworksButtonF302.enabled = false;
		UIArtworksButtonF302Text.enabled = false;
		UIArtworksButtonF303.enabled = false;
		UIArtworksButtonF303Text.enabled = false;
		UIArtworksButtonF304.enabled = false;
		UIArtworksButtonF304Text.enabled = false;
		UIArtworksButtonF305.enabled = false;
		UIArtworksButtonF305Text.enabled = false;
		UIArtworksButtonF306.enabled = false;
		UIArtworksButtonF306Text.enabled = false;
		UIArtworksButtonF307.enabled = false;
		UIArtworksButtonF307Text.enabled = false;
		UIArtworksButtonF308.enabled = false;
		UIArtworksButtonF308Text.enabled = false;
		UIArtworksButtonF309.enabled = false;
		UIArtworksButtonF309Text.enabled = false;
		UIArtworksButtonF310.enabled = false;
		UIArtworksButtonF310Text.enabled = false;
		UIArtworksButtonF311.enabled = false;
		UIArtworksButtonF311Text.enabled = false;
		UIArtworksButtonF312.enabled = false;
		UIArtworksButtonF312Text.enabled = false;
		UIArtworksButtonF313.enabled = false;
		UIArtworksButtonF313Text.enabled = false;
		UIArtworksButtonF314.enabled = false;
		UIArtworksButtonF314Text.enabled = false;
		UIArtworksButtonF315.enabled = false;
		UIArtworksButtonF315Text.enabled = false;
	}
	
	public void ArtworksPageG1Disable() {
		UIArtworksG1Background.enabled = false;
		UIArtworksG1Text.enabled = false;
		UIArtworksG1CloseButton.enabled = false;
		UIArtworksG1G1On.enabled = false;
		UIArtworksG1F1Off.enabled = false;
		UIOpeningArtworksF2Mute.enabled = false;
		UIOpeningArtworksF2Off.enabled = false;
		UIOpeningArtworksF2Mute.enabled = false;
		UIOpeningArtworksF2Off.enabled = false;
		UIOpeningArtworksF3Mute.enabled = false;
		UIOpeningArtworksF3Off.enabled = false;
		UIOpeningArtworksF3Mute.enabled = false;
		UIOpeningArtworksF3Off.enabled = false;
		UIOpeningArtworksG2Mute.enabled = false;
		UIOpeningArtworksG2Off.enabled = false;
		UIOpeningArtworksG2Mute.enabled = false;
		UIOpeningArtworksG2Off.enabled = false;
        UIOpeningArtworksG3Mute.enabled = false;
		UIOpeningArtworksG3Off.enabled = false;
		UIOpeningArtworksG3Mute.enabled = false;
		UIOpeningArtworksG3Off.enabled = false;
		UIOpeningArtworksFBMute.enabled = false;
		UIOpeningArtworksFBOff.enabled = false;
		UIOpeningArtworksFBMute.enabled = false;
		UIOpeningArtworksFBOff.enabled = false;
		UIArtworksButtonG101.enabled = false;
		UIArtworksButtonG101Text.enabled = false;
		UIArtworksButtonG102.enabled = false;
		UIArtworksButtonG102Text.enabled = false;
		UIArtworksButtonG103.enabled = false;
		UIArtworksButtonG103Text.enabled = false;
		UIArtworksButtonG104.enabled = false;
		UIArtworksButtonG104Text.enabled = false;
		UIArtworksButtonG105.enabled = false;
		UIArtworksButtonG105Text.enabled = false;
		UIArtworksButtonG106.enabled = false;
		UIArtworksButtonG106Text.enabled = false;
		UIArtworksButtonG107.enabled = false;
		UIArtworksButtonG107Text.enabled = false;
		UIArtworksButtonG108.enabled = false;
		UIArtworksButtonG108Text.enabled = false;
		UIArtworksButtonG109.enabled = false;
		UIArtworksButtonG109Text.enabled = false;
		UIArtworksButtonG110.enabled = false;
		UIArtworksButtonG110Text.enabled = false;
		UIArtworksButtonG111.enabled = false;
		UIArtworksButtonG111Text.enabled = false;
		UIArtworksButtonG112.enabled = false;
		UIArtworksButtonG112Text.enabled = false;
		UIArtworksButtonG113.enabled = false;
		UIArtworksButtonG113Text.enabled = false;
		UIArtworksButtonG114.enabled = false;
		UIArtworksButtonG114Text.enabled = false;
		UIArtworksButtonG115.enabled = false;
		UIArtworksButtonG115Text.enabled = false;
	}
	
	public void ArtworksPageG2Disable() {
		UIArtworksG2Background.enabled = false;
		UIArtworksG2Text.enabled = false;
		UIArtworksG2CloseButton.enabled = false;
		UIArtworksG2G2On.enabled = false;
		UIArtworksG2F1Off.enabled = false;
		UIOpeningArtworksF2Mute.enabled = false;
		UIOpeningArtworksF2Off.enabled = false;
		UIOpeningArtworksF2Mute.enabled = false;
		UIOpeningArtworksF2Off.enabled = false;
		UIOpeningArtworksF3Mute.enabled = false;
		UIOpeningArtworksF3Off.enabled = false;
		UIOpeningArtworksF3Mute.enabled = false;
		UIOpeningArtworksF3Off.enabled = false;
		UIOpeningArtworksG1Mute.enabled = false;
		UIOpeningArtworksG1Off.enabled = false;
		UIOpeningArtworksG1Mute.enabled = false;
		UIOpeningArtworksG1Off.enabled = false;
        UIOpeningArtworksG3Mute.enabled = false;
		UIOpeningArtworksG3Off.enabled = false;
		UIOpeningArtworksG3Mute.enabled = false;
		UIOpeningArtworksG3Off.enabled = false;
		UIOpeningArtworksFBMute.enabled = false;
		UIOpeningArtworksFBOff.enabled = false;
		UIOpeningArtworksFBMute.enabled = false;
		UIOpeningArtworksFBOff.enabled = false;
		UIArtworksButtonG201.enabled = false;
		UIArtworksButtonG201Text.enabled = false;
		UIArtworksButtonG202.enabled = false;
		UIArtworksButtonG202Text.enabled = false;
		UIArtworksButtonG203.enabled = false;
		UIArtworksButtonG203Text.enabled = false;
		UIArtworksButtonG204.enabled = false;
		UIArtworksButtonG204Text.enabled = false;
		UIArtworksButtonG205.enabled = false;
		UIArtworksButtonG205Text.enabled = false;
		UIArtworksButtonG206.enabled = false;
		UIArtworksButtonG206Text.enabled = false;
		UIArtworksButtonG207.enabled = false;
		UIArtworksButtonG207Text.enabled = false;
		UIArtworksButtonG208.enabled = false;
		UIArtworksButtonG208Text.enabled = false;
		UIArtworksButtonG209.enabled = false;
		UIArtworksButtonG209Text.enabled = false;
		UIArtworksButtonG210.enabled = false;
		UIArtworksButtonG210Text.enabled = false;
		UIArtworksButtonG211.enabled = false;
		UIArtworksButtonG211Text.enabled = false;
		UIArtworksButtonG212.enabled = false;
		UIArtworksButtonG212Text.enabled = false;
		UIArtworksButtonG213.enabled = false;
		UIArtworksButtonG213Text.enabled = false;
		UIArtworksButtonG214.enabled = false;
		UIArtworksButtonG214Text.enabled = false;
		UIArtworksButtonG215.enabled = false;
		UIArtworksButtonG215Text.enabled = false;
	}
    
    public void ArtworksPageG3Disable() {
		UIArtworksG3Background.enabled = false;
		UIArtworksG3Text.enabled = false;
		UIArtworksG3CloseButton.enabled = false;
		UIArtworksG3G3On.enabled = false;
		UIArtworksG3F1Off.enabled = false;
		UIOpeningArtworksF2Mute.enabled = false;
		UIOpeningArtworksF2Off.enabled = false;
		UIOpeningArtworksF2Mute.enabled = false;
		UIOpeningArtworksF2Off.enabled = false;
		UIOpeningArtworksF3Mute.enabled = false;
		UIOpeningArtworksF3Off.enabled = false;
		UIOpeningArtworksF3Mute.enabled = false;
		UIOpeningArtworksF3Off.enabled = false;
		UIOpeningArtworksG1Mute.enabled = false;
		UIOpeningArtworksG1Off.enabled = false;
		UIOpeningArtworksG1Mute.enabled = false;
		UIOpeningArtworksG1Off.enabled = false;
        UIOpeningArtworksG2Mute.enabled = false;
		UIOpeningArtworksG2Off.enabled = false;
		UIOpeningArtworksG2Mute.enabled = false;
		UIOpeningArtworksG2Off.enabled = false;
		UIOpeningArtworksFBMute.enabled = false;
		UIOpeningArtworksFBOff.enabled = false;
		UIOpeningArtworksFBMute.enabled = false;
		UIOpeningArtworksFBOff.enabled = false;
		UIArtworksButtonG301.enabled = false;
		UIArtworksButtonG301Text.enabled = false;
		UIArtworksButtonG302.enabled = false;
		UIArtworksButtonG302Text.enabled = false;
		UIArtworksButtonG303.enabled = false;
		UIArtworksButtonG303Text.enabled = false;
		UIArtworksButtonG304.enabled = false;
		UIArtworksButtonG304Text.enabled = false;
		UIArtworksButtonG305.enabled = false;
		UIArtworksButtonG305Text.enabled = false;
		UIArtworksButtonG306.enabled = false;
		UIArtworksButtonG306Text.enabled = false;
		UIArtworksButtonG307.enabled = false;
		UIArtworksButtonG307Text.enabled = false;
		UIArtworksButtonG308.enabled = false;
		UIArtworksButtonG308Text.enabled = false;
		UIArtworksButtonG309.enabled = false;
		UIArtworksButtonG309Text.enabled = false;
		UIArtworksButtonG310.enabled = false;
		UIArtworksButtonG310Text.enabled = false;
		UIArtworksButtonG311.enabled = false;
		UIArtworksButtonG311Text.enabled = false;
		UIArtworksButtonG312.enabled = false;
		UIArtworksButtonG312Text.enabled = false;
		UIArtworksButtonG313.enabled = false;
		UIArtworksButtonG313Text.enabled = false;
		UIArtworksButtonG314.enabled = false;
		UIArtworksButtonG314Text.enabled = false;
		UIArtworksButtonG315.enabled = false;
		UIArtworksButtonG315Text.enabled = false;
	}
	
	public void ArtworksPageFBDisable() {
		UIArtworksFBBackground.enabled = false;
		UIArtworksFBText.enabled = false;
		UIArtworksFBCloseButton.enabled = false;
		UIArtworksFBFBOn.enabled = false;
		UIArtworksFBF1Off.enabled = false;
		UIOpeningArtworksF2Mute.enabled = false;
		UIOpeningArtworksF2Off.enabled = false;
		UIOpeningArtworksF2Mute.enabled = false;
		UIOpeningArtworksF2Off.enabled = false;
		UIOpeningArtworksF3Mute.enabled = false;
		UIOpeningArtworksF3Off.enabled = false;
		UIOpeningArtworksF3Mute.enabled = false;
		UIOpeningArtworksF3Off.enabled = false;
		UIOpeningArtworksG1Mute.enabled = false;
		UIOpeningArtworksG1Off.enabled = false;
		UIOpeningArtworksG1Mute.enabled = false;
		UIOpeningArtworksG1Off.enabled = false;
		UIOpeningArtworksG2Mute.enabled = false;
		UIOpeningArtworksG2Off.enabled = false;
		UIOpeningArtworksG2Mute.enabled = false;
		UIOpeningArtworksG2Off.enabled = false;
        UIOpeningArtworksG3Mute.enabled = false;
		UIOpeningArtworksG3Off.enabled = false;
		UIOpeningArtworksG3Mute.enabled = false;
		UIOpeningArtworksG3Off.enabled = false;
		UIArtworksButtonFB01.enabled = false;
		UIArtworksButtonFB01Text.enabled = false;
		UIArtworksButtonFB02.enabled = false;
		UIArtworksButtonFB02Text.enabled = false;
		UIArtworksButtonFB03.enabled = false;
		UIArtworksButtonFB03Text.enabled = false;
		UIArtworksButtonFB04.enabled = false;
		UIArtworksButtonFB04Text.enabled = false;
		UIArtworksButtonFB05.enabled = false;
		UIArtworksButtonFB05Text.enabled = false;
		UIArtworksButtonFB06.enabled = false;
		UIArtworksButtonFB06Text.enabled = false;
		UIArtworksButtonFB07.enabled = false;
		UIArtworksButtonFB07Text.enabled = false;
		UIArtworksButtonFB08.enabled = false;
		UIArtworksButtonFB08Text.enabled = false;
		UIArtworksButtonFB09.enabled = false;
		UIArtworksButtonFB09Text.enabled = false;
		UIArtworksButtonFB10.enabled = false;
		UIArtworksButtonFB10Text.enabled = false;
		UIArtworksButtonFB11.enabled = false;
		UIArtworksButtonFB11Text.enabled = false;
		UIArtworksButtonFB12.enabled = false;
		UIArtworksButtonFB12Text.enabled = false;
		UIArtworksButtonFB13.enabled = false;
		UIArtworksButtonFB13Text.enabled = false;
		UIArtworksButtonFB14.enabled = false;
		UIArtworksButtonFB14Text.enabled = false;
		UIArtworksButtonFB15.enabled = false;
		UIArtworksButtonFB15Text.enabled = false;
	}
    
// --------------- BUTTON COLOR FUNCTIONS ---------------
    public void BoughtButtonsColor() {
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF101) == 0) {
            UIArtworksButtonF101.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF101) >= 1) {
            UIArtworksButtonF101.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF102) == 0) {
            UIArtworksButtonF102.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF102) >= 1) {
            UIArtworksButtonF102.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF103) == 0) {
            UIArtworksButtonF103.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF103) >= 1) {
            UIArtworksButtonF103.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF104) == 0) {
            UIArtworksButtonF104.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF104) >= 1) {
            UIArtworksButtonF104.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF105) == 0) {
            UIArtworksButtonF105.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF105) >= 1) {
            UIArtworksButtonF105.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF106) == 0) {
            UIArtworksButtonF106.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF106) >= 1) {
            UIArtworksButtonF106.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF107) == 0) {
            UIArtworksButtonF107.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF107) >= 1) {
            UIArtworksButtonF107.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF108) == 0) {
            UIArtworksButtonF108.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF108) >= 1) {
            UIArtworksButtonF108.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF109) == 0) {
            UIArtworksButtonF109.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF109) >= 1) {
            UIArtworksButtonF109.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF110) == 0) {
            UIArtworksButtonF110.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF110) >= 1) {
            UIArtworksButtonF110.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF111) == 0) {
            UIArtworksButtonF111.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF111) >= 1) {
            UIArtworksButtonF111.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF112) == 0) {
            UIArtworksButtonF112.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF112) >= 1) {
            UIArtworksButtonF112.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF113) == 0) {
            UIArtworksButtonF113.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF113) >= 1) {
            UIArtworksButtonF113.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF114) == 0) {
            UIArtworksButtonF114.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF114) >= 1) {
            UIArtworksButtonF114.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF115) == 0) {
            UIArtworksButtonF115.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF115) >= 1) {
            UIArtworksButtonF115.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF201) == 0) {
            UIArtworksButtonF201.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF201) >= 1) {
            UIArtworksButtonF201.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF202) == 0) {
            UIArtworksButtonF202.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF202) >= 1) {
            UIArtworksButtonF202.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF203) == 0) {
            UIArtworksButtonF203.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF203) >= 1) {
            UIArtworksButtonF203.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF204) == 0) {
            UIArtworksButtonF204.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF204) >= 1) {
            UIArtworksButtonF204.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF205) == 0) {
            UIArtworksButtonF205.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF205) >= 1) {
            UIArtworksButtonF205.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF206) == 0) {
            UIArtworksButtonF206.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF206) >= 1) {
            UIArtworksButtonF206.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF207) == 0) {
            UIArtworksButtonF207.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF207) >= 1) {
            UIArtworksButtonF207.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF208) == 0) {
            UIArtworksButtonF208.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF208) >= 1) {
            UIArtworksButtonF208.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF209) == 0) {
            UIArtworksButtonF209.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF209) >= 1) {
            UIArtworksButtonF209.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF210) == 0) {
            UIArtworksButtonF210.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF210) >= 1) {
            UIArtworksButtonF210.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF211) == 0) {
            UIArtworksButtonF211.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF211) >= 1) {
            UIArtworksButtonF211.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF212) == 0) {
            UIArtworksButtonF212.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF212) >= 1) {
            UIArtworksButtonF212.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF213) == 0) {
            UIArtworksButtonF213.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF213) >= 1) {
            UIArtworksButtonF213.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF214) == 0) {
            UIArtworksButtonF214.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF214) >= 1) {
            UIArtworksButtonF214.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF215) == 0) {
            UIArtworksButtonF215.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF215) >= 1) {
            UIArtworksButtonF215.color = ArtworkBoughtColorOn;
        }

        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF301) == 0) {
            UIArtworksButtonF301.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF301) >= 1) {
            UIArtworksButtonF301.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF302) == 0) {
            UIArtworksButtonF302.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF302) >= 1) {
            UIArtworksButtonF302.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF303) == 0) {
            UIArtworksButtonF303.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF303) >= 1) {
            UIArtworksButtonF303.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF304) == 0) {
            UIArtworksButtonF304.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF304) >= 1) {
            UIArtworksButtonF304.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF305) == 0) {
            UIArtworksButtonF305.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF305) >= 1) {
            UIArtworksButtonF305.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF306) == 0) {
            UIArtworksButtonF306.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF306) >= 1) {
            UIArtworksButtonF306.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF307) == 0) {
            UIArtworksButtonF307.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF307) >= 1) {
            UIArtworksButtonF307.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF308) == 0) {
            UIArtworksButtonF308.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF308) >= 1) {
            UIArtworksButtonF308.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF309) == 0) {
            UIArtworksButtonF309.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF309) >= 1) {
            UIArtworksButtonF309.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF310) == 0) {
            UIArtworksButtonF310.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF310) >= 1) {
            UIArtworksButtonF310.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF311) == 0) {
            UIArtworksButtonF311.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF311) >= 1) {
            UIArtworksButtonF311.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF312) == 0) {
            UIArtworksButtonF312.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF312) >= 1) {
            UIArtworksButtonF312.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF313) == 0) {
            UIArtworksButtonF313.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF313) >= 1) {
            UIArtworksButtonF313.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF314) == 0) {
            UIArtworksButtonF314.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF314) >= 1) {
            UIArtworksButtonF314.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF315) == 0) {
            UIArtworksButtonF315.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseF315) >= 1) {
            UIArtworksButtonF315.color = ArtworkBoughtColorOn;
        }

        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG101) == 0) {
            UIArtworksButtonG101.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG101) >= 1) {
            UIArtworksButtonG101.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG102) == 0) {
            UIArtworksButtonG102.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG102) >= 1) {
            UIArtworksButtonG102.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG103) == 0) {
            UIArtworksButtonG103.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG103) >= 1) {
            UIArtworksButtonG103.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG104) == 0) {
            UIArtworksButtonG104.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG104) >= 1) {
            UIArtworksButtonG104.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG105) == 0) {
            UIArtworksButtonG105.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG105) >= 1) {
            UIArtworksButtonG105.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG106) == 0) {
            UIArtworksButtonG106.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG106) >= 1) {
            UIArtworksButtonG106.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG107) == 0) {
            UIArtworksButtonG107.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG107) >= 1) {
            UIArtworksButtonG107.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG108) == 0) {
            UIArtworksButtonG108.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG108) >= 1) {
            UIArtworksButtonG108.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG109) == 0) {
            UIArtworksButtonG109.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG109) >= 1) {
            UIArtworksButtonG109.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG110) == 0) {
            UIArtworksButtonG110.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG110) >= 1) {
            UIArtworksButtonG110.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG111) == 0) {
            UIArtworksButtonG111.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG111) >= 1) {
            UIArtworksButtonG111.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG112) == 0) {
            UIArtworksButtonG112.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG112) >= 1) {
            UIArtworksButtonG112.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG113) == 0) {
            UIArtworksButtonG113.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG113) >= 1) {
            UIArtworksButtonG113.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG114) == 0) {
            UIArtworksButtonG114.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG114) >= 1) {
            UIArtworksButtonG114.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG115) == 0) {
            UIArtworksButtonG115.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG115) >= 1) {
            UIArtworksButtonG115.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG201) == 0) {
            UIArtworksButtonG201.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG201) >= 1) {
            UIArtworksButtonG201.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG202) == 0) {
            UIArtworksButtonG202.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG202) >= 1) {
            UIArtworksButtonG202.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG203) == 0) {
            UIArtworksButtonG203.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG203) >= 1) {
            UIArtworksButtonG203.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG204) == 0) {
            UIArtworksButtonG204.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG204) >= 1) {
            UIArtworksButtonG204.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG205) == 0) {
            UIArtworksButtonG205.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG205) >= 1) {
            UIArtworksButtonG205.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG206) == 0) {
            UIArtworksButtonG206.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG206) >= 1) {
            UIArtworksButtonG206.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG207) == 0) {
            UIArtworksButtonG207.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG207) >= 1) {
            UIArtworksButtonG207.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG208) == 0) {
            UIArtworksButtonG208.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG208) >= 1) {
            UIArtworksButtonG208.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG209) == 0) {
            UIArtworksButtonG209.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG209) >= 1) {
            UIArtworksButtonG209.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG210) == 0) {
            UIArtworksButtonG210.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG210) >= 1) {
            UIArtworksButtonG210.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG211) == 0) {
            UIArtworksButtonG211.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG211) >= 1) {
            UIArtworksButtonG211.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG212) == 0) {
            UIArtworksButtonG212.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG212) >= 1) {
            UIArtworksButtonG212.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG213) == 0) {
            UIArtworksButtonG213.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG213) >= 1) {
            UIArtworksButtonG213.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG214) == 0) {
            UIArtworksButtonG214.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG214) >= 1) {
            UIArtworksButtonG214.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG215) == 0) {
            UIArtworksButtonG215.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG215) >= 1) {
            UIArtworksButtonG215.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG301) == 0) {
            UIArtworksButtonG301.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG301) >= 1) {
            UIArtworksButtonG301.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG302) == 0) {
            UIArtworksButtonG302.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG302) >= 1) {
            UIArtworksButtonG302.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG303) == 0) {
            UIArtworksButtonG303.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG303) >= 1) {
            UIArtworksButtonG303.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG304) == 0) {
            UIArtworksButtonG304.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG304) >= 1) {
            UIArtworksButtonG304.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG305) == 0) {
            UIArtworksButtonG305.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG305) >= 1) {
            UIArtworksButtonG305.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG306) == 0) {
            UIArtworksButtonG306.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG306) >= 1) {
            UIArtworksButtonG306.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG307) == 0) {
            UIArtworksButtonG307.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG307) >= 1) {
            UIArtworksButtonG307.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG308) == 0) {
            UIArtworksButtonG308.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG308) >= 1) {
            UIArtworksButtonG308.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG309) == 0) {
            UIArtworksButtonG309.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG309) >= 1) {
            UIArtworksButtonG309.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG310) == 0) {
            UIArtworksButtonG310.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG310) >= 1) {
            UIArtworksButtonG310.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG311) == 0) {
            UIArtworksButtonG311.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG311) >= 1) {
            UIArtworksButtonG311.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG312) == 0) {
            UIArtworksButtonG312.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG312) >= 1) {
            UIArtworksButtonG312.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG313) == 0) {
            UIArtworksButtonG313.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG313) >= 1) {
            UIArtworksButtonG313.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG314) == 0) {
            UIArtworksButtonG314.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG314) >= 1) {
            UIArtworksButtonG314.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG315) == 0) {
            UIArtworksButtonG315.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseG315) >= 1) {
            UIArtworksButtonG315.color = ArtworkBoughtColorOn;
        }

        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB01) == 0) {
            UIArtworksButtonFB01.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB01) >= 1) {
            UIArtworksButtonFB01.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB02) == 0) {
            UIArtworksButtonFB02.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB02) >= 1) {
            UIArtworksButtonFB02.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB03) == 0) {
            UIArtworksButtonFB03.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB03) >= 1) {
            UIArtworksButtonFB03.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB04) == 0) {
            UIArtworksButtonFB04.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB04) >= 1) {
            UIArtworksButtonFB04.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB05) == 0) {
            UIArtworksButtonFB05.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB05) >= 1) {
            UIArtworksButtonFB05.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB06) == 0) {
            UIArtworksButtonFB06.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB06) >= 1) {
            UIArtworksButtonFB06.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB07) == 0) {
            UIArtworksButtonFB07.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB07) >= 1) {
            UIArtworksButtonFB07.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB08) == 0) {
            UIArtworksButtonFB08.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB08) >= 1) {
            UIArtworksButtonFB08.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB09) == 0) {
            UIArtworksButtonFB09.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB09) >= 1) {
            UIArtworksButtonFB09.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB10) == 0) {
            UIArtworksButtonFB10.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB10) >= 1) {
            UIArtworksButtonFB10.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB11) == 0) {
            UIArtworksButtonFB11.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB11) >= 1) {
            UIArtworksButtonFB11.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB12) == 0) {
            UIArtworksButtonFB12.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB12) >= 1) {
            UIArtworksButtonFB12.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB13) == 0) {
            UIArtworksButtonFB13.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB13) >= 1) {
            UIArtworksButtonFB13.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB14) == 0) {
            UIArtworksButtonFB14.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB14) >= 1) {
            UIArtworksButtonFB14.color = ArtworkBoughtColorOn;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB15) == 0) {
            UIArtworksButtonFB15.color = ArtworkBoughtColorOff;
        }
        
        if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB15) >= 1) {
            UIArtworksButtonFB15.color = ArtworkBoughtColorOn;
        }
    }
    
// --------------- UNLOCK BONUS ART FUNCTIONS ---------------
    public void F1BonusArtworkUnlock() {
        if (UIArtworksF1Text.enabled == true) {
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF1) < 15) {
                UIArtworksF1BonusText.enabled = false;
            }
            
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF1) >= 15) {
                UIArtworksF1BonusText.enabled = true;
            }
        }
        
        if (UIArtworksF1Text.enabled == false) {
            UIArtworksF1BonusText.enabled = false;
        }
    }
    
    public void F2BonusArtworkUnlock() {
        if (UIArtworksF2Text.enabled == true) {
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF2) < 15) {
                UIArtworksF2BonusText.enabled = false;
            }
            
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF2) >= 15) {
                UIArtworksF2BonusText.enabled = true;
            }
        }
        
        if (UIArtworksF2Text.enabled == false) {
            UIArtworksF2BonusText.enabled = false;
        }
    }
    
    public void F3BonusArtworkUnlock() {
        if (UIArtworksF3Text.enabled == true) {
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF3) < 15) {
                UIArtworksF3BonusText.enabled = false;
            }
            
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedF3) >= 15) {
                UIArtworksF3BonusText.enabled = true;
            }
        }
        
        if (UIArtworksF3Text.enabled == false) {
            UIArtworksF3BonusText.enabled = false;
        }
    }
    
    public void G1BonusArtworkUnlock() {
        if (UIArtworksG1Text.enabled == true) {
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG1) < 15) {
                UIArtworksG1BonusText.enabled = false;
            }
            
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG1) >= 15) {
                UIArtworksG1BonusText.enabled = true;
            }
        }
        
        if (UIArtworksG1Text.enabled == false) {
            UIArtworksG1BonusText.enabled = false;
        }
    }
    
    public void G2BonusArtworkUnlock() {
        if (UIArtworksG2Text.enabled == true) {
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG2) < 15) {
                UIArtworksG2BonusText.enabled = false;
            }
            
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG2) >= 15) {
                UIArtworksG2BonusText.enabled = true;
            }
        }
        
        if (UIArtworksG2Text.enabled == false) {
            UIArtworksG2BonusText.enabled = false;
        }
    }
    
    public void G3BonusArtworkUnlock() {
        if (UIArtworksG3Text.enabled == true) {
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG3) < 15) {
                UIArtworksG3BonusText.enabled = false;
            }
            
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedG3) >= 15) {
                UIArtworksG3BonusText.enabled = true;
            }
        }
        
        if (UIArtworksG3Text.enabled == false) {
            UIArtworksG3BonusText.enabled = false;
        }
    }
    
    public void FBBonusArtworkUnlock() {
        if (UIArtworksFBText.enabled == true) {
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedFB) < 15) {
                UIArtworksFBBonusText.enabled = false;
            }
            
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedFB) >= 15) {
                UIArtworksFBBonusText.enabled = true;
            }
        }
        
        if (UIArtworksFBText.enabled == false) {
            UIArtworksFBBonusText.enabled = false;
        }
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}