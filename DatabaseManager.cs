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

public class DatabaseManager : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static DatabaseManager SharedInstance = null;
	
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
		if (SharedInstance == null) {
			SharedInstance = this;
		}
		
		else if (SharedInstance != this) {
			Destroy(gameObject);
		}
		
		DontDestroyOnLoad(gameObject);
		
		FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://hall-of-the-art-thieves.firebaseio.com/");
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- FIREBASE FUNCTION ---------------
	public void CreateNewChateauPlayer(ChateauPlayer player, string UserID) {
		string PlayerJSON = JsonUtility.ToJson(player);
		Router.PlayerWithUID(UserID).SetRawJsonValueAsync(PlayerJSON);
	}
	
	public void CreateNewChateauGhostTimers(ChateauGhostTimers ghostTimers, string UserID) {
		string GhostsJSON = JsonUtility.ToJson(ghostTimers);
		Router.GhostsWithUID(UserID).SetRawJsonValueAsync(GhostsJSON);
	}
    
    public void CreateNewChateauArtTimers(ChateauArtTimers artTimers, string UserID) {
		string ArtJSON = JsonUtility.ToJson(artTimers);
		Router.ArtWithUID(UserID).SetRawJsonValueAsync(ArtJSON);
	}
    
    public void CreateNewChateauArtPurchase(ChateauArtPurchase artPurchase, string UserID) {
		string ArtPurchaseJSON = JsonUtility.ToJson(artPurchase);
		Router.ArtPurchaseWithUID(UserID).SetRawJsonValueAsync(ArtPurchaseJSON);
	}
    
    public void CreateNewChateauObjectives(ChateauObjectives objectives, string UserID) {
		string ObjectivesJSON = JsonUtility.ToJson(objectives);
		Router.ObjectivesWithUID(UserID).SetRawJsonValueAsync(ObjectivesJSON);
	}
    
    public void CreateNewChateauGhostClicks(ChateauGhostClicks ghostClicks, string UserID) {
		string GhostClicksJSON = JsonUtility.ToJson(ghostClicks);
		Router.GhostClicksWithUID(UserID).SetRawJsonValueAsync(GhostClicksJSON);
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}