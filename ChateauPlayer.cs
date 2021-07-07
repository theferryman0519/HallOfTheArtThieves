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

public class ChateauPlayer {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Class Properties - Player Profile
	public string DBPlayerName;
	public string DBPlayerEmail;
	public string DBPlayerFavArtist;
	public int DBNewsletterSubscription;
	public int DBBankAccountAmount;
	public int DBNumberOfArtworksCollected;
    public int DBNumberOfArtworksCollectedF1;
    public int DBNumberOfArtworksCollectedF2;
    public int DBNumberOfArtworksCollectedF3;
    public int DBNumberOfArtworksCollectedG1;
    public int DBNumberOfArtworksCollectedG2;
    public int DBNumberOfArtworksCollectedG3;
    public int DBNumberOfArtworksCollectedFB;
    public int DBNumberOfArtworksCollectedFBonus;
    public int DBNumberOfArtworksCollectedAzuchiMomoyama;
    public int DBNumberOfArtworksCollectedBaroque;
    public int DBNumberOfArtworksCollectedBunjinga;
    public int DBNumberOfArtworksCollectedClassicism;
    public int DBNumberOfArtworksCollectedEdo;
    public int DBNumberOfArtworksCollectedExpressionism;
    public int DBNumberOfArtworksCollectedGoldenAge;
    public int DBNumberOfArtworksCollectedImpressionism;
    public int DBNumberOfArtworksCollectedModernism;
    public int DBNumberOfArtworksCollectedMuromachi;
    public int DBNumberOfArtworksCollectedNeoclassicism;
    public int DBNumberOfArtworksCollectedPostImpressionism;
    public int DBNumberOfArtworksCollectedRealism;
    public int DBNumberOfArtworksCollectedRenaissance;
    public int DBNumberOfArtworksCollectedRomanticism;
    public int DBNumberOfArtworksCollectedSongDynasty;
    public int DBNumberOfArtworksCollectedSouthSchool;
    public int DBNumberOfArtworksCollectedTangDynasty;
    public int DBNumberOfArtworksCollectedAmerican;
    public int DBNumberOfArtworksCollectedAustrian;
    public int DBNumberOfArtworksCollectedChinese;
    public int DBNumberOfArtworksCollectedDutch;
    public int DBNumberOfArtworksCollectedEnglish;
    public int DBNumberOfArtworksCollectedFrench;
    public int DBNumberOfArtworksCollectedGerman;
    public int DBNumberOfArtworksCollectedGreek;
    public int DBNumberOfArtworksCollectedItalian;
    public int DBNumberOfArtworksCollectedJapanese;
    public int DBNumberOfArtworksCollectedKorean;
    public int DBNumberOfArtworksCollectedNorwegian;
    public int DBNumberOfArtworksCollectedPolish;
    public int DBNumberOfArtworksCollectedRussian;
    public int DBNumberOfArtworksCollectedSpanish;
    public int DBNumberOfArtworksCollectedSwiss;
	public int DBSecondFloorUnlock;
	public int DBThirdFloorUnlock;
	public int DBFirstGardenUnlock;
	public int DBSecondGardenUnlock;
    public int DBThirdGardenUnlock;
	public int DBBasementUnlock;
    public int DBLogInTipsHints;
    public int DBPlayerLogInDays;
    public int DBPlayerLogInTrueFalse;
	
