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

public class MainMenuRedAlertEnable : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Red Alert
    public Image UIRedAlertField;
	public Image UIRedAlertPanel;
    
    // F1
	public Image UIRedAlertArtistF1A;
    public Image UIRedAlertArtistF1B;
    public Image UIRedAlertArtistF1C;
    public Image UIRedAlertArtistF1D;
    public Image UIRedAlertArtistF1E;
    
    // F2
	public Image UIRedAlertArtistF2A;
    public Image UIRedAlertArtistF2B;
    public Image UIRedAlertArtistF2C;
    public Image UIRedAlertArtistF2D;
    public Image UIRedAlertArtistF2E;
    
    // F3
	public Image UIRedAlertArtistF3A;
    public Image UIRedAlertArtistF3B;
    public Image UIRedAlertArtistF3C;
    public Image UIRedAlertArtistF3D;
    public Image UIRedAlertArtistF3E;
    
    // G1
	public Image UIRedAlertArtistG1A;
    public Image UIRedAlertArtistG1B;
    public Image UIRedAlertArtistG1C;
    public Image UIRedAlertArtistG1D;
    public Image UIRedAlertArtistG1E;
    
    // G2
	public Image UIRedAlertArtistG2A;
    public Image UIRedAlertArtistG2B;
    public Image UIRedAlertArtistG2C;
    public Image UIRedAlertArtistG2D;
    public Image UIRedAlertArtistG2E;
    
    // G3
	public Image UIRedAlertArtistG3A;
    public Image UIRedAlertArtistG3B;
    public Image UIRedAlertArtistG3C;
    public Image UIRedAlertArtistG3D;
    public Image UIRedAlertArtistG3E;
    
    // FB
	public Image UIRedAlertArtistFBA;
    public Image UIRedAlertArtistFBB;
    public Image UIRedAlertArtistFBC;
    public Image UIRedAlertArtistFBD;
    public Image UIRedAlertArtistFBE;
	
