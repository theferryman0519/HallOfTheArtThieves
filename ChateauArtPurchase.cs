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

public class ChateauArtPurchase {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Class Properties - Art Purchase
    public int DBArtworkPurchaseF101;
	public int DBArtworkPurchaseF102;
	public int DBArtworkPurchaseF103;
	public int DBArtworkPurchaseF104;
	public int DBArtworkPurchaseF105;
	public int DBArtworkPurchaseF106;
	public int DBArtworkPurchaseF107;
	public int DBArtworkPurchaseF108;
	public int DBArtworkPurchaseF109;
	public int DBArtworkPurchaseF110;
	public int DBArtworkPurchaseF111;
	public int DBArtworkPurchaseF112;
	public int DBArtworkPurchaseF113;
	public int DBArtworkPurchaseF114;
	public int DBArtworkPurchaseF115;
	public int DBArtworkPurchaseF201;
	public int DBArtworkPurchaseF202;
	public int DBArtworkPurchaseF203;
	public int DBArtworkPurchaseF204;
	public int DBArtworkPurchaseF205;
	public int DBArtworkPurchaseF206;
	public int DBArtworkPurchaseF207;
	public int DBArtworkPurchaseF208;
	public int DBArtworkPurchaseF209;
	public int DBArtworkPurchaseF210;
	public int DBArtworkPurchaseF211;
	public int DBArtworkPurchaseF212;
	public int DBArtworkPurchaseF213;
	public int DBArtworkPurchaseF214;
	public int DBArtworkPurchaseF215;
	public int DBArtworkPurchaseF301;
	public int DBArtworkPurchaseF302;
	public int DBArtworkPurchaseF303;
	public int DBArtworkPurchaseF304;
	public int DBArtworkPurchaseF305;
	public int DBArtworkPurchaseF306;
	public int DBArtworkPurchaseF307;
	public int DBArtworkPurchaseF308;
	public int DBArtworkPurchaseF309;
	public int DBArtworkPurchaseF310;
	public int DBArtworkPurchaseF311;
	public int DBArtworkPurchaseF312;
	public int DBArtworkPurchaseF313;
	public int DBArtworkPurchaseF314;
	public int DBArtworkPurchaseF315;
	public int DBArtworkPurchaseG101;
	public int DBArtworkPurchaseG102;
	public int DBArtworkPurchaseG103;
	public int DBArtworkPurchaseG104;
	public int DBArtworkPurchaseG105;
	public int DBArtworkPurchaseG106;
	public int DBArtworkPurchaseG107;
	public int DBArtworkPurchaseG108;
	public int DBArtworkPurchaseG109;
	public int DBArtworkPurchaseG110;
	public int DBArtworkPurchaseG111;
	public int DBArtworkPurchaseG112;
	public int DBArtworkPurchaseG113;
	public int DBArtworkPurchaseG114;
	public int DBArtworkPurchaseG115;
	public int DBArtworkPurchaseG201;
	public int DBArtworkPurchaseG202;
	public int DBArtworkPurchaseG203;
	public int DBArtworkPurchaseG204;
	public int DBArtworkPurchaseG205;
	public int DBArtworkPurchaseG206;
	public int DBArtworkPurchaseG207;
	public int DBArtworkPurchaseG208;
	public int DBArtworkPurchaseG209;
	public int DBArtworkPurchaseG210;
	public int DBArtworkPurchaseG211;
	public int DBArtworkPurchaseG212;
	public int DBArtworkPurchaseG213;
	public int DBArtworkPurchaseG214;
	public int DBArtworkPurchaseG215;
    public int DBArtworkPurchaseG301;
	public int DBArtworkPurchaseG302;
	public int DBArtworkPurchaseG303;
	public int DBArtworkPurchaseG304;
	public int DBArtworkPurchaseG305;
	public int DBArtworkPurchaseG306;
	public int DBArtworkPurchaseG307;
	public int DBArtworkPurchaseG308;
	public int DBArtworkPurchaseG309;
	public int DBArtworkPurchaseG310;
	public int DBArtworkPurchaseG311;
	public int DBArtworkPurchaseG312;
	public int DBArtworkPurchaseG313;
	public int DBArtworkPurchaseG314;
	public int DBArtworkPurchaseG315;
	public int DBArtworkPurchaseFB01;
	public int DBArtworkPurchaseFB02;
	public int DBArtworkPurchaseFB03;
	public int DBArtworkPurchaseFB04;
	public int DBArtworkPurchaseFB05;
	public int DBArtworkPurchaseFB06;
	public int DBArtworkPurchaseFB07;
	public int DBArtworkPurchaseFB08;
	public int DBArtworkPurchaseFB09;
	public int DBArtworkPurchaseFB10;
	public int DBArtworkPurchaseFB11;
	public int DBArtworkPurchaseFB12;
	public int DBArtworkPurchaseFB13;
	public int DBArtworkPurchaseFB14;
	public int DBArtworkPurchaseFB15;
    public int DBBonusArtworkObtain01;
    public int DBBonusArtworkObtain02;
    public int DBBonusArtworkObtain03;
    public int DBBonusArtworkObtain04;
    public int DBBonusArtworkObtain05;
    public int DBBonusArtworkObtain06;
    public int DBBonusArtworkObtain07;
    public int DBBonusArtworkObtain08;
    public int DBBonusArtworkObtain09;
    public int DBBonusArtworkObtain10;
    public int DBArtworkPurchaseF101Added;
    public int DBArtworkPurchaseF102Added;
    public int DBArtworkPurchaseF103Added;
    public int DBArtworkPurchaseF104Added;
    public int DBArtworkPurchaseF105Added;
    public int DBArtworkPurchaseF106Added;
    public int DBArtworkPurchaseF107Added;
    public int DBArtworkPurchaseF108Added;
    public int DBArtworkPurchaseF201Added;
    public int DBArtworkPurchaseF202Added;
    public int DBArtworkPurchaseF203Added;
    public int DBArtworkPurchaseF204Added;
    public int DBArtworkPurchaseF205Added;
    public int DBArtworkPurchaseF206Added;
    public int DBArtworkPurchaseF207Added;
    public int DBArtworkPurchaseF208Added;
    public int DBArtworkPurchaseF301Added;
    public int DBArtworkPurchaseF302Added;
    public int DBArtworkPurchaseF303Added;
    public int DBArtworkPurchaseF304Added;
    public int DBArtworkPurchaseF305Added;
    public int DBArtworkPurchaseF306Added;
    public int DBArtworkPurchaseF307Added;
    public int DBArtworkPurchaseF308Added;
    public int DBArtworkPurchaseG101Added;
    public int DBArtworkPurchaseG102Added;
    public int DBArtworkPurchaseG103Added;
    public int DBArtworkPurchaseG104Added;
    public int DBArtworkPurchaseG105Added;
    public int DBArtworkPurchaseG106Added;
    public int DBArtworkPurchaseG107Added;
    public int DBArtworkPurchaseG108Added;
    public int DBArtworkPurchaseG201Added;
    public int DBArtworkPurchaseG202Added;
    public int DBArtworkPurchaseG203Added;
    public int DBArtworkPurchaseG204Added;
    public int DBArtworkPurchaseG205Added;
    public int DBArtworkPurchaseG206Added;
    public int DBArtworkPurchaseG207Added;
    public int DBArtworkPurchaseG208Added;
    public int DBArtworkPurchaseG301Added;
    public int DBArtworkPurchaseG302Added;
    public int DBArtworkPurchaseG303Added;
    public int DBArtworkPurchaseG304Added;
    public int DBArtworkPurchaseG305Added;
    public int DBArtworkPurchaseG306Added;
    public int DBArtworkPurchaseG307Added;
    public int DBArtworkPurchaseG308Added;
    public int DBArtworkPurchaseFB01Added;
    public int DBArtworkPurchaseFB02Added;
    public int DBArtworkPurchaseFB03Added;
    public int DBArtworkPurchaseFB04Added;
    public int DBArtworkPurchaseFB05Added;
    public int DBArtworkPurchaseFB06Added;
    public int DBArtworkPurchaseFB07Added;
    public int DBArtworkPurchaseFB08Added;
    public int DBArtworkPurchaseFB09Added;
    public int DBArtworkPurchaseFB10Added;
    
