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

public class MonthlyObjectiveItemsSceneEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image UIMonthlyObjectiveItemsBackground;
    public Text UIMonthlyObjectiveItemsTitle;
    public Text UIMonthlyObjectiveItemsBackButton;
    public Text UIMonthlyObjectiveItemsCloseButton;
    
    public Image UIMonthlyObjectiveItemsNumber1;
    public Text UIMonthlyObjectiveItemsNumber1Text;
    public Image UIMonthlyObjectiveItemsNumber1Check;
    public Image UIMonthlyObjectiveItemsNumber2;
    public Text UIMonthlyObjectiveItemsNumber2Text;
    public Image UIMonthlyObjectiveItemsNumber2Check;
    public Image UIMonthlyObjectiveItemsNumber3;
    public Text UIMonthlyObjectiveItemsNumber3Text;
    public Image UIMonthlyObjectiveItemsNumber3Check;
    public Image UIMonthlyObjectiveItemsNumber4;
    public Text UIMonthlyObjectiveItemsNumber4Text;
    public Image UIMonthlyObjectiveItemsNumber4Check;
    public Image UIMonthlyObjectiveItemsNumber5;
    public Text UIMonthlyObjectiveItemsNumber5Text;
    public Image UIMonthlyObjectiveItemsNumber5Check;
    
    public Image UIMonthlyObjectiveItemsField;
    public Text UIMonthlyObjectiveItemsFieldTitle;
    public Text UIMonthlyObjectiveItemsFieldText;
    public Text UIMonthlyObjectiveItemsFieldPrize;
    public Text UIMonthlyObjectiveItemsFieldTracking;
    
    public Text UIMonthlyObjectiveItemsFieldCompleteText;
    public Text UIMonthlyObjectiveItemsFieldProgressText;
    public Text UIMonthlyObjectiveItemsFieldClaimPrizeText;
	
// --------------- PRIVATE VARIABLES ---------------
	private Color EventObjectiveColorOff;
    private Color EventObjectiveColorOn;
    private Color EventObjectiveColorCollect;
	