// --------------- PRIVATE VARIABLES ---------------
    
	
// --------------- STATIC VARIABLES ---------------
    // F1
    public static int PrivateAlertTimeF1A;
    public static int PrivateAlertTimeF1B;
    public static int PrivateAlertTimeF1C;
    public static int PrivateAlertTimeF1D;
    public static int PrivateAlertTimeF1E;
    
    // F2
    public static int PrivateAlertTimeF2A;
    public static int PrivateAlertTimeF2B;
    public static int PrivateAlertTimeF2C;
    public static int PrivateAlertTimeF2D;
    public static int PrivateAlertTimeF2E;
    
    // F3
    public static int PrivateAlertTimeF3A;
    public static int PrivateAlertTimeF3B;
    public static int PrivateAlertTimeF3C;
    public static int PrivateAlertTimeF3D;
    public static int PrivateAlertTimeF3E;
    
    // G1
    public static int PrivateAlertTimeG1A;
    public static int PrivateAlertTimeG1B;
    public static int PrivateAlertTimeG1C;
    public static int PrivateAlertTimeG1D;
    public static int PrivateAlertTimeG1E;
    
    // G2
    public static int PrivateAlertTimeG2A;
    public static int PrivateAlertTimeG2B;
    public static int PrivateAlertTimeG2C;
    public static int PrivateAlertTimeG2D;
    public static int PrivateAlertTimeG2E;
    
    // G3
    public static int PrivateAlertTimeG3A;
    public static int PrivateAlertTimeG3B;
    public static int PrivateAlertTimeG3C;
    public static int PrivateAlertTimeG3D;
    public static int PrivateAlertTimeG3E;
    
    // FB
    public static int PrivateAlertTimeFBA;
    public static int PrivateAlertTimeFBB;
    public static int PrivateAlertTimeFBC;
    public static int PrivateAlertTimeFBD;
    public static int PrivateAlertTimeFBE;
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		RedAlertAllDisable();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
        // F1
        PrivateAlertTimeF1A = 0;
        PrivateAlertTimeF1B = 0;
        PrivateAlertTimeF1C = 0;
        PrivateAlertTimeF1D = 0;
        PrivateAlertTimeF1E = 0;
        
        // F2
        PrivateAlertTimeF2A = 0;
        PrivateAlertTimeF2B = 0;
        PrivateAlertTimeF2C = 0;
        PrivateAlertTimeF2D = 0;
        PrivateAlertTimeF2E = 0;
        
        // F3
        PrivateAlertTimeF3A = 0;
        PrivateAlertTimeF3B = 0;
        PrivateAlertTimeF3C = 0;
        PrivateAlertTimeF3D = 0;
        PrivateAlertTimeF3E = 0;
        
        // G1
        PrivateAlertTimeG1A = 0;
        PrivateAlertTimeG1B = 0;
        PrivateAlertTimeG1C = 0;
        PrivateAlertTimeG1D = 0;
        PrivateAlertTimeG1E = 0;
        
        // G2
        PrivateAlertTimeG2A = 0;
        PrivateAlertTimeG2B = 0;
        PrivateAlertTimeG2C = 0;
        PrivateAlertTimeG2D = 0;
        PrivateAlertTimeG2E = 0;
        
        // G3
        PrivateAlertTimeG3A = 0;
        PrivateAlertTimeG3B = 0;
        PrivateAlertTimeG3C = 0;
        PrivateAlertTimeG3D = 0;
        PrivateAlertTimeG3E = 0;
        
        // FB
        PrivateAlertTimeFBA = 0;
        PrivateAlertTimeFBB = 0;
        PrivateAlertTimeFBC = 0;
        PrivateAlertTimeFBD = 0;
        PrivateAlertTimeFBE = 0;
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		DetermineArtistSlot();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
// --------------- ENABLE FUNCTION ---------------
    // Field
    public void RedAlertFieldEnable() {
        UIRedAlertField.enabled = true;
    }
    
    // Panel
    public void RedAlertPanelEnable() {
        UIRedAlertPanel.enabled = true;
    }
    
    // F1
    public void RedAlertGhostF1AEnable() {
        UIRedAlertArtistF1A.enabled = true;
    }
    
    public void RedAlertGhostF1BEnable() {
        UIRedAlertArtistF1B.enabled = true;
    }
    
    public void RedAlertGhostF1CEnable() {
        UIRedAlertArtistF1C.enabled = true;
    }
    
    public void RedAlertGhostF1DEnable() {
        UIRedAlertArtistF1D.enabled = true;
    }
    
    public void RedAlertGhostF1EEnable() {
        UIRedAlertArtistF1E.enabled = true;
    }
    
    // F2
    public void RedAlertGhostF2AEnable() {
        UIRedAlertArtistF2A.enabled = true;
    }
    
    public void RedAlertGhostF2BEnable() {
        UIRedAlertArtistF2B.enabled = true;
    }
    
    public void RedAlertGhostF2CEnable() {
        UIRedAlertArtistF2C.enabled = true;
    }
    
    public void RedAlertGhostF2DEnable() {
        UIRedAlertArtistF2D.enabled = true;
    }
    
    public void RedAlertGhostF2EEnable() {
        UIRedAlertArtistF2E.enabled = true;
    }
    
    // F3
    public void RedAlertGhostF3AEnable() {
        UIRedAlertArtistF3A.enabled = true;
    }
    
    public void RedAlertGhostF3BEnable() {
        UIRedAlertArtistF3B.enabled = true;
    }
    
    public void RedAlertGhostF3CEnable() {
        UIRedAlertArtistF3C.enabled = true;
    }
    
    public void RedAlertGhostF3DEnable() {
        UIRedAlertArtistF3D.enabled = true;
    }
    
    public void RedAlertGhostF3EEnable() {
        UIRedAlertArtistF3E.enabled = true;
    }
    
    // G1
    public void RedAlertGhostG1AEnable() {
        UIRedAlertArtistG1A.enabled = true;
    }
    
    public void RedAlertGhostG1BEnable() {
        UIRedAlertArtistG1B.enabled = true;
    }
    
    public void RedAlertGhostG1CEnable() {
        UIRedAlertArtistG1C.enabled = true;
    }
    
    public void RedAlertGhostG1DEnable() {
        UIRedAlertArtistG1D.enabled = true;
    }
    
    public void RedAlertGhostG1EEnable() {
        UIRedAlertArtistG1E.enabled = true;
    }
    
    // G2
    public void RedAlertGhostG2AEnable() {
        UIRedAlertArtistG2A.enabled = true;
    }
    
    public void RedAlertGhostG2BEnable() {
        UIRedAlertArtistG2B.enabled = true;
    }
    
    public void RedAlertGhostG2CEnable() {
        UIRedAlertArtistG2C.enabled = true;
    }
    
    public void RedAlertGhostG2DEnable() {
        UIRedAlertArtistG2D.enabled = true;
    }
    
    public void RedAlertGhostG2EEnable() {
        UIRedAlertArtistG2E.enabled = true;
    }
    
    // G3
    public void RedAlertGhostG3AEnable() {
        UIRedAlertArtistG3A.enabled = true;
    }
    
    public void RedAlertGhostG3BEnable() {
        UIRedAlertArtistG3B.enabled = true;
    }
    
    public void RedAlertGhostG3CEnable() {
        UIRedAlertArtistG3C.enabled = true;
    }
    
    public void RedAlertGhostG3DEnable() {
        UIRedAlertArtistG3D.enabled = true;
    }
    
    public void RedAlertGhostG3EEnable() {
        UIRedAlertArtistG3E.enabled = true;
    }
    
    // FB
    public void RedAlertGhostFBAEnable() {
        UIRedAlertArtistFBA.enabled = true;
    }
    
    public void RedAlertGhostFBBEnable() {
        UIRedAlertArtistFBB.enabled = true;
    }
    
    public void RedAlertGhostFBCEnable() {
        UIRedAlertArtistFBC.enabled = true;
    }
    
    public void RedAlertGhostFBDEnable() {
        UIRedAlertArtistFBD.enabled = true;
    }
    
    public void RedAlertGhostFBEEnable() {
        UIRedAlertArtistFBE.enabled = true;
    }
	
