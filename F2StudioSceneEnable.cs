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

public class F2StudioSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer Raphael;
	public Renderer RaphaelGhost;
	
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
    
    public Image UIStudioArtistInfo;
	
	// Other Objects
	public Renderer AreaRug;
    public Renderer EaselCanvas;
    public Renderer EaselEasel;
    public Renderer DiningTableTable;
    public Renderer DiningTableLegs;
    public Renderer Paintbrush1;
    public Renderer Paintbrush2;
    public Renderer Paintbrush3;
    public Renderer Palette1;
    public Renderer Palette2;
	
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
		F2StudioRoomEnable();
		
		F2StudioMainDisable();
		F2StudioLightLeftDisable();
		F2StudioLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
        
        UIStudioArtistInfoEnable();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		F2StudioGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void F2StudioMainEnable() {
		Raphael.enabled = true;
		RaphaelGhost.enabled = true;
	}
	
	public void F2StudioRoomEnable() {
		Flooring.enabled = true;
		WallLeft.enabled = true;
		WallBack.enabled = true;
		WallRight.enabled = true;
		
        AreaRug.enabled = true;
        EaselCanvas.enabled = true;
        EaselEasel.enabled = true;
        DiningTableTable.enabled = true;
        DiningTableLegs.enabled = true;
        Paintbrush1.enabled = true;
        Paintbrush2.enabled = true;
        Paintbrush3.enabled = true;
        Palette1.enabled = true;
        Palette2.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightLeftTorch.enabled = true;

		WallLightRightHolder.enabled = true;
		WallLightRightTorch.enabled = true;
	}
	
	public void F2StudioLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void F2StudioLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
    
    public void UIStudioArtistInfoEnable() {
        UIStudioArtistInfo.enabled = true;
    }
	
// --------------- DISABLE FUNCTIONS ---------------
	public void F2StudioAllDisable() {
		F2StudioMainDisable();
		F2StudioRoomDisable();
		F2StudioLightLeftDisable();
		F2StudioLightRightDisable();
	}
	
	public void F2StudioMainDisable() {
		Raphael.enabled = false;
		RaphaelGhost.enabled = false;
	}
	
	public void F2StudioRoomDisable() {
		Flooring.enabled = false;
		WallLeft.enabled = false;
		WallBack.enabled = false;
		WallRight.enabled = false;
		
		AreaRug.enabled = false;
        EaselCanvas.enabled = false;
        EaselEasel.enabled = false;
        DiningTableTable.enabled = false;
        DiningTableLegs.enabled = false;
        Paintbrush1.enabled = false;
        Paintbrush2.enabled = false;
        Paintbrush3.enabled = false;
        Palette1.enabled = false;
        Palette2.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightLeftTorch.enabled = false;

		WallLightRightHolder.enabled = false;
		WallLightRightTorch.enabled = false;
	}
	
	public void F2StudioLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void F2StudioLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
    
    public void UIStudioArtistInfoDisable() {
        UIStudioArtistInfo.enabled = false;
    }
	
// --------------- SHOWING FUNCTIONS ---------------
	public void F2StudioGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			F2StudioMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}