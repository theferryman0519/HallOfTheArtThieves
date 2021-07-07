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

public class MainMenuScrollBookEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Sketchbook Background Images
	public Image UIScrollBookPageLeft;
	public Image UIScrollBookPageRight;
	
	// Log Page
	public Text UIScrollBookLogText;
	
	// Right Page Title
	public Text UIScrollBookTitleMain;
	
	// Right Page 1
	public Text UIScrollBookPage1Text;
	public Text UIScrollBookNext1Page;
	
	// Right Page 2
	public Text UIScrollBookPage2Text;
	public Text UIScrollBookPrior2Page;
	public Text UIScrollBookNext2Page;
	
	// Right Page 3
	public Text UIScrollBookPage3Text;
	public Text UIScrollBookPrior3Page;
	public Text UIScrollBookEnd3Page;
	
	// Close Button
	public Image UIScrollBookCloseButton;
	public Text UIScrollBookCloseButtonText;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		MainScrollBookAllDisable();
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLING FUNCTIONS ---------------
	public void MainScrollBookEnable() {
		UIScrollBookPageLeft.enabled = true;
		UIScrollBookPageRight.enabled = true;
		UIScrollBookLogText.enabled = true;
		UIScrollBookCloseButton.enabled = true;
		UIScrollBookCloseButtonText.enabled = true;
	}
	
	public void MainScrollBookPage1Enable() {
		UIScrollBookTitleMain.enabled = true;
		UIScrollBookPage1Text.enabled = true;
		UIScrollBookNext1Page.enabled = true;
	}
	
	public void MainScrollBookPage2Enable() {
		UIScrollBookTitleMain.enabled = true;
		UIScrollBookPage2Text.enabled = true;
		UIScrollBookPrior2Page.enabled = true;
		UIScrollBookNext2Page.enabled = true;
	}
	
	public void MainScrollBookPage3Enable() {
		UIScrollBookTitleMain.enabled = true;
		UIScrollBookPage3Text.enabled = true;
		UIScrollBookPrior3Page.enabled = true;
		UIScrollBookEnd3Page.enabled = true;
	}
	
// --------------- DISABLING FUNCTIONS ---------------
	public void MainScrollBookAllDisable() {
		MainScrollBookDisable();
		MainScrollBookPage1Disable();
		MainScrollBookPage2Disable();
		MainScrollBookPage3Disable();
	}
	
	public void MainScrollBookDisable() {
		UIScrollBookPageLeft.enabled = false;
		UIScrollBookPageRight.enabled = false;
		UIScrollBookLogText.enabled = false;
		UIScrollBookCloseButton.enabled = false;
		UIScrollBookCloseButtonText.enabled = false;
	}
	
	public void MainScrollBookPage1Disable() {
		UIScrollBookTitleMain.enabled = false;
		UIScrollBookPage1Text.enabled = false;
		UIScrollBookNext1Page.enabled = false;
	}
	
	public void MainScrollBookPage2Disable() {
		UIScrollBookTitleMain.enabled = false;
		UIScrollBookPage2Text.enabled = false;
		UIScrollBookPrior2Page.enabled = false;
		UIScrollBookNext2Page.enabled = false;
	}
	
	public void MainScrollBookPage3Disable() {
		UIScrollBookTitleMain.enabled = false;
		UIScrollBookPage3Text.enabled = false;
		UIScrollBookPrior3Page.enabled = false;
		UIScrollBookEnd3Page.enabled = false;
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}