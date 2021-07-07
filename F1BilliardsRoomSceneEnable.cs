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

public class F1BilliardsRoomSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Obejcts
	public Renderer Bierstadt;
	public Renderer BierstadtGhost;
	public Renderer Donatello;
	public Renderer DonatelloGhost;
	
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
	public Renderer PoolTableBall1;
	public Renderer PoolTableBall2;
	public Renderer PoolTableBall3;
	public Renderer PoolTableBox;
	public Renderer PoolTableHoles;
	public Renderer PoolTableLegs;
	public Renderer ChairChusion1;
	public Renderer ChairLegs1;
	public Renderer ChairSeat1;
	public Renderer ChairCushion2;
	public Renderer ChairLegs2;
	public Renderer ChairSeat2;
	
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
		F1BilliardsRoomRoomEnable();
		
		F1BilliardsRoomMainDisable();
		F1BilliardsRoomLightLeftDisable();
		F1BilliardsRoomLightRightDisable();
        
        AllTimersPlaying.AllTimersPlay();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		F1BilliardsRoomGhostsShow();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void F1BilliardsRoomMainEnable() {
		Bierstadt.enabled = true;
		BierstadtGhost.enabled = true;
		Donatello.enabled = true;
		DonatelloGhost.enabled = true;
	}
	
	public void F1BilliardsRoomRoomEnable() {
		Flooring.enabled = true;
		WallLeft.enabled = true;
		WallBack.enabled = true;
		WallRight.enabled = true;
		
		AreaRug.enabled = true;
		PoolTableBall1.enabled = true;
		PoolTableBall2.enabled = true;
		PoolTableBall3.enabled = true;
		PoolTableBox.enabled = true;
		PoolTableHoles.enabled = true;
		PoolTableLegs.enabled = true;
		ChairChusion1.enabled = true;
		ChairLegs1.enabled = true;
		ChairSeat1.enabled = true;
		ChairCushion2.enabled = true;
		ChairLegs2.enabled = true;
		ChairSeat2.enabled = true;

		WallLightLeftHolder.enabled = true;
		WallLightLeftTorch.enabled = true;

		WallLightRightHolder.enabled = true;
		WallLightRightTorch.enabled = true;
	}
	
	public void F1BilliardsRoomLightLeftEnable() {
		WallLightLeftFire.Play();
		WallLightLeftLight.enabled = true;
	}
	
	public void F1BilliardsRoomLightRightEnable() {
		WallLightRightFire.Play();
		WallLightRightLight.enabled = true;
	}
	
// --------------- DISABLE FUNCTIONS ---------------
	public void F1BilliardsRoomAllDisable() {
		F1BilliardsRoomMainDisable();
		F1BilliardsRoomRoomDisable();
		F1BilliardsRoomLightLeftDisable();
		F1BilliardsRoomLightRightDisable();
	}
	
	public void F1BilliardsRoomMainDisable() {
		Bierstadt.enabled = false;
		BierstadtGhost.enabled = false;
		Donatello.enabled = false;
		DonatelloGhost.enabled = false;
	}
	
	public void F1BilliardsRoomRoomDisable() {
		Flooring.enabled = false;
		WallLeft.enabled = false;
		WallBack.enabled = false;
		WallRight.enabled = false;
		
		AreaRug.enabled = false;
		PoolTableBall1.enabled = false;
		PoolTableBall2.enabled = false;
		PoolTableBall3.enabled = false;
		PoolTableBox.enabled = false;
		PoolTableHoles.enabled = false;
		PoolTableLegs.enabled = false;
		ChairChusion1.enabled = false;
		ChairLegs1.enabled = false;
		ChairSeat1.enabled = false;
		ChairCushion2.enabled = false;
		ChairLegs2.enabled = false;
		ChairSeat2.enabled = false;

		WallLightLeftHolder.enabled = false;
		WallLightLeftTorch.enabled = false;

		WallLightRightHolder.enabled = false;
		WallLightRightTorch.enabled = false;
	}
	
	public void F1BilliardsRoomLightLeftDisable() {
		WallLightLeftFire.Pause();
		WallLightLeftLight.enabled = false;
	}
	
	public void F1BilliardsRoomLightRightDisable() {
		WallLightRightFire.Pause();
		WallLightRightLight.enabled = false;
	}
	
// --------------- SHOWING FUNCTIONS ---------------
	public void F1BilliardsRoomGhostsShow() {
		if (RoomLightChanging.RoomLightIntensity >= RoomLightChanging.MaxRoomLightIntensity) {
			F1BilliardsRoomMainEnable();
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}