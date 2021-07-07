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

public class ArtworkPagesSceneEnableB : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Objects
	public Image UIArtworkPagesBackground;
	public Image UIArtworkPagesField;
	public Text UIArtworkPagesTitleInput;
	public Text UIArtworkPagesArtist;
	public Text UIArtworkPagesArtistInput;
	public Text UIArtworkPagesYear;
	public Text UIArtworkPagesYearInput;
	public Text UIArtworkPagesStyle;
	public Text UIArtworkPagesStyleInput;
    public Text UIArtworkPagesCountry;
	public Text UIArtworkPagesCountryInput;
	public Text UIArtworkPagesText;
	public Image UIArtworkPagesPurchaseButton;
	public Text UIArtworkPagesPurchaseButtonText;
	public Image UIArtworkPagesCannotBuyButton;
	public Text UIArtworkPagesCannotBuyButtonText;
	public Image UIArtworkPagesLearnButton;
	public Text UIArtworkPagesLearnButtonText;
	public Image UIArtworkPagesBoughtButton;
	public Text UIArtworkPagesBoughtButtonText;
	public Text UIArtworkPagesBackButton;
		
	// Page FB
	public Image UIArtworkPagesArtworkFB01;
	public Image UIArtworkPagesArtworkFB02;
	public Image UIArtworkPagesArtworkFB03;
	public Image UIArtworkPagesArtworkFB04;
	public Image UIArtworkPagesArtworkFB05;
	public Image UIArtworkPagesArtworkFB06;
	public Image UIArtworkPagesArtworkFB07;
	public Image UIArtworkPagesArtworkFB08;
	public Image UIArtworkPagesArtworkFB09;
	public Image UIArtworkPagesArtworkFB10;
	public Image UIArtworkPagesArtworkFB11;
	public Image UIArtworkPagesArtworkFB12;
	public Image UIArtworkPagesArtworkFB13;
	public Image UIArtworkPagesArtworkFB14;
	public Image UIArtworkPagesArtworkFB15;
    
    // Page F1 Added
	public Image UIArtworkPagesArtworkF101Added;
	public Image UIArtworkPagesArtworkF102Added;
	public Image UIArtworkPagesArtworkF103Added;
	public Image UIArtworkPagesArtworkF104Added;
	public Image UIArtworkPagesArtworkF105Added;
	public Image UIArtworkPagesArtworkF106Added;
	public Image UIArtworkPagesArtworkF107Added;
	public Image UIArtworkPagesArtworkF108Added;
    
    // Page F2 Added
	public Image UIArtworkPagesArtworkF201Added;
	public Image UIArtworkPagesArtworkF202Added;
	public Image UIArtworkPagesArtworkF203Added;
	public Image UIArtworkPagesArtworkF204Added;
	public Image UIArtworkPagesArtworkF205Added;
	public Image UIArtworkPagesArtworkF206Added;
	public Image UIArtworkPagesArtworkF207Added;
	public Image UIArtworkPagesArtworkF208Added;
    
    // Page F3 Added
	public Image UIArtworkPagesArtworkF301Added;
	public Image UIArtworkPagesArtworkF302Added;
	public Image UIArtworkPagesArtworkF303Added;
	public Image UIArtworkPagesArtworkF304Added;
	public Image UIArtworkPagesArtworkF305Added;
	public Image UIArtworkPagesArtworkF306Added;
	public Image UIArtworkPagesArtworkF307Added;
	public Image UIArtworkPagesArtworkF308Added;
    
    // Page G1 Added
	public Image UIArtworkPagesArtworkG101Added;
	public Image UIArtworkPagesArtworkG102Added;
	public Image UIArtworkPagesArtworkG103Added;
	public Image UIArtworkPagesArtworkG104Added;
	public Image UIArtworkPagesArtworkG105Added;
	public Image UIArtworkPagesArtworkG106Added;
	public Image UIArtworkPagesArtworkG107Added;
	public Image UIArtworkPagesArtworkG108Added;
    
    // Page G2 Added
	public Image UIArtworkPagesArtworkG201Added;
	public Image UIArtworkPagesArtworkG202Added;
	public Image UIArtworkPagesArtworkG203Added;
	public Image UIArtworkPagesArtworkG204Added;
	public Image UIArtworkPagesArtworkG205Added;
	public Image UIArtworkPagesArtworkG206Added;
	public Image UIArtworkPagesArtworkG207Added;
	public Image UIArtworkPagesArtworkG208Added;
    
    // Page G3 Added
	public Image UIArtworkPagesArtworkG301Added;
	public Image UIArtworkPagesArtworkG302Added;
	public Image UIArtworkPagesArtworkG303Added;
	public Image UIArtworkPagesArtworkG304Added;
	public Image UIArtworkPagesArtworkG305Added;
	public Image UIArtworkPagesArtworkG306Added;
	public Image UIArtworkPagesArtworkG307Added;
	public Image UIArtworkPagesArtworkG308Added;
    
    // Page FB Added
	public Image UIArtworkPagesArtworkFB01Added;
	public Image UIArtworkPagesArtworkFB02Added;
	public Image UIArtworkPagesArtworkFB03Added;
	public Image UIArtworkPagesArtworkFB04Added;
	public Image UIArtworkPagesArtworkFB05Added;
	public Image UIArtworkPagesArtworkFB06Added;
	public Image UIArtworkPagesArtworkFB07Added;
	public Image UIArtworkPagesArtworkFB08Added;
    public Image UIArtworkPagesArtworkFB09Added;
	public Image UIArtworkPagesArtworkFB10Added;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		ArtworkPagesAllEnable();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		ArtworkPagesSpecificEnable();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTIONS ---------------
	public void ArtworkPagesAllEnable() {
		UIArtworkPagesBackground.enabled = true;
		UIArtworkPagesField.enabled = true;
		UIArtworkPagesTitleInput.enabled = true;
		UIArtworkPagesArtist.enabled = true;
		UIArtworkPagesArtistInput.enabled = true;
		UIArtworkPagesYear.enabled = true;
		UIArtworkPagesYearInput.enabled = true;
		UIArtworkPagesStyle.enabled = true;
		UIArtworkPagesStyleInput.enabled = true;
		UIArtworkPagesText.enabled = true;
		UIArtworkPagesLearnButton.enabled = true;
		UIArtworkPagesLearnButtonText.enabled = true;
		UIArtworkPagesBackButton.enabled = true;
    }
	
    public void ArtworkPagesSpecificEnable() {
        if (UIArtworkPagesBackground.enabled == true) {
            if (MainArtworkPageButtons.IdentifyArtworkButton == 601) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB01.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB01;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB01;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB01.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB01;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB01;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB01) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB01) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB01.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB01) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB01.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB01) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 602) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB02.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB02;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB02;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB02.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB02;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB02;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB02) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB02) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB02.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB02) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB02.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB02) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 603) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB03.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB03;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB03;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB03.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB03;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB03;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB03) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB03) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB03.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB03) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB03.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB03) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 604) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB04.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB04;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB04;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB04.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB04;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB04;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB04) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB04) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB04.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB04) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB04.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB04) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 605) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB05.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB05;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB05;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB05.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB05;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB05;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB05) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB05) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB05.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB05) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB05.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB05) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 606) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB06.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB06;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB06;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB06.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB06;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB06;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB06) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB06) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB06.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB06) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB06.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB06) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 607) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB07.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB07;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB07;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB07.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB07;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB07;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB07) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB07) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB07.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB07) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB07.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB07) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 608) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB08.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB08;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB08;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB08.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB08;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB08;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB08) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB08) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB08.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB08) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB08.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB08) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 609) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB09.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB09;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB09;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB09.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB09;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB09;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB09) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB09) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB09.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB09) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB09.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB09) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 610) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB10.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB10;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB10;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB10.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB10;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB10;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB10) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB10) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB10.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB10) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB10.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB10) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 611) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB11.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB11;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB11;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB11.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB11;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB11;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB11) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB11) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB11.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB11) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB11.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB11) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 612) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB12.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB12;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB12;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB12.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB12;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB12;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB12) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB12) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB12.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB12) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB12.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB12) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 613) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB13.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB13;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB13;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB13.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB13;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB13;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB13) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB13) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB13.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB13) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB13.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB13) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 614) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB14.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB14;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB14;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB14.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB14;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB14;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB14) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB14) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB14.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB14) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB14.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB14) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 615) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB15.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB15;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB15;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB15.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB15;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB15;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB15) == 0) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesPurchaseButton.enabled = true;
                    UIArtworkPagesPurchaseButtonText.enabled = true;
                    UIArtworkPagesPurchaseButtonText.text = "Buy the Basement 15th Artwork";
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB15) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1001) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF101Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF101Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF101Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF101Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF101Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF101Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF101Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF101Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF101Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF101Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF101Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF101Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1002) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF102Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF102Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF102Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF102Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF102Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF102Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF102Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF102Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF102Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF102Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF102Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF102Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1003) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF103Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF103Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF103Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF103Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF103Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF103Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF103Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF103Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF103Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF103Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF103Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF103Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1004) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF104Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF104Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF104Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF104Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF104Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF104Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF104Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF104Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF104Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF104Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF104Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF104Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1005) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF105Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF105Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF105Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF105Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF105Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF105Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF105Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF105Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF105Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF105Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF105Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF105Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1006) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF106Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF106Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF106Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF106Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF106Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF106Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF106Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF106Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF106Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF106Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF106Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF106Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1007) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF107Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF107Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF107Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF107Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF107Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF107Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF107Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF107Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF107Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF107Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF107Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF107Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 1008) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF108Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF108Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF108Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF108Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF108Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF108Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF108Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF108Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF108Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF108Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF108Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF108Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2001) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF201Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF201Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF201Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF201Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF201Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF201Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF201Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF201Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF201Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF201Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF201Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF201Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2002) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF202Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF202Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF202Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF202Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF202Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF202Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF202Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF202Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF202Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF202Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF202Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF202Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2003) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF203Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF203Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF203Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF203Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF203Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF203Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF203Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF203Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF203Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF203Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF203Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF203Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2004) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF204Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF204Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF204Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF204Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF204Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF204Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF204Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF204Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF204Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF204Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF204Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF204Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2005) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF205Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF205Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF205Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF205Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF205Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF205Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF205Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF205Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF205Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF205Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF205Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF205Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2006) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF206Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF206Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF206Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF206Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF206Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF206Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF206Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF206Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF206Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF206Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF206Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF206Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2007) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF207Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF207Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF207Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF207Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF207Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF207Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF207Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF207Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF207Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF207Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF207Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF207Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 2008) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF208Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF208Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF208Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF208Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF208Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF208Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF208Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF208Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF208Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF208Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF208Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF208Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3001) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF301Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF301Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF301Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF301Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF301Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF301Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF301Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF301Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF301Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF301Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF301Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF301Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3002) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF302Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF302Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF302Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF302Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF302Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF302Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF302Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF302Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF302Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF302Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF302Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF302Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3003) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF303Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF303Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF303Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF303Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF303Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF303Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF303Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF303Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF303Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF303Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF303Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF303Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3004) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF304Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF304Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF304Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF304Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF304Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF304Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF304Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF304Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF304Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF304Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF304Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF304Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3005) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF305Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF305Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF305Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF305Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF305Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF305Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF305Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF305Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF305Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF305Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF305Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF305Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3006) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF306Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF306Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF306Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF306Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF306Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF306Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF306Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF306Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF306Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF306Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF306Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF306Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3007) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF307Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF307Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF307Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF307Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF307Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF307Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF307Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF307Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF307Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF307Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF307Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF307Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 3008) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF308Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF308Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF308Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF308Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF308Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF308Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF308Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF308Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF308Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF308Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF308Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF308Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4001) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG101Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG101Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG101Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG101Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG101Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG101Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG101Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG101Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG101Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG101Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG101Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG101Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4002) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG102Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG102Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG102Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG102Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG102Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG102Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG102Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG102Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG102Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG102Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG102Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG102Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4003) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG103Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG103Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG103Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG103Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG103Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG103Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG103Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG103Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG103Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG103Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG103Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG103Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4004) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG104Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG104Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG104Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG104Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG104Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG104Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG104Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG104Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG104Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG104Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG104Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG104Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4005) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG105Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG105Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG105Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG105Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG105Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG105Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG105Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG105Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG105Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG105Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG105Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG105Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4006) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG106Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG106Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG106Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG106Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG106Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG106Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG106Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG106Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG106Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG106Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG106Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG106Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4007) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG107Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG107Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG107Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG107Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG107Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG107Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG107Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG107Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG107Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG107Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG107Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG107Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 4008) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG108Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG108Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG108Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG108Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG108Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG108Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG108Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG108Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG108Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG108Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG108Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG108Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5001) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG201Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG201Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG201Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG201Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG201Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG201Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG201Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG201Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG201Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG201Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG201Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG201Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5002) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG202Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG202Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG202Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG202Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG202Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG202Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG202Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG202Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG202Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG202Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG202Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG202Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5003) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG203Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG203Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG203Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG203Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG203Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG203Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG203Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG203Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG203Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG203Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG203Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG203Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5004) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG204Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG204Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG204Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG204Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG204Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG204Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG204Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG204Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG204Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG204Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG204Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG204Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5005) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG205Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG205Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG205Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG205Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG205Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG205Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG205Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG205Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG205Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG205Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG205Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG205Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5006) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG206Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG206Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG206Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG206Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG206Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG206Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG206Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG206Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG206Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG206Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG206Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG206Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5007) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG207Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG207Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG207Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG207Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG207Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG207Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG207Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG207Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG207Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG207Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG207Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG207Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 5008) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG208Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG208Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG208Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG208Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG208Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG208Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG208Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG208Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG208Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG208Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG208Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG208Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6001) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG301Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG301Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG301Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG301Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG301Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG301Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG301Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG301Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG301Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG301Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG301Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG301Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6002) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG302Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG302Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG302Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG302Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG302Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG302Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG302Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG302Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG302Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG302Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG302Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG302Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6003) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG303Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG303Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG303Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG303Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG303Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG303Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG303Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG303Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG303Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG303Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG303Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG303Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6004) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG304Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG304Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG304Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG304Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG304Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG304Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG304Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG304Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG304Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG304Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG304Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG304Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6005) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG305Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG305Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG305Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG305Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG305Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG305Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG305Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG305Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG305Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG305Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG305Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG305Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6006) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG306Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG306Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG306Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG306Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG306Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG306Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG306Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG306Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG306Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG306Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG306Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG306Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6007) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG307Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG307Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG307Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG307Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG307Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG307Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG307Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG307Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG307Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG307Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG307Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG307Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 6008) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG308Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG308Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG308Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG308Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG308Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG308Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG308Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG308Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG308Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG308Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG308Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG308Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7001) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB01Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB01Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB01Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB01Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB01Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB01Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB01Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB01Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB01Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB01Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB01Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB01Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7002) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB02Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB02Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB02Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB02Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB02Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB02Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB02Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB02Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB02Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB02Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB02Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB02Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7003) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB03Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB03Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB03Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB03Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB03Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB03Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB03Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB03Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB03Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB03Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB03Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB03Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7004) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB04Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB04Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB04Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB04Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB04Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB04Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB04Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB04Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB04Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB04Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB04Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB04Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7005) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB05Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB05Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB05Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB05Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB05Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB05Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB05Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB05Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB05Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB05Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB05Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB05Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7006) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB06Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB06Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB06Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB06Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB06Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB06Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB06Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB06Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB06Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB06Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB06Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB06Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7007) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB07Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB07Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB07Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB07Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB07Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB07Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB07Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB07Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB07Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB07Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB07Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB07Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 7008) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkFB08Added.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameFB08Added;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistFB08Added;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearFB08Added.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementFB08Added;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityFB08Added;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB08Added) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostFB08Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostFB08Added.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostFB08Added) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostFB08Added.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseFB08Added) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
        }
	}
	