// --------------- DISABLE FUNCTION ---------------
    // All
	public void RedAlertAllDisable() {
        // Field
        RedAlertFieldDisable();
        
        // Panel
        RedAlertPanelDisable();
        
        // Artists
		RedAlertGhostF1ADisable();
        RedAlertGhostF1BDisable();
        RedAlertGhostF1CDisable();
        RedAlertGhostF1DDisable();
        RedAlertGhostF1EDisable();
        RedAlertGhostF2ADisable();
        RedAlertGhostF2BDisable();
        RedAlertGhostF2CDisable();
        RedAlertGhostF2DDisable();
        RedAlertGhostF2EDisable();
        RedAlertGhostF3ADisable();
        RedAlertGhostF3BDisable();
        RedAlertGhostF3CDisable();
        RedAlertGhostF3DDisable();
        RedAlertGhostF3EDisable();
        RedAlertGhostG1ADisable();
        RedAlertGhostG1BDisable();
        RedAlertGhostG1CDisable();
        RedAlertGhostG1DDisable();
        RedAlertGhostG1EDisable();
        RedAlertGhostG2ADisable();
        RedAlertGhostG2BDisable();
        RedAlertGhostG2CDisable();
        RedAlertGhostG2DDisable();
        RedAlertGhostG2EDisable();
        RedAlertGhostG3ADisable();
        RedAlertGhostG3BDisable();
        RedAlertGhostG3CDisable();
        RedAlertGhostG3DDisable();
        RedAlertGhostG3EDisable();
        RedAlertGhostFBADisable();
        RedAlertGhostFBBDisable();
        RedAlertGhostFBCDisable();
        RedAlertGhostFBDDisable();
        RedAlertGhostFBEDisable();
	}
    
    // Field
    public void RedAlertFieldDisable() {
        UIRedAlertField.enabled = false;
    }
    
    // Panel
    public void RedAlertPanelDisable() {
        UIRedAlertPanel.enabled = false;
    }
    
    // F1
    public void RedAlertGhostF1ADisable() {
        UIRedAlertArtistF1A.enabled = false;
    }
    
    public void RedAlertGhostF1BDisable() {
        UIRedAlertArtistF1B.enabled = false;
    }
    
    public void RedAlertGhostF1CDisable() {
        UIRedAlertArtistF1C.enabled = false;
    }
    
    public void RedAlertGhostF1DDisable() {
        UIRedAlertArtistF1D.enabled = false;
    }
    
    public void RedAlertGhostF1EDisable() {
        UIRedAlertArtistF1E.enabled = false;
    }
    
    // F2
    public void RedAlertGhostF2ADisable() {
        UIRedAlertArtistF2A.enabled = false;
    }
    
    public void RedAlertGhostF2BDisable() {
        UIRedAlertArtistF2B.enabled = false;
    }
    
    public void RedAlertGhostF2CDisable() {
        UIRedAlertArtistF2C.enabled = false;
    }
    
    public void RedAlertGhostF2DDisable() {
        UIRedAlertArtistF2D.enabled = false;
    }
    
    public void RedAlertGhostF2EDisable() {
        UIRedAlertArtistF2E.enabled = false;
    }
    
    // F3
    public void RedAlertGhostF3ADisable() {
        UIRedAlertArtistF3A.enabled = false;
    }
    
    public void RedAlertGhostF3BDisable() {
        UIRedAlertArtistF3B.enabled = false;
    }
    
    public void RedAlertGhostF3CDisable() {
        UIRedAlertArtistF3C.enabled = false;
    }
    
    public void RedAlertGhostF3DDisable() {
        UIRedAlertArtistF3D.enabled = false;
    }
    
    public void RedAlertGhostF3EDisable() {
        UIRedAlertArtistF3E.enabled = false;
    }
    
    // G1
    public void RedAlertGhostG1ADisable() {
        UIRedAlertArtistG1A.enabled = false;
    }
    
    public void RedAlertGhostG1BDisable() {
        UIRedAlertArtistG1B.enabled = false;
    }
    
    public void RedAlertGhostG1CDisable() {
        UIRedAlertArtistG1C.enabled = false;
    }
    
    public void RedAlertGhostG1DDisable() {
        UIRedAlertArtistG1D.enabled = false;
    }
    
    public void RedAlertGhostG1EDisable() {
        UIRedAlertArtistG1E.enabled = false;
    }
    
    // G2
    public void RedAlertGhostG2ADisable() {
        UIRedAlertArtistG2A.enabled = false;
    }
    
    public void RedAlertGhostG2BDisable() {
        UIRedAlertArtistG2B.enabled = false;
    }
    
    public void RedAlertGhostG2CDisable() {
        UIRedAlertArtistG2C.enabled = false;
    }
    
    public void RedAlertGhostG2DDisable() {
        UIRedAlertArtistG2D.enabled = false;
    }
    
    public void RedAlertGhostG2EDisable() {
        UIRedAlertArtistG2E.enabled = false;
    }
    
    // G3
    public void RedAlertGhostG3ADisable() {
        UIRedAlertArtistG3A.enabled = false;
    }
    
    public void RedAlertGhostG3BDisable() {
        UIRedAlertArtistG3B.enabled = false;
    }
    
    public void RedAlertGhostG3CDisable() {
        UIRedAlertArtistG3C.enabled = false;
    }
    
    public void RedAlertGhostG3DDisable() {
        UIRedAlertArtistG3D.enabled = false;
    }
    
    public void RedAlertGhostG3EDisable() {
        UIRedAlertArtistG3E.enabled = false;
    }
    
    // FB
    public void RedAlertGhostFBADisable() {
        UIRedAlertArtistFBA.enabled = false;
    }
    
    public void RedAlertGhostFBBDisable() {
        UIRedAlertArtistFBB.enabled = false;
    }
    
    public void RedAlertGhostFBCDisable() {
        UIRedAlertArtistFBC.enabled = false;
    }
    
    public void RedAlertGhostFBDDisable() {
        UIRedAlertArtistFBD.enabled = false;
    }
    
    public void RedAlertGhostFBEDisable() {
        UIRedAlertArtistFBE.enabled = false;
    }

