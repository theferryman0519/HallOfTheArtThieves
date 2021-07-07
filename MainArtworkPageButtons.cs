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

public class MainArtworkPageButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// UI Opening Artworks
	public Button UIOpeningArtworksCloseButton;
	public Button UIOpeningArtworksF1Off;
	public Button UIOpeningArtworksF2Off;
	public Button UIOpeningArtworksF3Off;
	public Button UIOpeningArtworksG1Off;
	public Button UIOpeningArtworksG2Off;
    public Button UIOpeningArtworksG3Off;
	public Button UIOpeningArtworksFBOff;
	
	// UI Artworks F1
	public Button UIArtworksF1CloseButton;
	public Button UIArtworksF1F1On;
	public Button UIArtworksF1F2Off;
	public Button UIArtworksF1F3Off;
	public Button UIArtworksF1G1Off;
	public Button UIArtworksF1G2Off;
    public Button UIArtworksF1G3Off;
	public Button UIArtworksF1FBOff;
	public Button UIArtworksButtonF101;
	public Button UIArtworksButtonF102;
	public Button UIArtworksButtonF103;
	public Button UIArtworksButtonF104;
	public Button UIArtworksButtonF105;
	public Button UIArtworksButtonF106;
	public Button UIArtworksButtonF107;
	public Button UIArtworksButtonF108;
	public Button UIArtworksButtonF109;
	public Button UIArtworksButtonF110;
	public Button UIArtworksButtonF111;
	public Button UIArtworksButtonF112;
	public Button UIArtworksButtonF113;
	public Button UIArtworksButtonF114;
	public Button UIArtworksButtonF115;
	
	// UI Artworks F2
	public Button UIArtworksF2CloseButton;
	public Button UIArtworksF2F2On;
	public Button UIArtworksF2F1Off;
	public Button UIArtworksF2F3Off;
	public Button UIArtworksF2G1Off;
	public Button UIArtworksF2G2Off;
    public Button UIArtworksF2G3Off;
	public Button UIArtworksF2FBOff;
	public Button UIArtworksButtonF201;
	public Button UIArtworksButtonF202;
	public Button UIArtworksButtonF203;
	public Button UIArtworksButtonF204;
	public Button UIArtworksButtonF205;
	public Button UIArtworksButtonF206;
	public Button UIArtworksButtonF207;
	public Button UIArtworksButtonF208;
	public Button UIArtworksButtonF209;
	public Button UIArtworksButtonF210;
	public Button UIArtworksButtonF211;
	public Button UIArtworksButtonF212;
	public Button UIArtworksButtonF213;
	public Button UIArtworksButtonF214;
	public Button UIArtworksButtonF215;
	
	// UI Artworks F3
	public Button UIArtworksF3CloseButton;
	public Button UIArtworksF3F3On;
	public Button UIArtworksF3F1Off;
	public Button UIArtworksF3F2Off;
	public Button UIArtworksF3G1Off;
	public Button UIArtworksF3G2Off;
    public Button UIArtworksF3G3Off;
	public Button UIArtworksF3FBOff;
	public Button UIArtworksButtonF301;
	public Button UIArtworksButtonF302;
	public Button UIArtworksButtonF303;
	public Button UIArtworksButtonF304;
	public Button UIArtworksButtonF305;
	public Button UIArtworksButtonF306;
	public Button UIArtworksButtonF307;
	public Button UIArtworksButtonF308;
	public Button UIArtworksButtonF309;
	public Button UIArtworksButtonF310;
	public Button UIArtworksButtonF311;
	public Button UIArtworksButtonF312;
	public Button UIArtworksButtonF313;
	public Button UIArtworksButtonF314;
	public Button UIArtworksButtonF315;
	
	// UI Artworks G1
	public Button UIArtworksG1CloseButton;
	public Button UIArtworksG1G1On;
	public Button UIArtworksG1F1Off;
	public Button UIArtworksG1F2Off;
	public Button UIArtworksG1F3Off;
	public Button UIArtworksG1G2Off;
    public Button UIArtworksG1G3Off;
	public Button UIArtworksG1FBOff;
	public Button UIArtworksButtonG101;
	public Button UIArtworksButtonG102;
	public Button UIArtworksButtonG103;
	public Button UIArtworksButtonG104;
	public Button UIArtworksButtonG105;
	public Button UIArtworksButtonG106;
	public Button UIArtworksButtonG107;
	public Button UIArtworksButtonG108;
	public Button UIArtworksButtonG109;
	public Button UIArtworksButtonG110;
	public Button UIArtworksButtonG111;
	public Button UIArtworksButtonG112;
	public Button UIArtworksButtonG113;
	public Button UIArtworksButtonG114;
	public Button UIArtworksButtonG115;
	
	// UI Artworks G2
	public Button UIArtworksG2CloseButton;
	public Button UIArtworksG2G2On;
	public Button UIArtworksG2F1Off;
	public Button UIArtworksG2F2Off;
	public Button UIArtworksG2F3Off;
	public Button UIArtworksG2G1Off;
    public Button UIArtworksG2G3Off;
	public Button UIArtworksG2FBOff;
	public Button UIArtworksButtonG201;
	public Button UIArtworksButtonG202;
	public Button UIArtworksButtonG203;
	public Button UIArtworksButtonG204;
	public Button UIArtworksButtonG205;
	public Button UIArtworksButtonG206;
	public Button UIArtworksButtonG207;
	public Button UIArtworksButtonG208;
	public Button UIArtworksButtonG209;
	public Button UIArtworksButtonG210;
	public Button UIArtworksButtonG211;
	public Button UIArtworksButtonG212;
	public Button UIArtworksButtonG213;
	public Button UIArtworksButtonG214;
	public Button UIArtworksButtonG215;
    
    // UI Artworks G3
	public Button UIArtworksG3CloseButton;
	public Button UIArtworksG3G3On;
	public Button UIArtworksG3F1Off;
	public Button UIArtworksG3F2Off;
	public Button UIArtworksG3F3Off;
	public Button UIArtworksG3G1Off;
    public Button UIArtworksG3G2Off;
	public Button UIArtworksG3FBOff;
	public Button UIArtworksButtonG301;
	public Button UIArtworksButtonG302;
	public Button UIArtworksButtonG303;
	public Button UIArtworksButtonG304;
	public Button UIArtworksButtonG305;
	public Button UIArtworksButtonG306;
	public Button UIArtworksButtonG307;
	public Button UIArtworksButtonG308;
	public Button UIArtworksButtonG309;
	public Button UIArtworksButtonG310;
	public Button UIArtworksButtonG311;
	public Button UIArtworksButtonG312;
	public Button UIArtworksButtonG313;
	public Button UIArtworksButtonG314;
	public Button UIArtworksButtonG315;
	
	// UI Artworks FB
	public Button UIArtworksFBCloseButton;
	public Button UIArtworksFBFBOn;
	public Button UIArtworksFBF1Off;
	public Button UIArtworksFBF2Off;
	public Button UIArtworksFBF3Off;
	public Button UIArtworksFBG1Off;
	public Button UIArtworksFBG2Off;
    public Button UIArtworksFBG3Off;
	public Button UIArtworksButtonFB01;
	public Button UIArtworksButtonFB02;
	public Button UIArtworksButtonFB03;
	public Button UIArtworksButtonFB04;
	public Button UIArtworksButtonFB05;
	public Button UIArtworksButtonFB06;
	public Button UIArtworksButtonFB07;
	public Button UIArtworksButtonFB08;
	public Button UIArtworksButtonFB09;
	public Button UIArtworksButtonFB10;
	public Button UIArtworksButtonFB11;
	public Button UIArtworksButtonFB12;
	public Button UIArtworksButtonFB13;
	public Button UIArtworksButtonFB14;
	public Button UIArtworksButtonFB15;
    
    // Bonus Buttons
    public Button UIArtworksF1BonusText;
    public Button UIArtworksF2BonusText;
    public Button UIArtworksF3BonusText;
    public Button UIArtworksG1BonusText;
    public Button UIArtworksG2BonusText;
    public Button UIArtworksG3BonusText;
    public Button UIArtworksFBBonusText;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	// Artwork Identifiers
	public static int IdentifyArtworkButton;
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Load Previous Room
	public SceneLoad Scene05Loading;
	
	// Load Artwork Info Scene
	public SceneLoad Scene37Loading;
	public SceneLoad Scene37BLoading;
    
    // Pausing Playing Timers
    public PausingPlayingTimers AllTimersPlaying;
    
    // Enable Bonus Pages
    public MainBonusArtworkPagesEnable ArtworksPageF1AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageF2AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageF3AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageG1AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageG2AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageG3AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageFBAddedEnabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Opening Artworks
		Button UIOpeningArtworksCloseButtonClick = UIOpeningArtworksCloseButton.GetComponent<Button>();
		Button UIOpeningArtworksF1OffClick = UIOpeningArtworksF1Off.GetComponent<Button>();
		Button UIOpeningArtworksF2OffClick = UIOpeningArtworksF2Off.GetComponent<Button>();
		Button UIOpeningArtworksF3OffClick = UIOpeningArtworksF3Off.GetComponent<Button>();
		Button UIOpeningArtworksG1OffClick = UIOpeningArtworksG1Off.GetComponent<Button>();
		Button UIOpeningArtworksG2OffClick = UIOpeningArtworksG2Off.GetComponent<Button>();
        Button UIOpeningArtworksG3OffClick = UIOpeningArtworksG3Off.GetComponent<Button>();
		Button UIOpeningArtworksFBOffClick = UIOpeningArtworksFBOff.GetComponent<Button>();
		
		UIOpeningArtworksCloseButtonClick.onClick.AddListener(UIOpeningArtworksCloseButtonClicking);
		UIOpeningArtworksF1OffClick.onClick.AddListener(UIOpeningArtworksF1OffClicking);
		UIOpeningArtworksF2OffClick.onClick.AddListener(UIOpeningArtworksF2OffClicking);
		UIOpeningArtworksF3OffClick.onClick.AddListener(UIOpeningArtworksF3OffClicking);
		UIOpeningArtworksG1OffClick.onClick.AddListener(UIOpeningArtworksG1OffClicking);
		UIOpeningArtworksG2OffClick.onClick.AddListener(UIOpeningArtworksG2OffClicking);
        UIOpeningArtworksG3OffClick.onClick.AddListener(UIOpeningArtworksG3OffClicking);
		UIOpeningArtworksFBOffClick.onClick.AddListener(UIOpeningArtworksFBOffClicking);
		
		// Artwork Page F1
		Button UIArtworksF1CloseButtonClick = UIArtworksF1CloseButton.GetComponent<Button>();
		Button UIArtworksF1F1OnClick = UIArtworksF1F1On.GetComponent<Button>();
		Button UIArtworksF1F2OffClick = UIArtworksF1F2Off.GetComponent<Button>();
		Button UIArtworksF1F3OffClick = UIArtworksF1F3Off.GetComponent<Button>();
		Button UIArtworksF1G1OffClick = UIArtworksF1G1Off.GetComponent<Button>();
		Button UIArtworksF1G2OffClick = UIArtworksF1G2Off.GetComponent<Button>();
        Button UIArtworksF1G3OffClick = UIArtworksF1G3Off.GetComponent<Button>();
		Button UIArtworksF1FBOffClick = UIArtworksF1FBOff.GetComponent<Button>();
		Button UIArtworksButtonF101Click = UIArtworksButtonF101.GetComponent<Button>();
		Button UIArtworksButtonF102Click = UIArtworksButtonF102.GetComponent<Button>();
		Button UIArtworksButtonF103Click = UIArtworksButtonF103.GetComponent<Button>();
		Button UIArtworksButtonF104Click = UIArtworksButtonF104.GetComponent<Button>();
		Button UIArtworksButtonF105Click = UIArtworksButtonF105.GetComponent<Button>();
		Button UIArtworksButtonF106Click = UIArtworksButtonF106.GetComponent<Button>();
		Button UIArtworksButtonF107Click = UIArtworksButtonF107.GetComponent<Button>();
		Button UIArtworksButtonF108Click = UIArtworksButtonF108.GetComponent<Button>();
		Button UIArtworksButtonF109Click = UIArtworksButtonF109.GetComponent<Button>();
		Button UIArtworksButtonF110Click = UIArtworksButtonF110.GetComponent<Button>();
		Button UIArtworksButtonF111Click = UIArtworksButtonF111.GetComponent<Button>();
		Button UIArtworksButtonF112Click = UIArtworksButtonF112.GetComponent<Button>();
		Button UIArtworksButtonF113Click = UIArtworksButtonF113.GetComponent<Button>();
		Button UIArtworksButtonF114Click = UIArtworksButtonF114.GetComponent<Button>();
		Button UIArtworksButtonF115Click = UIArtworksButtonF115.GetComponent<Button>();
		
		UIArtworksF1CloseButtonClick.onClick.AddListener(UIArtworksF1CloseButtonClicking);
		UIArtworksF1F1OnClick.onClick.AddListener(UIArtworksF1F1OnClicking);
		UIArtworksF1F2OffClick.onClick.AddListener(UIArtworksF1F2OffClicking);
		UIArtworksF1F3OffClick.onClick.AddListener(UIArtworksF1F3OffClicking);
		UIArtworksF1G1OffClick.onClick.AddListener(UIArtworksF1G1OffClicking);
		UIArtworksF1G2OffClick.onClick.AddListener(UIArtworksF1G2OffClicking);
        UIArtworksF1G3OffClick.onClick.AddListener(UIArtworksF1G3OffClicking);
		UIArtworksF1FBOffClick.onClick.AddListener(UIArtworksF1FBOffClicking);
		UIArtworksButtonF101Click.onClick.AddListener(UIArtworksButtonF101Clicking);
		UIArtworksButtonF102Click.onClick.AddListener(UIArtworksButtonF102Clicking);
		UIArtworksButtonF103Click.onClick.AddListener(UIArtworksButtonF103Clicking);
		UIArtworksButtonF104Click.onClick.AddListener(UIArtworksButtonF104Clicking);
		UIArtworksButtonF105Click.onClick.AddListener(UIArtworksButtonF105Clicking);
		UIArtworksButtonF106Click.onClick.AddListener(UIArtworksButtonF106Clicking);
		UIArtworksButtonF107Click.onClick.AddListener(UIArtworksButtonF107Clicking);
		UIArtworksButtonF108Click.onClick.AddListener(UIArtworksButtonF108Clicking);
		UIArtworksButtonF109Click.onClick.AddListener(UIArtworksButtonF109Clicking);
		UIArtworksButtonF110Click.onClick.AddListener(UIArtworksButtonF110Clicking);
		UIArtworksButtonF111Click.onClick.AddListener(UIArtworksButtonF111Clicking);
		UIArtworksButtonF112Click.onClick.AddListener(UIArtworksButtonF112Clicking);
		UIArtworksButtonF113Click.onClick.AddListener(UIArtworksButtonF113Clicking);
		UIArtworksButtonF114Click.onClick.AddListener(UIArtworksButtonF114Clicking);
		UIArtworksButtonF115Click.onClick.AddListener(UIArtworksButtonF115Clicking);
	
		// Artwork Page F2
		Button UIArtworksF2CloseButtonClick = UIArtworksF2CloseButton.GetComponent<Button>();
		Button UIArtworksF2F2OnClick = UIArtworksF2F2On.GetComponent<Button>();
		Button UIArtworksF2F1OffClick = UIArtworksF2F1Off.GetComponent<Button>();
		Button UIArtworksF2F3OffClick = UIArtworksF2F3Off.GetComponent<Button>();
		Button UIArtworksF2G1OffClick = UIArtworksF2G1Off.GetComponent<Button>();
		Button UIArtworksF2G2OffClick = UIArtworksF2G2Off.GetComponent<Button>();
        Button UIArtworksF2G3OffClick = UIArtworksF2G3Off.GetComponent<Button>();
		Button UIArtworksF2FBOffClick = UIArtworksF2FBOff.GetComponent<Button>();
		Button UIArtworksButtonF201Click = UIArtworksButtonF201.GetComponent<Button>();
		Button UIArtworksButtonF202Click = UIArtworksButtonF202.GetComponent<Button>();
		Button UIArtworksButtonF203Click = UIArtworksButtonF203.GetComponent<Button>();
		Button UIArtworksButtonF204Click = UIArtworksButtonF204.GetComponent<Button>();
		Button UIArtworksButtonF205Click = UIArtworksButtonF205.GetComponent<Button>();
		Button UIArtworksButtonF206Click = UIArtworksButtonF206.GetComponent<Button>();
		Button UIArtworksButtonF207Click = UIArtworksButtonF207.GetComponent<Button>();
		Button UIArtworksButtonF208Click = UIArtworksButtonF208.GetComponent<Button>();
		Button UIArtworksButtonF209Click = UIArtworksButtonF209.GetComponent<Button>();
		Button UIArtworksButtonF210Click = UIArtworksButtonF210.GetComponent<Button>();
		Button UIArtworksButtonF211Click = UIArtworksButtonF211.GetComponent<Button>();
		Button UIArtworksButtonF212Click = UIArtworksButtonF212.GetComponent<Button>();
		Button UIArtworksButtonF213Click = UIArtworksButtonF213.GetComponent<Button>();
		Button UIArtworksButtonF214Click = UIArtworksButtonF214.GetComponent<Button>();
		Button UIArtworksButtonF215Click = UIArtworksButtonF215.GetComponent<Button>();
		
		UIArtworksF2CloseButtonClick.onClick.AddListener(UIArtworksF2CloseButtonClicking);
		UIArtworksF2F2OnClick.onClick.AddListener(UIArtworksF2F2OnClicking);
		UIArtworksF2F1OffClick.onClick.AddListener(UIArtworksF2F1OffClicking);
		UIArtworksF2F3OffClick.onClick.AddListener(UIArtworksF2F3OffClicking);
		UIArtworksF2G1OffClick.onClick.AddListener(UIArtworksF2G1OffClicking);
		UIArtworksF2G2OffClick.onClick.AddListener(UIArtworksF2G2OffClicking);
        UIArtworksF2G3OffClick.onClick.AddListener(UIArtworksF2G3OffClicking);
		UIArtworksF2FBOffClick.onClick.AddListener(UIArtworksF2FBOffClicking);
		UIArtworksButtonF201Click.onClick.AddListener(UIArtworksButtonF201Clicking);
		UIArtworksButtonF202Click.onClick.AddListener(UIArtworksButtonF202Clicking);
		UIArtworksButtonF203Click.onClick.AddListener(UIArtworksButtonF203Clicking);
		UIArtworksButtonF204Click.onClick.AddListener(UIArtworksButtonF204Clicking);
		UIArtworksButtonF205Click.onClick.AddListener(UIArtworksButtonF205Clicking);
		UIArtworksButtonF206Click.onClick.AddListener(UIArtworksButtonF206Clicking);
		UIArtworksButtonF207Click.onClick.AddListener(UIArtworksButtonF207Clicking);
		UIArtworksButtonF208Click.onClick.AddListener(UIArtworksButtonF208Clicking);
		UIArtworksButtonF209Click.onClick.AddListener(UIArtworksButtonF209Clicking);
		UIArtworksButtonF210Click.onClick.AddListener(UIArtworksButtonF210Clicking);
		UIArtworksButtonF211Click.onClick.AddListener(UIArtworksButtonF211Clicking);
		UIArtworksButtonF212Click.onClick.AddListener(UIArtworksButtonF212Clicking);
		UIArtworksButtonF213Click.onClick.AddListener(UIArtworksButtonF213Clicking);
		UIArtworksButtonF214Click.onClick.AddListener(UIArtworksButtonF214Clicking);
		UIArtworksButtonF215Click.onClick.AddListener(UIArtworksButtonF215Clicking);

		// Artwork Page F3
		Button UIArtworksF3CloseButtonClick = UIArtworksF3CloseButton.GetComponent<Button>();
		Button UIArtworksF3F3OnClick = UIArtworksF3F3On.GetComponent<Button>();
		Button UIArtworksF3F1OffClick = UIArtworksF3F1Off.GetComponent<Button>();
		Button UIArtworksF3F2OffClick = UIArtworksF3F2Off.GetComponent<Button>();
		Button UIArtworksF3G1OffClick = UIArtworksF3G1Off.GetComponent<Button>();
		Button UIArtworksF3G2OffClick = UIArtworksF3G2Off.GetComponent<Button>();
        Button UIArtworksF3G3OffClick = UIArtworksF3G3Off.GetComponent<Button>();
		Button UIArtworksF3FBOffClick = UIArtworksF3FBOff.GetComponent<Button>();
		Button UIArtworksButtonF301Click = UIArtworksButtonF301.GetComponent<Button>();
		Button UIArtworksButtonF302Click = UIArtworksButtonF302.GetComponent<Button>();
		Button UIArtworksButtonF303Click = UIArtworksButtonF303.GetComponent<Button>();
		Button UIArtworksButtonF304Click = UIArtworksButtonF304.GetComponent<Button>();
		Button UIArtworksButtonF305Click = UIArtworksButtonF305.GetComponent<Button>();
		Button UIArtworksButtonF306Click = UIArtworksButtonF306.GetComponent<Button>();
		Button UIArtworksButtonF307Click = UIArtworksButtonF307.GetComponent<Button>();
		Button UIArtworksButtonF308Click = UIArtworksButtonF308.GetComponent<Button>();
		Button UIArtworksButtonF309Click = UIArtworksButtonF309.GetComponent<Button>();
		Button UIArtworksButtonF310Click = UIArtworksButtonF310.GetComponent<Button>();
		Button UIArtworksButtonF311Click = UIArtworksButtonF311.GetComponent<Button>();
		Button UIArtworksButtonF312Click = UIArtworksButtonF312.GetComponent<Button>();
		Button UIArtworksButtonF313Click = UIArtworksButtonF313.GetComponent<Button>();
		Button UIArtworksButtonF314Click = UIArtworksButtonF314.GetComponent<Button>();
		Button UIArtworksButtonF315Click = UIArtworksButtonF315.GetComponent<Button>();
		
		UIArtworksF3CloseButtonClick.onClick.AddListener(UIArtworksF3CloseButtonClicking);
		UIArtworksF3F3OnClick.onClick.AddListener(UIArtworksF3F3OnClicking);
		UIArtworksF3F1OffClick.onClick.AddListener(UIArtworksF3F1OffClicking);
		UIArtworksF3F2OffClick.onClick.AddListener(UIArtworksF3F2OffClicking);
		UIArtworksF3G1OffClick.onClick.AddListener(UIArtworksF3G1OffClicking);
		UIArtworksF3G2OffClick.onClick.AddListener(UIArtworksF3G2OffClicking);
        UIArtworksF3G3OffClick.onClick.AddListener(UIArtworksF3G3OffClicking);
		UIArtworksF3FBOffClick.onClick.AddListener(UIArtworksF3FBOffClicking);
		UIArtworksButtonF301Click.onClick.AddListener(UIArtworksButtonF301Clicking);
		UIArtworksButtonF302Click.onClick.AddListener(UIArtworksButtonF302Clicking);
		UIArtworksButtonF303Click.onClick.AddListener(UIArtworksButtonF303Clicking);
		UIArtworksButtonF304Click.onClick.AddListener(UIArtworksButtonF304Clicking);
		UIArtworksButtonF305Click.onClick.AddListener(UIArtworksButtonF305Clicking);
		UIArtworksButtonF306Click.onClick.AddListener(UIArtworksButtonF306Clicking);
		UIArtworksButtonF307Click.onClick.AddListener(UIArtworksButtonF307Clicking);
		UIArtworksButtonF308Click.onClick.AddListener(UIArtworksButtonF308Clicking);
		UIArtworksButtonF309Click.onClick.AddListener(UIArtworksButtonF309Clicking);
		UIArtworksButtonF310Click.onClick.AddListener(UIArtworksButtonF310Clicking);
		UIArtworksButtonF311Click.onClick.AddListener(UIArtworksButtonF311Clicking);
		UIArtworksButtonF312Click.onClick.AddListener(UIArtworksButtonF312Clicking);
		UIArtworksButtonF313Click.onClick.AddListener(UIArtworksButtonF313Clicking);
		UIArtworksButtonF314Click.onClick.AddListener(UIArtworksButtonF314Clicking);
		UIArtworksButtonF315Click.onClick.AddListener(UIArtworksButtonF315Clicking);
	
		// Artwork Page G1
		Button UIArtworksG1CloseButtonClick = UIArtworksG1CloseButton.GetComponent<Button>();
		Button UIArtworksG1G1OnClick = UIArtworksG1G1On.GetComponent<Button>();
		Button UIArtworksG1F1OffClick = UIArtworksG1F1Off.GetComponent<Button>();
		Button UIArtworksG1F2OffClick = UIArtworksG1F2Off.GetComponent<Button>();
		Button UIArtworksG1F3OffClick = UIArtworksG1F3Off.GetComponent<Button>();
		Button UIArtworksG1G2OffClick = UIArtworksG1G2Off.GetComponent<Button>();
        Button UIArtworksG1G3OffClick = UIArtworksG1G3Off.GetComponent<Button>();
		Button UIArtworksG1FBOffClick = UIArtworksG1FBOff.GetComponent<Button>();
		Button UIArtworksButtonG101Click = UIArtworksButtonG101.GetComponent<Button>();
		Button UIArtworksButtonG102Click = UIArtworksButtonG102.GetComponent<Button>();
		Button UIArtworksButtonG103Click = UIArtworksButtonG103.GetComponent<Button>();
		Button UIArtworksButtonG104Click = UIArtworksButtonG104.GetComponent<Button>();
		Button UIArtworksButtonG105Click = UIArtworksButtonG105.GetComponent<Button>();
		Button UIArtworksButtonG106Click = UIArtworksButtonG106.GetComponent<Button>();
		Button UIArtworksButtonG107Click = UIArtworksButtonG107.GetComponent<Button>();
		Button UIArtworksButtonG108Click = UIArtworksButtonG108.GetComponent<Button>();
		Button UIArtworksButtonG109Click = UIArtworksButtonG109.GetComponent<Button>();
		Button UIArtworksButtonG110Click = UIArtworksButtonG110.GetComponent<Button>();
		Button UIArtworksButtonG111Click = UIArtworksButtonG111.GetComponent<Button>();
		Button UIArtworksButtonG112Click = UIArtworksButtonG112.GetComponent<Button>();
		Button UIArtworksButtonG113Click = UIArtworksButtonG113.GetComponent<Button>();
		Button UIArtworksButtonG114Click = UIArtworksButtonG114.GetComponent<Button>();
		Button UIArtworksButtonG115Click = UIArtworksButtonG115.GetComponent<Button>();
		
		UIArtworksG1CloseButtonClick.onClick.AddListener(UIArtworksG1CloseButtonClicking);
		UIArtworksG1G1OnClick.onClick.AddListener(UIArtworksG1G1OnClicking);
		UIArtworksG1F1OffClick.onClick.AddListener(UIArtworksG1F1OffClicking);
		UIArtworksG1F2OffClick.onClick.AddListener(UIArtworksG1F2OffClicking);
		UIArtworksG1F3OffClick.onClick.AddListener(UIArtworksG1F3OffClicking);
		UIArtworksG1G2OffClick.onClick.AddListener(UIArtworksG1G2OffClicking);
        UIArtworksG1G3OffClick.onClick.AddListener(UIArtworksG1G3OffClicking);
		UIArtworksG1FBOffClick.onClick.AddListener(UIArtworksG1FBOffClicking);
		UIArtworksButtonG101Click.onClick.AddListener(UIArtworksButtonG101Clicking);
		UIArtworksButtonG102Click.onClick.AddListener(UIArtworksButtonG102Clicking);
		UIArtworksButtonG103Click.onClick.AddListener(UIArtworksButtonG103Clicking);
		UIArtworksButtonG104Click.onClick.AddListener(UIArtworksButtonG104Clicking);
		UIArtworksButtonG105Click.onClick.AddListener(UIArtworksButtonG105Clicking);
		UIArtworksButtonG106Click.onClick.AddListener(UIArtworksButtonG106Clicking);
		UIArtworksButtonG107Click.onClick.AddListener(UIArtworksButtonG107Clicking);
		UIArtworksButtonG108Click.onClick.AddListener(UIArtworksButtonG108Clicking);
		UIArtworksButtonG109Click.onClick.AddListener(UIArtworksButtonG109Clicking);
		UIArtworksButtonG110Click.onClick.AddListener(UIArtworksButtonG110Clicking);
		UIArtworksButtonG111Click.onClick.AddListener(UIArtworksButtonG111Clicking);
		UIArtworksButtonG112Click.onClick.AddListener(UIArtworksButtonG112Clicking);
		UIArtworksButtonG113Click.onClick.AddListener(UIArtworksButtonG113Clicking);
		UIArtworksButtonG114Click.onClick.AddListener(UIArtworksButtonG114Clicking);
		UIArtworksButtonG115Click.onClick.AddListener(UIArtworksButtonG115Clicking);
		
		// Artwork Page G2
		Button UIArtworksG2CloseButtonClick = UIArtworksG2CloseButton.GetComponent<Button>();
		Button UIArtworksG2G2OnClick = UIArtworksG2G2On.GetComponent<Button>();
		Button UIArtworksG2F1OffClick = UIArtworksG2F1Off.GetComponent<Button>();
		Button UIArtworksG2F2OffClick = UIArtworksG2F2Off.GetComponent<Button>();
		Button UIArtworksG2F3OffClick = UIArtworksG2F3Off.GetComponent<Button>();
		Button UIArtworksG2G1OffClick = UIArtworksG2G1Off.GetComponent<Button>();
        Button UIArtworksG2G3OffClick = UIArtworksG2G3Off.GetComponent<Button>();
		Button UIArtworksG2FBOffClick = UIArtworksG2FBOff.GetComponent<Button>();
		Button UIArtworksButtonG201Click = UIArtworksButtonG201.GetComponent<Button>();
		Button UIArtworksButtonG202Click = UIArtworksButtonG202.GetComponent<Button>();
		Button UIArtworksButtonG203Click = UIArtworksButtonG203.GetComponent<Button>();
		Button UIArtworksButtonG204Click = UIArtworksButtonG204.GetComponent<Button>();
		Button UIArtworksButtonG205Click = UIArtworksButtonG205.GetComponent<Button>();
		Button UIArtworksButtonG206Click = UIArtworksButtonG206.GetComponent<Button>();
		Button UIArtworksButtonG207Click = UIArtworksButtonG207.GetComponent<Button>();
		Button UIArtworksButtonG208Click = UIArtworksButtonG208.GetComponent<Button>();
		Button UIArtworksButtonG209Click = UIArtworksButtonG209.GetComponent<Button>();
		Button UIArtworksButtonG210Click = UIArtworksButtonG210.GetComponent<Button>();
		Button UIArtworksButtonG211Click = UIArtworksButtonG211.GetComponent<Button>();
		Button UIArtworksButtonG212Click = UIArtworksButtonG212.GetComponent<Button>();
		Button UIArtworksButtonG213Click = UIArtworksButtonG213.GetComponent<Button>();
		Button UIArtworksButtonG214Click = UIArtworksButtonG214.GetComponent<Button>();
		Button UIArtworksButtonG215Click = UIArtworksButtonG215.GetComponent<Button>();
		
		UIArtworksG2CloseButtonClick.onClick.AddListener(UIArtworksG2CloseButtonClicking);
		UIArtworksG2G2OnClick.onClick.AddListener(UIArtworksG2G2OnClicking);
		UIArtworksG2F1OffClick.onClick.AddListener(UIArtworksG2F1OffClicking);
		UIArtworksG2F2OffClick.onClick.AddListener(UIArtworksG2F2OffClicking);
		UIArtworksG2F3OffClick.onClick.AddListener(UIArtworksG2F3OffClicking);
		UIArtworksG2G1OffClick.onClick.AddListener(UIArtworksG2G1OffClicking);
        UIArtworksG2G3OffClick.onClick.AddListener(UIArtworksG2G3OffClicking);
		UIArtworksG2FBOffClick.onClick.AddListener(UIArtworksG2FBOffClicking);
		UIArtworksButtonG201Click.onClick.AddListener(UIArtworksButtonG201Clicking);
		UIArtworksButtonG202Click.onClick.AddListener(UIArtworksButtonG202Clicking);
		UIArtworksButtonG203Click.onClick.AddListener(UIArtworksButtonG203Clicking);
		UIArtworksButtonG204Click.onClick.AddListener(UIArtworksButtonG204Clicking);
		UIArtworksButtonG205Click.onClick.AddListener(UIArtworksButtonG205Clicking);
		UIArtworksButtonG206Click.onClick.AddListener(UIArtworksButtonG206Clicking);
		UIArtworksButtonG207Click.onClick.AddListener(UIArtworksButtonG207Clicking);
		UIArtworksButtonG208Click.onClick.AddListener(UIArtworksButtonG208Clicking);
		UIArtworksButtonG209Click.onClick.AddListener(UIArtworksButtonG209Clicking);
		UIArtworksButtonG210Click.onClick.AddListener(UIArtworksButtonG210Clicking);
		UIArtworksButtonG211Click.onClick.AddListener(UIArtworksButtonG211Clicking);
		UIArtworksButtonG212Click.onClick.AddListener(UIArtworksButtonG212Clicking);
		UIArtworksButtonG213Click.onClick.AddListener(UIArtworksButtonG213Clicking);
		UIArtworksButtonG214Click.onClick.AddListener(UIArtworksButtonG214Clicking);
		UIArtworksButtonG215Click.onClick.AddListener(UIArtworksButtonG215Clicking);
        
        // Artwork Page G3
		Button UIArtworksG3CloseButtonClick = UIArtworksG3CloseButton.GetComponent<Button>();
		Button UIArtworksG3G3OnClick = UIArtworksG3G3On.GetComponent<Button>();
		Button UIArtworksG3F1OffClick = UIArtworksG3F1Off.GetComponent<Button>();
		Button UIArtworksG3F2OffClick = UIArtworksG3F2Off.GetComponent<Button>();
		Button UIArtworksG3F3OffClick = UIArtworksG3F3Off.GetComponent<Button>();
		Button UIArtworksG3G1OffClick = UIArtworksG3G1Off.GetComponent<Button>();
        Button UIArtworksG3G2OffClick = UIArtworksG3G2Off.GetComponent<Button>();
		Button UIArtworksG3FBOffClick = UIArtworksG3FBOff.GetComponent<Button>();
		Button UIArtworksButtonG301Click = UIArtworksButtonG301.GetComponent<Button>();
		Button UIArtworksButtonG302Click = UIArtworksButtonG302.GetComponent<Button>();
		Button UIArtworksButtonG303Click = UIArtworksButtonG303.GetComponent<Button>();
		Button UIArtworksButtonG304Click = UIArtworksButtonG304.GetComponent<Button>();
		Button UIArtworksButtonG305Click = UIArtworksButtonG305.GetComponent<Button>();
		Button UIArtworksButtonG306Click = UIArtworksButtonG306.GetComponent<Button>();
		Button UIArtworksButtonG307Click = UIArtworksButtonG307.GetComponent<Button>();
		Button UIArtworksButtonG308Click = UIArtworksButtonG308.GetComponent<Button>();
		Button UIArtworksButtonG309Click = UIArtworksButtonG309.GetComponent<Button>();
		Button UIArtworksButtonG310Click = UIArtworksButtonG310.GetComponent<Button>();
		Button UIArtworksButtonG311Click = UIArtworksButtonG311.GetComponent<Button>();
		Button UIArtworksButtonG312Click = UIArtworksButtonG312.GetComponent<Button>();
		Button UIArtworksButtonG313Click = UIArtworksButtonG313.GetComponent<Button>();
		Button UIArtworksButtonG314Click = UIArtworksButtonG314.GetComponent<Button>();
		Button UIArtworksButtonG315Click = UIArtworksButtonG315.GetComponent<Button>();
		
		UIArtworksG3CloseButtonClick.onClick.AddListener(UIArtworksG3CloseButtonClicking);
		UIArtworksG3G3OnClick.onClick.AddListener(UIArtworksG3G3OnClicking);
		UIArtworksG3F1OffClick.onClick.AddListener(UIArtworksG3F1OffClicking);
		UIArtworksG3F2OffClick.onClick.AddListener(UIArtworksG3F2OffClicking);
		UIArtworksG3F3OffClick.onClick.AddListener(UIArtworksG3F3OffClicking);
		UIArtworksG3G1OffClick.onClick.AddListener(UIArtworksG3G1OffClicking);
        UIArtworksG3G2OffClick.onClick.AddListener(UIArtworksG3G2OffClicking);
		UIArtworksG3FBOffClick.onClick.AddListener(UIArtworksG3FBOffClicking);
		UIArtworksButtonG301Click.onClick.AddListener(UIArtworksButtonG301Clicking);
		UIArtworksButtonG302Click.onClick.AddListener(UIArtworksButtonG302Clicking);
		UIArtworksButtonG303Click.onClick.AddListener(UIArtworksButtonG303Clicking);
		UIArtworksButtonG304Click.onClick.AddListener(UIArtworksButtonG304Clicking);
		UIArtworksButtonG305Click.onClick.AddListener(UIArtworksButtonG305Clicking);
		UIArtworksButtonG306Click.onClick.AddListener(UIArtworksButtonG306Clicking);
		UIArtworksButtonG307Click.onClick.AddListener(UIArtworksButtonG307Clicking);
		UIArtworksButtonG308Click.onClick.AddListener(UIArtworksButtonG308Clicking);
		UIArtworksButtonG309Click.onClick.AddListener(UIArtworksButtonG309Clicking);
		UIArtworksButtonG310Click.onClick.AddListener(UIArtworksButtonG310Clicking);
		UIArtworksButtonG311Click.onClick.AddListener(UIArtworksButtonG311Clicking);
		UIArtworksButtonG312Click.onClick.AddListener(UIArtworksButtonG312Clicking);
		UIArtworksButtonG313Click.onClick.AddListener(UIArtworksButtonG313Clicking);
		UIArtworksButtonG314Click.onClick.AddListener(UIArtworksButtonG314Clicking);
		UIArtworksButtonG315Click.onClick.AddListener(UIArtworksButtonG315Clicking);
		
		// Artwork Page FB
		Button UIArtworksFBCloseButtonClick = UIArtworksFBCloseButton.GetComponent<Button>();
		Button UIArtworksFBFBOnClick = UIArtworksFBFBOn.GetComponent<Button>();
		Button UIArtworksFBF1OffClick = UIArtworksFBF1Off.GetComponent<Button>();
		Button UIArtworksFBF2OffClick = UIArtworksFBF2Off.GetComponent<Button>();
		Button UIArtworksFBF3OffClick = UIArtworksFBF3Off.GetComponent<Button>();
		Button UIArtworksFBG1OffClick = UIArtworksFBG1Off.GetComponent<Button>();
		Button UIArtworksFBG2OffClick = UIArtworksFBG2Off.GetComponent<Button>();
        Button UIArtworksFBG3OffClick = UIArtworksFBG3Off.GetComponent<Button>();
		Button UIArtworksButtonFB01Click = UIArtworksButtonFB01.GetComponent<Button>();
		Button UIArtworksButtonFB02Click = UIArtworksButtonFB02.GetComponent<Button>();
		Button UIArtworksButtonFB03Click = UIArtworksButtonFB03.GetComponent<Button>();
		Button UIArtworksButtonFB04Click = UIArtworksButtonFB04.GetComponent<Button>();
		Button UIArtworksButtonFB05Click = UIArtworksButtonFB05.GetComponent<Button>();
		Button UIArtworksButtonFB06Click = UIArtworksButtonFB06.GetComponent<Button>();
		Button UIArtworksButtonFB07Click = UIArtworksButtonFB07.GetComponent<Button>();
		Button UIArtworksButtonFB08Click = UIArtworksButtonFB08.GetComponent<Button>();
		Button UIArtworksButtonFB09Click = UIArtworksButtonFB09.GetComponent<Button>();
		Button UIArtworksButtonFB10Click = UIArtworksButtonFB10.GetComponent<Button>();
		Button UIArtworksButtonFB11Click = UIArtworksButtonFB11.GetComponent<Button>();
		Button UIArtworksButtonFB12Click = UIArtworksButtonFB12.GetComponent<Button>();
		Button UIArtworksButtonFB13Click = UIArtworksButtonFB13.GetComponent<Button>();
		Button UIArtworksButtonFB14Click = UIArtworksButtonFB14.GetComponent<Button>();
		Button UIArtworksButtonFB15Click = UIArtworksButtonFB15.GetComponent<Button>();
		
		UIArtworksFBCloseButtonClick.onClick.AddListener(UIArtworksFBCloseButtonClicking);
		UIArtworksFBFBOnClick.onClick.AddListener(UIArtworksFBFBOnClicking);
		UIArtworksFBF1OffClick.onClick.AddListener(UIArtworksFBF1OffClicking);
		UIArtworksFBF2OffClick.onClick.AddListener(UIArtworksFBF2OffClicking);
		UIArtworksFBF3OffClick.onClick.AddListener(UIArtworksFBF3OffClicking);
		UIArtworksFBG1OffClick.onClick.AddListener(UIArtworksFBG1OffClicking);
		UIArtworksFBG2OffClick.onClick.AddListener(UIArtworksFBG2OffClicking);
        UIArtworksFBG3OffClick.onClick.AddListener(UIArtworksFBG3OffClicking);
		UIArtworksButtonFB01Click.onClick.AddListener(UIArtworksButtonFB01Clicking);
		UIArtworksButtonFB02Click.onClick.AddListener(UIArtworksButtonFB02Clicking);
		UIArtworksButtonFB03Click.onClick.AddListener(UIArtworksButtonFB03Clicking);
		UIArtworksButtonFB04Click.onClick.AddListener(UIArtworksButtonFB04Clicking);
		UIArtworksButtonFB05Click.onClick.AddListener(UIArtworksButtonFB05Clicking);
		UIArtworksButtonFB06Click.onClick.AddListener(UIArtworksButtonFB06Clicking);
		UIArtworksButtonFB07Click.onClick.AddListener(UIArtworksButtonFB07Clicking);
		UIArtworksButtonFB08Click.onClick.AddListener(UIArtworksButtonFB08Clicking);
		UIArtworksButtonFB09Click.onClick.AddListener(UIArtworksButtonFB09Clicking);
		UIArtworksButtonFB10Click.onClick.AddListener(UIArtworksButtonFB10Clicking);
		UIArtworksButtonFB11Click.onClick.AddListener(UIArtworksButtonFB11Clicking);
		UIArtworksButtonFB12Click.onClick.AddListener(UIArtworksButtonFB12Clicking);
		UIArtworksButtonFB13Click.onClick.AddListener(UIArtworksButtonFB13Clicking);
		UIArtworksButtonFB14Click.onClick.AddListener(UIArtworksButtonFB14Clicking);
		UIArtworksButtonFB15Click.onClick.AddListener(UIArtworksButtonFB15Clicking);
        
        // Bonus Pages
        Button UIArtworksF1BonusTextClick = UIArtworksF1BonusText.GetComponent<Button>();
        Button UIArtworksF2BonusTextClick = UIArtworksF2BonusText.GetComponent<Button>();
        Button UIArtworksF3BonusTextClick = UIArtworksF3BonusText.GetComponent<Button>();
        Button UIArtworksG1BonusTextClick = UIArtworksG1BonusText.GetComponent<Button>();
        Button UIArtworksG2BonusTextClick = UIArtworksG2BonusText.GetComponent<Button>();
        Button UIArtworksG3BonusTextClick = UIArtworksG3BonusText.GetComponent<Button>();
        Button UIArtworksFBBonusTextClick = UIArtworksFBBonusText.GetComponent<Button>();
        
        UIArtworksF1BonusTextClick.onClick.AddListener(UIArtworksF1BonusTextClicking);
        UIArtworksF2BonusTextClick.onClick.AddListener(UIArtworksF2BonusTextClicking);
        UIArtworksF3BonusTextClick.onClick.AddListener(UIArtworksF3BonusTextClicking);
        UIArtworksG1BonusTextClick.onClick.AddListener(UIArtworksG1BonusTextClicking);
        UIArtworksG2BonusTextClick.onClick.AddListener(UIArtworksG2BonusTextClicking);
        UIArtworksG3BonusTextClick.onClick.AddListener(UIArtworksG3BonusTextClicking);
        UIArtworksFBBonusTextClick.onClick.AddListener(UIArtworksFBBonusTextClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- OPENING ARTWORKS BUTTON FUNCTIONS ---------------
	public void UIOpeningArtworksCloseButtonClicking() {
		AllTimersPlaying.AllTimersPlay();
		Scene05Loading.Scene05Load();
	}
	
	public void UIOpeningArtworksF1OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 1;
	}
	
	public void UIOpeningArtworksF2OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 2;
	}
	
	public void UIOpeningArtworksF3OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 3;
	}
	
	public void UIOpeningArtworksG1OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 4;
	}
	
	public void UIOpeningArtworksG2OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 5;
	}
    
    public void UIOpeningArtworksG3OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 7;
	}
	
	public void UIOpeningArtworksFBOffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 6;
	}
	
