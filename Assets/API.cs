using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct CFrame {
    public int x;
    public int y;
    public int z;
    public int rx;
    public int ry;
    public int rz;
}


public class SpawnLocation : MonoBehaviour {
	private CFrame CFrame;
}

public class Part : MonoBehaviour
{
    private int cr;
    private int cg;
    private int cb;
	private CFrame CFrame;
	

	//credit: EGAMatsu/Digital Space Productions
	void calculateBrickColor(int value)
	{
		switch (value)
		{
			case (1):
				cr = 242;
				cg = 243;
				cb = 243;
				break;
			case (2):
				cr = 161;
				cg = 165;
				cb = 162;
				break;
			case (3):
				cr = 249;
				cg = 233;
				cb = 153;
				break;
			case (5):
				cr = 215;
				cg = 197;
				cb = 154;
				break;
			case (6):
				cr = 194;
				cg = 218;
				cb = 184;
				break;
			case (9):
				cr = 232;
				cg = 186;
				cb = 200;
				break;
			case (11):
				cr = 128;
				cg = 187;
				cb = 219;
				break;
			case (12):
				cr = 203;
				cg = 132;
				cb = 66;
				break;
			case (18):
				cr = 204;
				cg = 142;
				cb = 105;
				break;
			case (21):
				cr = 196;
				cg = 40;
				cb = 28;
				break;
			case (22):
				cr = 196;
				cg = 112;
				cb = 160;
				break;
			case (23):
				cr = 13;
				cg = 105;
				cb = 172;
				break;
			case (24):
				cr = 245;
				cg = 205;
				cb = 48;
				break;
			case (25):
				cr = 98;
				cg = 71;
				cb = 50;
				break;
			case (26):
				cr = 27;
				cg = 42;
				cb = 53;
				break;
			case (27):
				cr = 109;
				cg = 110;
				cb = 108;
				break;
			case (28):
				cr = 40;
				cg = 127;
				cb = 71;
				break;
			case (29):
				cr = 161;
				cg = 196;
				cb = 140;
				break;
			case (36):
				cr = 243;
				cg = 207;
				cb = 155;
				break;
			case (37):
				cr = 75;
				cg = 151;
				cb = 75;
				break;
			case (38):
				cr = 160;
				cg = 95;
				cb = 53;
				break;
			case (39):
				cr = 193;
				cg = 202;
				cb = 222;
				break;
			case (40):
				cr = 236;
				cg = 236;
				cb = 236;
				break;
			case (41):
				cr = 205;
				cg = 84;
				cb = 75;
				break;
			case (42):
				cr = 193;
				cg = 223;
				cb = 240;
				break;
			case (43):
				cr = 123;
				cg = 182;
				cb = 232;
				break;
			case (44):
				cr = 247;
				cg = 241;
				cb = 141;
				break;
			case (45):
				cr = 180;
				cg = 210;
				cb = 228;
				break;
			case (47):
				cr = 217;
				cg = 133;
				cb = 108;
				break;
			case (48):
				cr = 132;
				cg = 182;
				cb = 141;
				break;
			case (49):
				cr = 248;
				cg = 241;
				cb = 132;
				break;
			case (50):
				cr = 236;
				cg = 232;
				cb = 222;
				break;
			case (100):
				cr = 238;
				cg = 196;
				cb = 182;
				break;
			case (101):
				cr = 218;
				cg = 134;
				cb = 122;
				break;
			case (102):
				cr = 110;
				cg = 153;
				cb = 202;
				break;
			case (103):
				cr = 199;
				cg = 193;
				cb = 183;
				break;
			case (104):
				cr = 107;
				cg = 50;
				cb = 124;
				break;
			case (105):
				cr = 226;
				cg = 155;
				cb = 64;
				break;
			case (106):
				cr = 218;
				cg = 133;
				cb = 65;
				break;
			case (107):
				cr = 0;
				cg = 143;
				cb = 156;
				break;
			case (108):
				cr = 104;
				cg = 92;
				cb = 67;
				break;
			case (110):
				cr = 67;
				cg = 84;
				cb = 147;
				break;
			case (111):
				cr = 191;
				cg = 183;
				cb = 177;
				break;
			case (112):
				cr = 104;
				cg = 116;
				cb = 172;
				break;
			case (113):
				cr = 228;
				cg = 173;
				cb = 200;
				break;
			case (115):
				cr = 199;
				cg = 210;
				cb = 60;
				break;
			case (116):
				cr = 85;
				cg = 165;
				cb = 175;
				break;
			case (118):
				cr = 183;
				cg = 215;
				cb = 213;
				break;
			case (119):
				cr = 164;
				cg = 189;
				cb = 71;
				break;
			case (120):
				cr = 217;
				cg = 228;
				cb = 167;
				break;
			case (121):
				cr = 231;
				cg = 172;
				cb = 88;
				break;
			case (123):
				cr = 211;
				cg = 111;
				cb = 76;
				break;
			case (124):
				cr = 146;
				cg = 57;
				cb = 120;
				break;
			case (125):
				cr = 234;
				cg = 184;
				cb = 146;
				break;
			case (126):
				cr = 165;
				cg = 165;
				cb = 203;
				break;
			case (127):
				cr = 220;
				cg = 188;
				cb = 129;
				break;
			case (128):
				cr = 174;
				cg = 122;
				cb = 89;
				break;
			case (131):
				cr = 156;
				cg = 163;
				cb = 168;
				break;
			case (133):
				cr = 213;
				cg = 115;
				cb = 61;
				break;
			case (134):
				cr = 216;
				cg = 221;
				cb = 86;
				break;
			case (135):
				cr = 116;
				cg = 134;
				cb = 157;
				break;
			case (136):
				cr = 135;
				cg = 124;
				cb = 144;
				break;
			case (137):
				cr = 224;
				cg = 152;
				cb = 100;
				break;
			case (138):
				cr = 149;
				cg = 138;
				cb = 115;
				break;
			case (140):
				cr = 32;
				cg = 58;
				cb = 86;
				break;
			case (141):
				cr = 39;
				cg = 70;
				cb = 45;
				break;
			case (143):
				cr = 207;
				cg = 226;
				cb = 247;
				break;
			case (145):
				cr = 121;
				cg = 136;
				cb = 161;
				break;
			case (146):
				cr = 149;
				cg = 142;
				cb = 163;
				break;
			case (147):
				cr = 147;
				cg = 135;
				cb = 103;
				break;
			case (148):
				cr = 87;
				cg = 88;
				cb = 87;
				break;
			case (149):
				cr = 22;
				cg = 29;
				cb = 50;
				break;
			case (150):
				cr = 171;
				cg = 173;
				cb = 172;
				break;
			case (151):
				cr = 120;
				cg = 144;
				cb = 130;
				break;
			case (153):
				cr = 149;
				cg = 121;
				cb = 119;
				break;
			case (154):
				cr = 123;
				cg = 46;
				cb = 47;
				break;
			case (157):
				cr = 255;
				cg = 246;
				cb = 123;
				break;
			case (158):
				cr = 225;
				cg = 164;
				cb = 194;
				break;
			case (168):
				cr = 117;
				cg = 108;
				cb = 98;
				break;
			case (176):
				cr = 151;
				cg = 105;
				cb = 91;
				break;
			case (178):
				cr = 180;
				cg = 132;
				cb = 85;
				break;
			case (179):
				cr = 137;
				cg = 135;
				cb = 136;
				break;
			case (180):
				cr = 215;
				cg = 169;
				cb = 75;
				break;
			case (190):
				cr = 249;
				cg = 214;
				cb = 46;
				break;
			case (191):
				cr = 232;
				cg = 171;
				cb = 45;
				break;
			case (192):
				cr = 105;
				cg = 64;
				cb = 40;
				break;
			case (193):
				cr = 207;
				cg = 96;
				cb = 36;
				break;
			case (194):
				cr = 163;
				cg = 162;
				cb = 165;
				break;
			case (195):
				cr = 70;
				cg = 103;
				cb = 164;
				break;
			case (196):
				cr = 35;
				cg = 71;
				cb = 139;
				break;
			case (198):
				cr = 142;
				cg = 66;
				cb = 133;
				break;
			case (199):
				cr = 99;
				cg = 95;
				cb = 98;
				break;
			case (200):
				cr = 130;
				cg = 138;
				cb = 93;
				break;
			case (208):
				cr = 229;
				cg = 228;
				cb = 223;
				break;
			case (209):
				cr = 176;
				cg = 142;
				cb = 68;
				break;
			case (210):
				cr = 112;
				cg = 149;
				cb = 120;
				break;
			case (211):
				cr = 121;
				cg = 181;
				cb = 181;
				break;
			case (212):
				cr = 159;
				cg = 195;
				cb = 233;
				break;
			case (213):
				cr = 108;
				cg = 129;
				cb = 183;
				break;
			case (216):
				cr = 143;
				cg = 76;
				cb = 42;
				break;
			case (217):
				cr = 124;
				cg = 92;
				cb = 70;
				break;
			case (218):
				cr = 150;
				cg = 112;
				cb = 159;
				break;
			case (219):
				cr = 107;
				cg = 98;
				cb = 155;
				break;
			case (220):
				cr = 167;
				cg = 169;
				cb = 206;
				break;
			case (221):
				cr = 205;
				cg = 98;
				cb = 152;
				break;
			case (222):
				cr = 228;
				cg = 173;
				cb = 200;
				break;
			case (223):
				cr = 220;
				cg = 144;
				cb = 149;
				break;
			case (224):
				cr = 240;
				cg = 213;
				cb = 160;
				break;
			case (225):
				cr = 235;
				cg = 184;
				cb = 127;
				break;
			case (226):
				cr = 253;
				cg = 234;
				cb = 141;
				break;
			case (232):
				cr = 125;
				cg = 187;
				cb = 221;
				break;
			case (268):
				cr = 52;
				cg = 43;
				cb = 117;
				break;
			case (301):
				cr = 80;
				cg = 109;
				cb = 84;
				break;
			case (302):
				cr = 91;
				cg = 93;
				cb = 105;
				break;
			case (303):
				cr = 0;
				cg = 16;
				cb = 176;
				break;
			case (304):
				cr = 44;
				cg = 101;
				cb = 29;
				break;
			case (305):
				cr = 82;
				cg = 124;
				cb = 174;
				break;
			case (306):
				cr = 51;
				cg = 88;
				cb = 130;
				break;
			case (307):
				cr = 16;
				cg = 42;
				cb = 220;
				break;
			case (308):
				cr = 61;
				cg = 21;
				cb = 133;
				break;
			case (309):
				cr = 52;
				cg = 142;
				cb = 64;
				break;
			case (310):
				cr = 91;
				cg = 154;
				cb = 76;
				break;
			case (311):
				cr = 159;
				cg = 161;
				cb = 172;
				break;
			case (312):
				cr = 89;
				cg = 34;
				cb = 89;
				break;
			case (313):
				cr = 31;
				cg = 128;
				cb = 29;
				break;
			case (314):
				cr = 159;
				cg = 173;
				cb = 192;
				break;
			case (315):
				cr = 9;
				cg = 137;
				cb = 207;
				break;
			case (316):
				cr = 123;
				cg = 0;
				cb = 123;
				break;
			case (317):
				cr = 124;
				cg = 156;
				cb = 107;
				break;
			case (318):
				cr = 138;
				cg = 171;
				cb = 133;
				break;
			case (319):
				cr = 185;
				cg = 196;
				cb = 177;
				break;
			case (320):
				cr = 202;
				cg = 203;
				cb = 209;
				break;
			case (321):
				cr = 167;
				cg = 94;
				cb = 155;
				break;
			case (322):
				cr = 123;
				cg = 47;
				cb = 123;
				break;
			case (323):
				cr = 148;
				cg = 190;
				cb = 129;
				break;
			case (324):
				cr = 168;
				cg = 189;
				cb = 153;
				break;
			case (325):
				cr = 223;
				cg = 223;
				cb = 222;
				break;
			case (326):
				cr = 218;
				cg = 220;
				cb = 225;
				break;
			case (327):
				cr = 151;
				cg = 0;
				cb = 0;
				break;
			case (328):
				cr = 177;
				cg = 229;
				cb = 166;
				break;
			case (329):
				cr = 152;
				cg = 194;
				cb = 219;
				break;
			case (330):
				cr = 255;
				cg = 152;
				cb = 220;
				break;
			case (331):
				cr = 255;
				cg = 89;
				cb = 89;
				break;
			case (332):
				cr = 117;
				cg = 0;
				cb = 0;
				break;
			case (333):
				cr = 239;
				cg = 184;
				cb = 56;
				break;
			case (334):
				cr = 248;
				cg = 217;
				cb = 109;
				break;
			case (335):
				cr = 231;
				cg = 231;
				cb = 236;
				break;
			case (336):
				cr = 199;
				cg = 212;
				cb = 228;
				break;
			case (337):
				cr = 255;
				cg = 148;
				cb = 148;
				break;
			case (338):
				cr = 190;
				cg = 104;
				cb = 98;
				break;
			case (339):
				cr = 86;
				cg = 36;
				cb = 36;
				break;
			case (340):
				cr = 241;
				cg = 231;
				cb = 199;
				break;
			case (341):
				cr = 254;
				cg = 243;
				cb = 187;
				break;
			case (342):
				cr = 224;
				cg = 178;
				cb = 208;
				break;
			case (343):
				cr = 212;
				cg = 144;
				cb = 189;
				break;
			case (344):
				cr = 150;
				cg = 85;
				cb = 85;
				break;
			case (345):
				cr = 143;
				cg = 76;
				cb = 42;
				break;
			case (346):
				cr = 211;
				cg = 190;
				cb = 150;
				break;
			case (347):
				cr = 226;
				cg = 220;
				cb = 188;
				break;
			case (348):
				cr = 237;
				cg = 234;
				cb = 234;
				break;
			case (349):
				cr = 233;
				cg = 218;
				cb = 218;
				break;
			case (350):
				cr = 136;
				cg = 62;
				cb = 62;
				break;
			case (351):
				cr = 188;
				cg = 155;
				cb = 93;
				break;
			case (352):
				cr = 199;
				cg = 172;
				cb = 120;
				break;
			case (353):
				cr = 202;
				cg = 191;
				cb = 163;
				break;
			case (354):
				cr = 187;
				cg = 179;
				cb = 178;
				break;
			case (355):
				cr = 108;
				cg = 88;
				cb = 75;
				break;
			case (356):
				cr = 160;
				cg = 132;
				cb = 79;
				break;
			case (357):
				cr = 149;
				cg = 137;
				cb = 136;
				break;
			case (358):
				cr = 171;
				cg = 168;
				cb = 158;
				break;
			case (359):
				cr = 175;
				cg = 148;
				cb = 131;
				break;
			case (360):
				cr = 150;
				cg = 103;
				cb = 102;
				break;
			case (361):
				cr = 86;
				cg = 66;
				cb = 54;
				break;
			case (362):
				cr = 126;
				cg = 104;
				cb = 63;
				break;
			case (363):
				cr = 105;
				cg = 102;
				cb = 92;
				break;
			case (364):
				cr = 90;
				cg = 76;
				cb = 66;
				break;
			case (365):
				cr = 106;
				cg = 57;
				cb = 9;
				break;
			case (1001):
				cr = 248;
				cg = 248;
				cb = 248;
				break;
			case (1002):
				cr = 205;
				cg = 205;
				cb = 205;
				break;
			case (1003):
				cr = 17;
				cg = 17;
				cb = 17;
				break;
			case (1004):
				cr = 255;
				cg = 0;
				cb = 0;
				break;
			case (1005):
				cr = 255;
				cg = 175;
				cb = 0;
				break;
			case (1006):
				cr = 180;
				cg = 128;
				cb = 255;
				break;
			case (1007):
				cr = 163;
				cg = 75;
				cb = 75;
				break;
			case (1008):
				cr = 193;
				cg = 190;
				cb = 66;
				break;
			case (1009):
				cr = 255;
				cg = 255;
				cb = 0;
				break;
			case (1010):
				cr = 0;
				cg = 0;
				cb = 255;
				break;
			case (1011):
				cr = 0;
				cg = 32;
				cb = 96;
				break;
			case (1012):
				cr = 33;
				cg = 84;
				cb = 185;
				break;
			case (1013):
				cr = 4;
				cg = 175;
				cb = 236;
				break;
			case (1014):
				cr = 170;
				cg = 85;
				cb = 0;
				break;
			case (1015):
				cr = 170;
				cg = 0;
				cb = 170;
				break;
			case (1016):
				cr = 255;
				cg = 102;
				cb = 204;
				break;
			case (1017):
				cr = 255;
				cg = 175;
				cb = 0;
				break;
			case (1018):
				cr = 18;
				cg = 238;
				cb = 212;
				break;
			case (1019):
				cr = 0;
				cg = 255;
				cb = 255;
				break;
			case (1020):
				cr = 0;
				cg = 255;
				cb = 0;
				break;
			case (1021):
				cr = 58;
				cg = 125;
				cb = 21;
				break;
			case (1022):
				cr = 127;
				cg = 142;
				cb = 100;
				break;
			case (1023):
				cr = 140;
				cg = 91;
				cb = 159;
				break;
			case (1024):
				cr = 175;
				cg = 221;
				cb = 255;
				break;
			case (1025):
				cr = 255;
				cg = 201;
				cb = 201;
				break;
			case (1026):
				cr = 177;
				cg = 167;
				cb = 255;
				break;
			case (1027):
				cr = 159;
				cg = 243;
				cb = 233;
				break;
			case (1028):
				cr = 204;
				cg = 255;
				cb = 204;
				break;
			case (1029):
				cr = 255;
				cg = 255;
				cb = 204;
				break;
			case (1030):
				cr = 255;
				cg = 204;
				cb = 153;
				break;
			case (1031):
				cr = 98;
				cg = 37;
				cb = 209;
				break;
			case (1032):
				cr = 255;
				cg = 0;
				cb = 191;
				break;
		}
	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