// --------------- DETERMINE ARTIST SLOT FUNCTION ---------------
    public void DetermineArtistSlot() {
        // ---------- F1
        if ((float.Parse(DataFillingInformation.DBGhostTimeF1A)) >= ((GhostInformation.GhostInfoTimerF1A) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeF1A)) < GhostInformation.GhostInfoTimerF1A)) {
            PrivateAlertTimeF1A = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF1A)) < ((GhostInformation.GhostInfoTimerF1A) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeF1A)) >= GhostInformation.GhostInfoTimerF1A)) {
            PrivateAlertTimeF1A = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF1B)) >= ((GhostInformation.GhostInfoTimerF1B) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeF1B)) < GhostInformation.GhostInfoTimerF1B)) {
            PrivateAlertTimeF1B = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF1B)) < ((GhostInformation.GhostInfoTimerF1B) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeF1B)) >= GhostInformation.GhostInfoTimerF1B)) {
            PrivateAlertTimeF1B = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF1C)) >= ((GhostInformation.GhostInfoTimerF1C) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeF1C)) < GhostInformation.GhostInfoTimerF1C)) {
            PrivateAlertTimeF1C = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF1C)) < ((GhostInformation.GhostInfoTimerF1C) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeF1C)) >= GhostInformation.GhostInfoTimerF1C)) {
            PrivateAlertTimeF1C = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF1D)) >= ((GhostInformation.GhostInfoTimerF1D) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeF1D)) < GhostInformation.GhostInfoTimerF1D)) {
            PrivateAlertTimeF1D = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF1D)) < ((GhostInformation.GhostInfoTimerF1D) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeF1D)) >= GhostInformation.GhostInfoTimerF1D)) {
            PrivateAlertTimeF1D = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF1E)) >= ((GhostInformation.GhostInfoTimerF1E) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeF1E)) < GhostInformation.GhostInfoTimerF1E)) {
            PrivateAlertTimeF1E = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF1E)) < ((GhostInformation.GhostInfoTimerF1E) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeF1E)) >= GhostInformation.GhostInfoTimerF1E)) {
            PrivateAlertTimeF1E = 0;
        }
        
        // ---------- F2
        if ((float.Parse(DataFillingInformation.DBGhostTimeF2A)) >= ((GhostInformation.GhostInfoTimerF2A) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeF2A)) < GhostInformation.GhostInfoTimerF2A)) {
            PrivateAlertTimeF2A = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF2A)) < ((GhostInformation.GhostInfoTimerF2A) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeF2A)) >= GhostInformation.GhostInfoTimerF2A)) {
            PrivateAlertTimeF2A = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF2B)) >= ((GhostInformation.GhostInfoTimerF2B) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeF2B)) < GhostInformation.GhostInfoTimerF2B)) {
            PrivateAlertTimeF2B = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF2B)) < ((GhostInformation.GhostInfoTimerF2B) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeF2B)) >= GhostInformation.GhostInfoTimerF2B)) {
            PrivateAlertTimeF2B = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF2C)) >= ((GhostInformation.GhostInfoTimerF2C) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeF2C)) < GhostInformation.GhostInfoTimerF2C)) {
            PrivateAlertTimeF2C = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF2C)) < ((GhostInformation.GhostInfoTimerF2C) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeF2C)) >= GhostInformation.GhostInfoTimerF2C)) {
            PrivateAlertTimeF2C = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF2D)) >= ((GhostInformation.GhostInfoTimerF2D) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeF2D)) < GhostInformation.GhostInfoTimerF2D)) {
            PrivateAlertTimeF2D = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF2D)) < ((GhostInformation.GhostInfoTimerF2D) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeF2D)) >= GhostInformation.GhostInfoTimerF2D)) {
            PrivateAlertTimeF2D = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF2E)) >= ((GhostInformation.GhostInfoTimerF2E) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeF2E)) < GhostInformation.GhostInfoTimerF2E)) {
            PrivateAlertTimeF2E = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF2E)) < ((GhostInformation.GhostInfoTimerF2E) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeF2E)) >= GhostInformation.GhostInfoTimerF2E)) {
            PrivateAlertTimeF2E = 0;
        }
        
        // ---------- F3
        if ((float.Parse(DataFillingInformation.DBGhostTimeF3A)) >= ((GhostInformation.GhostInfoTimerF3A) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeF3A)) < GhostInformation.GhostInfoTimerF3A)) {
            PrivateAlertTimeF3A = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF3A)) < ((GhostInformation.GhostInfoTimerF3A) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeF3A)) >= GhostInformation.GhostInfoTimerF3A)) {
            PrivateAlertTimeF3A = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF3B)) >= ((GhostInformation.GhostInfoTimerF3B) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeF3B)) < GhostInformation.GhostInfoTimerF3B)) {
            PrivateAlertTimeF3B = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF3B)) < ((GhostInformation.GhostInfoTimerF3B) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeF3B)) >= GhostInformation.GhostInfoTimerF3B)) {
            PrivateAlertTimeF3B = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF3C)) >= ((GhostInformation.GhostInfoTimerF3C) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeF3C)) < GhostInformation.GhostInfoTimerF3C)) {
            PrivateAlertTimeF3C = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF3C)) < ((GhostInformation.GhostInfoTimerF3C) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeF3C)) >= GhostInformation.GhostInfoTimerF3C)) {
            PrivateAlertTimeF3C = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF3D)) >= ((GhostInformation.GhostInfoTimerF3D) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeF3D)) < GhostInformation.GhostInfoTimerF3D)) {
            PrivateAlertTimeF3D = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF3D)) < ((GhostInformation.GhostInfoTimerF3D) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeF3D)) >= GhostInformation.GhostInfoTimerF3D)) {
            PrivateAlertTimeF3D = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF3E)) >= ((GhostInformation.GhostInfoTimerF3E) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeF3E)) < GhostInformation.GhostInfoTimerF3E)) {
            PrivateAlertTimeF3E = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeF3E)) < ((GhostInformation.GhostInfoTimerF3E) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeF3E)) >= GhostInformation.GhostInfoTimerF3E)) {
            PrivateAlertTimeF3E = 0;
        }
        
        // ---------- G1
        if ((float.Parse(DataFillingInformation.DBGhostTimeG1A)) >= ((GhostInformation.GhostInfoTimerG1A) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeG1A)) < GhostInformation.GhostInfoTimerG1A)) {
            PrivateAlertTimeG1A = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG1A)) < ((GhostInformation.GhostInfoTimerG1A) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeG1A)) >= GhostInformation.GhostInfoTimerG1A)) {
            PrivateAlertTimeG1A = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG1B)) >= ((GhostInformation.GhostInfoTimerG1B) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeG1B)) < GhostInformation.GhostInfoTimerG1B)) {
            PrivateAlertTimeG1B = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG1B)) < ((GhostInformation.GhostInfoTimerG1B) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeG1B)) >= GhostInformation.GhostInfoTimerG1B)) {
            PrivateAlertTimeG1B = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG1C)) >= ((GhostInformation.GhostInfoTimerG1C) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeG1C)) < GhostInformation.GhostInfoTimerG1C)) {
            PrivateAlertTimeG1C = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG1C)) < ((GhostInformation.GhostInfoTimerG1C) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeG1C)) >= GhostInformation.GhostInfoTimerG1C)) {
            PrivateAlertTimeG1C = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG1D)) >= ((GhostInformation.GhostInfoTimerG1D) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeG1D)) < GhostInformation.GhostInfoTimerG1D)) {
            PrivateAlertTimeG1D = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG1D)) < ((GhostInformation.GhostInfoTimerG1D) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeG1D)) >= GhostInformation.GhostInfoTimerG1D)) {
            PrivateAlertTimeG1D = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG1E)) >= ((GhostInformation.GhostInfoTimerG1E) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeG1E)) < GhostInformation.GhostInfoTimerG1E)) {
            PrivateAlertTimeG1E = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG1E)) < ((GhostInformation.GhostInfoTimerG1E) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeG1E)) >= GhostInformation.GhostInfoTimerG1E)) {
            PrivateAlertTimeG1E = 0;
        }
        
        // ---------- G2
        if ((float.Parse(DataFillingInformation.DBGhostTimeG2A)) >= ((GhostInformation.GhostInfoTimerG2A) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeG2A)) < GhostInformation.GhostInfoTimerG2A)) {
            PrivateAlertTimeG2A = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG2A)) < ((GhostInformation.GhostInfoTimerG2A) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeG2A)) >= GhostInformation.GhostInfoTimerG2A)) {
            PrivateAlertTimeG2A = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG2B)) >= ((GhostInformation.GhostInfoTimerG2B) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeG2B)) < GhostInformation.GhostInfoTimerG2B)) {
            PrivateAlertTimeG2B = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG2B)) < ((GhostInformation.GhostInfoTimerG2B) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeG2B)) >= GhostInformation.GhostInfoTimerG2B)) {
            PrivateAlertTimeG2B = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG2C)) >= ((GhostInformation.GhostInfoTimerG2C) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeG2C)) < GhostInformation.GhostInfoTimerG2C)) {
            PrivateAlertTimeG2C = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG2C)) < ((GhostInformation.GhostInfoTimerG2C) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeG2C)) >= GhostInformation.GhostInfoTimerG2C)) {
            PrivateAlertTimeG2C = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG2D)) >= ((GhostInformation.GhostInfoTimerG2D) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeG2D)) < GhostInformation.GhostInfoTimerG2D)) {
            PrivateAlertTimeG2D = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG2D)) < ((GhostInformation.GhostInfoTimerG2D) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeG2D)) >= GhostInformation.GhostInfoTimerG2D)) {
            PrivateAlertTimeG2D = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG2E)) >= ((GhostInformation.GhostInfoTimerG2E) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeG2E)) < GhostInformation.GhostInfoTimerG2E)) {
            PrivateAlertTimeG2E = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG2E)) < ((GhostInformation.GhostInfoTimerG2E) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeG2E)) >= GhostInformation.GhostInfoTimerG2E)) {
            PrivateAlertTimeG2E = 0;
        }
        
        // ---------- G3
        if ((float.Parse(DataFillingInformation.DBGhostTimeG3A)) >= ((GhostInformation.GhostInfoTimerG3A) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeG3A)) < GhostInformation.GhostInfoTimerG3A)) {
            PrivateAlertTimeG3A = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG3A)) < ((GhostInformation.GhostInfoTimerG3A) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeG3A)) >= GhostInformation.GhostInfoTimerG3A)) {
            PrivateAlertTimeG3A = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG3B)) >= ((GhostInformation.GhostInfoTimerG3B) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeG3B)) < GhostInformation.GhostInfoTimerG3B)) {
            PrivateAlertTimeG3B = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG3B)) < ((GhostInformation.GhostInfoTimerG3B) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeG3B)) >= GhostInformation.GhostInfoTimerG3B)) {
            PrivateAlertTimeG3B = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG3C)) >= ((GhostInformation.GhostInfoTimerG3C) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeG3C)) < GhostInformation.GhostInfoTimerG3C)) {
            PrivateAlertTimeG3C = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG3C)) < ((GhostInformation.GhostInfoTimerG3C) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeG3C)) >= GhostInformation.GhostInfoTimerG3C)) {
            PrivateAlertTimeG3C = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG3D)) >= ((GhostInformation.GhostInfoTimerG3D) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeG3D)) < GhostInformation.GhostInfoTimerG3D)) {
            PrivateAlertTimeG3D = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG3D)) < ((GhostInformation.GhostInfoTimerG3D) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeG3D)) >= GhostInformation.GhostInfoTimerG3D)) {
            PrivateAlertTimeG3D = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG3E)) >= ((GhostInformation.GhostInfoTimerG3E) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeG3E)) < GhostInformation.GhostInfoTimerG3E)) {
            PrivateAlertTimeG3E = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeG3E)) < ((GhostInformation.GhostInfoTimerG3E) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeG3E)) >= GhostInformation.GhostInfoTimerG3E)) {
            PrivateAlertTimeG3E = 0;
        }
        
        // ---------- FB
        if ((float.Parse(DataFillingInformation.DBGhostTimeFBA)) >= ((GhostInformation.GhostInfoTimerFBA) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeFBA)) < GhostInformation.GhostInfoTimerFBA)) {
            PrivateAlertTimeFBA = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeFBA)) < ((GhostInformation.GhostInfoTimerFBA) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeFBA)) >= GhostInformation.GhostInfoTimerFBA)) {
            PrivateAlertTimeFBA = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeFBB)) >= ((GhostInformation.GhostInfoTimerFBB) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeFBB)) < GhostInformation.GhostInfoTimerFBB)) {
            PrivateAlertTimeFBB = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeFBB)) < ((GhostInformation.GhostInfoTimerFBB) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeFBB)) >= GhostInformation.GhostInfoTimerFBB)) {
            PrivateAlertTimeFBB = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeFBC)) >= ((GhostInformation.GhostInfoTimerFBC) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeFBC)) < GhostInformation.GhostInfoTimerFBC)) {
            PrivateAlertTimeFBC = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeFBC)) < ((GhostInformation.GhostInfoTimerFBC) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeFBC)) >= GhostInformation.GhostInfoTimerFBC)) {
            PrivateAlertTimeFBC = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeFBD)) >= ((GhostInformation.GhostInfoTimerFBD) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeFBD)) < GhostInformation.GhostInfoTimerFBD)) {
            PrivateAlertTimeFBD = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeFBD)) < ((GhostInformation.GhostInfoTimerFBD) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeFBD)) >= GhostInformation.GhostInfoTimerFBD)) {
            PrivateAlertTimeFBD = 0;
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeFBE)) >= ((GhostInformation.GhostInfoTimerFBE) * 0.75f) && ((float.Parse(DataFillingInformation.DBGhostTimeFBE)) < GhostInformation.GhostInfoTimerFBE)) {
            PrivateAlertTimeFBE = 1;
            RedAlertFieldEnable();
        }
        
        if ((float.Parse(DataFillingInformation.DBGhostTimeFBE)) < ((GhostInformation.GhostInfoTimerFBE) * 0.75f) || ((float.Parse(DataFillingInformation.DBGhostTimeFBE)) >= GhostInformation.GhostInfoTimerFBE)) {
            PrivateAlertTimeFBE = 0;
        }
    }
		
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}