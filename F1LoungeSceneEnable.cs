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

public class F1LoungeSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer OKeeffe;
	public Renderer OKeeffeGhost;
	
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
	public Renderer BookshelfBooks1;
	public Renderer BookshelfShelf1;
	public Renderer BookshelfBooks2;
	public Renderer BookshelfShelf2;
	public Renderer CoffeeTableBody;
	public Renderer CoffeeTableLegs;
	public Renderer CheckerboardBody;
	public Renderer CheckerboardBox;
	public Renderer CheckerPieceBrown1;
	public Renderer CheckerPieceBrown2;
	public Renderer CheckerPieceBrown3;
	public Renderer CheckerPieceWhite1;
	public Renderer CheckerPieceWhite2;
	public Renderer CheckerPieceWhite3;
	
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
		F1LoungeRoomEnable();
		
		F1LoungeMainDisable();
		F1LoungeLightLeftDisable();
		F1LoungeLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		F1LoungeGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void F1LoungeMainEnable() {
		OKeeffe.enabled = true;
		OKeeffeGhost.enabled = true;
	}
	
	public void F1LoungeRoomEnable() {
		Flooring.enabled = true;
		WallLeft.enabled = true;
		WallBack.enabled = true;
		WallRight.enabled = true;
		
		AreaRug.enabled = true;
		BookshelfBooks1.enabled = true;
		BookshelfShelf1.enabled = true;
		BookshelfBooks2.enabled = true;
		BookshelfShelf2.enabled = true;
		CoffeeTableBody.enabled = true;
		CoffeeTableLegs.enabled = true;
		CheckerboardBody.enabled = true;
		CheckerboardBox.enabled = true;
		CheckerPieceBrown1.enabled = true;
		CheckerPieceBrown2.enabled = true;
		CheckerPieceBrown3.enabled = true;
		CheckerPieceWhite1.enabled = true;
		CheckerPieceWhite2.enabled = true;
		CheckerPieceWhite3.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightLeftTorch.enabled = true;

		WallLightRightHolder.enabled = true;
		WallLightRightTorch.enabled = true;
	}
	
	public void F1LoungeLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void F1LoungeLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void F1LoungeAllDisable() {
		F1LoungeMainDisable();
		F1LoungeRoomDisable();
		F1LoungeLightLeftDisable();
		F1LoungeLightRightDisable();
	}
	
	public void F1LoungeMainDisable() {
		OKeeffe.enabled = false;
		OKeeffeGhost.enabled = false;
	}
	
	public void F1LoungeRoomDisable() {
		Flooring.enabled = false;
		WallLeft.enabled = false;
		WallBack.enabled = false;
		WallRight.enabled = false;
		
		AreaRug.enabled = false;
		BookshelfBooks1.enabled = false;
		BookshelfShelf1.enabled = false;
		BookshelfBooks2.enabled = false;
		BookshelfShelf2.enabled = false;
		CoffeeTableBody.enabled = false;
		CoffeeTableLegs.enabled = false;
		CheckerboardBody.enabled = false;
		CheckerboardBox.enabled = false;
		CheckerPieceBrown1.enabled = false;
		CheckerPieceBrown2.enabled = false;
		CheckerPieceBrown3.enabled = false;
		CheckerPieceWhite1.enabled = false;
		CheckerPieceWhite2.enabled = false;
		CheckerPieceWhite3.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightLeftTorch.enabled = false;

		WallLightRightHolder.enabled = false;
		WallLightRightTorch.enabled = false;
	}
	
	public void F1LoungeLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void F1LoungeLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void F1LoungeGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			F1LoungeMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}