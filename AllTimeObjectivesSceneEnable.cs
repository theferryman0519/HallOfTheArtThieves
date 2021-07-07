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

public class AllTimeObjectivesSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image UIAllTimeObjectivesBackground;
    public Text UIAllTimeObjectivesTitle;
    public Text UIAllTimeObjectivesBackButton;
    public Text UIAllTimeObjectivesCloseButton;
    
    public Image UIAllTimeObjectivesItems01;
    public Text UIAllTimeObjectivesItems01Text;
    public Image UIAllTimeObjectivesItem01Check;
    public Image UIAllTimeObjectivesItems02;
    public Text UIAllTimeObjectivesItems02Text;
    public Image UIAllTimeObjectivesItem02Check;
    public Image UIAllTimeObjectivesItems03;
    public Text UIAllTimeObjectivesItems03Text;
    public Image UIAllTimeObjectivesItem03Check;
    public Image UIAllTimeObjectivesItems04;
    public Text UIAllTimeObjectivesItems04Text;
    public Image UIAllTimeObjectivesItem04Check;
    public Image UIAllTimeObjectivesItems05;
    public Text UIAllTimeObjectivesItems05Text;
    public Image UIAllTimeObjectivesItem05Check;
    public Image UIAllTimeObjectivesItems06;
    public Text UIAllTimeObjectivesItems06Text;
    public Image UIAllTimeObjectivesItem06Check;
    public Image UIAllTimeObjectivesItems07;
    public Text UIAllTimeObjectivesItems07Text;
    public Image UIAllTimeObjectivesItem07Check;
    public Image UIAllTimeObjectivesItems08;
    public Text UIAllTimeObjectivesItems08Text;
    public Image UIAllTimeObjectivesItem08Check;
    public Image UIAllTimeObjectivesItems09;
    public Text UIAllTimeObjectivesItems09Text;
    public Image UIAllTimeObjectivesItem09Check;
    public Image UIAllTimeObjectivesItems10;
    public Text UIAllTimeObjectivesItems10Text;
    public Image UIAllTimeObjectivesItem10Check;
    public Image UIAllTimeObjectivesItems11;
    public Text UIAllTimeObjectivesItems11Text;
    public Image UIAllTimeObjectivesItem11Check;
    public Image UIAllTimeObjectivesItems12;
    public Text UIAllTimeObjectivesItems12Text;
    public Image UIAllTimeObjectivesItem12Check;
    public Image UIAllTimeObjectivesItems13;
    public Text UIAllTimeObjectivesItems13Text;
    public Image UIAllTimeObjectivesItem13Check;
    public Image UIAllTimeObjectivesItems14;
    public Text UIAllTimeObjectivesItems14Text;
    public Image UIAllTimeObjectivesItem14Check;
    public Image UIAllTimeObjectivesItems15;
    public Text UIAllTimeObjectivesItems15Text;
    public Image UIAllTimeObjectivesItem15Check;
    
    public Image UIAllTimeObjectivesItemsField;
    public Text UIAllTimeObjectivesItemsFieldTitle;
    public Text UIAllTimeObjectivesItemsFieldText;
    public Text UIAllTimeObjectivesItemsFieldPrize;
    public Text UIAllTimeObjectivesItemsFieldTracking;
    public Text UIAllTimeObjectivesItemsFieldBackButton;
    
    public Text UIAllTimeObjectivesItemsFieldCompleteText;
    public Text UIAllTimeObjectivesItemsFieldProgressText;
    public Text UIAllTimeObjectivesItemsFieldClaimPrizeText;
	
