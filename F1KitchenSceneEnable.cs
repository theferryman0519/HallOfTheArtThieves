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

public class F1KitchenSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer Kandinsky;
	public Renderer KandinskyGhost;
	
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
	public Renderer CabinetInner1;
	public Renderer Cabinets1;
	public Renderer Countertops1;
	public Renderer StoveTopA1;
	public Renderer StoveTopB1;
	public Renderer CabinetInner2;
	public Renderer Cabinets2;
	public Renderer Countertops2;
	public Renderer StoveTopA2;
	public Renderer StoveTopB2;
	public Renderer Plate1;
	public Renderer Plate2;
	public Renderer Plate3;
	public Renderer Pot;
	
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
		F1KitchenRoomEnable();
		
		F1KitchenMainDisable();
		F1KitchenLightLeftDisable();
		F1KitchenLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		F1KitchenGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void F1KitchenMainEnable() {
		Kandinsky.enabled = true;
		KandinskyGhost.enabled = true;
	}
	
	public void F1KitchenRoomEnable() {
		Flooring.enabled = true;
		WallLeft.enabled = true;
		WallBack.enabled = true;
		WallRight.enabled = true;
		
		CabinetInner1.enabled = true;
		Cabinets1.enabled = true;
		Countertops1.enabled = true;
		StoveTopA1.enabled = true;
		StoveTopB1.enabled = true;
		CabinetInner2.enabled = true;
		Cabinets2.enabled = true;
		Countertops2.enabled = true;
		StoveTopA2.enabled = true;
		StoveTopB2.enabled = true;
		Plate1.enabled = true;
		Plate2.enabled = true;
		Plate3.enabled = true;
		Pot.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightLeftTorch.enabled = true;

		WallLightRightHolder.enabled = true;
		WallLightRightTorch.enabled = true;
	}
	
	public void F1KitchenLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void F1KitchenLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void F1KitchenAllDisable() {
		F1KitchenMainDisable();
		F1KitchenRoomDisable();
		F1KitchenLightLeftDisable();
		F1KitchenLightRightDisable();
	}
	
	public void F1KitchenMainDisable() {
		Kandinsky.enabled = false;
		KandinskyGhost.enabled = false;
	}
	
	public void F1KitchenRoomDisable() {
		Flooring.enabled = false;
		WallLeft.enabled = false;
		WallBack.enabled = false;
		WallRight.enabled = false;
		
		CabinetInner1.enabled = false;
		Cabinets1.enabled = false;
		Countertops1.enabled = false;
		StoveTopA1.enabled = false;
		StoveTopB1.enabled = false;
		CabinetInner2.enabled = false;
		Cabinets2.enabled = false;
		Countertops2.enabled = false;
		StoveTopA2.enabled = false;
		StoveTopB2.enabled = false;
		Plate1.enabled = false;
		Plate2.enabled = false;
		Plate3.enabled = false;
		Pot.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightLeftTorch.enabled = false;

		WallLightRightHolder.enabled = false;
		WallLightRightTorch.enabled = false;
	}
	
	public void F1KitchenLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void F1KitchenLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void F1KitchenGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			F1KitchenMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}