// --------------- STATIC VARIABLES ---------------
	public static int EventObjectiveNumber;
    public static string CurrentEventObjectiveNumber;
    public static int IndividualEventObjectiveNumber;
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		IndividualMonthlyObjectiveItemsAllDisable();
        CurrentEventObjectiveNumber = DateTime.Now.Month.ToString();
        
        IndividualMonthlyObjectiveItemsButtonsEnable();
        IndividualMonthlyObjectiveItemsFieldEnable();
        
        EventObjectiveColorOff = new Color(0.15f, 0.36f, 0.45f, 1.0f);
        EventObjectiveColorOn = new Color(0.01f, 0.78f, 0.0f, 1.0f);
        EventObjectiveColorCollect = new Color(0.01f, 0.73f, 0.91f, 1.0f);
        
        if ((int.Parse(CurrentEventObjectiveNumber) == 1) || (int.Parse(CurrentEventObjectiveNumber) == 2)) {
            IndividualEventObjectiveNumber = 101;
        }
        
        if ((int.Parse(CurrentEventObjectiveNumber) == 3) || (int.Parse(CurrentEventObjectiveNumber) == 4)) {
            IndividualEventObjectiveNumber = 201;
        }
        
        if ((int.Parse(CurrentEventObjectiveNumber) == 5) || (int.Parse(CurrentEventObjectiveNumber) == 6)) {
            IndividualEventObjectiveNumber = 301;
        }
        
        if ((int.Parse(CurrentEventObjectiveNumber) == 7) || (int.Parse(CurrentEventObjectiveNumber) == 8)) {
            IndividualEventObjectiveNumber = 401;
        }
        
        if ((int.Parse(CurrentEventObjectiveNumber) == 9) || (int.Parse(CurrentEventObjectiveNumber) == 10)) {
            IndividualEventObjectiveNumber = 501;
        }
        
        if ((int.Parse(CurrentEventObjectiveNumber) == 11) || (int.Parse(CurrentEventObjectiveNumber) == 12)) {
            IndividualEventObjectiveNumber = 601;
        }
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		if (((int.Parse(CurrentEventObjectiveNumber) == 1) || (int.Parse(CurrentEventObjectiveNumber) == 2)) && (UIMonthlyObjectiveItemsBackground.enabled == true)) {
            UIMonthlyObjectiveItemsTitle.text = "Event: " + ObjectiveInformation.EventObjectiveEvent01;
            UIMonthlyObjectiveItemsNumber1Text.text = ObjectiveInformation.EventObjectiveTitle011;
            UIMonthlyObjectiveItemsNumber2Text.text = ObjectiveInformation.EventObjectiveTitle012;
            UIMonthlyObjectiveItemsNumber3Text.text = ObjectiveInformation.EventObjectiveTitle013;
            UIMonthlyObjectiveItemsNumber4Text.text = ObjectiveInformation.EventObjectiveTitle014;
            UIMonthlyObjectiveItemsNumber5Text.text = ObjectiveInformation.EventObjectiveTitle015;
            
            if (IndividualEventObjectiveNumber == 101) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle011;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask011;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize011;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete101) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck1Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete101) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck1Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete101) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck1Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 102) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle012;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask012;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize012;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete102) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck2Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete102) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck2Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete102) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck2Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 103) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle013;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask013;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize013;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete103) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck3Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete103) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck3Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete103) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck3Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 104) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle014;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask014;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize014;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete104) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck4Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete104) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck4Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete104) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck4Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 105) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle015;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask015;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize015;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete105) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck5Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete105) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck5Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete105) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck5Enable();
                }
            }
        }
        
        if (((int.Parse(CurrentEventObjectiveNumber) == 3) || (int.Parse(CurrentEventObjectiveNumber) == 4)) && (UIMonthlyObjectiveItemsBackground.enabled == true)) {
            UIMonthlyObjectiveItemsTitle.text = "Event: " + ObjectiveInformation.EventObjectiveEvent02;
            UIMonthlyObjectiveItemsNumber1Text.text = ObjectiveInformation.EventObjectiveTitle021;
            UIMonthlyObjectiveItemsNumber2Text.text = ObjectiveInformation.EventObjectiveTitle022;
            UIMonthlyObjectiveItemsNumber3Text.text = ObjectiveInformation.EventObjectiveTitle023;
            UIMonthlyObjectiveItemsNumber4Text.text = ObjectiveInformation.EventObjectiveTitle024;
            UIMonthlyObjectiveItemsNumber5Text.text = ObjectiveInformation.EventObjectiveTitle025;
            
            if (IndividualEventObjectiveNumber == 201) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle021;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask021;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize021;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete201) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck1Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete201) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck1Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete201) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck1Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 202) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle022;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask022;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize022;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete202) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck2Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete202) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck2Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete202) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck2Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 203) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle023;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask023;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize023;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete203) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck3Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete203) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck3Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete203) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck3Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 204) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle024;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask024;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize024;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete204) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck4Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete204) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck4Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete204) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck4Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 205) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle025;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask025;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize025;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete205) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck5Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete205) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck5Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete205) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck5Enable();
                }
            }
        }
        
        if (((int.Parse(CurrentEventObjectiveNumber) == 5) || (int.Parse(CurrentEventObjectiveNumber) == 6)) && (UIMonthlyObjectiveItemsBackground.enabled == true)) {
            UIMonthlyObjectiveItemsTitle.text = "Event: " + ObjectiveInformation.EventObjectiveEvent03;
            UIMonthlyObjectiveItemsNumber1Text.text = ObjectiveInformation.EventObjectiveTitle031;
            UIMonthlyObjectiveItemsNumber2Text.text = ObjectiveInformation.EventObjectiveTitle032;
            UIMonthlyObjectiveItemsNumber3Text.text = ObjectiveInformation.EventObjectiveTitle033;
            UIMonthlyObjectiveItemsNumber4Text.text = ObjectiveInformation.EventObjectiveTitle034;
            UIMonthlyObjectiveItemsNumber5Text.text = ObjectiveInformation.EventObjectiveTitle035;
            
            if (IndividualEventObjectiveNumber == 301) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle031;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask031;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize031;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete301) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck1Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete301) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck1Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete301) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck1Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 302) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle032;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask032;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize032;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete302) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck2Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete302) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck2Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete302) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck2Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 303) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle033;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask033;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize033;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete303) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck3Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete303) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck3Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete303) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck3Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 304) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle034;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask034;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize034;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete304) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck4Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete304) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck4Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete304) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck4Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 305) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle035;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask035;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize035;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete305) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck5Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete305) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck5Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete305) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck5Enable();
                }
            }
        }
        
        if (((int.Parse(CurrentEventObjectiveNumber) == 7) || (int.Parse(CurrentEventObjectiveNumber) == 8)) && (UIMonthlyObjectiveItemsBackground.enabled == true)) {
            UIMonthlyObjectiveItemsTitle.text = "Event: " + ObjectiveInformation.EventObjectiveEvent04;
            UIMonthlyObjectiveItemsNumber1Text.text = ObjectiveInformation.EventObjectiveTitle041;
            UIMonthlyObjectiveItemsNumber2Text.text = ObjectiveInformation.EventObjectiveTitle042;
            UIMonthlyObjectiveItemsNumber3Text.text = ObjectiveInformation.EventObjectiveTitle043;
            UIMonthlyObjectiveItemsNumber4Text.text = ObjectiveInformation.EventObjectiveTitle044;
            UIMonthlyObjectiveItemsNumber5Text.text = ObjectiveInformation.EventObjectiveTitle045;
            
            if (IndividualEventObjectiveNumber == 401) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle041;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask041;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize041;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete401) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck1Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete401) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck1Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete401) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck1Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 402) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle042;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask042;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize042;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete402) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck2Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete402) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck2Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete402) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck2Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 403) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle043;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask043;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize043;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete403) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck3Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete403) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck3Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete403) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck3Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 404) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle044;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask044;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize044;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete404) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck4Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete404) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck4Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete404) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck4Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 405) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle045;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask045;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize045;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete405) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck5Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete405) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck5Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete405) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck5Enable();
                }
            }
        }
        
        if (((int.Parse(CurrentEventObjectiveNumber) == 9) || (int.Parse(CurrentEventObjectiveNumber) == 10)) && (UIMonthlyObjectiveItemsBackground.enabled == true)) {
            UIMonthlyObjectiveItemsTitle.text = "Event: " + ObjectiveInformation.EventObjectiveEvent05;
            UIMonthlyObjectiveItemsNumber1Text.text = ObjectiveInformation.EventObjectiveTitle051;
            UIMonthlyObjectiveItemsNumber2Text.text = ObjectiveInformation.EventObjectiveTitle052;
            UIMonthlyObjectiveItemsNumber3Text.text = ObjectiveInformation.EventObjectiveTitle053;
            UIMonthlyObjectiveItemsNumber4Text.text = ObjectiveInformation.EventObjectiveTitle054;
            UIMonthlyObjectiveItemsNumber5Text.text = ObjectiveInformation.EventObjectiveTitle055;
            
            if (IndividualEventObjectiveNumber == 501) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle051;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask051;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize051;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete501) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck1Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete501) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck1Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete501) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck1Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 502) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle052;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask052;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize052;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete502) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck2Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete502) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck2Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete502) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck2Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 503) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle053;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask053;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize053;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete503) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck3Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete503) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck3Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete503) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck3Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 504) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle054;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask054;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize054;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete504) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck4Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete504) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck4Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete504) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck4Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 505) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle055;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask055;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize055;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete505) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck5Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete505) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck5Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete505) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck5Enable();
                }
            }
        }
        
        if (((int.Parse(CurrentEventObjectiveNumber) == 11) || (int.Parse(CurrentEventObjectiveNumber) == 12)) && (UIMonthlyObjectiveItemsBackground.enabled == true)) {
            UIMonthlyObjectiveItemsTitle.text = "Event: " + ObjectiveInformation.EventObjectiveEvent06;
            UIMonthlyObjectiveItemsNumber1Text.text = ObjectiveInformation.EventObjectiveTitle061;
            UIMonthlyObjectiveItemsNumber2Text.text = ObjectiveInformation.EventObjectiveTitle062;
            UIMonthlyObjectiveItemsNumber3Text.text = ObjectiveInformation.EventObjectiveTitle063;
            UIMonthlyObjectiveItemsNumber4Text.text = ObjectiveInformation.EventObjectiveTitle064;
            UIMonthlyObjectiveItemsNumber5Text.text = ObjectiveInformation.EventObjectiveTitle065;
            
            if (IndividualEventObjectiveNumber == 601) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle061;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask061;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize061;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete601) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck1Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete601) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck1Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete601) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber1.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck1Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 602) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle062;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask062;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize062;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete602) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck2Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete602) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck2Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete602) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber2.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck2Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 603) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle063;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask063;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize063;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete603) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck3Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete603) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck3Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete603) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber3.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck3Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 604) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle064;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask064;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize064;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete604) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck4Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete604) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck4Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete604) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber4.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck4Enable();
                }
            }
            
            if (IndividualEventObjectiveNumber == 605) {
                UIMonthlyObjectiveItemsFieldTitle.text = ObjectiveInformation.EventObjectiveTitle065;
                UIMonthlyObjectiveItemsFieldText.text = ObjectiveInformation.EventObjectiveTask065;
                UIMonthlyObjectiveItemsFieldPrize.text = "Completion Prize: " + ObjectiveInformation.EventObjectivePrize065;
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete605) == 0) {
                    IndividualMonthlyObjectiveItemsProgressEnable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorOff;
                    IndividualMonthlyObjectiveItemsCheck5Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete605) == 1) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeEnable();
                    IndividualMonthlyObjectiveItemsCompleteDisable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorCollect;
                    IndividualMonthlyObjectiveItemsCheck5Disable();
                }
                
                if (int.Parse(DataFillingInformation.DBEventObjectiveComplete605) == 2) {
                    IndividualMonthlyObjectiveItemsProgressDisable();
                    IndividualMonthlyObjectiveItemsClaimPrizeDisable();
                    IndividualMonthlyObjectiveItemsCompleteEnable();
                    UIMonthlyObjectiveItemsNumber5.color = EventObjectiveColorOn;
                    IndividualMonthlyObjectiveItemsCheck5Enable();
                }
            }
        }
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
    public void IndividualMonthlyObjectiveItemsMainEnable() {
        UIMonthlyObjectiveItemsBackground.enabled = true;
        UIMonthlyObjectiveItemsTitle.enabled = true;
        UIMonthlyObjectiveItemsBackButton.enabled = true;
        UIMonthlyObjectiveItemsCloseButton.enabled = true;
    }
    
    public void IndividualMonthlyObjectiveItemsButtonsEnable() {
        UIMonthlyObjectiveItemsNumber1.enabled = true;
        UIMonthlyObjectiveItemsNumber1Text.enabled = true;
        UIMonthlyObjectiveItemsNumber2.enabled = true;
        UIMonthlyObjectiveItemsNumber2Text.enabled = true;
        UIMonthlyObjectiveItemsNumber3.enabled = true;
        UIMonthlyObjectiveItemsNumber3Text.enabled = true;
        UIMonthlyObjectiveItemsNumber4.enabled = true;
        UIMonthlyObjectiveItemsNumber4Text.enabled = true;
        UIMonthlyObjectiveItemsNumber5.enabled = true;
        UIMonthlyObjectiveItemsNumber5Text.enabled = true;
    }
    
    public void IndividualMonthlyObjectiveItemsFieldEnable() {
        UIMonthlyObjectiveItemsField.enabled = true;
        UIMonthlyObjectiveItemsFieldTitle.enabled = true;
        UIMonthlyObjectiveItemsFieldText.enabled = true;
        UIMonthlyObjectiveItemsFieldPrize.enabled = true;
        UIMonthlyObjectiveItemsFieldTracking.enabled = true;
    }
    
    public void IndividualMonthlyObjectiveItemsCompleteEnable() {
        UIMonthlyObjectiveItemsFieldCompleteText.enabled = true;
    }
    
    public void IndividualMonthlyObjectiveItemsProgressEnable() {
        UIMonthlyObjectiveItemsFieldProgressText.enabled = true;
    }
    
    public void IndividualMonthlyObjectiveItemsClaimPrizeEnable() {
        UIMonthlyObjectiveItemsFieldClaimPrizeText.enabled = true;
    }
    
    public void IndividualMonthlyObjectiveItemsCheck1Enable() {
        UIMonthlyObjectiveItemsNumber1Check.enabled = true;
    }
    
    public void IndividualMonthlyObjectiveItemsCheck2Enable() {
        UIMonthlyObjectiveItemsNumber2Check.enabled = true;
    }
    
    public void IndividualMonthlyObjectiveItemsCheck3Enable() {
        UIMonthlyObjectiveItemsNumber3Check.enabled = true;
    }
    
    public void IndividualMonthlyObjectiveItemsCheck4Enable() {
        UIMonthlyObjectiveItemsNumber4Check.enabled = true;
    }
    
    public void IndividualMonthlyObjectiveItemsCheck5Enable() {
        UIMonthlyObjectiveItemsNumber5Check.enabled = true;
    }
    
