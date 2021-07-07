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

public class MainMenuScrollBookButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Close Sketchbook Button
	public Button UIScrollBookCloseButton;
	
	// Page Buttons
	public Button UIScrollBookNext1Page;
	public Button UIScrollBookPrior2Page;
	public Button UIScrollBookNext2Page;
	public Button UIScrollBookPrior3Page;
	public Button UIScrollBookEnd3Page;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Enable Objects
	public MainMenuScrollBookEnable MainScrollBookPage1Enabling;
	public MainMenuScrollBookEnable MainScrollBookPage2Enabling;
	public MainMenuScrollBookEnable MainScrollBookPage3Enabling;
	
	// Disable Objects
	public MainMenuScrollBookEnable MainScrollBookPage1Disabling;
	public MainMenuScrollBookEnable MainScrollBookPage2Disabling;
	public MainMenuScrollBookEnable MainScrollBookPage3Disabling;
	public MainMenuScrollBookEnable MainScrollBookAllDisabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		Button UIScrollBookCloseButtonClick = UIScrollBookCloseButton.GetComponent<Button>();
		Button UIScrollBookNext1PageClick = UIScrollBookNext1Page.GetComponent<Button>();
		Button UIScrollBookPrior2PageClick = UIScrollBookPrior2Page.GetComponent<Button>();
		Button UIScrollBookNext2PageClick = UIScrollBookNext2Page.GetComponent<Button>();
		Button UIScrollBookPrior3PageClick = UIScrollBookPrior3Page.GetComponent<Button>();
		Button UIScrollBookEnd3PageClick = UIScrollBookEnd3Page.GetComponent<Button>();
		
		UIScrollBookCloseButtonClick.onClick.AddListener(UIScrollBookCloseButtonClicking);
		UIScrollBookNext1PageClick.onClick.AddListener(UIScrollBookNext1PageClicking);
		UIScrollBookPrior2PageClick.onClick.AddListener(UIScrollBookPrior2PageClicking);
		UIScrollBookNext2PageClick.onClick.AddListener(UIScrollBookNext2PageClicking);
		UIScrollBookPrior3PageClick.onClick.AddListener(UIScrollBookPrior3PageClicking);
		UIScrollBookEnd3PageClick.onClick.AddListener(UIScrollBookEnd3PageClicking);
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
	public void UIScrollBookCloseButtonClicking() {
		MainScrollBookAllDisabling.MainScrollBookAllDisable();
	}
	
	public void UIScrollBookNext1PageClicking() {
		MainScrollBookPage1Disabling.MainScrollBookPage1Disable();
		MainScrollBookPage2Enabling.MainScrollBookPage2Enable();
	}
	
	public void UIScrollBookPrior2PageClicking() {
		MainScrollBookPage2Disabling.MainScrollBookPage2Disable();
		MainScrollBookPage1Enabling.MainScrollBookPage1Enable();
	}
	
	public void UIScrollBookNext2PageClicking() {
		MainScrollBookPage2Disabling.MainScrollBookPage2Disable();
		MainScrollBookPage3Enabling.MainScrollBookPage3Enable();
	}
	
	public void UIScrollBookPrior3PageClicking() {
		MainScrollBookPage3Disabling.MainScrollBookPage3Disable();
		MainScrollBookPage2Enabling.MainScrollBookPage2Enable();
	}
	
	public void UIScrollBookEnd3PageClicking() {
		MainScrollBookAllDisabling.MainScrollBookAllDisable();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}