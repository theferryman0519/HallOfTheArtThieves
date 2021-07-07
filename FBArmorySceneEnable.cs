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

public class FBArmorySceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer Munch;
	public Renderer MunchGhost;
    public Renderer David;
	public Renderer DavidGhost;
	
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
    public Renderer CrestCrest;
    public Renderer CrestCrestImage;
    public Renderer RapierBase1;
    public Renderer RapierBlade1;
    public Renderer RapierGrid1;
    public Renderer RapierPommel1;
    public Renderer RapierSpiral1;
    public Renderer RapierBase2;
    public Renderer RapierBlade2;
    public Renderer RapierGrid2;
    public Renderer RapierPommel2;
    public Renderer RapierSpiral2;
    public Renderer Rifle1;
    public Renderer Rifle2;
    public Renderer Rifle3;
    public Renderer Rifle4;
    public Renderer Rifle5;
    public Renderer Rifle6;
    public Renderer DiningTableTable;
    public Renderer DiningTableLegs;
	
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
		FBArmoryRoomEnable();
		
		FBArmoryMainDisable();
		FBArmoryLightLeftDisable();
		FBArmoryLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		FBArmoryGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void FBArmoryMainEnable() {
		Munch.enabled = true;
		MunchGhost.enabled = true;
        David.enabled = true;
		DavidGhost.enabled = true;
	}
	
	public void FBArmoryRoomEnable() {
		Flooring.enabled = true;
		WallLeft.enabled = true;
		WallBack.enabled = true;
		WallRight.enabled = true;
		
        AreaRug.enabled = true;
        CrestCrest.enabled = true;
        CrestCrestImage.enabled = true;
        RapierBase1.enabled = true;
        RapierBlade1.enabled = true;
        RapierGrid1.enabled = true;
        RapierPommel1.enabled = true;
        RapierSpiral1.enabled = true;
        RapierBase2.enabled = true;
        RapierBlade2.enabled = true;
        RapierGrid2.enabled = true;
        RapierPommel2.enabled = true;
        RapierSpiral2.enabled = true;
        Rifle1.enabled = true;
        Rifle2.enabled = true;
        Rifle3.enabled = true;
        Rifle4.enabled = true;
        Rifle5.enabled = true;
        Rifle6.enabled = true;
        DiningTableTable.enabled = true;
        DiningTableLegs.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightLeftTorch.enabled = true;

		WallLightRightHolder.enabled = true;
		WallLightRightTorch.enabled = true;
	}
	
	public void FBArmoryLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void FBArmoryLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void FBArmoryAllDisable() {
		FBArmoryMainDisable();
		FBArmoryRoomDisable();
		FBArmoryLightLeftDisable();
		FBArmoryLightRightDisable();
	}
	
	public void FBArmoryMainDisable() {
		Munch.enabled = false;
		MunchGhost.enabled = false;
        David.enabled = false;
		DavidGhost.enabled = false;
	}
	
	public void FBArmoryRoomDisable() {
		Flooring.enabled = false;
		WallLeft.enabled = false;
		WallBack.enabled = false;
		WallRight.enabled = false;
		
		AreaRug.enabled = false;
        CrestCrest.enabled = false;
        CrestCrestImage.enabled = false;
        RapierBase1.enabled = false;
        RapierBlade1.enabled = false;
        RapierGrid1.enabled = false;
        RapierPommel1.enabled = false;
        RapierSpiral1.enabled = false;
        RapierBase2.enabled = false;
        RapierBlade2.enabled = false;
        RapierGrid2.enabled = false;
        RapierPommel2.enabled = false;
        RapierSpiral2.enabled = false;
        Rifle1.enabled = false;
        Rifle2.enabled = false;
        Rifle3.enabled = false;
        Rifle4.enabled = false;
        Rifle5.enabled = false;
        Rifle6.enabled = false;
        DiningTableTable.enabled = false;
        DiningTableLegs.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightLeftTorch.enabled = false;

		WallLightRightHolder.enabled = false;
		WallLightRightTorch.enabled = false;
	}
	
	public void FBArmoryLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void FBArmoryLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void FBArmoryGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			FBArmoryMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}