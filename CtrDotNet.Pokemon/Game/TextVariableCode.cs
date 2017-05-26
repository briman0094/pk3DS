﻿namespace CtrDotNet.Pokemon.Game
{
    public class TextVariableCode
    {
        public readonly int Code;
        public readonly string Name;
        private TextVariableCode(int code, string name)
        {
            this.Code = code;
            this.Name = name;
        }

        public static readonly TextVariableCode[] VariableCodesXy =
        {
            new TextVariableCode(0xFF00, "COLOR"),
            new TextVariableCode(0x0100, "TRNAME"),
            new TextVariableCode(0x0101, "PKNAME"),
            new TextVariableCode(0x0102, "PKNICK"),
            new TextVariableCode(0x0103, "TYPE"),
            new TextVariableCode(0x0105, "LOCATION"),
            new TextVariableCode(0x0106, "ABILITY"),
            new TextVariableCode(0x0107, "MOVE"),
            new TextVariableCode(0x0108, "ITEM1"),
            new TextVariableCode(0x0109, "ITEM2"),
            new TextVariableCode(0x010A, "sTRBAG"),
            new TextVariableCode(0x010B, "BOX"),
            new TextVariableCode(0x010D, "EVSTAT"),
            new TextVariableCode(0x0110, "OPOWER"),
            new TextVariableCode(0x0127, "RIBBON"),
            new TextVariableCode(0x0134, "MIINAME"),
            new TextVariableCode(0x013E, "WEATHER"),
            new TextVariableCode(0x0189, "TRNICK"),
            new TextVariableCode(0x018A, "1stchrTR"),
            new TextVariableCode(0x018B, "SHOUTOUT"),
            new TextVariableCode(0x018E, "BERRY"),
            new TextVariableCode(0x018F, "REMFEEL"),
            new TextVariableCode(0x0190, "REMQUAL"),
            new TextVariableCode(0x0191, "WEBSITE"),
            new TextVariableCode(0x019C, "CHOICECOS"),
            new TextVariableCode(0x01A1, "GSYNCID"),
            new TextVariableCode(0x0192, "PRVIDSAY"),
            new TextVariableCode(0x0193, "BTLTEST"),
            new TextVariableCode(0x0195, "GENLOC"),
            new TextVariableCode(0x0199, "CHOICEFOOD"),
            new TextVariableCode(0x019A, "HOTELITEM"),
            new TextVariableCode(0x019B, "TAXISTOP"),
            new TextVariableCode(0x019F, "MAISTITLE"),
            new TextVariableCode(0x1000, "ITEMPLUR0"),
            new TextVariableCode(0x1001, "ITEMPLUR1"),
            new TextVariableCode(0x1100, "GENDBR"),
            new TextVariableCode(0x1101, "NUMBRNCH"),
            new TextVariableCode(0x1302, "iCOLOR2"),
            new TextVariableCode(0x1303, "iCOLOR3"),
            new TextVariableCode(0x0200, "NUM1"),
            new TextVariableCode(0x0201, "NUM2"),
            new TextVariableCode(0x0202, "NUM3"),
            new TextVariableCode(0x0203, "NUM4"),
            new TextVariableCode(0x0204, "NUM5"),
            new TextVariableCode(0x0205, "NUM6"),
            new TextVariableCode(0x0206, "NUM7"),
            new TextVariableCode(0x0207, "NUM8"),
            new TextVariableCode(0x0208, "NUM9"),
        };
        public static readonly TextVariableCode[] VariableCodesAo =
        {
            new TextVariableCode(0xFF00, "COLOR"),
            new TextVariableCode(0x0100, "TRNAME"),
            new TextVariableCode(0x0101, "PKNAME"),
            new TextVariableCode(0x0102, "PKNICK"),
            new TextVariableCode(0x0103, "TYPE"),
            new TextVariableCode(0x0105, "LOCATION"),
            new TextVariableCode(0x0106, "ABILITY"),
            new TextVariableCode(0x0107, "MOVE"),
            new TextVariableCode(0x0108, "ITEM1"),
            new TextVariableCode(0x0109, "ITEM2"),
            new TextVariableCode(0x010A, "sTRBAG"),
            new TextVariableCode(0x010B, "BOX"),
            new TextVariableCode(0x010D, "EVSTAT"),
            new TextVariableCode(0x0110, "OPOWER"),
            new TextVariableCode(0x0127, "RIBBON"),
            new TextVariableCode(0x0134, "MIINAME"),
            new TextVariableCode(0x013E, "WEATHER"),
            new TextVariableCode(0x0189, "TRNICK"),
            new TextVariableCode(0x018A, "1stchrTR"),
            new TextVariableCode(0x018B, "SHOUTOUT"),
            new TextVariableCode(0x018E, "BERRY"),
            new TextVariableCode(0x018F, "REMFEEL"),
            new TextVariableCode(0x0190, "REMQUAL"),
            new TextVariableCode(0x0191, "WEBSITE"),
            new TextVariableCode(0x019C, "CHOICECOS"),
            new TextVariableCode(0x01A1, "GSYNCID"),
            new TextVariableCode(0x0192, "PRVIDSAY"),
            new TextVariableCode(0x0193, "BTLTEST"),
            new TextVariableCode(0x0195, "GENLOC"),
            new TextVariableCode(0x0199, "CHOICEFOOD"),
            new TextVariableCode(0x019A, "HOTELITEM"),
            new TextVariableCode(0x019B, "TAXISTOP"),
            new TextVariableCode(0x019F, "MAISTITLE"),
            new TextVariableCode(0x1000, "ITEMPLUR0"),
            new TextVariableCode(0x1001, "ITEMPLUR1"),
            new TextVariableCode(0x1100, "GENDBR"),
            new TextVariableCode(0x1101, "NUMBRNCH"),
            new TextVariableCode(0x1302, "iCOLOR2"),
            new TextVariableCode(0x1303, "iCOLOR3"),
            new TextVariableCode(0x0200, "NUM1"),
            new TextVariableCode(0x0201, "NUM2"),
            new TextVariableCode(0x0202, "NUM3"),
            new TextVariableCode(0x0203, "NUM4"),
            new TextVariableCode(0x0204, "NUM5"),
            new TextVariableCode(0x0205, "NUM6"),
            new TextVariableCode(0x0206, "NUM7"),
            new TextVariableCode(0x0207, "NUM8"),
            new TextVariableCode(0x0208, "NUM9"),
        };
        public static readonly TextVariableCode[] VariableCodesSm =
        {
            new TextVariableCode(0xFF00, "COLOR"),
            new TextVariableCode(0x0100, "TRNAME"),
            new TextVariableCode(0x0101, "PKNAME"),
            new TextVariableCode(0x0102, "PKNICK"),
            new TextVariableCode(0x0103, "TYPE"),
            new TextVariableCode(0x0105, "LOCATION"),
            new TextVariableCode(0x0106, "ABILITY"),
            new TextVariableCode(0x0107, "MOVE"),
            new TextVariableCode(0x0108, "ITEM1"),
            new TextVariableCode(0x0109, "ITEM2"),
            new TextVariableCode(0x010A, "sTRBAG"),
            new TextVariableCode(0x010B, "BOX"),
            new TextVariableCode(0x010D, "EVSTAT"),
            new TextVariableCode(0x0110, "OPOWER"),
            new TextVariableCode(0x0127, "RIBBON"),
            new TextVariableCode(0x0134, "MIINAME"),
            new TextVariableCode(0x013E, "WEATHER"),
            new TextVariableCode(0x0189, "TRNICK"),
            new TextVariableCode(0x018A, "1stchrTR"),
            new TextVariableCode(0x018B, "SHOUTOUT"),
            new TextVariableCode(0x018E, "BERRY"),
            new TextVariableCode(0x018F, "REMFEEL"),
            new TextVariableCode(0x0190, "REMQUAL"),
            new TextVariableCode(0x0191, "WEBSITE"),
            new TextVariableCode(0x019C, "CHOICECOS"),
            new TextVariableCode(0x01A1, "GSYNCID"),
            new TextVariableCode(0x0192, "PRVIDSAY"),
            new TextVariableCode(0x0193, "BTLTEST"),
            new TextVariableCode(0x0195, "GENLOC"),
            new TextVariableCode(0x0199, "CHOICEFOOD"),
            new TextVariableCode(0x019A, "HOTELITEM"),
            new TextVariableCode(0x019B, "TAXISTOP"),
            new TextVariableCode(0x019F, "MAISTITLE"),
            new TextVariableCode(0x1000, "ITEMPLUR0"),
            new TextVariableCode(0x1001, "ITEMPLUR1"),
            new TextVariableCode(0x1100, "GENDBR"),
            new TextVariableCode(0x1101, "NUMBRNCH"),
            new TextVariableCode(0x1302, "iCOLOR2"),
            new TextVariableCode(0x1303, "iCOLOR3"),
            new TextVariableCode(0x0200, "NUM1"),
            new TextVariableCode(0x0201, "NUM2"),
            new TextVariableCode(0x0202, "NUM3"),
            new TextVariableCode(0x0203, "NUM4"),
            new TextVariableCode(0x0204, "NUM5"),
            new TextVariableCode(0x0205, "NUM6"),
            new TextVariableCode(0x0206, "NUM7"),
            new TextVariableCode(0x0207, "NUM8"),
            new TextVariableCode(0x0208, "NUM9"),
        };
    }
}
