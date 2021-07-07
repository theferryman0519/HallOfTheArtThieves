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

public class MainMenuGhostInnerBookButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Text Variables
	public Text UIGhostArtInfoGhostName;
	public Text UIGhostArtInfoGhostLocation;
	public Text UIGhostArtInfoGhostTheftTimer;
	public Text UIGhostArtInfoGhostTheftAmount;
	public Text UIGhostArtInfoGhostBirthYear;
	public Text UIGhostArtInfoGhostDeathYear;
	public Text UIGhostArtInfoGhostPeriod;
	public Text UIGhostArtInfoGhostNation;
    public Text UIGhostArtInfoGhostLearnLink;
    public Text UIGhostArtInfoGhostClickAmount;
	
	// Ghost Image Buttons
	public Button UIGhostArtImageGhostAF1;
	public Button UIGhostArtImageGhostBF1;
	public Button UIGhostArtImageGhostCF1;
	public Button UIGhostArtImageGhostDF1;
	public Button UIGhostArtImageGhostEF1;
	public Button UIGhostArtImageGhostAF2;
	public Button UIGhostArtImageGhostBF2;
	public Button UIGhostArtImageGhostCF2;
	public Button UIGhostArtImageGhostDF2;
	public Button UIGhostArtImageGhostEF2;
	public Button UIGhostArtImageGhostAF3;
	public Button UIGhostArtImageGhostBF3;
	public Button UIGhostArtImageGhostCF3;
	public Button UIGhostArtImageGhostDF3;
	public Button UIGhostArtImageGhostEF3;
	public Button UIGhostArtImageGhostAG1;
	public Button UIGhostArtImageGhostBG1;
	public Button UIGhostArtImageGhostCG1;
	public Button UIGhostArtImageGhostDG1;
	public Button UIGhostArtImageGhostEG1;
	public Button UIGhostArtImageGhostAG2;
	public Button UIGhostArtImageGhostBG2;
	public Button UIGhostArtImageGhostCG2;
	public Button UIGhostArtImageGhostDG2;
	public Button UIGhostArtImageGhostEG2;
    public Button UIGhostArtImageGhostAG3;
	public Button UIGhostArtImageGhostBG3;
	public Button UIGhostArtImageGhostCG3;
	public Button UIGhostArtImageGhostDG3;
	public Button UIGhostArtImageGhostEG3;
	public Button UIGhostArtImageGhostAFB;
	public Button UIGhostArtImageGhostBFB;
	public Button UIGhostArtImageGhostCFB;
	public Button UIGhostArtImageGhostDFB;
	public Button UIGhostArtImageGhostEFB;
    public Button UIGhostArtInfoGhostLearnLinkButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Disable Objects
    public MainMenuGhostBookEnable FMainUIGhostArtInfoGhostTextDisabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Disable Page Info
		UIGhostArtInfoGhostName.enabled = false;
		UIGhostArtInfoGhostLocation.enabled = false;
		UIGhostArtInfoGhostTheftTimer.enabled = false;
		UIGhostArtInfoGhostTheftAmount.enabled = false;
		UIGhostArtInfoGhostBirthYear.enabled = false;
		UIGhostArtInfoGhostDeathYear.enabled = false;
		UIGhostArtInfoGhostPeriod.enabled = false;
		UIGhostArtInfoGhostNation.enabled = false;
        UIGhostArtInfoGhostLearnLink.enabled = false;
        UIGhostArtInfoGhostClickAmount.enabled = false;
		
		// F1 Ghost Buttons
		Button UIGhostArtImageGhostAF1Click = UIGhostArtImageGhostAF1.GetComponent<Button>();
		Button UIGhostArtImageGhostBF1Click = UIGhostArtImageGhostBF1.GetComponent<Button>();
		Button UIGhostArtImageGhostCF1Click = UIGhostArtImageGhostCF1.GetComponent<Button>();
		Button UIGhostArtImageGhostDF1Click = UIGhostArtImageGhostDF1.GetComponent<Button>();
		Button UIGhostArtImageGhostEF1Click = UIGhostArtImageGhostEF1.GetComponent<Button>();
		
		UIGhostArtImageGhostAF1Click.onClick.AddListener(UIGhostArtImageGhostAF1Clicking);
		UIGhostArtImageGhostBF1Click.onClick.AddListener(UIGhostArtImageGhostBF1Clicking);
		UIGhostArtImageGhostCF1Click.onClick.AddListener(UIGhostArtImageGhostCF1Clicking);
		UIGhostArtImageGhostDF1Click.onClick.AddListener(UIGhostArtImageGhostDF1Clicking);
		UIGhostArtImageGhostEF1Click.onClick.AddListener(UIGhostArtImageGhostEF1Clicking);
		
		// F2 Ghost Buttons
		Button UIGhostArtImageGhostAF2Click = UIGhostArtImageGhostAF2.GetComponent<Button>();
		Button UIGhostArtImageGhostBF2Click = UIGhostArtImageGhostBF2.GetComponent<Button>();
		Button UIGhostArtImageGhostCF2Click = UIGhostArtImageGhostCF2.GetComponent<Button>();
		Button UIGhostArtImageGhostDF2Click = UIGhostArtImageGhostDF2.GetComponent<Button>();
		Button UIGhostArtImageGhostEF2Click = UIGhostArtImageGhostEF2.GetComponent<Button>();
		
		UIGhostArtImageGhostAF2Click.onClick.AddListener(UIGhostArtImageGhostAF2Clicking);
		UIGhostArtImageGhostBF2Click.onClick.AddListener(UIGhostArtImageGhostBF2Clicking);
		UIGhostArtImageGhostCF2Click.onClick.AddListener(UIGhostArtImageGhostCF2Clicking);
		UIGhostArtImageGhostDF2Click.onClick.AddListener(UIGhostArtImageGhostDF2Clicking);
		UIGhostArtImageGhostEF2Click.onClick.AddListener(UIGhostArtImageGhostEF2Clicking);
		
		// F3 Ghost Buttons
		Button UIGhostArtImageGhostAF3Click = UIGhostArtImageGhostAF3.GetComponent<Button>();
		Button UIGhostArtImageGhostBF3Click = UIGhostArtImageGhostBF3.GetComponent<Button>();
		Button UIGhostArtImageGhostCF3Click = UIGhostArtImageGhostCF3.GetComponent<Button>();
		Button UIGhostArtImageGhostDF3Click = UIGhostArtImageGhostDF3.GetComponent<Button>();
		Button UIGhostArtImageGhostEF3Click = UIGhostArtImageGhostEF3.GetComponent<Button>();
		
		UIGhostArtImageGhostAF3Click.onClick.AddListener(UIGhostArtImageGhostAF3Clicking);
		UIGhostArtImageGhostBF3Click.onClick.AddListener(UIGhostArtImageGhostBF3Clicking);
		UIGhostArtImageGhostCF3Click.onClick.AddListener(UIGhostArtImageGhostCF3Clicking);
		UIGhostArtImageGhostDF3Click.onClick.AddListener(UIGhostArtImageGhostDF3Clicking);
		UIGhostArtImageGhostEF3Click.onClick.AddListener(UIGhostArtImageGhostEF3Clicking);
		
		// G1 Ghost Buttons
		Button UIGhostArtImageGhostAG1Click = UIGhostArtImageGhostAG1.GetComponent<Button>();
		Button UIGhostArtImageGhostBG1Click = UIGhostArtImageGhostBG1.GetComponent<Button>();
		Button UIGhostArtImageGhostCG1Click = UIGhostArtImageGhostCG1.GetComponent<Button>();
		Button UIGhostArtImageGhostDG1Click = UIGhostArtImageGhostDG1.GetComponent<Button>();
		Button UIGhostArtImageGhostEG1Click = UIGhostArtImageGhostEG1.GetComponent<Button>();
		
		UIGhostArtImageGhostAG1Click.onClick.AddListener(UIGhostArtImageGhostAG1Clicking);
		UIGhostArtImageGhostBG1Click.onClick.AddListener(UIGhostArtImageGhostBG1Clicking);
		UIGhostArtImageGhostCG1Click.onClick.AddListener(UIGhostArtImageGhostCG1Clicking);
		UIGhostArtImageGhostDG1Click.onClick.AddListener(UIGhostArtImageGhostDG1Clicking);
		UIGhostArtImageGhostEG1Click.onClick.AddListener(UIGhostArtImageGhostEG1Clicking);
		
		// G2 Ghost Buttons
		Button UIGhostArtImageGhostAG2Click = UIGhostArtImageGhostAG2.GetComponent<Button>();
		Button UIGhostArtImageGhostBG2Click = UIGhostArtImageGhostBG2.GetComponent<Button>();
		Button UIGhostArtImageGhostCG2Click = UIGhostArtImageGhostCG2.GetComponent<Button>();
		Button UIGhostArtImageGhostDG2Click = UIGhostArtImageGhostDG2.GetComponent<Button>();
		Button UIGhostArtImageGhostEG2Click = UIGhostArtImageGhostEG2.GetComponent<Button>();
		
		UIGhostArtImageGhostAG2Click.onClick.AddListener(UIGhostArtImageGhostAG2Clicking);
		UIGhostArtImageGhostBG2Click.onClick.AddListener(UIGhostArtImageGhostBG2Clicking);
		UIGhostArtImageGhostCG2Click.onClick.AddListener(UIGhostArtImageGhostCG2Clicking);
		UIGhostArtImageGhostDG2Click.onClick.AddListener(UIGhostArtImageGhostDG2Clicking);
		UIGhostArtImageGhostEG2Click.onClick.AddListener(UIGhostArtImageGhostEG2Clicking);
        
        // G3 Ghost Buttons
		Button UIGhostArtImageGhostAG3Click = UIGhostArtImageGhostAG3.GetComponent<Button>();
		Button UIGhostArtImageGhostBG3Click = UIGhostArtImageGhostBG3.GetComponent<Button>();
		Button UIGhostArtImageGhostCG3Click = UIGhostArtImageGhostCG3.GetComponent<Button>();
		Button UIGhostArtImageGhostDG3Click = UIGhostArtImageGhostDG3.GetComponent<Button>();
		Button UIGhostArtImageGhostEG3Click = UIGhostArtImageGhostEG3.GetComponent<Button>();
		
		UIGhostArtImageGhostAG3Click.onClick.AddListener(UIGhostArtImageGhostAG3Clicking);
		UIGhostArtImageGhostBG3Click.onClick.AddListener(UIGhostArtImageGhostBG3Clicking);
		UIGhostArtImageGhostCG3Click.onClick.AddListener(UIGhostArtImageGhostCG3Clicking);
		UIGhostArtImageGhostDG3Click.onClick.AddListener(UIGhostArtImageGhostDG3Clicking);
		UIGhostArtImageGhostEG3Click.onClick.AddListener(UIGhostArtImageGhostEG3Clicking);
		
		// FB Ghost Buttons
		Button UIGhostArtImageGhostAFBClick = UIGhostArtImageGhostAFB.GetComponent<Button>();
		Button UIGhostArtImageGhostBFBClick = UIGhostArtImageGhostBFB.GetComponent<Button>();
		Button UIGhostArtImageGhostCFBClick = UIGhostArtImageGhostCFB.GetComponent<Button>();
		Button UIGhostArtImageGhostDFBClick = UIGhostArtImageGhostDFB.GetComponent<Button>();
		Button UIGhostArtImageGhostEFBClick = UIGhostArtImageGhostEFB.GetComponent<Button>();
		
		UIGhostArtImageGhostAFBClick.onClick.AddListener(UIGhostArtImageGhostAFBClicking);
		UIGhostArtImageGhostBFBClick.onClick.AddListener(UIGhostArtImageGhostBFBClicking);
		UIGhostArtImageGhostCFBClick.onClick.AddListener(UIGhostArtImageGhostCFBClicking);
		UIGhostArtImageGhostDFBClick.onClick.AddListener(UIGhostArtImageGhostDFBClicking);
		UIGhostArtImageGhostEFBClick.onClick.AddListener(UIGhostArtImageGhostEFBClicking);
        
        // Learn Link Button
        Button UIGhostArtInfoGhostLearnLinkButtonClick = UIGhostArtInfoGhostLearnLinkButton.GetComponent<Button>();
		UIGhostArtInfoGhostLearnLinkButtonClick.onClick.AddListener(UIGhostArtInfoGhostLearnLinkButtonClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- F1 BUTTON FUNCTIONS ---------------
	public void UIGhostArtImageGhostAF1Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameF1A.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationF1A.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerF1A * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftF1A.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearF1A.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearF1A.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodF1A.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationF1A.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksF1A.ToString();
	}
	
	public void UIGhostArtImageGhostBF1Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameF1B.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationF1B.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerF1B * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftF1B.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearF1B.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearF1B.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodF1B.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationF1B.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksF1B.ToString();
	}
	
	public void UIGhostArtImageGhostCF1Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameF1C.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationF1C.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerF1C * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftF1C.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearF1C.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearF1C.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodF1C.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationF1C.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksF1C.ToString();
	}
	
	public void UIGhostArtImageGhostDF1Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameF1D.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationF1D.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerF1D * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftF1D.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearF1D.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearF1D.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodF1D.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationF1D.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksF1D.ToString();
	}
	
	public void UIGhostArtImageGhostEF1Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameF1E.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationF1E.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerF1E * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftF1E.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearF1E.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearF1E.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodF1E.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationF1E.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksF1E.ToString();
	}
	
