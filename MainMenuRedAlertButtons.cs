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

public class MainMenuRedAlertButtons : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
    public Button UIRedAlertField;
    
    // F1
	public Button UIRedAlertArtistF1A;
    public Button UIRedAlertArtistF1B;
    public Button UIRedAlertArtistF1C;
    public Button UIRedAlertArtistF1D;
    public Button UIRedAlertArtistF1E;
    
    // F2
	public Button UIRedAlertArtistF2A;
    public Button UIRedAlertArtistF2B;
    public Button UIRedAlertArtistF2C;
    public Button UIRedAlertArtistF2D;
    public Button UIRedAlertArtistF2E;
    
    // F3
	public Button UIRedAlertArtistF3A;
    public Button UIRedAlertArtistF3B;
    public Button UIRedAlertArtistF3C;
    public Button UIRedAlertArtistF3D;
    public Button UIRedAlertArtistF3E;
    
    // G1
	public Button UIRedAlertArtistG1A;
    public Button UIRedAlertArtistG1B;
    public Button UIRedAlertArtistG1C;
    public Button UIRedAlertArtistG1D;
    public Button UIRedAlertArtistG1E;
    
    // G2
	public Button UIRedAlertArtistG2A;
    public Button UIRedAlertArtistG2B;
    public Button UIRedAlertArtistG2C;
    public Button UIRedAlertArtistG2D;
    public Button UIRedAlertArtistG2E;
    
    // G3
	public Button UIRedAlertArtistG3A;
    public Button UIRedAlertArtistG3B;
    public Button UIRedAlertArtistG3C;
    public Button UIRedAlertArtistG3D;
    public Button UIRedAlertArtistG3E;
    
    // FB
	public Button UIRedAlertArtistFBA;
    public Button UIRedAlertArtistFBB;
    public Button UIRedAlertArtistFBC;
    public Button UIRedAlertArtistFBD;
    public Button UIRedAlertArtistFBE;
	
// --------------- PRIVATE VARIABLES ---------------
	// Ghost Timers
	private float WriteGhostTimerF1A;
	private float WriteGhostTimerF1B;
	private float WriteGhostTimerF1C;
	private float WriteGhostTimerF1D;
	private float WriteGhostTimerF1E;
	private float WriteGhostTimerF2A;
	private float WriteGhostTimerF2B;
	private float WriteGhostTimerF2C;
	private float WriteGhostTimerF2D;
	private float WriteGhostTimerF2E;
	private float WriteGhostTimerF3A;
	private float WriteGhostTimerF3B;
	private float WriteGhostTimerF3C;
	private float WriteGhostTimerF3D;
	private float WriteGhostTimerF3E;
	private float WriteGhostTimerG1A;
	private float WriteGhostTimerG1B;
	private float WriteGhostTimerG1C;
	private float WriteGhostTimerG1D;
	private float WriteGhostTimerG1E;
	private float WriteGhostTimerG2A;
	private float WriteGhostTimerG2B;
	private float WriteGhostTimerG2C;
	private float WriteGhostTimerG2D;
	private float WriteGhostTimerG2E;
    private float WriteGhostTimerG3A;
	private float WriteGhostTimerG3B;
	private float WriteGhostTimerG3C;
	private float WriteGhostTimerG3D;
	private float WriteGhostTimerG3E;
	private float WriteGhostTimerFBA;
	private float WriteGhostTimerFBB;
	private float WriteGhostTimerFBC;
	private float WriteGhostTimerFBD;
	private float WriteGhostTimerFBE;
    
    // Artwork Timers
	private float WriteArtworkTimerF101;
    private float WriteArtworkTimerF102;
    private float WriteArtworkTimerF103;
    private float WriteArtworkTimerF104;
    private float WriteArtworkTimerF105;
    private float WriteArtworkTimerF106;
    private float WriteArtworkTimerF107;
    private float WriteArtworkTimerF108;
    private float WriteArtworkTimerF109;
    private float WriteArtworkTimerF110;
    private float WriteArtworkTimerF111;
    private float WriteArtworkTimerF112;
    private float WriteArtworkTimerF113;
    private float WriteArtworkTimerF114;
    private float WriteArtworkTimerF115;
    private float WriteArtworkTimerF201;
    private float WriteArtworkTimerF202;
    private float WriteArtworkTimerF203;
    private float WriteArtworkTimerF204;
    private float WriteArtworkTimerF205;
    private float WriteArtworkTimerF206;
    private float WriteArtworkTimerF207;
    private float WriteArtworkTimerF208;
    private float WriteArtworkTimerF209;
    private float WriteArtworkTimerF210;
    private float WriteArtworkTimerF211;
    private float WriteArtworkTimerF212;
    private float WriteArtworkTimerF213;
    private float WriteArtworkTimerF214;
    private float WriteArtworkTimerF215;
    private float WriteArtworkTimerF301;
    private float WriteArtworkTimerF302;
    private float WriteArtworkTimerF303;
    private float WriteArtworkTimerF304;
    private float WriteArtworkTimerF305;
    private float WriteArtworkTimerF306;
    private float WriteArtworkTimerF307;
    private float WriteArtworkTimerF308;
    private float WriteArtworkTimerF309;
    private float WriteArtworkTimerF310;
    private float WriteArtworkTimerF311;
    private float WriteArtworkTimerF312;
    private float WriteArtworkTimerF313;
    private float WriteArtworkTimerF314;
    private float WriteArtworkTimerF315;
    private float WriteArtworkTimerG101;
    private float WriteArtworkTimerG102;
    private float WriteArtworkTimerG103;
    private float WriteArtworkTimerG104;
    private float WriteArtworkTimerG105;
    private float WriteArtworkTimerG106;
    private float WriteArtworkTimerG107;
    private float WriteArtworkTimerG108;
    private float WriteArtworkTimerG109;
    private float WriteArtworkTimerG110;
    private float WriteArtworkTimerG111;
    private float WriteArtworkTimerG112;
    private float WriteArtworkTimerG113;
    private float WriteArtworkTimerG114;
    private float WriteArtworkTimerG115;
    private float WriteArtworkTimerG201;
    private float WriteArtworkTimerG202;
    private float WriteArtworkTimerG203;
    private float WriteArtworkTimerG204;
    private float WriteArtworkTimerG205;
    private float WriteArtworkTimerG206;
    private float WriteArtworkTimerG207;
    private float WriteArtworkTimerG208;
    private float WriteArtworkTimerG209;
    private float WriteArtworkTimerG210;
    private float WriteArtworkTimerG211;
    private float WriteArtworkTimerG212;
    private float WriteArtworkTimerG213;
    private float WriteArtworkTimerG214;
    private float WriteArtworkTimerG215;
    private float WriteArtworkTimerG301;
    private float WriteArtworkTimerG302;
    private float WriteArtworkTimerG303;
    private float WriteArtworkTimerG304;
    private float WriteArtworkTimerG305;
    private float WriteArtworkTimerG306;
    private float WriteArtworkTimerG307;
    private float WriteArtworkTimerG308;
    private float WriteArtworkTimerG309;
    private float WriteArtworkTimerG310;
    private float WriteArtworkTimerG311;
    private float WriteArtworkTimerG312;
    private float WriteArtworkTimerG313;
    private float WriteArtworkTimerG314;
    private float WriteArtworkTimerG315;
    private float WriteArtworkTimerFB01;
    private float WriteArtworkTimerFB02;
    private float WriteArtworkTimerFB03;
    private float WriteArtworkTimerFB04;
    private float WriteArtworkTimerFB05;
    private float WriteArtworkTimerFB06;
    private float WriteArtworkTimerFB07;
    private float WriteArtworkTimerFB08;
    private float WriteArtworkTimerFB09;
    private float WriteArtworkTimerFB10;
    private float WriteArtworkTimerFB11;
    private float WriteArtworkTimerFB12;
    private float WriteArtworkTimerFB13;
    private float WriteArtworkTimerFB14;
    private float WriteArtworkTimerFB15;
    private float WriteArtworkTimerFBonus01;
    private float WriteArtworkTimerFBonus02;
    private float WriteArtworkTimerFBonus03;
    private float WriteArtworkTimerFBonus04;
    private float WriteArtworkTimerFBonus05;
    private float WriteArtworkTimerFBonus06;
    private float WriteArtworkTimerFBonus07;
    private float WriteArtworkTimerFBonus08;
    private float WriteArtworkTimerFBonus09;
    private float WriteArtworkTimerFBonus10;
    private float WriteArtworkTimerF101Added;
    private float WriteArtworkTimerF102Added;
    private float WriteArtworkTimerF103Added;
    private float WriteArtworkTimerF104Added;
    private float WriteArtworkTimerF105Added;
    private float WriteArtworkTimerF106Added;
    private float WriteArtworkTimerF107Added;
    private float WriteArtworkTimerF108Added;
    private float WriteArtworkTimerF201Added;
    private float WriteArtworkTimerF202Added;
    private float WriteArtworkTimerF203Added;
    private float WriteArtworkTimerF204Added;
    private float WriteArtworkTimerF205Added;
    private float WriteArtworkTimerF206Added;
    private float WriteArtworkTimerF207Added;
    private float WriteArtworkTimerF208Added;
    private float WriteArtworkTimerF301Added;
    private float WriteArtworkTimerF302Added;
    private float WriteArtworkTimerF303Added;
    private float WriteArtworkTimerF304Added;
    private float WriteArtworkTimerF305Added;
    private float WriteArtworkTimerF306Added;
    private float WriteArtworkTimerF307Added;
    private float WriteArtworkTimerF308Added;
    private float WriteArtworkTimerG101Added;
    private float WriteArtworkTimerG102Added;
    private float WriteArtworkTimerG103Added;
    private float WriteArtworkTimerG104Added;
    private float WriteArtworkTimerG105Added;
    private float WriteArtworkTimerG106Added;
    private float WriteArtworkTimerG107Added;
    private float WriteArtworkTimerG108Added;
    private float WriteArtworkTimerG201Added;
    private float WriteArtworkTimerG202Added;
    private float WriteArtworkTimerG203Added;
    private float WriteArtworkTimerG204Added;
    private float WriteArtworkTimerG205Added;
    private float WriteArtworkTimerG206Added;
    private float WriteArtworkTimerG207Added;
    private float WriteArtworkTimerG208Added;
    private float WriteArtworkTimerG301Added;
    private float WriteArtworkTimerG302Added;
    private float WriteArtworkTimerG303Added;
    private float WriteArtworkTimerG304Added;
    private float WriteArtworkTimerG305Added;
    private float WriteArtworkTimerG306Added;
    private float WriteArtworkTimerG307Added;
    private float WriteArtworkTimerG308Added;
    private float WriteArtworkTimerFB01Added;
    private float WriteArtworkTimerFB02Added;
    private float WriteArtworkTimerFB03Added;
    private float WriteArtworkTimerFB04Added;
    private float WriteArtworkTimerFB05Added;
    private float WriteArtworkTimerFB06Added;
    private float WriteArtworkTimerFB07Added;
    private float WriteArtworkTimerFB08Added;
    private float WriteArtworkTimerFB09Added;
    private float WriteArtworkTimerFB10Added;
		
