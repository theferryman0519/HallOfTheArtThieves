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

public class YourGallery02SceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    // Buttons
    public Button UIGalleryButtonRight;
    public Button UIGalleryButtonLeft;
    
	// Artworks
	// Page F3
	public Button UIGalleryF301;
	public Button UIGalleryF302;
	public Button UIGalleryF303;
	public Button UIGalleryF304;
	public Button UIGalleryF305;
	public Button UIGalleryF306;
	public Button UIGalleryF307;
	public Button UIGalleryF308;
	public Button UIGalleryF309;
	public Button UIGalleryF310;
	public Button UIGalleryF311;
	public Button UIGalleryF312;
	public Button UIGalleryF313;
	public Button UIGalleryF314;
	public Button UIGalleryF315;
	
	// Page G1
	public Button UIGalleryG101;
	public Button UIGalleryG102;
	public Button UIGalleryG103;
	public Button UIGalleryG104;
	public Button UIGalleryG105;
	public Button UIGalleryG106;
	public Button UIGalleryG107;
	public Button UIGalleryG108;
	public Button UIGalleryG109;
	public Button UIGalleryG110;
	public Button UIGalleryG111;
	public Button UIGalleryG112;
	public Button UIGalleryG113;
	public Button UIGalleryG114;
	public Button UIGalleryG115;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Loading
    public SceneLoad Scene41Loading;
    public SceneLoad Scene43Loading;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        // Buttons ------------------------------------------------------------
        Button UIGalleryButtonRightClick = UIGalleryButtonRight.GetComponent<Button>();
		UIGalleryButtonRightClick.onClick.AddListener(UIGalleryButtonRightClicking);
        
        Button UIGalleryButtonLeftClick = UIGalleryButtonLeft.GetComponent<Button>();
		UIGalleryButtonLeftClick.onClick.AddListener(UIGalleryButtonLeftClicking);
        
        // F3 ------------------------------------------------------------
        // F301
        Button UIGalleryF301Click = UIGalleryF301.GetComponent<Button>();
		UIGalleryF301Click.onClick.AddListener(UIGalleryF301Clicking);
        
        // F302
        Button UIGalleryF302Click = UIGalleryF302.GetComponent<Button>();
		UIGalleryF302Click.onClick.AddListener(UIGalleryF302Clicking);
        
        // F303
        Button UIGalleryF303Click = UIGalleryF303.GetComponent<Button>();
		UIGalleryF303Click.onClick.AddListener(UIGalleryF303Clicking);
        
        // F304
        Button UIGalleryF304Click = UIGalleryF304.GetComponent<Button>();
		UIGalleryF304Click.onClick.AddListener(UIGalleryF304Clicking);
        
        // F305
        Button UIGalleryF305Click = UIGalleryF305.GetComponent<Button>();
		UIGalleryF305Click.onClick.AddListener(UIGalleryF305Clicking);
        
        // F306
        Button UIGalleryF306Click = UIGalleryF306.GetComponent<Button>();
		UIGalleryF306Click.onClick.AddListener(UIGalleryF306Clicking);
        
        // F307
        Button UIGalleryF307Click = UIGalleryF307.GetComponent<Button>();
		UIGalleryF307Click.onClick.AddListener(UIGalleryF307Clicking);
        
        // F308
        Button UIGalleryF308Click = UIGalleryF308.GetComponent<Button>();
		UIGalleryF308Click.onClick.AddListener(UIGalleryF308Clicking);
        
        // F309
        Button UIGalleryF309Click = UIGalleryF309.GetComponent<Button>();
		UIGalleryF309Click.onClick.AddListener(UIGalleryF309Clicking);
        
        // F310
        Button UIGalleryF310Click = UIGalleryF310.GetComponent<Button>();
		UIGalleryF310Click.onClick.AddListener(UIGalleryF310Clicking);
        
        // F311
        Button UIGalleryF311Click = UIGalleryF311.GetComponent<Button>();
		UIGalleryF311Click.onClick.AddListener(UIGalleryF311Clicking);
        
        // F312
        Button UIGalleryF312Click = UIGalleryF312.GetComponent<Button>();
		UIGalleryF312Click.onClick.AddListener(UIGalleryF312Clicking);
        
        // F313
        Button UIGalleryF313Click = UIGalleryF313.GetComponent<Button>();
		UIGalleryF313Click.onClick.AddListener(UIGalleryF313Clicking);
        
        // F314
        Button UIGalleryF314Click = UIGalleryF314.GetComponent<Button>();
		UIGalleryF314Click.onClick.AddListener(UIGalleryF314Clicking);
        
        // F315
        Button UIGalleryF315Click = UIGalleryF315.GetComponent<Button>();
		UIGalleryF315Click.onClick.AddListener(UIGalleryF315Clicking);
        
        // G1 ------------------------------------------------------------
        // G101
        Button UIGalleryG101Click = UIGalleryG101.GetComponent<Button>();
		UIGalleryG101Click.onClick.AddListener(UIGalleryG101Clicking);
        
        // G102
        Button UIGalleryG102Click = UIGalleryG102.GetComponent<Button>();
		UIGalleryG102Click.onClick.AddListener(UIGalleryG102Clicking);
        
        // G103
        Button UIGalleryG103Click = UIGalleryG103.GetComponent<Button>();
		UIGalleryG103Click.onClick.AddListener(UIGalleryG103Clicking);
        
        // G104
        Button UIGalleryG104Click = UIGalleryG104.GetComponent<Button>();
		UIGalleryG104Click.onClick.AddListener(UIGalleryG104Clicking);
        
        // G105
        Button UIGalleryG105Click = UIGalleryG105.GetComponent<Button>();
		UIGalleryG105Click.onClick.AddListener(UIGalleryG105Clicking);
        
        // G106
        Button UIGalleryG106Click = UIGalleryG106.GetComponent<Button>();
		UIGalleryG106Click.onClick.AddListener(UIGalleryG106Clicking);
        
        // G107
        Button UIGalleryG107Click = UIGalleryG107.GetComponent<Button>();
		UIGalleryG107Click.onClick.AddListener(UIGalleryG107Clicking);
        
        // G108
        Button UIGalleryG108Click = UIGalleryG108.GetComponent<Button>();
		UIGalleryG108Click.onClick.AddListener(UIGalleryG108Clicking);
        
        // G109
        Button UIGalleryG109Click = UIGalleryG109.GetComponent<Button>();
		UIGalleryG109Click.onClick.AddListener(UIGalleryG109Clicking);
        
        // G110
        Button UIGalleryG110Click = UIGalleryG110.GetComponent<Button>();
		UIGalleryG110Click.onClick.AddListener(UIGalleryG110Clicking);
        
        // G111
        Button UIGalleryG111Click = UIGalleryG111.GetComponent<Button>();
		UIGalleryG111Click.onClick.AddListener(UIGalleryG111Clicking);
        
        // G112
        Button UIGalleryG112Click = UIGalleryG112.GetComponent<Button>();
		UIGalleryG112Click.onClick.AddListener(UIGalleryG112Clicking);
        
        // G113
        Button UIGalleryG113Click = UIGalleryG113.GetComponent<Button>();
		UIGalleryG113Click.onClick.AddListener(UIGalleryG113Clicking);
        
        // G114
        Button UIGalleryG114Click = UIGalleryG114.GetComponent<Button>();
		UIGalleryG114Click.onClick.AddListener(UIGalleryG114Clicking);
        
        // G115
        Button UIGalleryG115Click = UIGalleryG115.GetComponent<Button>();
		UIGalleryG115Click.onClick.AddListener(UIGalleryG115Clicking);
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
        Scene43Loading.Scene43Load();
    }
    
    public void UIGalleryButtonLeftClicking() {
        Scene41Loading.Scene41Load();
    }
    
    // F3 ------------------------------------------------------------
    public void UIGalleryF301Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF301);
    }
    
    public void UIGalleryF302Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF302);
    }
    
    public void UIGalleryF303Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF303);
    }
    
    public void UIGalleryF304Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF304);
    }
    
    public void UIGalleryF305Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF305);
    }
    
    public void UIGalleryF306Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF306);
    }
    
    public void UIGalleryF307Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF307);
    }
    
    public void UIGalleryF308Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF308);
    }
    
    public void UIGalleryF309Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF309);
    }
    
    public void UIGalleryF310Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF310);
    }
    
    public void UIGalleryF311Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF311);
    }
    
    public void UIGalleryF312Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF312);
    }
    
    public void UIGalleryF313Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF313);
    }
    
    public void UIGalleryF314Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF314);
    }
    
    public void UIGalleryF315Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF315);
    }
    
    // G1 ------------------------------------------------------------
    public void UIGalleryG101Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG101);
    }
    
    public void UIGalleryG102Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG102);
    }
    
    public void UIGalleryG103Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG103);
    }
    
    public void UIGalleryG104Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG104);
    }
    
    public void UIGalleryG105Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG105);
    }
    
    public void UIGalleryG106Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG106);
    }
    
    public void UIGalleryG107Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG107);
    }
    
    public void UIGalleryG108Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG108);
    }
    
    public void UIGalleryG109Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG109);
    }
    
    public void UIGalleryG110Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG110);
    }
    
    public void UIGalleryG111Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG111);
    }
    
    public void UIGalleryG112Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG112);
    }
    
    public void UIGalleryG113Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG113);
    }
    
    public void UIGalleryG114Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG114);
    }
    
    public void UIGalleryG115Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG115);
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}