// --------------- F2 BUTTON FUNCTIONS ---------------
	public void UIGhostArtImageGhostAF2Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameF2A.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationF2A.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerF2A * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftF2A.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearF2A.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearF2A.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodF2A.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationF2A.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksF2A.ToString();
	}
	
	public void UIGhostArtImageGhostBF2Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameF2B.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationF2B.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerF2B * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftF2B.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearF2B.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearF2B.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodF2B.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationF2B.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksF2B.ToString();
	}
	
	public void UIGhostArtImageGhostCF2Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameF2C.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationF2C.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerF2C * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftF2C.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearF2C.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearF2C.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodF2C.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationF2C.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksF2C.ToString();
	}
	
	public void UIGhostArtImageGhostDF2Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameF2D.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationF2D.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerF2D * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftF2D.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearF2D.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearF2D.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodF2D.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationF2D.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksF2D.ToString();
	}
	
	public void UIGhostArtImageGhostEF2Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameF2E.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationF2E.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerF2E * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftF2E.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearF2E.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearF2E.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodF2E.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationF2E.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksF2E.ToString();
	}
	
// --------------- F3 BUTTON FUNCTIONS ---------------
	public void UIGhostArtImageGhostAF3Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameF3A.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationF3A.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerF3A * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftF3A.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearF3A.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearF3A.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodF3A.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationF3A.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksF3A.ToString();
	}
	
	public void UIGhostArtImageGhostBF3Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameF3B.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationF3B.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerF3B * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftF3B.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearF3B.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearF3B.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodF3B.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationF3B.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksF3B.ToString();
	}
	
	public void UIGhostArtImageGhostCF3Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameF3C.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationF3C.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerF3C * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftF3C.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearF3C.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearF3C.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodF3C.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationF3C.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksF3C.ToString();
	}
	
	public void UIGhostArtImageGhostDF3Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameF3D.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationF3D.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerF3D * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftF3D.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearF3D.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearF3D.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodF3D.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationF3D.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksF3D.ToString();
	}
	
	public void UIGhostArtImageGhostEF3Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameF3E.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationF3E.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerF3E * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftF3E.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearF3E.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearF3E.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodF3E.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationF3E.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksF3E.ToString();
	}
	
