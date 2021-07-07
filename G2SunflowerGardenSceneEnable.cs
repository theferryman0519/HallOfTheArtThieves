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

public class G2SunflowerGardenSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer VanGogh;
	public Renderer VanGoghGhost;
	
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
	public Renderer Sunflower1;
    public Renderer Sunflower2;
    public Renderer Sunflower5;
    public Renderer Sunflower7;
    public Renderer Sunflower11;
    public Renderer Sunflower13;
    public Renderer Sunflower16;
	
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
		G2SunflowerGardenRoomEnable();
		
		G2SunflowerGardenMainDisable();
		G2SunflowerGardenLightLeftDisable();
		G2SunflowerGardenLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		G2SunflowerGardenGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void G2SunflowerGardenMainEnable() {
		VanGogh.enabled = true;
		VanGoghGhost.enabled = true;
	}
	
	public void G2SunflowerGardenRoomEnable() {
		GardenGrass1.enabled = true;
        GardenGrass2.enabled = true;
        GardenGrass3.enabled = true;
		WallBack.enabled = true;
		
        Sunflower1.enabled = true;
        Sunflower2.enabled = true;
        Sunflower5.enabled = true;
        Sunflower7.enabled = true;
        Sunflower11.enabled = true;
        Sunflower13.enabled = true;
        Sunflower16.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightRightHolder.enabled = true;
	}
	
	public void G2SunflowerGardenLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void G2SunflowerGardenLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void G2SunflowerGardenAllDisable() {
		G2SunflowerGardenMainDisable();
		G2SunflowerGardenRoomDisable();
		G2SunflowerGardenLightLeftDisable();
		G2SunflowerGardenLightRightDisable();
	}
	
	public void G2SunflowerGardenMainDisable() {
		VanGogh.enabled = false;
		VanGoghGhost.enabled = false;
	}
	
	public void G2SunflowerGardenRoomDisable() {
		GardenGrass1.enabled = false;
        GardenGrass2.enabled = false;
        GardenGrass3.enabled = false;
		WallBack.enabled = false;
		
        Sunflower1.enabled = false;
        Sunflower2.enabled = false;
        Sunflower5.enabled = false;
        Sunflower7.enabled = false;
        Sunflower11.enabled = false;
        Sunflower13.enabled = false;
        Sunflower16.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightRightHolder.enabled = false;
	}
	
	public void G2SunflowerGardenLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void G2SunflowerGardenLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void G2SunflowerGardenGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			G2SunflowerGardenMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}