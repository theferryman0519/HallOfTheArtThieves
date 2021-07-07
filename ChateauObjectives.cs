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

public class ChateauObjectives {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Class Properties - Objectives Complete
    public int DBAllTimeObjectiveComplete01;
    public int DBAllTimeObjectiveComplete02;
    public int DBAllTimeObjectiveComplete03;
    public int DBAllTimeObjectiveComplete04;
    public int DBAllTimeObjectiveComplete05;
    public int DBAllTimeObjectiveComplete06;
    public int DBAllTimeObjectiveComplete07;
    public int DBAllTimeObjectiveComplete08;
    public int DBAllTimeObjectiveComplete09;
    public int DBAllTimeObjectiveComplete10;
    public int DBAllTimeObjectiveComplete11;
    public int DBAllTimeObjectiveComplete12;
    public int DBAllTimeObjectiveComplete13;
    public int DBAllTimeObjectiveComplete14;
    public int DBAllTimeObjectiveComplete15;
    public int DBEventObjectiveComplete101;
    public int DBEventObjectiveComplete102;
    public int DBEventObjectiveComplete103;
    public int DBEventObjectiveComplete104;
    public int DBEventObjectiveComplete105;
    public int DBEventObjectiveComplete201;
    public int DBEventObjectiveComplete202;
    public int DBEventObjectiveComplete203;
    public int DBEventObjectiveComplete204;
    public int DBEventObjectiveComplete205;
    public int DBEventObjectiveComplete301;
    public int DBEventObjectiveComplete302;
    public int DBEventObjectiveComplete303;
    public int DBEventObjectiveComplete304;
    public int DBEventObjectiveComplete305; 
    public int DBEventObjectiveComplete401;
    public int DBEventObjectiveComplete402;
    public int DBEventObjectiveComplete403;
    public int DBEventObjectiveComplete404;
    public int DBEventObjectiveComplete405; 
    public int DBEventObjectiveComplete501;
    public int DBEventObjectiveComplete502;
    public int DBEventObjectiveComplete503;
    public int DBEventObjectiveComplete504;
    public int DBEventObjectiveComplete505;
    public int DBEventObjectiveComplete601;
    public int DBEventObjectiveComplete602;
    public int DBEventObjectiveComplete603;
    public int DBEventObjectiveComplete604;
    public int DBEventObjectiveComplete605;
	
