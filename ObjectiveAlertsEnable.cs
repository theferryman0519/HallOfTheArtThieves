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

public class ObjectiveAlertsEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image UIObjectiveAlertsPanel;
    public Text UIObjectiveAlertsText;
	
// --------------- PRIVATE VARIABLES ---------------
	private string CurrentEventObjectiveDate;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	// Auth
	private FirebaseAuth PlayerAuthentication;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		ObjectiveAlertsAllDisable();
        
        // Firebase Auth
		PlayerAuthentication = FirebaseAuth.DefaultInstance;
        
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            FirebaseDatabase.DefaultInstance.GetReference("ChateauObjectives").Child(FirebaseAuthentication.NewPlayer.UserId).GetValueAsync().ContinueWith(playertask => {
                if (playertask.IsCanceled || playertask.IsFaulted) {
                    
                }
                
                else {
                    DataSnapshot ChateauSnapshot = playertask.Result;

                    // ALl-Time Objectives
                    DataFillingInformation.DBAllTimeObjectiveComplete01 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete01").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete02 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete02").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete03 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete03").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete04 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete04").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete05 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete05").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete06 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete06").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete07 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete07").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete08 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete08").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete09 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete09").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete10 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete10").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete11 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete11").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete12 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete12").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete13 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete13").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete14 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete14").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete15 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete15").Value.ToString();
                    
                    // Event Objectives
                    DataFillingInformation.DBEventObjectiveComplete101 = ChateauSnapshot.Child("DBEventObjectiveComplete101").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete102 = ChateauSnapshot.Child("DBEventObjectiveComplete102").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete103 = ChateauSnapshot.Child("DBEventObjectiveComplete103").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete104 = ChateauSnapshot.Child("DBEventObjectiveComplete104").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete105 = ChateauSnapshot.Child("DBEventObjectiveComplete105").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete201 = ChateauSnapshot.Child("DBEventObjectiveComplete201").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete202 = ChateauSnapshot.Child("DBEventObjectiveComplete202").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete203 = ChateauSnapshot.Child("DBEventObjectiveComplete203").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete204 = ChateauSnapshot.Child("DBEventObjectiveComplete204").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete205 = ChateauSnapshot.Child("DBEventObjectiveComplete205").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete301 = ChateauSnapshot.Child("DBEventObjectiveComplete301").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete302 = ChateauSnapshot.Child("DBEventObjectiveComplete302").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete303 = ChateauSnapshot.Child("DBEventObjectiveComplete303").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete304 = ChateauSnapshot.Child("DBEventObjectiveComplete304").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete305 = ChateauSnapshot.Child("DBEventObjectiveComplete305").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete401 = ChateauSnapshot.Child("DBEventObjectiveComplete401").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete402 = ChateauSnapshot.Child("DBEventObjectiveComplete402").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete403 = ChateauSnapshot.Child("DBEventObjectiveComplete403").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete404 = ChateauSnapshot.Child("DBEventObjectiveComplete404").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete405 = ChateauSnapshot.Child("DBEventObjectiveComplete405").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete501 = ChateauSnapshot.Child("DBEventObjectiveComplete501").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete502 = ChateauSnapshot.Child("DBEventObjectiveComplete502").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete503 = ChateauSnapshot.Child("DBEventObjectiveComplete503").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete504 = ChateauSnapshot.Child("DBEventObjectiveComplete504").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete505 = ChateauSnapshot.Child("DBEventObjectiveComplete505").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete601 = ChateauSnapshot.Child("DBEventObjectiveComplete601").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete602 = ChateauSnapshot.Child("DBEventObjectiveComplete602").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete603 = ChateauSnapshot.Child("DBEventObjectiveComplete603").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete604 = ChateauSnapshot.Child("DBEventObjectiveComplete604").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete605 = ChateauSnapshot.Child("DBEventObjectiveComplete605").Value.ToString();
                }
            });
            
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.NewPlayer.UserId).GetValueAsync().ContinueWith(playertasktwo => {
                if (playertasktwo.IsCanceled || playertasktwo.IsFaulted) {
                    
                }
                
                else {
                    DataSnapshot ChateauSnapshotTwo = playertasktwo.Result;

                    DataFillingInformation.DBNumberOfArtworksCollected = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollected").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedF1 = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedF1").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedF2 = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedF2").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedF3 = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedF3").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedG1 = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedG1").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedG2 = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedG2").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedFB = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedFB").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedBaroque = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedBaroque").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedBunjinga = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedBunjinga").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedEdo = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedEdo").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedExpressionism = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedExpressionism").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedGoldenAge = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedGoldenAge").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedImpressionism = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedImpressionism").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedModernism = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedModernism").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedMuromachi = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedMuromachi").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedNeoclassicism = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedNeoclassicism").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedRealism = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedRealism").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedRenaissance = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedRenaissance").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedRomanticism = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedRomanticism").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedSongDynasty = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedSongDynasty").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedTangDynasty = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedTangDynasty").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedAmerican = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedAmerican").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedChinese = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedChinese").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedDutch = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedDutch").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedEnglish = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedEnglish").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedFrench = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedFrench").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedGerman = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedGerman").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedItalian = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedItalian").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedJapanese = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedJapanese").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedNorwegian = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedNorwegian").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedPolish = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedPolish").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedRussian = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedRussian").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedSpanish = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedSpanish").Value.ToString();
                    DataFillingInformation.DBSecondFloorUnlock = ChateauSnapshotTwo.Child("DBSecondFloorUnlock").Value.ToString();
                    DataFillingInformation.DBThirdFloorUnlock = ChateauSnapshotTwo.Child("DBThirdFloorUnlock").Value.ToString();
                    DataFillingInformation.DBFirstGardenUnlock = ChateauSnapshotTwo.Child("DBFirstGardenUnlock").Value.ToString();
                    DataFillingInformation.DBSecondGardenUnlock = ChateauSnapshotTwo.Child("DBSecondGardenUnlock").Value.ToString();
                    DataFillingInformation.DBBasementUnlock = ChateauSnapshotTwo.Child("DBBasementUnlock").Value.ToString();
                }
            });
            
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.NewPlayer.UserId).GetValueAsync().ContinueWith(playertaskthree => {
                if (playertaskthree.IsCanceled || playertaskthree.IsFaulted) {
                    
                }
                
                else {
                    DataSnapshot ChateauSnapshotThree = playertaskthree.Result;

                    DataFillingInformation.DBArtworkPurchaseF101 = ChateauSnapshotThree.Child("DBArtworkPurchaseF101").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF102 = ChateauSnapshotThree.Child("DBArtworkPurchaseF102").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF103 = ChateauSnapshotThree.Child("DBArtworkPurchaseF103").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF104 = ChateauSnapshotThree.Child("DBArtworkPurchaseF104").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF105 = ChateauSnapshotThree.Child("DBArtworkPurchaseF105").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF106 = ChateauSnapshotThree.Child("DBArtworkPurchaseF106").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF107 = ChateauSnapshotThree.Child("DBArtworkPurchaseF107").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF108 = ChateauSnapshotThree.Child("DBArtworkPurchaseF108").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF109 = ChateauSnapshotThree.Child("DBArtworkPurchaseF109").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF110 = ChateauSnapshotThree.Child("DBArtworkPurchaseF110").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF111 = ChateauSnapshotThree.Child("DBArtworkPurchaseF111").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF112 = ChateauSnapshotThree.Child("DBArtworkPurchaseF112").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF113 = ChateauSnapshotThree.Child("DBArtworkPurchaseF113").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF114 = ChateauSnapshotThree.Child("DBArtworkPurchaseF114").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF115 = ChateauSnapshotThree.Child("DBArtworkPurchaseF115").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF201 = ChateauSnapshotThree.Child("DBArtworkPurchaseF201").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF202 = ChateauSnapshotThree.Child("DBArtworkPurchaseF202").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF203 = ChateauSnapshotThree.Child("DBArtworkPurchaseF203").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF204 = ChateauSnapshotThree.Child("DBArtworkPurchaseF204").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF205 = ChateauSnapshotThree.Child("DBArtworkPurchaseF205").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF206 = ChateauSnapshotThree.Child("DBArtworkPurchaseF206").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF207 = ChateauSnapshotThree.Child("DBArtworkPurchaseF207").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF208 = ChateauSnapshotThree.Child("DBArtworkPurchaseF208").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF209 = ChateauSnapshotThree.Child("DBArtworkPurchaseF209").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF210 = ChateauSnapshotThree.Child("DBArtworkPurchaseF210").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF211 = ChateauSnapshotThree.Child("DBArtworkPurchaseF211").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF212 = ChateauSnapshotThree.Child("DBArtworkPurchaseF212").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF213 = ChateauSnapshotThree.Child("DBArtworkPurchaseF213").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF214 = ChateauSnapshotThree.Child("DBArtworkPurchaseF214").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF215 = ChateauSnapshotThree.Child("DBArtworkPurchaseF215").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF301 = ChateauSnapshotThree.Child("DBArtworkPurchaseF301").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF302 = ChateauSnapshotThree.Child("DBArtworkPurchaseF302").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF303 = ChateauSnapshotThree.Child("DBArtworkPurchaseF303").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF304 = ChateauSnapshotThree.Child("DBArtworkPurchaseF304").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF305 = ChateauSnapshotThree.Child("DBArtworkPurchaseF305").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF306 = ChateauSnapshotThree.Child("DBArtworkPurchaseF306").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF307 = ChateauSnapshotThree.Child("DBArtworkPurchaseF307").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF308 = ChateauSnapshotThree.Child("DBArtworkPurchaseF308").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF309 = ChateauSnapshotThree.Child("DBArtworkPurchaseF309").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF310 = ChateauSnapshotThree.Child("DBArtworkPurchaseF310").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF311 = ChateauSnapshotThree.Child("DBArtworkPurchaseF311").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF312 = ChateauSnapshotThree.Child("DBArtworkPurchaseF312").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF313 = ChateauSnapshotThree.Child("DBArtworkPurchaseF313").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF314 = ChateauSnapshotThree.Child("DBArtworkPurchaseF314").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF315 = ChateauSnapshotThree.Child("DBArtworkPurchaseF315").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG101 = ChateauSnapshotThree.Child("DBArtworkPurchaseG101").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG102 = ChateauSnapshotThree.Child("DBArtworkPurchaseG102").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG103 = ChateauSnapshotThree.Child("DBArtworkPurchaseG103").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG104 = ChateauSnapshotThree.Child("DBArtworkPurchaseG104").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG105 = ChateauSnapshotThree.Child("DBArtworkPurchaseG105").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG106 = ChateauSnapshotThree.Child("DBArtworkPurchaseG106").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG107 = ChateauSnapshotThree.Child("DBArtworkPurchaseG107").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG108 = ChateauSnapshotThree.Child("DBArtworkPurchaseG108").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG109 = ChateauSnapshotThree.Child("DBArtworkPurchaseG109").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG110 = ChateauSnapshotThree.Child("DBArtworkPurchaseG110").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG111 = ChateauSnapshotThree.Child("DBArtworkPurchaseG111").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG112 = ChateauSnapshotThree.Child("DBArtworkPurchaseG112").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG113 = ChateauSnapshotThree.Child("DBArtworkPurchaseG113").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG114 = ChateauSnapshotThree.Child("DBArtworkPurchaseG114").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG115 = ChateauSnapshotThree.Child("DBArtworkPurchaseG115").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG201 = ChateauSnapshotThree.Child("DBArtworkPurchaseG201").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG202 = ChateauSnapshotThree.Child("DBArtworkPurchaseG202").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG203 = ChateauSnapshotThree.Child("DBArtworkPurchaseG203").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG204 = ChateauSnapshotThree.Child("DBArtworkPurchaseG204").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG205 = ChateauSnapshotThree.Child("DBArtworkPurchaseG205").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG206 = ChateauSnapshotThree.Child("DBArtworkPurchaseG206").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG207 = ChateauSnapshotThree.Child("DBArtworkPurchaseG207").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG208 = ChateauSnapshotThree.Child("DBArtworkPurchaseG208").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG209 = ChateauSnapshotThree.Child("DBArtworkPurchaseG209").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG210 = ChateauSnapshotThree.Child("DBArtworkPurchaseG210").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG211 = ChateauSnapshotThree.Child("DBArtworkPurchaseG211").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG212 = ChateauSnapshotThree.Child("DBArtworkPurchaseG212").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG213 = ChateauSnapshotThree.Child("DBArtworkPurchaseG213").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG214 = ChateauSnapshotThree.Child("DBArtworkPurchaseG214").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG215 = ChateauSnapshotThree.Child("DBArtworkPurchaseG215").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB01 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB01").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB02 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB02").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB03 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB03").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB04 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB04").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB05 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB05").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB06 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB06").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB07 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB07").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB08 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB08").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB09 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB09").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB10 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB10").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB11 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB11").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB12 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB12").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB13 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB13").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB14 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB14").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB15 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB15").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain01 = ChateauSnapshotThree.Child("DBBonusArtworkObtain01").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain02 = ChateauSnapshotThree.Child("DBBonusArtworkObtain02").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain03 = ChateauSnapshotThree.Child("DBBonusArtworkObtain03").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain04 = ChateauSnapshotThree.Child("DBBonusArtworkObtain04").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain05 = ChateauSnapshotThree.Child("DBBonusArtworkObtain05").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain06 = ChateauSnapshotThree.Child("DBBonusArtworkObtain06").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain07 = ChateauSnapshotThree.Child("DBBonusArtworkObtain07").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain08 = ChateauSnapshotThree.Child("DBBonusArtworkObtain08").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain09 = ChateauSnapshotThree.Child("DBBonusArtworkObtain09").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain10 = ChateauSnapshotThree.Child("DBBonusArtworkObtain10").Value.ToString();
                }
            });
            
            FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostClicks").Child(FirebaseAuthentication.NewPlayer.UserId).GetValueAsync().ContinueWith(playertaskfour => {
                if (playertaskfour.IsCanceled || playertaskfour.IsFaulted) {
                    
                }
                
                else {
                    DataSnapshot ChateauSnapshotFour = playertaskfour.Result;

                    DataFillingInformation.DBGhostMonthlyClicksF1A = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF1A").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF1B = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF1B").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF1C = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF1C").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF1D = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF1D").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF1E = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF1E").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF2A = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF2A").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF2B = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF2B").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF2C = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF2C").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF2D = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF2D").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF2E = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF2E").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF3A = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF3A").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF3B = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF3B").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF3C = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF3C").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF3D = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF3D").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF3E = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF3E").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG1A = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG1A").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG1B = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG1B").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG1C = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG1C").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG1D = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG1D").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG1E = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG1E").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG2A = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG2A").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG2B = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG2B").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG2C = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG2C").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG2D = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG2D").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG2E = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG2E").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksFBA = ChateauSnapshotFour.Child("DBGhostMonthlyClicksFBA").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksFBB = ChateauSnapshotFour.Child("DBGhostMonthlyClicksFBB").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksFBC = ChateauSnapshotFour.Child("DBGhostMonthlyClicksFBC").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksFBD = ChateauSnapshotFour.Child("DBGhostMonthlyClicksFBD").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksFBE = ChateauSnapshotFour.Child("DBGhostMonthlyClicksFBE").Value.ToString();
                }
            });
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            FirebaseDatabase.DefaultInstance.GetReference("ChateauObjectives").Child(FirebaseAuthentication.CurrentPlayer.UserId).GetValueAsync().ContinueWith(playertask => {
                if (playertask.IsCanceled || playertask.IsFaulted) {
                    
                }
                
                else {
                    DataSnapshot ChateauSnapshot = playertask.Result;

                    // ALl-Time Objectives
                    DataFillingInformation.DBAllTimeObjectiveComplete01 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete01").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete02 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete02").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete03 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete03").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete04 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete04").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete05 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete05").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete06 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete06").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete07 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete07").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete08 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete08").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete09 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete09").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete10 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete10").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete11 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete11").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete12 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete12").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete13 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete13").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete14 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete14").Value.ToString();
                    DataFillingInformation.DBAllTimeObjectiveComplete15 = ChateauSnapshot.Child("DBAllTimeObjectiveComplete15").Value.ToString();
                    
                    // Event Objectives
                    DataFillingInformation.DBEventObjectiveComplete101 = ChateauSnapshot.Child("DBEventObjectiveComplete101").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete102 = ChateauSnapshot.Child("DBEventObjectiveComplete102").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete103 = ChateauSnapshot.Child("DBEventObjectiveComplete103").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete104 = ChateauSnapshot.Child("DBEventObjectiveComplete104").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete105 = ChateauSnapshot.Child("DBEventObjectiveComplete105").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete201 = ChateauSnapshot.Child("DBEventObjectiveComplete201").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete202 = ChateauSnapshot.Child("DBEventObjectiveComplete202").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete203 = ChateauSnapshot.Child("DBEventObjectiveComplete203").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete204 = ChateauSnapshot.Child("DBEventObjectiveComplete204").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete205 = ChateauSnapshot.Child("DBEventObjectiveComplete205").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete301 = ChateauSnapshot.Child("DBEventObjectiveComplete301").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete302 = ChateauSnapshot.Child("DBEventObjectiveComplete302").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete303 = ChateauSnapshot.Child("DBEventObjectiveComplete303").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete304 = ChateauSnapshot.Child("DBEventObjectiveComplete304").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete305 = ChateauSnapshot.Child("DBEventObjectiveComplete305").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete401 = ChateauSnapshot.Child("DBEventObjectiveComplete401").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete402 = ChateauSnapshot.Child("DBEventObjectiveComplete402").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete403 = ChateauSnapshot.Child("DBEventObjectiveComplete403").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete404 = ChateauSnapshot.Child("DBEventObjectiveComplete404").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete405 = ChateauSnapshot.Child("DBEventObjectiveComplete405").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete501 = ChateauSnapshot.Child("DBEventObjectiveComplete501").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete502 = ChateauSnapshot.Child("DBEventObjectiveComplete502").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete503 = ChateauSnapshot.Child("DBEventObjectiveComplete503").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete504 = ChateauSnapshot.Child("DBEventObjectiveComplete504").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete505 = ChateauSnapshot.Child("DBEventObjectiveComplete505").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete601 = ChateauSnapshot.Child("DBEventObjectiveComplete601").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete602 = ChateauSnapshot.Child("DBEventObjectiveComplete602").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete603 = ChateauSnapshot.Child("DBEventObjectiveComplete603").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete604 = ChateauSnapshot.Child("DBEventObjectiveComplete604").Value.ToString();
                    DataFillingInformation.DBEventObjectiveComplete605 = ChateauSnapshot.Child("DBEventObjectiveComplete605").Value.ToString();
                }
            });
            
            FirebaseDatabase.DefaultInstance.GetReference("ChateauPlayers").Child(FirebaseAuthentication.CurrentPlayer.UserId).GetValueAsync().ContinueWith(playertasktwo => {
                if (playertasktwo.IsCanceled || playertasktwo.IsFaulted) {
                    
                }
                
                else {
                    DataSnapshot ChateauSnapshotTwo = playertasktwo.Result;

                    DataFillingInformation.DBNumberOfArtworksCollected = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollected").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedF1 = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedF1").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedF2 = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedF2").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedF3 = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedF3").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedG1 = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedG1").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedG2 = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedG2").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedFB = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedFB").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedBaroque = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedBaroque").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedBunjinga = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedBunjinga").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedEdo = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedEdo").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedExpressionism = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedExpressionism").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedGoldenAge = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedGoldenAge").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedImpressionism = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedImpressionism").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedModernism = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedModernism").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedMuromachi = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedMuromachi").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedNeoclassicism = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedNeoclassicism").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedRealism = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedRealism").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedRenaissance = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedRenaissance").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedRomanticism = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedRomanticism").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedSongDynasty = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedSongDynasty").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedTangDynasty = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedTangDynasty").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedAmerican = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedAmerican").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedChinese = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedChinese").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedDutch = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedDutch").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedEnglish = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedEnglish").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedFrench = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedFrench").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedGerman = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedGerman").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedItalian = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedItalian").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedJapanese = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedJapanese").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedNorwegian = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedNorwegian").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedPolish = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedPolish").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedRussian = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedRussian").Value.ToString();
                    DataFillingInformation.DBNumberOfArtworksCollectedSpanish = ChateauSnapshotTwo.Child("DBNumberOfArtworksCollectedSpanish").Value.ToString();
                    DataFillingInformation.DBSecondFloorUnlock = ChateauSnapshotTwo.Child("DBSecondFloorUnlock").Value.ToString();
                    DataFillingInformation.DBThirdFloorUnlock = ChateauSnapshotTwo.Child("DBThirdFloorUnlock").Value.ToString();
                    DataFillingInformation.DBFirstGardenUnlock = ChateauSnapshotTwo.Child("DBFirstGardenUnlock").Value.ToString();
                    DataFillingInformation.DBSecondGardenUnlock = ChateauSnapshotTwo.Child("DBSecondGardenUnlock").Value.ToString();
                    DataFillingInformation.DBBasementUnlock = ChateauSnapshotTwo.Child("DBBasementUnlock").Value.ToString();
                }
            });
            
            FirebaseDatabase.DefaultInstance.GetReference("ChateauArtPurchase").Child(FirebaseAuthentication.CurrentPlayer.UserId).GetValueAsync().ContinueWith(playertaskthree => {
                if (playertaskthree.IsCanceled || playertaskthree.IsFaulted) {
                    
                }
                
                else {
                    DataSnapshot ChateauSnapshotThree = playertaskthree.Result;

                    DataFillingInformation.DBArtworkPurchaseF101 = ChateauSnapshotThree.Child("DBArtworkPurchaseF101").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF102 = ChateauSnapshotThree.Child("DBArtworkPurchaseF102").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF103 = ChateauSnapshotThree.Child("DBArtworkPurchaseF103").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF104 = ChateauSnapshotThree.Child("DBArtworkPurchaseF104").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF105 = ChateauSnapshotThree.Child("DBArtworkPurchaseF105").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF106 = ChateauSnapshotThree.Child("DBArtworkPurchaseF106").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF107 = ChateauSnapshotThree.Child("DBArtworkPurchaseF107").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF108 = ChateauSnapshotThree.Child("DBArtworkPurchaseF108").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF109 = ChateauSnapshotThree.Child("DBArtworkPurchaseF109").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF110 = ChateauSnapshotThree.Child("DBArtworkPurchaseF110").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF111 = ChateauSnapshotThree.Child("DBArtworkPurchaseF111").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF112 = ChateauSnapshotThree.Child("DBArtworkPurchaseF112").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF113 = ChateauSnapshotThree.Child("DBArtworkPurchaseF113").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF114 = ChateauSnapshotThree.Child("DBArtworkPurchaseF114").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF115 = ChateauSnapshotThree.Child("DBArtworkPurchaseF115").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF201 = ChateauSnapshotThree.Child("DBArtworkPurchaseF201").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF202 = ChateauSnapshotThree.Child("DBArtworkPurchaseF202").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF203 = ChateauSnapshotThree.Child("DBArtworkPurchaseF203").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF204 = ChateauSnapshotThree.Child("DBArtworkPurchaseF204").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF205 = ChateauSnapshotThree.Child("DBArtworkPurchaseF205").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF206 = ChateauSnapshotThree.Child("DBArtworkPurchaseF206").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF207 = ChateauSnapshotThree.Child("DBArtworkPurchaseF207").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF208 = ChateauSnapshotThree.Child("DBArtworkPurchaseF208").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF209 = ChateauSnapshotThree.Child("DBArtworkPurchaseF209").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF210 = ChateauSnapshotThree.Child("DBArtworkPurchaseF210").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF211 = ChateauSnapshotThree.Child("DBArtworkPurchaseF211").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF212 = ChateauSnapshotThree.Child("DBArtworkPurchaseF212").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF213 = ChateauSnapshotThree.Child("DBArtworkPurchaseF213").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF214 = ChateauSnapshotThree.Child("DBArtworkPurchaseF214").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF215 = ChateauSnapshotThree.Child("DBArtworkPurchaseF215").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF301 = ChateauSnapshotThree.Child("DBArtworkPurchaseF301").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF302 = ChateauSnapshotThree.Child("DBArtworkPurchaseF302").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF303 = ChateauSnapshotThree.Child("DBArtworkPurchaseF303").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF304 = ChateauSnapshotThree.Child("DBArtworkPurchaseF304").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF305 = ChateauSnapshotThree.Child("DBArtworkPurchaseF305").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF306 = ChateauSnapshotThree.Child("DBArtworkPurchaseF306").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF307 = ChateauSnapshotThree.Child("DBArtworkPurchaseF307").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF308 = ChateauSnapshotThree.Child("DBArtworkPurchaseF308").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF309 = ChateauSnapshotThree.Child("DBArtworkPurchaseF309").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF310 = ChateauSnapshotThree.Child("DBArtworkPurchaseF310").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF311 = ChateauSnapshotThree.Child("DBArtworkPurchaseF311").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF312 = ChateauSnapshotThree.Child("DBArtworkPurchaseF312").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF313 = ChateauSnapshotThree.Child("DBArtworkPurchaseF313").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF314 = ChateauSnapshotThree.Child("DBArtworkPurchaseF314").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseF315 = ChateauSnapshotThree.Child("DBArtworkPurchaseF315").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG101 = ChateauSnapshotThree.Child("DBArtworkPurchaseG101").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG102 = ChateauSnapshotThree.Child("DBArtworkPurchaseG102").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG103 = ChateauSnapshotThree.Child("DBArtworkPurchaseG103").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG104 = ChateauSnapshotThree.Child("DBArtworkPurchaseG104").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG105 = ChateauSnapshotThree.Child("DBArtworkPurchaseG105").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG106 = ChateauSnapshotThree.Child("DBArtworkPurchaseG106").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG107 = ChateauSnapshotThree.Child("DBArtworkPurchaseG107").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG108 = ChateauSnapshotThree.Child("DBArtworkPurchaseG108").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG109 = ChateauSnapshotThree.Child("DBArtworkPurchaseG109").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG110 = ChateauSnapshotThree.Child("DBArtworkPurchaseG110").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG111 = ChateauSnapshotThree.Child("DBArtworkPurchaseG111").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG112 = ChateauSnapshotThree.Child("DBArtworkPurchaseG112").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG113 = ChateauSnapshotThree.Child("DBArtworkPurchaseG113").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG114 = ChateauSnapshotThree.Child("DBArtworkPurchaseG114").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG115 = ChateauSnapshotThree.Child("DBArtworkPurchaseG115").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG201 = ChateauSnapshotThree.Child("DBArtworkPurchaseG201").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG202 = ChateauSnapshotThree.Child("DBArtworkPurchaseG202").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG203 = ChateauSnapshotThree.Child("DBArtworkPurchaseG203").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG204 = ChateauSnapshotThree.Child("DBArtworkPurchaseG204").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG205 = ChateauSnapshotThree.Child("DBArtworkPurchaseG205").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG206 = ChateauSnapshotThree.Child("DBArtworkPurchaseG206").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG207 = ChateauSnapshotThree.Child("DBArtworkPurchaseG207").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG208 = ChateauSnapshotThree.Child("DBArtworkPurchaseG208").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG209 = ChateauSnapshotThree.Child("DBArtworkPurchaseG209").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG210 = ChateauSnapshotThree.Child("DBArtworkPurchaseG210").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG211 = ChateauSnapshotThree.Child("DBArtworkPurchaseG211").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG212 = ChateauSnapshotThree.Child("DBArtworkPurchaseG212").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG213 = ChateauSnapshotThree.Child("DBArtworkPurchaseG213").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG214 = ChateauSnapshotThree.Child("DBArtworkPurchaseG214").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseG215 = ChateauSnapshotThree.Child("DBArtworkPurchaseG215").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB01 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB01").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB02 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB02").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB03 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB03").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB04 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB04").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB05 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB05").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB06 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB06").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB07 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB07").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB08 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB08").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB09 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB09").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB10 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB10").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB11 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB11").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB12 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB12").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB13 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB13").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB14 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB14").Value.ToString();
                    DataFillingInformation.DBArtworkPurchaseFB15 = ChateauSnapshotThree.Child("DBArtworkPurchaseFB15").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain01 = ChateauSnapshotThree.Child("DBBonusArtworkObtain01").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain02 = ChateauSnapshotThree.Child("DBBonusArtworkObtain02").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain03 = ChateauSnapshotThree.Child("DBBonusArtworkObtain03").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain04 = ChateauSnapshotThree.Child("DBBonusArtworkObtain04").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain05 = ChateauSnapshotThree.Child("DBBonusArtworkObtain05").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain06 = ChateauSnapshotThree.Child("DBBonusArtworkObtain06").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain07 = ChateauSnapshotThree.Child("DBBonusArtworkObtain07").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain08 = ChateauSnapshotThree.Child("DBBonusArtworkObtain08").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain09 = ChateauSnapshotThree.Child("DBBonusArtworkObtain09").Value.ToString();
                    DataFillingInformation.DBBonusArtworkObtain10 = ChateauSnapshotThree.Child("DBBonusArtworkObtain10").Value.ToString();
                }
            });
            
            FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostClicks").Child(FirebaseAuthentication.CurrentPlayer.UserId).GetValueAsync().ContinueWith(playertaskfour => {
                if (playertaskfour.IsCanceled || playertaskfour.IsFaulted) {
                    
                }
                
                else {
                    DataSnapshot ChateauSnapshotFour = playertaskfour.Result;

                    DataFillingInformation.DBGhostMonthlyClicksF1A = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF1A").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF1B = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF1B").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF1C = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF1C").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF1D = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF1D").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF1E = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF1E").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF2A = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF2A").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF2B = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF2B").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF2C = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF2C").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF2D = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF2D").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF2E = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF2E").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF3A = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF3A").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF3B = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF3B").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF3C = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF3C").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF3D = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF3D").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksF3E = ChateauSnapshotFour.Child("DBGhostMonthlyClicksF3E").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG1A = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG1A").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG1B = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG1B").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG1C = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG1C").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG1D = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG1D").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG1E = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG1E").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG2A = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG2A").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG2B = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG2B").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG2C = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG2C").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG2D = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG2D").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksG2E = ChateauSnapshotFour.Child("DBGhostMonthlyClicksG2E").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksFBA = ChateauSnapshotFour.Child("DBGhostMonthlyClicksFBA").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksFBB = ChateauSnapshotFour.Child("DBGhostMonthlyClicksFBB").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksFBC = ChateauSnapshotFour.Child("DBGhostMonthlyClicksFBC").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksFBD = ChateauSnapshotFour.Child("DBGhostMonthlyClicksFBD").Value.ToString();
                    DataFillingInformation.DBGhostMonthlyClicksFBE = ChateauSnapshotFour.Child("DBGhostMonthlyClicksFBE").Value.ToString();
                }
            });
        }
        
        CurrentEventObjectiveDate = MonthlyObjectiveItemsSceneEnable.CurrentEventObjectiveNumber;
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		// All-Time Objectives
        ObjectiveAlertsNotificationAllTime01();
        ObjectiveAlertsNotificationAllTime02();
        ObjectiveAlertsNotificationAllTime03();
        ObjectiveAlertsNotificationAllTime04();
        ObjectiveAlertsNotificationAllTime05();
        ObjectiveAlertsNotificationAllTime06();
        ObjectiveAlertsNotificationAllTime07();
        ObjectiveAlertsNotificationAllTime08();
        ObjectiveAlertsNotificationAllTime09();
        ObjectiveAlertsNotificationAllTime10();
        ObjectiveAlertsNotificationAllTime11();
        ObjectiveAlertsNotificationAllTime12();
        ObjectiveAlertsNotificationAllTime13();
        ObjectiveAlertsNotificationAllTime14();
        ObjectiveAlertsNotificationAllTime15();
        
        // Event Objectives
        if ((int.Parse(CurrentEventObjectiveDate) == 1) || (int.Parse(CurrentEventObjectiveDate) == 2)) {
            ObjectiveAlertsNotificationEvent101();
            ObjectiveAlertsNotificationEvent102();
            ObjectiveAlertsNotificationEvent103();
            ObjectiveAlertsNotificationEvent104();
            ObjectiveAlertsNotificationEvent105();
        }
        
        if ((int.Parse(CurrentEventObjectiveDate) == 3) || (int.Parse(CurrentEventObjectiveDate) == 4)) {
            ObjectiveAlertsNotificationEvent201();
            ObjectiveAlertsNotificationEvent202();
            ObjectiveAlertsNotificationEvent203();
            ObjectiveAlertsNotificationEvent204();
            ObjectiveAlertsNotificationEvent205();
        }
        
        if ((int.Parse(CurrentEventObjectiveDate) == 5) || (int.Parse(CurrentEventObjectiveDate) == 6)) {
            ObjectiveAlertsNotificationEvent301();
            ObjectiveAlertsNotificationEvent302();
            ObjectiveAlertsNotificationEvent303();
            ObjectiveAlertsNotificationEvent304();
            ObjectiveAlertsNotificationEvent305();
        }
        
        if ((int.Parse(CurrentEventObjectiveDate) == 7) || (int.Parse(CurrentEventObjectiveDate) == 8)) {
            ObjectiveAlertsNotificationEvent401();
            ObjectiveAlertsNotificationEvent402();
            ObjectiveAlertsNotificationEvent403();
            ObjectiveAlertsNotificationEvent404();
            ObjectiveAlertsNotificationEvent405();
        }
        
        if ((int.Parse(CurrentEventObjectiveDate) == 9) || (int.Parse(CurrentEventObjectiveDate) == 10)) {
            ObjectiveAlertsNotificationEvent501();
            ObjectiveAlertsNotificationEvent502();
            ObjectiveAlertsNotificationEvent503();
            ObjectiveAlertsNotificationEvent504();
            ObjectiveAlertsNotificationEvent505();
        }
        
        if ((int.Parse(CurrentEventObjectiveDate) == 11) || (int.Parse(CurrentEventObjectiveDate) == 12)) {
            ObjectiveAlertsNotificationEvent601();
            ObjectiveAlertsNotificationEvent602();
            ObjectiveAlertsNotificationEvent603();
            ObjectiveAlertsNotificationEvent604();
            ObjectiveAlertsNotificationEvent605();
        }
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
    public void ObjectiveAlertsAllEnable() {
        UIObjectiveAlertsPanel.enabled = true;
        UIObjectiveAlertsText.enabled = true;
    }
    
