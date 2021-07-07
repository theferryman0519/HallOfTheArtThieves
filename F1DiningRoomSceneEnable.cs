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

public class F1DiningRoomSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer DaVinci;
	public Renderer DaVinciGhost;
	
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
	public Renderer DiningTableBody;
	public Renderer DiningTableLegs;
	public Renderer DiningChairCushion1;
	public Renderer DiningChairLegs1;
	public Renderer DiningChairSeat1;
	public Renderer DiningChaitCushion2;
	public Renderer DiningChairLegs2;
	public Renderer DiningChairSeat2;
	public Renderer DiningChairCushion3;
	public Renderer DiningChairLegs3;
	public Renderer DiningChairSeat3;
	public Renderer DiningChairCushion4;
	public Renderer DiningChairLegs4;
	public Renderer DiningChairSeat4;
	public Renderer Plate1;
	public Renderer Plate2;
	public Renderer Plate3;
	public Renderer Plate4;
	public Renderer WineGlass1;
	public Renderer WineGlass2;
	public Renderer WineGlass3;
	public Renderer WineGlass4;
	
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
		F1DiningRoomRoomEnable();
		
		F1DiningRoomMainDisable();
		F1DiningRoomLightLeftDisable();
		F1DiningRoomLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		F1DiningRoomGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void F1DiningRoomMainEnable() {
		DaVinci.enabled = true;
		DaVinciGhost.enabled = true;
	}
	
	public void F1DiningRoomRoomEnable() {
		Flooring.enabled = true;
		WallLeft.enabled = true;
		WallBack.enabled = true;
		WallRight.enabled = true;
		
		AreaRug.enabled = true;
		DiningTableBody.enabled = true;
		DiningTableLegs.enabled = true;
		DiningChairCushion1.enabled = true;
		DiningChairLegs1.enabled = true;
		DiningChairSeat1.enabled = true;
		DiningChaitCushion2.enabled = true;
		DiningChairLegs2.enabled = true;
		DiningChairSeat2.enabled = true;
		DiningChairCushion3.enabled = true;
		DiningChairLegs3.enabled = true;
		DiningChairSeat3.enabled = true;
		DiningChairCushion4.enabled = true;
		DiningChairLegs4.enabled = true;
		DiningChairSeat4.enabled = true;
		Plate1.enabled = true;
		Plate2.enabled = true;
		Plate3.enabled = true;
		Plate4.enabled = true;
		WineGlass1.enabled = true;
		WineGlass2.enabled = true;
		WineGlass3.enabled = true;
		WineGlass4.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightLeftTorch.enabled = true;

		WallLightRightHolder.enabled = true;
		WallLightRightTorch.enabled = true;
	}
	
	public void F1DiningRoomLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void F1DiningRoomLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void F1DiningRoomAllDisable() {
		F1DiningRoomMainDisable();
		F1DiningRoomRoomDisable();
		F1DiningRoomLightLeftDisable();
		F1DiningRoomLightRightDisable();
	}
	
	public void F1DiningRoomMainDisable() {
		DaVinci.enabled = false;
		DaVinciGhost.enabled = false;
	}
	
	public void F1DiningRoomRoomDisable() {
		Flooring.enabled = false;
		WallLeft.enabled = false;
		WallBack.enabled = false;
		WallRight.enabled = false;
		
		AreaRug.enabled = false;
		DiningTableBody.enabled = false;
		DiningTableLegs.enabled = false;
		DiningChairCushion1.enabled = false;
		DiningChairLegs1.enabled = false;
		DiningChairSeat1.enabled = false;
		DiningChaitCushion2.enabled = false;
		DiningChairLegs2.enabled = false;
		DiningChairSeat2.enabled = false;
		DiningChairCushion3.enabled = false;
		DiningChairLegs3.enabled = false;
		DiningChairSeat3.enabled = false;
		DiningChairCushion4.enabled = false;
		DiningChairLegs4.enabled = false;
		DiningChairSeat4.enabled = false;
		Plate1.enabled = false;
		Plate2.enabled = false;
		Plate3.enabled = false;
		Plate4.enabled = false;
		WineGlass1.enabled = false;
		WineGlass2.enabled = false;
		WineGlass3.enabled = false;
		WineGlass4.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightLeftTorch.enabled = false;

		WallLightRightHolder.enabled = false;
		WallLightRightTorch.enabled = false;
	}
	
	public void F1DiningRoomLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void F1DiningRoomLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void F1DiningRoomGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			F1DiningRoomMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}