	// Constructor - Player
	public ChateauObjectives(int DBAllTimeObjectiveComplete01, int DBAllTimeObjectiveComplete02, int DBAllTimeObjectiveComplete03, int DBAllTimeObjectiveComplete04, int DBAllTimeObjectiveComplete05, int DBAllTimeObjectiveComplete06, int DBAllTimeObjectiveComplete07, int DBAllTimeObjectiveComplete08, int DBAllTimeObjectiveComplete09, int DBAllTimeObjectiveComplete10, int DBAllTimeObjectiveComplete11, int DBAllTimeObjectiveComplete12, int DBAllTimeObjectiveComplete13, int DBAllTimeObjectiveComplete14, int DBAllTimeObjectiveComplete15, int DBEventObjectiveComplete101, int DBEventObjectiveComplete102, int DBEventObjectiveComplete103, int DBEventObjectiveComplete104, int DBEventObjectiveComplete105, int DBEventObjectiveComplete201, int DBEventObjectiveComplete202, int DBEventObjectiveComplete203, int DBEventObjectiveComplete204, int DBEventObjectiveComplete205, int DBEventObjectiveComplete301, int DBEventObjectiveComplete302, int DBEventObjectiveComplete303, int DBEventObjectiveComplete304, int DBEventObjectiveComplete305, int DBEventObjectiveComplete401, int DBEventObjectiveComplete402, int DBEventObjectiveComplete403, int DBEventObjectiveComplete404, int DBEventObjectiveComplete405, int DBEventObjectiveComplete501, int DBEventObjectiveComplete502, int DBEventObjectiveComplete503, int DBEventObjectiveComplete504, int DBEventObjectiveComplete505, int DBEventObjectiveComplete601, int DBEventObjectiveComplete602, int DBEventObjectiveComplete603, int DBEventObjectiveComplete604, int DBEventObjectiveComplete605) {
        this.DBAllTimeObjectiveComplete01 = DBAllTimeObjectiveComplete01;
        this.DBAllTimeObjectiveComplete02 = DBAllTimeObjectiveComplete02;
        this.DBAllTimeObjectiveComplete03 = DBAllTimeObjectiveComplete03;
        this.DBAllTimeObjectiveComplete04 = DBAllTimeObjectiveComplete04;
        this.DBAllTimeObjectiveComplete05 = DBAllTimeObjectiveComplete05;
        this.DBAllTimeObjectiveComplete06 = DBAllTimeObjectiveComplete06;
        this.DBAllTimeObjectiveComplete07 = DBAllTimeObjectiveComplete07;
        this.DBAllTimeObjectiveComplete08 = DBAllTimeObjectiveComplete08;
        this.DBAllTimeObjectiveComplete09 = DBAllTimeObjectiveComplete09;
        this.DBAllTimeObjectiveComplete10 = DBAllTimeObjectiveComplete10;
        this.DBAllTimeObjectiveComplete11 = DBAllTimeObjectiveComplete11;
        this.DBAllTimeObjectiveComplete12 = DBAllTimeObjectiveComplete12;
        this.DBAllTimeObjectiveComplete13 = DBAllTimeObjectiveComplete13;
        this.DBAllTimeObjectiveComplete14 = DBAllTimeObjectiveComplete14;
        this.DBEventObjectiveComplete101 = DBEventObjectiveComplete101;
        this.DBEventObjectiveComplete102 = DBEventObjectiveComplete102;
        this.DBEventObjectiveComplete103 = DBEventObjectiveComplete103;
        this.DBEventObjectiveComplete104 = DBEventObjectiveComplete104;
        this.DBEventObjectiveComplete105 = DBEventObjectiveComplete105;
        this.DBEventObjectiveComplete201 = DBEventObjectiveComplete201;
        this.DBEventObjectiveComplete202 = DBEventObjectiveComplete202;
        this.DBEventObjectiveComplete203 = DBEventObjectiveComplete203;
        this.DBEventObjectiveComplete204 = DBEventObjectiveComplete204;
        this.DBEventObjectiveComplete205 = DBEventObjectiveComplete205;
        this.DBEventObjectiveComplete301 = DBEventObjectiveComplete301;
        this.DBEventObjectiveComplete302 = DBEventObjectiveComplete302;
        this.DBEventObjectiveComplete303 = DBEventObjectiveComplete303;
        this.DBEventObjectiveComplete304 = DBEventObjectiveComplete304;
        this.DBEventObjectiveComplete305 = DBEventObjectiveComplete305;
        this.DBEventObjectiveComplete401 = DBEventObjectiveComplete401;
        this.DBEventObjectiveComplete402 = DBEventObjectiveComplete402;
        this.DBEventObjectiveComplete403 = DBEventObjectiveComplete403;
        this.DBEventObjectiveComplete404 = DBEventObjectiveComplete404;
        this.DBEventObjectiveComplete405 = DBEventObjectiveComplete405;
        this.DBEventObjectiveComplete501 = DBEventObjectiveComplete501;
        this.DBEventObjectiveComplete502 = DBEventObjectiveComplete502;
        this.DBEventObjectiveComplete503 = DBEventObjectiveComplete503;
        this.DBEventObjectiveComplete504 = DBEventObjectiveComplete504;
        this.DBEventObjectiveComplete505 = DBEventObjectiveComplete505;
        this.DBEventObjectiveComplete601 = DBEventObjectiveComplete601;
        this.DBEventObjectiveComplete602 = DBEventObjectiveComplete602;
        this.DBEventObjectiveComplete603 = DBEventObjectiveComplete603;
        this.DBEventObjectiveComplete604 = DBEventObjectiveComplete604;
        this.DBEventObjectiveComplete605 = DBEventObjectiveComplete605;
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