// --------------- G1 BUTTON FUNCTIONS ---------------
	public void UIGhostArtImageGhostAG1Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameG1A.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationG1A.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerG1A * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftG1A.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearG1A.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearG1A.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodG1A.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationG1A.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksG1A.ToString();
	}
	
	public void UIGhostArtImageGhostBG1Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameG1B.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationG1B.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerG1B * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftG1B.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearG1B.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearG1B.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodG1B.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationG1B.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksG1B.ToString();
	}
	
	public void UIGhostArtImageGhostCG1Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameG1C.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationG1C.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerG1C * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftG1C.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearG1C.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearG1C.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodG1C.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationG1C.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksG1C.ToString();
	}
	
	public void UIGhostArtImageGhostDG1Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameG1D.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationG1D.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerG1D * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftG1D.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearG1D.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearG1D.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodG1D.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationG1D.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksG1D.ToString();
	}
	
	public void UIGhostArtImageGhostEG1Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameG1E.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationG1E.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerG1E * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftG1E.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearG1E.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearG1E.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodG1E.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationG1E.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksG1E.ToString();
	}
	
// --------------- G2 BUTTON FUNCTIONS ---------------
	public void UIGhostArtImageGhostAG2Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameG2A.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationG2A.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerG2A * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftG2A.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearG2A.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearG2A.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodG2A.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationG2A.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksG2A.ToString();
	}
	
	public void UIGhostArtImageGhostBG2Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameG2B.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationG2B.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerG2B * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftG2B.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearG2B.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearG2B.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodG2B.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationG2B.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksG2B.ToString();
	}
	
	public void UIGhostArtImageGhostCG2Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameG2C.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationG2C.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerG2C * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftG2C.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearG2C.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearG2C.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodG2C.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationG2C.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksG2C.ToString();
	}
	
	public void UIGhostArtImageGhostDG2Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameG2D.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationG2D.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerG2D * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftG2D.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearG2D.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearG2D.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodG2D.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationG2D.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksG2D.ToString();
	}
	
	public void UIGhostArtImageGhostEG2Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameG2E.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationG2E.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerG2E * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftG2E.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearG2E.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearG2E.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodG2E.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationG2E.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksG2E.ToString();
	}
    