// --------------- PRIVATE VARIABLES ---------------
	private Color AllTimeObjectiveColorOff;
    private Color AllTimeObjectiveColorOn;
    private Color AllTimeObjectiveColorCollect;
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		AllTimeObjectiveItemsAllDisable();
        
        AllTimeObjectiveColorOff = new Color(0.15f, 0.36f, 0.45f, 1.0f);
        AllTimeObjectiveColorOn = new Color(0.01f, 0.78f, 0.0f, 1.0f);
        AllTimeObjectiveColorCollect = new Color(0.01f, 0.73f, 0.91f, 1.0f);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
        // All-Time 01
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete01) == 0) {
            UIAllTimeObjectivesItems01.color = AllTimeObjectiveColorOff;
            AllTimeObjectiveItemsFieldCheck01Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete01) == 1) {
            UIAllTimeObjectivesItems01.color = AllTimeObjectiveColorCollect;
            AllTimeObjectiveItemsFieldCheck01Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete01) == 2) {
            UIAllTimeObjectivesItems01.color = AllTimeObjectiveColorOn;
            if (UIAllTimeObjectivesItemsField.enabled == false) {
                AllTimeObjectiveItemsFieldCheck01Enable();
            }
        }
        
        // All-Time 02
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete02) == 0) {
            UIAllTimeObjectivesItems02.color = AllTimeObjectiveColorOff;
            AllTimeObjectiveItemsFieldCheck02Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete02) == 1) {
            UIAllTimeObjectivesItems02.color = AllTimeObjectiveColorCollect;
            AllTimeObjectiveItemsFieldCheck02Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete02) == 2) {
            UIAllTimeObjectivesItems02.color = AllTimeObjectiveColorOn;
            if (UIAllTimeObjectivesItemsField.enabled == false) {
                AllTimeObjectiveItemsFieldCheck02Enable();
            }
        }
        
        // All-Time 03
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete03) == 0) {
            UIAllTimeObjectivesItems03.color = AllTimeObjectiveColorOff;
            AllTimeObjectiveItemsFieldCheck03Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete03) == 1) {
            UIAllTimeObjectivesItems03.color = AllTimeObjectiveColorCollect;
            AllTimeObjectiveItemsFieldCheck03Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete03) == 2) {
            UIAllTimeObjectivesItems03.color = AllTimeObjectiveColorOn;
            if (UIAllTimeObjectivesItemsField.enabled == false) {
                AllTimeObjectiveItemsFieldCheck03Enable();
            }
        }
        
        // All-Time 04
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete04) == 0) {
            UIAllTimeObjectivesItems04.color = AllTimeObjectiveColorOff;
            AllTimeObjectiveItemsFieldCheck04Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete04) == 1) {
            UIAllTimeObjectivesItems04.color = AllTimeObjectiveColorCollect;
            AllTimeObjectiveItemsFieldCheck04Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete04) == 2) {
            UIAllTimeObjectivesItems04.color = AllTimeObjectiveColorOn;
            if (UIAllTimeObjectivesItemsField.enabled == false) {
                AllTimeObjectiveItemsFieldCheck04Enable();
            }
        }
        
        // All-Time 05
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete05) == 0) {
            UIAllTimeObjectivesItems05.color = AllTimeObjectiveColorOff;
            AllTimeObjectiveItemsFieldCheck05Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete05) == 1) {
            UIAllTimeObjectivesItems05.color = AllTimeObjectiveColorCollect;
            AllTimeObjectiveItemsFieldCheck05Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete05) == 2) {
            UIAllTimeObjectivesItems05.color = AllTimeObjectiveColorOn;
            if (UIAllTimeObjectivesItemsField.enabled == false) {
                AllTimeObjectiveItemsFieldCheck05Enable();
            }
        }
        
        // All-Time 06
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete06) == 0) {
            UIAllTimeObjectivesItems06.color = AllTimeObjectiveColorOff;
            AllTimeObjectiveItemsFieldCheck06Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete06) == 1) {
            UIAllTimeObjectivesItems06.color = AllTimeObjectiveColorCollect;
            AllTimeObjectiveItemsFieldCheck06Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete06) == 2) {
            UIAllTimeObjectivesItems06.color = AllTimeObjectiveColorOn;
            if (UIAllTimeObjectivesItemsField.enabled == false) {
                AllTimeObjectiveItemsFieldCheck06Enable();
            }
        }
        
        // All-Time 07
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete07) == 0) {
            UIAllTimeObjectivesItems07.color = AllTimeObjectiveColorOff;
            AllTimeObjectiveItemsFieldCheck07Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete07) == 1) {
            UIAllTimeObjectivesItems07.color = AllTimeObjectiveColorCollect;
            AllTimeObjectiveItemsFieldCheck07Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete07) == 2) {
            UIAllTimeObjectivesItems07.color = AllTimeObjectiveColorOn;
            if (UIAllTimeObjectivesItemsField.enabled == false) {
                AllTimeObjectiveItemsFieldCheck07Enable();
            }
        }
        
        // All-Time 08
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete08) == 0) {
            UIAllTimeObjectivesItems08.color = AllTimeObjectiveColorOff;
            AllTimeObjectiveItemsFieldCheck08Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete08) == 1) {
            UIAllTimeObjectivesItems08.color = AllTimeObjectiveColorCollect;
            AllTimeObjectiveItemsFieldCheck08Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete08) == 2) {
            UIAllTimeObjectivesItems08.color = AllTimeObjectiveColorOn;
            if (UIAllTimeObjectivesItemsField.enabled == false) {
                AllTimeObjectiveItemsFieldCheck08Enable();
            }
        }
        
        // All-Time 09
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete09) == 0) {
            UIAllTimeObjectivesItems09.color = AllTimeObjectiveColorOff;
            AllTimeObjectiveItemsFieldCheck09Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete09) == 1) {
            UIAllTimeObjectivesItems09.color = AllTimeObjectiveColorCollect;
            AllTimeObjectiveItemsFieldCheck09Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete09) == 2) {
            UIAllTimeObjectivesItems09.color = AllTimeObjectiveColorOn;
            if (UIAllTimeObjectivesItemsField.enabled == false) {
                AllTimeObjectiveItemsFieldCheck09Enable();
            }
        }
        
        // All-Time 10
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete10) == 0) {
            UIAllTimeObjectivesItems10.color = AllTimeObjectiveColorOff;
            AllTimeObjectiveItemsFieldCheck10Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete10) == 1) {
            UIAllTimeObjectivesItems10.color = AllTimeObjectiveColorCollect;
            AllTimeObjectiveItemsFieldCheck10Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete10) == 2) {
            UIAllTimeObjectivesItems10.color = AllTimeObjectiveColorOn;
            if (UIAllTimeObjectivesItemsField.enabled == false) {
                AllTimeObjectiveItemsFieldCheck10Enable();
            }
        }
        
        // All-Time 11
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete11) == 0) {
            UIAllTimeObjectivesItems11.color = AllTimeObjectiveColorOff;
            AllTimeObjectiveItemsFieldCheck11Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete11) == 1) {
            UIAllTimeObjectivesItems11.color = AllTimeObjectiveColorCollect;
            AllTimeObjectiveItemsFieldCheck11Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete11) == 2) {
            UIAllTimeObjectivesItems11.color = AllTimeObjectiveColorOn;
            if (UIAllTimeObjectivesItemsField.enabled == false) {
                AllTimeObjectiveItemsFieldCheck11Enable();
            }
        }
        
        // All-Time 12
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete12) == 0) {
            UIAllTimeObjectivesItems12.color = AllTimeObjectiveColorOff;
            AllTimeObjectiveItemsFieldCheck12Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete12) == 1) {
            UIAllTimeObjectivesItems12.color = AllTimeObjectiveColorCollect;
            AllTimeObjectiveItemsFieldCheck12Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete12) == 2) {
            UIAllTimeObjectivesItems12.color = AllTimeObjectiveColorOn;
            if (UIAllTimeObjectivesItemsField.enabled == false) {
                AllTimeObjectiveItemsFieldCheck12Enable();
            }
        }
        
        // All-Time 13
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete13) == 0) {
            UIAllTimeObjectivesItems13.color = AllTimeObjectiveColorOff;
            AllTimeObjectiveItemsFieldCheck13Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete13) == 1) {
            UIAllTimeObjectivesItems13.color = AllTimeObjectiveColorCollect;
            AllTimeObjectiveItemsFieldCheck13Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete13) == 2) {
            UIAllTimeObjectivesItems13.color = AllTimeObjectiveColorOn;
            if (UIAllTimeObjectivesItemsField.enabled == false) {
                AllTimeObjectiveItemsFieldCheck13Enable();
            }
        }
        
        // All-Time 14
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete14) == 0) {
            UIAllTimeObjectivesItems14.color = AllTimeObjectiveColorOff;
            AllTimeObjectiveItemsFieldCheck14Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete14) == 1) {
            UIAllTimeObjectivesItems14.color = AllTimeObjectiveColorCollect;
            AllTimeObjectiveItemsFieldCheck14Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete14) == 2) {
            UIAllTimeObjectivesItems14.color = AllTimeObjectiveColorOn;
            if (UIAllTimeObjectivesItemsField.enabled == false) {
                AllTimeObjectiveItemsFieldCheck14Enable();
            }
        }
        
        // All-Time 15
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete15) == 0) {
            UIAllTimeObjectivesItems15.color = AllTimeObjectiveColorOff;
            AllTimeObjectiveItemsFieldCheck15Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete15) == 1) {
            UIAllTimeObjectivesItems15.color = AllTimeObjectiveColorCollect;
            AllTimeObjectiveItemsFieldCheck15Disable();
        }
        
        if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete15) == 2) {
            UIAllTimeObjectivesItems15.color = AllTimeObjectiveColorOn;
            if (UIAllTimeObjectivesItemsField.enabled == false) {
                AllTimeObjectiveItemsFieldCheck15Enable();
            }
        }
                
		UIAllTimeObjectivesItems01Text.text = ObjectiveInformation.AllTimeObjectiveTitle01;
        UIAllTimeObjectivesItems02Text.text = ObjectiveInformation.AllTimeObjectiveTitle02;
        UIAllTimeObjectivesItems03Text.text = ObjectiveInformation.AllTimeObjectiveTitle03;
        UIAllTimeObjectivesItems04Text.text = ObjectiveInformation.AllTimeObjectiveTitle04;
        UIAllTimeObjectivesItems05Text.text = ObjectiveInformation.AllTimeObjectiveTitle05;
        UIAllTimeObjectivesItems06Text.text = ObjectiveInformation.AllTimeObjectiveTitle06;
        UIAllTimeObjectivesItems07Text.text = ObjectiveInformation.AllTimeObjectiveTitle07;
        UIAllTimeObjectivesItems08Text.text = ObjectiveInformation.AllTimeObjectiveTitle08;
        UIAllTimeObjectivesItems09Text.text = ObjectiveInformation.AllTimeObjectiveTitle09;
        UIAllTimeObjectivesItems10Text.text = ObjectiveInformation.AllTimeObjectiveTitle10;
        UIAllTimeObjectivesItems11Text.text = ObjectiveInformation.AllTimeObjectiveTitle11;
        UIAllTimeObjectivesItems12Text.text = ObjectiveInformation.AllTimeObjectiveTitle12;
        UIAllTimeObjectivesItems13Text.text = ObjectiveInformation.AllTimeObjectiveTitle13;
        UIAllTimeObjectivesItems14Text.text = ObjectiveInformation.AllTimeObjectiveTitle14;
        UIAllTimeObjectivesItems15Text.text = ObjectiveInformation.AllTimeObjectiveTitle15;
        
        if ((AllTimeObjectivesSceneButtons.AllTimeObjectiveNumber == 01) && (UIAllTimeObjectivesBackground.enabled == true)) {
            UIAllTimeObjectivesItemsFieldTitle.text = ObjectiveInformation.AllTimeObjectiveTitle01;
            UIAllTimeObjectivesItemsFieldText.text = ObjectiveInformation.AllTimeObjectiveTask01;
            UIAllTimeObjectivesItemsFieldPrize.text = ObjectiveInformation.AllTimeObjectivePrize01;
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete01) == 0) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressEnable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete01) == 1) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeEnable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete01) == 2) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteEnable();
                }
            }
        }
        
        if ((AllTimeObjectivesSceneButtons.AllTimeObjectiveNumber == 02) && (UIAllTimeObjectivesBackground.enabled == true)) {
            UIAllTimeObjectivesItemsFieldTitle.text = ObjectiveInformation.AllTimeObjectiveTitle02;
            UIAllTimeObjectivesItemsFieldText.text = ObjectiveInformation.AllTimeObjectiveTask02;
            UIAllTimeObjectivesItemsFieldPrize.text = ObjectiveInformation.AllTimeObjectivePrize02;
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete02) == 0) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressEnable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete02) == 1) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeEnable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete02) == 2) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteEnable();
                }
            }
        }
        
        if ((AllTimeObjectivesSceneButtons.AllTimeObjectiveNumber == 03) && (UIAllTimeObjectivesBackground.enabled == true)) {
            UIAllTimeObjectivesItemsFieldTitle.text = ObjectiveInformation.AllTimeObjectiveTitle03;
            UIAllTimeObjectivesItemsFieldText.text = ObjectiveInformation.AllTimeObjectiveTask03;
            UIAllTimeObjectivesItemsFieldPrize.text = ObjectiveInformation.AllTimeObjectivePrize03;
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete03) == 0) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressEnable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete03) == 1) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeEnable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete03) == 2) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteEnable();
                }
            }
        }
        
        if ((AllTimeObjectivesSceneButtons.AllTimeObjectiveNumber == 04) && (UIAllTimeObjectivesBackground.enabled == true)) {
            UIAllTimeObjectivesItemsFieldTitle.text = ObjectiveInformation.AllTimeObjectiveTitle04;
            UIAllTimeObjectivesItemsFieldText.text = ObjectiveInformation.AllTimeObjectiveTask04;
            UIAllTimeObjectivesItemsFieldPrize.text = ObjectiveInformation.AllTimeObjectivePrize04;
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete04) == 0) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressEnable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete04) == 1) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeEnable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete04) == 2) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteEnable();
                }
            }
        }
        
        if ((AllTimeObjectivesSceneButtons.AllTimeObjectiveNumber == 05) && (UIAllTimeObjectivesBackground.enabled == true)) {
            UIAllTimeObjectivesItemsFieldTitle.text = ObjectiveInformation.AllTimeObjectiveTitle05;
            UIAllTimeObjectivesItemsFieldText.text = ObjectiveInformation.AllTimeObjectiveTask05;
            UIAllTimeObjectivesItemsFieldPrize.text = ObjectiveInformation.AllTimeObjectivePrize05;
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete05) == 0) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressEnable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete05) == 1) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeEnable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete05) == 2) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteEnable();
                }
            }
        }
        
        if ((AllTimeObjectivesSceneButtons.AllTimeObjectiveNumber == 06) && (UIAllTimeObjectivesBackground.enabled == true)) {
            UIAllTimeObjectivesItemsFieldTitle.text = ObjectiveInformation.AllTimeObjectiveTitle06;
            UIAllTimeObjectivesItemsFieldText.text = ObjectiveInformation.AllTimeObjectiveTask06;
            UIAllTimeObjectivesItemsFieldPrize.text = ObjectiveInformation.AllTimeObjectivePrize06;
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete06) == 0) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressEnable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete06) == 1) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeEnable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete06) == 2) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteEnable();
                }
            }
        }
        
        if ((AllTimeObjectivesSceneButtons.AllTimeObjectiveNumber == 07) && (UIAllTimeObjectivesBackground.enabled == true)) {
            UIAllTimeObjectivesItemsFieldTitle.text = ObjectiveInformation.AllTimeObjectiveTitle07;
            UIAllTimeObjectivesItemsFieldText.text = ObjectiveInformation.AllTimeObjectiveTask07;
            UIAllTimeObjectivesItemsFieldPrize.text = ObjectiveInformation.AllTimeObjectivePrize07;
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete07) == 0) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressEnable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete07) == 1) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeEnable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete07) == 2) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteEnable();
                }
            }
        }
        
        if ((AllTimeObjectivesSceneButtons.AllTimeObjectiveNumber == 08) && (UIAllTimeObjectivesBackground.enabled == true)) {
            UIAllTimeObjectivesItemsFieldTitle.text = ObjectiveInformation.AllTimeObjectiveTitle08;
            UIAllTimeObjectivesItemsFieldText.text = ObjectiveInformation.AllTimeObjectiveTask08;
            UIAllTimeObjectivesItemsFieldPrize.text = ObjectiveInformation.AllTimeObjectivePrize08;
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete08) == 0) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressEnable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete08) == 1) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeEnable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete08) == 2) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteEnable();
                }
            }
        }
        
        if ((AllTimeObjectivesSceneButtons.AllTimeObjectiveNumber == 09) && (UIAllTimeObjectivesBackground.enabled == true)) {
            UIAllTimeObjectivesItemsFieldTitle.text = ObjectiveInformation.AllTimeObjectiveTitle09;
            UIAllTimeObjectivesItemsFieldText.text = ObjectiveInformation.AllTimeObjectiveTask09;
            UIAllTimeObjectivesItemsFieldPrize.text = ObjectiveInformation.AllTimeObjectivePrize09;
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete09) == 0) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressEnable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete09) == 1) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeEnable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete09) == 2) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteEnable();
                }
            }
        }
        
        if ((AllTimeObjectivesSceneButtons.AllTimeObjectiveNumber == 10) && (UIAllTimeObjectivesBackground.enabled == true)) {
            UIAllTimeObjectivesItemsFieldTitle.text = ObjectiveInformation.AllTimeObjectiveTitle10;
            UIAllTimeObjectivesItemsFieldText.text = ObjectiveInformation.AllTimeObjectiveTask10;
            UIAllTimeObjectivesItemsFieldPrize.text = ObjectiveInformation.AllTimeObjectivePrize10;
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete10) == 0) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressEnable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete10) == 1) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeEnable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete10) == 2) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteEnable();
                }
            }
        }
        
        if ((AllTimeObjectivesSceneButtons.AllTimeObjectiveNumber == 11) && (UIAllTimeObjectivesBackground.enabled == true)) {
            UIAllTimeObjectivesItemsFieldTitle.text = ObjectiveInformation.AllTimeObjectiveTitle11;
            UIAllTimeObjectivesItemsFieldText.text = ObjectiveInformation.AllTimeObjectiveTask11;
            UIAllTimeObjectivesItemsFieldPrize.text = ObjectiveInformation.AllTimeObjectivePrize11;
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete11) == 0) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressEnable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete11) == 1) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeEnable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete11) == 2) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteEnable();
                }
            }
        }
        
        if ((AllTimeObjectivesSceneButtons.AllTimeObjectiveNumber == 12) && (UIAllTimeObjectivesBackground.enabled == true)) {
            UIAllTimeObjectivesItemsFieldTitle.text = ObjectiveInformation.AllTimeObjectiveTitle12;
            UIAllTimeObjectivesItemsFieldText.text = ObjectiveInformation.AllTimeObjectiveTask12;
            UIAllTimeObjectivesItemsFieldPrize.text = ObjectiveInformation.AllTimeObjectivePrize12;
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete12) == 0) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressEnable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete12) == 1) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeEnable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete12) == 2) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteEnable();
                }
            }
        }
        
        if ((AllTimeObjectivesSceneButtons.AllTimeObjectiveNumber == 13) && (UIAllTimeObjectivesBackground.enabled == true)) {
            UIAllTimeObjectivesItemsFieldTitle.text = ObjectiveInformation.AllTimeObjectiveTitle13;
            UIAllTimeObjectivesItemsFieldText.text = ObjectiveInformation.AllTimeObjectiveTask13;
            UIAllTimeObjectivesItemsFieldPrize.text = ObjectiveInformation.AllTimeObjectivePrize13;
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete13) == 0) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressEnable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete13) == 1) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeEnable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete13) == 2) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteEnable();
                }
            }
        }
        
        if ((AllTimeObjectivesSceneButtons.AllTimeObjectiveNumber == 14) && (UIAllTimeObjectivesBackground.enabled == true)) {
            UIAllTimeObjectivesItemsFieldTitle.text = ObjectiveInformation.AllTimeObjectiveTitle14;
            UIAllTimeObjectivesItemsFieldText.text = ObjectiveInformation.AllTimeObjectiveTask14;
            UIAllTimeObjectivesItemsFieldPrize.text = ObjectiveInformation.AllTimeObjectivePrize14;
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete14) == 0) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressEnable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete14) == 1) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeEnable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete14) == 2) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteEnable();
                }
            }
        }
        
        if ((AllTimeObjectivesSceneButtons.AllTimeObjectiveNumber == 15) && (UIAllTimeObjectivesBackground.enabled == true)) {
            UIAllTimeObjectivesItemsFieldTitle.text = ObjectiveInformation.AllTimeObjectiveTitle15;
            UIAllTimeObjectivesItemsFieldText.text = ObjectiveInformation.AllTimeObjectiveTask15;
            UIAllTimeObjectivesItemsFieldPrize.text = ObjectiveInformation.AllTimeObjectivePrize15;
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete15) == 0) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressEnable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete15) == 1) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeEnable();
                    AllTimeObjectiveItemsFieldCompleteDisable();
                }
            }
            
            if (int.Parse(DataFillingInformation.DBAllTimeObjectiveComplete15) == 2) {
                if (UIAllTimeObjectivesItemsFieldPrize.enabled == true) {
                    AllTimeObjectiveItemsFieldProgressDisable();
                    AllTimeObjectiveItemsFieldClaimPrizeDisable();
                    AllTimeObjectiveItemsFieldCompleteEnable();
                }
            }
        }
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTION ---------------
    public void AllTimeObjectiveItemsMainEnable() {
        UIAllTimeObjectivesBackground.enabled = true;
        UIAllTimeObjectivesTitle.enabled = true;
        UIAllTimeObjectivesBackButton.enabled = true;
        UIAllTimeObjectivesCloseButton.enabled = true;
    }
    
    public void AllTimeObjectiveItemsButtonsEnable() {
        UIAllTimeObjectivesItems01.enabled = true;
        UIAllTimeObjectivesItems01Text.enabled = true;
        UIAllTimeObjectivesItems02.enabled = true;
        UIAllTimeObjectivesItems02Text.enabled = true;
        UIAllTimeObjectivesItems03.enabled = true;
        UIAllTimeObjectivesItems03Text.enabled = true;
        UIAllTimeObjectivesItems04.enabled = true;
        UIAllTimeObjectivesItems04Text.enabled = true;
        UIAllTimeObjectivesItems05.enabled = true;
        UIAllTimeObjectivesItems05Text.enabled = true;
        UIAllTimeObjectivesItems06.enabled = true;
        UIAllTimeObjectivesItems06Text.enabled = true;
        UIAllTimeObjectivesItems07.enabled = true;
        UIAllTimeObjectivesItems07Text.enabled = true;
        UIAllTimeObjectivesItems08.enabled = true;
        UIAllTimeObjectivesItems08Text.enabled = true;
        UIAllTimeObjectivesItems09.enabled = true;
        UIAllTimeObjectivesItems09Text.enabled = true;
        UIAllTimeObjectivesItems10.enabled = true;
        UIAllTimeObjectivesItems10Text.enabled = true;
        UIAllTimeObjectivesItems11.enabled = true;
        UIAllTimeObjectivesItems11Text.enabled = true;
        UIAllTimeObjectivesItems12.enabled = true;
        UIAllTimeObjectivesItems12Text.enabled = true;
        UIAllTimeObjectivesItems13.enabled = true;
        UIAllTimeObjectivesItems13Text.enabled = true;
        UIAllTimeObjectivesItems14.enabled = true;
        UIAllTimeObjectivesItems14Text.enabled = true;
        UIAllTimeObjectivesItems15.enabled = true;
        UIAllTimeObjectivesItems15Text.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldEnable() {
        UIAllTimeObjectivesItemsField.enabled = true;
        UIAllTimeObjectivesItemsFieldTitle.enabled = true;
        UIAllTimeObjectivesItemsFieldText.enabled = true;
        UIAllTimeObjectivesItemsFieldPrize.enabled = true;
        UIAllTimeObjectivesItemsFieldTracking.enabled = true;
        UIAllTimeObjectivesItemsFieldBackButton.enabled = true;
        AllTimeObjectiveItemsFieldCheck01Disable();
        AllTimeObjectiveItemsFieldCheck02Disable();
        AllTimeObjectiveItemsFieldCheck03Disable();
        AllTimeObjectiveItemsFieldCheck04Disable();
        AllTimeObjectiveItemsFieldCheck05Disable();
        AllTimeObjectiveItemsFieldCheck06Disable();
        AllTimeObjectiveItemsFieldCheck07Disable();
        AllTimeObjectiveItemsFieldCheck08Disable();
        AllTimeObjectiveItemsFieldCheck09Disable();
        AllTimeObjectiveItemsFieldCheck10Disable();
        AllTimeObjectiveItemsFieldCheck11Disable();
        AllTimeObjectiveItemsFieldCheck12Disable();
        AllTimeObjectiveItemsFieldCheck13Disable();
        AllTimeObjectiveItemsFieldCheck14Disable();
        AllTimeObjectiveItemsFieldCheck15Disable();
    }
    
    public void AllTimeObjectiveItemsFieldCompleteEnable() {
        UIAllTimeObjectivesItemsFieldCompleteText.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldProgressEnable() {
        UIAllTimeObjectivesItemsFieldProgressText.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldClaimPrizeEnable() {
        UIAllTimeObjectivesItemsFieldClaimPrizeText.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldCheck01Enable() {
        UIAllTimeObjectivesItem01Check.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldCheck02Enable() {
        UIAllTimeObjectivesItem02Check.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldCheck03Enable() {
        UIAllTimeObjectivesItem03Check.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldCheck04Enable() {
        UIAllTimeObjectivesItem04Check.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldCheck05Enable() {
        UIAllTimeObjectivesItem05Check.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldCheck06Enable() {
        UIAllTimeObjectivesItem06Check.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldCheck07Enable() {
        UIAllTimeObjectivesItem07Check.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldCheck08Enable() {
        UIAllTimeObjectivesItem08Check.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldCheck09Enable() {
        UIAllTimeObjectivesItem09Check.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldCheck10Enable() {
        UIAllTimeObjectivesItem10Check.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldCheck11Enable() {
        UIAllTimeObjectivesItem11Check.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldCheck12Enable() {
        UIAllTimeObjectivesItem12Check.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldCheck13Enable() {
        UIAllTimeObjectivesItem13Check.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldCheck14Enable() {
        UIAllTimeObjectivesItem14Check.enabled = true;
    }
    
    public void AllTimeObjectiveItemsFieldCheck15Enable() {
        UIAllTimeObjectivesItem15Check.enabled = true;
    }
    
// --------------- DISABLE FUNCTION ---------------
    public void AllTimeObjectiveItemsAllDisable() {
        AllTimeObjectiveItemsMainDisable();
        AllTimeObjectiveItemsButtonsDisable();
        AllTimeObjectiveItemsFieldDisable();
        AllTimeObjectiveItemsFieldCompleteDisable();
        AllTimeObjectiveItemsFieldProgressDisable();
        AllTimeObjectiveItemsFieldClaimPrizeDisable();
        AllTimeObjectiveItemsFieldCheck01Disable();
        AllTimeObjectiveItemsFieldCheck02Disable();
        AllTimeObjectiveItemsFieldCheck03Disable();
        AllTimeObjectiveItemsFieldCheck04Disable();
        AllTimeObjectiveItemsFieldCheck05Disable();
        AllTimeObjectiveItemsFieldCheck06Disable();
        AllTimeObjectiveItemsFieldCheck07Disable();
        AllTimeObjectiveItemsFieldCheck08Disable();
        AllTimeObjectiveItemsFieldCheck09Disable();
        AllTimeObjectiveItemsFieldCheck10Disable();
        AllTimeObjectiveItemsFieldCheck11Disable();
        AllTimeObjectiveItemsFieldCheck12Disable();
        AllTimeObjectiveItemsFieldCheck13Disable();
        AllTimeObjectiveItemsFieldCheck14Disable();
        AllTimeObjectiveItemsFieldCheck15Disable();
    }
    
    public void AllTimeObjectiveItemsMainDisable() {
        UIAllTimeObjectivesBackground.enabled = false;
        UIAllTimeObjectivesTitle.enabled = false;
        UIAllTimeObjectivesBackButton.enabled = false;
        UIAllTimeObjectivesCloseButton.enabled = false;
    }
    
    public void AllTimeObjectiveItemsButtonsDisable() {
        UIAllTimeObjectivesItems01.enabled = false;
        UIAllTimeObjectivesItems01Text.enabled = false;
        UIAllTimeObjectivesItems02.enabled = false;
        UIAllTimeObjectivesItems02Text.enabled = false;
        UIAllTimeObjectivesItems03.enabled = false;
        UIAllTimeObjectivesItems03Text.enabled = false;
        UIAllTimeObjectivesItems04.enabled = false;
        UIAllTimeObjectivesItems04Text.enabled = false;
        UIAllTimeObjectivesItems05.enabled = false;
        UIAllTimeObjectivesItems05Text.enabled = false;
        UIAllTimeObjectivesItems06.enabled = false;
        UIAllTimeObjectivesItems06Text.enabled = false;
        UIAllTimeObjectivesItems07.enabled = false;
        UIAllTimeObjectivesItems07Text.enabled = false;
        UIAllTimeObjectivesItems08.enabled = false;
        UIAllTimeObjectivesItems08Text.enabled = false;
        UIAllTimeObjectivesItems09.enabled = false;
        UIAllTimeObjectivesItems09Text.enabled = false;
        UIAllTimeObjectivesItems10.enabled = false;
        UIAllTimeObjectivesItems10Text.enabled = false;
        UIAllTimeObjectivesItems11.enabled = false;
        UIAllTimeObjectivesItems11Text.enabled = false;
        UIAllTimeObjectivesItems12.enabled = false;
        UIAllTimeObjectivesItems12Text.enabled = false;
        UIAllTimeObjectivesItems13.enabled = false;
        UIAllTimeObjectivesItems13Text.enabled = false;
        UIAllTimeObjectivesItems14.enabled = false;
        UIAllTimeObjectivesItems14Text.enabled = false;
        UIAllTimeObjectivesItems15.enabled = false;
        UIAllTimeObjectivesItems15Text.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldDisable() {
        UIAllTimeObjectivesItemsField.enabled = false;
        UIAllTimeObjectivesItemsFieldTitle.enabled = false;
        UIAllTimeObjectivesItemsFieldText.enabled = false;
        UIAllTimeObjectivesItemsFieldPrize.enabled = false;
        UIAllTimeObjectivesItemsFieldTracking.enabled = false;
        UIAllTimeObjectivesItemsFieldBackButton.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCompleteDisable() {
        UIAllTimeObjectivesItemsFieldCompleteText.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldProgressDisable() {
        UIAllTimeObjectivesItemsFieldProgressText.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldClaimPrizeDisable() {
        UIAllTimeObjectivesItemsFieldClaimPrizeText.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCheck01Disable() {
        UIAllTimeObjectivesItem01Check.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCheck02Disable() {
        UIAllTimeObjectivesItem02Check.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCheck03Disable() {
        UIAllTimeObjectivesItem03Check.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCheck04Disable() {
        UIAllTimeObjectivesItem04Check.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCheck05Disable() {
        UIAllTimeObjectivesItem05Check.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCheck06Disable() {
        UIAllTimeObjectivesItem06Check.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCheck07Disable() {
        UIAllTimeObjectivesItem07Check.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCheck08Disable() {
        UIAllTimeObjectivesItem08Check.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCheck09Disable() {
        UIAllTimeObjectivesItem09Check.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCheck10Disable() {
        UIAllTimeObjectivesItem10Check.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCheck11Disable() {
        UIAllTimeObjectivesItem11Check.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCheck12Disable() {
        UIAllTimeObjectivesItem12Check.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCheck13Disable() {
        UIAllTimeObjectivesItem13Check.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCheck14Disable() {
        UIAllTimeObjectivesItem14Check.enabled = false;
    }
    
    public void AllTimeObjectiveItemsFieldCheck15Disable() {
        UIAllTimeObjectivesItem15Check.enabled = false;
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}