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

public class MainMenuProfileBookButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button UIProfileTutorialButton;
	public Button UIProfileCreditsButton;
	public Button UIProfileContactButton;
	public Button UIProfileBookCloseButton;
    public Button UIProfileBookSoundsOff;
    public Button UIProfileBookSoundsOn;
    public Button UIProfileBookStoreButton;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	public MainMenuProfileBookEnable MainProfileBookAllDisabling;
	
	public SceneLoad SceneTutorial01Loading;
	public SceneLoad Scene35Loading;
    public SceneLoad Scene39Loading;
    
    public SoundMusicPlaying SoundMusicMuting;
    public SoundMusicPlaying SoundMusicUnmuting;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		Button UIProfileTutorialButtonClick = UIProfileTutorialButton.GetComponent<Button>();
		Button UIProfileCreditsButtonClick = UIProfileCreditsButton.GetComponent<Button>();
		Button UIProfileContactButtonClick = UIProfileContactButton.GetComponent<Button>();
		Button UIProfileBookCloseButtonClick = UIProfileBookCloseButton.GetComponent<Button>();
        Button UIProfileBookSoundsOffClick = UIProfileBookSoundsOff.GetComponent<Button>();
        Button UIProfileBookSoundsOnClick = UIProfileBookSoundsOn.GetComponent<Button>();
        Button UIProfileBookStoreButtonClick = UIProfileBookStoreButton.GetComponent<Button>();
		
		UIProfileTutorialButtonClick.onClick.AddListener(UIProfileTutorialButtonClicking);
		UIProfileCreditsButtonClick.onClick.AddListener(UIProfileCreditsButtonClicking);
		UIProfileContactButtonClick.onClick.AddListener(UIProfileContactButtonClicking);
		UIProfileBookCloseButtonClick.onClick.AddListener(UIProfileBookCloseButtonClicking);
        UIProfileBookSoundsOffClick.onClick.AddListener(UIProfileBookSoundsOffClicking);
        UIProfileBookSoundsOnClick.onClick.AddListener(UIProfileBookSoundsOnClicking);
        UIProfileBookStoreButtonClick.onClick.AddListener(UIProfileBookStoreButtonClicking);
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
	public void UIProfileTutorialButtonClicking() {
		SceneTutorial01Loading.SceneTutorial01Load();
	}
	
	public void UIProfileCreditsButtonClicking() {
		Scene35Loading.Scene35Load();
	}
	
	public void UIProfileContactButtonClicking() {
		Application.OpenURL("https://www.halloftheartthieves.com/contact-us.html");
	}
	
	public void UIProfileBookCloseButtonClicking() {
		MainProfileBookAllDisabling.MainProfileBookAllDisable();
	}
    
    public void UIProfileBookSoundsOffClicking() {
        OpeningMusic.MusicIsMute = 1;
        SoundMusicUnmuting.SoundMusicUnmute();
    }
    
    public void UIProfileBookSoundsOnClicking() {
        OpeningMusic.MusicIsMute = 0;
        SoundMusicMuting.SoundMusicMute();
    }
    
    public void UIProfileBookStoreButtonClicking() {
        Scene39Loading.Scene39Load();
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}