	// Constructor - Player
	public ChateauPlayer(string DBPlayerName, string DBPlayerEmail, string DBPlayerFavArtist, int DBNewsletterSubscription, int DBBankAccountAmount, int DBNumberOfArtworksCollected, int DBNumberOfArtworksCollectedF1, int DBNumberOfArtworksCollectedF2, int DBNumberOfArtworksCollectedF3, int DBNumberOfArtworksCollectedG1, int DBNumberOfArtworksCollectedG2, int DBNumberOfArtworksCollectedG3, int DBNumberOfArtworksCollectedFB, int DBNumberOfArtworksCollectedFBonus, int DBNumberOfArtworksCollectedAzuchiMomoyama, int DBNumberOfArtworksCollectedBaroque, int DBNumberOfArtworksCollectedBunjinga, int DBNumberOfArtworksCollectedClassicism, int DBNumberOfArtworksCollectedEdo, int DBNumberOfArtworksCollectedExpressionism, int DBNumberOfArtworksCollectedGoldenAge, int DBNumberOfArtworksCollectedImpressionism, int DBNumberOfArtworksCollectedModernism, int DBNumberOfArtworksCollectedMuromachi, int DBNumberOfArtworksCollectedNeoclassicism, int DBNumberOfArtworksCollectedPostImpressionism, int DBNumberOfArtworksCollectedRealism, int DBNumberOfArtworksCollectedRenaissance, int DBNumberOfArtworksCollectedRomanticism, int DBNumberOfArtworksCollectedSongDynasty, int DBNumberOfArtworksCollectedSouthSchool, int DBNumberOfArtworksCollectedTangDynasty, int DBNumberOfArtworksCollectedAmerican, int DBNumberOfArtworksCollectedAustrian, int DBNumberOfArtworksCollectedChinese, int DBNumberOfArtworksCollectedDutch, int DBNumberOfArtworksCollectedEnglish, int DBNumberOfArtworksCollectedFrench, int DBNumberOfArtworksCollectedGerman, int DBNumberOfArtworksCollectedGreek, int DBNumberOfArtworksCollectedItalian, int DBNumberOfArtworksCollectedJapanese, int DBNumberOfArtworksCollectedKorean, int DBNumberOfArtworksCollectedNorwegian, int DBNumberOfArtworksCollectedPolish, int DBNumberOfArtworksCollectedRussian, int DBNumberOfArtworksCollectedSpanish, int DBNumberOfArtworksCollectedSwiss, int DBSecondFloorUnlock, int DBThirdFloorUnlock, int DBFirstGardenUnlock, int DBSecondGardenUnlock, int DBThirdGardenUnlock, int DBBasementUnlock, int DBLogInTipsHints, int DBPlayerLogInDays, int DBPlayerLogInTrueFalse) {
		this.DBPlayerName = DBPlayerName;
		this.DBPlayerEmail = DBPlayerEmail;
		this.DBPlayerFavArtist = DBPlayerFavArtist;
		this.DBNewsletterSubscription = DBNewsletterSubscription;
		this.DBBankAccountAmount = DBBankAccountAmount;
		this.DBNumberOfArtworksCollected = DBNumberOfArtworksCollected;
        this.DBNumberOfArtworksCollectedF1 = DBNumberOfArtworksCollectedF1;
        this.DBNumberOfArtworksCollectedF2 = DBNumberOfArtworksCollectedF2;
        this.DBNumberOfArtworksCollectedF3 = DBNumberOfArtworksCollectedF3;
        this.DBNumberOfArtworksCollectedG1 = DBNumberOfArtworksCollectedG1;
        this.DBNumberOfArtworksCollectedG2 = DBNumberOfArtworksCollectedG2;
        this.DBNumberOfArtworksCollectedG3 = DBNumberOfArtworksCollectedG3;
        this.DBNumberOfArtworksCollectedFB = DBNumberOfArtworksCollectedFB;
        this.DBNumberOfArtworksCollectedFBonus = DBNumberOfArtworksCollectedFBonus;
        this.DBNumberOfArtworksCollectedAzuchiMomoyama = DBNumberOfArtworksCollectedAzuchiMomoyama;
        this.DBNumberOfArtworksCollectedBaroque = DBNumberOfArtworksCollectedBaroque;
        this.DBNumberOfArtworksCollectedBunjinga = DBNumberOfArtworksCollectedBunjinga;
        this.DBNumberOfArtworksCollectedClassicism = DBNumberOfArtworksCollectedClassicism;
        this.DBNumberOfArtworksCollectedEdo = DBNumberOfArtworksCollectedEdo;
        this.DBNumberOfArtworksCollectedExpressionism = DBNumberOfArtworksCollectedExpressionism;
        this.DBNumberOfArtworksCollectedGoldenAge = DBNumberOfArtworksCollectedGoldenAge;
        this.DBNumberOfArtworksCollectedImpressionism = DBNumberOfArtworksCollectedImpressionism;
        this.DBNumberOfArtworksCollectedModernism = DBNumberOfArtworksCollectedModernism;
        this.DBNumberOfArtworksCollectedMuromachi = DBNumberOfArtworksCollectedMuromachi;
        this.DBNumberOfArtworksCollectedNeoclassicism = DBNumberOfArtworksCollectedNeoclassicism;
        this.DBNumberOfArtworksCollectedPostImpressionism = DBNumberOfArtworksCollectedPostImpressionism;
        this.DBNumberOfArtworksCollectedRealism = DBNumberOfArtworksCollectedRealism;
        this.DBNumberOfArtworksCollectedRenaissance = DBNumberOfArtworksCollectedRenaissance;
        this.DBNumberOfArtworksCollectedRomanticism = DBNumberOfArtworksCollectedRomanticism;
        this.DBNumberOfArtworksCollectedSongDynasty = DBNumberOfArtworksCollectedSongDynasty;
        this.DBNumberOfArtworksCollectedSouthSchool = DBNumberOfArtworksCollectedSouthSchool;
        this.DBNumberOfArtworksCollectedTangDynasty = DBNumberOfArtworksCollectedTangDynasty;
        this.DBNumberOfArtworksCollectedAmerican = DBNumberOfArtworksCollectedAmerican;
        this.DBNumberOfArtworksCollectedAustrian = DBNumberOfArtworksCollectedAustrian;
        this.DBNumberOfArtworksCollectedChinese = DBNumberOfArtworksCollectedChinese;
        this.DBNumberOfArtworksCollectedDutch = DBNumberOfArtworksCollectedDutch;
        this.DBNumberOfArtworksCollectedEnglish = DBNumberOfArtworksCollectedEnglish;
        this.DBNumberOfArtworksCollectedFrench = DBNumberOfArtworksCollectedFrench;
        this.DBNumberOfArtworksCollectedGerman = DBNumberOfArtworksCollectedGerman;
        this.DBNumberOfArtworksCollectedGreek = DBNumberOfArtworksCollectedGreek;
        this.DBNumberOfArtworksCollectedItalian = DBNumberOfArtworksCollectedItalian;
        this.DBNumberOfArtworksCollectedJapanese = DBNumberOfArtworksCollectedJapanese;
        this.DBNumberOfArtworksCollectedKorean = DBNumberOfArtworksCollectedKorean;
        this.DBNumberOfArtworksCollectedNorwegian = DBNumberOfArtworksCollectedNorwegian;
        this.DBNumberOfArtworksCollectedPolish = DBNumberOfArtworksCollectedPolish;
        this.DBNumberOfArtworksCollectedRussian = DBNumberOfArtworksCollectedRussian;
        this.DBNumberOfArtworksCollectedSpanish = DBNumberOfArtworksCollectedSpanish;
        this.DBNumberOfArtworksCollectedSwiss = DBNumberOfArtworksCollectedSwiss;
		this.DBSecondFloorUnlock = DBSecondFloorUnlock;
		this.DBThirdFloorUnlock = DBThirdFloorUnlock;
		this.DBFirstGardenUnlock = DBFirstGardenUnlock;
		this.DBSecondGardenUnlock = DBSecondGardenUnlock;
        this.DBThirdGardenUnlock = DBThirdGardenUnlock;
		this.DBBasementUnlock = DBBasementUnlock;
        this.DBLogInTipsHints = DBLogInTipsHints;
        this.DBPlayerLogInDays = DBPlayerLogInDays;
        this.DBPlayerLogInTrueFalse = DBPlayerLogInTrueFalse;
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