	// Constructor - Art Purchase
	public ChateauArtPurchase(int DBArtworkPurchaseF101, int DBArtworkPurchaseF102, int DBArtworkPurchaseF103, int DBArtworkPurchaseF104, int DBArtworkPurchaseF105, int DBArtworkPurchaseF106, int DBArtworkPurchaseF107, int DBArtworkPurchaseF108, int DBArtworkPurchaseF109, int DBArtworkPurchaseF110, int DBArtworkPurchaseF111, int DBArtworkPurchaseF112, int DBArtworkPurchaseF113, int DBArtworkPurchaseF114, int DBArtworkPurchaseF115, int DBArtworkPurchaseF201, int DBArtworkPurchaseF202, int DBArtworkPurchaseF203, int DBArtworkPurchaseF204, int DBArtworkPurchaseF205, int DBArtworkPurchaseF206, int DBArtworkPurchaseF207, int DBArtworkPurchaseF208, int DBArtworkPurchaseF209, int DBArtworkPurchaseF210, int DBArtworkPurchaseF211, int DBArtworkPurchaseF212, int DBArtworkPurchaseF213, int DBArtworkPurchaseF214, int DBArtworkPurchaseF215, int DBArtworkPurchaseF301, int DBArtworkPurchaseF302, int DBArtworkPurchaseF303, int DBArtworkPurchaseF304, int DBArtworkPurchaseF305, int DBArtworkPurchaseF306, int DBArtworkPurchaseF307, int DBArtworkPurchaseF308, int DBArtworkPurchaseF309, int DBArtworkPurchaseF310, int DBArtworkPurchaseF311, int DBArtworkPurchaseF312, int DBArtworkPurchaseF313, int DBArtworkPurchaseF314, int DBArtworkPurchaseF315, int DBArtworkPurchaseG101, int DBArtworkPurchaseG102, int DBArtworkPurchaseG103, int DBArtworkPurchaseG104, int DBArtworkPurchaseG105, int DBArtworkPurchaseG106, int DBArtworkPurchaseG107, int DBArtworkPurchaseG108, int DBArtworkPurchaseG109, int DBArtworkPurchaseG110, int DBArtworkPurchaseG111, int DBArtworkPurchaseG112, int DBArtworkPurchaseG113, int DBArtworkPurchaseG114, int DBArtworkPurchaseG115, int DBArtworkPurchaseG201, int DBArtworkPurchaseG202, int DBArtworkPurchaseG203, int DBArtworkPurchaseG204, int DBArtworkPurchaseG205, int DBArtworkPurchaseG206, int DBArtworkPurchaseG207, int DBArtworkPurchaseG208, int DBArtworkPurchaseG209, int DBArtworkPurchaseG210, int DBArtworkPurchaseG211, int DBArtworkPurchaseG212, int DBArtworkPurchaseG213, int DBArtworkPurchaseG214, int DBArtworkPurchaseG215, int DBArtworkPurchaseG301, int DBArtworkPurchaseG302, int DBArtworkPurchaseG303, int DBArtworkPurchaseG304, int DBArtworkPurchaseG305, int DBArtworkPurchaseG306, int DBArtworkPurchaseG307, int DBArtworkPurchaseG308, int DBArtworkPurchaseG309, int DBArtworkPurchaseG310, int DBArtworkPurchaseG311, int DBArtworkPurchaseG312, int DBArtworkPurchaseG313, int DBArtworkPurchaseG314, int DBArtworkPurchaseG315,int DBArtworkPurchaseFB01, int DBArtworkPurchaseFB02, int DBArtworkPurchaseFB03, int DBArtworkPurchaseFB04, int DBArtworkPurchaseFB05, int DBArtworkPurchaseFB06, int DBArtworkPurchaseFB07, int DBArtworkPurchaseFB08, int DBArtworkPurchaseFB09, int DBArtworkPurchaseFB10, int DBArtworkPurchaseFB11, int DBArtworkPurchaseFB12, int DBArtworkPurchaseFB13, int DBArtworkPurchaseFB14, int DBArtworkPurchaseFB15, int DBBonusArtworkObtain01, int DBBonusArtworkObtain02, int DBBonusArtworkObtain03, int DBBonusArtworkObtain04, int DBBonusArtworkObtain05, int DBBonusArtworkObtain06, int DBBonusArtworkObtain07, int DBBonusArtworkObtain08, int DBBonusArtworkObtain09, int DBBonusArtworkObtain10, int DBArtworkPurchaseF101Added, int DBArtworkPurchaseF102Added, int DBArtworkPurchaseF103Added, int DBArtworkPurchaseF104Added, int DBArtworkPurchaseF105Added, int DBArtworkPurchaseF106Added, int DBArtworkPurchaseF107Added, int DBArtworkPurchaseF108Added, int DBArtworkPurchaseF201Added, int DBArtworkPurchaseF202Added, int DBArtworkPurchaseF203Added, int DBArtworkPurchaseF204Added, int DBArtworkPurchaseF205Added, int DBArtworkPurchaseF206Added, int DBArtworkPurchaseF207Added, int DBArtworkPurchaseF208Added, int DBArtworkPurchaseF301Added, int DBArtworkPurchaseF302Added, int DBArtworkPurchaseF303Added, int DBArtworkPurchaseF304Added, int DBArtworkPurchaseF305Added, int DBArtworkPurchaseF306Added, int DBArtworkPurchaseF307Added, int DBArtworkPurchaseF308Added, int DBArtworkPurchaseG101Added, int DBArtworkPurchaseG102Added, int DBArtworkPurchaseG103Added, int DBArtworkPurchaseG104Added, int DBArtworkPurchaseG105Added, int DBArtworkPurchaseG106Added, int DBArtworkPurchaseG107Added, int DBArtworkPurchaseG108Added, int DBArtworkPurchaseG201Added, int DBArtworkPurchaseG202Added, int DBArtworkPurchaseG203Added, int DBArtworkPurchaseG204Added, int DBArtworkPurchaseG205Added, int DBArtworkPurchaseG206Added, int DBArtworkPurchaseG207Added, int DBArtworkPurchaseG208Added, int DBArtworkPurchaseG301Added, int DBArtworkPurchaseG302Added, int DBArtworkPurchaseG303Added, int DBArtworkPurchaseG304Added, int DBArtworkPurchaseG305Added, int DBArtworkPurchaseG306Added, int DBArtworkPurchaseG307Added, int DBArtworkPurchaseG308Added, int DBArtworkPurchaseFB01Added, int DBArtworkPurchaseFB02Added, int DBArtworkPurchaseFB03Added, int DBArtworkPurchaseFB04Added, int DBArtworkPurchaseFB05Added, int DBArtworkPurchaseFB06Added, int DBArtworkPurchaseFB07Added, int DBArtworkPurchaseFB08Added, int DBArtworkPurchaseFB09Added, int DBArtworkPurchaseFB10Added) {
        this.DBArtworkPurchaseF101 = DBArtworkPurchaseF101;
        this.DBArtworkPurchaseF102 = DBArtworkPurchaseF102;
        this.DBArtworkPurchaseF103 = DBArtworkPurchaseF103;
        this.DBArtworkPurchaseF104 = DBArtworkPurchaseF104;
        this.DBArtworkPurchaseF105 = DBArtworkPurchaseF105;
        this.DBArtworkPurchaseF106 = DBArtworkPurchaseF106;
        this.DBArtworkPurchaseF107 = DBArtworkPurchaseF107;
        this.DBArtworkPurchaseF108 = DBArtworkPurchaseF108;
        this.DBArtworkPurchaseF109 = DBArtworkPurchaseF109;
        this.DBArtworkPurchaseF110 = DBArtworkPurchaseF110;
        this.DBArtworkPurchaseF111 = DBArtworkPurchaseF111;
        this.DBArtworkPurchaseF112 = DBArtworkPurchaseF112;
        this.DBArtworkPurchaseF113 = DBArtworkPurchaseF113;
        this.DBArtworkPurchaseF114 = DBArtworkPurchaseF114;
        this.DBArtworkPurchaseF115 = DBArtworkPurchaseF115;
        this.DBArtworkPurchaseF201 = DBArtworkPurchaseF201;
        this.DBArtworkPurchaseF202 = DBArtworkPurchaseF202;
        this.DBArtworkPurchaseF203 = DBArtworkPurchaseF203;
        this.DBArtworkPurchaseF204 = DBArtworkPurchaseF204;
        this.DBArtworkPurchaseF205 = DBArtworkPurchaseF205;
        this.DBArtworkPurchaseF206 = DBArtworkPurchaseF206;
        this.DBArtworkPurchaseF207 = DBArtworkPurchaseF207;
        this.DBArtworkPurchaseF208 = DBArtworkPurchaseF208;
        this.DBArtworkPurchaseF209 = DBArtworkPurchaseF209;
        this.DBArtworkPurchaseF210 = DBArtworkPurchaseF210;
        this.DBArtworkPurchaseF211 = DBArtworkPurchaseF211;
        this.DBArtworkPurchaseF212 = DBArtworkPurchaseF212;
        this.DBArtworkPurchaseF213 = DBArtworkPurchaseF213;
        this.DBArtworkPurchaseF214 = DBArtworkPurchaseF214;
        this.DBArtworkPurchaseF215 = DBArtworkPurchaseF215;
        this.DBArtworkPurchaseF301 = DBArtworkPurchaseF301;
        this.DBArtworkPurchaseF302 = DBArtworkPurchaseF302;
        this.DBArtworkPurchaseF303 = DBArtworkPurchaseF303;
        this.DBArtworkPurchaseF304 = DBArtworkPurchaseF304;
        this.DBArtworkPurchaseF305 = DBArtworkPurchaseF305;
        this.DBArtworkPurchaseF306 = DBArtworkPurchaseF306;
        this.DBArtworkPurchaseF307 = DBArtworkPurchaseF307;
        this.DBArtworkPurchaseF308 = DBArtworkPurchaseF308;
        this.DBArtworkPurchaseF309 = DBArtworkPurchaseF309;
        this.DBArtworkPurchaseF310 = DBArtworkPurchaseF310;
        this.DBArtworkPurchaseF311 = DBArtworkPurchaseF311;
        this.DBArtworkPurchaseF312 = DBArtworkPurchaseF312;
        this.DBArtworkPurchaseF313 = DBArtworkPurchaseF313;
        this.DBArtworkPurchaseF314 = DBArtworkPurchaseF314;
        this.DBArtworkPurchaseF315 = DBArtworkPurchaseF315;
        this.DBArtworkPurchaseG101 = DBArtworkPurchaseG101;
        this.DBArtworkPurchaseG102 = DBArtworkPurchaseG102;
        this.DBArtworkPurchaseG103 = DBArtworkPurchaseG103;
        this.DBArtworkPurchaseG104 = DBArtworkPurchaseG104;
        this.DBArtworkPurchaseG105 = DBArtworkPurchaseG105;
        this.DBArtworkPurchaseG106 = DBArtworkPurchaseG106;
        this.DBArtworkPurchaseG107 = DBArtworkPurchaseG107;
        this.DBArtworkPurchaseG108 = DBArtworkPurchaseG108;
        this.DBArtworkPurchaseG109 = DBArtworkPurchaseG109;
        this.DBArtworkPurchaseG110 = DBArtworkPurchaseG110;
        this.DBArtworkPurchaseG111 = DBArtworkPurchaseG111;
        this.DBArtworkPurchaseG112 = DBArtworkPurchaseG112;
        this.DBArtworkPurchaseG113 = DBArtworkPurchaseG113;
        this.DBArtworkPurchaseG114 = DBArtworkPurchaseG114;
        this.DBArtworkPurchaseG115 = DBArtworkPurchaseG115;
        this.DBArtworkPurchaseG201 = DBArtworkPurchaseG201;
        this.DBArtworkPurchaseG202 = DBArtworkPurchaseG202;
        this.DBArtworkPurchaseG203 = DBArtworkPurchaseG203;
        this.DBArtworkPurchaseG204 = DBArtworkPurchaseG204;
        this.DBArtworkPurchaseG205 = DBArtworkPurchaseG205;
        this.DBArtworkPurchaseG206 = DBArtworkPurchaseG206;
        this.DBArtworkPurchaseG207 = DBArtworkPurchaseG207;
        this.DBArtworkPurchaseG208 = DBArtworkPurchaseG208;
        this.DBArtworkPurchaseG209 = DBArtworkPurchaseG209;
        this.DBArtworkPurchaseG210 = DBArtworkPurchaseG210;
        this.DBArtworkPurchaseG211 = DBArtworkPurchaseG211;
        this.DBArtworkPurchaseG212 = DBArtworkPurchaseG212;
        this.DBArtworkPurchaseG213 = DBArtworkPurchaseG213;
        this.DBArtworkPurchaseG214 = DBArtworkPurchaseG214;
        this.DBArtworkPurchaseG215 = DBArtworkPurchaseG215;
        this.DBArtworkPurchaseG301 = DBArtworkPurchaseG301;
        this.DBArtworkPurchaseG302 = DBArtworkPurchaseG302;
        this.DBArtworkPurchaseG303 = DBArtworkPurchaseG303;
        this.DBArtworkPurchaseG304 = DBArtworkPurchaseG304;
        this.DBArtworkPurchaseG305 = DBArtworkPurchaseG305;
        this.DBArtworkPurchaseG306 = DBArtworkPurchaseG306;
        this.DBArtworkPurchaseG307 = DBArtworkPurchaseG307;
        this.DBArtworkPurchaseG308 = DBArtworkPurchaseG308;
        this.DBArtworkPurchaseG309 = DBArtworkPurchaseG309;
        this.DBArtworkPurchaseG310 = DBArtworkPurchaseG310;
        this.DBArtworkPurchaseG311 = DBArtworkPurchaseG311;
        this.DBArtworkPurchaseG312 = DBArtworkPurchaseG312;
        this.DBArtworkPurchaseG313 = DBArtworkPurchaseG313;
        this.DBArtworkPurchaseG314 = DBArtworkPurchaseG314;
        this.DBArtworkPurchaseG315 = DBArtworkPurchaseG315;
        this.DBArtworkPurchaseFB01 = DBArtworkPurchaseFB01;
        this.DBArtworkPurchaseFB02 = DBArtworkPurchaseFB02;
        this.DBArtworkPurchaseFB03 = DBArtworkPurchaseFB03;
        this.DBArtworkPurchaseFB04 = DBArtworkPurchaseFB04;
        this.DBArtworkPurchaseFB05 = DBArtworkPurchaseFB05;
        this.DBArtworkPurchaseFB06 = DBArtworkPurchaseFB06;
        this.DBArtworkPurchaseFB07 = DBArtworkPurchaseFB07;
        this.DBArtworkPurchaseFB08 = DBArtworkPurchaseFB08;
        this.DBArtworkPurchaseFB09 = DBArtworkPurchaseFB09;
        this.DBArtworkPurchaseFB10 = DBArtworkPurchaseFB10;
        this.DBArtworkPurchaseFB11 = DBArtworkPurchaseFB11;
        this.DBArtworkPurchaseFB12 = DBArtworkPurchaseFB12;
        this.DBArtworkPurchaseFB13 = DBArtworkPurchaseFB13;
        this.DBArtworkPurchaseFB14 = DBArtworkPurchaseFB14;
        this.DBArtworkPurchaseFB15 = DBArtworkPurchaseFB15;
        this.DBBonusArtworkObtain01 = DBBonusArtworkObtain01;
        this.DBBonusArtworkObtain02 = DBBonusArtworkObtain02;
        this.DBBonusArtworkObtain03 = DBBonusArtworkObtain03;
        this.DBBonusArtworkObtain04 = DBBonusArtworkObtain04;
        this.DBBonusArtworkObtain05 = DBBonusArtworkObtain05;
        this.DBBonusArtworkObtain06 = DBBonusArtworkObtain06;
        this.DBBonusArtworkObtain07 = DBBonusArtworkObtain07;
        this.DBBonusArtworkObtain08 = DBBonusArtworkObtain08;
        this.DBBonusArtworkObtain09 = DBBonusArtworkObtain09;
        this.DBBonusArtworkObtain10 = DBBonusArtworkObtain10;
        this.DBArtworkPurchaseF101Added = DBArtworkPurchaseF101Added;
        this.DBArtworkPurchaseF102Added = DBArtworkPurchaseF102Added;
        this.DBArtworkPurchaseF103Added = DBArtworkPurchaseF103Added;
        this.DBArtworkPurchaseF104Added = DBArtworkPurchaseF104Added;
        this.DBArtworkPurchaseF105Added = DBArtworkPurchaseF105Added;
        this.DBArtworkPurchaseF106Added = DBArtworkPurchaseF106Added;
        this.DBArtworkPurchaseF107Added = DBArtworkPurchaseF107Added;
        this.DBArtworkPurchaseF108Added = DBArtworkPurchaseF108Added;
        this.DBArtworkPurchaseF201Added = DBArtworkPurchaseF201Added;
        this.DBArtworkPurchaseF202Added = DBArtworkPurchaseF202Added;
        this.DBArtworkPurchaseF203Added = DBArtworkPurchaseF203Added;
        this.DBArtworkPurchaseF204Added = DBArtworkPurchaseF204Added;
        this.DBArtworkPurchaseF205Added = DBArtworkPurchaseF205Added;
        this.DBArtworkPurchaseF206Added = DBArtworkPurchaseF206Added;
        this.DBArtworkPurchaseF207Added = DBArtworkPurchaseF207Added;
        this.DBArtworkPurchaseF208Added = DBArtworkPurchaseF208Added;
        this.DBArtworkPurchaseF301Added = DBArtworkPurchaseF301Added;
        this.DBArtworkPurchaseF302Added = DBArtworkPurchaseF302Added;
        this.DBArtworkPurchaseF303Added = DBArtworkPurchaseF303Added;
        this.DBArtworkPurchaseF304Added = DBArtworkPurchaseF304Added;
        this.DBArtworkPurchaseF305Added = DBArtworkPurchaseF305Added;
        this.DBArtworkPurchaseF306Added = DBArtworkPurchaseF306Added;
        this.DBArtworkPurchaseF307Added = DBArtworkPurchaseF307Added;
        this.DBArtworkPurchaseF308Added = DBArtworkPurchaseF308Added;
        this.DBArtworkPurchaseG101Added = DBArtworkPurchaseG101Added;
        this.DBArtworkPurchaseG102Added = DBArtworkPurchaseG102Added;
        this.DBArtworkPurchaseG103Added = DBArtworkPurchaseG103Added;
        this.DBArtworkPurchaseG104Added = DBArtworkPurchaseG104Added;
        this.DBArtworkPurchaseG105Added = DBArtworkPurchaseG105Added;
        this.DBArtworkPurchaseG106Added = DBArtworkPurchaseG106Added;
        this.DBArtworkPurchaseG107Added = DBArtworkPurchaseG107Added;
        this.DBArtworkPurchaseG108Added = DBArtworkPurchaseG108Added;
        this.DBArtworkPurchaseG201Added = DBArtworkPurchaseG201Added;
        this.DBArtworkPurchaseG202Added = DBArtworkPurchaseG202Added;
        this.DBArtworkPurchaseG203Added = DBArtworkPurchaseG203Added;
        this.DBArtworkPurchaseG204Added = DBArtworkPurchaseG204Added;
        this.DBArtworkPurchaseG205Added = DBArtworkPurchaseG205Added;
        this.DBArtworkPurchaseG206Added = DBArtworkPurchaseG206Added;
        this.DBArtworkPurchaseG207Added = DBArtworkPurchaseG207Added;
        this.DBArtworkPurchaseG208Added = DBArtworkPurchaseG208Added;
        this.DBArtworkPurchaseG301Added = DBArtworkPurchaseG301Added;
        this.DBArtworkPurchaseG302Added = DBArtworkPurchaseG302Added;
        this.DBArtworkPurchaseG303Added = DBArtworkPurchaseG303Added;
        this.DBArtworkPurchaseG304Added = DBArtworkPurchaseG304Added;
        this.DBArtworkPurchaseG305Added = DBArtworkPurchaseG305Added;
        this.DBArtworkPurchaseG306Added = DBArtworkPurchaseG306Added;
        this.DBArtworkPurchaseG307Added = DBArtworkPurchaseG307Added;
        this.DBArtworkPurchaseG308Added = DBArtworkPurchaseG308Added;
        this.DBArtworkPurchaseFB01Added = DBArtworkPurchaseFB01Added;
        this.DBArtworkPurchaseFB02Added = DBArtworkPurchaseFB02Added;
        this.DBArtworkPurchaseFB03Added = DBArtworkPurchaseFB03Added;
        this.DBArtworkPurchaseFB04Added = DBArtworkPurchaseFB04Added;
        this.DBArtworkPurchaseFB05Added = DBArtworkPurchaseFB05Added;
        this.DBArtworkPurchaseFB06Added = DBArtworkPurchaseFB06Added;
        this.DBArtworkPurchaseFB07Added = DBArtworkPurchaseFB07Added;
        this.DBArtworkPurchaseFB08Added = DBArtworkPurchaseFB08Added;
        this.DBArtworkPurchaseFB09Added = DBArtworkPurchaseFB09Added;
        this.DBArtworkPurchaseFB10Added = DBArtworkPurchaseFB10Added;
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