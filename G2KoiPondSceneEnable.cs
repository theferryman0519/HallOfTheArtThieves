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

public class G2KoiPondSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer Monet;
	public Renderer MonetGhost;
	
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
	public Renderer KoiPondPond;
    public Renderer KoiPondRocks;
	
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
		G2KoiPondRoomEnable();
		
		G2KoiPondMainDisable();
		G2KoiPondLightLeftDisable();
		G2KoiPondLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		G2KoiPondGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void G2KoiPondMainEnable() {
		Monet.enabled = true;
		MonetGhost.enabled = true;
	}
	
	public void G2KoiPondRoomEnable() {
		GardenGrass1.enabled = true;
        GardenGrass2.enabled = true;
        GardenGrass3.enabled = true;
		WallBack.enabled = true;
		
        KoiPondPond.enabled = true;
        KoiPondRocks.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightRightHolder.enabled = true;
	}
	
	public void G2KoiPondLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void G2KoiPondLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void G2KoiPondAllDisable() {
		G2KoiPondMainDisable();
		G2KoiPondRoomDisable();
		G2KoiPondLightLeftDisable();
		G2KoiPondLightRightDisable();
	}
	
	public void G2KoiPondMainDisable() {
		Monet.enabled = false;
		MonetGhost.enabled = false;
	}
	
	public void G2KoiPondRoomDisable() {
		GardenGrass1.enabled = false;
        GardenGrass2.enabled = false;
        GardenGrass3.enabled = false;
		WallBack.enabled = false;
		
        KoiPondPond.enabled = false;
        KoiPondRocks.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightRightHolder.enabled = false;
	}
	
	public void G2KoiPondLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void G2KoiPondLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void G2KoiPondGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			G2KoiPondMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}