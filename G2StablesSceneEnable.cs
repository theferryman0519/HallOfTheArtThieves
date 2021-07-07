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

public class G2StablesSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer Vermeer;
	public Renderer VermeerGhost;
    public Renderer Rubens;
	public Renderer RubensGhost;
	
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
	public Renderer Stables1;
    public Renderer Stables2;
    public Renderer Stables3;
    public Renderer Horse;
	
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
		G2StablesRoomEnable();
		
		G2StablesMainDisable();
		G2StablesLightLeftDisable();
		G2StablesLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		G2StablesGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void G2StablesMainEnable() {
		Vermeer.enabled = true;
		VermeerGhost.enabled = true;
        Rubens.enabled = true;
		RubensGhost.enabled = true;
	}
	
	public void G2StablesRoomEnable() {
		GardenGrass1.enabled = true;
        GardenGrass2.enabled = true;
        GardenGrass3.enabled = true;
		WallBack.enabled = true;
		
        Stables1.enabled = true;
        Stables2.enabled = true;
        Stables3.enabled = true;
        Horse.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightRightHolder.enabled = true;
	}
	
	public void G2StablesLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void G2StablesLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void G2StablesAllDisable() {
		G2StablesMainDisable();
		G2StablesRoomDisable();
		G2StablesLightLeftDisable();
		G2StablesLightRightDisable();
	}
	
	public void G2StablesMainDisable() {
		Vermeer.enabled = false;
		VermeerGhost.enabled = false;
        Rubens.enabled = false;
		RubensGhost.enabled = false;
	}
	
	public void G2StablesRoomDisable() {
		GardenGrass1.enabled = false;
        GardenGrass2.enabled = false;
        GardenGrass3.enabled = false;
		WallBack.enabled = false;
		
        Stables1.enabled = false;
        Stables2.enabled = false;
        Stables3.enabled = false;
        Horse.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightRightHolder.enabled = false;
	}
	
	public void G2StablesLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void G2StablesLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void G2StablesGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			G2StablesMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}