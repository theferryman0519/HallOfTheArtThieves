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

public class ChateauArtTimers {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Class Properties - Art Timers
    public float DBArtworkTimersF101;
	public float DBArtworkTimersF102;
	public float DBArtworkTimersF103;
	public float DBArtworkTimersF104;
	public float DBArtworkTimersF105;
	public float DBArtworkTimersF106;
	public float DBArtworkTimersF107;
	public float DBArtworkTimersF108;
	public float DBArtworkTimersF109;
	public float DBArtworkTimersF110;
	public float DBArtworkTimersF111;
	public float DBArtworkTimersF112;
	public float DBArtworkTimersF113;
	public float DBArtworkTimersF114;
	public float DBArtworkTimersF115;
	public float DBArtworkTimersF201;
	public float DBArtworkTimersF202;
	public float DBArtworkTimersF203;
	public float DBArtworkTimersF204;
	public float DBArtworkTimersF205;
	public float DBArtworkTimersF206;
	public float DBArtworkTimersF207;
	public float DBArtworkTimersF208;
	public float DBArtworkTimersF209;
	public float DBArtworkTimersF210;
	public float DBArtworkTimersF211;
	public float DBArtworkTimersF212;
	public float DBArtworkTimersF213;
	public float DBArtworkTimersF214;
	public float DBArtworkTimersF215;
	public float DBArtworkTimersF301;
	public float DBArtworkTimersF302;
	public float DBArtworkTimersF303;
	public float DBArtworkTimersF304;
	public float DBArtworkTimersF305;
	public float DBArtworkTimersF306;
	public float DBArtworkTimersF307;
	public float DBArtworkTimersF308;
	public float DBArtworkTimersF309;
	public float DBArtworkTimersF310;
	public float DBArtworkTimersF311;
	public float DBArtworkTimersF312;
	public float DBArtworkTimersF313;
	public float DBArtworkTimersF314;
	public float DBArtworkTimersF315;
	public float DBArtworkTimersG101;
	public float DBArtworkTimersG102;
	public float DBArtworkTimersG103;
	public float DBArtworkTimersG104;
	public float DBArtworkTimersG105;
	public float DBArtworkTimersG106;
	public float DBArtworkTimersG107;
	public float DBArtworkTimersG108;
	public float DBArtworkTimersG109;
	public float DBArtworkTimersG110;
	public float DBArtworkTimersG111;
	public float DBArtworkTimersG112;
	public float DBArtworkTimersG113;
	public float DBArtworkTimersG114;
	public float DBArtworkTimersG115;
	public float DBArtworkTimersG201;
	public float DBArtworkTimersG202;
	public float DBArtworkTimersG203;
	public float DBArtworkTimersG204;
	public float DBArtworkTimersG205;
	public float DBArtworkTimersG206;
	public float DBArtworkTimersG207;
	public float DBArtworkTimersG208;
	public float DBArtworkTimersG209;
	public float DBArtworkTimersG210;
	public float DBArtworkTimersG211;
	public float DBArtworkTimersG212;
	public float DBArtworkTimersG213;
	public float DBArtworkTimersG214;
	public float DBArtworkTimersG215;
    public float DBArtworkTimersG301;
	public float DBArtworkTimersG302;
	public float DBArtworkTimersG303;
	public float DBArtworkTimersG304;
	public float DBArtworkTimersG305;
	public float DBArtworkTimersG306;
	public float DBArtworkTimersG307;
	public float DBArtworkTimersG308;
	public float DBArtworkTimersG309;
	public float DBArtworkTimersG310;
	public float DBArtworkTimersG311;
	public float DBArtworkTimersG312;
	public float DBArtworkTimersG313;
	public float DBArtworkTimersG314;
	public float DBArtworkTimersG315;
	public float DBArtworkTimersFB01;
	public float DBArtworkTimersFB02;
	public float DBArtworkTimersFB03;
	public float DBArtworkTimersFB04;
	public float DBArtworkTimersFB05;
	public float DBArtworkTimersFB06;
	public float DBArtworkTimersFB07;
	public float DBArtworkTimersFB08;
	public float DBArtworkTimersFB09;
	public float DBArtworkTimersFB10;
	public float DBArtworkTimersFB11;
	public float DBArtworkTimersFB12;
	public float DBArtworkTimersFB13;
	public float DBArtworkTimersFB14;
	public float DBArtworkTimersFB15;
    public float DBBonusArtworkTimers01;
    public float DBBonusArtworkTimers02;
    public float DBBonusArtworkTimers03;
    public float DBBonusArtworkTimers04;
    public float DBBonusArtworkTimers05;
    public float DBBonusArtworkTimers06;
    public float DBBonusArtworkTimers07;
    public float DBBonusArtworkTimers08;
    public float DBBonusArtworkTimers09;
    public float DBBonusArtworkTimers10;
    public float DBArtworkTimersF101Added;
    public float DBArtworkTimersF102Added;
    public float DBArtworkTimersF103Added;
    public float DBArtworkTimersF104Added;
    public float DBArtworkTimersF105Added;
    public float DBArtworkTimersF106Added;
    public float DBArtworkTimersF107Added;
    public float DBArtworkTimersF108Added;
    public float DBArtworkTimersF201Added;
    public float DBArtworkTimersF202Added;
    public float DBArtworkTimersF203Added;
    public float DBArtworkTimersF204Added;
    public float DBArtworkTimersF205Added;
    public float DBArtworkTimersF206Added;
    public float DBArtworkTimersF207Added;
    public float DBArtworkTimersF208Added;
    public float DBArtworkTimersF301Added;
    public float DBArtworkTimersF302Added;
    public float DBArtworkTimersF303Added;
    public float DBArtworkTimersF304Added;
    public float DBArtworkTimersF305Added;
    public float DBArtworkTimersF306Added;
    public float DBArtworkTimersF307Added;
    public float DBArtworkTimersF308Added;
    public float DBArtworkTimersG101Added;
    public float DBArtworkTimersG102Added;
    public float DBArtworkTimersG103Added;
    public float DBArtworkTimersG104Added;
    public float DBArtworkTimersG105Added;
    public float DBArtworkTimersG106Added;
    public float DBArtworkTimersG107Added;
    public float DBArtworkTimersG108Added;
    public float DBArtworkTimersG201Added;
    public float DBArtworkTimersG202Added;
    public float DBArtworkTimersG203Added;
    public float DBArtworkTimersG204Added;
    public float DBArtworkTimersG205Added;
    public float DBArtworkTimersG206Added;
    public float DBArtworkTimersG207Added;
    public float DBArtworkTimersG208Added;
    public float DBArtworkTimersG301Added;
    public float DBArtworkTimersG302Added;
    public float DBArtworkTimersG303Added;
    public float DBArtworkTimersG304Added;
    public float DBArtworkTimersG305Added;
    public float DBArtworkTimersG306Added;
    public float DBArtworkTimersG307Added;
    public float DBArtworkTimersG308Added;
    public float DBArtworkTimersFB01Added;
    public float DBArtworkTimersFB02Added;
    public float DBArtworkTimersFB03Added;
    public float DBArtworkTimersFB04Added;
    public float DBArtworkTimersFB05Added;
    public float DBArtworkTimersFB06Added;
    public float DBArtworkTimersFB07Added;
    public float DBArtworkTimersFB08Added;
    public float DBArtworkTimersFB09Added;
    public float DBArtworkTimersFB10Added;
    