// --------------- STATIC VARIABLES ---------------
	
	
// --------------- FIREBASE VARIABLES ---------------
	// Auth
	private FirebaseAuth PlayerAuthentication;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Disable Objects
	public MainMenuRedAlertEnable RedAlertAllDisabling;
    
    // Enable Objects
    public MainMenuRedAlertEnable RedAlertPanelEnabling;
    public MainMenuRedAlertEnable RedAlertGhostF1AEnabling;
    public MainMenuRedAlertEnable RedAlertGhostF1BEnabling;
    public MainMenuRedAlertEnable RedAlertGhostF1CEnabling;
    public MainMenuRedAlertEnable RedAlertGhostF1DEnabling;
    public MainMenuRedAlertEnable RedAlertGhostF1EEnabling;
    public MainMenuRedAlertEnable RedAlertGhostF2AEnabling;
    public MainMenuRedAlertEnable RedAlertGhostF2BEnabling;
    public MainMenuRedAlertEnable RedAlertGhostF2CEnabling;
    public MainMenuRedAlertEnable RedAlertGhostF2DEnabling;
    public MainMenuRedAlertEnable RedAlertGhostF2EEnabling;
    public MainMenuRedAlertEnable RedAlertGhostF3AEnabling;
    public MainMenuRedAlertEnable RedAlertGhostF3BEnabling;
    public MainMenuRedAlertEnable RedAlertGhostF3CEnabling;
    public MainMenuRedAlertEnable RedAlertGhostF3DEnabling;
    public MainMenuRedAlertEnable RedAlertGhostF3EEnabling;
    public MainMenuRedAlertEnable RedAlertGhostG1AEnabling;
    public MainMenuRedAlertEnable RedAlertGhostG1BEnabling;
    public MainMenuRedAlertEnable RedAlertGhostG1CEnabling;
    public MainMenuRedAlertEnable RedAlertGhostG1DEnabling;
    public MainMenuRedAlertEnable RedAlertGhostG1EEnabling;
    public MainMenuRedAlertEnable RedAlertGhostG2AEnabling;
    public MainMenuRedAlertEnable RedAlertGhostG2BEnabling;
    public MainMenuRedAlertEnable RedAlertGhostG2CEnabling;
    public MainMenuRedAlertEnable RedAlertGhostG2DEnabling;
    public MainMenuRedAlertEnable RedAlertGhostG2EEnabling;
    public MainMenuRedAlertEnable RedAlertGhostG3AEnabling;
    public MainMenuRedAlertEnable RedAlertGhostG3BEnabling;
    public MainMenuRedAlertEnable RedAlertGhostG3CEnabling;
    public MainMenuRedAlertEnable RedAlertGhostG3DEnabling;
    public MainMenuRedAlertEnable RedAlertGhostG3EEnabling;
    public MainMenuRedAlertEnable RedAlertGhostFBAEnabling;
    public MainMenuRedAlertEnable RedAlertGhostFBBEnabling;
    public MainMenuRedAlertEnable RedAlertGhostFBCEnabling;
    public MainMenuRedAlertEnable RedAlertGhostFBDEnabling;
    public MainMenuRedAlertEnable RedAlertGhostFBEEnabling;
	
	// Open Scenes F1
	public SceneLoad Scene06Loading; // Billiards Room
	public SceneLoad Scene07Loading; // Dining Room
	public SceneLoad Scene05Loading; // Foyer
	public SceneLoad Scene08Loading; // Kitchen
	public SceneLoad Scene09Loading; // Lounge
	
	// Open Scenes F2
	public SceneLoad Scene10Loading; // First Bedroom
	public SceneLoad Scene11Loading; // Second Bedroom
	public SceneLoad Scene12Loading; // Parlor
	public SceneLoad Scene13Loading; // Library
	public SceneLoad Scene14Loading; // Studio
	
	// Open Scenes F3
	public SceneLoad Scene15Loading; // Third Bedroom
	public SceneLoad Scene16Loading; // Fourth Bedroom
	public SceneLoad Scene17Loading; // Balcony
	public SceneLoad Scene18Loading; // Study
	
	// Open Scenes G1
	public SceneLoad Scene19Loading; // Rose Garden
	public SceneLoad Scene20Loading; // Daisy Garden
	public SceneLoad Scene21Loading; // Lily Pond
	public SceneLoad Scene22Loading; // Tulip Garden
	
	// Open Scenes G2
	public SceneLoad Scene23Loading; // Koi Pond
	public SceneLoad Scene24Loading; // Hedge Maze
	public SceneLoad Scene25Loading; // Stables
	public SceneLoad Scene26Loading; // Sunflower Garden
    
    // Open Scenes G3
	public SceneLoad Scene30ALoading; // Castle Tower
	public SceneLoad Scene30BLoading; // King's Garden
	public SceneLoad Scene30CLoading; // Queen's Garden
	public SceneLoad Scene30DLoading; // Chess Garden
	
	// Open Scenes FB
	public SceneLoad Scene27Loading; // Dungeon
	public SceneLoad Scene28Loading; // Servants Quarter
	public SceneLoad Scene29Loading; // Armory
	public SceneLoad Scene30Loading; // Wine Cellar
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
        // Firebase Auth
		PlayerAuthentication = FirebaseAuth.DefaultInstance;
        
        // Panel Artist Button
        Button UIRedAlertFieldClick = UIRedAlertField.GetComponent<Button>();
		UIRedAlertFieldClick.onClick.AddListener(UIRedAlertFieldClicking);
        
        // F1
        Button UIRedAlertArtistF1AClick = UIRedAlertArtistF1A.GetComponent<Button>();
		UIRedAlertArtistF1AClick.onClick.AddListener(UIRedAlertArtistF1AClicking);
        
        Button UIRedAlertArtistF1BClick = UIRedAlertArtistF1B.GetComponent<Button>();
		UIRedAlertArtistF1BClick.onClick.AddListener(UIRedAlertArtistF1BClicking);
        
        Button UIRedAlertArtistF1CClick = UIRedAlertArtistF1C.GetComponent<Button>();
		UIRedAlertArtistF1CClick.onClick.AddListener(UIRedAlertArtistF1CClicking);
        
        Button UIRedAlertArtistF1DClick = UIRedAlertArtistF1D.GetComponent<Button>();
		UIRedAlertArtistF1DClick.onClick.AddListener(UIRedAlertArtistF1DClicking);
        
        Button UIRedAlertArtistF1EClick = UIRedAlertArtistF1E.GetComponent<Button>();
		UIRedAlertArtistF1EClick.onClick.AddListener(UIRedAlertArtistF1EClicking);
        
        // F2
        Button UIRedAlertArtistF2AClick = UIRedAlertArtistF2A.GetComponent<Button>();
		UIRedAlertArtistF2AClick.onClick.AddListener(UIRedAlertArtistF2AClicking);
        
        Button UIRedAlertArtistF2BClick = UIRedAlertArtistF2B.GetComponent<Button>();
		UIRedAlertArtistF2BClick.onClick.AddListener(UIRedAlertArtistF2BClicking);
        
        Button UIRedAlertArtistF2CClick = UIRedAlertArtistF2C.GetComponent<Button>();
		UIRedAlertArtistF2CClick.onClick.AddListener(UIRedAlertArtistF2CClicking);
        
        Button UIRedAlertArtistF2DClick = UIRedAlertArtistF2D.GetComponent<Button>();
		UIRedAlertArtistF2DClick.onClick.AddListener(UIRedAlertArtistF2DClicking);
        
        Button UIRedAlertArtistF2EClick = UIRedAlertArtistF2E.GetComponent<Button>();
		UIRedAlertArtistF2EClick.onClick.AddListener(UIRedAlertArtistF2EClicking);
        
        // F3
        Button UIRedAlertArtistF3AClick = UIRedAlertArtistF3A.GetComponent<Button>();
		UIRedAlertArtistF3AClick.onClick.AddListener(UIRedAlertArtistF3AClicking);
        
        Button UIRedAlertArtistF3BClick = UIRedAlertArtistF3B.GetComponent<Button>();
		UIRedAlertArtistF3BClick.onClick.AddListener(UIRedAlertArtistF3BClicking);
        
        Button UIRedAlertArtistF3CClick = UIRedAlertArtistF3C.GetComponent<Button>();
		UIRedAlertArtistF3CClick.onClick.AddListener(UIRedAlertArtistF3CClicking);
        
        Button UIRedAlertArtistF3DClick = UIRedAlertArtistF3D.GetComponent<Button>();
		UIRedAlertArtistF3DClick.onClick.AddListener(UIRedAlertArtistF3DClicking);
        
        Button UIRedAlertArtistF3EClick = UIRedAlertArtistF3E.GetComponent<Button>();
		UIRedAlertArtistF3EClick.onClick.AddListener(UIRedAlertArtistF3EClicking);
        
        // G1
        Button UIRedAlertArtistG1AClick = UIRedAlertArtistG1A.GetComponent<Button>();
		UIRedAlertArtistG1AClick.onClick.AddListener(UIRedAlertArtistG1AClicking);
        
        Button UIRedAlertArtistG1BClick = UIRedAlertArtistG1B.GetComponent<Button>();
		UIRedAlertArtistG1BClick.onClick.AddListener(UIRedAlertArtistG1BClicking);
        
        Button UIRedAlertArtistG1CClick = UIRedAlertArtistG1C.GetComponent<Button>();
		UIRedAlertArtistG1CClick.onClick.AddListener(UIRedAlertArtistG1CClicking);
        
        Button UIRedAlertArtistG1DClick = UIRedAlertArtistG1D.GetComponent<Button>();
		UIRedAlertArtistG1DClick.onClick.AddListener(UIRedAlertArtistG1DClicking);
        
        Button UIRedAlertArtistG1EClick = UIRedAlertArtistG1E.GetComponent<Button>();
		UIRedAlertArtistG1EClick.onClick.AddListener(UIRedAlertArtistG1EClicking);
        
        // G2
        Button UIRedAlertArtistG2AClick = UIRedAlertArtistG2A.GetComponent<Button>();
		UIRedAlertArtistG2AClick.onClick.AddListener(UIRedAlertArtistG2AClicking);
        
        Button UIRedAlertArtistG2BClick = UIRedAlertArtistG2B.GetComponent<Button>();
		UIRedAlertArtistG2BClick.onClick.AddListener(UIRedAlertArtistG2BClicking);
        
        Button UIRedAlertArtistG2CClick = UIRedAlertArtistG2C.GetComponent<Button>();
		UIRedAlertArtistG2CClick.onClick.AddListener(UIRedAlertArtistG2CClicking);
        
        Button UIRedAlertArtistG2DClick = UIRedAlertArtistG2D.GetComponent<Button>();
		UIRedAlertArtistG2DClick.onClick.AddListener(UIRedAlertArtistG2DClicking);
        
        Button UIRedAlertArtistG2EClick = UIRedAlertArtistG2E.GetComponent<Button>();
		UIRedAlertArtistG2EClick.onClick.AddListener(UIRedAlertArtistG2EClicking);
        
        // G3
        Button UIRedAlertArtistG3AClick = UIRedAlertArtistG3A.GetComponent<Button>();
		UIRedAlertArtistG3AClick.onClick.AddListener(UIRedAlertArtistG3AClicking);
        
        Button UIRedAlertArtistG3BClick = UIRedAlertArtistG3B.GetComponent<Button>();
		UIRedAlertArtistG3BClick.onClick.AddListener(UIRedAlertArtistG3BClicking);
        
        Button UIRedAlertArtistG3CClick = UIRedAlertArtistG3C.GetComponent<Button>();
		UIRedAlertArtistG3CClick.onClick.AddListener(UIRedAlertArtistG3CClicking);
        
        Button UIRedAlertArtistG3DClick = UIRedAlertArtistG3D.GetComponent<Button>();
		UIRedAlertArtistG3DClick.onClick.AddListener(UIRedAlertArtistG3DClicking);
        
        Button UIRedAlertArtistG3EClick = UIRedAlertArtistG3E.GetComponent<Button>();
		UIRedAlertArtistG3EClick.onClick.AddListener(UIRedAlertArtistG3EClicking);
        
        // FB
        Button UIRedAlertArtistFBAClick = UIRedAlertArtistFBA.GetComponent<Button>();
		UIRedAlertArtistFBAClick.onClick.AddListener(UIRedAlertArtistFBAClicking);
        
        Button UIRedAlertArtistFBBClick = UIRedAlertArtistFBB.GetComponent<Button>();
		UIRedAlertArtistFBBClick.onClick.AddListener(UIRedAlertArtistFBBClicking);
        
        Button UIRedAlertArtistFBCClick = UIRedAlertArtistFBC.GetComponent<Button>();
		UIRedAlertArtistFBCClick.onClick.AddListener(UIRedAlertArtistFBCClicking);
        
        Button UIRedAlertArtistFBDClick = UIRedAlertArtistFBD.GetComponent<Button>();
		UIRedAlertArtistFBDClick.onClick.AddListener(UIRedAlertArtistFBDClicking);
        
        Button UIRedAlertArtistFBEClick = UIRedAlertArtistFBE.GetComponent<Button>();
		UIRedAlertArtistFBEClick.onClick.AddListener(UIRedAlertArtistFBEClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		// Ghost Timers
		WriteGhostTimerF1A = float.Parse(DataFillingInformation.DBGhostTimeF1A);
		WriteGhostTimerF1B = float.Parse(DataFillingInformation.DBGhostTimeF1B);
		WriteGhostTimerF1C = float.Parse(DataFillingInformation.DBGhostTimeF1C);
		WriteGhostTimerF1D = float.Parse(DataFillingInformation.DBGhostTimeF1D);
		WriteGhostTimerF1E = float.Parse(DataFillingInformation.DBGhostTimeF1E);
		WriteGhostTimerF2A = float.Parse(DataFillingInformation.DBGhostTimeF2A);
		WriteGhostTimerF2B = float.Parse(DataFillingInformation.DBGhostTimeF2B);
		WriteGhostTimerF2C = float.Parse(DataFillingInformation.DBGhostTimeF2C);
		WriteGhostTimerF2D = float.Parse(DataFillingInformation.DBGhostTimeF2D);
		WriteGhostTimerF2E = float.Parse(DataFillingInformation.DBGhostTimeF2E);
		WriteGhostTimerF3A = float.Parse(DataFillingInformation.DBGhostTimeF3A);
		WriteGhostTimerF3B = float.Parse(DataFillingInformation.DBGhostTimeF3B);
		WriteGhostTimerF3C = float.Parse(DataFillingInformation.DBGhostTimeF3C);
		WriteGhostTimerF3D = float.Parse(DataFillingInformation.DBGhostTimeF3D);
		WriteGhostTimerF3E = float.Parse(DataFillingInformation.DBGhostTimeF3E);
		WriteGhostTimerG1A = float.Parse(DataFillingInformation.DBGhostTimeG1A);
		WriteGhostTimerG1B = float.Parse(DataFillingInformation.DBGhostTimeG1B);
		WriteGhostTimerG1C = float.Parse(DataFillingInformation.DBGhostTimeG1C);
		WriteGhostTimerG1D = float.Parse(DataFillingInformation.DBGhostTimeG1D);
		WriteGhostTimerG1E = float.Parse(DataFillingInformation.DBGhostTimeG1E);
		WriteGhostTimerG2A = float.Parse(DataFillingInformation.DBGhostTimeG2A);
		WriteGhostTimerG2B = float.Parse(DataFillingInformation.DBGhostTimeG2B);
		WriteGhostTimerG2C = float.Parse(DataFillingInformation.DBGhostTimeG2C);
		WriteGhostTimerG2D = float.Parse(DataFillingInformation.DBGhostTimeG2D);
		WriteGhostTimerG2E = float.Parse(DataFillingInformation.DBGhostTimeG2E);
        WriteGhostTimerG3A = float.Parse(DataFillingInformation.DBGhostTimeG3A);
		WriteGhostTimerG3B = float.Parse(DataFillingInformation.DBGhostTimeG3B);
		WriteGhostTimerG3C = float.Parse(DataFillingInformation.DBGhostTimeG3C);
		WriteGhostTimerG3D = float.Parse(DataFillingInformation.DBGhostTimeG3D);
		WriteGhostTimerG3E = float.Parse(DataFillingInformation.DBGhostTimeG3E);
		WriteGhostTimerFBA = float.Parse(DataFillingInformation.DBGhostTimeFBA);
		WriteGhostTimerFBB = float.Parse(DataFillingInformation.DBGhostTimeFBB);
		WriteGhostTimerFBC = float.Parse(DataFillingInformation.DBGhostTimeFBC);
		WriteGhostTimerFBD = float.Parse(DataFillingInformation.DBGhostTimeFBD);
		WriteGhostTimerFBE = float.Parse(DataFillingInformation.DBGhostTimeFBE);
        
        // Artwork Timers
        WriteArtworkTimerF101 = float.Parse(DataFillingInformation.DBArtworkTimersF101);
        WriteArtworkTimerF102 = float.Parse(DataFillingInformation.DBArtworkTimersF102);
        WriteArtworkTimerF103 = float.Parse(DataFillingInformation.DBArtworkTimersF103);
        WriteArtworkTimerF104 = float.Parse(DataFillingInformation.DBArtworkTimersF104);
        WriteArtworkTimerF105 = float.Parse(DataFillingInformation.DBArtworkTimersF105);
        WriteArtworkTimerF106 = float.Parse(DataFillingInformation.DBArtworkTimersF106);
        WriteArtworkTimerF107 = float.Parse(DataFillingInformation.DBArtworkTimersF107);
        WriteArtworkTimerF108 = float.Parse(DataFillingInformation.DBArtworkTimersF108);
        WriteArtworkTimerF109 = float.Parse(DataFillingInformation.DBArtworkTimersF109);
        WriteArtworkTimerF110 = float.Parse(DataFillingInformation.DBArtworkTimersF110);
        WriteArtworkTimerF111 = float.Parse(DataFillingInformation.DBArtworkTimersF111);
        WriteArtworkTimerF112 = float.Parse(DataFillingInformation.DBArtworkTimersF112);
        WriteArtworkTimerF113 = float.Parse(DataFillingInformation.DBArtworkTimersF113);
        WriteArtworkTimerF114 = float.Parse(DataFillingInformation.DBArtworkTimersF114);
        WriteArtworkTimerF115 = float.Parse(DataFillingInformation.DBArtworkTimersF115);
        WriteArtworkTimerF201 = float.Parse(DataFillingInformation.DBArtworkTimersF201);
        WriteArtworkTimerF202 = float.Parse(DataFillingInformation.DBArtworkTimersF202);
        WriteArtworkTimerF203 = float.Parse(DataFillingInformation.DBArtworkTimersF203);
        WriteArtworkTimerF204 = float.Parse(DataFillingInformation.DBArtworkTimersF204);
        WriteArtworkTimerF205 = float.Parse(DataFillingInformation.DBArtworkTimersF205);
        WriteArtworkTimerF206 = float.Parse(DataFillingInformation.DBArtworkTimersF206);
        WriteArtworkTimerF207 = float.Parse(DataFillingInformation.DBArtworkTimersF207);
        WriteArtworkTimerF208 = float.Parse(DataFillingInformation.DBArtworkTimersF208);
        WriteArtworkTimerF209 = float.Parse(DataFillingInformation.DBArtworkTimersF209);
        WriteArtworkTimerF210 = float.Parse(DataFillingInformation.DBArtworkTimersF210);
        WriteArtworkTimerF211 = float.Parse(DataFillingInformation.DBArtworkTimersF211);
        WriteArtworkTimerF212 = float.Parse(DataFillingInformation.DBArtworkTimersF212);
        WriteArtworkTimerF213 = float.Parse(DataFillingInformation.DBArtworkTimersF213);
        WriteArtworkTimerF214 = float.Parse(DataFillingInformation.DBArtworkTimersF214);
        WriteArtworkTimerF215 = float.Parse(DataFillingInformation.DBArtworkTimersF215);
        WriteArtworkTimerF301 = float.Parse(DataFillingInformation.DBArtworkTimersF301);
        WriteArtworkTimerF302 = float.Parse(DataFillingInformation.DBArtworkTimersF302);
        WriteArtworkTimerF303 = float.Parse(DataFillingInformation.DBArtworkTimersF303);
        WriteArtworkTimerF304 = float.Parse(DataFillingInformation.DBArtworkTimersF304);
        WriteArtworkTimerF305 = float.Parse(DataFillingInformation.DBArtworkTimersF305);
        WriteArtworkTimerF306 = float.Parse(DataFillingInformation.DBArtworkTimersF306);
        WriteArtworkTimerF307 = float.Parse(DataFillingInformation.DBArtworkTimersF307);
        WriteArtworkTimerF308 = float.Parse(DataFillingInformation.DBArtworkTimersF308);
        WriteArtworkTimerF309 = float.Parse(DataFillingInformation.DBArtworkTimersF309);
        WriteArtworkTimerF310 = float.Parse(DataFillingInformation.DBArtworkTimersF310);
        WriteArtworkTimerF311 = float.Parse(DataFillingInformation.DBArtworkTimersF311);
        WriteArtworkTimerF312 = float.Parse(DataFillingInformation.DBArtworkTimersF312);
        WriteArtworkTimerF313 = float.Parse(DataFillingInformation.DBArtworkTimersF313);
        WriteArtworkTimerF314 = float.Parse(DataFillingInformation.DBArtworkTimersF314);
        WriteArtworkTimerF315 = float.Parse(DataFillingInformation.DBArtworkTimersF315);
        WriteArtworkTimerG101 = float.Parse(DataFillingInformation.DBArtworkTimersG101);
        WriteArtworkTimerG102 = float.Parse(DataFillingInformation.DBArtworkTimersG102);
        WriteArtworkTimerG103 = float.Parse(DataFillingInformation.DBArtworkTimersG103);
        WriteArtworkTimerG104 = float.Parse(DataFillingInformation.DBArtworkTimersG104);
        WriteArtworkTimerG105 = float.Parse(DataFillingInformation.DBArtworkTimersG105);
        WriteArtworkTimerG106 = float.Parse(DataFillingInformation.DBArtworkTimersG106);
        WriteArtworkTimerG107 = float.Parse(DataFillingInformation.DBArtworkTimersG107);
        WriteArtworkTimerG108 = float.Parse(DataFillingInformation.DBArtworkTimersG108);
        WriteArtworkTimerG109 = float.Parse(DataFillingInformation.DBArtworkTimersG109);
        WriteArtworkTimerG110 = float.Parse(DataFillingInformation.DBArtworkTimersG110);
        WriteArtworkTimerG111 = float.Parse(DataFillingInformation.DBArtworkTimersG111);
        WriteArtworkTimerG112 = float.Parse(DataFillingInformation.DBArtworkTimersG112);
        WriteArtworkTimerG113 = float.Parse(DataFillingInformation.DBArtworkTimersG113);
        WriteArtworkTimerG114 = float.Parse(DataFillingInformation.DBArtworkTimersG114);
        WriteArtworkTimerG115 = float.Parse(DataFillingInformation.DBArtworkTimersG115);
        WriteArtworkTimerG201 = float.Parse(DataFillingInformation.DBArtworkTimersG201);
        WriteArtworkTimerG202 = float.Parse(DataFillingInformation.DBArtworkTimersG202);
        WriteArtworkTimerG203 = float.Parse(DataFillingInformation.DBArtworkTimersG203);
        WriteArtworkTimerG204 = float.Parse(DataFillingInformation.DBArtworkTimersG204);
        WriteArtworkTimerG205 = float.Parse(DataFillingInformation.DBArtworkTimersG205);
        WriteArtworkTimerG206 = float.Parse(DataFillingInformation.DBArtworkTimersG206);
        WriteArtworkTimerG207 = float.Parse(DataFillingInformation.DBArtworkTimersG207);
        WriteArtworkTimerG208 = float.Parse(DataFillingInformation.DBArtworkTimersG208);
        WriteArtworkTimerG209 = float.Parse(DataFillingInformation.DBArtworkTimersG209);
        WriteArtworkTimerG210 = float.Parse(DataFillingInformation.DBArtworkTimersG210);
        WriteArtworkTimerG211 = float.Parse(DataFillingInformation.DBArtworkTimersG211);
        WriteArtworkTimerG212 = float.Parse(DataFillingInformation.DBArtworkTimersG212);
        WriteArtworkTimerG213 = float.Parse(DataFillingInformation.DBArtworkTimersG213);
        WriteArtworkTimerG214 = float.Parse(DataFillingInformation.DBArtworkTimersG214);
        WriteArtworkTimerG215 = float.Parse(DataFillingInformation.DBArtworkTimersG215);
        WriteArtworkTimerG301 = float.Parse(DataFillingInformation.DBArtworkTimersG301);
        WriteArtworkTimerG302 = float.Parse(DataFillingInformation.DBArtworkTimersG302);
        WriteArtworkTimerG303 = float.Parse(DataFillingInformation.DBArtworkTimersG303);
        WriteArtworkTimerG304 = float.Parse(DataFillingInformation.DBArtworkTimersG304);
        WriteArtworkTimerG305 = float.Parse(DataFillingInformation.DBArtworkTimersG305);
        WriteArtworkTimerG306 = float.Parse(DataFillingInformation.DBArtworkTimersG306);
        WriteArtworkTimerG307 = float.Parse(DataFillingInformation.DBArtworkTimersG307);
        WriteArtworkTimerG308 = float.Parse(DataFillingInformation.DBArtworkTimersG308);
        WriteArtworkTimerG309 = float.Parse(DataFillingInformation.DBArtworkTimersG309);
        WriteArtworkTimerG310 = float.Parse(DataFillingInformation.DBArtworkTimersG310);
        WriteArtworkTimerG311 = float.Parse(DataFillingInformation.DBArtworkTimersG311);
        WriteArtworkTimerG312 = float.Parse(DataFillingInformation.DBArtworkTimersG312);
        WriteArtworkTimerG313 = float.Parse(DataFillingInformation.DBArtworkTimersG313);
        WriteArtworkTimerG314 = float.Parse(DataFillingInformation.DBArtworkTimersG314);
        WriteArtworkTimerG315 = float.Parse(DataFillingInformation.DBArtworkTimersG315);
        WriteArtworkTimerFB01 = float.Parse(DataFillingInformation.DBArtworkTimersFB01);
        WriteArtworkTimerFB02 = float.Parse(DataFillingInformation.DBArtworkTimersFB02);
        WriteArtworkTimerFB03 = float.Parse(DataFillingInformation.DBArtworkTimersFB03);
        WriteArtworkTimerFB04 = float.Parse(DataFillingInformation.DBArtworkTimersFB04);
        WriteArtworkTimerFB05 = float.Parse(DataFillingInformation.DBArtworkTimersFB05);
        WriteArtworkTimerFB06 = float.Parse(DataFillingInformation.DBArtworkTimersFB06);
        WriteArtworkTimerFB07 = float.Parse(DataFillingInformation.DBArtworkTimersFB07);
        WriteArtworkTimerFB08 = float.Parse(DataFillingInformation.DBArtworkTimersFB08);
        WriteArtworkTimerFB09 = float.Parse(DataFillingInformation.DBArtworkTimersFB09);
        WriteArtworkTimerFB10 = float.Parse(DataFillingInformation.DBArtworkTimersFB10);
        WriteArtworkTimerFB11 = float.Parse(DataFillingInformation.DBArtworkTimersFB11);
        WriteArtworkTimerFB12 = float.Parse(DataFillingInformation.DBArtworkTimersFB12);
        WriteArtworkTimerFB13 = float.Parse(DataFillingInformation.DBArtworkTimersFB13);
        WriteArtworkTimerFB14 = float.Parse(DataFillingInformation.DBArtworkTimersFB14);
        WriteArtworkTimerFB15 = float.Parse(DataFillingInformation.DBArtworkTimersFB15);
        WriteArtworkTimerFBonus01 = float.Parse(DataFillingInformation.DBBonusArtworkTimers01);
        WriteArtworkTimerFBonus02 = float.Parse(DataFillingInformation.DBBonusArtworkTimers02);
        WriteArtworkTimerFBonus03 = float.Parse(DataFillingInformation.DBBonusArtworkTimers03);
        WriteArtworkTimerFBonus04 = float.Parse(DataFillingInformation.DBBonusArtworkTimers04);
        WriteArtworkTimerFBonus05 = float.Parse(DataFillingInformation.DBBonusArtworkTimers05);
        WriteArtworkTimerFBonus06 = float.Parse(DataFillingInformation.DBBonusArtworkTimers06);
        WriteArtworkTimerFBonus07 = float.Parse(DataFillingInformation.DBBonusArtworkTimers07);
        WriteArtworkTimerFBonus08 = float.Parse(DataFillingInformation.DBBonusArtworkTimers08);
        WriteArtworkTimerFBonus09 = float.Parse(DataFillingInformation.DBBonusArtworkTimers09);
        WriteArtworkTimerFBonus10 = float.Parse(DataFillingInformation.DBBonusArtworkTimers10);
        WriteArtworkTimerF101Added = float.Parse(DataFillingInformation.DBArtworkTimersF101Added);
        WriteArtworkTimerF102Added = float.Parse(DataFillingInformation.DBArtworkTimersF102Added);
        WriteArtworkTimerF103Added = float.Parse(DataFillingInformation.DBArtworkTimersF103Added);
        WriteArtworkTimerF104Added = float.Parse(DataFillingInformation.DBArtworkTimersF104Added);
        WriteArtworkTimerF105Added = float.Parse(DataFillingInformation.DBArtworkTimersF105Added);
        WriteArtworkTimerF106Added = float.Parse(DataFillingInformation.DBArtworkTimersF106Added);
        WriteArtworkTimerF107Added = float.Parse(DataFillingInformation.DBArtworkTimersF107Added);
        WriteArtworkTimerF108Added = float.Parse(DataFillingInformation.DBArtworkTimersF108Added);
        WriteArtworkTimerF201Added = float.Parse(DataFillingInformation.DBArtworkTimersF201Added);
        WriteArtworkTimerF202Added = float.Parse(DataFillingInformation.DBArtworkTimersF202Added);
        WriteArtworkTimerF203Added = float.Parse(DataFillingInformation.DBArtworkTimersF203Added);
        WriteArtworkTimerF204Added = float.Parse(DataFillingInformation.DBArtworkTimersF204Added);
        WriteArtworkTimerF205Added = float.Parse(DataFillingInformation.DBArtworkTimersF205Added);
        WriteArtworkTimerF206Added = float.Parse(DataFillingInformation.DBArtworkTimersF206Added);
        WriteArtworkTimerF207Added = float.Parse(DataFillingInformation.DBArtworkTimersF207Added);
        WriteArtworkTimerF208Added = float.Parse(DataFillingInformation.DBArtworkTimersF208Added);
        WriteArtworkTimerF301Added = float.Parse(DataFillingInformation.DBArtworkTimersF301Added);
        WriteArtworkTimerF302Added = float.Parse(DataFillingInformation.DBArtworkTimersF302Added);
        WriteArtworkTimerF303Added = float.Parse(DataFillingInformation.DBArtworkTimersF303Added);
        WriteArtworkTimerF304Added = float.Parse(DataFillingInformation.DBArtworkTimersF304Added);
        WriteArtworkTimerF305Added = float.Parse(DataFillingInformation.DBArtworkTimersF305Added);
        WriteArtworkTimerF306Added = float.Parse(DataFillingInformation.DBArtworkTimersF306Added);
        WriteArtworkTimerF307Added = float.Parse(DataFillingInformation.DBArtworkTimersF307Added);
        WriteArtworkTimerF308Added = float.Parse(DataFillingInformation.DBArtworkTimersF308Added);
        WriteArtworkTimerG101Added = float.Parse(DataFillingInformation.DBArtworkTimersG101Added);
        WriteArtworkTimerG102Added = float.Parse(DataFillingInformation.DBArtworkTimersG102Added);
        WriteArtworkTimerG103Added = float.Parse(DataFillingInformation.DBArtworkTimersG103Added);
        WriteArtworkTimerG104Added = float.Parse(DataFillingInformation.DBArtworkTimersG104Added);
        WriteArtworkTimerG105Added = float.Parse(DataFillingInformation.DBArtworkTimersG105Added);
        WriteArtworkTimerG106Added = float.Parse(DataFillingInformation.DBArtworkTimersG106Added);
        WriteArtworkTimerG107Added = float.Parse(DataFillingInformation.DBArtworkTimersG107Added);
        WriteArtworkTimerG108Added = float.Parse(DataFillingInformation.DBArtworkTimersG108Added);
        WriteArtworkTimerG201Added = float.Parse(DataFillingInformation.DBArtworkTimersG201Added);
        WriteArtworkTimerG202Added = float.Parse(DataFillingInformation.DBArtworkTimersG202Added);
        WriteArtworkTimerG203Added = float.Parse(DataFillingInformation.DBArtworkTimersG203Added);
        WriteArtworkTimerG204Added = float.Parse(DataFillingInformation.DBArtworkTimersG204Added);
        WriteArtworkTimerG205Added = float.Parse(DataFillingInformation.DBArtworkTimersG205Added);
        WriteArtworkTimerG206Added = float.Parse(DataFillingInformation.DBArtworkTimersG206Added);
        WriteArtworkTimerG207Added = float.Parse(DataFillingInformation.DBArtworkTimersG207Added);
        WriteArtworkTimerG208Added = float.Parse(DataFillingInformation.DBArtworkTimersG208Added);
        WriteArtworkTimerG301Added = float.Parse(DataFillingInformation.DBArtworkTimersG301Added);
        WriteArtworkTimerG302Added = float.Parse(DataFillingInformation.DBArtworkTimersG302Added);
        WriteArtworkTimerG303Added = float.Parse(DataFillingInformation.DBArtworkTimersG303Added);
        WriteArtworkTimerG304Added = float.Parse(DataFillingInformation.DBArtworkTimersG304Added);
        WriteArtworkTimerG305Added = float.Parse(DataFillingInformation.DBArtworkTimersG305Added);
        WriteArtworkTimerG306Added = float.Parse(DataFillingInformation.DBArtworkTimersG306Added);
        WriteArtworkTimerG307Added = float.Parse(DataFillingInformation.DBArtworkTimersG307Added);
        WriteArtworkTimerG308Added = float.Parse(DataFillingInformation.DBArtworkTimersG308Added);
        WriteArtworkTimerFB01Added = float.Parse(DataFillingInformation.DBArtworkTimersFB01Added);
        WriteArtworkTimerFB02Added = float.Parse(DataFillingInformation.DBArtworkTimersFB02Added);
        WriteArtworkTimerFB03Added = float.Parse(DataFillingInformation.DBArtworkTimersFB03Added);
        WriteArtworkTimerFB04Added = float.Parse(DataFillingInformation.DBArtworkTimersFB04Added);
        WriteArtworkTimerFB05Added = float.Parse(DataFillingInformation.DBArtworkTimersFB05Added);
        WriteArtworkTimerFB06Added = float.Parse(DataFillingInformation.DBArtworkTimersFB06Added);
        WriteArtworkTimerFB07Added = float.Parse(DataFillingInformation.DBArtworkTimersFB07Added);
        WriteArtworkTimerFB08Added = float.Parse(DataFillingInformation.DBArtworkTimersFB08Added);
        WriteArtworkTimerFB09Added = float.Parse(DataFillingInformation.DBArtworkTimersFB09Added);
        WriteArtworkTimerFB10Added = float.Parse(DataFillingInformation.DBArtworkTimersFB10Added);
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- BUTTON FUNCTION ---------------
    // Field
    public void UIRedAlertFieldClicking() {
        RedAlertPanelEnabling.RedAlertPanelEnable();
        
        // F1
        if (MainMenuRedAlertEnable.PrivateAlertTimeF1A == 1) {
            RedAlertGhostF1AEnabling.RedAlertGhostF1AEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeF1B == 1) {
            RedAlertGhostF1BEnabling.RedAlertGhostF1BEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeF1C == 1) {
            RedAlertGhostF1CEnabling.RedAlertGhostF1CEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeF1D == 1) {
            RedAlertGhostF1DEnabling.RedAlertGhostF1DEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeF1E == 1) {
            RedAlertGhostF1EEnabling.RedAlertGhostF1EEnable();
        }
        
        // F2
        if (MainMenuRedAlertEnable.PrivateAlertTimeF2A == 1) {
            RedAlertGhostF2AEnabling.RedAlertGhostF2AEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeF2B == 1) {
            RedAlertGhostF2BEnabling.RedAlertGhostF2BEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeF2C == 1) {
            RedAlertGhostF2CEnabling.RedAlertGhostF2CEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeF2D == 1) {
            RedAlertGhostF2DEnabling.RedAlertGhostF2DEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeF2E == 1) {
            RedAlertGhostF2EEnabling.RedAlertGhostF2EEnable();
        }
        
        // F3
        if (MainMenuRedAlertEnable.PrivateAlertTimeF3A == 1) {
            RedAlertGhostF3AEnabling.RedAlertGhostF3AEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeF3B == 1) {
            RedAlertGhostF3BEnabling.RedAlertGhostF3BEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeF3C == 1) {
            RedAlertGhostF3CEnabling.RedAlertGhostF3CEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeF3D == 1) {
            RedAlertGhostF3DEnabling.RedAlertGhostF3DEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeF3E == 1) {
            RedAlertGhostF3EEnabling.RedAlertGhostF3EEnable();
        }
        
        // G1
        if (MainMenuRedAlertEnable.PrivateAlertTimeG1A == 1) {
            RedAlertGhostG1AEnabling.RedAlertGhostG1AEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeG1B == 1) {
            RedAlertGhostG1BEnabling.RedAlertGhostG1BEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeG1C == 1) {
            RedAlertGhostG1CEnabling.RedAlertGhostG1CEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeG1D == 1) {
            RedAlertGhostG1DEnabling.RedAlertGhostG1DEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeG1E == 1) {
            RedAlertGhostG1EEnabling.RedAlertGhostG1EEnable();
        }
        
        // G2
        if (MainMenuRedAlertEnable.PrivateAlertTimeG2A == 1) {
            RedAlertGhostG2AEnabling.RedAlertGhostG2AEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeG2B == 1) {
            RedAlertGhostG2BEnabling.RedAlertGhostG2BEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeG2C == 1) {
            RedAlertGhostG2CEnabling.RedAlertGhostG2CEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeG2D == 1) {
            RedAlertGhostG2DEnabling.RedAlertGhostG2DEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeG2E == 1) {
            RedAlertGhostG2EEnabling.RedAlertGhostG2EEnable();
        }
        
        // G3
        if (MainMenuRedAlertEnable.PrivateAlertTimeG3A == 1) {
            RedAlertGhostG3AEnabling.RedAlertGhostG3AEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeG3B == 1) {
            RedAlertGhostG3BEnabling.RedAlertGhostG3BEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeG3C == 1) {
            RedAlertGhostG3CEnabling.RedAlertGhostG3CEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeG3D == 1) {
            RedAlertGhostG3DEnabling.RedAlertGhostG3DEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeG3E == 1) {
            RedAlertGhostG3EEnabling.RedAlertGhostG3EEnable();
        }
        
        // FB
        if (MainMenuRedAlertEnable.PrivateAlertTimeFBA == 1) {
            RedAlertGhostFBAEnabling.RedAlertGhostFBAEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeFBB == 1) {
            RedAlertGhostFBBEnabling.RedAlertGhostFBBEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeFBC == 1) {
            RedAlertGhostFBCEnabling.RedAlertGhostFBCEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeFBD == 1) {
            RedAlertGhostFBDEnabling.RedAlertGhostFBDEnable();
        }
        
        if (MainMenuRedAlertEnable.PrivateAlertTimeFBE == 1) {
            RedAlertGhostFBEEnabling.RedAlertGhostFBEEnable();
        }
    }
    
    // F1
    public void UIRedAlertArtistF1AClicking() {
        Scene06Loading.Scene06Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 06;
    }
    
    public void UIRedAlertArtistF1BClicking() {
        Scene06Loading.Scene06Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 06;
    }
    
    public void UIRedAlertArtistF1CClicking() {
        Scene09Loading.Scene09Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 09;
    }
    
    public void UIRedAlertArtistF1DClicking() {
        Scene07Loading.Scene07Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 07;
    }
    
    public void UIRedAlertArtistF1EClicking() {
        Scene08Loading.Scene08Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 08;
    }
    
    // F2
    public void UIRedAlertArtistF2AClicking() {
        Scene10Loading.Scene10Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 10;
    }
    
    public void UIRedAlertArtistF2BClicking() {
        Scene11Loading.Scene11Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 11;
    }
    
    public void UIRedAlertArtistF2CClicking() {
        Scene12Loading.Scene12Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 12;
    }
    
    public void UIRedAlertArtistF2DClicking() {
        Scene13Loading.Scene13Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 13;
    }
    
    public void UIRedAlertArtistF2EClicking() {
        Scene14Loading.Scene14Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 14;
    }
    
    // F3
    public void UIRedAlertArtistF3AClicking() {
        Scene15Loading.Scene15Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 15;
    }
    
    public void UIRedAlertArtistF3BClicking() {
        Scene16Loading.Scene16Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 16;
    }
    
    public void UIRedAlertArtistF3CClicking() {
        Scene17Loading.Scene17Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 17;
    }
    
    public void UIRedAlertArtistF3DClicking() {
        Scene17Loading.Scene17Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 17;
    }
    
    public void UIRedAlertArtistF3EClicking() {
        Scene18Loading.Scene18Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 18;
    }
    
    // G1
    public void UIRedAlertArtistG1AClicking() {
        Scene19Loading.Scene19Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 19;
    }
    
    public void UIRedAlertArtistG1BClicking() {
        Scene19Loading.Scene19Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 19;
    }
    
    public void UIRedAlertArtistG1CClicking() {
        Scene22Loading.Scene22Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 22;
    }
    
    public void UIRedAlertArtistG1DClicking() {
        Scene21Loading.Scene21Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 21;
    }
    
    public void UIRedAlertArtistG1EClicking() {
        Scene20Loading.Scene20Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 20;
    }
    
    // G2
    public void UIRedAlertArtistG2AClicking() {
        Scene23Loading.Scene23Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 23;
    }
    
    public void UIRedAlertArtistG2BClicking() {
        Scene24Loading.Scene24Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 24;
    }
    
    public void UIRedAlertArtistG2CClicking() {
        Scene25Loading.Scene25Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 25;
    }
    
    public void UIRedAlertArtistG2DClicking() {
        Scene25Loading.Scene25Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 25;
    }
    
    public void UIRedAlertArtistG2EClicking() {
        Scene26Loading.Scene26Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 26;
    }
    
    // G3
    public void UIRedAlertArtistG3AClicking() {
        Scene23Loading.Scene23Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 70;
    }
    
    public void UIRedAlertArtistG3BClicking() {
        Scene24Loading.Scene24Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 71;
    }
    
    public void UIRedAlertArtistG3CClicking() {
        Scene25Loading.Scene25Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 72;
    }
    
    public void UIRedAlertArtistG3DClicking() {
        Scene25Loading.Scene25Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 72;
    }
    
    public void UIRedAlertArtistG3EClicking() {
        Scene26Loading.Scene26Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 73;
    }
    
    // FB
    public void UIRedAlertArtistFBAClicking() {
        Scene27Loading.Scene27Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 27;
    }
    
    public void UIRedAlertArtistFBBClicking() {
        Scene29Loading.Scene29Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 29;
    }
    
    public void UIRedAlertArtistFBCClicking() {
        Scene29Loading.Scene29Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 29;
    }
    
    public void UIRedAlertArtistFBDClicking() {
        Scene30Loading.Scene30Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 30;
    }
    
    public void UIRedAlertArtistFBEClicking() {
        Scene28Loading.Scene28Load();
        WriteGhostTimerData();
        WriteArtworkTimerData();
        RedAlertAllDisabling.RedAlertAllDisable();
        SceneLoad.RoomTrackerCode = 28;
    }
	
// --------------- WRITE DATABASE FUNCTIONS ---------------
	public void WriteGhostTimerData() {
		if (DataFillingInformation.AuthLoggedOrSigned == 0) {
			// F1A
			DataFillingInformation.DBGhostTimeF1A = WriteGhostTimerF1A.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeF1A").SetValueAsync(WriteGhostTimerF1A);
			
			// F1B
			DataFillingInformation.DBGhostTimeF1B = WriteGhostTimerF1B.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeF1B").SetValueAsync(WriteGhostTimerF1B);
			
			// F1C
			DataFillingInformation.DBGhostTimeF1C = WriteGhostTimerF1C.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeF1C").SetValueAsync(WriteGhostTimerF1C);
			
			// F1D
			DataFillingInformation.DBGhostTimeF1D = WriteGhostTimerF1D.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeF1D").SetValueAsync(WriteGhostTimerF1D);
			
			// F1E
			DataFillingInformation.DBGhostTimeF1E = WriteGhostTimerF1E.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeF1E").SetValueAsync(WriteGhostTimerF1E);
			
			// F2A
			DataFillingInformation.DBGhostTimeF2A = WriteGhostTimerF2A.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeF2A").SetValueAsync(WriteGhostTimerF2A);
			
			// F2B
			DataFillingInformation.DBGhostTimeF2B = WriteGhostTimerF2B.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeF2B").SetValueAsync(WriteGhostTimerF2B);
			
			// F2C
			DataFillingInformation.DBGhostTimeF2C = WriteGhostTimerF2C.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeF2C").SetValueAsync(WriteGhostTimerF2C);
			
			// F2D
			DataFillingInformation.DBGhostTimeF2D = WriteGhostTimerF2D.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeF2D").SetValueAsync(WriteGhostTimerF2D);
			
			// F2E
			DataFillingInformation.DBGhostTimeF2E = WriteGhostTimerF2E.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeF2E").SetValueAsync(WriteGhostTimerF2E);
			
			// F3A
			DataFillingInformation.DBGhostTimeF3A = WriteGhostTimerF3A.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeF3A").SetValueAsync(WriteGhostTimerF3A);
			
			// F3B
			DataFillingInformation.DBGhostTimeF3B = WriteGhostTimerF3B.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeF3B").SetValueAsync(WriteGhostTimerF3B);
			
			// F3C
			DataFillingInformation.DBGhostTimeF3C = WriteGhostTimerF3C.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeF3C").SetValueAsync(WriteGhostTimerF3C);
			
			// F3D
			DataFillingInformation.DBGhostTimeF3D = WriteGhostTimerF3D.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeF3D").SetValueAsync(WriteGhostTimerF3D);
			
			// F3E
			DataFillingInformation.DBGhostTimeF3E = WriteGhostTimerF3E.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeF3E").SetValueAsync(WriteGhostTimerF3E);
			
			// G1A
			DataFillingInformation.DBGhostTimeG1A = WriteGhostTimerG1A.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeG1A").SetValueAsync(WriteGhostTimerG1A);
			
			// G1B
			DataFillingInformation.DBGhostTimeG1B = WriteGhostTimerG1B.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeG1B").SetValueAsync(WriteGhostTimerG1B);
			
			// G1C
			DataFillingInformation.DBGhostTimeG1C = WriteGhostTimerG1C.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeG1C").SetValueAsync(WriteGhostTimerG1C);
			
			// G1D
			DataFillingInformation.DBGhostTimeG1D = WriteGhostTimerG1D.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeG1D").SetValueAsync(WriteGhostTimerG1D);
			
			// G1E
			DataFillingInformation.DBGhostTimeG1E = WriteGhostTimerG1E.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeG1E").SetValueAsync(WriteGhostTimerG1E);
			
			// G2A
			DataFillingInformation.DBGhostTimeG2A = WriteGhostTimerG2A.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeG2A").SetValueAsync(WriteGhostTimerG2A);
			
			// G2B
			DataFillingInformation.DBGhostTimeG2B = WriteGhostTimerG2B.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeG2B").SetValueAsync(WriteGhostTimerG2B);
			
			// G2C
			DataFillingInformation.DBGhostTimeG2C = WriteGhostTimerG2C.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeG2C").SetValueAsync(WriteGhostTimerG2C);
			
			// G2D
			DataFillingInformation.DBGhostTimeG2D = WriteGhostTimerG2D.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeG2D").SetValueAsync(WriteGhostTimerG2D);
			
			// G2E
			DataFillingInformation.DBGhostTimeG2E = WriteGhostTimerG2E.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeG2E").SetValueAsync(WriteGhostTimerG2E);
            
            // G3A
			DataFillingInformation.DBGhostTimeG3A = WriteGhostTimerG3A.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeG3A").SetValueAsync(WriteGhostTimerG3A);
			
			// G3B
			DataFillingInformation.DBGhostTimeG3B = WriteGhostTimerG3B.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeG3B").SetValueAsync(WriteGhostTimerG3B);
			
			// G3C
			DataFillingInformation.DBGhostTimeG3C = WriteGhostTimerG3C.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeG3C").SetValueAsync(WriteGhostTimerG3C);
			
			// G3D
			DataFillingInformation.DBGhostTimeG3D = WriteGhostTimerG3D.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeG3D").SetValueAsync(WriteGhostTimerG3D);
			
			// G3E
			DataFillingInformation.DBGhostTimeG3E = WriteGhostTimerG3E.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeG3E").SetValueAsync(WriteGhostTimerG3E);
			
			// FBA
			DataFillingInformation.DBGhostTimeFBA = WriteGhostTimerFBA.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeFBA").SetValueAsync(WriteGhostTimerFBA);
			
			// FBB
			DataFillingInformation.DBGhostTimeFBB = WriteGhostTimerFBB.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeFBB").SetValueAsync(WriteGhostTimerFBB);
			
			// FBC
			DataFillingInformation.DBGhostTimeFBC = WriteGhostTimerFBC.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeFBC").SetValueAsync(WriteGhostTimerFBC);
			
			// FBD
			DataFillingInformation.DBGhostTimeFBD = WriteGhostTimerFBD.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeFBD").SetValueAsync(WriteGhostTimerFBD);
			
			// FBE
			DataFillingInformation.DBGhostTimeFBE = WriteGhostTimerFBE.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBGhostTimeFBE").SetValueAsync(WriteGhostTimerFBE);
		}
		
		if (DataFillingInformation.AuthLoggedOrSigned == 1) {
			// F1A
			DataFillingInformation.DBGhostTimeF1A = WriteGhostTimerF1A.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeF1A").SetValueAsync(WriteGhostTimerF1A);
			
			// F1B
			DataFillingInformation.DBGhostTimeF1B = WriteGhostTimerF1B.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeF1B").SetValueAsync(WriteGhostTimerF1B);
			
			// F1C
			DataFillingInformation.DBGhostTimeF1C = WriteGhostTimerF1C.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeF1C").SetValueAsync(WriteGhostTimerF1C);
			
			// F1D
			DataFillingInformation.DBGhostTimeF1D = WriteGhostTimerF1D.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeF1D").SetValueAsync(WriteGhostTimerF1D);
			
			// F1E
			DataFillingInformation.DBGhostTimeF1E = WriteGhostTimerF1E.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeF1E").SetValueAsync(WriteGhostTimerF1E);
			
			// F2A
			DataFillingInformation.DBGhostTimeF2A = WriteGhostTimerF2A.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeF2A").SetValueAsync(WriteGhostTimerF2A);
			
			// F2B
			DataFillingInformation.DBGhostTimeF2B = WriteGhostTimerF2B.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeF2B").SetValueAsync(WriteGhostTimerF2B);
			
			// F2C
			DataFillingInformation.DBGhostTimeF2C = WriteGhostTimerF2C.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeF2C").SetValueAsync(WriteGhostTimerF2C);
			
			// F2D
			DataFillingInformation.DBGhostTimeF2D = WriteGhostTimerF2D.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeF2D").SetValueAsync(WriteGhostTimerF2D);
			
			// F2E
			DataFillingInformation.DBGhostTimeF2E = WriteGhostTimerF2E.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeF2E").SetValueAsync(WriteGhostTimerF2E);
			
			// F3A
			DataFillingInformation.DBGhostTimeF3A = WriteGhostTimerF3A.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeF3A").SetValueAsync(WriteGhostTimerF3A);
			
			// F3B
			DataFillingInformation.DBGhostTimeF3B = WriteGhostTimerF3B.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeF3B").SetValueAsync(WriteGhostTimerF3B);
			
			// F3C
			DataFillingInformation.DBGhostTimeF3C = WriteGhostTimerF3C.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeF3C").SetValueAsync(WriteGhostTimerF3C);
			
			// F3D
			DataFillingInformation.DBGhostTimeF3D = WriteGhostTimerF3D.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeF3D").SetValueAsync(WriteGhostTimerF3D);
			
			// F3E
			DataFillingInformation.DBGhostTimeF3E = WriteGhostTimerF3E.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeF3E").SetValueAsync(WriteGhostTimerF3E);
			
			// G1A
			DataFillingInformation.DBGhostTimeG1A = WriteGhostTimerG1A.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeG1A").SetValueAsync(WriteGhostTimerG1A);
			
			// G1B
			DataFillingInformation.DBGhostTimeG1B = WriteGhostTimerG1B.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeG1B").SetValueAsync(WriteGhostTimerG1B);
			
			// G1C
			DataFillingInformation.DBGhostTimeG1C = WriteGhostTimerG1C.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeG1C").SetValueAsync(WriteGhostTimerG1C);
			
			// G1D
			DataFillingInformation.DBGhostTimeG1D = WriteGhostTimerG1D.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeG1D").SetValueAsync(WriteGhostTimerG1D);
			
			// G1E
			DataFillingInformation.DBGhostTimeG1E = WriteGhostTimerG1E.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeG1E").SetValueAsync(WriteGhostTimerG1E);
			
			// G2A
			DataFillingInformation.DBGhostTimeG2A = WriteGhostTimerG2A.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeG2A").SetValueAsync(WriteGhostTimerG2A);
			
			// G2B
			DataFillingInformation.DBGhostTimeG2B = WriteGhostTimerG2B.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeG2B").SetValueAsync(WriteGhostTimerG2B);
			
			// G2C
			DataFillingInformation.DBGhostTimeG2C = WriteGhostTimerG2C.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeG2C").SetValueAsync(WriteGhostTimerG2C);
			
			// G2D
			DataFillingInformation.DBGhostTimeG2D = WriteGhostTimerG2D.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeG2D").SetValueAsync(WriteGhostTimerG2D);
			
			// G2E
			DataFillingInformation.DBGhostTimeG2E = WriteGhostTimerG2E.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeG2E").SetValueAsync(WriteGhostTimerG2E);
            
            // G3A
			DataFillingInformation.DBGhostTimeG3A = WriteGhostTimerG3A.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeG3A").SetValueAsync(WriteGhostTimerG3A);
			
			// G3B
			DataFillingInformation.DBGhostTimeG3B = WriteGhostTimerG3B.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeG3B").SetValueAsync(WriteGhostTimerG3B);
			
			// G3C
			DataFillingInformation.DBGhostTimeG3C = WriteGhostTimerG3C.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeG3C").SetValueAsync(WriteGhostTimerG3C);
			
			// G3D
			DataFillingInformation.DBGhostTimeG3D = WriteGhostTimerG3D.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeG3D").SetValueAsync(WriteGhostTimerG3D);
			
			// G3E
			DataFillingInformation.DBGhostTimeG3E = WriteGhostTimerG3E.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeG3E").SetValueAsync(WriteGhostTimerG3E);
			
			// FBA
			DataFillingInformation.DBGhostTimeFBA = WriteGhostTimerFBA.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeFBA").SetValueAsync(WriteGhostTimerFBA);
			
			// FBB
			DataFillingInformation.DBGhostTimeFBB = WriteGhostTimerFBB.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeFBB").SetValueAsync(WriteGhostTimerFBB);
			
			// FBC
			DataFillingInformation.DBGhostTimeFBC = WriteGhostTimerFBC.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeFBC").SetValueAsync(WriteGhostTimerFBC);
			
			// FBD
			DataFillingInformation.DBGhostTimeFBD = WriteGhostTimerFBD.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeFBD").SetValueAsync(WriteGhostTimerFBD);
			
			// FBE
			DataFillingInformation.DBGhostTimeFBE = WriteGhostTimerFBE.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauGhostTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBGhostTimeFBE").SetValueAsync(WriteGhostTimerFBE);
		}
	}
    
    public void WriteArtworkTimerData() {
        if (DataFillingInformation.AuthLoggedOrSigned == 0) {
            // F101
			DataFillingInformation.DBArtworkTimersF101 = WriteArtworkTimerF101.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF101").SetValueAsync(WriteArtworkTimerF101);
            
            // F102
			DataFillingInformation.DBArtworkTimersF102 = WriteArtworkTimerF102.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF102").SetValueAsync(WriteArtworkTimerF102);
            
            // F103
			DataFillingInformation.DBArtworkTimersF103 = WriteArtworkTimerF103.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF103").SetValueAsync(WriteArtworkTimerF103);
            
            // F104
			DataFillingInformation.DBArtworkTimersF104 = WriteArtworkTimerF104.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF104").SetValueAsync(WriteArtworkTimerF104);
            
            // F105
			DataFillingInformation.DBArtworkTimersF105 = WriteArtworkTimerF105.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF105").SetValueAsync(WriteArtworkTimerF105);
            
            // F106
			DataFillingInformation.DBArtworkTimersF106 = WriteArtworkTimerF106.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF106").SetValueAsync(WriteArtworkTimerF106);
            
            // F107
			DataFillingInformation.DBArtworkTimersF107 = WriteArtworkTimerF107.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF107").SetValueAsync(WriteArtworkTimerF107);
            
            // F108
			DataFillingInformation.DBArtworkTimersF108 = WriteArtworkTimerF108.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF108").SetValueAsync(WriteArtworkTimerF108);
            
            // F109
			DataFillingInformation.DBArtworkTimersF109 = WriteArtworkTimerF109.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF109").SetValueAsync(WriteArtworkTimerF109);
            
            // F110
			DataFillingInformation.DBArtworkTimersF110 = WriteArtworkTimerF110.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF110").SetValueAsync(WriteArtworkTimerF110);
            
            // F111
			DataFillingInformation.DBArtworkTimersF111 = WriteArtworkTimerF111.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF111").SetValueAsync(WriteArtworkTimerF111);
            
            // F112
			DataFillingInformation.DBArtworkTimersF112 = WriteArtworkTimerF112.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF112").SetValueAsync(WriteArtworkTimerF112);
            
            // F113
			DataFillingInformation.DBArtworkTimersF113 = WriteArtworkTimerF113.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF113").SetValueAsync(WriteArtworkTimerF113);
            
            // F114
			DataFillingInformation.DBArtworkTimersF114 = WriteArtworkTimerF114.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF114").SetValueAsync(WriteArtworkTimerF114);
            
            // F115
			DataFillingInformation.DBArtworkTimersF115 = WriteArtworkTimerF115.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF115").SetValueAsync(WriteArtworkTimerF115);
            
            // F201
			DataFillingInformation.DBArtworkTimersF201 = WriteArtworkTimerF201.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF201").SetValueAsync(WriteArtworkTimerF201);
            
            // F202
			DataFillingInformation.DBArtworkTimersF202 = WriteArtworkTimerF202.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF202").SetValueAsync(WriteArtworkTimerF202);
            
            // F203
			DataFillingInformation.DBArtworkTimersF203 = WriteArtworkTimerF203.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF203").SetValueAsync(WriteArtworkTimerF203);
            
            // F204
			DataFillingInformation.DBArtworkTimersF204 = WriteArtworkTimerF204.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF204").SetValueAsync(WriteArtworkTimerF204);
            
            // F205
			DataFillingInformation.DBArtworkTimersF205 = WriteArtworkTimerF205.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF205").SetValueAsync(WriteArtworkTimerF205);
            
            // F206
			DataFillingInformation.DBArtworkTimersF206 = WriteArtworkTimerF206.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF206").SetValueAsync(WriteArtworkTimerF206);
            
            // F207
			DataFillingInformation.DBArtworkTimersF207 = WriteArtworkTimerF207.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF207").SetValueAsync(WriteArtworkTimerF207);
            
            // F208
			DataFillingInformation.DBArtworkTimersF208 = WriteArtworkTimerF208.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF208").SetValueAsync(WriteArtworkTimerF208);
            
            // F209
			DataFillingInformation.DBArtworkTimersF209 = WriteArtworkTimerF209.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF209").SetValueAsync(WriteArtworkTimerF209);
            
            // F210
			DataFillingInformation.DBArtworkTimersF210 = WriteArtworkTimerF210.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF210").SetValueAsync(WriteArtworkTimerF210);
            
            // F211
			DataFillingInformation.DBArtworkTimersF211 = WriteArtworkTimerF211.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF211").SetValueAsync(WriteArtworkTimerF211);
            
            // F212
			DataFillingInformation.DBArtworkTimersF212 = WriteArtworkTimerF212.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF212").SetValueAsync(WriteArtworkTimerF212);
            
            // F213
			DataFillingInformation.DBArtworkTimersF213 = WriteArtworkTimerF213.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF213").SetValueAsync(WriteArtworkTimerF213);
            
            // F214
			DataFillingInformation.DBArtworkTimersF214 = WriteArtworkTimerF214.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF214").SetValueAsync(WriteArtworkTimerF214);
            
            // F215
			DataFillingInformation.DBArtworkTimersF215 = WriteArtworkTimerF215.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF215").SetValueAsync(WriteArtworkTimerF215);
            
            // F301
			DataFillingInformation.DBArtworkTimersF301 = WriteArtworkTimerF301.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF301").SetValueAsync(WriteArtworkTimerF301);
            
            // F302
			DataFillingInformation.DBArtworkTimersF302 = WriteArtworkTimerF302.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF302").SetValueAsync(WriteArtworkTimerF302);
            
            // F303
			DataFillingInformation.DBArtworkTimersF303 = WriteArtworkTimerF303.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF303").SetValueAsync(WriteArtworkTimerF303);
            
            // F304
			DataFillingInformation.DBArtworkTimersF304 = WriteArtworkTimerF304.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF304").SetValueAsync(WriteArtworkTimerF304);
            
            // F305
			DataFillingInformation.DBArtworkTimersF305 = WriteArtworkTimerF305.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF305").SetValueAsync(WriteArtworkTimerF305);
            
            // F306
			DataFillingInformation.DBArtworkTimersF306 = WriteArtworkTimerF306.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF306").SetValueAsync(WriteArtworkTimerF306);
            
            // F307
			DataFillingInformation.DBArtworkTimersF307 = WriteArtworkTimerF307.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF307").SetValueAsync(WriteArtworkTimerF307);
            
            // F308
			DataFillingInformation.DBArtworkTimersF308 = WriteArtworkTimerF308.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF308").SetValueAsync(WriteArtworkTimerF308);
            
            // F309
			DataFillingInformation.DBArtworkTimersF309 = WriteArtworkTimerF309.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF309").SetValueAsync(WriteArtworkTimerF309);
            
            // F310
			DataFillingInformation.DBArtworkTimersF310 = WriteArtworkTimerF310.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF310").SetValueAsync(WriteArtworkTimerF310);
            
            // F311
			DataFillingInformation.DBArtworkTimersF311 = WriteArtworkTimerF311.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF311").SetValueAsync(WriteArtworkTimerF311);
            
            // F312
			DataFillingInformation.DBArtworkTimersF312 = WriteArtworkTimerF312.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF312").SetValueAsync(WriteArtworkTimerF312);
            
            // F313
			DataFillingInformation.DBArtworkTimersF313 = WriteArtworkTimerF313.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF313").SetValueAsync(WriteArtworkTimerF313);
            
            // F314
			DataFillingInformation.DBArtworkTimersF314 = WriteArtworkTimerF314.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF314").SetValueAsync(WriteArtworkTimerF314);
            
            // F315
			DataFillingInformation.DBArtworkTimersF315 = WriteArtworkTimerF315.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF315").SetValueAsync(WriteArtworkTimerF315);
            
            // G101
			DataFillingInformation.DBArtworkTimersG101 = WriteArtworkTimerG101.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG101").SetValueAsync(WriteArtworkTimerG101);
            
            // G102
			DataFillingInformation.DBArtworkTimersG102 = WriteArtworkTimerG102.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG102").SetValueAsync(WriteArtworkTimerG102);
            
            // G103
			DataFillingInformation.DBArtworkTimersG103 = WriteArtworkTimerG103.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG103").SetValueAsync(WriteArtworkTimerG103);
            
            // G104
			DataFillingInformation.DBArtworkTimersG104 = WriteArtworkTimerG104.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG104").SetValueAsync(WriteArtworkTimerG104);
            
            // G105
			DataFillingInformation.DBArtworkTimersG105 = WriteArtworkTimerG105.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG105").SetValueAsync(WriteArtworkTimerG105);
            
            // G106
			DataFillingInformation.DBArtworkTimersG106 = WriteArtworkTimerG106.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG106").SetValueAsync(WriteArtworkTimerG106);
            
            // G107
			DataFillingInformation.DBArtworkTimersG107 = WriteArtworkTimerG107.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG107").SetValueAsync(WriteArtworkTimerG107);
            
            // G108
			DataFillingInformation.DBArtworkTimersG108 = WriteArtworkTimerG108.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG108").SetValueAsync(WriteArtworkTimerG108);
            
            // G109
			DataFillingInformation.DBArtworkTimersG109 = WriteArtworkTimerG109.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG109").SetValueAsync(WriteArtworkTimerG109);
            
            // G110
			DataFillingInformation.DBArtworkTimersG110 = WriteArtworkTimerG110.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG110").SetValueAsync(WriteArtworkTimerG110);
            
            // G111
			DataFillingInformation.DBArtworkTimersG111 = WriteArtworkTimerG111.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG111").SetValueAsync(WriteArtworkTimerG111);
            
            // G112
			DataFillingInformation.DBArtworkTimersG112 = WriteArtworkTimerG112.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG112").SetValueAsync(WriteArtworkTimerG112);
            
            // G113
			DataFillingInformation.DBArtworkTimersG113 = WriteArtworkTimerG113.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG113").SetValueAsync(WriteArtworkTimerG113);
            
            // G114
			DataFillingInformation.DBArtworkTimersG114 = WriteArtworkTimerG114.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG114").SetValueAsync(WriteArtworkTimerG114);
            
            // G115
			DataFillingInformation.DBArtworkTimersG115 = WriteArtworkTimerG115.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG115").SetValueAsync(WriteArtworkTimerG115);
            
            // G201
			DataFillingInformation.DBArtworkTimersG201 = WriteArtworkTimerG201.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG201").SetValueAsync(WriteArtworkTimerG201);
            
            // G202
			DataFillingInformation.DBArtworkTimersG202 = WriteArtworkTimerG202.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG202").SetValueAsync(WriteArtworkTimerG202);
            
            // G203
			DataFillingInformation.DBArtworkTimersG203 = WriteArtworkTimerG203.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG203").SetValueAsync(WriteArtworkTimerG203);
            
            // G204
			DataFillingInformation.DBArtworkTimersG204 = WriteArtworkTimerG204.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG204").SetValueAsync(WriteArtworkTimerG204);
            
            // G205
			DataFillingInformation.DBArtworkTimersG205 = WriteArtworkTimerG205.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG205").SetValueAsync(WriteArtworkTimerG205);
            
            // G206
			DataFillingInformation.DBArtworkTimersG206 = WriteArtworkTimerG206.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG206").SetValueAsync(WriteArtworkTimerG206);
            
            // G207
			DataFillingInformation.DBArtworkTimersG207 = WriteArtworkTimerG207.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG207").SetValueAsync(WriteArtworkTimerG207);
            
            // G208
			DataFillingInformation.DBArtworkTimersG208 = WriteArtworkTimerG208.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG208").SetValueAsync(WriteArtworkTimerG208);
            
            // G209
			DataFillingInformation.DBArtworkTimersG209 = WriteArtworkTimerG209.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG209").SetValueAsync(WriteArtworkTimerG209);
            
            // G210
			DataFillingInformation.DBArtworkTimersG210 = WriteArtworkTimerG210.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG210").SetValueAsync(WriteArtworkTimerG210);
            
            // G211
			DataFillingInformation.DBArtworkTimersG211 = WriteArtworkTimerG211.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG211").SetValueAsync(WriteArtworkTimerG211);
            
            // G212
			DataFillingInformation.DBArtworkTimersG212 = WriteArtworkTimerG212.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG212").SetValueAsync(WriteArtworkTimerG212);
            
            // G213
			DataFillingInformation.DBArtworkTimersG213 = WriteArtworkTimerG213.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG213").SetValueAsync(WriteArtworkTimerG213);
            
            // G214
			DataFillingInformation.DBArtworkTimersG214 = WriteArtworkTimerG214.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG214").SetValueAsync(WriteArtworkTimerG214);
            
            // G215
			DataFillingInformation.DBArtworkTimersG215 = WriteArtworkTimerG215.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG215").SetValueAsync(WriteArtworkTimerG215);
            
            // G301
			DataFillingInformation.DBArtworkTimersG301 = WriteArtworkTimerG301.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG301").SetValueAsync(WriteArtworkTimerG301);
            
            // G302
			DataFillingInformation.DBArtworkTimersG302 = WriteArtworkTimerG302.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG302").SetValueAsync(WriteArtworkTimerG302);
            
            // G303
			DataFillingInformation.DBArtworkTimersG303 = WriteArtworkTimerG303.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG303").SetValueAsync(WriteArtworkTimerG303);
            
            // G304
			DataFillingInformation.DBArtworkTimersG304 = WriteArtworkTimerG304.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG304").SetValueAsync(WriteArtworkTimerG304);
            
            // G305
			DataFillingInformation.DBArtworkTimersG305 = WriteArtworkTimerG305.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG305").SetValueAsync(WriteArtworkTimerG305);
            
            // G306
			DataFillingInformation.DBArtworkTimersG306 = WriteArtworkTimerG306.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG306").SetValueAsync(WriteArtworkTimerG306);
            
            // G307
			DataFillingInformation.DBArtworkTimersG307 = WriteArtworkTimerG307.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG307").SetValueAsync(WriteArtworkTimerG307);
            
            // G308
			DataFillingInformation.DBArtworkTimersG308 = WriteArtworkTimerG308.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG308").SetValueAsync(WriteArtworkTimerG308);
            
            // G309
			DataFillingInformation.DBArtworkTimersG309 = WriteArtworkTimerG309.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG309").SetValueAsync(WriteArtworkTimerG309);
            
            // G310
			DataFillingInformation.DBArtworkTimersG310 = WriteArtworkTimerG310.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG310").SetValueAsync(WriteArtworkTimerG310);
            
            // G311
			DataFillingInformation.DBArtworkTimersG311 = WriteArtworkTimerG311.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG311").SetValueAsync(WriteArtworkTimerG311);
            
            // G312
			DataFillingInformation.DBArtworkTimersG312 = WriteArtworkTimerG312.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG312").SetValueAsync(WriteArtworkTimerG312);
            
            // G313
			DataFillingInformation.DBArtworkTimersG313 = WriteArtworkTimerG313.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG313").SetValueAsync(WriteArtworkTimerG313);
            
            // G314
			DataFillingInformation.DBArtworkTimersG314 = WriteArtworkTimerG314.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG314").SetValueAsync(WriteArtworkTimerG314);
            
            // G315
			DataFillingInformation.DBArtworkTimersG315 = WriteArtworkTimerG315.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG315").SetValueAsync(WriteArtworkTimerG315);
            
            // FB01
			DataFillingInformation.DBArtworkTimersFB01 = WriteArtworkTimerFB01.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB01").SetValueAsync(WriteArtworkTimerFB01);
            
            // FB02
			DataFillingInformation.DBArtworkTimersFB02 = WriteArtworkTimerFB02.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB02").SetValueAsync(WriteArtworkTimerFB02);
            
            // FB03
			DataFillingInformation.DBArtworkTimersFB03 = WriteArtworkTimerFB03.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB03").SetValueAsync(WriteArtworkTimerFB03);
            
            // FB04
			DataFillingInformation.DBArtworkTimersFB04 = WriteArtworkTimerFB04.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB04").SetValueAsync(WriteArtworkTimerFB04);
            
            // FB05
			DataFillingInformation.DBArtworkTimersFB05 = WriteArtworkTimerFB05.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB05").SetValueAsync(WriteArtworkTimerFB05);
            
            // FB06
			DataFillingInformation.DBArtworkTimersFB06 = WriteArtworkTimerFB06.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB06").SetValueAsync(WriteArtworkTimerFB06);
            
            // FB07
			DataFillingInformation.DBArtworkTimersFB07 = WriteArtworkTimerFB07.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB07").SetValueAsync(WriteArtworkTimerFB07);
            
            // FB08
			DataFillingInformation.DBArtworkTimersFB08 = WriteArtworkTimerFB08.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB08").SetValueAsync(WriteArtworkTimerFB08);
            
            // FB09
			DataFillingInformation.DBArtworkTimersFB09 = WriteArtworkTimerFB09.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB09").SetValueAsync(WriteArtworkTimerFB09);
            
            // FB10
			DataFillingInformation.DBArtworkTimersFB10 = WriteArtworkTimerFB10.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB10").SetValueAsync(WriteArtworkTimerFB10);
            
            // FB11
			DataFillingInformation.DBArtworkTimersFB11 = WriteArtworkTimerFB11.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB11").SetValueAsync(WriteArtworkTimerFB11);
            
            // FB12
			DataFillingInformation.DBArtworkTimersFB12 = WriteArtworkTimerFB12.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB12").SetValueAsync(WriteArtworkTimerFB12);
            
            // FB13
			DataFillingInformation.DBArtworkTimersFB13 = WriteArtworkTimerFB13.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB13").SetValueAsync(WriteArtworkTimerFB13);
            
            // FB14
			DataFillingInformation.DBArtworkTimersFB14 = WriteArtworkTimerFB14.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB14").SetValueAsync(WriteArtworkTimerFB14);
            
            // FB15
			DataFillingInformation.DBArtworkTimersFB15 = WriteArtworkTimerFB15.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB15").SetValueAsync(WriteArtworkTimerFB15);
            
            // FBonus01
			DataFillingInformation.DBBonusArtworkTimers01 = WriteArtworkTimerFBonus01.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBonusArtworkTimers01").SetValueAsync(WriteArtworkTimerFBonus01);
            
            // FBonus02
			DataFillingInformation.DBBonusArtworkTimers02 = WriteArtworkTimerFBonus02.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBonusArtworkTimers02").SetValueAsync(WriteArtworkTimerFBonus02);
            
            // FBonus03
			DataFillingInformation.DBBonusArtworkTimers03 = WriteArtworkTimerFBonus03.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBonusArtworkTimers03").SetValueAsync(WriteArtworkTimerFBonus03);
            
            // FBonus04
			DataFillingInformation.DBBonusArtworkTimers04 = WriteArtworkTimerFBonus04.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBonusArtworkTimers04").SetValueAsync(WriteArtworkTimerFBonus04);
            
            // FBonus05
			DataFillingInformation.DBBonusArtworkTimers05 = WriteArtworkTimerFBonus05.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBonusArtworkTimers05").SetValueAsync(WriteArtworkTimerFBonus05);
            
            // FBonus06
			DataFillingInformation.DBBonusArtworkTimers06 = WriteArtworkTimerFBonus06.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBonusArtworkTimers06").SetValueAsync(WriteArtworkTimerFBonus06);
            
            // FBonus07
			DataFillingInformation.DBBonusArtworkTimers07 = WriteArtworkTimerFBonus07.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBonusArtworkTimers07").SetValueAsync(WriteArtworkTimerFBonus07);
            
            // FBonus08
			DataFillingInformation.DBBonusArtworkTimers08 = WriteArtworkTimerFBonus08.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBonusArtworkTimers08").SetValueAsync(WriteArtworkTimerFBonus08);
            
            // FBonus09
			DataFillingInformation.DBBonusArtworkTimers09 = WriteArtworkTimerFBonus09.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBonusArtworkTimers09").SetValueAsync(WriteArtworkTimerFBonus09);
            
            // FBonus10
			DataFillingInformation.DBBonusArtworkTimers10 = WriteArtworkTimerFBonus10.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBBonusArtworkTimers10").SetValueAsync(WriteArtworkTimerFBonus10);
            
            // F101Added
			DataFillingInformation.DBArtworkTimersF101Added = WriteArtworkTimerF101Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF101Added").SetValueAsync(WriteArtworkTimerF101Added);
            
            // F102Added
			DataFillingInformation.DBArtworkTimersF102Added = WriteArtworkTimerF102Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF102Added").SetValueAsync(WriteArtworkTimerF102Added);
            
            // F103Added
			DataFillingInformation.DBArtworkTimersF103Added = WriteArtworkTimerF103Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF103Added").SetValueAsync(WriteArtworkTimerF103Added);
            
            // F104Added
			DataFillingInformation.DBArtworkTimersF104Added = WriteArtworkTimerF104Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF104Added").SetValueAsync(WriteArtworkTimerF104Added);
            
            // F105Added
			DataFillingInformation.DBArtworkTimersF105Added = WriteArtworkTimerF105Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF105Added").SetValueAsync(WriteArtworkTimerF105Added);
            
            // F106Added
			DataFillingInformation.DBArtworkTimersF106Added = WriteArtworkTimerF106Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF106Added").SetValueAsync(WriteArtworkTimerF106Added);
            
            // F107Added
			DataFillingInformation.DBArtworkTimersF107Added = WriteArtworkTimerF107Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF107Added").SetValueAsync(WriteArtworkTimerF107Added);
            
            // F108Added
			DataFillingInformation.DBArtworkTimersF108Added = WriteArtworkTimerF108Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF108Added").SetValueAsync(WriteArtworkTimerF108Added);
            
            // F201Added
			DataFillingInformation.DBArtworkTimersF201Added = WriteArtworkTimerF201Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF201Added").SetValueAsync(WriteArtworkTimerF201Added);
            
            // F202Added
			DataFillingInformation.DBArtworkTimersF202Added = WriteArtworkTimerF202Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF202Added").SetValueAsync(WriteArtworkTimerF202Added);
            
            // F203Added
			DataFillingInformation.DBArtworkTimersF203Added = WriteArtworkTimerF203Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF203Added").SetValueAsync(WriteArtworkTimerF203Added);
            
            // F204Added
			DataFillingInformation.DBArtworkTimersF204Added = WriteArtworkTimerF204Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF204Added").SetValueAsync(WriteArtworkTimerF204Added);
            
            // F205Added
			DataFillingInformation.DBArtworkTimersF205Added = WriteArtworkTimerF205Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF205Added").SetValueAsync(WriteArtworkTimerF205Added);
            
            // F206Added
			DataFillingInformation.DBArtworkTimersF206Added = WriteArtworkTimerF206Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF206Added").SetValueAsync(WriteArtworkTimerF206Added);
            
            // F207Added
			DataFillingInformation.DBArtworkTimersF207Added = WriteArtworkTimerF207Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF207Added").SetValueAsync(WriteArtworkTimerF207Added);
            
            // F208Added
			DataFillingInformation.DBArtworkTimersF208Added = WriteArtworkTimerF208Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF208Added").SetValueAsync(WriteArtworkTimerF208Added);
            
            // F301Added
			DataFillingInformation.DBArtworkTimersF301Added = WriteArtworkTimerF301Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF301Added").SetValueAsync(WriteArtworkTimerF301Added);
            
            // F302Added
			DataFillingInformation.DBArtworkTimersF302Added = WriteArtworkTimerF302Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF302Added").SetValueAsync(WriteArtworkTimerF302Added);
            
            // F303Added
			DataFillingInformation.DBArtworkTimersF303Added = WriteArtworkTimerF303Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF303Added").SetValueAsync(WriteArtworkTimerF303Added);
            
            // F304Added
			DataFillingInformation.DBArtworkTimersF304Added = WriteArtworkTimerF304Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF304Added").SetValueAsync(WriteArtworkTimerF304Added);
            
            // F305Added
			DataFillingInformation.DBArtworkTimersF305Added = WriteArtworkTimerF305Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF305Added").SetValueAsync(WriteArtworkTimerF305Added);
            
            // F306Added
			DataFillingInformation.DBArtworkTimersF306Added = WriteArtworkTimerF306Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF306Added").SetValueAsync(WriteArtworkTimerF306Added);
            
            // F307Added
			DataFillingInformation.DBArtworkTimersF307Added = WriteArtworkTimerF307Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF307Added").SetValueAsync(WriteArtworkTimerF307Added);
            
            // F308Added
			DataFillingInformation.DBArtworkTimersF308Added = WriteArtworkTimerF308Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersF308Added").SetValueAsync(WriteArtworkTimerF308Added);
            
            // G101Added
			DataFillingInformation.DBArtworkTimersG101Added = WriteArtworkTimerG101Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG101Added").SetValueAsync(WriteArtworkTimerG101Added);
            
            // G102Added
			DataFillingInformation.DBArtworkTimersG102Added = WriteArtworkTimerG102Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG102Added").SetValueAsync(WriteArtworkTimerG102Added);
            
            // G103Added
			DataFillingInformation.DBArtworkTimersG103Added = WriteArtworkTimerG103Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG103Added").SetValueAsync(WriteArtworkTimerG103Added);
            
            // G104Added
			DataFillingInformation.DBArtworkTimersG104Added = WriteArtworkTimerG104Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG104Added").SetValueAsync(WriteArtworkTimerG104Added);
            
            // G105Added
			DataFillingInformation.DBArtworkTimersG105Added = WriteArtworkTimerG105Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG105Added").SetValueAsync(WriteArtworkTimerG105Added);
            
            // G106Added
			DataFillingInformation.DBArtworkTimersG106Added = WriteArtworkTimerG106Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG106Added").SetValueAsync(WriteArtworkTimerG106Added);
            
            // G107Added
			DataFillingInformation.DBArtworkTimersG107Added = WriteArtworkTimerG107Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG107Added").SetValueAsync(WriteArtworkTimerG107Added);
            
            // G108Added
			DataFillingInformation.DBArtworkTimersG108Added = WriteArtworkTimerG108Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG108Added").SetValueAsync(WriteArtworkTimerG108Added);
            
            // G201Added
			DataFillingInformation.DBArtworkTimersG201Added = WriteArtworkTimerG201Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG201Added").SetValueAsync(WriteArtworkTimerG201Added);
            
            // G202Added
			DataFillingInformation.DBArtworkTimersG202Added = WriteArtworkTimerG202Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG202Added").SetValueAsync(WriteArtworkTimerG202Added);
            
            // G203Added
			DataFillingInformation.DBArtworkTimersG203Added = WriteArtworkTimerG203Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG203Added").SetValueAsync(WriteArtworkTimerG203Added);
            
            // G204Added
			DataFillingInformation.DBArtworkTimersG204Added = WriteArtworkTimerG204Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG204Added").SetValueAsync(WriteArtworkTimerG204Added);
            
            // G205Added
			DataFillingInformation.DBArtworkTimersG205Added = WriteArtworkTimerG205Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG205Added").SetValueAsync(WriteArtworkTimerG205Added);
            
            // G206Added
			DataFillingInformation.DBArtworkTimersG206Added = WriteArtworkTimerG206Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG206Added").SetValueAsync(WriteArtworkTimerG206Added);
            
            // G207Added
			DataFillingInformation.DBArtworkTimersG207Added = WriteArtworkTimerG207Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG207Added").SetValueAsync(WriteArtworkTimerG207Added);
            
            // G208Added
			DataFillingInformation.DBArtworkTimersG208Added = WriteArtworkTimerG208Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG208Added").SetValueAsync(WriteArtworkTimerG208Added);
            
            // G301Added
			DataFillingInformation.DBArtworkTimersG301Added = WriteArtworkTimerG301Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG301Added").SetValueAsync(WriteArtworkTimerG301Added);
            
            // G302Added
			DataFillingInformation.DBArtworkTimersG302Added = WriteArtworkTimerG302Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG302Added").SetValueAsync(WriteArtworkTimerG302Added);
            
            // G303Added
			DataFillingInformation.DBArtworkTimersG303Added = WriteArtworkTimerG303Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG303Added").SetValueAsync(WriteArtworkTimerG303Added);
            
            // G304Added
			DataFillingInformation.DBArtworkTimersG304Added = WriteArtworkTimerG304Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG304Added").SetValueAsync(WriteArtworkTimerG304Added);
            
            // G305Added
			DataFillingInformation.DBArtworkTimersG305Added = WriteArtworkTimerG305Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG305Added").SetValueAsync(WriteArtworkTimerG305Added);
            
            // G306Added
			DataFillingInformation.DBArtworkTimersG306Added = WriteArtworkTimerG306Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG306Added").SetValueAsync(WriteArtworkTimerG306Added);
            
            // G307Added
			DataFillingInformation.DBArtworkTimersG307Added = WriteArtworkTimerG307Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG307Added").SetValueAsync(WriteArtworkTimerG307Added);
            
            // G308Added
			DataFillingInformation.DBArtworkTimersG308Added = WriteArtworkTimerG308Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersG308Added").SetValueAsync(WriteArtworkTimerG308Added);
            
            // FB01Added
			DataFillingInformation.DBArtworkTimersFB01Added = WriteArtworkTimerFB01Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB01Added").SetValueAsync(WriteArtworkTimerFB01Added);
            
            // FB02Added
			DataFillingInformation.DBArtworkTimersFB02Added = WriteArtworkTimerFB02Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB02Added").SetValueAsync(WriteArtworkTimerFB02Added);
            
            // FB03Added
			DataFillingInformation.DBArtworkTimersFB03Added = WriteArtworkTimerFB03Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB03Added").SetValueAsync(WriteArtworkTimerFB03Added);
            
            // FB04Added
			DataFillingInformation.DBArtworkTimersFB04Added = WriteArtworkTimerFB04Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB04Added").SetValueAsync(WriteArtworkTimerFB04Added);
            
            // FB05Added
			DataFillingInformation.DBArtworkTimersFB05Added = WriteArtworkTimerFB05Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB05Added").SetValueAsync(WriteArtworkTimerFB05Added);
            
            // FB06Added
			DataFillingInformation.DBArtworkTimersFB06Added = WriteArtworkTimerFB06Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB06Added").SetValueAsync(WriteArtworkTimerFB06Added);
            
            // FB07Added
			DataFillingInformation.DBArtworkTimersFB07Added = WriteArtworkTimerFB07Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB07Added").SetValueAsync(WriteArtworkTimerFB07Added);
            
            // FB08Added
			DataFillingInformation.DBArtworkTimersFB08Added = WriteArtworkTimerFB08Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB08Added").SetValueAsync(WriteArtworkTimerFB08Added);
            
            // FB09Added
			DataFillingInformation.DBArtworkTimersFB09Added = WriteArtworkTimerFB09Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB09Added").SetValueAsync(WriteArtworkTimerFB09Added);
            
            // FB10Added
			DataFillingInformation.DBArtworkTimersFB10Added = WriteArtworkTimerFB10Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.NewPlayer.UserId).Child("DBArtworkTimersFB10Added").SetValueAsync(WriteArtworkTimerFB10Added);
        }
        
        if (DataFillingInformation.AuthLoggedOrSigned == 1) {
            // F101
			DataFillingInformation.DBArtworkTimersF101 = WriteArtworkTimerF101.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF101").SetValueAsync(WriteArtworkTimerF101);
            
            // F102
			DataFillingInformation.DBArtworkTimersF102 = WriteArtworkTimerF102.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF102").SetValueAsync(WriteArtworkTimerF102);
            
            // F103
			DataFillingInformation.DBArtworkTimersF103 = WriteArtworkTimerF103.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF103").SetValueAsync(WriteArtworkTimerF103);
            
            // F104
			DataFillingInformation.DBArtworkTimersF104 = WriteArtworkTimerF104.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF104").SetValueAsync(WriteArtworkTimerF104);
            
            // F105
			DataFillingInformation.DBArtworkTimersF105 = WriteArtworkTimerF105.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF105").SetValueAsync(WriteArtworkTimerF105);
            
            // F106
			DataFillingInformation.DBArtworkTimersF106 = WriteArtworkTimerF106.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF106").SetValueAsync(WriteArtworkTimerF106);
            
            // F107
			DataFillingInformation.DBArtworkTimersF107 = WriteArtworkTimerF107.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF107").SetValueAsync(WriteArtworkTimerF107);
            
            // F108
			DataFillingInformation.DBArtworkTimersF108 = WriteArtworkTimerF108.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF108").SetValueAsync(WriteArtworkTimerF108);
            
            // F109
			DataFillingInformation.DBArtworkTimersF109 = WriteArtworkTimerF109.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF109").SetValueAsync(WriteArtworkTimerF109);
            
            // F110
			DataFillingInformation.DBArtworkTimersF110 = WriteArtworkTimerF110.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF110").SetValueAsync(WriteArtworkTimerF110);
            
            // F111
			DataFillingInformation.DBArtworkTimersF111 = WriteArtworkTimerF111.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF111").SetValueAsync(WriteArtworkTimerF111);
            
            // F112
			DataFillingInformation.DBArtworkTimersF112 = WriteArtworkTimerF112.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF112").SetValueAsync(WriteArtworkTimerF112);
            
            // F113
			DataFillingInformation.DBArtworkTimersF113 = WriteArtworkTimerF113.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF113").SetValueAsync(WriteArtworkTimerF113);
            
            // F114
			DataFillingInformation.DBArtworkTimersF114 = WriteArtworkTimerF114.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF114").SetValueAsync(WriteArtworkTimerF114);
            
            // F115
			DataFillingInformation.DBArtworkTimersF115 = WriteArtworkTimerF115.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF115").SetValueAsync(WriteArtworkTimerF115);
            
            // F201
			DataFillingInformation.DBArtworkTimersF201 = WriteArtworkTimerF201.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF201").SetValueAsync(WriteArtworkTimerF201);
            
            // F202
			DataFillingInformation.DBArtworkTimersF202 = WriteArtworkTimerF202.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF202").SetValueAsync(WriteArtworkTimerF202);
            
            // F203
			DataFillingInformation.DBArtworkTimersF203 = WriteArtworkTimerF203.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF203").SetValueAsync(WriteArtworkTimerF203);
            
            // F204
			DataFillingInformation.DBArtworkTimersF204 = WriteArtworkTimerF204.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF204").SetValueAsync(WriteArtworkTimerF204);
            
            // F205
			DataFillingInformation.DBArtworkTimersF205 = WriteArtworkTimerF205.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF205").SetValueAsync(WriteArtworkTimerF205);
            
            // F206
			DataFillingInformation.DBArtworkTimersF206 = WriteArtworkTimerF206.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF206").SetValueAsync(WriteArtworkTimerF206);
            
            // F207
			DataFillingInformation.DBArtworkTimersF207 = WriteArtworkTimerF207.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF207").SetValueAsync(WriteArtworkTimerF207);
            
            // F208
			DataFillingInformation.DBArtworkTimersF208 = WriteArtworkTimerF208.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF208").SetValueAsync(WriteArtworkTimerF208);
            
            // F209
			DataFillingInformation.DBArtworkTimersF209 = WriteArtworkTimerF209.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF209").SetValueAsync(WriteArtworkTimerF209);
            
            // F210
			DataFillingInformation.DBArtworkTimersF210 = WriteArtworkTimerF210.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF210").SetValueAsync(WriteArtworkTimerF210);
            
            // F211
			DataFillingInformation.DBArtworkTimersF211 = WriteArtworkTimerF211.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF211").SetValueAsync(WriteArtworkTimerF211);
            
            // F212
			DataFillingInformation.DBArtworkTimersF212 = WriteArtworkTimerF212.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF212").SetValueAsync(WriteArtworkTimerF212);
            
            // F213
			DataFillingInformation.DBArtworkTimersF213 = WriteArtworkTimerF213.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF213").SetValueAsync(WriteArtworkTimerF213);
            
            // F214
			DataFillingInformation.DBArtworkTimersF214 = WriteArtworkTimerF214.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF214").SetValueAsync(WriteArtworkTimerF214);
            
            // F215
			DataFillingInformation.DBArtworkTimersF215 = WriteArtworkTimerF215.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF215").SetValueAsync(WriteArtworkTimerF215);
            
            // F301
			DataFillingInformation.DBArtworkTimersF301 = WriteArtworkTimerF301.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF301").SetValueAsync(WriteArtworkTimerF301);
            
            // F302
			DataFillingInformation.DBArtworkTimersF302 = WriteArtworkTimerF302.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF302").SetValueAsync(WriteArtworkTimerF302);
            
            // F303
			DataFillingInformation.DBArtworkTimersF303 = WriteArtworkTimerF303.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF303").SetValueAsync(WriteArtworkTimerF303);
            
            // F304
			DataFillingInformation.DBArtworkTimersF304 = WriteArtworkTimerF304.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF304").SetValueAsync(WriteArtworkTimerF304);
            
            // F305
			DataFillingInformation.DBArtworkTimersF305 = WriteArtworkTimerF305.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF305").SetValueAsync(WriteArtworkTimerF305);
            
            // F306
			DataFillingInformation.DBArtworkTimersF306 = WriteArtworkTimerF306.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF306").SetValueAsync(WriteArtworkTimerF306);
            
            // F307
			DataFillingInformation.DBArtworkTimersF307 = WriteArtworkTimerF307.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF307").SetValueAsync(WriteArtworkTimerF307);
            
            // F308
			DataFillingInformation.DBArtworkTimersF308 = WriteArtworkTimerF308.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF308").SetValueAsync(WriteArtworkTimerF308);
            
            // F309
			DataFillingInformation.DBArtworkTimersF309 = WriteArtworkTimerF309.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF309").SetValueAsync(WriteArtworkTimerF309);
            
            // F310
			DataFillingInformation.DBArtworkTimersF310 = WriteArtworkTimerF310.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF310").SetValueAsync(WriteArtworkTimerF310);
            
            // F311
			DataFillingInformation.DBArtworkTimersF311 = WriteArtworkTimerF311.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF311").SetValueAsync(WriteArtworkTimerF311);
            
            // F312
			DataFillingInformation.DBArtworkTimersF312 = WriteArtworkTimerF312.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF312").SetValueAsync(WriteArtworkTimerF312);
            
            // F313
			DataFillingInformation.DBArtworkTimersF313 = WriteArtworkTimerF313.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF313").SetValueAsync(WriteArtworkTimerF313);
            
            // F314
			DataFillingInformation.DBArtworkTimersF314 = WriteArtworkTimerF314.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF314").SetValueAsync(WriteArtworkTimerF314);
            
            // F315
			DataFillingInformation.DBArtworkTimersF315 = WriteArtworkTimerF315.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF315").SetValueAsync(WriteArtworkTimerF315);
            
            // G101
			DataFillingInformation.DBArtworkTimersG101 = WriteArtworkTimerG101.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG101").SetValueAsync(WriteArtworkTimerG101);
            
            // G102
			DataFillingInformation.DBArtworkTimersG102 = WriteArtworkTimerG102.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG102").SetValueAsync(WriteArtworkTimerG102);
            
            // G103
			DataFillingInformation.DBArtworkTimersG103 = WriteArtworkTimerG103.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG103").SetValueAsync(WriteArtworkTimerG103);
            
            // G104
			DataFillingInformation.DBArtworkTimersG104 = WriteArtworkTimerG104.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG104").SetValueAsync(WriteArtworkTimerG104);
            
            // G105
			DataFillingInformation.DBArtworkTimersG105 = WriteArtworkTimerG105.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG105").SetValueAsync(WriteArtworkTimerG105);
            
            // G106
			DataFillingInformation.DBArtworkTimersG106 = WriteArtworkTimerG106.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG106").SetValueAsync(WriteArtworkTimerG106);
            
            // G107
			DataFillingInformation.DBArtworkTimersG107 = WriteArtworkTimerG107.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG107").SetValueAsync(WriteArtworkTimerG107);
            
            // G108
			DataFillingInformation.DBArtworkTimersG108 = WriteArtworkTimerG108.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG108").SetValueAsync(WriteArtworkTimerG108);
            
            // G109
			DataFillingInformation.DBArtworkTimersG109 = WriteArtworkTimerG109.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG109").SetValueAsync(WriteArtworkTimerG109);
            
            // G110
			DataFillingInformation.DBArtworkTimersG110 = WriteArtworkTimerG110.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG110").SetValueAsync(WriteArtworkTimerG110);
            
            // G111
			DataFillingInformation.DBArtworkTimersG111 = WriteArtworkTimerG111.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG111").SetValueAsync(WriteArtworkTimerG111);
            
            // G112
			DataFillingInformation.DBArtworkTimersG112 = WriteArtworkTimerG112.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG112").SetValueAsync(WriteArtworkTimerG112);
            
            // G113
			DataFillingInformation.DBArtworkTimersG113 = WriteArtworkTimerG113.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG113").SetValueAsync(WriteArtworkTimerG113);
            
            // G114
			DataFillingInformation.DBArtworkTimersG114 = WriteArtworkTimerG114.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG114").SetValueAsync(WriteArtworkTimerG114);
            
            // G115
			DataFillingInformation.DBArtworkTimersG115 = WriteArtworkTimerG115.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG115").SetValueAsync(WriteArtworkTimerG115);
            
            // G201
			DataFillingInformation.DBArtworkTimersG201 = WriteArtworkTimerG201.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG201").SetValueAsync(WriteArtworkTimerG201);
            
            // G202
			DataFillingInformation.DBArtworkTimersG202 = WriteArtworkTimerG202.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG202").SetValueAsync(WriteArtworkTimerG202);
            
            // G203
			DataFillingInformation.DBArtworkTimersG203 = WriteArtworkTimerG203.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG203").SetValueAsync(WriteArtworkTimerG203);
            
            // G204
			DataFillingInformation.DBArtworkTimersG204 = WriteArtworkTimerG204.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG204").SetValueAsync(WriteArtworkTimerG204);
            
            // G205
			DataFillingInformation.DBArtworkTimersG205 = WriteArtworkTimerG205.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG205").SetValueAsync(WriteArtworkTimerG205);
            
            // G206
			DataFillingInformation.DBArtworkTimersG206 = WriteArtworkTimerG206.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG206").SetValueAsync(WriteArtworkTimerG206);
            
            // G207
			DataFillingInformation.DBArtworkTimersG207 = WriteArtworkTimerG207.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG207").SetValueAsync(WriteArtworkTimerG207);
            
            // G208
			DataFillingInformation.DBArtworkTimersG208 = WriteArtworkTimerG208.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG208").SetValueAsync(WriteArtworkTimerG208);
            
            // G209
			DataFillingInformation.DBArtworkTimersG209 = WriteArtworkTimerG209.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG209").SetValueAsync(WriteArtworkTimerG209);
            
            // G210
			DataFillingInformation.DBArtworkTimersG210 = WriteArtworkTimerG210.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG210").SetValueAsync(WriteArtworkTimerG210);
            
            // G211
			DataFillingInformation.DBArtworkTimersG211 = WriteArtworkTimerG211.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG211").SetValueAsync(WriteArtworkTimerG211);
            
            // G212
			DataFillingInformation.DBArtworkTimersG212 = WriteArtworkTimerG212.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG212").SetValueAsync(WriteArtworkTimerG212);
            
            // G213
			DataFillingInformation.DBArtworkTimersG213 = WriteArtworkTimerG213.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG213").SetValueAsync(WriteArtworkTimerG213);
            
            // G214
			DataFillingInformation.DBArtworkTimersG214 = WriteArtworkTimerG214.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG214").SetValueAsync(WriteArtworkTimerG214);
            
            // G215
			DataFillingInformation.DBArtworkTimersG215 = WriteArtworkTimerG215.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG215").SetValueAsync(WriteArtworkTimerG215);
            
            // G301
			DataFillingInformation.DBArtworkTimersG301 = WriteArtworkTimerG301.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG301").SetValueAsync(WriteArtworkTimerG301);
            
            // G302
			DataFillingInformation.DBArtworkTimersG302 = WriteArtworkTimerG302.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG302").SetValueAsync(WriteArtworkTimerG302);
            
            // G303
			DataFillingInformation.DBArtworkTimersG303 = WriteArtworkTimerG303.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG303").SetValueAsync(WriteArtworkTimerG303);
            
            // G304
			DataFillingInformation.DBArtworkTimersG304 = WriteArtworkTimerG304.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG304").SetValueAsync(WriteArtworkTimerG304);
            
            // G305
			DataFillingInformation.DBArtworkTimersG305 = WriteArtworkTimerG305.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG305").SetValueAsync(WriteArtworkTimerG305);
            
            // G306
			DataFillingInformation.DBArtworkTimersG306 = WriteArtworkTimerG306.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG306").SetValueAsync(WriteArtworkTimerG306);
            
            // G307
			DataFillingInformation.DBArtworkTimersG307 = WriteArtworkTimerG307.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG307").SetValueAsync(WriteArtworkTimerG307);
            
            // G308
			DataFillingInformation.DBArtworkTimersG308 = WriteArtworkTimerG308.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG308").SetValueAsync(WriteArtworkTimerG308);
            
            // G309
			DataFillingInformation.DBArtworkTimersG309 = WriteArtworkTimerG309.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG309").SetValueAsync(WriteArtworkTimerG309);
            
            // G310
			DataFillingInformation.DBArtworkTimersG310 = WriteArtworkTimerG310.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG310").SetValueAsync(WriteArtworkTimerG310);
            
            // G311
			DataFillingInformation.DBArtworkTimersG311 = WriteArtworkTimerG311.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG311").SetValueAsync(WriteArtworkTimerG311);
            
            // G312
			DataFillingInformation.DBArtworkTimersG312 = WriteArtworkTimerG312.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG312").SetValueAsync(WriteArtworkTimerG312);
            
            // G313
			DataFillingInformation.DBArtworkTimersG313 = WriteArtworkTimerG313.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG313").SetValueAsync(WriteArtworkTimerG313);
            
            // G314
			DataFillingInformation.DBArtworkTimersG314 = WriteArtworkTimerG314.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG314").SetValueAsync(WriteArtworkTimerG314);
            
            // G315
			DataFillingInformation.DBArtworkTimersG315 = WriteArtworkTimerG315.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG315").SetValueAsync(WriteArtworkTimerG315);
            
            // FB01
			DataFillingInformation.DBArtworkTimersFB01 = WriteArtworkTimerFB01.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB01").SetValueAsync(WriteArtworkTimerFB01);
            
            // FB02
			DataFillingInformation.DBArtworkTimersFB02 = WriteArtworkTimerFB02.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB02").SetValueAsync(WriteArtworkTimerFB02);
            
            // FB03
			DataFillingInformation.DBArtworkTimersFB03 = WriteArtworkTimerFB03.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB03").SetValueAsync(WriteArtworkTimerFB03);
            
            // FB04
			DataFillingInformation.DBArtworkTimersFB04 = WriteArtworkTimerFB04.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB04").SetValueAsync(WriteArtworkTimerFB04);
            
            // FB05
			DataFillingInformation.DBArtworkTimersFB05 = WriteArtworkTimerFB05.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB05").SetValueAsync(WriteArtworkTimerFB05);
            
            // FB06
			DataFillingInformation.DBArtworkTimersFB06 = WriteArtworkTimerFB06.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB06").SetValueAsync(WriteArtworkTimerFB06);
            
            // FB07
			DataFillingInformation.DBArtworkTimersFB07 = WriteArtworkTimerFB07.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB07").SetValueAsync(WriteArtworkTimerFB07);
            
            // FB08
			DataFillingInformation.DBArtworkTimersFB08 = WriteArtworkTimerFB08.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB08").SetValueAsync(WriteArtworkTimerFB08);
            
            // FB09
			DataFillingInformation.DBArtworkTimersFB09 = WriteArtworkTimerFB09.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB09").SetValueAsync(WriteArtworkTimerFB09);
            
            // FB10
			DataFillingInformation.DBArtworkTimersFB10 = WriteArtworkTimerFB10.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB10").SetValueAsync(WriteArtworkTimerFB10);
            
            // FB11
			DataFillingInformation.DBArtworkTimersFB11 = WriteArtworkTimerFB11.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB11").SetValueAsync(WriteArtworkTimerFB11);
            
            // FB12
			DataFillingInformation.DBArtworkTimersFB12 = WriteArtworkTimerFB12.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB12").SetValueAsync(WriteArtworkTimerFB12);
            
            // FB13
			DataFillingInformation.DBArtworkTimersFB13 = WriteArtworkTimerFB13.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB13").SetValueAsync(WriteArtworkTimerFB13);
            
            // FB14
			DataFillingInformation.DBArtworkTimersFB14 = WriteArtworkTimerFB14.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB14").SetValueAsync(WriteArtworkTimerFB14);
            
            // FB15
			DataFillingInformation.DBArtworkTimersFB15 = WriteArtworkTimerFB15.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB15").SetValueAsync(WriteArtworkTimerFB15);
            
            // FBonus01
			DataFillingInformation.DBBonusArtworkTimers01 = WriteArtworkTimerFBonus01.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBonusArtworkTimers01").SetValueAsync(WriteArtworkTimerFBonus01);
            
            // FBonus02
			DataFillingInformation.DBBonusArtworkTimers02 = WriteArtworkTimerFBonus02.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBonusArtworkTimers02").SetValueAsync(WriteArtworkTimerFBonus02);
            
            // FBonus03
			DataFillingInformation.DBBonusArtworkTimers03 = WriteArtworkTimerFBonus03.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBonusArtworkTimers03").SetValueAsync(WriteArtworkTimerFBonus03);
            
            // FBonus04
			DataFillingInformation.DBBonusArtworkTimers04 = WriteArtworkTimerFBonus04.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBonusArtworkTimers04").SetValueAsync(WriteArtworkTimerFBonus04);
            
            // FBonus05
			DataFillingInformation.DBBonusArtworkTimers05 = WriteArtworkTimerFBonus05.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBonusArtworkTimers05").SetValueAsync(WriteArtworkTimerFBonus05);
            
            // FBonus06
			DataFillingInformation.DBBonusArtworkTimers06 = WriteArtworkTimerFBonus06.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBonusArtworkTimers06").SetValueAsync(WriteArtworkTimerFBonus06);
            
            // FBonus07
			DataFillingInformation.DBBonusArtworkTimers07 = WriteArtworkTimerFBonus07.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBonusArtworkTimers07").SetValueAsync(WriteArtworkTimerFBonus07);
            
            // FBonus08
			DataFillingInformation.DBBonusArtworkTimers08 = WriteArtworkTimerFBonus08.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBonusArtworkTimers08").SetValueAsync(WriteArtworkTimerFBonus08);
            
            // FBonus09
			DataFillingInformation.DBBonusArtworkTimers09 = WriteArtworkTimerFBonus09.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBonusArtworkTimers09").SetValueAsync(WriteArtworkTimerFBonus09);
            
            // FBonus10
			DataFillingInformation.DBBonusArtworkTimers10 = WriteArtworkTimerFBonus10.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBBonusArtworkTimers10").SetValueAsync(WriteArtworkTimerFBonus10);
            
            // F101Added
			DataFillingInformation.DBArtworkTimersF101Added = WriteArtworkTimerF101Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF101Added").SetValueAsync(WriteArtworkTimerF101Added);
            
            // F102Added
			DataFillingInformation.DBArtworkTimersF102Added = WriteArtworkTimerF102Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF102Added").SetValueAsync(WriteArtworkTimerF102Added);
            
            // F103Added
			DataFillingInformation.DBArtworkTimersF103Added = WriteArtworkTimerF103Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF103Added").SetValueAsync(WriteArtworkTimerF103Added);
            
            // F104Added
			DataFillingInformation.DBArtworkTimersF104Added = WriteArtworkTimerF104Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF104Added").SetValueAsync(WriteArtworkTimerF104Added);
            
            // F105Added
			DataFillingInformation.DBArtworkTimersF105Added = WriteArtworkTimerF105Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF105Added").SetValueAsync(WriteArtworkTimerF105Added);
            
            // F106Added
			DataFillingInformation.DBArtworkTimersF106Added = WriteArtworkTimerF106Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF106Added").SetValueAsync(WriteArtworkTimerF106Added);
            
            // F107Added
			DataFillingInformation.DBArtworkTimersF107Added = WriteArtworkTimerF107Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF107Added").SetValueAsync(WriteArtworkTimerF107Added);
            
            // F108Added
			DataFillingInformation.DBArtworkTimersF108Added = WriteArtworkTimerF108Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF108Added").SetValueAsync(WriteArtworkTimerF108Added);
            
            // F201Added
			DataFillingInformation.DBArtworkTimersF201Added = WriteArtworkTimerF201Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF201Added").SetValueAsync(WriteArtworkTimerF201Added);
            
            // F202Added
			DataFillingInformation.DBArtworkTimersF202Added = WriteArtworkTimerF202Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF202Added").SetValueAsync(WriteArtworkTimerF202Added);
            
            // F203Added
			DataFillingInformation.DBArtworkTimersF203Added = WriteArtworkTimerF203Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF203Added").SetValueAsync(WriteArtworkTimerF203Added);
            
            // F204Added
			DataFillingInformation.DBArtworkTimersF204Added = WriteArtworkTimerF204Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF204Added").SetValueAsync(WriteArtworkTimerF204Added);
            
            // F205Added
			DataFillingInformation.DBArtworkTimersF205Added = WriteArtworkTimerF205Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF205Added").SetValueAsync(WriteArtworkTimerF205Added);
            
            // F206Added
			DataFillingInformation.DBArtworkTimersF206Added = WriteArtworkTimerF206Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF206Added").SetValueAsync(WriteArtworkTimerF206Added);
            
            // F207Added
			DataFillingInformation.DBArtworkTimersF207Added = WriteArtworkTimerF207Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF207Added").SetValueAsync(WriteArtworkTimerF207Added);
            
            // F208Added
			DataFillingInformation.DBArtworkTimersF208Added = WriteArtworkTimerF208Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF208Added").SetValueAsync(WriteArtworkTimerF208Added);
            
            // F301Added
			DataFillingInformation.DBArtworkTimersF301Added = WriteArtworkTimerF301Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF301Added").SetValueAsync(WriteArtworkTimerF301Added);
            
            // F302Added
			DataFillingInformation.DBArtworkTimersF302Added = WriteArtworkTimerF302Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF302Added").SetValueAsync(WriteArtworkTimerF302Added);
            
            // F303Added
			DataFillingInformation.DBArtworkTimersF303Added = WriteArtworkTimerF303Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF303Added").SetValueAsync(WriteArtworkTimerF303Added);
            
            // F304Added
			DataFillingInformation.DBArtworkTimersF304Added = WriteArtworkTimerF304Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF304Added").SetValueAsync(WriteArtworkTimerF304Added);
            
            // F305Added
			DataFillingInformation.DBArtworkTimersF305Added = WriteArtworkTimerF305Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF305Added").SetValueAsync(WriteArtworkTimerF305Added);
            
            // F306Added
			DataFillingInformation.DBArtworkTimersF306Added = WriteArtworkTimerF306Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF306Added").SetValueAsync(WriteArtworkTimerF306Added);
            
            // F307Added
			DataFillingInformation.DBArtworkTimersF307Added = WriteArtworkTimerF307Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF307Added").SetValueAsync(WriteArtworkTimerF307Added);
            
            // F308Added
			DataFillingInformation.DBArtworkTimersF308Added = WriteArtworkTimerF308Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersF308Added").SetValueAsync(WriteArtworkTimerF308Added);
            
            // G101Added
			DataFillingInformation.DBArtworkTimersG101Added = WriteArtworkTimerG101Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG101Added").SetValueAsync(WriteArtworkTimerG101Added);
            
            // G102Added
			DataFillingInformation.DBArtworkTimersG102Added = WriteArtworkTimerG102Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG102Added").SetValueAsync(WriteArtworkTimerG102Added);
            
            // G103Added
			DataFillingInformation.DBArtworkTimersG103Added = WriteArtworkTimerG103Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG103Added").SetValueAsync(WriteArtworkTimerG103Added);
            
            // G104Added
			DataFillingInformation.DBArtworkTimersG104Added = WriteArtworkTimerG104Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG104Added").SetValueAsync(WriteArtworkTimerG104Added);
            
            // G105Added
			DataFillingInformation.DBArtworkTimersG105Added = WriteArtworkTimerG105Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG105Added").SetValueAsync(WriteArtworkTimerG105Added);
            
            // G106Added
			DataFillingInformation.DBArtworkTimersG106Added = WriteArtworkTimerG106Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG106Added").SetValueAsync(WriteArtworkTimerG106Added);
            
            // G107Added
			DataFillingInformation.DBArtworkTimersG107Added = WriteArtworkTimerG107Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG107Added").SetValueAsync(WriteArtworkTimerG107Added);
            
            // G108Added
			DataFillingInformation.DBArtworkTimersG108Added = WriteArtworkTimerG108Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG108Added").SetValueAsync(WriteArtworkTimerG108Added);
            
            // G201Added
			DataFillingInformation.DBArtworkTimersG201Added = WriteArtworkTimerG201Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG201Added").SetValueAsync(WriteArtworkTimerG201Added);
            
            // G202Added
			DataFillingInformation.DBArtworkTimersG202Added = WriteArtworkTimerG202Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG202Added").SetValueAsync(WriteArtworkTimerG202Added);
            
            // G203Added
			DataFillingInformation.DBArtworkTimersG203Added = WriteArtworkTimerG203Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG203Added").SetValueAsync(WriteArtworkTimerG203Added);
            
            // G204Added
			DataFillingInformation.DBArtworkTimersG204Added = WriteArtworkTimerG204Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG204Added").SetValueAsync(WriteArtworkTimerG204Added);
            
            // G205Added
			DataFillingInformation.DBArtworkTimersG205Added = WriteArtworkTimerG205Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG205Added").SetValueAsync(WriteArtworkTimerG205Added);
            
            // G206Added
			DataFillingInformation.DBArtworkTimersG206Added = WriteArtworkTimerG206Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG206Added").SetValueAsync(WriteArtworkTimerG206Added);
            
            // G207Added
			DataFillingInformation.DBArtworkTimersG207Added = WriteArtworkTimerG207Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG207Added").SetValueAsync(WriteArtworkTimerG207Added);
            
            // G208Added
			DataFillingInformation.DBArtworkTimersG208Added = WriteArtworkTimerG208Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG208Added").SetValueAsync(WriteArtworkTimerG208Added);
            
            // G301Added
			DataFillingInformation.DBArtworkTimersG301Added = WriteArtworkTimerG301Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG301Added").SetValueAsync(WriteArtworkTimerG301Added);
            
            // G302Added
			DataFillingInformation.DBArtworkTimersG302Added = WriteArtworkTimerG302Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG302Added").SetValueAsync(WriteArtworkTimerG302Added);
            
            // G303Added
			DataFillingInformation.DBArtworkTimersG303Added = WriteArtworkTimerG303Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG303Added").SetValueAsync(WriteArtworkTimerG303Added);
            
            // G304Added
			DataFillingInformation.DBArtworkTimersG304Added = WriteArtworkTimerG304Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG304Added").SetValueAsync(WriteArtworkTimerG304Added);
            
            // G305Added
			DataFillingInformation.DBArtworkTimersG305Added = WriteArtworkTimerG305Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG305Added").SetValueAsync(WriteArtworkTimerG305Added);
            
            // G306Added
			DataFillingInformation.DBArtworkTimersG306Added = WriteArtworkTimerG306Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG306Added").SetValueAsync(WriteArtworkTimerG306Added);
            
            // G307Added
			DataFillingInformation.DBArtworkTimersG307Added = WriteArtworkTimerG307Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG307Added").SetValueAsync(WriteArtworkTimerG307Added);
            
            // G308Added
			DataFillingInformation.DBArtworkTimersG308Added = WriteArtworkTimerG308Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersG308Added").SetValueAsync(WriteArtworkTimerG308Added);
            
            // FB01Added
			DataFillingInformation.DBArtworkTimersFB01Added = WriteArtworkTimerFB01Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB01Added").SetValueAsync(WriteArtworkTimerFB01Added);
            
            // FB02Added
			DataFillingInformation.DBArtworkTimersFB02Added = WriteArtworkTimerFB02Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB02Added").SetValueAsync(WriteArtworkTimerFB02Added);
            
            // FB03Added
			DataFillingInformation.DBArtworkTimersFB03Added = WriteArtworkTimerFB03Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB03Added").SetValueAsync(WriteArtworkTimerFB03Added);
            
            // FB04Added
			DataFillingInformation.DBArtworkTimersFB04Added = WriteArtworkTimerFB04Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB04Added").SetValueAsync(WriteArtworkTimerFB04Added);
            
            // FB05Added
			DataFillingInformation.DBArtworkTimersFB05Added = WriteArtworkTimerFB05Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB05Added").SetValueAsync(WriteArtworkTimerFB05Added);
            
            // FB06Added
			DataFillingInformation.DBArtworkTimersFB06Added = WriteArtworkTimerFB06Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB06Added").SetValueAsync(WriteArtworkTimerFB06Added);
            
            // FB07Added
			DataFillingInformation.DBArtworkTimersFB07Added = WriteArtworkTimerFB07Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB07Added").SetValueAsync(WriteArtworkTimerFB07Added);
            
            // FB08Added
			DataFillingInformation.DBArtworkTimersFB08Added = WriteArtworkTimerFB08Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB08Added").SetValueAsync(WriteArtworkTimerFB08Added);
            
            // FB09Added
			DataFillingInformation.DBArtworkTimersFB09Added = WriteArtworkTimerFB09Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB09Added").SetValueAsync(WriteArtworkTimerFB09Added);
            
            // FB10Added
			DataFillingInformation.DBArtworkTimersFB10Added = WriteArtworkTimerFB10Added.ToString();
			FirebaseDatabase.DefaultInstance.GetReference("ChateauArtTimers").Child(FirebaseAuthentication.CurrentPlayer.UserId).Child("DBArtworkTimersFB10Added").SetValueAsync(WriteArtworkTimerFB10Added);
        }
    }
		
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}