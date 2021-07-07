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

public class FBWineCellarSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer Picasso;
	public Renderer PicassoGhost;
	
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
    public Renderer WineRackBottles1;
    public Renderer WineRackRack1;
    public Renderer WineRackBottles2;
    public Renderer WineRackRack2;
    public Renderer WineRackBottles3;
    public Renderer WineRackRack3;
    public Renderer WineRackBottles4;
    public Renderer WineRackRack4;
    public Renderer DiningTableTable;
    public Renderer DiningTableLegs;
    public Renderer WineGlass;
	
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
		FBWineCellarRoomEnable();
		
		FBWineCellarMainDisable();
		FBWineCellarLightLeftDisable();
		FBWineCellarLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		FBWineCellarGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void FBWineCellarMainEnable() {
		Picasso.enabled = true;
		PicassoGhost.enabled = true;
	}
	
	public void FBWineCellarRoomEnable() {
		Flooring.enabled = true;
		WallLeft.enabled = true;
		WallBack.enabled = true;
		WallRight.enabled = true;
		
        AreaRug.enabled = true;
        WineRackBottles1.enabled = true;
        WineRackRack1.enabled = true;
        WineRackBottles2.enabled = true;
        WineRackRack2.enabled = true;
        WineRackBottles3.enabled = true;
        WineRackRack3.enabled = true;
        WineRackBottles4.enabled = true;
        WineRackRack4.enabled = true;
        DiningTableTable.enabled = true;
        DiningTableLegs.enabled = true;
        WineGlass.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightLeftTorch.enabled = true;

		WallLightRightHolder.enabled = true;
		WallLightRightTorch.enabled = true;
	}
	
	public void FBWineCellarLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void FBWineCellarLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void FBWineCellarAllDisable() {
		FBWineCellarMainDisable();
		FBWineCellarRoomDisable();
		FBWineCellarLightLeftDisable();
		FBWineCellarLightRightDisable();
	}
	
	public void FBWineCellarMainDisable() {
		Picasso.enabled = false;
		PicassoGhost.enabled = false;
	}
	
	public void FBWineCellarRoomDisable() {
		Flooring.enabled = false;
		WallLeft.enabled = false;
		WallBack.enabled = false;
		WallRight.enabled = false;
		
		AreaRug.enabled = false;
        WineRackBottles1.enabled = false;
        WineRackRack1.enabled = false;
        WineRackBottles2.enabled = false;
        WineRackRack2.enabled = false;
        WineRackBottles3.enabled = false;
        WineRackRack3.enabled = false;
        WineRackBottles4.enabled = false;
        WineRackRack4.enabled = false;
        DiningTableTable.enabled = false;
        DiningTableLegs.enabled = false;
        WineGlass.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightLeftTorch.enabled = false;

		WallLightRightHolder.enabled = false;
		WallLightRightTorch.enabled = false;
	}
	
	public void FBWineCellarLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void FBWineCellarLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void FBWineCellarGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			FBWineCellarMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}