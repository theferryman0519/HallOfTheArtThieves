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

public class YourGallery05SceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    // Buttons
    public Button UIGalleryButtonRight;
    public Button UIGalleryButtonLeft;
    
	// Artworks
    // Page F3 Added
	public Button UIGalleryF301Added;
	public Button UIGalleryF302Added;
	public Button UIGalleryF303Added;
	public Button UIGalleryF304Added;
	public Button UIGalleryF305Added;
	public Button UIGalleryF306Added;
	public Button UIGalleryF307Added;
	public Button UIGalleryF308Added;
    
    // Page G1 Added
	public Button UIGalleryG101Added;
	public Button UIGalleryG102Added;
	public Button UIGalleryG103Added;
	public Button UIGalleryG104Added;
	public Button UIGalleryG105Added;
	public Button UIGalleryG106Added;
	public Button UIGalleryG107Added;
	public Button UIGalleryG108Added;
    
    // Page G2 Added
	public Button UIGalleryG201Added;
	public Button UIGalleryG202Added;
	public Button UIGalleryG203Added;
	public Button UIGalleryG204Added;
	public Button UIGalleryG205Added;
	public Button UIGalleryG206Added;
	public Button UIGalleryG207Added;
	public Button UIGalleryG208Added;
    
    // Page G3 Added
	public Button UIGalleryG301Added;
	public Button UIGalleryG302Added;
	public Button UIGalleryG303Added;
	public Button UIGalleryG304Added;
	public Button UIGalleryG305Added;
	public Button UIGalleryG306Added;
	public Button UIGalleryG307Added;
	public Button UIGalleryG308Added;
    
    // Page FB Added
	public Button UIGalleryFB01Added;
	public Button UIGalleryFB02Added;
	public Button UIGalleryFB03Added;
	public Button UIGalleryFB04Added;
	public Button UIGalleryFB05Added;
	public Button UIGalleryFB06Added;
	public Button UIGalleryFB07Added;
	public Button UIGalleryFB08Added;
    public Button UIGalleryFB09Added;
	public Button UIGalleryFB10Added;
    
    // Page FBonus Added
	public Button UIGalleryFBonus01;
	public Button UIGalleryFBonus02;
	public Button UIGalleryFBonus03;
	public Button UIGalleryFBonus04;
	public Button UIGalleryFBonus05;
	public Button UIGalleryFBonus06;
	public Button UIGalleryFBonus07;
	public Button UIGalleryFBonus08;
    public Button UIGalleryFBonus09;
	public Button UIGalleryFBonus10;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Scene Loading
    public SceneLoad Scene44Loading;
    public SceneLoad Scene41Loading;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        // Buttons ------------------------------------------------------------
        Button UIGalleryButtonRightClick = UIGalleryButtonRight.GetComponent<Button>();
		UIGalleryButtonRightClick.onClick.AddListener(UIGalleryButtonRightClicking);
        
        Button UIGalleryButtonLeftClick = UIGalleryButtonLeft.GetComponent<Button>();
		UIGalleryButtonLeftClick.onClick.AddListener(UIGalleryButtonLeftClicking);
        
        // F3 Added ------------------------------------------------------------
        // F301Added
        Button UIGalleryF301AddedClick = UIGalleryF301Added.GetComponent<Button>();
		UIGalleryF301AddedClick.onClick.AddListener(UIGalleryF301AddedClicking);
        
        // F302Added
        Button UIGalleryF302AddedClick = UIGalleryF302Added.GetComponent<Button>();
		UIGalleryF302AddedClick.onClick.AddListener(UIGalleryF302AddedClicking);
        
        // F303Added
        Button UIGalleryF303AddedClick = UIGalleryF303Added.GetComponent<Button>();
		UIGalleryF303AddedClick.onClick.AddListener(UIGalleryF303AddedClicking);
        
        // F304Added
        Button UIGalleryF304AddedClick = UIGalleryF304Added.GetComponent<Button>();
		UIGalleryF304AddedClick.onClick.AddListener(UIGalleryF304AddedClicking);
        
        // F305Added
        Button UIGalleryF305AddedClick = UIGalleryF305Added.GetComponent<Button>();
		UIGalleryF305AddedClick.onClick.AddListener(UIGalleryF305AddedClicking);
        
        // F306Added
        Button UIGalleryF306AddedClick = UIGalleryF306Added.GetComponent<Button>();
		UIGalleryF306AddedClick.onClick.AddListener(UIGalleryF306AddedClicking);
        
        // F307Added
        Button UIGalleryF307AddedClick = UIGalleryF307Added.GetComponent<Button>();
		UIGalleryF307AddedClick.onClick.AddListener(UIGalleryF307AddedClicking);
        
        // F308Added
        Button UIGalleryF308AddedClick = UIGalleryF308Added.GetComponent<Button>();
		UIGalleryF308AddedClick.onClick.AddListener(UIGalleryF308AddedClicking);
        
        // G1 Added ------------------------------------------------------------
        // G101Added
        Button UIGalleryG101AddedClick = UIGalleryG101Added.GetComponent<Button>();
		UIGalleryG101AddedClick.onClick.AddListener(UIGalleryG101AddedClicking);
        
        // G102Added
        Button UIGalleryG102AddedClick = UIGalleryG102Added.GetComponent<Button>();
		UIGalleryG102AddedClick.onClick.AddListener(UIGalleryG102AddedClicking);
        
        // G103Added
        Button UIGalleryG103AddedClick = UIGalleryG103Added.GetComponent<Button>();
		UIGalleryG103AddedClick.onClick.AddListener(UIGalleryG103AddedClicking);
        
        // G104Added
        Button UIGalleryG104AddedClick = UIGalleryG104Added.GetComponent<Button>();
		UIGalleryG104AddedClick.onClick.AddListener(UIGalleryG104AddedClicking);
        
        // G105Added
        Button UIGalleryG105AddedClick = UIGalleryG105Added.GetComponent<Button>();
		UIGalleryG105AddedClick.onClick.AddListener(UIGalleryG105AddedClicking);
        
        // G106Added
        Button UIGalleryG106AddedClick = UIGalleryG106Added.GetComponent<Button>();
		UIGalleryG106AddedClick.onClick.AddListener(UIGalleryG106AddedClicking);
        
        // G107Added
        Button UIGalleryG107AddedClick = UIGalleryG107Added.GetComponent<Button>();
		UIGalleryG107AddedClick.onClick.AddListener(UIGalleryG107AddedClicking);
        
        // G108Added
        Button UIGalleryG108AddedClick = UIGalleryG108Added.GetComponent<Button>();
		UIGalleryG108AddedClick.onClick.AddListener(UIGalleryG108AddedClicking);
        
        // G2 Added ------------------------------------------------------------
        // G201Added
        Button UIGalleryG201AddedClick = UIGalleryG201Added.GetComponent<Button>();
		UIGalleryG201AddedClick.onClick.AddListener(UIGalleryG201AddedClicking);
        
        // G202Added
        Button UIGalleryG202AddedClick = UIGalleryG202Added.GetComponent<Button>();
		UIGalleryG202AddedClick.onClick.AddListener(UIGalleryG202AddedClicking);
        
        // G203Added
        Button UIGalleryG203AddedClick = UIGalleryG203Added.GetComponent<Button>();
		UIGalleryG203AddedClick.onClick.AddListener(UIGalleryG203AddedClicking);
        
        // G204Added
        Button UIGalleryG204AddedClick = UIGalleryG204Added.GetComponent<Button>();
		UIGalleryG204AddedClick.onClick.AddListener(UIGalleryG204AddedClicking);
        
        // G205Added
        Button UIGalleryG205AddedClick = UIGalleryG205Added.GetComponent<Button>();
		UIGalleryG205AddedClick.onClick.AddListener(UIGalleryG205AddedClicking);
        
        // G206Added
        Button UIGalleryG206AddedClick = UIGalleryG206Added.GetComponent<Button>();
		UIGalleryG206AddedClick.onClick.AddListener(UIGalleryG206AddedClicking);
        
        // G207Added
        Button UIGalleryG207AddedClick = UIGalleryG207Added.GetComponent<Button>();
		UIGalleryG207AddedClick.onClick.AddListener(UIGalleryG207AddedClicking);
        
        // G208Added
        Button UIGalleryG208AddedClick = UIGalleryG208Added.GetComponent<Button>();
		UIGalleryG208AddedClick.onClick.AddListener(UIGalleryG208AddedClicking);
        
        // G3 Added ------------------------------------------------------------
        // G301Added
        Button UIGalleryG301AddedClick = UIGalleryG301Added.GetComponent<Button>();
		UIGalleryG301AddedClick.onClick.AddListener(UIGalleryG301AddedClicking);
        
        // G302Added
        Button UIGalleryG302AddedClick = UIGalleryG302Added.GetComponent<Button>();
		UIGalleryG302AddedClick.onClick.AddListener(UIGalleryG302AddedClicking);
        
        // G303Added
        Button UIGalleryG303AddedClick = UIGalleryG303Added.GetComponent<Button>();
		UIGalleryG303AddedClick.onClick.AddListener(UIGalleryG303AddedClicking);
        
        // G304Added
        Button UIGalleryG304AddedClick = UIGalleryG304Added.GetComponent<Button>();
		UIGalleryG304AddedClick.onClick.AddListener(UIGalleryG304AddedClicking);
        
        // G305Added
        Button UIGalleryG305AddedClick = UIGalleryG305Added.GetComponent<Button>();
		UIGalleryG305AddedClick.onClick.AddListener(UIGalleryG305AddedClicking);
        
        // G306Added
        Button UIGalleryG306AddedClick = UIGalleryG306Added.GetComponent<Button>();
		UIGalleryG306AddedClick.onClick.AddListener(UIGalleryG306AddedClicking);
        
        // G307Added
        Button UIGalleryG307AddedClick = UIGalleryG307Added.GetComponent<Button>();
		UIGalleryG307AddedClick.onClick.AddListener(UIGalleryG307AddedClicking);
        
        // G308Added
        Button UIGalleryG308AddedClick = UIGalleryG308Added.GetComponent<Button>();
		UIGalleryG308AddedClick.onClick.AddListener(UIGalleryG308AddedClicking);
        
        // FB Added ------------------------------------------------------------
        // FB01Added
        Button UIGalleryFB01AddedClick = UIGalleryFB01Added.GetComponent<Button>();
		UIGalleryFB01AddedClick.onClick.AddListener(UIGalleryFB01AddedClicking);
        
        // FB02Added
        Button UIGalleryFB02AddedClick = UIGalleryFB02Added.GetComponent<Button>();
		UIGalleryFB02AddedClick.onClick.AddListener(UIGalleryFB02AddedClicking);
        
        // FB03Added
        Button UIGalleryFB03AddedClick = UIGalleryFB03Added.GetComponent<Button>();
		UIGalleryFB03AddedClick.onClick.AddListener(UIGalleryFB03AddedClicking);
        
        // FB04Added
        Button UIGalleryFB04AddedClick = UIGalleryFB04Added.GetComponent<Button>();
		UIGalleryFB04AddedClick.onClick.AddListener(UIGalleryFB04AddedClicking);
        
        // FB05Added
        Button UIGalleryFB05AddedClick = UIGalleryFB05Added.GetComponent<Button>();
		UIGalleryFB05AddedClick.onClick.AddListener(UIGalleryFB05AddedClicking);
        
        // FB06Added
        Button UIGalleryFB06AddedClick = UIGalleryFB06Added.GetComponent<Button>();
		UIGalleryFB06AddedClick.onClick.AddListener(UIGalleryFB06AddedClicking);
        
        // FB07Added
        Button UIGalleryFB07AddedClick = UIGalleryFB07Added.GetComponent<Button>();
		UIGalleryFB07AddedClick.onClick.AddListener(UIGalleryFB07AddedClicking);
        
        // FB08Added
        Button UIGalleryFB08AddedClick = UIGalleryFB08Added.GetComponent<Button>();
		UIGalleryFB08AddedClick.onClick.AddListener(UIGalleryFB08AddedClicking);
        
        // FB09Added
        Button UIGalleryFB09AddedClick = UIGalleryFB09Added.GetComponent<Button>();
		UIGalleryFB09AddedClick.onClick.AddListener(UIGalleryFB09AddedClicking);
        
        // FB10Added
        Button UIGalleryFB10AddedClick = UIGalleryFB10Added.GetComponent<Button>();
		UIGalleryFB10AddedClick.onClick.AddListener(UIGalleryFB10AddedClicking);
        
        // FBonus ------------------------------------------------------------
        // FBonus01
        Button UIGalleryFBonus01Click = UIGalleryFBonus01.GetComponent<Button>();
		UIGalleryFBonus01Click.onClick.AddListener(UIGalleryFBonus01Clicking);
        
        // FBonus02
        Button UIGalleryFBonus02Click = UIGalleryFBonus02.GetComponent<Button>();
		UIGalleryFBonus02Click.onClick.AddListener(UIGalleryFBonus02Clicking);
        
        // FBonus03
        Button UIGalleryFBonus03Click = UIGalleryFBonus03.GetComponent<Button>();
		UIGalleryFBonus03Click.onClick.AddListener(UIGalleryFBonus03Clicking);
        
        // FBonus04
        Button UIGalleryFBonus04Click = UIGalleryFBonus04.GetComponent<Button>();
		UIGalleryFBonus04Click.onClick.AddListener(UIGalleryFBonus04Clicking);
        
        // FBonus05
        Button UIGalleryFBonus05Click = UIGalleryFBonus05.GetComponent<Button>();
		UIGalleryFBonus05Click.onClick.AddListener(UIGalleryFBonus05Clicking);
        
        // FBonus06
        Button UIGalleryFBonus06Click = UIGalleryFBonus06.GetComponent<Button>();
		UIGalleryFBonus06Click.onClick.AddListener(UIGalleryFBonus06Clicking);
        
        // FBonus07
        Button UIGalleryFBonus07Click = UIGalleryFBonus07.GetComponent<Button>();
		UIGalleryFBonus07Click.onClick.AddListener(UIGalleryFBonus07Clicking);
        
        // FBonus08
        Button UIGalleryFBonus08Click = UIGalleryFBonus08.GetComponent<Button>();
		UIGalleryFBonus08Click.onClick.AddListener(UIGalleryFBonus08Clicking);
        
        // FBonus09
        Button UIGalleryFBonus09Click = UIGalleryFBonus09.GetComponent<Button>();
		UIGalleryFBonus09Click.onClick.AddListener(UIGalleryFBonus09Clicking);
        
        // FBonus10
        Button UIGalleryFBonus10Click = UIGalleryFBonus10.GetComponent<Button>();
		UIGalleryFBonus10Click.onClick.AddListener(UIGalleryFBonus10Clicking);
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
        Scene41Loading.Scene41Load();
    }
    
    public void UIGalleryButtonLeftClicking() {
        Scene44Loading.Scene44Load();
    }
    
    // F3 Added ------------------------------------------------------------
    public void UIGalleryF301AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF301Added);
    }
    
    public void UIGalleryF302AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF302Added);
    }
    
    public void UIGalleryF303AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF303Added);
    }
    
    public void UIGalleryF304AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF304Added);
    }
    
    public void UIGalleryF305AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF305Added);
    }
    
    public void UIGalleryF306AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF306Added);
    }
    
    public void UIGalleryF307AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF307Added);
    }
    
    public void UIGalleryF308AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkF308Added);
    }
    
    // G1 Added ------------------------------------------------------------
    public void UIGalleryG101AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG101Added);
    }
    
    public void UIGalleryG102AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG102Added);
    }
    
    public void UIGalleryG103AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG103Added);
    }
    
    public void UIGalleryG104AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG104Added);
    }
    
    public void UIGalleryG105AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG105Added);
    }
    
    public void UIGalleryG106AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG106Added);
    }
    
    public void UIGalleryG107AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG107Added);
    }
    
    public void UIGalleryG108AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG108Added);
    }
    
    // G2 Added ------------------------------------------------------------
    public void UIGalleryG201AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG201Added);
    }
    
    public void UIGalleryG202AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG202Added);
    }
    
    public void UIGalleryG203AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG203Added);
    }
    
    public void UIGalleryG204AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG204Added);
    }
    
    public void UIGalleryG205AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG205Added);
    }
    
    public void UIGalleryG206AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG206Added);
    }
    
    public void UIGalleryG207AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG207Added);
    }
    
    public void UIGalleryG208AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG208Added);
    }
    
    // G3 Added ------------------------------------------------------------
    public void UIGalleryG301AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG301Added);
    }
    
    public void UIGalleryG302AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG302Added);
    }
    
    public void UIGalleryG303AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG303Added);
    }
    
    public void UIGalleryG304AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG304Added);
    }
    
    public void UIGalleryG305AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG305Added);
    }
    
    public void UIGalleryG306AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG306Added);
    }
    
    public void UIGalleryG307AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG307Added);
    }
    
    public void UIGalleryG308AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkG308Added);
    }
    
    // FB Added ------------------------------------------------------------
    public void UIGalleryFB01AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB01Added);
    }
    
    public void UIGalleryFB02AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB02Added);
    }
    
    public void UIGalleryFB03AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB03Added);
    }
    
    public void UIGalleryFB04AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB04Added);
    }
    
    public void UIGalleryFB05AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB05Added);
    }
    
    public void UIGalleryFB06AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB06Added);
    }
    
    public void UIGalleryFB07AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB07Added);
    }
    
    public void UIGalleryFB08AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB08Added);
    }
    
    public void UIGalleryFB09AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB09Added);
    }
    
    public void UIGalleryFB10AddedClicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFB10Added);
    }
    
    // FBonus ------------------------------------------------------------
    public void UIGalleryFBonus01Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFBonus01);
    }
    
    public void UIGalleryFBonus02Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFBonus02);
    }
    
    public void UIGalleryFBonus03Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFBonus03);
    }
    
    public void UIGalleryFBonus04Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFBonus04);
    }
    
    public void UIGalleryFBonus05Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFBonus05);
    }
    
    public void UIGalleryFBonus06Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFBonus06);
    }
    
    public void UIGalleryFBonus07Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFBonus07);
    }
    
    public void UIGalleryFBonus08Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFBonus08);
    }
    
    public void UIGalleryFBonus09Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFBonus09);
    }
    
    public void UIGalleryFBonus10Clicking() {
        Application.OpenURL(ArtworkInformation.ArtPieceLearnLinkFBonus10);
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}