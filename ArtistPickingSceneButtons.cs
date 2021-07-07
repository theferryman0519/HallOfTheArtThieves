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

public class ArtistPickingSceneButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Buttons
    public Button UIArtistPickingAHButtonOff;
    public Button UIArtistPickingIPButtonOff;
    public Button UIArtistPickingQZButtonOff;
    public Button UIArtistPickingAHButtonOn;
    public Button UIArtistPickingIPButtonOn;
    public Button UIArtistPickingQZButtonOn;
    public Button UIArtistPickingBackButton;
    
    // Toggles Buttons Off
    // A through H
    public Button UIArtistAHToggleOff1;
    public Button UIArtistAHToggleOff2;
    public Button UIArtistAHToggleOff3;
    public Button UIArtistAHToggleOff4;
    public Button UIArtistAHToggleOff5;
    public Button UIArtistAHToggleOff6;
    public Button UIArtistAHToggleOff7;
    public Button UIArtistAHToggleOff8;
    public Button UIArtistAHToggleOff9;
    
    // I through P
    public Button UIArtistIPToggleOff1;
    public Button UIArtistIPToggleOff2;
    public Button UIArtistIPToggleOff3;
    public Button UIArtistIPToggleOff4;
    public Button UIArtistIPToggleOff5;
    public Button UIArtistIPToggleOff6;
    public Button UIArtistIPToggleOff7;
    public Button UIArtistIPToggleOff8;
    public Button UIArtistIPToggleOff9;
    
    // Q through Z
    public Button UIArtistQZToggleOff1;
    public Button UIArtistQZToggleOff2;
    public Button UIArtistQZToggleOff3;
    public Button UIArtistQZToggleOff4;
    public Button UIArtistQZToggleOff5;
    public Button UIArtistQZToggleOff6;
    public Button UIArtistQZToggleOff7;
    public Button UIArtistQZToggleOff8;
    public Button UIArtistQZToggleOff9;
    
    // Toggles Buttons On
    // A through H
    public Button UIArtistAHToggleOn1;
    public Button UIArtistAHToggleOn2;
    public Button UIArtistAHToggleOn3;
    public Button UIArtistAHToggleOn4;
    public Button UIArtistAHToggleOn5;
    public Button UIArtistAHToggleOn6;
    public Button UIArtistAHToggleOn7;
    public Button UIArtistAHToggleOn8;
    public Button UIArtistAHToggleOn9;
    
    // I through P
    public Button UIArtistIPToggleOn1;
    public Button UIArtistIPToggleOn2;
    public Button UIArtistIPToggleOn3;
    public Button UIArtistIPToggleOn4;
    public Button UIArtistIPToggleOn5;
    public Button UIArtistIPToggleOn6;
    public Button UIArtistIPToggleOn7;
    public Button UIArtistIPToggleOn8;
    public Button UIArtistIPToggleOn9;
    
    // Q through Z
    public Button UIArtistQZToggleOn1;
    public Button UIArtistQZToggleOn2;
    public Button UIArtistQZToggleOn3;
    public Button UIArtistQZToggleOn4;
    public Button UIArtistQZToggleOn5;
    public Button UIArtistQZToggleOn6;
    public Button UIArtistQZToggleOn7;
    public Button UIArtistQZToggleOn8;
    public Button UIArtistQZToggleOn9;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int ArtistPickingAH;
    public static int ArtistPickingIP;
    public static int ArtistPickingQZ;
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Enable Artist Picking Pages
    public ArtistPickingSceneEnable ArtistPickingAHEnabling;
    public ArtistPickingSceneEnable ArtistPickingIPEnabling;
    public ArtistPickingSceneEnable ArtistPickingQZEnabling;
    
    // Disable Artist Picking Pages
    public ArtistPickingSceneEnable ArtistPickingAHDisabling;
    public ArtistPickingSceneEnable ArtistPickingIPDisabling;
    public ArtistPickingSceneEnable ArtistPickingQZDisabling;
    
    // Load Options Scene
    public SceneLoad Scene03Loading;
    
    // Enable & Disable Toggles
    public ArtistPickingInformation ArtistPickingAllOffToggling;
    
    public ArtistPickingInformation ArtistPickingAHOn1On;
    public ArtistPickingInformation ArtistPickingAHOn2On;
    public ArtistPickingInformation ArtistPickingAHOn3On;
    public ArtistPickingInformation ArtistPickingAHOn4On;
    public ArtistPickingInformation ArtistPickingAHOn5On;
    public ArtistPickingInformation ArtistPickingAHOn6On;
    public ArtistPickingInformation ArtistPickingAHOn7On;
    public ArtistPickingInformation ArtistPickingAHOn8On;
    public ArtistPickingInformation ArtistPickingAHOn9On;
    public ArtistPickingInformation ArtistPickingIPOn1On;
    public ArtistPickingInformation ArtistPickingIPOn2On;
    public ArtistPickingInformation ArtistPickingIPOn3On;
    public ArtistPickingInformation ArtistPickingIPOn4On;
    public ArtistPickingInformation ArtistPickingIPOn5On;
    public ArtistPickingInformation ArtistPickingIPOn6On;
    public ArtistPickingInformation ArtistPickingIPOn7On;
    public ArtistPickingInformation ArtistPickingIPOn8On;
    public ArtistPickingInformation ArtistPickingIPOn9On;
    public ArtistPickingInformation ArtistPickingQZOn1On;
    public ArtistPickingInformation ArtistPickingQZOn2On;
    public ArtistPickingInformation ArtistPickingQZOn3On;
    public ArtistPickingInformation ArtistPickingQZOn4On;
    public ArtistPickingInformation ArtistPickingQZOn5On;
    public ArtistPickingInformation ArtistPickingQZOn6On;
    public ArtistPickingInformation ArtistPickingQZOn7On;
    public ArtistPickingInformation ArtistPickingQZOn8On;
    public ArtistPickingInformation ArtistPickingQZOn9On;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		ArtistPickingAH = 0;
        ArtistPickingIP = 0;
        ArtistPickingQZ = 0;
        
        Button UIArtistPickingAHButtonOffClick = UIArtistPickingAHButtonOff.GetComponent<Button>();
        Button UIArtistPickingIPButtonOffClick = UIArtistPickingIPButtonOff.GetComponent<Button>();
        Button UIArtistPickingQZButtonOffClick = UIArtistPickingQZButtonOff.GetComponent<Button>();
        Button UIArtistPickingAHButtonOnClick = UIArtistPickingAHButtonOn.GetComponent<Button>();
        Button UIArtistPickingIPButtonOnClick = UIArtistPickingIPButtonOn.GetComponent<Button>();
        Button UIArtistPickingQZButtonOnClick = UIArtistPickingQZButtonOn.GetComponent<Button>();
        Button UIArtistPickingBackButtonClick = UIArtistPickingBackButton.GetComponent<Button>();
		
		UIArtistPickingAHButtonOffClick.onClick.AddListener(UIArtistPickingAHButtonOffClicking);
        UIArtistPickingIPButtonOffClick.onClick.AddListener(UIArtistPickingIPButtonOffClicking);
        UIArtistPickingQZButtonOffClick.onClick.AddListener(UIArtistPickingQZButtonOffClicking);
        UIArtistPickingAHButtonOnClick.onClick.AddListener(UIArtistPickingAHButtonOnClicking);
        UIArtistPickingIPButtonOnClick.onClick.AddListener(UIArtistPickingIPButtonOnClicking);
        UIArtistPickingQZButtonOnClick.onClick.AddListener(UIArtistPickingQZButtonOnClicking);
        UIArtistPickingBackButtonClick.onClick.AddListener(UIArtistPickingBackButtonClicking);
        
        // Toggles Off
        // A through H
        Button UIArtistAHToggleOff1Click = UIArtistAHToggleOff1.GetComponent<Button>();
        Button UIArtistAHToggleOff2Click = UIArtistAHToggleOff2.GetComponent<Button>();
        Button UIArtistAHToggleOff3Click = UIArtistAHToggleOff3.GetComponent<Button>();
        Button UIArtistAHToggleOff4Click = UIArtistAHToggleOff4.GetComponent<Button>();
        Button UIArtistAHToggleOff5Click = UIArtistAHToggleOff5.GetComponent<Button>();
        Button UIArtistAHToggleOff6Click = UIArtistAHToggleOff6.GetComponent<Button>();
        Button UIArtistAHToggleOff7Click = UIArtistAHToggleOff7.GetComponent<Button>();
        Button UIArtistAHToggleOff8Click = UIArtistAHToggleOff8.GetComponent<Button>();
        Button UIArtistAHToggleOff9Click = UIArtistAHToggleOff9.GetComponent<Button>();
		
		UIArtistAHToggleOff1Click.onClick.AddListener(UIArtistAHToggleOff1Clicking);
        UIArtistAHToggleOff2Click.onClick.AddListener(UIArtistAHToggleOff2Clicking);
        UIArtistAHToggleOff3Click.onClick.AddListener(UIArtistAHToggleOff3Clicking);
        UIArtistAHToggleOff4Click.onClick.AddListener(UIArtistAHToggleOff4Clicking);
        UIArtistAHToggleOff5Click.onClick.AddListener(UIArtistAHToggleOff5Clicking);
        UIArtistAHToggleOff6Click.onClick.AddListener(UIArtistAHToggleOff6Clicking);
        UIArtistAHToggleOff7Click.onClick.AddListener(UIArtistAHToggleOff7Clicking);
        UIArtistAHToggleOff8Click.onClick.AddListener(UIArtistAHToggleOff8Clicking);
        UIArtistAHToggleOff9Click.onClick.AddListener(UIArtistAHToggleOff9Clicking);
        
        // I through P
        Button UIArtistIPToggleOff1Click = UIArtistIPToggleOff1.GetComponent<Button>();
        Button UIArtistIPToggleOff2Click = UIArtistIPToggleOff2.GetComponent<Button>();
        Button UIArtistIPToggleOff3Click = UIArtistIPToggleOff3.GetComponent<Button>();
        Button UIArtistIPToggleOff4Click = UIArtistIPToggleOff4.GetComponent<Button>();
        Button UIArtistIPToggleOff5Click = UIArtistIPToggleOff5.GetComponent<Button>();
        Button UIArtistIPToggleOff6Click = UIArtistIPToggleOff6.GetComponent<Button>();
        Button UIArtistIPToggleOff7Click = UIArtistIPToggleOff7.GetComponent<Button>();
        Button UIArtistIPToggleOff8Click = UIArtistIPToggleOff8.GetComponent<Button>();
        Button UIArtistIPToggleOff9Click = UIArtistIPToggleOff9.GetComponent<Button>();
		
		UIArtistIPToggleOff1Click.onClick.AddListener(UIArtistIPToggleOff1Clicking);
        UIArtistIPToggleOff2Click.onClick.AddListener(UIArtistIPToggleOff2Clicking);
        UIArtistIPToggleOff3Click.onClick.AddListener(UIArtistIPToggleOff3Clicking);
        UIArtistIPToggleOff4Click.onClick.AddListener(UIArtistIPToggleOff4Clicking);
        UIArtistIPToggleOff5Click.onClick.AddListener(UIArtistIPToggleOff5Clicking);
        UIArtistIPToggleOff6Click.onClick.AddListener(UIArtistIPToggleOff6Clicking);
        UIArtistIPToggleOff7Click.onClick.AddListener(UIArtistIPToggleOff7Clicking);
        UIArtistIPToggleOff8Click.onClick.AddListener(UIArtistIPToggleOff8Clicking);
        UIArtistIPToggleOff9Click.onClick.AddListener(UIArtistIPToggleOff9Clicking);
        
        // Q through Z
        Button UIArtistQZToggleOff1Click = UIArtistQZToggleOff1.GetComponent<Button>();
        Button UIArtistQZToggleOff2Click = UIArtistQZToggleOff2.GetComponent<Button>();
        Button UIArtistQZToggleOff3Click = UIArtistQZToggleOff3.GetComponent<Button>();
        Button UIArtistQZToggleOff4Click = UIArtistQZToggleOff4.GetComponent<Button>();
        Button UIArtistQZToggleOff5Click = UIArtistQZToggleOff5.GetComponent<Button>();
        Button UIArtistQZToggleOff6Click = UIArtistQZToggleOff6.GetComponent<Button>();
        Button UIArtistQZToggleOff7Click = UIArtistQZToggleOff7.GetComponent<Button>();
        Button UIArtistQZToggleOff8Click = UIArtistQZToggleOff8.GetComponent<Button>();
        Button UIArtistQZToggleOff9Click = UIArtistQZToggleOff9.GetComponent<Button>();
		
		UIArtistQZToggleOff1Click.onClick.AddListener(UIArtistQZToggleOff1Clicking);
        UIArtistQZToggleOff2Click.onClick.AddListener(UIArtistQZToggleOff2Clicking);
        UIArtistQZToggleOff3Click.onClick.AddListener(UIArtistQZToggleOff3Clicking);
        UIArtistQZToggleOff4Click.onClick.AddListener(UIArtistQZToggleOff4Clicking);
        UIArtistQZToggleOff5Click.onClick.AddListener(UIArtistQZToggleOff5Clicking);
        UIArtistQZToggleOff6Click.onClick.AddListener(UIArtistQZToggleOff6Clicking);
        UIArtistQZToggleOff7Click.onClick.AddListener(UIArtistQZToggleOff7Clicking);
        UIArtistQZToggleOff8Click.onClick.AddListener(UIArtistQZToggleOff8Clicking);
        UIArtistQZToggleOff9Click.onClick.AddListener(UIArtistQZToggleOff9Clicking);
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
    public void UIArtistPickingAHButtonOffClicking() {
        // Disable All Pages
        ArtistPickingAHDisabling.ArtistPickingAHDisable();
        ArtistPickingIPDisabling.ArtistPickingIPDisable();
        ArtistPickingQZDisabling.ArtistPickingQZDisable();
        ArtistPickingAH = 0;
        ArtistPickingIP = 0;
        ArtistPickingQZ = 0;
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Enable Page
        ArtistPickingAHEnabling.ArtistPickingAHEnable();
        ArtistPickingAH = 1;
    }
    
    public void UIArtistPickingIPButtonOffClicking() {
        // Disable All Pages
        ArtistPickingAHDisabling.ArtistPickingAHDisable();
        ArtistPickingIPDisabling.ArtistPickingIPDisable();
        ArtistPickingQZDisabling.ArtistPickingQZDisable();
        ArtistPickingAH = 0;
        ArtistPickingIP = 0;
        ArtistPickingQZ = 0;
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Enable Page
        ArtistPickingIPEnabling.ArtistPickingIPEnable();
        ArtistPickingIP = 1;
    }
    
    public void UIArtistPickingQZButtonOffClicking() {
        // Disable All Pages
        ArtistPickingAHDisabling.ArtistPickingAHDisable();
        ArtistPickingIPDisabling.ArtistPickingIPDisable();
        ArtistPickingQZDisabling.ArtistPickingQZDisable();
        ArtistPickingAH = 0;
        ArtistPickingIP = 0;
        ArtistPickingQZ = 0;
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Enable Page
        ArtistPickingQZEnabling.ArtistPickingQZEnable();
        ArtistPickingQZ = 1;
    }
    
    public void UIArtistPickingAHButtonOnClicking() {
        // Disable All Pages
        ArtistPickingAHDisabling.ArtistPickingAHDisable();
        ArtistPickingIPDisabling.ArtistPickingIPDisable();
        ArtistPickingQZDisabling.ArtistPickingQZDisable();
        ArtistPickingAH = 0;
        ArtistPickingIP = 0;
        ArtistPickingQZ = 0;
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Enable Page
        ArtistPickingAHEnabling.ArtistPickingAHEnable();
        ArtistPickingAH = 1;
    }
    
    public void UIArtistPickingIPButtonOnClicking() {
        // Disable All Pages
        ArtistPickingAHDisabling.ArtistPickingAHDisable();
        ArtistPickingIPDisabling.ArtistPickingIPDisable();
        ArtistPickingQZDisabling.ArtistPickingQZDisable();
        ArtistPickingAH = 0;
        ArtistPickingIP = 0;
        ArtistPickingQZ = 0;
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Enable Page
        ArtistPickingIPEnabling.ArtistPickingIPEnable();
        ArtistPickingIP = 1;
    }
    
    public void UIArtistPickingQZButtonOnClicking() {
        // Disable All Pages
        ArtistPickingAHDisabling.ArtistPickingAHDisable();
        ArtistPickingIPDisabling.ArtistPickingIPDisable();
        ArtistPickingQZDisabling.ArtistPickingQZDisable();
        ArtistPickingAH = 0;
        ArtistPickingIP = 0;
        ArtistPickingQZ = 0;
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Enable Page
        ArtistPickingQZEnabling.ArtistPickingQZEnable();
        ArtistPickingQZ = 1;
    }
    
    public void UIArtistPickingBackButtonClicking() {
        Scene03Loading.Scene03Load();
    }
    
