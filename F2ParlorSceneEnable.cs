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

public class F2ParlorSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer Pollock;
	public Renderer PollockGhost;
	
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
    public Renderer CoffeeTableTable;
    public Renderer CoffeeTableLegs;
    public Renderer DiningChairCushion1;
    public Renderer DiningChairLegs1;
    public Renderer DiningChairSeat1;
    public Renderer DiningChairCushion2;
    public Renderer DiningChairLegs2;
    public Renderer DiningChairSeat2;
    public Renderer DiningChairCushion3;
    public Renderer DiningChairLegs3;
    public Renderer DiningChairSeat3;
    public Renderer DiningChairCushion4;
    public Renderer DiningChairLegs4;
    public Renderer DiningChairSeat4;
	
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
		F2ParlorRoomEnable();
		
		F2ParlorMainDisable();
		F2ParlorLightLeftDisable();
		F2ParlorLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		F2ParlorGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void F2ParlorMainEnable() {
		Pollock.enabled = true;
		PollockGhost.enabled = true;
	}
	
	public void F2ParlorRoomEnable() {
		Flooring.enabled = true;
		WallLeft.enabled = true;
		WallBack.enabled = true;
		WallRight.enabled = true;
		
        AreaRug.enabled = true;
        CoffeeTableTable.enabled = true;
        CoffeeTableLegs.enabled = true;
        DiningChairCushion1.enabled = true;
        DiningChairLegs1.enabled = true;
        DiningChairSeat1.enabled = true;
        DiningChairCushion2.enabled = true;
        DiningChairLegs2.enabled = true;
        DiningChairSeat2.enabled = true;
        DiningChairCushion3.enabled = true;
        DiningChairLegs3.enabled = true;
        DiningChairSeat3.enabled = true;
        DiningChairCushion4.enabled = true;
        DiningChairLegs4.enabled = true;
        DiningChairSeat4.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightLeftTorch.enabled = true;

		WallLightRightHolder.enabled = true;
		WallLightRightTorch.enabled = true;
	}
	
	public void F2ParlorLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void F2ParlorLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void F2ParlorAllDisable() {
		F2ParlorMainDisable();
		F2ParlorRoomDisable();
		F2ParlorLightLeftDisable();
		F2ParlorLightRightDisable();
	}
	
	public void F2ParlorMainDisable() {
		Pollock.enabled = false;
		PollockGhost.enabled = false;
	}
	
	public void F2ParlorRoomDisable() {
		Flooring.enabled = false;
		WallLeft.enabled = false;
		WallBack.enabled = false;
		WallRight.enabled = false;
		
		AreaRug.enabled = false;
        CoffeeTableTable.enabled = false;
        CoffeeTableLegs.enabled = false;
        DiningChairCushion1.enabled = false;
        DiningChairLegs1.enabled = false;
        DiningChairSeat1.enabled = false;
        DiningChairCushion2.enabled = false;
        DiningChairLegs2.enabled = false;
        DiningChairSeat2.enabled = false;
        DiningChairCushion3.enabled = false;
        DiningChairLegs3.enabled = false;
        DiningChairSeat3.enabled = false;
        DiningChairCushion4.enabled = false;
        DiningChairLegs4.enabled = false;
        DiningChairSeat4.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightLeftTorch.enabled = false;

		WallLightRightHolder.enabled = false;
		WallLightRightTorch.enabled = false;
	}
	
	public void F2ParlorLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void F2ParlorLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void F2ParlorGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			F2ParlorMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}