// --------------- DISABLE FUNCTIONS ---------------
    public void ArtworkPagesMainDisable() {
        UIArtworkPagesBackground.enabled = false;
		UIArtworkPagesField.enabled = false;
		UIArtworkPagesTitleInput.enabled = false;
		UIArtworkPagesArtist.enabled = false;
		UIArtworkPagesArtistInput.enabled = false;
		UIArtworkPagesYear.enabled = false;
		UIArtworkPagesYearInput.enabled = false;
		UIArtworkPagesStyle.enabled = false;
		UIArtworkPagesStyleInput.enabled = false;
        UIArtworkPagesCountry.enabled = false;
		UIArtworkPagesCountryInput.enabled = false;
		UIArtworkPagesText.enabled = false;
		UIArtworkPagesLearnButton.enabled = false;
		UIArtworkPagesLearnButtonText.enabled = false;
		UIArtworkPagesBackButton.enabled = false;
    }
    
	public void ArtworkPagesButtonsDisable() {
		UIArtworkPagesPurchaseButton.enabled = false;
		UIArtworkPagesPurchaseButtonText.enabled = false;
		UIArtworkPagesCannotBuyButton.enabled = false;
		UIArtworkPagesCannotBuyButtonText.enabled = false;
		UIArtworkPagesBoughtButton.enabled = false;
		UIArtworkPagesBoughtButtonText.enabled = false;
	}
	
	public void ArtworkPagesArtworkDisable() {
		UIArtworkPagesArtworkFB01.enabled = false;
		UIArtworkPagesArtworkFB02.enabled = false;
		UIArtworkPagesArtworkFB03.enabled = false;
		UIArtworkPagesArtworkFB04.enabled = false;
		UIArtworkPagesArtworkFB05.enabled = false;
		UIArtworkPagesArtworkFB06.enabled = false;
		UIArtworkPagesArtworkFB07.enabled = false;
		UIArtworkPagesArtworkFB08.enabled = false;
		UIArtworkPagesArtworkFB09.enabled = false;
		UIArtworkPagesArtworkFB10.enabled = false;
		UIArtworkPagesArtworkFB11.enabled = false;
		UIArtworkPagesArtworkFB12.enabled = false;
		UIArtworkPagesArtworkFB13.enabled = false;
		UIArtworkPagesArtworkFB14.enabled = false;
		UIArtworkPagesArtworkFB15.enabled = false;
        UIArtworkPagesArtworkF101Added.enabled = false;
		UIArtworkPagesArtworkF102Added.enabled = false;
		UIArtworkPagesArtworkF103Added.enabled = false;
		UIArtworkPagesArtworkF104Added.enabled = false;
		UIArtworkPagesArtworkF105Added.enabled = false;
		UIArtworkPagesArtworkF106Added.enabled = false;
		UIArtworkPagesArtworkF107Added.enabled = false;
		UIArtworkPagesArtworkF108Added.enabled = false;
        UIArtworkPagesArtworkF201Added.enabled = false;
		UIArtworkPagesArtworkF202Added.enabled = false;
		UIArtworkPagesArtworkF203Added.enabled = false;
		UIArtworkPagesArtworkF204Added.enabled = false;
		UIArtworkPagesArtworkF205Added.enabled = false;
		UIArtworkPagesArtworkF206Added.enabled = false;
		UIArtworkPagesArtworkF207Added.enabled = false;
		UIArtworkPagesArtworkF208Added.enabled = false;
        UIArtworkPagesArtworkF301Added.enabled = false;
		UIArtworkPagesArtworkF302Added.enabled = false;
		UIArtworkPagesArtworkF303Added.enabled = false;
		UIArtworkPagesArtworkF304Added.enabled = false;
		UIArtworkPagesArtworkF305Added.enabled = false;
		UIArtworkPagesArtworkF306Added.enabled = false;
		UIArtworkPagesArtworkF307Added.enabled = false;
		UIArtworkPagesArtworkF308Added.enabled = false;
        UIArtworkPagesArtworkG101Added.enabled = false;
		UIArtworkPagesArtworkG102Added.enabled = false;
		UIArtworkPagesArtworkG203Added.enabled = false;
		UIArtworkPagesArtworkG104Added.enabled = false;
		UIArtworkPagesArtworkG105Added.enabled = false;
		UIArtworkPagesArtworkG106Added.enabled = false;
		UIArtworkPagesArtworkG107Added.enabled = false;
		UIArtworkPagesArtworkG108Added.enabled = false;
        UIArtworkPagesArtworkG201Added.enabled = false;
		UIArtworkPagesArtworkG202Added.enabled = false;
		UIArtworkPagesArtworkG203Added.enabled = false;
		UIArtworkPagesArtworkG204Added.enabled = false;
		UIArtworkPagesArtworkG205Added.enabled = false;
		UIArtworkPagesArtworkG206Added.enabled = false;
		UIArtworkPagesArtworkG207Added.enabled = false;
		UIArtworkPagesArtworkG208Added.enabled = false;
        UIArtworkPagesArtworkG301Added.enabled = false;
		UIArtworkPagesArtworkG302Added.enabled = false;
		UIArtworkPagesArtworkG303Added.enabled = false;
		UIArtworkPagesArtworkG304Added.enabled = false;
		UIArtworkPagesArtworkG305Added.enabled = false;
		UIArtworkPagesArtworkG306Added.enabled = false;
		UIArtworkPagesArtworkG307Added.enabled = false;
		UIArtworkPagesArtworkG308Added.enabled = false;
        UIArtworkPagesArtworkFB01Added.enabled = false;
		UIArtworkPagesArtworkFB02Added.enabled = false;
		UIArtworkPagesArtworkFB03Added.enabled = false;
		UIArtworkPagesArtworkFB04Added.enabled = false;
		UIArtworkPagesArtworkFB05Added.enabled = false;
		UIArtworkPagesArtworkFB06Added.enabled = false;
		UIArtworkPagesArtworkFB07Added.enabled = false;
		UIArtworkPagesArtworkFB08Added.enabled = false;
        UIArtworkPagesArtworkFB09Added.enabled = false;
		UIArtworkPagesArtworkFB10Added.enabled = false;
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}