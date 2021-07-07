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

public class G1TulipGardenSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer VanEyck;
	public Renderer VanEyckGhost;
	
	// Base Objects
	public Renderer GardenGrass1;
    public Renderer GardenGrass2;
    public Renderer GardenGrass3;
	public Renderer WallBack;
	
	public Renderer WallLightLeftHolder;
	public ParticleSystem WallLightLeftFire;
	public Light WallLightLeftLight;
	
	public Renderer WallLightRightHolder;
	public ParticleSystem WallLightRightFire;
	public Light WallLightRightLight;
	
	// Other Objects
	public Renderer Tulip1;
    public Renderer Tulip2;
    public Renderer Tulip3;
    public Renderer Tulip4;
    public Renderer Tulip5;
    public Renderer Tulip6;
    public Renderer Tulip7;
    public Renderer Tulip8;
    public Renderer Tulip9;
    public Renderer Tulip10;
    public Renderer Tulip11;
    public Renderer Tulip12;
    public Renderer Tulip13;
    public Renderer Tulip14;
    public Renderer Tulip15;
    public Renderer Tulip16;
    public Renderer Tulip17;
    public Renderer Tulip18;
    public Renderer Tulip19;
    public Renderer Tulip20;
    public Renderer Tulip21;
    public Renderer Tulip22;
    public Renderer Tulip23;
    public Renderer Tulip24;
	
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
		G1TulipGardenRoomEnable();
		
		G1TulipGardenMainDisable();
		G1TulipGardenLightLeftDisable();
		G1TulipGardenLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		G1TulipGardenGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void G1TulipGardenMainEnable() {
		VanEyck.enabled = true;
		VanEyckGhost.enabled = true;
	}
	
	public void G1TulipGardenRoomEnable() {
		GardenGrass1.enabled = true;
        GardenGrass2.enabled = true;
        GardenGrass3.enabled = true;
		WallBack.enabled = true;
		
        Tulip1.enabled = true;
        Tulip2.enabled = true;
        Tulip3.enabled = true;
        Tulip4.enabled = true;
        Tulip5.enabled = true;
        Tulip6.enabled = true;
        Tulip7.enabled = true;
        Tulip8.enabled = true;
        Tulip9.enabled = true;
        Tulip10.enabled = true;
        Tulip11.enabled = true;
        Tulip12.enabled = true;
        Tulip13.enabled = true;
        Tulip14.enabled = true;
        Tulip15.enabled = true;
        Tulip16.enabled = true;
        Tulip17.enabled = true;
        Tulip18.enabled = true;
        Tulip19.enabled = true;
        Tulip20.enabled = true;
        Tulip21.enabled = true;
        Tulip22.enabled = true;
        Tulip23.enabled = true;
        Tulip24.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightRightHolder.enabled = true;
	}
	
	public void G1TulipGardenLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void G1TulipGardenLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void G1TulipGardenAllDisable() {
		G1TulipGardenMainDisable();
		G1TulipGardenRoomDisable();
		G1TulipGardenLightLeftDisable();
		G1TulipGardenLightRightDisable();
	}
	
	public void G1TulipGardenMainDisable() {
		VanEyck.enabled = false;
		VanEyckGhost.enabled = false;
	}
	
	public void G1TulipGardenRoomDisable() {
		GardenGrass1.enabled = false;
        GardenGrass2.enabled = false;
        GardenGrass3.enabled = false;
		WallBack.enabled = false;
		
        Tulip1.enabled = false;
        Tulip2.enabled = false;
        Tulip3.enabled = false;
        Tulip4.enabled = false;
        Tulip5.enabled = false;
        Tulip6.enabled = false;
        Tulip7.enabled = false;
        Tulip8.enabled = false;
        Tulip9.enabled = false;
        Tulip10.enabled = false;
        Tulip11.enabled = false;
        Tulip12.enabled = false;
        Tulip13.enabled = false;
        Tulip14.enabled = false;
        Tulip15.enabled = false;
        Tulip16.enabled = false;
        Tulip17.enabled = false;
        Tulip18.enabled = false;
        Tulip19.enabled = false;
        Tulip20.enabled = false;
        Tulip21.enabled = false;
        Tulip22.enabled = false;
        Tulip23.enabled = false;
        Tulip24.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightRightHolder.enabled = false;
	}
	
	public void G1TulipGardenLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void G1TulipGardenLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void G1TulipGardenGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			G1TulipGardenMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}