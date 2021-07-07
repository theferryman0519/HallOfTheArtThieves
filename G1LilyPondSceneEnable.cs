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

public class G1LilyPondSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer Cezanne;
	public Renderer CezanneGhost;
	
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
	public Renderer LilyPondPond;
    public Renderer LilyPondRocks;
	
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
		G1LilyPondRoomEnable();
		
		G1LilyPondMainDisable();
		G1LilyPondLightLeftDisable();
		G1LilyPondLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		G1LilyPondGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void G1LilyPondMainEnable() {
		Cezanne.enabled = true;
		CezanneGhost.enabled = true;
	}
	
	public void G1LilyPondRoomEnable() {
		GardenGrass1.enabled = true;
        GardenGrass2.enabled = true;
        GardenGrass3.enabled = true;
		WallBack.enabled = true;
		
        LilyPondPond.enabled = true;
        LilyPondRocks.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightRightHolder.enabled = true;
	}
	
	public void G1LilyPondLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void G1LilyPondLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void G1LilyPondAllDisable() {
		G1LilyPondMainDisable();
		G1LilyPondRoomDisable();
		G1LilyPondLightLeftDisable();
		G1LilyPondLightRightDisable();
	}
	
	public void G1LilyPondMainDisable() {
		Cezanne.enabled = false;
		CezanneGhost.enabled = false;
	}
	
	public void G1LilyPondRoomDisable() {
		GardenGrass1.enabled = false;
        GardenGrass2.enabled = false;
        GardenGrass3.enabled = false;
		WallBack.enabled = false;
		
        LilyPondPond.enabled = false;
        LilyPondRocks.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightRightHolder.enabled = false;
	}
	
	public void G1LilyPondLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void G1LilyPondLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void G1LilyPondGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			G1LilyPondMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}