	// Constructor - Art Timers
	public ChateauArtTimers(float DBArtworkTimersF101, float DBArtworkTimersF102, float DBArtworkTimersF103, float DBArtworkTimersF104, float DBArtworkTimersF105, float DBArtworkTimersF106, float DBArtworkTimersF107, float DBArtworkTimersF108, float DBArtworkTimersF109, float DBArtworkTimersF110, float DBArtworkTimersF111, float DBArtworkTimersF112, float DBArtworkTimersF113, float DBArtworkTimersF114, float DBArtworkTimersF115, float DBArtworkTimersF201, float DBArtworkTimersF202, float DBArtworkTimersF203, float DBArtworkTimersF204, float DBArtworkTimersF205, float DBArtworkTimersF206, float DBArtworkTimersF207, float DBArtworkTimersF208, float DBArtworkTimersF209, float DBArtworkTimersF210, float DBArtworkTimersF211, float DBArtworkTimersF212, float DBArtworkTimersF213, float DBArtworkTimersF214, float DBArtworkTimersF215, float DBArtworkTimersF301, float DBArtworkTimersF302, float DBArtworkTimersF303, float DBArtworkTimersF304, float DBArtworkTimersF305, float DBArtworkTimersF306, float DBArtworkTimersF307, float DBArtworkTimersF308, float DBArtworkTimersF309, float DBArtworkTimersF310, float DBArtworkTimersF311, float DBArtworkTimersF312, float DBArtworkTimersF313, float DBArtworkTimersF314, float DBArtworkTimersF315, float DBArtworkTimersG101, float DBArtworkTimersG102, float DBArtworkTimersG103, float DBArtworkTimersG104, float DBArtworkTimersG105, float DBArtworkTimersG106, float DBArtworkTimersG107, float DBArtworkTimersG108, float DBArtworkTimersG109, float DBArtworkTimersG110, float DBArtworkTimersG111, float DBArtworkTimersG112, float DBArtworkTimersG113, float DBArtworkTimersG114, float DBArtworkTimersG115, float DBArtworkTimersG201, float DBArtworkTimersG202, float DBArtworkTimersG203, float DBArtworkTimersG204, float DBArtworkTimersG205, float DBArtworkTimersG206, float DBArtworkTimersG207, float DBArtworkTimersG208, float DBArtworkTimersG209, float DBArtworkTimersG210, float DBArtworkTimersG211, float DBArtworkTimersG212, float DBArtworkTimersG213, float DBArtworkTimersG214, float DBArtworkTimersG215, float DBArtworkTimersG301, float DBArtworkTimersG302, float DBArtworkTimersG303, float DBArtworkTimersG304, float DBArtworkTimersG305, float DBArtworkTimersG306, float DBArtworkTimersG307, float DBArtworkTimersG308, float DBArtworkTimersG309, float DBArtworkTimersG310, float DBArtworkTimersG311, float DBArtworkTimersG312, float DBArtworkTimersG313, float DBArtworkTimersG314, float DBArtworkTimersG315, float DBArtworkTimersFB01, float DBArtworkTimersFB02, float DBArtworkTimersFB03, float DBArtworkTimersFB04, float DBArtworkTimersFB05, float DBArtworkTimersFB06, float DBArtworkTimersFB07, float DBArtworkTimersFB08, float DBArtworkTimersFB09, float DBArtworkTimersFB10, float DBArtworkTimersFB11, float DBArtworkTimersFB12, float DBArtworkTimersFB13, float DBArtworkTimersFB14, float DBArtworkTimersFB15, float DBBonusArtworkTimers01, float DBBonusArtworkTimers02, float DBBonusArtworkTimers03, float DBBonusArtworkTimers04, float DBBonusArtworkTimers05, float DBBonusArtworkTimers06, float DBBonusArtworkTimers07, float DBBonusArtworkTimers08, float DBBonusArtworkTimers09, float DBBonusArtworkTimers10, float DBArtworkTimersF101Added, float DBArtworkTimersF102Added, float DBArtworkTimersF103Added, float DBArtworkTimersF104Added, float DBArtworkTimersF105Added, float DBArtworkTimersF106Added, float DBArtworkTimersF107Added, float DBArtworkTimersF108Added, float DBArtworkTimersF201Added, float DBArtworkTimersF202Added, float DBArtworkTimersF203Added, float DBArtworkTimersF204Added, float DBArtworkTimersF205Added, float DBArtworkTimersF206Added, float DBArtworkTimersF207Added, float DBArtworkTimersF208Added, float DBArtworkTimersF301Added, float DBArtworkTimersF302Added, float DBArtworkTimersF303Added, float DBArtworkTimersF304Added, float DBArtworkTimersF305Added, float DBArtworkTimersF306Added, float DBArtworkTimersF307Added, float DBArtworkTimersF308Added, float DBArtworkTimersG101Added, float DBArtworkTimersG102Added, float DBArtworkTimersG103Added, float DBArtworkTimersG104Added, float DBArtworkTimersG105Added, float DBArtworkTimersG106Added, float DBArtworkTimersG107Added, float DBArtworkTimersG108Added, float DBArtworkTimersG201Added, float DBArtworkTimersG202Added, float DBArtworkTimersG203Added, float DBArtworkTimersG204Added, float DBArtworkTimersG205Added, float DBArtworkTimersG206Added, float DBArtworkTimersG207Added, float DBArtworkTimersG208Added, float DBArtworkTimersG301Added, float DBArtworkTimersG302Added, float DBArtworkTimersG303Added, float DBArtworkTimersG304Added, float DBArtworkTimersG305Added, float DBArtworkTimersG306Added, float DBArtworkTimersG307Added, float DBArtworkTimersG308Added, float DBArtworkTimersFB01Added, float DBArtworkTimersFB02Added, float DBArtworkTimersFB03Added, float DBArtworkTimersFB04Added, float DBArtworkTimersFB05Added, float DBArtworkTimersFB06Added, float DBArtworkTimersFB07Added, float DBArtworkTimersFB08Added, float DBArtworkTimersFB09Added, float DBArtworkTimersFB10Added) {
        this.DBArtworkTimersF101 = DBArtworkTimersF101;
        this.DBArtworkTimersF102 = DBArtworkTimersF102;
        this.DBArtworkTimersF103 = DBArtworkTimersF103;
        this.DBArtworkTimersF104 = DBArtworkTimersF104;
        this.DBArtworkTimersF105 = DBArtworkTimersF105;
        this.DBArtworkTimersF106 = DBArtworkTimersF106;
        this.DBArtworkTimersF107 = DBArtworkTimersF107;
        this.DBArtworkTimersF108 = DBArtworkTimersF108;
        this.DBArtworkTimersF109 = DBArtworkTimersF109;
        this.DBArtworkTimersF110 = DBArtworkTimersF110;
        this.DBArtworkTimersF111 = DBArtworkTimersF111;
        this.DBArtworkTimersF112 = DBArtworkTimersF112;
        this.DBArtworkTimersF113 = DBArtworkTimersF113;
        this.DBArtworkTimersF114 = DBArtworkTimersF114;
        this.DBArtworkTimersF115 = DBArtworkTimersF115;
        this.DBArtworkTimersF201 = DBArtworkTimersF201;
        this.DBArtworkTimersF202 = DBArtworkTimersF202;
        this.DBArtworkTimersF203 = DBArtworkTimersF203;
        this.DBArtworkTimersF204 = DBArtworkTimersF204;
        this.DBArtworkTimersF205 = DBArtworkTimersF205;
        this.DBArtworkTimersF206 = DBArtworkTimersF206;
        this.DBArtworkTimersF207 = DBArtworkTimersF207;
        this.DBArtworkTimersF208 = DBArtworkTimersF208;
        this.DBArtworkTimersF209 = DBArtworkTimersF209;
        this.DBArtworkTimersF210 = DBArtworkTimersF210;
        this.DBArtworkTimersF211 = DBArtworkTimersF211;
        this.DBArtworkTimersF212 = DBArtworkTimersF212;
        this.DBArtworkTimersF213 = DBArtworkTimersF213;
        this.DBArtworkTimersF214 = DBArtworkTimersF214;
        this.DBArtworkTimersF215 = DBArtworkTimersF215;
        this.DBArtworkTimersF301 = DBArtworkTimersF301;
        this.DBArtworkTimersF302 = DBArtworkTimersF302;
        this.DBArtworkTimersF303 = DBArtworkTimersF303;
        this.DBArtworkTimersF304 = DBArtworkTimersF304;
        this.DBArtworkTimersF305 = DBArtworkTimersF305;
        this.DBArtworkTimersF306 = DBArtworkTimersF306;
        this.DBArtworkTimersF307 = DBArtworkTimersF307;
        this.DBArtworkTimersF308 = DBArtworkTimersF308;
        this.DBArtworkTimersF309 = DBArtworkTimersF309;
        this.DBArtworkTimersF310 = DBArtworkTimersF310;
        this.DBArtworkTimersF311 = DBArtworkTimersF311;
        this.DBArtworkTimersF312 = DBArtworkTimersF312;
        this.DBArtworkTimersF313 = DBArtworkTimersF313;
        this.DBArtworkTimersF314 = DBArtworkTimersF314;
        this.DBArtworkTimersF315 = DBArtworkTimersF315;
        this.DBArtworkTimersG101 = DBArtworkTimersG101;
        this.DBArtworkTimersG102 = DBArtworkTimersG102;
        this.DBArtworkTimersG103 = DBArtworkTimersG103;
        this.DBArtworkTimersG104 = DBArtworkTimersG104;
        this.DBArtworkTimersG105 = DBArtworkTimersG105;
        this.DBArtworkTimersG106 = DBArtworkTimersG106;
        this.DBArtworkTimersG107 = DBArtworkTimersG107;
        this.DBArtworkTimersG108 = DBArtworkTimersG108;
        this.DBArtworkTimersG109 = DBArtworkTimersG109;
        this.DBArtworkTimersG110 = DBArtworkTimersG110;
        this.DBArtworkTimersG111 = DBArtworkTimersG111;
        this.DBArtworkTimersG112 = DBArtworkTimersG112;
        this.DBArtworkTimersG113 = DBArtworkTimersG113;
        this.DBArtworkTimersG114 = DBArtworkTimersG114;
        this.DBArtworkTimersG115 = DBArtworkTimersG115;
        this.DBArtworkTimersG201 = DBArtworkTimersG201;
        this.DBArtworkTimersG202 = DBArtworkTimersG202;
        this.DBArtworkTimersG203 = DBArtworkTimersG203;
        this.DBArtworkTimersG204 = DBArtworkTimersG204;
        this.DBArtworkTimersG205 = DBArtworkTimersG205;
        this.DBArtworkTimersG206 = DBArtworkTimersG206;
        this.DBArtworkTimersG207 = DBArtworkTimersG207;
        this.DBArtworkTimersG208 = DBArtworkTimersG208;
        this.DBArtworkTimersG209 = DBArtworkTimersG209;
        this.DBArtworkTimersG210 = DBArtworkTimersG210;
        this.DBArtworkTimersG211 = DBArtworkTimersG211;
        this.DBArtworkTimersG212 = DBArtworkTimersG212;
        this.DBArtworkTimersG213 = DBArtworkTimersG213;
        this.DBArtworkTimersG214 = DBArtworkTimersG214;
        this.DBArtworkTimersG215 = DBArtworkTimersG215;
        this.DBArtworkTimersG301 = DBArtworkTimersG301;
        this.DBArtworkTimersG302 = DBArtworkTimersG302;
        this.DBArtworkTimersG303 = DBArtworkTimersG303;
        this.DBArtworkTimersG304 = DBArtworkTimersG304;
        this.DBArtworkTimersG305 = DBArtworkTimersG305;
        this.DBArtworkTimersG306 = DBArtworkTimersG306;
        this.DBArtworkTimersG307 = DBArtworkTimersG307;
        this.DBArtworkTimersG308 = DBArtworkTimersG308;
        this.DBArtworkTimersG309 = DBArtworkTimersG309;
        this.DBArtworkTimersG310 = DBArtworkTimersG310;
        this.DBArtworkTimersG311 = DBArtworkTimersG311;
        this.DBArtworkTimersG312 = DBArtworkTimersG312;
        this.DBArtworkTimersG313 = DBArtworkTimersG313;
        this.DBArtworkTimersG314 = DBArtworkTimersG314;
        this.DBArtworkTimersG315 = DBArtworkTimersG315;
        this.DBArtworkTimersFB01 = DBArtworkTimersFB01;
        this.DBArtworkTimersFB02 = DBArtworkTimersFB02;
        this.DBArtworkTimersFB03 = DBArtworkTimersFB03;
        this.DBArtworkTimersFB04 = DBArtworkTimersFB04;
        this.DBArtworkTimersFB05 = DBArtworkTimersFB05;
        this.DBArtworkTimersFB06 = DBArtworkTimersFB06;
        this.DBArtworkTimersFB07 = DBArtworkTimersFB07;
        this.DBArtworkTimersFB08 = DBArtworkTimersFB08;
        this.DBArtworkTimersFB09 = DBArtworkTimersFB09;
        this.DBArtworkTimersFB10 = DBArtworkTimersFB10;
        this.DBArtworkTimersFB11 = DBArtworkTimersFB11;
        this.DBArtworkTimersFB12 = DBArtworkTimersFB12;
        this.DBArtworkTimersFB13 = DBArtworkTimersFB13;
        this.DBArtworkTimersFB14 = DBArtworkTimersFB14;
        this.DBArtworkTimersFB15 = DBArtworkTimersFB15;
        this.DBBonusArtworkTimers01 = DBBonusArtworkTimers01;
        this.DBBonusArtworkTimers02 = DBBonusArtworkTimers02;
        this.DBBonusArtworkTimers03 = DBBonusArtworkTimers03;
        this.DBBonusArtworkTimers04 = DBBonusArtworkTimers04;
        this.DBBonusArtworkTimers05 = DBBonusArtworkTimers05;
        this.DBBonusArtworkTimers06 = DBBonusArtworkTimers06;
        this.DBBonusArtworkTimers07 = DBBonusArtworkTimers07;
        this.DBBonusArtworkTimers08 = DBBonusArtworkTimers08;
        this.DBBonusArtworkTimers09 = DBBonusArtworkTimers09;
        this.DBBonusArtworkTimers10 = DBBonusArtworkTimers10;
        this.DBArtworkTimersF101Added = DBArtworkTimersF101Added;
        this.DBArtworkTimersF102Added = DBArtworkTimersF102Added;
        this.DBArtworkTimersF103Added = DBArtworkTimersF103Added;
        this.DBArtworkTimersF104Added = DBArtworkTimersF104Added;
        this.DBArtworkTimersF105Added = DBArtworkTimersF105Added;
        this.DBArtworkTimersF106Added = DBArtworkTimersF106Added;
        this.DBArtworkTimersF107Added = DBArtworkTimersF107Added;
        this.DBArtworkTimersF108Added = DBArtworkTimersF108Added;
        this.DBArtworkTimersF201Added = DBArtworkTimersF201Added;
        this.DBArtworkTimersF202Added = DBArtworkTimersF202Added;
        this.DBArtworkTimersF203Added = DBArtworkTimersF203Added;
        this.DBArtworkTimersF204Added = DBArtworkTimersF204Added;
        this.DBArtworkTimersF205Added = DBArtworkTimersF205Added;
        this.DBArtworkTimersF206Added = DBArtworkTimersF206Added;
        this.DBArtworkTimersF207Added = DBArtworkTimersF207Added;
        this.DBArtworkTimersF208Added = DBArtworkTimersF208Added;
        this.DBArtworkTimersF301Added = DBArtworkTimersF301Added;
        this.DBArtworkTimersF302Added = DBArtworkTimersF302Added;
        this.DBArtworkTimersF303Added = DBArtworkTimersF303Added;
        this.DBArtworkTimersF304Added = DBArtworkTimersF304Added;
        this.DBArtworkTimersF305Added = DBArtworkTimersF305Added;
        this.DBArtworkTimersF306Added = DBArtworkTimersF306Added;
        this.DBArtworkTimersF307Added = DBArtworkTimersF307Added;
        this.DBArtworkTimersF308Added = DBArtworkTimersF308Added;
        this.DBArtworkTimersG101Added = DBArtworkTimersG101Added;
        this.DBArtworkTimersG102Added = DBArtworkTimersG102Added;
        this.DBArtworkTimersG103Added = DBArtworkTimersG103Added;
        this.DBArtworkTimersG104Added = DBArtworkTimersG104Added;
        this.DBArtworkTimersG105Added = DBArtworkTimersG105Added;
        this.DBArtworkTimersG106Added = DBArtworkTimersG106Added;
        this.DBArtworkTimersG107Added = DBArtworkTimersG107Added;
        this.DBArtworkTimersG108Added = DBArtworkTimersG108Added;
        this.DBArtworkTimersG201Added = DBArtworkTimersG201Added;
        this.DBArtworkTimersG202Added = DBArtworkTimersG202Added;
        this.DBArtworkTimersG203Added = DBArtworkTimersG203Added;
        this.DBArtworkTimersG204Added = DBArtworkTimersG204Added;
        this.DBArtworkTimersG205Added = DBArtworkTimersG205Added;
        this.DBArtworkTimersG206Added = DBArtworkTimersG206Added;
        this.DBArtworkTimersG207Added = DBArtworkTimersG207Added;
        this.DBArtworkTimersG208Added = DBArtworkTimersG208Added;
        this.DBArtworkTimersG301Added = DBArtworkTimersG301Added;
        this.DBArtworkTimersG302Added = DBArtworkTimersG302Added;
        this.DBArtworkTimersG303Added = DBArtworkTimersG303Added;
        this.DBArtworkTimersG304Added = DBArtworkTimersG304Added;
        this.DBArtworkTimersG305Added = DBArtworkTimersG305Added;
        this.DBArtworkTimersG306Added = DBArtworkTimersG306Added;
        this.DBArtworkTimersG307Added = DBArtworkTimersG307Added;
        this.DBArtworkTimersG308Added = DBArtworkTimersG308Added;
        this.DBArtworkTimersFB01Added = DBArtworkTimersFB01Added;
        this.DBArtworkTimersFB02Added = DBArtworkTimersFB02Added;
        this.DBArtworkTimersFB03Added = DBArtworkTimersFB03Added;
        this.DBArtworkTimersFB04Added = DBArtworkTimersFB04Added;
        this.DBArtworkTimersFB05Added = DBArtworkTimersFB05Added;
        this.DBArtworkTimersFB06Added = DBArtworkTimersFB06Added;
        this.DBArtworkTimersFB07Added = DBArtworkTimersFB07Added;
        this.DBArtworkTimersFB08Added = DBArtworkTimersFB08Added;
        this.DBArtworkTimersFB09Added = DBArtworkTimersFB09Added;
        this.DBArtworkTimersFB10Added = DBArtworkTimersFB10Added;
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