// --------------- DISABLE FUNCTIONS ---------------
    public void ObjectiveAlertsAllDisable() {
        UIObjectiveAlertsPanel.enabled = false;
        UIObjectiveAlertsText.enabled = false;
    }
    
// --------------- NOTIFICATION FUNCTIONS ---------------
    // All-Time Objectives
    public void ObjectiveAlertsNotificationAllTime01() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete01) == 1) {
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollected) >= 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.AllTimeObjectiveTitle01;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete01) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete01) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationAllTime02() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete02) == 1) {
            if ((int.Parse(DataFillingInformation.DBArtworkPurchaseF105) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF310) == 1)) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.AllTimeObjectiveTitle02;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete02) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete02) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationAllTime03() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete03) == 1) {
            if ((int.Parse(DataFillingInformation.DBArtworkPurchaseF312) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF314) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseFB13) == 1)) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.AllTimeObjectiveTitle03;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete03) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete03) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationAllTime04() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete04) == 1) {
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedBaroque) >= 7) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.AllTimeObjectiveTitle04;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete04) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete04) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationAllTime05() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete05) == 1) {
            if (((int.Parse(DataFillingInformation.DBEventObjectiveComplete101) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete102) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete103) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete104) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete105) == 1)) || ((int.Parse(DataFillingInformation.DBEventObjectiveComplete201) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete202) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete203) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete204) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete205) == 1)) || ((int.Parse(DataFillingInformation.DBEventObjectiveComplete301) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete302) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete303) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete304) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete305) == 1)) || ((int.Parse(DataFillingInformation.DBEventObjectiveComplete401) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete402) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete403) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete404) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete405) == 1)) || ((int.Parse(DataFillingInformation.DBEventObjectiveComplete501) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete502) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete503) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete504) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete505) == 1)) || ((int.Parse(DataFillingInformation.DBEventObjectiveComplete601) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete602) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete603) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete604) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete605) == 1))) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.AllTimeObjectiveTitle05;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete05) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete05) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationAllTime06() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete06) == 1) {
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedRenaissance) >= 6) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.AllTimeObjectiveTitle06;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete06) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete06) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationAllTime07() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete07) == 1) {
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedGoldenAge) >= 7) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.AllTimeObjectiveTitle07;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete07) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete07) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationAllTime08() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete08) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseF305) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.AllTimeObjectiveTitle08;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete08) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete08) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationAllTime09() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete09) == 1) {
            if (int.Parse(DataFillingInformation.DBNumberOfArtworksCollectedItalian) >= 10) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.AllTimeObjectiveTitle09;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete09) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete09) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationAllTime10() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete10) == 1) {
            if ((int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 1) && (int.Parse(DataFillingInformation.DBSecondGardenUnlock) == 1)) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.AllTimeObjectiveTitle10;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete10) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete10) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationAllTime11() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete11) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB15) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.AllTimeObjectiveTitle11;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete11) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete11) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationAllTime12() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete12) == 1) {
            if ((int.Parse(DataFillingInformation.DBArtworkPurchaseF205) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF309) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseFB07) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseFB11) == 1)) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.AllTimeObjectiveTitle12;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete12) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete12) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationAllTime13() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete13) == 1) {
            if ((int.Parse(DataFillingInformation.DBArtworkPurchaseFB10) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF109) == 1)) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.AllTimeObjectiveTitle13;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete13) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete13) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationAllTime14() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete14) == 1) {
            if (((int.Parse(DataFillingInformation.DBEventObjectiveComplete201) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete202) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete203) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete204) == 1) && (int.Parse(DataFillingInformation.DBEventObjectiveComplete205) == 1))) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.AllTimeObjectiveTitle14;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete14) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete14) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationAllTime15() {
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete15) == 1) {
            if ((int.Parse(DataFillingInformation.DBArtworkPurchaseF106) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF108) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF110) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF201) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF204) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseG111) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF211) == 1)) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.AllTimeObjectiveTitle15;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete15) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete15) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    // Event Objectives
    public void ObjectiveAlertsNotificationEvent101() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete101) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseG109) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle011;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete101) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete101) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent102() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete102) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseF303) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle012;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete102) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete102) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent103() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete103) == 1) {
            if ((int.Parse(DataFillingInformation.DBArtworkPurchaseF201) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF204) == 1)) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle013;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete103) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete103) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent104() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete104) == 1) {
            if ((int.Parse(DataFillingInformation.DBArtworkPurchaseF311) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseFB13) == 1)) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle014;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete104) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete104) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent105() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete105) == 1) {
            if (EventObjectives.IfGroundhogDay == "02/02") {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle015;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete105) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete105) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent201() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete201) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseF104) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle021;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete201) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete201) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent202() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete202) == 1) {
            if (int.Parse(DataFillingInformation.DBFirstGardenUnlock) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle022;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete202) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete202) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent203() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete203) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseF309) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle023;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete203) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete203) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent204() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete204) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseF315) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle024;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete204) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete204) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent205() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete205) == 1) {
            if ((int.Parse(DataFillingInformation.DBArtworkPurchaseG110) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF205) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF303) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF305) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF309) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseFB05) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseFB07) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseFB11) == 1)) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle025;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete205) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete205) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent301() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete301) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB09) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle031;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete301) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete301) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent302() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete302) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseF206) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle032;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete302) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete302) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent303() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete303) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseG104) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle033;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete303) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete303) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent304() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete304) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseF313) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle034;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete304) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete304) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent305() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete305) == 1) {
            if ((int.Parse(DataFillingInformation.DBArtworkPurchaseF104) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF206) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseF313) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseG106) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseG213) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseFB03) == 1)) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle035;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete305) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete305) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent401() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete401) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseF105) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle041;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete401) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete401) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent402() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete402) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseG210) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle042;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete402) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete402) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent403() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete403) == 1) {
            if ((int.Parse(DataFillingInformation.DBArtworkPurchaseG113) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseG203) == 1)) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle043;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete403) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete403) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent404() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete404) == 1) {
            if (int.Parse(DataFillingInformation.DBGhostMonthlyClicksFBC) >= 325) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle044;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete404) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete404) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent405() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete405) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB07) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle045;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete405) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete405) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent501() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete501) == 1) {
            if (int.Parse(DataFillingInformation.DBGhostMonthlyClicksF3E) >= 175) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle051;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete501) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete501) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent502() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete502) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseF213) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle052;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete502) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete502) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent503() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete503) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseF115) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle053;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete503) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete503) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent504() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete504) == 1) {
            if (int.Parse(DataFillingInformation.DBGhostMonthlyClicksFBD) >= 300) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle054;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete504) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete504) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent505() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete505) == 1) {
            if ((int.Parse(DataFillingInformation.DBArtworkPurchaseF214) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseFB09) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseFB14) == 1)) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle055;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete505) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete505) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent601() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete601) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseG110) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle061;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete601) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete601) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent602() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete602) == 1) {
            if (int.Parse(DataFillingInformation.DBGhostMonthlyClicksF1E) >= 250) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle062;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete602) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete602) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent603() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete603) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseG214) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle063;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete603) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete603) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent604() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete604) == 1) {
            if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB14) == 1) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle064;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete604) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete604) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
    
    public void ObjectiveAlertsNotificationEvent605() {
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete605) == 1) {
            if ((int.Parse(DataFillingInformation.DBArtworkPurchaseF107) == 1) && (int.Parse(DataFillingInformation.DBArtworkPurchaseG210) == 1)) {
                ObjectiveAlertsAllEnable();
                UIObjectiveAlertsText.text = "Congratulations!" + "\n" + "Click here to claim your prize for completing the objective, " + ObjectiveInformation.EventObjectiveTitle065;
            }
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete605) == 0) {
            ObjectiveAlertsAllDisable();
        }
        
        if (int.Parse(DataFillingInformation.DBEventObjectiveComplete605) == 2) {
            ObjectiveAlertsAllDisable();
        }
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}