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

public class G1DaisyGardenSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer Botticelli;
	public Renderer BotticelliGhost;
	
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
	public Renderer Daisy1;
    public Renderer Daisy2;
    public Renderer Daisy3;
    public Renderer Daisy4;
    public Renderer Daisy5;
    public Renderer Daisy6;
    public Renderer Daisy7;
    public Renderer Daisy8;
    public Renderer Daisy9;
    public Renderer Daisy10;
    public Renderer Daisy11;
    public Renderer Daisy12;
    public Renderer Daisy13;
    public Renderer Daisy14;
    public Renderer Daisy15;
	
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
		G1DaisyGardenRoomEnable();
		
		G1DaisyGardenMainDisable();
		G1DaisyGardenLightLeftDisable();
		G1DaisyGardenLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		G1DaisyGardenGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void G1DaisyGardenMainEnable() {
		Botticelli.enabled = true;
		BotticelliGhost.enabled = true;
	}
	
	public void G1DaisyGardenRoomEnable() {
		GardenGrass1.enabled = true;
        GardenGrass2.enabled = true;
        GardenGrass3.enabled = true;
		WallBack.enabled = true;
		
        Daisy1.enabled = true;
        Daisy2.enabled = true;
        Daisy3.enabled = true;
        Daisy4.enabled = true;
        Daisy5.enabled = true;
        Daisy6.enabled = true;
        Daisy7.enabled = true;
        Daisy8.enabled = true;
        Daisy9.enabled = true;
        Daisy10.enabled = true;
        Daisy11.enabled = true;
        Daisy12.enabled = true;
        Daisy13.enabled = true;
        Daisy14.enabled = true;
        Daisy15.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightRightHolder.enabled = true;
	}
	
	public void G1DaisyGardenLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void G1DaisyGardenLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void G1DaisyGardenAllDisable() {
		G1DaisyGardenMainDisable();
		G1DaisyGardenRoomDisable();
		G1DaisyGardenLightLeftDisable();
		G1DaisyGardenLightRightDisable();
	}
	
	public void G1DaisyGardenMainDisable() {
		Botticelli.enabled = false;
		BotticelliGhost.enabled = false;
	}
	
	public void G1DaisyGardenRoomDisable() {
		GardenGrass1.enabled = false;
        GardenGrass2.enabled = false;
        GardenGrass3.enabled = false;
		WallBack.enabled = false;
		
        Daisy1.enabled = false;
        Daisy2.enabled = false;
        Daisy3.enabled = false;
        Daisy4.enabled = false;
        Daisy5.enabled = false;
        Daisy6.enabled = false;
        Daisy7.enabled = false;
        Daisy8.enabled = false;
        Daisy9.enabled = false;
        Daisy10.enabled = false;
        Daisy11.enabled = false;
        Daisy12.enabled = false;
        Daisy13.enabled = false;
        Daisy14.enabled = false;
        Daisy15.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightRightHolder.enabled = false;
	}
	
	public void G1DaisyGardenLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void G1DaisyGardenLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void G1DaisyGardenGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			G1DaisyGardenMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}