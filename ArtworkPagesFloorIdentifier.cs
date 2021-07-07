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

public class ArtworkPagesFloorIdentifier : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static int ArtworkPagesFloorIdentify;
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Disable All Scenes
	public MainArtworkPageEnable MainArtworksPageAllDisabling;
    public MainBonusArtworkPagesEnable ArtworkPagesAddedAllDisabling;
	
	// Enabling Pages
    public MainArtworkPageEnable OpeningArtworksEnabling;
	public MainArtworkPageEnable ArtworksPageF1Enabling;
	public MainArtworkPageEnable ArtworksPageF2Enabling;
	public MainArtworkPageEnable ArtworksPageF3Enabling;
	public MainArtworkPageEnable ArtworksPageG1Enabling;
	public MainArtworkPageEnable ArtworksPageG2Enabling;
    public MainArtworkPageEnable ArtworksPageG3Enabling;
	public MainArtworkPageEnable ArtworksPageFBEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageF1AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageF2AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageF3AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageG1AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageG2AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageG3AddedEnabling;
    public MainBonusArtworkPagesEnable ArtworksPageFBAddedEnabling;
    
    public MainArtworkPageEnable OpenArtworksSecondaryFloorsEnabling;
    public MainArtworkPageEnable OpenArtworksSecondaryFloorsF1Enabling;
    public MainArtworkPageEnable OpenArtworksSecondaryFloorsF2Enabling;
    public MainArtworkPageEnable OpenArtworksSecondaryFloorsF3Enabling;
    public MainArtworkPageEnable OpenArtworksSecondaryFloorsG1Enabling;
    public MainArtworkPageEnable OpenArtworksSecondaryFloorsG2Enabling;
    public MainArtworkPageEnable OpenArtworksSecondaryFloorsG3Enabling;
    public MainArtworkPageEnable OpenArtworksSecondaryFloorsFBEnabling;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if (ArtworkPagesFloorIdentify == 0) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
            
            // Enable Floor
            OpeningArtworksEnabling.OpeningArtworksEnable();
            OpenArtworksSecondaryFloorsEnabling.OpenArtworksSecondaryFloorsEnable();
        }
        
        if (ArtworkPagesFloorIdentify == 1) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
            
            // Enable Floor
            ArtworksPageF1Enabling.ArtworksPageF1Enable();
            OpenArtworksSecondaryFloorsF1Enabling.OpenArtworksSecondaryFloorsF1Enable();
        }
        
        if (ArtworkPagesFloorIdentify == 2) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
            
            // Enable Floor
            ArtworksPageF2Enabling.ArtworksPageF2Enable();
            OpenArtworksSecondaryFloorsF2Enabling.OpenArtworksSecondaryFloorsF2Enable();
        }
        
        if (ArtworkPagesFloorIdentify == 3) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
            
            // Enable Floor
            ArtworksPageF3Enabling.ArtworksPageF3Enable();
            OpenArtworksSecondaryFloorsF3Enabling.OpenArtworksSecondaryFloorsF3Enable();
        }
        
        if (ArtworkPagesFloorIdentify == 4) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
            
            // Enable Floor
            ArtworksPageG1Enabling.ArtworksPageG1Enable();
            OpenArtworksSecondaryFloorsG1Enabling.OpenArtworksSecondaryFloorsG1Enable();
        }
        
        if (ArtworkPagesFloorIdentify == 5) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
            
            // Enable Floor
            ArtworksPageG2Enabling.ArtworksPageG2Enable();
            OpenArtworksSecondaryFloorsG2Enabling.OpenArtworksSecondaryFloorsG2Enable();
        }
        
        if (ArtworkPagesFloorIdentify == 6) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
            
            // Enable Floor
            ArtworksPageFBEnabling.ArtworksPageFBEnable();
            OpenArtworksSecondaryFloorsFBEnabling.OpenArtworksSecondaryFloorsFBEnable();
        }
        
        if (ArtworkPagesFloorIdentify == 7) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
            
            // Enable Floor
            ArtworksPageG3Enabling.ArtworksPageG3Enable();
            OpenArtworksSecondaryFloorsG3Enabling.OpenArtworksSecondaryFloorsG3Enable();
        }
        
        if (ArtworkPagesFloorIdentify == 8) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
        }
        
        if (ArtworkPagesFloorIdentify == 11) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
            
            // Enable Floor
            ArtworksPageF1AddedEnabling.ArtworksPageF1AddedEnable();
        }
        
        if (ArtworkPagesFloorIdentify == 12) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
            
            // Enable Floor
            ArtworksPageF2AddedEnabling.ArtworksPageF2AddedEnable();
        }
        
        if (ArtworkPagesFloorIdentify == 13) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
            
            // Enable Floor
            ArtworksPageF3AddedEnabling.ArtworksPageF3AddedEnable();
        }
        
        if (ArtworkPagesFloorIdentify == 14) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
            
            // Enable Floor
            ArtworksPageG1AddedEnabling.ArtworksPageG1AddedEnable();
        }
        
        if (ArtworkPagesFloorIdentify == 15) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
            
            // Enable Floor
            ArtworksPageG2AddedEnabling.ArtworksPageG2AddedEnable();
        }
        
        if (ArtworkPagesFloorIdentify == 16) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
            
            // Enable Floor
            ArtworksPageFBAddedEnabling.ArtworksPageFBAddedEnable();
        }
        
        if (ArtworkPagesFloorIdentify == 17) {
            // Disable All
            MainArtworksPageAllDisabling.MainArtworksPageAllDisable();
            ArtworkPagesAddedAllDisabling.ArtworkPagesAddedAllDisable();
            
            // Enable Floor
            ArtworksPageG3AddedEnabling.ArtworksPageG3AddedEnable();
        }
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
	
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}