// --------------- DISABLE FUNCTIONS ---------------
    public void IndividualMonthlyObjectiveItemsAllDisable() {
        IndividualMonthlyObjectiveItemsMainDisable();
        IndividualMonthlyObjectiveItemsButtonsDisable();
        IndividualMonthlyObjectiveItemsFieldDisable();
        IndividualMonthlyObjectiveItemsCompleteDisable();
        IndividualMonthlyObjectiveItemsProgressDisable();
        IndividualMonthlyObjectiveItemsClaimPrizeDisable();
        IndividualMonthlyObjectiveItemsCheck1Disable();
        IndividualMonthlyObjectiveItemsCheck2Disable();
        IndividualMonthlyObjectiveItemsCheck3Disable();
        IndividualMonthlyObjectiveItemsCheck4Disable();
        IndividualMonthlyObjectiveItemsCheck5Disable();
    }
    
    public void IndividualMonthlyObjectiveItemsMainDisable() {
        UIMonthlyObjectiveItemsBackground.enabled = false;
        UIMonthlyObjectiveItemsTitle.enabled = false;
        UIMonthlyObjectiveItemsBackButton.enabled = false;
        UIMonthlyObjectiveItemsCloseButton.enabled = false;
    }
    
    public void IndividualMonthlyObjectiveItemsButtonsDisable() {
        UIMonthlyObjectiveItemsNumber1.enabled = false;
        UIMonthlyObjectiveItemsNumber1Text.enabled = false;
        UIMonthlyObjectiveItemsNumber2.enabled = false;
        UIMonthlyObjectiveItemsNumber2Text.enabled = false;
        UIMonthlyObjectiveItemsNumber3.enabled = false;
        UIMonthlyObjectiveItemsNumber3Text.enabled = false;
        UIMonthlyObjectiveItemsNumber4.enabled = false;
        UIMonthlyObjectiveItemsNumber4Text.enabled = false;
        UIMonthlyObjectiveItemsNumber5.enabled = false;
        UIMonthlyObjectiveItemsNumber5Text.enabled = false;
    }
    
    public void IndividualMonthlyObjectiveItemsFieldDisable() {
        UIMonthlyObjectiveItemsField.enabled = false;
        UIMonthlyObjectiveItemsFieldTitle.enabled = false;
        UIMonthlyObjectiveItemsFieldText.enabled = false;
        UIMonthlyObjectiveItemsFieldPrize.enabled = false;
        UIMonthlyObjectiveItemsFieldTracking.enabled = false;
    }
    
    public void IndividualMonthlyObjectiveItemsCompleteDisable() {
        UIMonthlyObjectiveItemsFieldCompleteText.enabled = false;
    }
    
    public void IndividualMonthlyObjectiveItemsProgressDisable() {
        UIMonthlyObjectiveItemsFieldProgressText.enabled = false;
    }
    
    public void IndividualMonthlyObjectiveItemsClaimPrizeDisable() {
        UIMonthlyObjectiveItemsFieldClaimPrizeText.enabled = false;
    }
    
    public void IndividualMonthlyObjectiveItemsCheck1Disable() {
        UIMonthlyObjectiveItemsNumber1Check.enabled = false;
    }
    
    public void IndividualMonthlyObjectiveItemsCheck2Disable() {
        UIMonthlyObjectiveItemsNumber2Check.enabled = false;
    }
    
    public void IndividualMonthlyObjectiveItemsCheck3Disable() {
        UIMonthlyObjectiveItemsNumber3Check.enabled = false;
    }
    
    public void IndividualMonthlyObjectiveItemsCheck4Disable() {
        UIMonthlyObjectiveItemsNumber4Check.enabled = false;
    }
    
    public void IndividualMonthlyObjectiveItemsCheck5Disable() {
        UIMonthlyObjectiveItemsNumber5Check.enabled = false;
    }
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}