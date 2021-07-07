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

public class F1FoyerSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer Scroll;
	
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
	public Renderer DeskBody;
	public Renderer DeskLegs;
	
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
		F1FoyerRoomEnable();
		
		F1FoyerMainDisable();
		F1FoyerLightLeftDisable();
		F1FoyerLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		F1FoyerScrollShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void F1FoyerMainEnable() {
		Scroll.enabled = true;
	}
	
	public void F1FoyerRoomEnable() {
		Flooring.enabled = true;
		WallLeft.enabled = true;
		WallBack.enabled = true;
		WallRight.enabled = true;
		
		AreaRug.enabled = true;
		DeskBody.enabled = true;
		DeskLegs.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightLeftTorch.enabled = true;

		WallLightRightHolder.enabled = true;
		WallLightRightTorch.enabled = true;
	}
	
	public void F1FoyerLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void F1FoyerLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void F1FoyerAllDisable() {
		F1FoyerMainDisable();
		F1FoyerRoomDisable();
		F1FoyerLightLeftDisable();
		F1FoyerLightRightDisable();
	}
	
	public void F1FoyerMainDisable() {
		Scroll.enabled = false;
	}
	
	public void F1FoyerRoomDisable() {
		Flooring.enabled = false;
		WallLeft.enabled = false;
		WallBack.enabled = false;
		WallRight.enabled = false;
		
		AreaRug.enabled = false;
		DeskBody.enabled = false;
		DeskLegs.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightLeftTorch.enabled = false;

		WallLightRightHolder.enabled = false;
		WallLightRightTorch.enabled = false;
	}
	
	public void F1FoyerLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void F1FoyerLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void F1FoyerScrollShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			F1FoyerMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}