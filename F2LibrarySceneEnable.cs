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

public class F2LibrarySceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer Cassatt;
	public Renderer CassattGhost;
	
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
    public Renderer BookshelfBooks1;
    public Renderer BookshelfShelf1;
    public Renderer BookshelfBooks2;
    public Renderer BookshelfShelf2;
    public Renderer BookshelfBooks3;
    public Renderer BookshelfShelf3;
    public Renderer BookshelfBooks4;
    public Renderer BookshelfShelf4;
    public Renderer DiningChairCushion;
    public Renderer DiningChairLegs;
    public Renderer DiningChairSeat;
	
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
		F2LibraryRoomEnable();
		
		F2LibraryMainDisable();
		F2LibraryLightLeftDisable();
		F2LibraryLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		F2LibraryGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void F2LibraryMainEnable() {
		Cassatt.enabled = true;
		CassattGhost.enabled = true;
	}
	
	public void F2LibraryRoomEnable() {
		Flooring.enabled = true;
		WallLeft.enabled = true;
		WallBack.enabled = true;
		WallRight.enabled = true;
		
        AreaRug.enabled = true;
        BookshelfBooks1.enabled = true;
        BookshelfShelf1.enabled = true;
        BookshelfBooks2.enabled = true;
        BookshelfShelf2.enabled = true;
        BookshelfBooks3.enabled = true;
        BookshelfShelf3.enabled = true;
        BookshelfBooks4.enabled = true;
        BookshelfShelf4.enabled = true;
        DiningChairCushion.enabled = true;
        DiningChairLegs.enabled = true;
        DiningChairSeat.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightLeftTorch.enabled = true;

		WallLightRightHolder.enabled = true;
		WallLightRightTorch.enabled = true;
	}
	
	public void F2LibraryLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void F2LibraryLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void F2LibraryAllDisable() {
		F2LibraryMainDisable();
		F2LibraryRoomDisable();
		F2LibraryLightLeftDisable();
		F2LibraryLightRightDisable();
	}
	
	public void F2LibraryMainDisable() {
		Cassatt.enabled = false;
		CassattGhost.enabled = false;
	}
	
	public void F2LibraryRoomDisable() {
		Flooring.enabled = false;
		WallLeft.enabled = false;
		WallBack.enabled = false;
		WallRight.enabled = false;
		
		AreaRug.enabled = false;
        BookshelfBooks1.enabled = false;
        BookshelfShelf1.enabled = false;
        BookshelfBooks2.enabled = false;
        BookshelfShelf2.enabled = false;
        BookshelfBooks3.enabled = false;
        BookshelfShelf3.enabled = false;
        BookshelfBooks4.enabled = false;
        BookshelfShelf4.enabled = false;
        DiningChairCushion.enabled = false;
        DiningChairLegs.enabled = false;
        DiningChairSeat.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightLeftTorch.enabled = false;

		WallLightRightHolder.enabled = false;
		WallLightRightTorch.enabled = false;
	}
	
	public void F2LibraryLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void F2LibraryLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void F2LibraryGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			F2LibraryMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}