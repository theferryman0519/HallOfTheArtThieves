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

public class YourGallery04SceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    // Buttons
    public Button UIGalleryButtonRight;
    public Button UIGalleryButtonLeft;
    
	// Artworks
	// Page FB
	public Button UIGalleryFB01;
	public Button UIGalleryFB02;
	public Button UIGalleryFB03;
	public Button UIGalleryFB04;
	public Button UIGalleryFB05;
	public Button UIGalleryFB06;
	public Button UIGalleryFB07;
	public Button UIGalleryFB08;
	public Button UIGalleryFB09;
	public Button UIGalleryFB10;
	public Button UIGalleryFB11;
	public Button UIGalleryFB12;
	public Button UIGalleryFB13;
	public Button UIGalleryFB14;
	public Button UIGalleryFB15;
    
    // Page F1 Added
	public Button UIGalleryF101Added;
	public Button UIGalleryF102Added;
	public Button UIGalleryF103Added;
	public Button UIGalleryF104Added;
	public Button UIGalleryF105Added;
	public Button UIGalleryF106Added;
	public Button UIGalleryF107Added;
	public Button UIGalleryF108Added;
    
    // Page F2 Added
	public Button UIGalleryF201Added;
	public Button UIGalleryF202Added;
	public Button UIGalleryF203Added;
	public Button UIGalleryF204Added;
	public Button UIGalleryF205Added;
	public Button UIGalleryF206Added;
	public Button UIGalleryF207Added;
	public Button UIGalleryF208Added;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Loading
    public SceneLoad Scene45Loading;
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
        
        // FB ------------------------------------------------------------
        // FB01
        Button UIGalleryFB01Click = UIGalleryFB01.GetComponent<Button>();
		UIGalleryFB01Click.onClick.AddListener(UIGalleryFB01Clicking);
        
        // FB02
        Button UIGalleryFB02Click = UIGalleryFB02.GetComponent<Button>();
		UIGalleryFB02Click.onClick.AddListener(UIGalleryFB02Clicking);
        
        // FB03
        Button UIGalleryFB03Click = UIGalleryFB03.GetComponent<Button>();
		UIGalleryFB03Click.onClick.AddListener(UIGalleryFB03Clicking);
        
        // FB04
        Button UIGalleryFB04Click = UIGalleryFB04.GetComponent<Button>();
		UIGalleryFB04Click.onClick.AddListener(UIGalleryFB04Clicking);
        
        // FB05
        Button UIGalleryFB05Click = UIGalleryFB05.GetComponent<Button>();
		UIGalleryFB05Click.onClick.AddListener(UIGalleryFB05Clicking);
        
        // FB06
        Button UIGalleryFB06Click = UIGalleryFB06.GetComponent<Button>();
		UIGalleryFB06Click.onClick.AddListener(UIGalleryFB06Clicking);
        
        // FB07
        Button UIGalleryFB07Click = UIGalleryFB07.GetComponent<Button>();
		UIGalleryFB07Click.onClick.AddListener(UIGalleryFB07Clicking);
        
        // FB08
        Button UIGalleryFB08Click = UIGalleryFB08.GetComponent<Button>();
		UIGalleryFB08Click.onClick.AddListener(UIGalleryFB08Clicking);
        
        // FB09
        Button UIGalleryFB09Click = UIGalleryFB09.GetComponent<Button>();
		UIGalleryFB09Click.onClick.AddListener(UIGalleryFB09Clicking);
        
        // FB10
        Button UIGalleryFB10Click = UIGalleryFB10.GetComponent<Button>();
		UIGalleryFB10Click.onClick.AddListener(UIGalleryFB10Clicking);
        
        // FB11
        Button UIGalleryFB11Click = UIGalleryFB11.GetComponent<Button>();
		UIGalleryFB11Click.onClick.AddListener(UIGalleryFB11Clicking);
        
        // FB12
        Button UIGalleryFB12Click = UIGalleryFB12.GetComponent<Button>();
		UIGalleryFB12Click.onClick.AddListener(UIGalleryFB12Clicking);
        
        // FB13
        Button UIGalleryFB13Click = UIGalleryFB13.GetComponent<Button>();
		UIGalleryFB13Click.onClick.AddListener(UIGalleryFB13Clicking);
        
        // FB14
        Button UIGalleryFB14Click = UIGalleryFB14.GetComponent<Button>();
		UIGalleryFB14Click.onClick.AddListener(UIGalleryFB14Clicking);
        
        // FB15
        Button UIGalleryFB15Click = UIGalleryFB15.GetComponent<Button>();
		UIGalleryFB15Click.onClick.AddListener(UIGalleryFB15Clicking);
        
        // F1 Added ------------------------------------------------------------
        // F101Added
        Button UIGalleryF101AddedClick = UIGalleryF101Added.GetComponent<Button>();
		UIGalleryF101AddedClick.onClick.AddListener(UIGalleryF101AddedClicking);
        
        // F102Added
        Button UIGalleryF102AddedClick = UIGalleryF102Added.GetComponent<Button>();
		UIGalleryF102AddedClick.onClick.AddListener(UIGalleryF102AddedClicking);
        
        // F103Added
        Button UIGalleryF103AddedClick = UIGalleryF103Added.GetComponent<Button>();
		UIGalleryF103AddedClick.onClick.AddListener(UIGalleryF103AddedClicking);
        
        // F104Added
        Button UIGalleryF104AddedClick = UIGalleryF104Added.GetComponent<Button>();
		UIGalleryF104AddedClick.onClick.AddListener(UIGalleryF104AddedClicking);
        
        // F105Added
        Button UIGalleryF105AddedClick = UIGalleryF105Added.GetComponent<Button>();
		UIGalleryF105AddedClick.onClick.AddListener(UIGalleryF105AddedClicking);
        
        // F106Added
        Button UIGalleryF106AddedClick = UIGalleryF106Added.GetComponent<Button>();
		UIGalleryF106AddedClick.onClick.AddListener(UIGalleryF106AddedClicking);
        
        // F107Added
        Button UIGalleryF107AddedClick = UIGalleryF107Added.GetComponent<Button>();
		UIGalleryF107AddedClick.onClick.AddListener(UIGalleryF107AddedClicking);
        
        // F108Added
        Button UIGalleryF108AddedClick = UIGalleryF108Added.GetComponent<Button>();
		UIGalleryF108AddedClick.onClick.AddListener(UIGalleryF108AddedClicking);
        
        // F2 Added ------------------------------------------------------------
        // F201Added
        Button UIGalleryF201AddedClick = UIGalleryF201Added.GetComponent<Button>();
		UIGalleryF201AddedClick.onClick.AddListener(UIGalleryF201AddedClicking);
        
        // F202Added
        Button UIGalleryF202AddedClick = UIGalleryF202Added.GetComponent<Button>();
		UIGalleryF202AddedClick.onClick.AddListener(UIGalleryF202AddedClicking);
        
        // F203Added
        Button UIGalleryF203AddedClick = UIGalleryF203Added.GetComponent<Button>();
		UIGalleryF203AddedClick.onClick.AddListener(UIGalleryF203AddedClicking);
        
        // F204Added
        Button UIGalleryF204AddedClick = UIGalleryF204Added.GetComponent<Button>();
		UIGalleryF204AddedClick.onClick.AddListener(UIGalleryF204AddedClicking);
        
        // F205Added
        Button UIGalleryF205AddedClick = UIGalleryF205Added.GetComponent<Button>();
		UIGalleryF205AddedClick.onClick.AddListener(UIGalleryF205AddedClicking);
        
        // F206Added
        Button UIGalleryF206AddedClick = UIGalleryF206Added.GetComponent<Button>();
		UIGalleryF206AddedClick.onClick.AddListener(UIGalleryF206AddedClicking);
        
        // F207Added
        Button UIGalleryF207AddedClick = UIGalleryF207Added.GetComponent<Button>();
		UIGalleryF207AddedClick.onClick.AddListener(UIGalleryF207AddedClicking);
        
        // F208Added
        Button UIGalleryF208AddedClick = UIGalleryF208Added.GetComponent<Button>();
		UIGalleryF208AddedClick.onClick.AddListener(UIGalleryF208AddedClicking);
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
        Scene45Loading.Scene45Load();
    }
    
    public void UIGalleryButtonLeftClicking() {
        Scene43Loading.Scene43Load();
    }
    
    // FB ------------------------------------------------------------
    public void UIGalleryFB01Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB01);
    }
    
    public void UIGalleryFB02Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB02);
    }
    
    public void UIGalleryFB03Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB03);
    }
    
    public void UIGalleryFB04Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB04);
    }
    
    public void UIGalleryFB05Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB05);
    }
    
    public void UIGalleryFB06Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB06);
    }
    
    public void UIGalleryFB07Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB07);
    }
    
    public void UIGalleryFB08Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB08);
    }
    
    public void UIGalleryFB09Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB09);
    }
    
    public void UIGalleryFB10Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB10);
    }
    
    public void UIGalleryFB11Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB11);
    }
    
    public void UIGalleryFB12Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB12);
    }
    
    public void UIGalleryFB13Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB13);
    }
    
    public void UIGalleryFB14Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB14);
    }
    
    public void UIGalleryFB15Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB15);
    }
    
    // F1 Added ------------------------------------------------------------
    public void UIGalleryF101AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF101Added);
    }
    
    public void UIGalleryF102AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF102Added);
    }
    
    public void UIGalleryF103AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF103Added);
    }
    
    public void UIGalleryF104AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF104Added);
    }
    
    public void UIGalleryF105AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF105Added);
    }
    
    public void UIGalleryF106AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF106Added);
    }
    
    public void UIGalleryF107AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF107Added);
    }
    
    public void UIGalleryF108AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF108Added);
    }
    
    // F2 Added ------------------------------------------------------------
    public void UIGalleryF201AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF201Added);
    }
    
    public void UIGalleryF202AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF202Added);
    }
    
    public void UIGalleryF203AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF203Added);
    }
    
    public void UIGalleryF204AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF204Added);
    }
    
    public void UIGalleryF205AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF205Added);
    }
    
    public void UIGalleryF206AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF206Added);
    }
    
    public void UIGalleryF207AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF207Added);
    }
    
    public void UIGalleryF208AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF208Added);
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}