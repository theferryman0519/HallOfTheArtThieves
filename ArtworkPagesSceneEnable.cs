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

public class ArtworkPagesSceneEnable : MonoBehaviour {
		
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
	
	// Page F1
	public Image UIArtworkPagesArtworkF101;
	public Image UIArtworkPagesArtworkF102;
	public Image UIArtworkPagesArtworkF103;
	public Image UIArtworkPagesArtworkF104;
	public Image UIArtworkPagesArtworkF105;
	public Image UIArtworkPagesArtworkF106;
	public Image UIArtworkPagesArtworkF107;
	public Image UIArtworkPagesArtworkF108;
	public Image UIArtworkPagesArtworkF109;
	public Image UIArtworkPagesArtworkF110;
	public Image UIArtworkPagesArtworkF111;
	public Image UIArtworkPagesArtworkF112;
	public Image UIArtworkPagesArtworkF113;
	public Image UIArtworkPagesArtworkF114;
	public Image UIArtworkPagesArtworkF115;
	
	// Page F2
	public Image UIArtworkPagesArtworkF201;
	public Image UIArtworkPagesArtworkF202;
	public Image UIArtworkPagesArtworkF203;
	public Image UIArtworkPagesArtworkF204;
	public Image UIArtworkPagesArtworkF205;
	public Image UIArtworkPagesArtworkF206;
	public Image UIArtworkPagesArtworkF207;
	public Image UIArtworkPagesArtworkF208;
	public Image UIArtworkPagesArtworkF209;
	public Image UIArtworkPagesArtworkF210;
	public Image UIArtworkPagesArtworkF211;
	public Image UIArtworkPagesArtworkF212;
	public Image UIArtworkPagesArtworkF213;
	public Image UIArtworkPagesArtworkF214;
	public Image UIArtworkPagesArtworkF215;
	
	// Page F3
	public Image UIArtworkPagesArtworkF301;
	public Image UIArtworkPagesArtworkF302;
	public Image UIArtworkPagesArtworkF303;
	public Image UIArtworkPagesArtworkF304;
	public Image UIArtworkPagesArtworkF305;
	public Image UIArtworkPagesArtworkF306;
	public Image UIArtworkPagesArtworkF307;
	public Image UIArtworkPagesArtworkF308;
	public Image UIArtworkPagesArtworkF309;
	public Image UIArtworkPagesArtworkF310;
	public Image UIArtworkPagesArtworkF311;
	public Image UIArtworkPagesArtworkF312;
	public Image UIArtworkPagesArtworkF313;
	public Image UIArtworkPagesArtworkF314;
	public Image UIArtworkPagesArtworkF315;
	
	// Page G1
	public Image UIArtworkPagesArtworkG101;
	public Image UIArtworkPagesArtworkG102;
	public Image UIArtworkPagesArtworkG103;
	public Image UIArtworkPagesArtworkG104;
	public Image UIArtworkPagesArtworkG105;
	public Image UIArtworkPagesArtworkG106;
	public Image UIArtworkPagesArtworkG107;
	public Image UIArtworkPagesArtworkG108;
	public Image UIArtworkPagesArtworkG109;
	public Image UIArtworkPagesArtworkG110;
	public Image UIArtworkPagesArtworkG111;
	public Image UIArtworkPagesArtworkG112;
	public Image UIArtworkPagesArtworkG113;
	public Image UIArtworkPagesArtworkG114;
	public Image UIArtworkPagesArtworkG115;
	
	// Page G2
	public Image UIArtworkPagesArtworkG201;
	public Image UIArtworkPagesArtworkG202;
	public Image UIArtworkPagesArtworkG203;
	public Image UIArtworkPagesArtworkG204;
	public Image UIArtworkPagesArtworkG205;
	public Image UIArtworkPagesArtworkG206;
	public Image UIArtworkPagesArtworkG207;
	public Image UIArtworkPagesArtworkG208;
	public Image UIArtworkPagesArtworkG209;
	public Image UIArtworkPagesArtworkG210;
	public Image UIArtworkPagesArtworkG211;
	public Image UIArtworkPagesArtworkG212;
	public Image UIArtworkPagesArtworkG213;
	public Image UIArtworkPagesArtworkG214;
	public Image UIArtworkPagesArtworkG215;
    
