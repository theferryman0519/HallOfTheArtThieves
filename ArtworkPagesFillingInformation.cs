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

public class ArtworkPagesFillingInformation : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// F1 Selection Texts
	public Text UIArtworksButtonF101Text;
	public Text UIArtworksButtonF102Text;
	public Text UIArtworksButtonF103Text;
	public Text UIArtworksButtonF104Text;
	public Text UIArtworksButtonF105Text;
	public Text UIArtworksButtonF106Text;
	public Text UIArtworksButtonF107Text;
	public Text UIArtworksButtonF108Text;
	public Text UIArtworksButtonF109Text;
	public Text UIArtworksButtonF110Text;
	public Text UIArtworksButtonF111Text;
	public Text UIArtworksButtonF112Text;
	public Text UIArtworksButtonF113Text;
	public Text UIArtworksButtonF114Text;
	public Text UIArtworksButtonF115Text;
    
    // F2 Selection Texts
	public Text UIArtworksButtonF201Text;
	public Text UIArtworksButtonF202Text;
	public Text UIArtworksButtonF203Text;
	public Text UIArtworksButtonF204Text;
	public Text UIArtworksButtonF205Text;
	public Text UIArtworksButtonF206Text;
	public Text UIArtworksButtonF207Text;
	public Text UIArtworksButtonF208Text;
	public Text UIArtworksButtonF209Text;
	public Text UIArtworksButtonF210Text;
	public Text UIArtworksButtonF211Text;
	public Text UIArtworksButtonF212Text;
	public Text UIArtworksButtonF213Text;
	public Text UIArtworksButtonF214Text;
	public Text UIArtworksButtonF215Text;
    
    // F3 Selection Texts
	public Text UIArtworksButtonF301Text;
	public Text UIArtworksButtonF302Text;
	public Text UIArtworksButtonF303Text;
	public Text UIArtworksButtonF304Text;
	public Text UIArtworksButtonF305Text;
	public Text UIArtworksButtonF306Text;
	public Text UIArtworksButtonF307Text;
	public Text UIArtworksButtonF308Text;
	public Text UIArtworksButtonF309Text;
	public Text UIArtworksButtonF310Text;
	public Text UIArtworksButtonF311Text;
	public Text UIArtworksButtonF312Text;
	public Text UIArtworksButtonF313Text;
	public Text UIArtworksButtonF314Text;
	public Text UIArtworksButtonF315Text;
    
    // G1 Selection Texts
	public Text UIArtworksButtonG101Text;
	public Text UIArtworksButtonG102Text;
	public Text UIArtworksButtonG103Text;
	public Text UIArtworksButtonG104Text;
	public Text UIArtworksButtonG105Text;
	public Text UIArtworksButtonG106Text;
	public Text UIArtworksButtonG107Text;
	public Text UIArtworksButtonG108Text;
	public Text UIArtworksButtonG109Text;
	public Text UIArtworksButtonG110Text;
	public Text UIArtworksButtonG111Text;
	public Text UIArtworksButtonG112Text;
	public Text UIArtworksButtonG113Text;
	public Text UIArtworksButtonG114Text;
	public Text UIArtworksButtonG115Text;
    
    // G2 Selection Texts
	public Text UIArtworksButtonG201Text;
	public Text UIArtworksButtonG202Text;
	public Text UIArtworksButtonG203Text;
	public Text UIArtworksButtonG204Text;
	public Text UIArtworksButtonG205Text;
	public Text UIArtworksButtonG206Text;
	public Text UIArtworksButtonG207Text;
	public Text UIArtworksButtonG208Text;
	public Text UIArtworksButtonG209Text;
	public Text UIArtworksButtonG210Text;
	public Text UIArtworksButtonG211Text;
	public Text UIArtworksButtonG212Text;
	public Text UIArtworksButtonG213Text;
	public Text UIArtworksButtonG214Text;
	public Text UIArtworksButtonG215Text;
    
    // G3 Selection Texts
	public Text UIArtworksButtonG301Text;
	public Text UIArtworksButtonG302Text;
	public Text UIArtworksButtonG303Text;
	public Text UIArtworksButtonG304Text;
	public Text UIArtworksButtonG305Text;
	public Text UIArtworksButtonG306Text;
	public Text UIArtworksButtonG307Text;
	public Text UIArtworksButtonG308Text;
	public Text UIArtworksButtonG309Text;
	public Text UIArtworksButtonG310Text;
	public Text UIArtworksButtonG311Text;
	public Text UIArtworksButtonG312Text;
	public Text UIArtworksButtonG313Text;
	public Text UIArtworksButtonG314Text;
	public Text UIArtworksButtonG315Text;
    
    // FB Selection Texts
	public Text UIArtworksButtonFB01Text;
	public Text UIArtworksButtonFB02Text;
	public Text UIArtworksButtonFB03Text;
	public Text UIArtworksButtonFB04Text;
	public Text UIArtworksButtonFB05Text;
	public Text UIArtworksButtonFB06Text;
	public Text UIArtworksButtonFB07Text;
	public Text UIArtworksButtonFB08Text;
	public Text UIArtworksButtonFB09Text;
	public Text UIArtworksButtonFB10Text;
	public Text UIArtworksButtonFB11Text;
	public Text UIArtworksButtonFB12Text;
	public Text UIArtworksButtonFB13Text;
	public Text UIArtworksButtonFB14Text;
	public Text UIArtworksButtonFB15Text;
    
    // F1 Bonus Selection Texts
    public Text UIArtworksButtonF101AddedText;
    public Text UIArtworksButtonF102AddedText;
    public Text UIArtworksButtonF103AddedText;
    public Text UIArtworksButtonF104AddedText;
    public Text UIArtworksButtonF105AddedText;
    public Text UIArtworksButtonF106AddedText;
    public Text UIArtworksButtonF107AddedText;
    public Text UIArtworksButtonF108AddedText;
    
    // F2 Bonus Selection Texts
    public Text UIArtworksButtonF201AddedText;
    public Text UIArtworksButtonF202AddedText;
    public Text UIArtworksButtonF203AddedText;
    public Text UIArtworksButtonF204AddedText;
    public Text UIArtworksButtonF205AddedText;
    public Text UIArtworksButtonF206AddedText;
    public Text UIArtworksButtonF207AddedText;
    public Text UIArtworksButtonF208AddedText;
    
    // F3 Bonus Selection Texts
    public Text UIArtworksButtonF301AddedText;
    public Text UIArtworksButtonF302AddedText;
    public Text UIArtworksButtonF303AddedText;
    public Text UIArtworksButtonF304AddedText;
    public Text UIArtworksButtonF305AddedText;
    public Text UIArtworksButtonF306AddedText;
    public Text UIArtworksButtonF307AddedText;
    public Text UIArtworksButtonF308AddedText;
    
    // G1 Bonus Selection Texts
    public Text UIArtworksButtonG101AddedText;
    public Text UIArtworksButtonG102AddedText;
    public Text UIArtworksButtonG103AddedText;
    public Text UIArtworksButtonG104AddedText;
    public Text UIArtworksButtonG105AddedText;
    public Text UIArtworksButtonG106AddedText;
    public Text UIArtworksButtonG107AddedText;
    public Text UIArtworksButtonG108AddedText;
    
    // G2 Bonus Selection Texts
    public Text UIArtworksButtonG201AddedText;
    public Text UIArtworksButtonG202AddedText;
    public Text UIArtworksButtonG203AddedText;
    public Text UIArtworksButtonG204AddedText;
    public Text UIArtworksButtonG205AddedText;
    public Text UIArtworksButtonG206AddedText;
    public Text UIArtworksButtonG207AddedText;
    public Text UIArtworksButtonG208AddedText;
    
    // G3 Bonus Selection Texts
    public Text UIArtworksButtonG301AddedText;
    public Text UIArtworksButtonG302AddedText;
    public Text UIArtworksButtonG303AddedText;
    public Text UIArtworksButtonG304AddedText;
    public Text UIArtworksButtonG305AddedText;
    public Text UIArtworksButtonG306AddedText;
    public Text UIArtworksButtonG307AddedText;
    public Text UIArtworksButtonG308AddedText;
    
    // FB Bonus Selection Texts
    public Text UIArtworksButtonFB01AddedText;
    public Text UIArtworksButtonFB02AddedText;
    public Text UIArtworksButtonFB03AddedText;
    public Text UIArtworksButtonFB04AddedText;
    public Text UIArtworksButtonFB05AddedText;
    public Text UIArtworksButtonFB06AddedText;
    public Text UIArtworksButtonFB07AddedText;
    public Text UIArtworksButtonFB08AddedText;
    public Text UIArtworksButtonFB09AddedText;
    public Text UIArtworksButtonFB10AddedText;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
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
        // F1 Selection Texts
        UIArtworksButtonF101Text.text = (ArtworkInformation.ArtPieceNameF101).ToString();
        UIArtworksButtonF102Text.text = (ArtworkInformation.ArtPieceNameF102).ToString();
        UIArtworksButtonF103Text.text = (ArtworkInformation.ArtPieceNameF103).ToString();
        UIArtworksButtonF104Text.text = (ArtworkInformation.ArtPieceNameF104).ToString();
        UIArtworksButtonF105Text.text = (ArtworkInformation.ArtPieceNameF105).ToString();
        UIArtworksButtonF106Text.text = (ArtworkInformation.ArtPieceNameF106).ToString();
        UIArtworksButtonF107Text.text = (ArtworkInformation.ArtPieceNameF107).ToString();
        UIArtworksButtonF108Text.text = (ArtworkInformation.ArtPieceNameF108).ToString();
        UIArtworksButtonF109Text.text = (ArtworkInformation.ArtPieceNameF109).ToString();
        UIArtworksButtonF110Text.text = (ArtworkInformation.ArtPieceNameF110).ToString();
        UIArtworksButtonF111Text.text = (ArtworkInformation.ArtPieceNameF111).ToString();
        UIArtworksButtonF112Text.text = (ArtworkInformation.ArtPieceNameF112).ToString();
        UIArtworksButtonF113Text.text = (ArtworkInformation.ArtPieceNameF113).ToString();
        UIArtworksButtonF114Text.text = (ArtworkInformation.ArtPieceNameF114).ToString();
        UIArtworksButtonF115Text.text = (ArtworkInformation.ArtPieceNameF115).ToString();
    
        // F2 Selection Texts
        UIArtworksButtonF201Text.text = (ArtworkInformation.ArtPieceNameF201).ToString();
        UIArtworksButtonF202Text.text = (ArtworkInformation.ArtPieceNameF202).ToString();
        UIArtworksButtonF203Text.text = (ArtworkInformation.ArtPieceNameF203).ToString();
        UIArtworksButtonF204Text.text = (ArtworkInformation.ArtPieceNameF204).ToString();
        UIArtworksButtonF205Text.text = (ArtworkInformation.ArtPieceNameF205).ToString();
        UIArtworksButtonF206Text.text = (ArtworkInformation.ArtPieceNameF206).ToString();
        UIArtworksButtonF207Text.text = (ArtworkInformation.ArtPieceNameF207).ToString();
        UIArtworksButtonF208Text.text = (ArtworkInformation.ArtPieceNameF208).ToString();
        UIArtworksButtonF209Text.text = (ArtworkInformation.ArtPieceNameF209).ToString();
        UIArtworksButtonF210Text.text = (ArtworkInformation.ArtPieceNameF210).ToString();
        UIArtworksButtonF211Text.text = (ArtworkInformation.ArtPieceNameF211).ToString();
        UIArtworksButtonF212Text.text = (ArtworkInformation.ArtPieceNameF212).ToString();
        UIArtworksButtonF213Text.text = (ArtworkInformation.ArtPieceNameF213).ToString();
        UIArtworksButtonF214Text.text = (ArtworkInformation.ArtPieceNameF214).ToString();
        UIArtworksButtonF215Text.text = (ArtworkInformation.ArtPieceNameF215).ToString();
    
        // F3 Selection Texts
        UIArtworksButtonF301Text.text = (ArtworkInformation.ArtPieceNameF301).ToString();
        UIArtworksButtonF302Text.text = (ArtworkInformation.ArtPieceNameF302).ToString();
        UIArtworksButtonF303Text.text = (ArtworkInformation.ArtPieceNameF303).ToString();
        UIArtworksButtonF304Text.text = (ArtworkInformation.ArtPieceNameF304).ToString();
        UIArtworksButtonF305Text.text = (ArtworkInformation.ArtPieceNameF305).ToString();
        UIArtworksButtonF306Text.text = (ArtworkInformation.ArtPieceNameF306).ToString();
        UIArtworksButtonF307Text.text = (ArtworkInformation.ArtPieceNameF307).ToString();
        UIArtworksButtonF308Text.text = (ArtworkInformation.ArtPieceNameF308).ToString();
        UIArtworksButtonF309Text.text = (ArtworkInformation.ArtPieceNameF309).ToString();
        UIArtworksButtonF310Text.text = (ArtworkInformation.ArtPieceNameF310).ToString();
        UIArtworksButtonF311Text.text = (ArtworkInformation.ArtPieceNameF311).ToString();
        UIArtworksButtonF312Text.text = (ArtworkInformation.ArtPieceNameF312).ToString();
        UIArtworksButtonF313Text.text = (ArtworkInformation.ArtPieceNameF313).ToString();
        UIArtworksButtonF314Text.text = (ArtworkInformation.ArtPieceNameF314).ToString();
        UIArtworksButtonF315Text.text = (ArtworkInformation.ArtPieceNameF315).ToString();
    
        // G1 Selection Texts
        UIArtworksButtonG101Text.text = (ArtworkInformation.ArtPieceNameG101).ToString();
        UIArtworksButtonG102Text.text = (ArtworkInformation.ArtPieceNameG102).ToString();
        UIArtworksButtonG103Text.text = (ArtworkInformation.ArtPieceNameG103).ToString();
        UIArtworksButtonG104Text.text = (ArtworkInformation.ArtPieceNameG104).ToString();
        UIArtworksButtonG105Text.text = (ArtworkInformation.ArtPieceNameG105).ToString();
        UIArtworksButtonG106Text.text = (ArtworkInformation.ArtPieceNameG106).ToString();
        UIArtworksButtonG107Text.text = (ArtworkInformation.ArtPieceNameG107).ToString();
        UIArtworksButtonG108Text.text = (ArtworkInformation.ArtPieceNameG108).ToString();
        UIArtworksButtonG109Text.text = (ArtworkInformation.ArtPieceNameG109).ToString();
        UIArtworksButtonG110Text.text = (ArtworkInformation.ArtPieceNameG110).ToString();
        UIArtworksButtonG111Text.text = (ArtworkInformation.ArtPieceNameG111).ToString();
        UIArtworksButtonG112Text.text = (ArtworkInformation.ArtPieceNameG112).ToString();
        UIArtworksButtonG113Text.text = (ArtworkInformation.ArtPieceNameG113).ToString();
        UIArtworksButtonG114Text.text = (ArtworkInformation.ArtPieceNameG114).ToString();
        UIArtworksButtonG115Text.text = (ArtworkInformation.ArtPieceNameG115).ToString();
    
        // G2 Selection Texts
        UIArtworksButtonG201Text.text = (ArtworkInformation.ArtPieceNameG201).ToString();
        UIArtworksButtonG202Text.text = (ArtworkInformation.ArtPieceNameG202).ToString();
        UIArtworksButtonG203Text.text = (ArtworkInformation.ArtPieceNameG203).ToString();
        UIArtworksButtonG204Text.text = (ArtworkInformation.ArtPieceNameG204).ToString();
        UIArtworksButtonG205Text.text = (ArtworkInformation.ArtPieceNameG205).ToString();
        UIArtworksButtonG206Text.text = (ArtworkInformation.ArtPieceNameG206).ToString();
        UIArtworksButtonG207Text.text = (ArtworkInformation.ArtPieceNameG207).ToString();
        UIArtworksButtonG208Text.text = (ArtworkInformation.ArtPieceNameG208).ToString();
        UIArtworksButtonG209Text.text = (ArtworkInformation.ArtPieceNameG209).ToString();
        UIArtworksButtonG210Text.text = (ArtworkInformation.ArtPieceNameG210).ToString();
        UIArtworksButtonG211Text.text = (ArtworkInformation.ArtPieceNameG211).ToString();
        UIArtworksButtonG212Text.text = (ArtworkInformation.ArtPieceNameG212).ToString();
        UIArtworksButtonG213Text.text = (ArtworkInformation.ArtPieceNameG213).ToString();
        UIArtworksButtonG214Text.text = (ArtworkInformation.ArtPieceNameG214).ToString();
        UIArtworksButtonG215Text.text = (ArtworkInformation.ArtPieceNameG215).ToString();
        
        // G3 Selection Texts
        UIArtworksButtonG301Text.text = (ArtworkInformation.ArtPieceNameG301).ToString();
        UIArtworksButtonG302Text.text = (ArtworkInformation.ArtPieceNameG302).ToString();
        UIArtworksButtonG303Text.text = (ArtworkInformation.ArtPieceNameG303).ToString();
        UIArtworksButtonG304Text.text = (ArtworkInformation.ArtPieceNameG304).ToString();
        UIArtworksButtonG305Text.text = (ArtworkInformation.ArtPieceNameG305).ToString();
        UIArtworksButtonG306Text.text = (ArtworkInformation.ArtPieceNameG306).ToString();
        UIArtworksButtonG307Text.text = (ArtworkInformation.ArtPieceNameG307).ToString();
        UIArtworksButtonG308Text.text = (ArtworkInformation.ArtPieceNameG308).ToString();
        UIArtworksButtonG309Text.text = (ArtworkInformation.ArtPieceNameG309).ToString();
        UIArtworksButtonG310Text.text = (ArtworkInformation.ArtPieceNameG310).ToString();
        UIArtworksButtonG311Text.text = (ArtworkInformation.ArtPieceNameG311).ToString();
        UIArtworksButtonG312Text.text = (ArtworkInformation.ArtPieceNameG312).ToString();
        UIArtworksButtonG313Text.text = (ArtworkInformation.ArtPieceNameG313).ToString();
        UIArtworksButtonG314Text.text = (ArtworkInformation.ArtPieceNameG314).ToString();
        UIArtworksButtonG315Text.text = (ArtworkInformation.ArtPieceNameG315).ToString();
    
        // FB Selection Texts
        UIArtworksButtonFB01Text.text = (ArtworkInformation.ArtPieceNameFB01).ToString();
        UIArtworksButtonFB02Text.text = (ArtworkInformation.ArtPieceNameFB02).ToString();
        UIArtworksButtonFB03Text.text = (ArtworkInformation.ArtPieceNameFB03).ToString();
        UIArtworksButtonFB04Text.text = (ArtworkInformation.ArtPieceNameFB04).ToString();
        UIArtworksButtonFB05Text.text = (ArtworkInformation.ArtPieceNameFB05).ToString();
        UIArtworksButtonFB06Text.text = (ArtworkInformation.ArtPieceNameFB06).ToString();
        UIArtworksButtonFB07Text.text = (ArtworkInformation.ArtPieceNameFB07).ToString();
        UIArtworksButtonFB08Text.text = (ArtworkInformation.ArtPieceNameFB08).ToString();
        UIArtworksButtonFB09Text.text = (ArtworkInformation.ArtPieceNameFB09).ToString();
        UIArtworksButtonFB10Text.text = (ArtworkInformation.ArtPieceNameFB10).ToString();
        UIArtworksButtonFB11Text.text = (ArtworkInformation.ArtPieceNameFB11).ToString();
        UIArtworksButtonFB12Text.text = (ArtworkInformation.ArtPieceNameFB12).ToString();
        UIArtworksButtonFB13Text.text = (ArtworkInformation.ArtPieceNameFB13).ToString();
        UIArtworksButtonFB14Text.text = (ArtworkInformation.ArtPieceNameFB14).ToString();
        UIArtworksButtonFB15Text.text = (ArtworkInformation.ArtPieceNameFB15).ToString();
        
        // F1 Bonus Selection Texts
        UIArtworksButtonF101AddedText.text = (ArtworkInformation.ArtPieceNameF101Added).ToString();
        UIArtworksButtonF102AddedText.text = (ArtworkInformation.ArtPieceNameF102Added).ToString();
        UIArtworksButtonF103AddedText.text = (ArtworkInformation.ArtPieceNameF103Added).ToString();
        UIArtworksButtonF104AddedText.text = (ArtworkInformation.ArtPieceNameF104Added).ToString();
        UIArtworksButtonF105AddedText.text = (ArtworkInformation.ArtPieceNameF105Added).ToString();
        UIArtworksButtonF106AddedText.text = (ArtworkInformation.ArtPieceNameF106Added).ToString();
        UIArtworksButtonF107AddedText.text = (ArtworkInformation.ArtPieceNameF107Added).ToString();
        UIArtworksButtonF108AddedText.text = (ArtworkInformation.ArtPieceNameF108Added).ToString();
        
        // F2 Bonus Selection Texts
        UIArtworksButtonF201AddedText.text = (ArtworkInformation.ArtPieceNameF201Added).ToString();
        UIArtworksButtonF202AddedText.text = (ArtworkInformation.ArtPieceNameF202Added).ToString();
        UIArtworksButtonF203AddedText.text = (ArtworkInformation.ArtPieceNameF203Added).ToString();
        UIArtworksButtonF204AddedText.text = (ArtworkInformation.ArtPieceNameF204Added).ToString();
        UIArtworksButtonF205AddedText.text = (ArtworkInformation.ArtPieceNameF205Added).ToString();
        UIArtworksButtonF206AddedText.text = (ArtworkInformation.ArtPieceNameF206Added).ToString();
        UIArtworksButtonF207AddedText.text = (ArtworkInformation.ArtPieceNameF207Added).ToString();
        UIArtworksButtonF208AddedText.text = (ArtworkInformation.ArtPieceNameF208Added).ToString();
        
        // F3 Bonus Selection Texts
        UIArtworksButtonF301AddedText.text = (ArtworkInformation.ArtPieceNameF301Added).ToString();
        UIArtworksButtonF302AddedText.text = (ArtworkInformation.ArtPieceNameF302Added).ToString();
        UIArtworksButtonF303AddedText.text = (ArtworkInformation.ArtPieceNameF303Added).ToString();
        UIArtworksButtonF304AddedText.text = (ArtworkInformation.ArtPieceNameF304Added).ToString();
        UIArtworksButtonF305AddedText.text = (ArtworkInformation.ArtPieceNameF305Added).ToString();
        UIArtworksButtonF306AddedText.text = (ArtworkInformation.ArtPieceNameF306Added).ToString();
        UIArtworksButtonF307AddedText.text = (ArtworkInformation.ArtPieceNameF307Added).ToString();
        UIArtworksButtonF308AddedText.text = (ArtworkInformation.ArtPieceNameF308Added).ToString();
        
        // G1 Bonus Selection Texts
        UIArtworksButtonG101AddedText.text = (ArtworkInformation.ArtPieceNameG101Added).ToString();
        UIArtworksButtonG102AddedText.text = (ArtworkInformation.ArtPieceNameG102Added).ToString();
        UIArtworksButtonG103AddedText.text = (ArtworkInformation.ArtPieceNameG103Added).ToString();
        UIArtworksButtonG104AddedText.text = (ArtworkInformation.ArtPieceNameG104Added).ToString();
        UIArtworksButtonG105AddedText.text = (ArtworkInformation.ArtPieceNameG105Added).ToString();
        UIArtworksButtonG106AddedText.text = (ArtworkInformation.ArtPieceNameG106Added).ToString();
        UIArtworksButtonG107AddedText.text = (ArtworkInformation.ArtPieceNameG107Added).ToString();
        UIArtworksButtonG108AddedText.text = (ArtworkInformation.ArtPieceNameG108Added).ToString();
        
        // G2 Bonus Selection Texts
        UIArtworksButtonG201AddedText.text = (ArtworkInformation.ArtPieceNameG201Added).ToString();
        UIArtworksButtonG202AddedText.text = (ArtworkInformation.ArtPieceNameG202Added).ToString();
        UIArtworksButtonG203AddedText.text = (ArtworkInformation.ArtPieceNameG203Added).ToString();
        UIArtworksButtonG204AddedText.text = (ArtworkInformation.ArtPieceNameG204Added).ToString();
        UIArtworksButtonG205AddedText.text = (ArtworkInformation.ArtPieceNameG205Added).ToString();
        UIArtworksButtonG206AddedText.text = (ArtworkInformation.ArtPieceNameG206Added).ToString();
        UIArtworksButtonG207AddedText.text = (ArtworkInformation.ArtPieceNameG207Added).ToString();
        UIArtworksButtonG208AddedText.text = (ArtworkInformation.ArtPieceNameG208Added).ToString();
        
        // G3 Bonus Selection Texts
        UIArtworksButtonG301AddedText.text = (ArtworkInformation.ArtPieceNameG301Added).ToString();
        UIArtworksButtonG302AddedText.text = (ArtworkInformation.ArtPieceNameG302Added).ToString();
        UIArtworksButtonG303AddedText.text = (ArtworkInformation.ArtPieceNameG303Added).ToString();
        UIArtworksButtonG304AddedText.text = (ArtworkInformation.ArtPieceNameG304Added).ToString();
        UIArtworksButtonG305AddedText.text = (ArtworkInformation.ArtPieceNameG305Added).ToString();
        UIArtworksButtonG306AddedText.text = (ArtworkInformation.ArtPieceNameG306Added).ToString();
        UIArtworksButtonG307AddedText.text = (ArtworkInformation.ArtPieceNameG307Added).ToString();
        UIArtworksButtonG308AddedText.text = (ArtworkInformation.ArtPieceNameG308Added).ToString();
        
        // FB Bonus Selection Texts
        UIArtworksButtonFB01AddedText.text = (ArtworkInformation.ArtPieceNameFB01Added).ToString();
        UIArtworksButtonFB02AddedText.text = (ArtworkInformation.ArtPieceNameFB02Added).ToString();
        UIArtworksButtonFB03AddedText.text = (ArtworkInformation.ArtPieceNameFB03Added).ToString();
        UIArtworksButtonFB04AddedText.text = (ArtworkInformation.ArtPieceNameFB04Added).ToString();
        UIArtworksButtonFB05AddedText.text = (ArtworkInformation.ArtPieceNameFB05Added).ToString();
        UIArtworksButtonFB06AddedText.text = (ArtworkInformation.ArtPieceNameFB06Added).ToString();
        UIArtworksButtonFB07AddedText.text = (ArtworkInformation.ArtPieceNameFB07Added).ToString();
        UIArtworksButtonFB08AddedText.text = (ArtworkInformation.ArtPieceNameFB08Added).ToString();
        UIArtworksButtonFB09AddedText.text = (ArtworkInformation.ArtPieceNameFB09Added).ToString();
        UIArtworksButtonFB10AddedText.text = (ArtworkInformation.ArtPieceNameFB10Added).ToString();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
	
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}