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

public class FBServantsQuarterSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer Dali;
	public Renderer DaliGhost;
	
	// Base Objects
	public Renderer Flooring;
	public Renderer WallLeft;
	public Renderer WallBack;
	public Renderer WallRight;
	
	public Renderer WallLightLeftHolder;
	public Renderer WallLightLeftTorch;
	public ParticleSystem WallLightLeftFire;
	public Light WallLightLeftLight;
	
	public Renderer WallLightRightHolder;
	public Renderer WallLightRightTorch;
	public ParticleSystem WallLightRightFire;
	public Light WallLightRightLight;
	
	// Other Objects
	public Renderer AreaRug;
    public Renderer BedBox;
    public Renderer BedCushions;
    public Renderer BedMattress;
    public Renderer BookshelfBooks;
    public Renderer BookshelfShelf;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Playing Pausing Timers
    public PausingPlayingTimers AllTimersPlaying;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		FBServantsQuarterRoomEnable();
		
		FBServantsQuarterMainDisable();
		FBServantsQuarterLightLeftDisable();
		FBServantsQuarterLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		FBServantsQuarterGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void FBServantsQuarterMainEnable() {
		Dali.enabled = true;
		DaliGhost.enabled = true;
	}
	
	public void FBServantsQuarterRoomEnable() {
		Flooring.enabled = true;
		WallLeft.enabled = true;
		WallBack.enabled = true;
		WallRight.enabled = true;
		
        AreaRug.enabled = true;
        BedBox.enabled = true;
        BedCushions.enabled = true;
        BedMattress.enabled = true;
        BookshelfBooks.enabled = true;
        BookshelfShelf.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightLeftTorch.enabled = true;

		WallLightRightHolder.enabled = true;
		WallLightRightTorch.enabled = true;
	}
	
	public void FBServantsQuarterLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void FBServantsQuarterLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void FBServantsQuarterAllDisable() {
		FBServantsQuarterMainDisable();
		FBServantsQuarterRoomDisable();
		FBServantsQuarterLightLeftDisable();
		FBServantsQuarterLightRightDisable();
	}
	
	public void FBServantsQuarterMainDisable() {
		Dali.enabled = false;
		DaliGhost.enabled = false;
	}
	
	public void FBServantsQuarterRoomDisable() {
		Flooring.enabled = false;
		WallLeft.enabled = false;
		WallBack.enabled = false;
		WallRight.enabled = false;
		
		AreaRug.enabled = false;
        BedBox.enabled = false;
        BedCushions.enabled = false;
        BedMattress.enabled = false;
        BookshelfBooks.enabled = false;
        BookshelfShelf.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightLeftTorch.enabled = false;

		WallLightRightHolder.enabled = false;
		WallLightRightTorch.enabled = false;
	}
	
	public void FBServantsQuarterLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void FBServantsQuarterLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void FBServantsQuarterGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			FBServantsQuarterMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}