// --------------- G3 BUTTON FUNCTIONS ---------------
	public void UIGhostArtImageGhostAG3Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameG3A.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationG3A.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerG3A * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftG3A.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearG3A.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearG3A.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodG3A.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationG3A.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksG3A.ToString();
	}
	
	public void UIGhostArtImageGhostBG3Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameG3B.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationG3B.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerG3B * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftG3B.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearG3B.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearG3B.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodG3B.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationG3B.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksG3B.ToString();
	}
	
	public void UIGhostArtImageGhostCG3Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameG3C.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationG3C.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerG3C * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftG3C.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearG3C.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearG3C.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodG3C.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationG3C.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksG3C.ToString();
	}
	
	public void UIGhostArtImageGhostDG3Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameG3D.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationG3D.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerG3D * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftG3D.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearG3D.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearG3D.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodG3D.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationG3D.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksG3D.ToString();
	}
	
	public void UIGhostArtImageGhostEG3Clicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameG3E.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationG3E.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerG3E * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftG3E.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearG3E.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearG3E.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodG3E.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationG3E.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksG3E.ToString();
	}
	
// --------------- FB BUTTON FUNCTIONS ---------------
	public void UIGhostArtImageGhostAFBClicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameFBA.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationFBA.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerFBA * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftFBA.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearFBA.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearFBA.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodFBA.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationFBA.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksFBA.ToString();
	}
	
	public void UIGhostArtImageGhostBFBClicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameFBB.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationFBB.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerFBB * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftFBB.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearFBB.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearFBB.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodFBB.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationFBB.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksFBB.ToString();
	}
	
	public void UIGhostArtImageGhostCFBClicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameFBC.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationFBC.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerFBC * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftFBC.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearFBC.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearFBC.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodFBC.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationFBC.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksFBC.ToString();
	}
	
	public void UIGhostArtImageGhostDFBClicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameFBD.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationFBD.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerFBD * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftFBD.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearFBD.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearFBD.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodFBD.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationFBD.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksFBD.ToString();
	}
	
	public void UIGhostArtImageGhostEFBClicking() {
        // Disable Text
        FMainUIGhostArtInfoGhostTextDisabling.FMainUIGhostArtInfoGhostTextDisable();
        
		// Enable Page Objects
		UIGhostArtInfoGhostName.enabled = true;
		UIGhostArtInfoGhostLocation.enabled = true;
		UIGhostArtInfoGhostTheftTimer.enabled = true;
		UIGhostArtInfoGhostTheftAmount.enabled = true;
		UIGhostArtInfoGhostBirthYear.enabled = true;
		UIGhostArtInfoGhostDeathYear.enabled = true;
		UIGhostArtInfoGhostPeriod.enabled = true;
		UIGhostArtInfoGhostNation.enabled = true;
        UIGhostArtInfoGhostLearnLink.enabled = true;
        UIGhostArtInfoGhostClickAmount.enabled = true;
		
		// Fill Page Text
		UIGhostArtInfoGhostName.text = GhostInformation.GhostInfoNameFBE.ToString();
		UIGhostArtInfoGhostLocation.text = "Found In: " + GhostInformation.GhostInfoLocationFBE.ToString();
		UIGhostArtInfoGhostTheftTimer.text = "Theft Timer: " + (GhostInformation.GhostInfoTimerFBE * 0.0167f).ToString("#,#") + " Minutes";
		UIGhostArtInfoGhostTheftAmount.text = "Theft Amount: " + GhostInformation.GhostInfoTheftFBE.ToString() + " Coins";
		UIGhostArtInfoGhostBirthYear.text = "Born In:" + "\n" + GhostInformation.GhostInfoBirthYearFBE.ToString();
		UIGhostArtInfoGhostDeathYear.text = "Died In:" + "\n" + GhostInformation.GhostInfoDeathYearFBE.ToString();
		UIGhostArtInfoGhostPeriod.text = "Art Period: " + GhostInformation.GhostInfoPeriodFBE.ToString();
		UIGhostArtInfoGhostNation.text = "Nationality: " + GhostInformation.GhostInfoNationFBE.ToString();
        UIGhostArtInfoGhostClickAmount.text = "Monthly Clicks: " + DataFillingInformation.DBGhostMonthlyClicksFBE.ToString();
	}
    
