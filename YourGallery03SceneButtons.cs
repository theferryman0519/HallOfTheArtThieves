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

public class YourGallery03SceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    // Buttons
    public Button UIGalleryButtonRight;
    public Button UIGalleryButtonLeft;
    
	// Artworks
	// Page G2
	public Button UIGalleryG201;
	public Button UIGalleryG202;
	public Button UIGalleryG203;
	public Button UIGalleryG204;
	public Button UIGalleryG205;
	public Button UIGalleryG206;
	public Button UIGalleryG207;
	public Button UIGalleryG208;
	public Button UIGalleryG209;
	public Button UIGalleryG210;
	public Button UIGalleryG211;
	public Button UIGalleryG212;
	public Button UIGalleryG213;
	public Button UIGalleryG214;
	public Button UIGalleryG215;
    
    // Page G3
	public Button UIGalleryG301;
	public Button UIGalleryG302;
	public Button UIGalleryG303;
	public Button UIGalleryG304;
	public Button UIGalleryG305;
	public Button UIGalleryG306;
	public Button UIGalleryG307;
	public Button UIGalleryG308;
	public Button UIGalleryG309;
	public Button UIGalleryG310;
	public Button UIGalleryG311;
	public Button UIGalleryG312;
	public Button UIGalleryG313;
	public Button UIGalleryG314;
	public Button UIGalleryG315;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Loading
    public SceneLoad Scene44Loading;
    public SceneLoad Scene42Loading;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        // Buttons ------------------------------------------------------------
        Button UIGalleryButtonRightClick = UIGalleryButtonRight.GetComponent<Button>();
		UIGalleryButtonRightClick.onClick.AddListener(UIGalleryButtonRightClicking);
        
        Button UIGalleryButtonLeftClick = UIGalleryButtonLeft.GetComponent<Button>();
		UIGalleryButtonLeftClick.onClick.AddListener(UIGalleryButtonLeftClicking);
        
        // G2 ------------------------------------------------------------
        // G201
        Button UIGalleryG201Click = UIGalleryG201.GetComponent<Button>();
		UIGalleryG201Click.onClick.AddListener(UIGalleryG201Clicking);
        
        // G202
        Button UIGalleryG202Click = UIGalleryG202.GetComponent<Button>();
		UIGalleryG202Click.onClick.AddListener(UIGalleryG202Clicking);
        
        // G203
        Button UIGalleryG203Click = UIGalleryG203.GetComponent<Button>();
		UIGalleryG203Click.onClick.AddListener(UIGalleryG203Clicking);
        
        // G204
        Button UIGalleryG204Click = UIGalleryG204.GetComponent<Button>();
		UIGalleryG204Click.onClick.AddListener(UIGalleryG204Clicking);
        
        // G205
        Button UIGalleryG205Click = UIGalleryG205.GetComponent<Button>();
		UIGalleryG205Click.onClick.AddListener(UIGalleryG205Clicking);
        
        // G206
        Button UIGalleryG206Click = UIGalleryG206.GetComponent<Button>();
		UIGalleryG206Click.onClick.AddListener(UIGalleryG206Clicking);
        
        // G207
        Button UIGalleryG207Click = UIGalleryG207.GetComponent<Button>();
		UIGalleryG207Click.onClick.AddListener(UIGalleryG207Clicking);
        
        // G208
        Button UIGalleryG208Click = UIGalleryG208.GetComponent<Button>();
		UIGalleryG208Click.onClick.AddListener(UIGalleryG208Clicking);
        
        // G209
        Button UIGalleryG209Click = UIGalleryG209.GetComponent<Button>();
		UIGalleryG209Click.onClick.AddListener(UIGalleryG209Clicking);
        
        // G210
        Button UIGalleryG210Click = UIGalleryG210.GetComponent<Button>();
		UIGalleryG210Click.onClick.AddListener(UIGalleryG210Clicking);
        
        // G211
        Button UIGalleryG211Click = UIGalleryG211.GetComponent<Button>();
		UIGalleryG211Click.onClick.AddListener(UIGalleryG211Clicking);
        
        // G212
        Button UIGalleryG212Click = UIGalleryG212.GetComponent<Button>();
		UIGalleryG212Click.onClick.AddListener(UIGalleryG212Clicking);
        
        // G213
        Button UIGalleryG213Click = UIGalleryG213.GetComponent<Button>();
		UIGalleryG213Click.onClick.AddListener(UIGalleryG213Clicking);
        
        // G214
        Button UIGalleryG214Click = UIGalleryG214.GetComponent<Button>();
		UIGalleryG214Click.onClick.AddListener(UIGalleryG214Clicking);
        
        // G215
        Button UIGalleryG215Click = UIGalleryG215.GetComponent<Button>();
		UIGalleryG215Click.onClick.AddListener(UIGalleryG215Clicking);
        
        // G3 ------------------------------------------------------------
        // G301
        Button UIGalleryG301Click = UIGalleryG301.GetComponent<Button>();
		UIGalleryG301Click.onClick.AddListener(UIGalleryG301Clicking);
        
        // G302
        Button UIGalleryG302Click = UIGalleryG302.GetComponent<Button>();
		UIGalleryG302Click.onClick.AddListener(UIGalleryG302Clicking);
        
        // G303
        Button UIGalleryG303Click = UIGalleryG303.GetComponent<Button>();
		UIGalleryG303Click.onClick.AddListener(UIGalleryG303Clicking);
        
        // G304
        Button UIGalleryG304Click = UIGalleryG304.GetComponent<Button>();
		UIGalleryG304Click.onClick.AddListener(UIGalleryG304Clicking);
        
        // G305
        Button UIGalleryG305Click = UIGalleryG305.GetComponent<Button>();
		UIGalleryG305Click.onClick.AddListener(UIGalleryG305Clicking);
        
        // G306
        Button UIGalleryG306Click = UIGalleryG306.GetComponent<Button>();
		UIGalleryG306Click.onClick.AddListener(UIGalleryG306Clicking);
        
        // G307
        Button UIGalleryG307Click = UIGalleryG307.GetComponent<Button>();
		UIGalleryG307Click.onClick.AddListener(UIGalleryG307Clicking);
        
        // G308
        Button UIGalleryG308Click = UIGalleryG308.GetComponent<Button>();
		UIGalleryG308Click.onClick.AddListener(UIGalleryG308Clicking);
        
        // G309
        Button UIGalleryG309Click = UIGalleryG309.GetComponent<Button>();
		UIGalleryG309Click.onClick.AddListener(UIGalleryG309Clicking);
        
        // G310
        Button UIGalleryG310Click = UIGalleryG310.GetComponent<Button>();
		UIGalleryG310Click.onClick.AddListener(UIGalleryG310Clicking);
        
        // G311
        Button UIGalleryG311Click = UIGalleryG311.GetComponent<Button>();
		UIGalleryG311Click.onClick.AddListener(UIGalleryG311Clicking);
        
        // G312
        Button UIGalleryG312Click = UIGalleryG312.GetComponent<Button>();
		UIGalleryG312Click.onClick.AddListener(UIGalleryG312Clicking);
        
        // G313
        Button UIGalleryG313Click = UIGalleryG313.GetComponent<Button>();
		UIGalleryG313Click.onClick.AddListener(UIGalleryG313Clicking);
        
        // G314
        Button UIGalleryG314Click = UIGalleryG314.GetComponent<Button>();
		UIGalleryG314Click.onClick.AddListener(UIGalleryG314Clicking);
        
        // G315
        Button UIGalleryG315Click = UIGalleryG315.GetComponent<Button>();
		UIGalleryG315Click.onClick.AddListener(UIGalleryG315Clicking);
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
    // Buttons ------------------------------------------------------------
    public void UIGalleryButtonRightClicking() {
        Scene44Loading.Scene44Load();
    }
    
    public void UIGalleryButtonLeftClicking() {
        Scene42Loading.Scene42Load();
    }
    
    // G2 ------------------------------------------------------------
    public void UIGalleryG201Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG201);
    }
    
    public void UIGalleryG202Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG202);
    }
    
    public void UIGalleryG203Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG203);
    }
    
    public void UIGalleryG204Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG204);
    }
    
    public void UIGalleryG205Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG205);
    }
    
    public void UIGalleryG206Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG206);
    }
    
    public void UIGalleryG207Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG207);
    }
    
    public void UIGalleryG208Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG208);
    }
    
    public void UIGalleryG209Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG209);
    }
    
    public void UIGalleryG210Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG210);
    }
    
    public void UIGalleryG211Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG211);
    }
    
    public void UIGalleryG212Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG212);
    }
    
    public void UIGalleryG213Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG213);
    }
    
    public void UIGalleryG214Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG214);
    }
    
    public void UIGalleryG215Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG215);
    }
    
    // G3 ------------------------------------------------------------
    public void UIGalleryG301Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG301);
    }
    
    public void UIGalleryG302Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG302);
    }
    
    public void UIGalleryG303Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG303);
    }
    
    public void UIGalleryG304Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG304);
    }
    
    public void UIGalleryG305Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG305);
    }
    
    public void UIGalleryG306Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG306);
    }
    
    public void UIGalleryG307Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG307);
    }
    
    public void UIGalleryG308Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG308);
    }
    
    public void UIGalleryG309Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG309);
    }
    
    public void UIGalleryG310Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG310);
    }
    
    public void UIGalleryG311Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG311);
    }
    
    public void UIGalleryG312Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG312);
    }
    
    public void UIGalleryG313Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG313);
    }
    
    public void UIGalleryG314Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG314);
    }
    
    public void UIGalleryG315Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG315);
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}