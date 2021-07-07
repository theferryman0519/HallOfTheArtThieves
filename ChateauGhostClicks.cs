using System;
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

public class ChateauGhostClicks {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Class Properties - Ghost Clicks
	public int DBGhostMonthlyClicksF1A;
	public int DBGhostMonthlyClicksF1B;
	public int DBGhostMonthlyClicksF1C;
	public int DBGhostMonthlyClicksF1D;
	public int DBGhostMonthlyClicksF1E;
	public int DBGhostMonthlyClicksF2A;
	public int DBGhostMonthlyClicksF2B;
	public int DBGhostMonthlyClicksF2C;
	public int DBGhostMonthlyClicksF2D;
	public int DBGhostMonthlyClicksF2E;
	public int DBGhostMonthlyClicksF3A;
	public int DBGhostMonthlyClicksF3B;
	public int DBGhostMonthlyClicksF3C;
	public int DBGhostMonthlyClicksF3D;
	public int DBGhostMonthlyClicksF3E;
	public int DBGhostMonthlyClicksG1A;
	public int DBGhostMonthlyClicksG1B;
	public int DBGhostMonthlyClicksG1C;
	public int DBGhostMonthlyClicksG1D;
	public int DBGhostMonthlyClicksG1E;
	public int DBGhostMonthlyClicksG2A;
	public int DBGhostMonthlyClicksG2B;
	public int DBGhostMonthlyClicksG2C;
	public int DBGhostMonthlyClicksG2D;
	public int DBGhostMonthlyClicksG2E;
    public int DBGhostMonthlyClicksG3A;
	public int DBGhostMonthlyClicksG3B;
	public int DBGhostMonthlyClicksG3C;
	public int DBGhostMonthlyClicksG3D;
	public int DBGhostMonthlyClicksG3E;
	public int DBGhostMonthlyClicksFBA;
	public int DBGhostMonthlyClicksFBB;
	public int DBGhostMonthlyClicksFBC;
	public int DBGhostMonthlyClicksFBD;
	public int DBGhostMonthlyClicksFBE;
		
	// Constructor - Ghost Clicks
	public ChateauGhostClicks(int DBGhostMonthlyClicksF1A, int DBGhostMonthlyClicksF1B, int DBGhostMonthlyClicksF1C, int DBGhostMonthlyClicksF1D, int DBGhostMonthlyClicksF1E, int DBGhostMonthlyClicksF2A, int DBGhostMonthlyClicksF2B, int DBGhostMonthlyClicksF2C, int DBGhostMonthlyClicksF2D, int DBGhostMonthlyClicksF2E, int DBGhostMonthlyClicksF3A, int DBGhostMonthlyClicksF3B, int DBGhostMonthlyClicksF3C, int DBGhostMonthlyClicksF3D, int DBGhostMonthlyClicksF3E, int DBGhostMonthlyClicksG1A, int DBGhostMonthlyClicksG1B, int DBGhostMonthlyClicksG1C, int DBGhostMonthlyClicksG1D, int DBGhostMonthlyClicksG1E, int DBGhostMonthlyClicksG2A, int DBGhostMonthlyClicksG2B, int DBGhostMonthlyClicksG2C, int DBGhostMonthlyClicksG2D, int DBGhostMonthlyClicksG2E, int DBGhostMonthlyClicksG3A, int DBGhostMonthlyClicksG3B, int DBGhostMonthlyClicksG3C, int DBGhostMonthlyClicksG3D, int DBGhostMonthlyClicksG3E, int DBGhostMonthlyClicksFBA, int DBGhostMonthlyClicksFBB, int DBGhostMonthlyClicksFBC, int DBGhostMonthlyClicksFBD, int DBGhostMonthlyClicksFBE) {
		this.DBGhostMonthlyClicksF1A = DBGhostMonthlyClicksF1A;
		this.DBGhostMonthlyClicksF1B = DBGhostMonthlyClicksF1B;
		this.DBGhostMonthlyClicksF1C = DBGhostMonthlyClicksF1C;
		this.DBGhostMonthlyClicksF1D = DBGhostMonthlyClicksF1D;
		this.DBGhostMonthlyClicksF1E = DBGhostMonthlyClicksF1E;
		this.DBGhostMonthlyClicksF2A = DBGhostMonthlyClicksF2A;
		this.DBGhostMonthlyClicksF2B = DBGhostMonthlyClicksF2B;
		this.DBGhostMonthlyClicksF2C = DBGhostMonthlyClicksF2C;
		this.DBGhostMonthlyClicksF2D = DBGhostMonthlyClicksF2D;
		this.DBGhostMonthlyClicksF2E = DBGhostMonthlyClicksF2E;
		this.DBGhostMonthlyClicksF3A = DBGhostMonthlyClicksF3A;
		this.DBGhostMonthlyClicksF3B = DBGhostMonthlyClicksF3B;
		this.DBGhostMonthlyClicksF3C = DBGhostMonthlyClicksF3C;
		this.DBGhostMonthlyClicksF3D = DBGhostMonthlyClicksF3D;
		this.DBGhostMonthlyClicksF3E = DBGhostMonthlyClicksF3E;
		this.DBGhostMonthlyClicksG1A = DBGhostMonthlyClicksG1A;
		this.DBGhostMonthlyClicksG1B = DBGhostMonthlyClicksG1B;
		this.DBGhostMonthlyClicksG1C = DBGhostMonthlyClicksG1C;
		this.DBGhostMonthlyClicksG1D = DBGhostMonthlyClicksG1D;
		this.DBGhostMonthlyClicksG1E = DBGhostMonthlyClicksG1E;
		this.DBGhostMonthlyClicksG2A = DBGhostMonthlyClicksG2A;
		this.DBGhostMonthlyClicksG2B = DBGhostMonthlyClicksG2B;
		this.DBGhostMonthlyClicksG2C = DBGhostMonthlyClicksG2C;
		this.DBGhostMonthlyClicksG2D = DBGhostMonthlyClicksG2D;
		this.DBGhostMonthlyClicksG2E = DBGhostMonthlyClicksG2E;
        this.DBGhostMonthlyClicksG3A = DBGhostMonthlyClicksG3A;
		this.DBGhostMonthlyClicksG3B = DBGhostMonthlyClicksG3B;
		this.DBGhostMonthlyClicksG3C = DBGhostMonthlyClicksG3C;
		this.DBGhostMonthlyClicksG3D = DBGhostMonthlyClicksG3D;
		this.DBGhostMonthlyClicksG3E = DBGhostMonthlyClicksG3E;
		this.DBGhostMonthlyClicksFBA = DBGhostMonthlyClicksFBA;
		this.DBGhostMonthlyClicksFBB = DBGhostMonthlyClicksFBB;
		this.DBGhostMonthlyClicksFBC = DBGhostMonthlyClicksFBC;
		this.DBGhostMonthlyClicksFBD = DBGhostMonthlyClicksFBD;
		this.DBGhostMonthlyClicksFBE = DBGhostMonthlyClicksFBE;
	}
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
	
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}