// --------------- ARTWORK PAGE F1 BUTTON FUNCTIONS ---------------
	public void UIArtworksF1CloseButtonClicking() {
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 0;
	}
	
	public void UIArtworksF1F1OnClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 1;
	}
	
	public void UIArtworksF1F2OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 2;
	}
	
	public void UIArtworksF1F3OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 3;
	}
	
	public void UIArtworksF1G1OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 4;
	}
	
	public void UIArtworksF1G2OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 5;
	}
    
    public void UIArtworksF1G3OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 7;
	}
	
	public void UIArtworksF1FBOffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 6;
	}
	
	public void UIArtworksButtonF101Clicking() {
		IdentifyArtworkButton = 101;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF102Clicking() {
		IdentifyArtworkButton = 102;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF103Clicking() {
		IdentifyArtworkButton = 103;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF104Clicking() {
		IdentifyArtworkButton = 104;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF105Clicking() {
		IdentifyArtworkButton = 105;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF106Clicking() {
		IdentifyArtworkButton = 106;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF107Clicking() {
		IdentifyArtworkButton = 107;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF108Clicking() {
		IdentifyArtworkButton = 108;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF109Clicking() {
		IdentifyArtworkButton = 109;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF110Clicking() {
		IdentifyArtworkButton = 110;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF111Clicking() {
		IdentifyArtworkButton = 111;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF112Clicking() {
		IdentifyArtworkButton = 112;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF113Clicking() {
		IdentifyArtworkButton = 113;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF114Clicking() {
		IdentifyArtworkButton = 114;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF115Clicking() {
		IdentifyArtworkButton = 115;
		Scene37Loading.Scene37Load();
	}

// --------------- ARTWORK PAGE F2 BUTTON FUNCTIONS ---------------
	public void UIArtworksF2CloseButtonClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 0;
	}
	
	public void UIArtworksF2F2OnClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 2;
	}
	
	public void UIArtworksF2F1OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 1;
	}
	
	public void UIArtworksF2F3OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 3;
	}
	
	public void UIArtworksF2G1OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 4;
	}
	
	public void UIArtworksF2G2OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 5;
	}
    
    public void UIArtworksF2G3OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 7;
	}
	
	public void UIArtworksF2FBOffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 6;
	}
	
	public void UIArtworksButtonF201Clicking() {
		IdentifyArtworkButton = 201;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF202Clicking() {
		IdentifyArtworkButton = 202;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF203Clicking() {
		IdentifyArtworkButton = 203;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF204Clicking() {
		IdentifyArtworkButton = 204;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF205Clicking() {
		IdentifyArtworkButton = 205;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF206Clicking() {
		IdentifyArtworkButton = 206;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF207Clicking() {
		IdentifyArtworkButton = 207;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF208Clicking() {
		IdentifyArtworkButton = 208;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF209Clicking() {
		IdentifyArtworkButton = 209;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF210Clicking() {
		IdentifyArtworkButton = 210;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF211Clicking() {
		IdentifyArtworkButton = 211;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF212Clicking() {
		IdentifyArtworkButton = 212;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF213Clicking() {
		IdentifyArtworkButton = 213;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF214Clicking() {
		IdentifyArtworkButton = 214;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF215Clicking() {
		IdentifyArtworkButton = 215;
		Scene37Loading.Scene37Load();
	}
	
// --------------- ARTWORK PAGE F3 BUTTON FUNCTIONS ---------------
	public void UIArtworksF3CloseButtonClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 0;
	}
	
	public void UIArtworksF3F3OnClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 3;
	}
	
	public void UIArtworksF3F1OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 1;
	}
	
	public void UIArtworksF3F2OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 2;
	}
	
	public void UIArtworksF3G1OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 4;
	}
	
	public void UIArtworksF3G2OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 5;
	}
    
    public void UIArtworksF3G3OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 7;
	}
	
	public void UIArtworksF3FBOffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 6;
	}
	
	public void UIArtworksButtonF301Clicking() {
		IdentifyArtworkButton = 301;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF302Clicking() {
		IdentifyArtworkButton = 302;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF303Clicking() {
		IdentifyArtworkButton = 303;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF304Clicking() {
		IdentifyArtworkButton = 304;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF305Clicking() {
		IdentifyArtworkButton = 305;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF306Clicking() {
		IdentifyArtworkButton = 306;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF307Clicking() {
		IdentifyArtworkButton = 307;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF308Clicking() {
		IdentifyArtworkButton = 308;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF309Clicking() {
		IdentifyArtworkButton = 309;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF310Clicking() {
		IdentifyArtworkButton = 310;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF311Clicking() {
		IdentifyArtworkButton = 311;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF312Clicking() {
		IdentifyArtworkButton = 312;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF313Clicking() {
		IdentifyArtworkButton = 313;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF314Clicking() {
		IdentifyArtworkButton = 314;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonF315Clicking() {
		IdentifyArtworkButton = 315;
		Scene37Loading.Scene37Load();
	}
	
// --------------- ARTWORK PAGE G1 BUTTON FUNCTIONS ---------------
	public void UIArtworksG1CloseButtonClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 0;
	}
	
	public void UIArtworksG1G1OnClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 4;
	}
	
	public void UIArtworksG1F1OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 1;
	}
	
	public void UIArtworksG1F2OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 2;
	}
	
	public void UIArtworksG1F3OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 3;
	}
	
	public void UIArtworksG1G2OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 5;
	}
    
    public void UIArtworksG1G3OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 7;
	}
	
	public void UIArtworksG1FBOffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 6;
	}
	
	public void UIArtworksButtonG101Clicking() {
		IdentifyArtworkButton = 401;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG102Clicking() {
		IdentifyArtworkButton = 402;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG103Clicking() {
		IdentifyArtworkButton = 403;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG104Clicking() {
		IdentifyArtworkButton = 404;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG105Clicking() {
		IdentifyArtworkButton = 405;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG106Clicking() {
		IdentifyArtworkButton = 406;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG107Clicking() {
		IdentifyArtworkButton = 407;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG108Clicking() {
		IdentifyArtworkButton = 408;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG109Clicking() {
		IdentifyArtworkButton = 409;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG110Clicking() {
		IdentifyArtworkButton = 410;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG111Clicking() {
		IdentifyArtworkButton = 411;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG112Clicking() {
		IdentifyArtworkButton = 412;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG113Clicking() {
		IdentifyArtworkButton = 413;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG114Clicking() {
		IdentifyArtworkButton = 414;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG115Clicking() {
		IdentifyArtworkButton = 415;
		Scene37Loading.Scene37Load();
	}
	
// --------------- ARTWORK PAGE G2 BUTTON FUNCTIONS ---------------
	public void UIArtworksG2CloseButtonClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 0;
	}
	
	public void UIArtworksG2G2OnClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 5;
	}
	
	public void UIArtworksG2F1OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 1;
	}
	
	public void UIArtworksG2F2OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 2;
	}
	
	public void UIArtworksG2F3OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 3;
	}
	
	public void UIArtworksG2G1OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 4;
	}
    
    public void UIArtworksG2G3OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 7;
	}
	
	public void UIArtworksG2FBOffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 6;
	}
	
	public void UIArtworksButtonG201Clicking() {
		IdentifyArtworkButton = 501;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG202Clicking() {
		IdentifyArtworkButton = 502;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG203Clicking() {
		IdentifyArtworkButton = 503;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG204Clicking() {
		IdentifyArtworkButton = 504;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG205Clicking() {
		IdentifyArtworkButton = 505;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG206Clicking() {
		IdentifyArtworkButton = 506;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG207Clicking() {
		IdentifyArtworkButton = 507;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG208Clicking() {
		IdentifyArtworkButton = 508;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG209Clicking() {
		IdentifyArtworkButton = 509;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG210Clicking() {
		IdentifyArtworkButton = 510;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG211Clicking() {
		IdentifyArtworkButton = 511;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG212Clicking() {
		IdentifyArtworkButton = 512;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG213Clicking() {
		IdentifyArtworkButton = 513;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG214Clicking() {
		IdentifyArtworkButton = 514;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG215Clicking() {
		IdentifyArtworkButton = 515;
		Scene37Loading.Scene37Load();
	}
    
// --------------- ARTWORK PAGE G3 BUTTON FUNCTIONS ---------------
	public void UIArtworksG3CloseButtonClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 0;
	}
	
	public void UIArtworksG3G3OnClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 7;
	}
	
	public void UIArtworksG3F1OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 1;
	}
	
	public void UIArtworksG3F2OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 2;
	}
	
	public void UIArtworksG3F3OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 3;
	}
	
	public void UIArtworksG3G1OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 4;
	}
    
    public void UIArtworksG3G2OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 5;
	}
	
	public void UIArtworksG3FBOffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 6;
	}
	
	public void UIArtworksButtonG301Clicking() {
		IdentifyArtworkButton = 701;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG302Clicking() {
		IdentifyArtworkButton = 702;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG303Clicking() {
		IdentifyArtworkButton = 703;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG304Clicking() {
		IdentifyArtworkButton = 704;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG305Clicking() {
		IdentifyArtworkButton = 705;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG306Clicking() {
		IdentifyArtworkButton = 706;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG307Clicking() {
		IdentifyArtworkButton = 707;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG308Clicking() {
		IdentifyArtworkButton = 708;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG309Clicking() {
		IdentifyArtworkButton = 709;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG310Clicking() {
		IdentifyArtworkButton = 710;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG311Clicking() {
		IdentifyArtworkButton = 711;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG312Clicking() {
		IdentifyArtworkButton = 712;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG313Clicking() {
		IdentifyArtworkButton = 713;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG314Clicking() {
		IdentifyArtworkButton = 714;
		Scene37Loading.Scene37Load();
	}
	
	public void UIArtworksButtonG315Clicking() {
		IdentifyArtworkButton = 715;
		Scene37Loading.Scene37Load();
	}
	
// --------------- ARTWORK PAGE FB BUTTON FUNCTIONS ---------------
	public void UIArtworksFBCloseButtonClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 0;
	}
	
	public void UIArtworksFBFBOnClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 6;
	}
	
	public void UIArtworksFBF1OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 1;
	}
	
	public void UIArtworksFBF2OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 2;
	}
	
	public void UIArtworksFBF3OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 3;
	}
	
	public void UIArtworksFBG1OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 4;
	}
	
	public void UIArtworksFBG2OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 5;
	}
    
    public void UIArtworksFBG3OffClicking() {
		ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 7;
	}
	
	public void UIArtworksButtonFB01Clicking() {
		IdentifyArtworkButton = 601;
		Scene37BLoading.Scene37BLoad();
	}
	
	public void UIArtworksButtonFB02Clicking() {
		IdentifyArtworkButton = 602;
		Scene37BLoading.Scene37BLoad();
	}
	
	public void UIArtworksButtonFB03Clicking() {
		IdentifyArtworkButton = 603;
		Scene37BLoading.Scene37BLoad();
	}
	
	public void UIArtworksButtonFB04Clicking() {
		IdentifyArtworkButton = 604;
		Scene37BLoading.Scene37BLoad();
	}
	
	public void UIArtworksButtonFB05Clicking() {
		IdentifyArtworkButton = 605;
		Scene37BLoading.Scene37BLoad();
	}
	
	public void UIArtworksButtonFB06Clicking() {
		IdentifyArtworkButton = 606;
		Scene37BLoading.Scene37BLoad();
	}
	
	public void UIArtworksButtonFB07Clicking() {
		IdentifyArtworkButton = 607;
		Scene37BLoading.Scene37BLoad();
	}
	
	public void UIArtworksButtonFB08Clicking() {
		IdentifyArtworkButton = 608;
		Scene37BLoading.Scene37BLoad();
	}
	
	public void UIArtworksButtonFB09Clicking() {
		IdentifyArtworkButton = 609;
		Scene37BLoading.Scene37BLoad();
	}
	
	public void UIArtworksButtonFB10Clicking() {
		IdentifyArtworkButton = 610;
		Scene37BLoading.Scene37BLoad();
	}
	
	public void UIArtworksButtonFB11Clicking() {
		IdentifyArtworkButton = 611;
		Scene37BLoading.Scene37BLoad();
	}
	
	public void UIArtworksButtonFB12Clicking() {
		IdentifyArtworkButton = 612;
		Scene37BLoading.Scene37BLoad();
	}
	
	public void UIArtworksButtonFB13Clicking() {
		IdentifyArtworkButton = 613;
		Scene37BLoading.Scene37BLoad();
	}
	
	public void UIArtworksButtonFB14Clicking() {
		IdentifyArtworkButton = 614;
		Scene37BLoading.Scene37BLoad();
	}
	
	public void UIArtworksButtonFB15Clicking() {
		IdentifyArtworkButton = 615;
		Scene37BLoading.Scene37BLoad();
	}
    
// --------------- ARTWORK BONUS BUTTON FUNCTIONS ---------------
    public void UIArtworksF1BonusTextClicking() {
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 11;
    }
    
    public void UIArtworksF2BonusTextClicking() {
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 12;
    }
    
    public void UIArtworksF3BonusTextClicking() {
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 13;
    }
    
    public void UIArtworksG1BonusTextClicking() {
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 14;
    }
    
    public void UIArtworksG2BonusTextClicking() {
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 15;
    }
    
    public void UIArtworksG3BonusTextClicking() {
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 17;
    }
    
    public void UIArtworksFBBonusTextClicking() {
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 8;
        ArtworkPagesFloorIdentifier.ArtworkPagesFloorIdentify = 16;
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}