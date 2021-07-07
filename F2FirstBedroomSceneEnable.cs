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

public class F2FirstBedroomSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer Durer;
	public Renderer DurerGhost;
	
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
	public Renderer BedLegs;
	public Renderer BedMattress;
	public Renderer DiningChairCushion;
	public Renderer DiningChairLegs;
	public Renderer DiningChairSeat;
	
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
		F2FirstBedroomRoomEnable();
		
		F2FirstBedroomMainDisable();
		F2FirstBedroomLightLeftDisable();
		F2FirstBedroomLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		F2FirstBedroomGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void F2FirstBedroomMainEnable() {
		Durer.enabled = true;
		DurerGhost.enabled = true;
	}
	
	public void F2FirstBedroomRoomEnable() {
		Flooring.enabled = true;
		WallLeft.enabled = true;
		WallBack.enabled = true;
		WallRight.enabled = true;
		
        AreaRug.enabled = true;
        BedBox.enabled = true;
        BedCushions.enabled = true;
        BedLegs.enabled = true;
        BedMattress.enabled = true;
        DiningChairCushion.enabled = true;
        DiningChairLegs.enabled = true;
        DiningChairSeat.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightLeftTorch.enabled = true;

		WallLightRightHolder.enabled = true;
		WallLightRightTorch.enabled = true;
	}
	
	public void F2FirstBedroomLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void F2FirstBedroomLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void F2FirstBedroomAllDisable() {
		F2FirstBedroomMainDisable();
		F2FirstBedroomRoomDisable();
		F2FirstBedroomLightLeftDisable();
		F2FirstBedroomLightRightDisable();
	}
	
	public void F2FirstBedroomMainDisable() {
		Durer.enabled = false;
		DurerGhost.enabled = false;
	}
	
	public void F2FirstBedroomRoomDisable() {
		Flooring.enabled = false;
		WallLeft.enabled = false;
		WallBack.enabled = false;
		WallRight.enabled = false;
		
		AreaRug.enabled = false;
        BedBox.enabled = false;
        BedCushions.enabled = false;
        BedLegs.enabled = false;
        BedMattress.enabled = false;
        DiningChairCushion.enabled = false;
        DiningChairLegs.enabled = false;
        DiningChairSeat.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightLeftTorch.enabled = false;

		WallLightRightHolder.enabled = false;
		WallLightRightTorch.enabled = false;
	}
	
	public void F2FirstBedroomLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void F2FirstBedroomLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void F2FirstBedroomGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			F2FirstBedroomMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}