    // Page G3
	public Image UIArtworkPagesArtworkG301;
	public Image UIArtworkPagesArtworkG302;
	public Image UIArtworkPagesArtworkG303;
	public Image UIArtworkPagesArtworkG304;
	public Image UIArtworkPagesArtworkG305;
	public Image UIArtworkPagesArtworkG306;
	public Image UIArtworkPagesArtworkG307;
	public Image UIArtworkPagesArtworkG308;
	public Image UIArtworkPagesArtworkG309;
	public Image UIArtworkPagesArtworkG310;
	public Image UIArtworkPagesArtworkG311;
	public Image UIArtworkPagesArtworkG312;
	public Image UIArtworkPagesArtworkG313;
	public Image UIArtworkPagesArtworkG314;
	public Image UIArtworkPagesArtworkG315;
	
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
            if (MainArtworkPageButtons.IdentifyArtworkButton == 101) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF101.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF101;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF101;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF101.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF101;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF101;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF101) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF101) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF101.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF101) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF101.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF101) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 102) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF102.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF102;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF102;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF102.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF102;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF102;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF102) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF102) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF102.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF102) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF102.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF102) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 103) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF103.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF103;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF103;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF103.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF103;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF103;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF103) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF103) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF103.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF103) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF103.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF103) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 104) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF104.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF104;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF104;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF104.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF104;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF104;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF104) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF104) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF104.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF104) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF104.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF104) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 105) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF105.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF105;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF105;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF105.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF105;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF105;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF105) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF105) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF105.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF105) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF105.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF105) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 106) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF106.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF106;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF106;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF106.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF106;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF106;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF106) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF106) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF106.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF106) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF106.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF106) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 107) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF107.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF107;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF107;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF107.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF107;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF107;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF107) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF107) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF107.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF107) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF107.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF107) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 108) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF108.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF108;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF108;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF108.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF108;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF108;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF108) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF108) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF108.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF108) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF108.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF108) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 109) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF109.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF109;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF109;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF109.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF109;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF109;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF109) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF109) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF109.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF109) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF109.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF109) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 110) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF110.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF110;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF110;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF110.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF110;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF110;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF110) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF110) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF110.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF110) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF110.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF110) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 111) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF111.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF111;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF111;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF111.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF111;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF111;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF111) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF111) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF111.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF111) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF111.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF111) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 112) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF112.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF112;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF112;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF112.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF112;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF112;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF112) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF112) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF112.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF112) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF112.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF112) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 113) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF113.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF113;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF113;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF113.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF113;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF113;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF113) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF113) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF113.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF113) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF113.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF113) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 114) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF114.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF114;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF114;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF114.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF114;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF114;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF114) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF114) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF114.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF114) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF114.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF114) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 115) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF115.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF115;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF115;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF115.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF115;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF115;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF115) == 0) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesPurchaseButton.enabled = true;
                    UIArtworkPagesPurchaseButtonText.enabled = true;
                    UIArtworkPagesPurchaseButtonText.text = "Buy the First Floor 15th Artwork";
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF115) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 201) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF201.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF201;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF201;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF201.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF201;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF201;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF201) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF201) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF201.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF201) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF201.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF201) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 202) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF202.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF202;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF202;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF202.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF202;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF202;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF202) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF202) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF202.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF202) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF202.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF202) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 203) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF203.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF203;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF203;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF203.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF203;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF203;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF203) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF203) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF203.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF203) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF203.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF203) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 204) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF204.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF204;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF204;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF204.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF204;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF204;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF204) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF204) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF204.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF204) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF204.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF204) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 205) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF205.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF205;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF205;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF205.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF205;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF205;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF205) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF205) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF205.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF205) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF205.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF205) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 206) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF206.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF206;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF206;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF206.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF206;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF206;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF206) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF206) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF206.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF206) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF206.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF206) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 207) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF207.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF207;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF207;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF207.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF207;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF207;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF207) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF207) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF207.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF207) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF207.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF207) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 208) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF208.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF208;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF208;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF208.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF208;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF208;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF208) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF208) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF208.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF208) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF208.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF208) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 209) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF209.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF209;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF209;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF209.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF209;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF209;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF209) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF209) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF209.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF209) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF209.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF209) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 210) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF210.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF210;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF210;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF210.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF210;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF210;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF210) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF210) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF210.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF210) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF210.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF210) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 211) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF211.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF211;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF211;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF211.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF211;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF211;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF211) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF211) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF211.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF211) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF211.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF211) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 212) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF212.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF212;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF212;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF212.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF212;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF212;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF212) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF212) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF212.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF212) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF212.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF212) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 213) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF213.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF213;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF213;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF213.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF213;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF213;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF213) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF213) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF213.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF213) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF213.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF213) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 214) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF214.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF214;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF214;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF214.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF214;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF214;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF214) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF214) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF214.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF214) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF214.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF214) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 215) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF215.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF215;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF215;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF215.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF215;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF215;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF215) == 0) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesPurchaseButton.enabled = true;
                    UIArtworkPagesPurchaseButtonText.enabled = true;
                    UIArtworkPagesPurchaseButtonText.text = "Buy the Second Floor 15th Artwork";
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF215) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 301) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF301.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF301;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF301;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF301.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF301;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF301;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF301) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF301) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF301.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF301) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF301.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF301) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 302) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF302.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF302;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF302;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF302.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF302;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF302;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF302) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF302) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF302.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF302) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF302.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF302) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 303) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF303.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF303;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF303;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF303.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF303;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF303;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF303) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF303) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF303.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF303) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF303.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF303) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 304) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF304.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF304;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF304;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF304.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF304;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF304;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF304) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF304) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF304.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF304) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF304.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF304) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 305) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF305.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF305;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF305;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF305.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF305;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF305;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF305) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF305) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF305.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF305) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF305.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF305) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 306) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF306.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF306;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF306;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF306.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF306;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF306;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF306) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF306) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF306.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF306) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF306.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF306) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 307) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF307.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF307;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF307;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF307.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF307;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF307;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF307) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF307) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF307.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF307) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF307.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF307) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 308) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF308.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF308;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF308;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF308.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF308;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF308;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF308) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF308) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF308.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF308) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF308.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF308) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 309) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF309.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF309;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF309;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF309.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF309;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF309;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF309) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF309) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF309.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF309) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF309.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF309) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 310) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF310.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF310;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF310;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF310.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF310;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF310;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF310) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF310) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF310.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF310) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF310.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF310) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 311) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF311.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF311;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF311;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF311.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF311;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF311;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF311) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF311) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF311.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF311) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF311.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF311) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 312) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF312.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF312;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF312;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF312.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF312;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF312;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF312) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF312) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF312.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF312) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF312.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF312) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 313) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF313.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF313;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF313;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF313.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF313;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF313;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF313) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF313) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF313.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF313) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF313.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF313) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 314) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF314.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF314;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF314;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF314.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF314;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF314;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF314) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostF314) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostF314.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostF314) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostF314.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF314) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 315) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkF315.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameF315;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistF315;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearF315.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementF315;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityF315;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF315) == 0) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesPurchaseButton.enabled = true;
                    UIArtworkPagesPurchaseButtonText.enabled = true;
                    UIArtworkPagesPurchaseButtonText.text = "Buy the Third Floor 15th Artwork";
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseF315) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 401) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG101.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG101;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG101;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG101.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG101;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG101;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG101) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG101) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG101.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG101) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG101.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG101) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 402) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG102.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG102;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG102;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG102.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG102;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG102;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG102) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG102) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG102.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG102) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG102.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG102) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 403) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG103.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG103;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG103;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG103.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG103;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG103;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG103) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG103) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG103.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG103) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG103.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG103) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 404) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG104.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG104;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG104;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG104.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG104;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG104;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG104) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG104) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG104.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG104) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG104.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG104) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 405) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG105.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG105;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG105;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG105.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG105;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG105;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG105) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG105) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG105.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG105) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG105.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG105) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 406) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG106.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG106;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG106;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG106.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG106;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG106;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG106) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG106) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG106.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG106) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG106.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG106) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 407) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG107.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG107;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG107;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG107.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG107;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG107;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG107) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG107) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG107.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG107) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG107.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG107) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 408) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG108.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG108;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG108;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG108.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG108;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG108;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG108) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG108) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG108.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG108) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG108.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG108) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 409) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG109.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG109;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG109;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG109.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG109;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG109;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG109) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG109) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG109.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG109) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG109.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG109) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 410) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG110.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG110;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG110;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG110.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG110;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG110;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG110) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG110) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG110.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG110) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG110.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG110) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 411) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG111.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG111;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG111;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG111.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG111;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG111;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG111) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG111) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG111.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG111) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG111.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG111) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 412) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG112.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG112;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG112;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG112.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG112;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG112;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG112) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG112) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG112.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG112) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG112.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG112) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 413) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG113.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG113;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG113;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG113.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG113;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG113;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG113) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG113) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG113.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG113) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG113.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG113) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 414) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG114.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG114;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG114;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG114.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG114;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG114;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG114) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG114) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG114.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG114) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG114.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG114) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 415) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG115.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG115;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG115;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG115.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG115;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG115;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG115) == 0) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesPurchaseButton.enabled = true;
                    UIArtworkPagesPurchaseButtonText.enabled = true;
                    UIArtworkPagesPurchaseButtonText.text = "Buy the First Garden 15th Artwork";
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG115) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 501) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG201.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG201;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG201;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG201.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG201;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG201;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG201) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG201) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG201.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG201) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG201.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG201) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 502) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG202.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG202;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG202;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG202.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG202;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG202;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG202) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG202) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG202.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG202) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG202.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG202) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 503) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG203.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG203;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG203;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG203.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG203;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG203;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG203) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG203) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG203.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG203) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG203.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG203) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 504) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG204.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG204;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG204;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG204.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG204;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG204;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG204) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG204) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG204.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG204) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG204.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG204) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 505) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG205.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG205;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG205;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG205.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG205;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG205;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG205) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG205) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG205.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG205) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG205.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG205) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 506) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG206.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG206;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG206;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG206.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG206;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG206;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG206) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG206) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG206.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG206) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG206.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG206) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 507) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG207.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG207;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG207;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG207.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG207;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG207;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG207) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG207) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG207.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG207) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG207.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG207) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 508) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG208.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG208;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG208;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG208.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG208;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG208;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG208) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG208) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG208.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG208) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG208.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG208) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 509) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG209.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG209;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG209;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG209.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG209;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG209;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG209) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG209) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG209.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG209) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG209.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG209) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 510) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG210.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG210;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG210;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG210.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG210;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG210;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG210) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG210) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG210.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG210) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG210.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG210) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 511) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG211.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG211;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG211;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG211.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG211;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG211;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG211) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG211) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG211.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG211) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG211.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG211) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 512) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG212.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG212;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG212;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG212.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG212;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG212;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG212) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG212) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG212.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG212) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG212.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG212) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 513) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG213.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG213;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG213;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG213.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG213;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG213;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG213) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG213) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG213.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG213) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG213.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG213) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 514) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG214.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG214;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG214;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG214.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG214;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG214;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG214) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG214) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG214.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG214) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG214.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG214) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 515) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG215.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG215;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG215;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG215.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG215;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG215;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG215) == 0) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesPurchaseButton.enabled = true;
                    UIArtworkPagesPurchaseButtonText.enabled = true;
                    UIArtworkPagesPurchaseButtonText.text = "Buy the Second Garden 15th Artwork";
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG215) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }
            
            if (MainArtworkPageButtons.IdentifyArtworkButton == 701) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG301.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG301;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG301;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG301.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG301;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG301;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG301) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG301) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG301.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG301) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG301.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG301) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 702) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG302.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG302;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG302;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG302.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG302;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG302;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG302) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG302) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG302.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG302) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG302.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG302) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 703) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG303.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG303;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG303;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG303.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG303;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG303;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG303) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG303) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG303.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG303) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG303.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG303) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 704) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG304.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG304;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG304;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG304.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG304;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG304;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG304) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG304) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG304.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG304) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG304.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG304) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 705) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG305.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG305;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG305;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG305.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG305;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG305;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG305) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG305) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG305.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG305) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG305.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG305) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 706) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG306.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG306;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG306;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG306.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG306;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG306;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG306) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG306) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG306.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG306) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG306.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG306) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 707) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG307.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG307;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG307;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG307.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG307;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG307;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG307) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG307) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG307.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG307) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG307.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG307) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 708) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG308.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG308;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG308;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG308.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG308;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG308;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG308) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG308) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG308.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG308) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG308.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG308) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 709) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG309.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG309;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG309;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG309.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG309;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG309;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG309) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG309) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG309.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG309) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG309.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG309) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 710) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG310.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG310;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG310;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG310.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG310;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG310;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG310) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG310) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG310.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG310) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG310.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG310) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 711) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG311.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG311;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG311;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG311.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG311;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG311;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG311) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG311) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG311.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG311) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG311.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG311) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 712) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG312.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG312;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG312;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG312.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG312;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG312;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG312) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG312) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG312.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG312) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG312.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG312) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 713) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG313.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG313;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG313;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG313.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG313;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG313;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG313) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG313) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG313.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG313) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG313.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG313) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 714) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG314.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG314;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG314;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG314.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG314;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG314;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG314) == 0) {
                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) < ArtworkInformation.ArtPieceLoanCostG314) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesCannotBuyButton.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.enabled = true;
                        UIArtworkPagesCannotBuyButtonText.text = "Need " + ArtworkInformation.ArtPieceLoanCostG314.ToString("#,#") + " Coins";
                    }

                    if (int.Parse(DataFillingInformation.DBBankAccountAmount) >= ArtworkInformation.ArtPieceLoanCostG314) {
                        ArtworkPagesButtonsDisable();
                        UIArtworkPagesPurchaseButton.enabled = true;
                        UIArtworkPagesPurchaseButtonText.enabled = true;
                        UIArtworkPagesPurchaseButtonText.text = "Purchase for " + ArtworkInformation.ArtPieceLoanCostG314.ToString("#,#") + " Coins";
                    }
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG314) >= 1) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesBoughtButton.enabled = true;
                    UIArtworkPagesBoughtButtonText.enabled = true;
                }
            }

            if (MainArtworkPageButtons.IdentifyArtworkButton == 715) {
                ArtworkPagesArtworkDisable();
                UIArtworkPagesArtworkG315.enabled = true;
                UIArtworkPagesTitleInput.text = ArtworkInformation.ArtPieceNameG315;
                UIArtworkPagesArtistInput.text = ArtworkInformation.ArtPieceArtistG315;
                UIArtworkPagesYearInput.text = ArtworkInformation.ArtPieceYearG315.ToString();
                UIArtworkPagesStyleInput.text = ArtworkInformation.ArtPieceMovementG315;
                UIArtworkPagesCountryInput.text = ArtworkInformation.ArtPieceNationalityG315;

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG315) == 0) {
                    ArtworkPagesButtonsDisable();
                    UIArtworkPagesPurchaseButton.enabled = true;
                    UIArtworkPagesPurchaseButtonText.enabled = true;
                    UIArtworkPagesPurchaseButtonText.text = "Buy the Third Garden 15th Artwork";
                }

                if (int.Parse(DataFillingInformation.DBArtworkPurchaseG315) >= 1) {
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
		UIArtworkPagesArtworkF101.enabled = false;
		UIArtworkPagesArtworkF102.enabled = false;
		UIArtworkPagesArtworkF103.enabled = false;
		UIArtworkPagesArtworkF104.enabled = false;
		UIArtworkPagesArtworkF105.enabled = false;
		UIArtworkPagesArtworkF106.enabled = false;
		UIArtworkPagesArtworkF107.enabled = false;
		UIArtworkPagesArtworkF108.enabled = false;
		UIArtworkPagesArtworkF109.enabled = false;
		UIArtworkPagesArtworkF110.enabled = false;
		UIArtworkPagesArtworkF111.enabled = false;
		UIArtworkPagesArtworkF112.enabled = false;
		UIArtworkPagesArtworkF113.enabled = false;
		UIArtworkPagesArtworkF114.enabled = false;
		UIArtworkPagesArtworkF115.enabled = false;
		UIArtworkPagesArtworkF201.enabled = false;
		UIArtworkPagesArtworkF202.enabled = false;
		UIArtworkPagesArtworkF203.enabled = false;
		UIArtworkPagesArtworkF204.enabled = false;
		UIArtworkPagesArtworkF205.enabled = false;
		UIArtworkPagesArtworkF206.enabled = false;
		UIArtworkPagesArtworkF207.enabled = false;
		UIArtworkPagesArtworkF208.enabled = false;
		UIArtworkPagesArtworkF209.enabled = false;
		UIArtworkPagesArtworkF210.enabled = false;
		UIArtworkPagesArtworkF211.enabled = false;
		UIArtworkPagesArtworkF212.enabled = false;
		UIArtworkPagesArtworkF213.enabled = false;
		UIArtworkPagesArtworkF214.enabled = false;
		UIArtworkPagesArtworkF215.enabled = false;
		UIArtworkPagesArtworkF301.enabled = false;
		UIArtworkPagesArtworkF302.enabled = false;
		UIArtworkPagesArtworkF303.enabled = false;
		UIArtworkPagesArtworkF304.enabled = false;
		UIArtworkPagesArtworkF305.enabled = false;
		UIArtworkPagesArtworkF306.enabled = false;
		UIArtworkPagesArtworkF307.enabled = false;
		UIArtworkPagesArtworkF308.enabled = false;
		UIArtworkPagesArtworkF309.enabled = false;
		UIArtworkPagesArtworkF310.enabled = false;
		UIArtworkPagesArtworkF311.enabled = false;
		UIArtworkPagesArtworkF312.enabled = false;
		UIArtworkPagesArtworkF313.enabled = false;
		UIArtworkPagesArtworkF314.enabled = false;
		UIArtworkPagesArtworkF315.enabled = false;
		UIArtworkPagesArtworkG101.enabled = false;
		UIArtworkPagesArtworkG102.enabled = false;
		UIArtworkPagesArtworkG103.enabled = false;
		UIArtworkPagesArtworkG104.enabled = false;
		UIArtworkPagesArtworkG105.enabled = false;
		UIArtworkPagesArtworkG106.enabled = false;
		UIArtworkPagesArtworkG107.enabled = false;
		UIArtworkPagesArtworkG108.enabled = false;
		UIArtworkPagesArtworkG109.enabled = false;
		UIArtworkPagesArtworkG110.enabled = false;
		UIArtworkPagesArtworkG111.enabled = false;
		UIArtworkPagesArtworkG112.enabled = false;
		UIArtworkPagesArtworkG113.enabled = false;
		UIArtworkPagesArtworkG114.enabled = false;
		UIArtworkPagesArtworkG115.enabled = false;
		UIArtworkPagesArtworkG201.enabled = false;
		UIArtworkPagesArtworkG202.enabled = false;
		UIArtworkPagesArtworkG203.enabled = false;
		UIArtworkPagesArtworkG204.enabled = false;
		UIArtworkPagesArtworkG205.enabled = false;
		UIArtworkPagesArtworkG206.enabled = false;
		UIArtworkPagesArtworkG207.enabled = false;
		UIArtworkPagesArtworkG208.enabled = false;
		UIArtworkPagesArtworkG209.enabled = false;
		UIArtworkPagesArtworkG210.enabled = false;
		UIArtworkPagesArtworkG211.enabled = false;
		UIArtworkPagesArtworkG212.enabled = false;
		UIArtworkPagesArtworkG213.enabled = false;
		UIArtworkPagesArtworkG214.enabled = false;
		UIArtworkPagesArtworkG215.enabled = false;
        UIArtworkPagesArtworkG301.enabled = false;
		UIArtworkPagesArtworkG302.enabled = false;
		UIArtworkPagesArtworkG303.enabled = false;
		UIArtworkPagesArtworkG304.enabled = false;
		UIArtworkPagesArtworkG305.enabled = false;
		UIArtworkPagesArtworkG306.enabled = false;
		UIArtworkPagesArtworkG307.enabled = false;
		UIArtworkPagesArtworkG308.enabled = false;
		UIArtworkPagesArtworkG309.enabled = false;
		UIArtworkPagesArtworkG310.enabled = false;
		UIArtworkPagesArtworkG311.enabled = false;
		UIArtworkPagesArtworkG312.enabled = false;
		UIArtworkPagesArtworkG313.enabled = false;
		UIArtworkPagesArtworkG314.enabled = false;
		UIArtworkPagesArtworkG315.enabled = false;
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}