// --------------- G2 BUTTON FUNCTIONS ---------------
    public void UIGhostArtInfoGhostLearnLinkButtonClicking() {
        // F1
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameF1A.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF1A);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameF1B.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF1B);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameF1C.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF1C);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameF1D.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF1D);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameF1E.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF1E);
        }
        
        // F2
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameF2A.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF2A);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameF2B.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF2B);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameF2C.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF2C);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameF2D.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF2D);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameF2E.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF2E);
        }
        
        // F3
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameF3A.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF3A);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameF3B.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF3B);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameF3C.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF3C);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameF3D.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF3D);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameF3E.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkF3E);
        }
        
        // G1
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameG1A.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkG1A);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameG1B.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkG1B);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameG1C.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkG1C);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameG1D.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkG1D);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameG1E.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkG1E);
        }
        
        // G2
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameG2A.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkG2A);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameG2B.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkG2B);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameG2C.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkG2C);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameG2D.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkG2D);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameG2E.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkG2E);
        }
        
        // G3
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameG3A.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkG3A);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameG3B.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkG3B);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameG3C.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkG3C);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameG3D.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkG3D);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameG3E.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkG3E);
        }
        
        // FB
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameFBA.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkFBA);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameFBB.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkFBB);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameFBC.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkFBC);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameFBD.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkFBD);
        }
        
        if (UIGhostArtInfoGhostName.text == GhostInformation.GhostInfoNameFBE.ToString()) {
            Application.OpenURL(GhostInformation.GhostInfoLearnLinkFBE);
        }
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}