// --------------- TOGGLE BUTTON FUNCTIONS ---------------
    public void UIArtistAHToggleOff1Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingAHOn1On.ArtistPickingAHOn1();
        DataFillingInformation.DBPlayerFavArtist = "Michelangelo Buonarotti".ToString();
    }
    
    public void UIArtistAHToggleOff2Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingAHOn2On.ArtistPickingAHOn2();
        DataFillingInformation.DBPlayerFavArtist = "Michelangelo Merisi Caravaggio".ToString();
    }
    
    public void UIArtistAHToggleOff3Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingAHOn3On.ArtistPickingAHOn3();
        DataFillingInformation.DBPlayerFavArtist = "Paul Cezanne".ToString();
    }
    
    public void UIArtistAHToggleOff4Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingAHOn4On.ArtistPickingAHOn4();
        DataFillingInformation.DBPlayerFavArtist = "Marc Chagall".ToString();
    }
    
    public void UIArtistAHToggleOff5Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingAHOn5On.ArtistPickingAHOn5();
        DataFillingInformation.DBPlayerFavArtist = "Salvador Dali".ToString();
    }
    
    public void UIArtistAHToggleOff6Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingAHOn6On.ArtistPickingAHOn6();
        DataFillingInformation.DBPlayerFavArtist = "Edgar Degas".ToString();
    }
    
    public void UIArtistAHToggleOff7Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingAHOn7On.ArtistPickingAHOn7();
        DataFillingInformation.DBPlayerFavArtist = "Albrecht Durer".ToString();
    }
    
    public void UIArtistAHToggleOff8Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingAHOn8On.ArtistPickingAHOn8();
        DataFillingInformation.DBPlayerFavArtist = "Francisco Goya".ToString();
    }
    
    public void UIArtistAHToggleOff9Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingAHOn9On.ArtistPickingAHOn9();
        DataFillingInformation.DBPlayerFavArtist = "Edward Hopper".ToString();
    }
    
    public void UIArtistIPToggleOff1Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingIPOn1On.ArtistPickingIPOn1();
        DataFillingInformation.DBPlayerFavArtist = "Frida Kahlo".ToString();
    }
    
    public void UIArtistIPToggleOff2Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingIPOn2On.ArtistPickingIPOn2();
        DataFillingInformation.DBPlayerFavArtist = "Edouard Manet".ToString();
    }
    
    public void UIArtistIPToggleOff3Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingIPOn3On.ArtistPickingIPOn3();
        DataFillingInformation.DBPlayerFavArtist = "Henri Matisse".ToString();
    }
    
    public void UIArtistIPToggleOff4Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingIPOn4On.ArtistPickingIPOn4();
        DataFillingInformation.DBPlayerFavArtist = "Joan Miro".ToString();
    }
    
    public void UIArtistIPToggleOff5Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingIPOn5On.ArtistPickingIPOn5();
        DataFillingInformation.DBPlayerFavArtist = "Claude Monet".ToString();
    }
    
    public void UIArtistIPToggleOff6Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingIPOn6On.ArtistPickingIPOn6();
        DataFillingInformation.DBPlayerFavArtist = "Edvard Munch".ToString();
    }
    
    public void UIArtistIPToggleOff7Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingIPOn7On.ArtistPickingIPOn7();
        DataFillingInformation.DBPlayerFavArtist = "Georgia O'Keeffe".ToString();
    }
    
    public void UIArtistIPToggleOff8Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingIPOn8On.ArtistPickingIPOn8();
        DataFillingInformation.DBPlayerFavArtist = "Pablo Picasso".ToString();
    }
    
    public void UIArtistIPToggleOff9Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingIPOn9On.ArtistPickingIPOn9();
        DataFillingInformation.DBPlayerFavArtist = "Jackson Pollock".ToString();
    }
    
    public void UIArtistQZToggleOff1Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingQZOn1On.ArtistPickingQZOn1();
        DataFillingInformation.DBPlayerFavArtist = "Peter Paul Rubens".ToString();
    }
    
    public void UIArtistQZToggleOff2Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingQZOn2On.ArtistPickingQZOn2();
        DataFillingInformation.DBPlayerFavArtist = "Raphael Sanzio".ToString();
    }
    
    public void UIArtistQZToggleOff3Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingQZOn3On.ArtistPickingQZOn3();
        DataFillingInformation.DBPlayerFavArtist = "Vincent van Gogh".ToString();
    }
    
    public void UIArtistQZToggleOff4Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingQZOn4On.ArtistPickingQZOn4();
        DataFillingInformation.DBPlayerFavArtist = "Rembrandt van Rijn".ToString();
    }
    
    public void UIArtistQZToggleOff5Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingQZOn5On.ArtistPickingQZOn5();
        DataFillingInformation.DBPlayerFavArtist = "Jacob van Ruisdael".ToString();
    }
    
    public void UIArtistQZToggleOff6Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingQZOn6On.ArtistPickingQZOn6();
        DataFillingInformation.DBPlayerFavArtist = "Tiziano Vecelli".ToString();
    }
    
    public void UIArtistQZToggleOff7Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingQZOn7On.ArtistPickingQZOn7();
        DataFillingInformation.DBPlayerFavArtist = "Johannes Vermeer".ToString();
    }
    
    public void UIArtistQZToggleOff8Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingQZOn8On.ArtistPickingQZOn8();
        DataFillingInformation.DBPlayerFavArtist = "Leonardo da Vinci".ToString();
    }
    
    public void UIArtistQZToggleOff9Clicking() {
        // Turn Off All Toggles
        ArtistPickingAllOffToggling.ArtistPickingAllOffToggle();
        
        // Turn On Toggle
        ArtistPickingQZOn9On.ArtistPickingQZOn9();
        DataFillingInformation.DBPlayerFavArtist = "Andy Warhol".ToString();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}