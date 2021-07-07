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

public class YourGallery01SceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    // Buttons
    public Button UIGalleryButtonRight;
    public Button UIGalleryButtonLeft;
    
	// Artworks
    // Page F1
	public Button UIGalleryF101;
	public Button UIGalleryF102;
	public Button UIGalleryF103;
	public Button UIGalleryF104;
	public Button UIGalleryF105;
	public Button UIGalleryF106;
	public Button UIGalleryF107;
	public Button UIGalleryF108;
	public Button UIGalleryF109;
	public Button UIGalleryF110;
	public Button UIGalleryF111;
	public Button UIGalleryF112;
	public Button UIGalleryF113;
	public Button UIGalleryF114;
	public Button UIGalleryF115;
	
	// Page F2
	public Button UIGalleryF201;
	public Button UIGalleryF202;
	public Button UIGalleryF203;
	public Button UIGalleryF204;
	public Button UIGalleryF205;
	public Button UIGalleryF206;
	public Button UIGalleryF207;
	public Button UIGalleryF208;
	public Button UIGalleryF209;
	public Button UIGalleryF210;
	public Button UIGalleryF211;
	public Button UIGalleryF212;
	public Button UIGalleryF213;
	public Button UIGalleryF214;
	public Button UIGalleryF215;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Loading
    public SceneLoad Scene45Loading;
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
        
		// F1 ------------------------------------------------------------
        // F101
        Button UIGalleryF101Click = UIGalleryF101.GetComponent<Button>();
		UIGalleryF101Click.onClick.AddListener(UIGalleryF101Clicking);
        
        // F102
        Button UIGalleryF102Click = UIGalleryF102.GetComponent<Button>();
		UIGalleryF102Click.onClick.AddListener(UIGalleryF102Clicking);
        
        // F103
        Button UIGalleryF103Click = UIGalleryF103.GetComponent<Button>();
		UIGalleryF103Click.onClick.AddListener(UIGalleryF103Clicking);
        
        // F104
        Button UIGalleryF104Click = UIGalleryF104.GetComponent<Button>();
		UIGalleryF104Click.onClick.AddListener(UIGalleryF104Clicking);
        
        // F105
        Button UIGalleryF105Click = UIGalleryF105.GetComponent<Button>();
		UIGalleryF105Click.onClick.AddListener(UIGalleryF105Clicking);
        
        // F106
        Button UIGalleryF106Click = UIGalleryF106.GetComponent<Button>();
		UIGalleryF106Click.onClick.AddListener(UIGalleryF106Clicking);
        
        // F107
        Button UIGalleryF107Click = UIGalleryF107.GetComponent<Button>();
		UIGalleryF107Click.onClick.AddListener(UIGalleryF107Clicking);
        
        // F108
        Button UIGalleryF108Click = UIGalleryF108.GetComponent<Button>();
		UIGalleryF108Click.onClick.AddListener(UIGalleryF108Clicking);
        
        // F109
        Button UIGalleryF109Click = UIGalleryF109.GetComponent<Button>();
		UIGalleryF109Click.onClick.AddListener(UIGalleryF109Clicking);
        
        // F110
        Button UIGalleryF110Click = UIGalleryF110.GetComponent<Button>();
		UIGalleryF110Click.onClick.AddListener(UIGalleryF110Clicking);
        
        // F111
        Button UIGalleryF111Click = UIGalleryF111.GetComponent<Button>();
		UIGalleryF111Click.onClick.AddListener(UIGalleryF111Clicking);
        
        // F112
        Button UIGalleryF112Click = UIGalleryF112.GetComponent<Button>();
		UIGalleryF112Click.onClick.AddListener(UIGalleryF112Clicking);
        
        // F113
        Button UIGalleryF113Click = UIGalleryF113.GetComponent<Button>();
		UIGalleryF113Click.onClick.AddListener(UIGalleryF113Clicking);
        
        // F114
        Button UIGalleryF114Click = UIGalleryF114.GetComponent<Button>();
		UIGalleryF114Click.onClick.AddListener(UIGalleryF114Clicking);
        
        // F115
        Button UIGalleryF115Click = UIGalleryF115.GetComponent<Button>();
		UIGalleryF115Click.onClick.AddListener(UIGalleryF115Clicking);
        
        // F2 ------------------------------------------------------------
        // F201
        Button UIGalleryF201Click = UIGalleryF201.GetComponent<Button>();
		UIGalleryF201Click.onClick.AddListener(UIGalleryF201Clicking);
        
        // F202
        Button UIGalleryF202Click = UIGalleryF202.GetComponent<Button>();
		UIGalleryF202Click.onClick.AddListener(UIGalleryF202Clicking);
        
        // F203
        Button UIGalleryF203Click = UIGalleryF203.GetComponent<Button>();
		UIGalleryF203Click.onClick.AddListener(UIGalleryF203Clicking);
        
        // F204
        Button UIGalleryF204Click = UIGalleryF204.GetComponent<Button>();
		UIGalleryF204Click.onClick.AddListener(UIGalleryF204Clicking);
        
        // F205
        Button UIGalleryF205Click = UIGalleryF205.GetComponent<Button>();
		UIGalleryF205Click.onClick.AddListener(UIGalleryF205Clicking);
        
        // F206
        Button UIGalleryF206Click = UIGalleryF206.GetComponent<Button>();
		UIGalleryF206Click.onClick.AddListener(UIGalleryF206Clicking);
        
        // F207
        Button UIGalleryF207Click = UIGalleryF207.GetComponent<Button>();
		UIGalleryF207Click.onClick.AddListener(UIGalleryF207Clicking);
        
        // F208
        Button UIGalleryF208Click = UIGalleryF208.GetComponent<Button>();
		UIGalleryF208Click.onClick.AddListener(UIGalleryF208Clicking);
        
        // F209
        Button UIGalleryF209Click = UIGalleryF209.GetComponent<Button>();
		UIGalleryF209Click.onClick.AddListener(UIGalleryF209Clicking);
        
        // F210
        Button UIGalleryF210Click = UIGalleryF210.GetComponent<Button>();
		UIGalleryF210Click.onClick.AddListener(UIGalleryF210Clicking);
        
        // F211
        Button UIGalleryF211Click = UIGalleryF211.GetComponent<Button>();
		UIGalleryF211Click.onClick.AddListener(UIGalleryF211Clicking);
        
        // F212
        Button UIGalleryF212Click = UIGalleryF212.GetComponent<Button>();
		UIGalleryF212Click.onClick.AddListener(UIGalleryF212Clicking);
        
        // F213
        Button UIGalleryF213Click = UIGalleryF213.GetComponent<Button>();
		UIGalleryF213Click.onClick.AddListener(UIGalleryF213Clicking);
        
        // F214
        Button UIGalleryF214Click = UIGalleryF214.GetComponent<Button>();
		UIGalleryF214Click.onClick.AddListener(UIGalleryF214Clicking);
        
        // F215
        Button UIGalleryF215Click = UIGalleryF215.GetComponent<Button>();
		UIGalleryF215Click.onClick.AddListener(UIGalleryF215Clicking);
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
        Scene42Loading.Scene42Load();
    }
    
    public void UIGalleryButtonLeftClicking() {
        Scene45Loading.Scene45Load();
    }
    
    // F1 ------------------------------------------------------------
    public void UIGalleryF101Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF101);
    }
    
    public void UIGalleryF102Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF102);
    }
    
    public void UIGalleryF103Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF103);
    }
    
    public void UIGalleryF104Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF104);
    }
    
    public void UIGalleryF105Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF105);
    }
    
    public void UIGalleryF106Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF106);
    }
    
    public void UIGalleryF107Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF107);
    }
    
    public void UIGalleryF108Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF108);
    }
    
    public void UIGalleryF109Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF109);
    }
    
    public void UIGalleryF110Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF110);
    }
    
    public void UIGalleryF111Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF111);
    }
    
    public void UIGalleryF112Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF112);
    }
    
    public void UIGalleryF113Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF113);
    }
    
    public void UIGalleryF114Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF114);
    }
    
    public void UIGalleryF115Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF115);
    }
    
    // F2 ------------------------------------------------------------
    public void UIGalleryF201Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF201);
    }
    
    public void UIGalleryF202Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF202);
    }
    
    public void UIGalleryF203Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF203);
    }
    
    public void UIGalleryF204Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF204);
    }
    
    public void UIGalleryF205Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF205);
    }
    
    public void UIGalleryF206Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF206);
    }
    
    public void UIGalleryF207Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF207);
    }
    
    public void UIGalleryF208Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF208);
    }
    
    public void UIGalleryF209Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF209);
    }
    
    public void UIGalleryF210Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF210);
    }
    
    public void UIGalleryF211Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF211);
    }
    
    public void UIGalleryF212Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF212);
    }
    
    public void UIGalleryF213Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF213);
    }
    
    public void UIGalleryF214Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF214);
    }
    
    public void UIGalleryF215Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF215);
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}