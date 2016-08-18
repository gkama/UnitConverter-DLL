using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class UnitConverter
    {
        #region Convert Time
        public double ConvertTime(string Case, double Time)
        {
            //If '0' is returned, it's parsed incorrectly
            if (double.TryParse(Time.ToString(), out Time))
            {
                switch (Case)
                {
                    //Seconds
                    case "SecondsSeconds":
                        return Time * 1;
                    case "SecondsMinutes":
                        return Time / 60;
                    case "SecondsHours":
                        return Time / (60 * 60);
                    case "SecondsDays":
                        return Time / (60 * 60 * 24);
                    case "SecondsWeeks":
                        return Time / (60 * 60 * 24 * 7);
                    case "SecondsMonths":
                        return Time / (60 * 60 * 24 * 30);
                    case "SecondsYears":
                        return Time / (60 * 60 * 24 * 365);

                    //Minutes
                    case "MinutesSeconds":
                        return Time * 60;
                    case "MinutesMinutes":
                        return Time * 1;
                    case "MinutesHours":
                        return Time / 60;
                    case "MinutesDays":
                        return Time / (60 * 24);
                    case "MinutesWeeks":
                        return Time / (60 * 24 * 7);
                    case "MinutesMonths":
                        return Time / (60 * 24 * 30);
                    case "MinutesYears":
                        return Time / (60 * 24 * 365);

                    //Hours
                    case "HoursSeconds":
                        return Time * (60 * 60);
                    case "HoursMinutes":
                        return Time * 60;
                    case "HoursHours":
                        return Time * 1;
                    case "HoursDays":
                        return Time / 24;
                    case "HoursWeeks":
                        return Time / (24 * 7);
                    case "HoursMonths":
                        return Time / (24 * 30);
                    case "HoursYears":
                        return Time / (24 * 365);

                    //Days
                    case "DaysSeconds":
                        return Time * (60 * 60 * 24);
                    case "DaysMinutes":
                        return Time * (60 * 24);
                    case "DaysHours":
                        return Time * 24;
                    case "DaysDays":
                        return Time * 1;
                    case "DaysWeeks":
                        return Time / 7;
                    case "DaysMonths":
                        return Time / 30;
                    case "DaysYears":
                        return Time / 365;

                    //Weeks
                    case "WeeksSeconds":
                        return Time * (60 * 60 * 24 * 7);
                    case "WeeksMinutes":
                        return Time * (60 * 24 * 7);
                    case "WeeksHours":
                        return Time * (24 * 7);
                    case "WeeksDays":
                        return Time * 7;
                    case "WeeksWeeks":
                        return Time * 1;
                    case "WeeksMonths":
                        return Time / (30 / 7);
                    case "WeeksYears":
                        return Time / 52;

                    //Months
                    case "MonthsSeconds":
                        return Time * (60 * 60 * 24 * 30);
                    case "MonthsMinutes":
                        return Time * (60 * 24 * 30);
                    case "MonthsHours":
                        return Time * (24 * 30);
                    case "MonthsDays":
                        return Time * 30;
                    case "MonthsWeeks":
                        return Time * (30 / 7);
                    case "MonthsMonths":
                        return Time * 1;
                    case "MonthsYears":
                        return Time / 12;

                    //Years
                    case "YearsSeconds":
                        return Time * (60 * 60 * 24 * 365);
                    case "YearsMinutes":
                        return Time * (60 * 24 * 365);
                    case "YearsHours":
                        return Time * (24 * 365);
                    case "YearsDays":
                        return Time * 365;
                    case "YearsWeeks":
                        return Time * 52;
                    case "YearsMonths":
                        return Time * 12;
                    case "YearsYears":
                        return Time * 1;

                    default:
                        return 0;
                }
            }
            else
                return 0;
        }
        //List of Time Items
        private List<string> _valuesListTime = new List<string>() { "Seconds", "Minutes", "Hours", "Days", "Weeks", "Months", "Years" };
        public List<string> ValuesListTime
        {
            get { return _valuesListTime; }
        }

        #endregion

        #region Convert Decimal Number
        public string ConvertDecimalNumber(string Case, int Number)
        {
            //If "" is returned, it's parsed incorrectly
            if (Int32.TryParse(Number.ToString(), out Number))
            {
                switch (Case)
                {
                    //Decimal
                    case "DecimalDecimal":
                        return Number.ToString();
                    case "DecimalBinary":
                        return Convert.ToString(Number, 2);
                    case "DecimalHexadecimal":
                        return int.Parse(Number.ToString("X"), System.Globalization.NumberStyles.HexNumber).ToString();
                    case "DecimalOctal":
                        return Convert.ToString(Number, 8);

                    default:
                        return "";
                }
            }
            else
                return "";
        }
        //List of Decimal Number Items
        private List<string> _valuesListDecimalNumber = new List<string>() { "Decimal", "Binary", "Hexadecimal", "Octal" };
        public List<string> ValuesListDecimalNumber
        {
            get { return _valuesListDecimalNumber; }
        }
        #endregion

        #region Convert Currency
        public double ConvertCurrency(string Case, double Currency)
        {
            //If '0' is returned, it's parsed incorrectly
            if (double.TryParse(Currency.ToString(), out Currency))
            {
                switch (Case)
                {
                    /* US Dollar = USD
                     * Bitcoin = BTC
                     * Euro = EUR
                     * British Pound = GBP
                     * Indian Rupee = INR
                     * Australian Dollar = AUD
                     * Canadian Dollar = CAD
                     * Japanese Yen = JPY
                     * Chinese Yuan Renminbi = CNY
                     * Mexican Peso = MXN
                     */

                    //US Dollar
                    case "US DollarUS Dollar":
                        return Currency * 1;
                    case "US DollarBitcoin":
                        return Currency * 0.0017;
                    case "US DollarEuro":
                        return Currency * 0.887097;
                    case "US DollarBritish Pound":
                        return Currency * 0.766687;
                    case "US DollarIndian Rupee":
                        return Currency * 66.8574;
                    case "US DollarAustralian Dollar":
                        return Currency * 1.29832;
                    case "US DollarCanadian Dollar":
                        return Currency * 1.28493;
                    case "US DollarJapanese Yen":
                        return Currency * 100.161;
                    case "US DollarChinese Yuan Renminbi":
                        return Currency * 6.62756;
                    case "US DollarMexican Peso":
                        return Currency * 17.9702;

                    //Bitcoin
                    case "BitcoinUS Dollar":
                        return Currency * 575.252;
                    case "BitcoinBitcoin":
                        return Currency * 1;
                    case "BitcoinEuro":
                        return Currency * 510.532;
                    case "BitcoinBritish Pound":
                        return Currency * 441.299;
                    case "BitcoinIndian Rupee":
                        return Currency * 38463.45;
                    case "BitcoinAustralian Dollar":
                        return Currency * 748.521;
                    case "BitcoinCanadian Dollar":
                        return Currency * 741.218;
                    case "BitcoinJapanese Yen":
                        return Currency * 57774.78;
                    case "BitcoinChinese Yuan Renminbi":
                        return Currency * 3821.80;
                    case "BitcoinMexican Peso":
                        return Currency * 10373.11;

                    //Euro
                    case "EuroUS Dollar":
                        return Currency * 1.12763;
                    case "EuroBitcoin":
                        return Currency * 0.00195874;
                    case "EuroEuro":
                        return Currency * 1;
                    case "EuroBritish Pound":
                        return Currency * 0.864847;
                    case "EuroIndian Rupee":
                        return Currency * 75.4066;
                    case "EuroAustralian Dollar":
                        return Currency * 1.46411;
                    case "EuroCanadian Dollar":
                        return Currency * 1.44976;
                    case "EuroJapanese Yen":
                        return Currency * 112.982;
                    case "EuroChinese Yuan Renminbi":
                        return Currency * 7.46836;
                    case "EuroMexican Peso":
                        return Currency * 20.2646;

                    //British Pound
                    case "British PoundUS Dollar":
                        return Currency * 1.30400;
                    case "British PoundBitcoin":
                        return Currency * 0.00226604;
                    case "British PoundEuro":
                        return Currency * 1.15627;
                    case "British PoundBritish Pound":
                        return Currency * 1;
                    case "British PoundIndian Rupee":
                        return Currency * 87.1903;
                    case "British PoundAustralian Dollar":
                        return Currency * 1.69238;
                    case "British PoundCanadian Dollar":
                        return Currency * 1.67568;
                    case "British PoundJapanese Yen":
                        return Currency * 130.665;
                    case "British PoundChinese Yuan Renminbi":
                        return Currency * 8.63624;
                    case "British PoundMexican Peso":
                        return Currency * 23.4370;

                    //Indian Rupee
                    case "Indian RupeeUS Dollar":
                        return Currency * 0.0149550;
                    case "Indian RupeeBitcoin":
                        return Currency * 0.0000259987;
                    case "Indian RupeeEuro":
                        return Currency * 0.0132614;
                    case "Indian RupeeBritish Pound":
                        return Currency * 0.0114692;
                    case "Indian RupeeIndian Rupee":
                        return Currency * 1;
                    case "Indian RupeeAustralian Dollar":
                        return Currency * 0.0194105;
                    case "Indian RupeeCanadian Dollar":
                        return Currency * 0.0192160;
                    case "Indian RupeeJapanese Yen":
                        return Currency * 1.49867;
                    case "Indian RupeeChinese Yuan Renminbi":
                        return Currency * 0.0990289;
                    case "Indian RupeeMexican Peso":
                        return Currency * 0.268801;

                    //Australian Dollar
                    case "Australian DollarUS Dollar":
                        return Currency * 0.770350;
                    case "Australian DollarBitcoin":
                        return Currency * 0.00133597;
                    case "Australian DollarEuro":
                        return Currency * 0.683008;
                    case "Australian DollarBritish Pound":
                        return Currency * 0.590883;
                    case "Australian DollarIndian Rupee":
                        return Currency * 51.5113;
                    case "Australian DollarAustralian Dollar":
                        return Currency * 1;
                    case "Australian DollarCanadian Dollar":
                        return Currency * 0.989891;
                    case "Australian DollarJapanese Yen":
                        return Currency * 77.2156;
                    case "Australian DollarChinese Yuan Renminbi":
                        return Currency * 5.10144;
                    case "Australian DollarMexican Peso":
                        return Currency * 13.8499;

                    //Canadian Dollar
                    case "Canadian DollarUS Dollar":
                        return Currency * 0.778263;
                    case "Canadian DollarBitcoin":
                        return Currency * 0.00134416;
                    case "Canadian DollarEuro":
                        return Currency * 0.690145;
                    case "Canadian DollarBritish Pound":
                        return Currency * 0.596568;
                    case "Canadian DollarIndian Rupee":
                        return Currency * 52.0415;
                    case "Canadian DollarAustralian Dollar":
                        return Currency * 1.01020;
                    case "Canadian DollarCanadian Dollar":
                        return Currency * 1;
                    case "Canadian DollarJapanese Yen":
                        return Currency * 77.9961;
                    case "Canadian DollarChinese Yuan Renminbi":
                        return Currency * 5.15424;
                    case "Canadian DollarMexican Peso":
                        return Currency * 13.9831;

                    //Japanese Yen
                    case "Japanese YenUS Dollar":
                        return Currency * 0.00997915;
                    case "Japanese YenBitcoin":
                        return Currency * 0.0000173086;
                    case "Japanese YenEuro":
                        return Currency * 0.00885097;
                    case "Japanese YenBritish Pound":
                        return Currency * 0.00765317;
                    case "Japanese YenIndian Rupee":
                        return Currency * 0.667284;
                    case "Japanese YenAustralian Dollar":
                        return Currency * 0.0129516;
                    case "Japanese YenCanadian Dollar":
                        return Currency * 0.0128199;
                    case "Japanese YenJapanese Yen":
                        return Currency * 1;
                    case "Japanese YenChinese Yuan Renminbi":
                        return Currency * 0.0660953;
                    case "Japanese YenMexican Peso":
                        return Currency * 0.179362;

                    //Chinese Yuan Renminbi
                    case "Chinese Yuan RenminbiUS Dollar":
                        return Currency * 0.150984;
                    case "Chinese Yuan RenminbiBitcoin":
                        return Currency * 0.000261657;
                    case "Chinese Yuan RenminbiEuro":
                        return Currency * 0.133898;
                    case "Chinese Yuan RenminbiBritish Pound":
                        return Currency * 0.115791;
                    case "Chinese Yuan RenminbiIndian Rupee":
                        return Currency * 10.0932;
                    case "Chinese Yuan RenminbiAustralian Dollar":
                        return Currency * 0.195979;
                    case "Chinese Yuan RenminbiCanadian Dollar":
                        return Currency * 0.194129;
                    case "Chinese Yuan RenminbiJapanese Yen":
                        return Currency * 15.1324;
                    case "Chinese Yuan RenminbiChinese Yuan Renminbi":
                        return Currency * 1;
                    case "Chinese Yuan RenminbiMexican Peso":
                        return Currency * 2.71373;

                    //Mexican Peso
                    case "Mexican PesoUS Dollar":
                        return Currency * 0.0556289;
                    case "Mexican PesoBitcoin":
                        return Currency * 0.0000964031;
                    case "Mexican PesoEuro":
                        return Currency * 0.0493470;
                    case "Mexican PesoBritish Pound":
                        return Currency * 0.0426676;
                    case "Mexican PesoIndian Rupee":
                        return Currency * 3.72155;
                    case "Mexican PesoAustralian Dollar":
                        return Currency * 0.0722344;
                    case "Mexican PesoCanadian Dollar":
                        return Currency * 0.0714903;
                    case "Mexican PesoJapanese Yen":
                        return Currency * 5.57863;
                    case "Mexican PesoChinese Yuan Renminbi":
                        return Currency * 0.368519;
                    case "Mexican PesoMexican Peso":
                        return Currency * 1;

                    default:
                        return 0;
                }
            }
            else
                return 0;
        }
        //List of Currency Items
        private List<string> _valuesListCurrency = new List<string>() { "US Dollar", "Bitcoin", "Euro", "British Pound", "Indian Rupee", "Australian Dollar", "Canadian Dollar", "Japanese Yen", "Chinese Yuan Renminbi", "Mexican Peso" };
        public List<string> ValuesListCurrency 
        {
            get { return _valuesListCurrency; }
        }
        #endregion

        #region Convert Liquid
        //Pints
        public double PINT_TO_PINT = 1.00000;
        public double PINT_TO_CM = 0.00047;
        public double PINT_TO_QT = 0.50000;
        public double PINT_TO_GL = 0.12500;
        public double PINT_TO_OZ = 16.00000;
        public double PINT_TO_CUPS = 2.00000;

        //Cubic Meters
        public double CM_TO_PINT = 2113.37630;
        public double CM_TO_CM = 1.00000;
        public double CM_TO_QT = 1056.68815;
        public double CM_TO_GL = 264.17204;
        public double CM_TO_OZ = 33814.02077;
        public double CM_TO_CUPS = 4226.75260;

        //Quarts
        public double QT_TO_PINT = 2.00000;
        public double QT_TO_CM = 0.00095;
        public double QT_TO_QT = 1.00000;
        public double QT_TO_GL = 0.25000;
        public double QT_TO_OZ = 32.00000;
        public double QT_TO_CUPS = 4.00000;

        //Gallons
        public double GL_TO_PINT = 8.00000;
        public double GL_TO_CM = 0.00379;
        public double GL_TO_QT = 4.00000;
        public double GL_TO_GL = 1.00000;
        public double GL_TO_OZ = 128.00000;
        public double GL_TO_CUPS = 16.00000;

        //Ounces
        public double OZ_TO_PINT = 0.06250;
        public double OZ_TO_CM = 0.00003;
        public double OZ_TO_QT = 0.03125;
        public double OZ_TO_GL = 0.00781;
        public double OZ_TO_OZ = 1.00000;
        public double OZ_TO_CUPS = 0.12500;

        //Cups
        public double CUPS_TO_PINT = 0.50000;
        public double CUPS_TO_CM = 0.00024;
        public double CUPS_TO_QT = 0.25000;
        public double CUPS_TO_GL = 0.06250;
        public double CUPS_TO_OZ = 8.00000;
        public double CUPS_TO_CUPS = 1.00000;

        //Conversion function
        public double ConvertLiquid(string Case, double Value)
        {
            //If '0' is returned, it's parsed incorrectly
            if (double.TryParse(Value.ToString(), out Value))
            {
                switch (Case)
                {
                    //Pints
                    case "PintsPints":
                        return Value * PINT_TO_PINT;
                    case "PintsCubic Meters":
                        return Value * PINT_TO_CM;
                    case "PintsQuarts":
                        return Value * PINT_TO_QT;
                    case "PintsGallons":
                        return Value * PINT_TO_GL;
                    case "PintsOunces":
                        return Value * PINT_TO_OZ;
                    case "PintsCups":
                        return Value * PINT_TO_CUPS;

                    //Cubic Meters
                    case "Cubic MetersPints":
                        return Value * CM_TO_PINT;
                    case "Cubic MetersCubic Meters":
                        return Value * CM_TO_CM;
                    case "Cubic MetersQuarts":
                        return Value * CM_TO_QT;
                    case "Cubic MetersGallons":
                        return Value * CM_TO_GL;
                    case "Cubic MetersOunces":
                        return Value * CM_TO_OZ;
                    case "Cubic MetersCups":
                        return Value * CM_TO_CUPS;

                    //Quarts
                    case "QuartsPints":
                        return Value * QT_TO_PINT;
                    case "QuartsCubic Meters":
                        return Value * QT_TO_CM;
                    case "QuartsQuarts":
                        return Value * QT_TO_QT;
                    case "QuartsGallons":
                        return Value * QT_TO_GL;
                    case "QuartsOunces":
                        return Value * QT_TO_OZ;
                    case "QuartsCups":
                        return Value * QT_TO_CUPS;

                    //Gallons
                    case "GallonsPints":
                        return Value * GL_TO_PINT;
                    case "GallonsCubic Meters":
                        return Value * GL_TO_CM;
                    case "GallonsQuarts":
                        return Value * GL_TO_QT;
                    case "GallonsGallons":
                        return Value * GL_TO_GL;
                    case "GallonsOunces":
                        return Value * GL_TO_OZ;
                    case "GallonsCups":
                        return Value * GL_TO_CUPS;

                    //Ounces
                    case "OuncesPints":
                        return Value * OZ_TO_PINT;
                    case "OuncesCubic Meters":
                        return Value * OZ_TO_CM;
                    case "OuncesQuarts":
                        return Value * OZ_TO_QT;
                    case "OuncesGallons":
                        return Value * OZ_TO_GL;
                    case "OuncesOunces":
                        return Value * OZ_TO_OZ;
                    case "OuncesCups":
                        return Value * OZ_TO_CUPS;

                    //Cups
                    case "CupsPints":
                        return Value * CUPS_TO_PINT;
                    case "CupsCubic Meters":
                        return Value * CUPS_TO_CM;
                    case "CupsQuarts":
                        return Value * CUPS_TO_QT;
                    case "CupsGallons":
                        return Value * CUPS_TO_GL;
                    case "CupsOunces":
                        return Value * CUPS_TO_OZ;
                    case "CupsCups":
                        return Value * CUPS_TO_CUPS;

                    //Default
                    default:
                        return 0;
                }
            }
            else
                return 0;
        }
        //List of Liquid Items
        private List<string> _valuesListLiquid = new List<string>() { "Pints", "Cubic Meters", "Quarts", "Gallons", "Ounces", "Cups" };
        public List<string> ValuesListLiquid 
        {
            get { return _valuesListLiquid; }
        }
        #endregion

        #region Convert Weight
        //Pounds
        public double LB_TO_LB = 1.00000;
        public double LB_TO_KG = 0.45359;
        public double LB_TO_OZ = 16.00000;
        public double LB_TO_G = 453.59232;
        public double LB_TO_T = 0.00050;
        //Kilograms
        public double KG_TO_LB = 2.20462;
        public double KG_TO_KG = 1.00000;
        public double KG_TO_OZ = 35.27397;
        public double KG_TO_G = 1000.00000;
        public double KG_TO_T = 0.00110;
        //Ounces
        public double OZ_TO_LB = 0.06250;
        public double OZ_TO_KG = 0.02835;
        public double OZ_TO_G = 28.34952;
        public double OZ_TO_T = 0.00003;
        //Grams
        public double G_TO_LB = 0.00220;
        public double G_TO_KG = 0.00100;
        public double G_TO_OZ = 0.03527;
        public double G_TO_G = 1.00000;
        public double G_TO_T = 0.00000;
        //US Tons
        public double T_TO_LB = 2000.00000;
        public double T_TO_KG = 907.18464;
        public double T_TO_OZ = 32000.00000;
        public double T_TO_G = 907184.64000;
        public double T_TO_T = 1.00000;

        //Conversion function
        public double ConvertWeight(string Case, double Value)
        {
            if (double.TryParse(Value.ToString(), out Value))
            {
                switch (Case)
                {
                    //Pounds
                    case "PoundsPounds":
                        return Value * LB_TO_LB;
                    case "PoundsKilograms":
                        return Value * LB_TO_KG;
                    case "PoundsOunces":
                        return Value * LB_TO_OZ;
                    case "PoundsGrams":
                        return Value * LB_TO_G;
                    case "PoundsUS Tons":
                        return Value * LB_TO_T;

                    //Kilograms
                    case "KilogramsPounds":
                        return Value * KG_TO_LB;
                    case "KilogramsKilograms":
                        return Value * KG_TO_KG;
                    case "KilogramsOunces":
                        return Value * KG_TO_OZ;
                    case "KilogramsGrams":
                        return Value * KG_TO_G;
                    case "KilogramsUS Tons":
                        return Value * KG_TO_T;

                    //Ounces
                    case "OuncesPounds":
                        return Value * OZ_TO_LB;
                    case "OuncesKilograms":
                        return Value * OZ_TO_KG;
                    case "OuncesOunces":
                        return Value * OZ_TO_OZ;
                    case "OuncesGrams":
                        return Value * OZ_TO_G;
                    case "OuncesUS Tons":
                        return Value * OZ_TO_T;

                    //Grams
                    case "GramsPounds":
                        return Value * G_TO_LB;
                    case "GramsKilograms":
                        return Value * G_TO_KG;
                    case "GramsOunces":
                        return Value * G_TO_OZ;
                    case "GramsGrams":
                        return Value * G_TO_G;
                    case "GramsUS Tons":
                        return Value * G_TO_T;

                    //US Tons
                    case "US TonsPounds":
                        return Value * T_TO_LB;
                    case "US TonsKilograms":
                        return Value * T_TO_KG;
                    case "US TonsOunces":
                        return Value * T_TO_OZ;
                    case "US TonsGrams":
                        return Value * T_TO_G;
                    case "US TonsUS Tons":
                        return Value * T_TO_T;

                    //Default
                    default:
                        return 0;
                }
            }
            else
                return 0;
        }
        //List of Weight Items
        private List<string> _valuesListWeight = new List<string>() { "Pounds", "Kilograms", "Ounces", "Grams", "US Tons" };
        public List<string> ValuesListWeight
        {
            get { return _valuesListWeight; }
        }
        #endregion

        #region Convert Length
        //Centimeters
        public double CM_TO_M = 0.01000;
        public double CM_TO_FT = 0.03281;
        public double CM_TO_YD = 0.01094;
        public double CM_TO_KM = 0.00001;
        public double CM_TO_MI = 0.00001;
        public double CM_TO_IN = 0.39370;
        //Meters
        public double M_TO_CM = 100.00000;
        public double M_TO_M = 1.00000;
        public double M_TO_FT = 3.28084;
        public double M_TO_YD = 1.09361;
        public double M_TO_KM = 0.00100;
        public double M_TO_MI = 0.00062;
        public double M_TO_IN = 39.37008;
        //Feet
        public double FT_TO_CM = 30.48000;
        public double FT_TO_M = 0.30480;
        public double FT_TO_FT = 1.00000;
        public double FT_TO_YD = 0.33333;
        public double FT_TO_KM = 0.00030;
        public double FT_TO_MI = 0.00019;
        public double FT_TO_IN = 12.00000;
        //Yards
        public double YD_TO_CM = 91.43999;
        public double YD_TO_M = 0.91440;
        public double YD_TO_FT = 3.00000;
        public double YD_TO_YD = 1.00000;
        public double YD_TO_KM = 0.00091;
        public double YD_TO_MI = 0.00057;
        public double YD_TO_IN = 36.00000;
        //Kilometers
        public double KM_TO_CM = 100000.00000;
        public double KM_TO_M = 1000.00000;
        public double KM_TO_FT = 3280.83976;
        public double KM_TO_YD = 1093.61339;
        public double KM_TO_KM = 1.00000;
        public double KM_TO_MI = 0.62137;
        public double KM_TO_IN = 39370.07874;
        //Miles
        public double MI_TO_CM = 160934.68839;
        public double MI_TO_M = 1609.34688;
        public double MI_TO_FT = 5280.00925;
        public double MI_TO_YD = 1760.00329;
        public double MI_TO_KM = 1.60935;
        public double MI_TO_MI = 1.00000;
        public double MI_TO_IN = 63360.11354;
        //Inchhes
        public double IN_TO_CM = 2.54000;
        public double IN_TO_M = 0.02540;
        public double IN_TO_FT = 0.08333;
        public double IN_TO_YD = 0.02778;
        public double IN_TO_KM = 0.00003;
        public double IN_TO_MI = 0.00002;
        public double IN_TO_IN = 1.00000;

        //Conversion function
        public double ConvertLength(string Case, double Value)
        {
            if (double.TryParse(Value.ToString(), out Value))
            {
                switch (Case)
                {
                    //Centimeters
                    case "CentimetersCentimeters":
                        return Value * CM_TO_CM;
                    case "CentimetersMeters":
                        return Value * CM_TO_M;
                    case "CentimetersFeet":
                        return Value * CM_TO_FT;
                    case "CentimetersYards":
                        return Value * CM_TO_YD;
                    case "CentimetersKilometers":
                        return Value * CM_TO_KM;
                    case "CentimetersMiles":
                        return Value * CM_TO_MI;
                    case "CentimetersInches":
                        return Value * CM_TO_IN;

                    //Meters
                    case "MetersCentimeters":
                        return Value * M_TO_CM;
                    case "MetersMeters":
                        return Value * M_TO_M;
                    case "MetersFeet":
                        return Value * M_TO_FT;
                    case "MetersYards":
                        return Value * M_TO_YD;
                    case "MetersKilometers":
                        return Value * M_TO_KM;
                    case "MetersMiles":
                        return Value * M_TO_MI;
                    case "MetersInches":
                        return Value * M_TO_IN;

                    //Feet
                    case "FeetCentimeters":
                        return Value * FT_TO_CM;
                    case "FeetMeters":
                        return Value * FT_TO_M;
                    case "FeetFeet":
                        return Value * FT_TO_FT;
                    case "FeetYards":
                        return Value * FT_TO_YD;
                    case "FeetKilometers":
                        return Value * FT_TO_KM;
                    case "FeetMiles":
                        return Value * FT_TO_MI;
                    case "FeetInches":
                        return Value * FT_TO_IN;

                    //Yards
                    case "YardsCentimeters":
                        return Value * YD_TO_CM;
                    case "YardsMeters":
                        return Value * YD_TO_M;
                    case "YardsFeet":
                        return Value * YD_TO_FT;
                    case "YardsYards":
                        return Value * YD_TO_YD;
                    case "YardsKilometers":
                        return Value * YD_TO_KM;
                    case "YardsMiles":
                        return Value * YD_TO_MI;
                    case "YardsInches":
                        return Value * YD_TO_IN;

                    //Kilometers
                    case "KilometersCentimeters":
                        return Value * KM_TO_CM;
                    case "KilometersMeters":
                        return Value * KM_TO_M;
                    case "KilometersFeet":
                        return Value * KM_TO_FT;
                    case "KilometersYards":
                        return Value * KM_TO_YD;
                    case "KilometersKilometers":
                        return Value * KM_TO_KM;
                    case "KilometersMiles":
                        return Value * KM_TO_MI;
                    case "KilometersInches":
                        return Value * KM_TO_IN;

                    //Miles
                    case "MilesCentimeters":
                        return Value * MI_TO_CM;
                    case "MilesMeters":
                        return Value * MI_TO_M;
                    case "MilesFeet":
                        return Value * MI_TO_FT;
                    case "MilesYards":
                        return Value * MI_TO_YD;
                    case "MilesKilometers":
                        return Value * MI_TO_KM;
                    case "MilesMiles":
                        return Value * MI_TO_MI;
                    case "MilesInches":
                        return Value * MI_TO_IN;

                    //Inches
                    case "InchesCentimeters":
                        return Value * IN_TO_CM;
                    case "InchesMeters":
                        return Value * IN_TO_M;
                    case "InchesFeet":
                        return Value * IN_TO_FT;
                    case "InchesYards":
                        return Value * IN_TO_YD;
                    case "InchesKilometers":
                        return Value * IN_TO_KM;
                    case "InchesMiles":
                        return Value * IN_TO_MI;
                    case "InchesInches":
                        return Value * IN_TO_IN;

                    //Default
                    default:
                        return 0;
                }
            }
            else
                return 0;
        }
        //List of Length Items
        private List<string> _valuesListLength = new List<string>() { "Centimeters", "Meters", "Feet", "Yards", "Kilometers", "Miles", "Inches" };
        public List<string> ValuesListLength
        {
            get { return _valuesListLength; }
        }
        #endregion

        #region Convert Degrees (Temperature)
        //Values
        public double KELVIN_CONST = 273.15;
        public double KELVIN_CONST2 = 459.67;

        public double ConvertDegrees(string Case, double Value)
        {
            if (double.TryParse(Value.ToString(), out Value))
            {
                switch (Case)
                {
                    //Celcius
                    case "CelciusCelcius":
                        return Value;
                    case "CelciusFahrenheit":
                        return (Value * 9 / 5) + 32;
                    case "CelciusKelvin":
                        return Value + KELVIN_CONST;

                    //Fahrenheit
                    case "FahrenheitCelcius":
                        return (Value - 32) * 5 / 9;
                    case "FahrenheitFahrenheit":
                        return Value;
                    case "FahrenheitKelvin":
                        return Value + KELVIN_CONST2;

                    //Kelvin
                    case "KelvinCelcius":
                        return Value - KELVIN_CONST;
                    case "KelvinFahrenheit":
                        return (Value * 9 / 5) + KELVIN_CONST2;
                    case "KelvinKelvin":
                        return Value;

                    default:
                        return 0;
                }
            }
            else
                return 0;
        }
        //List of Degrees Items
        private List<string> _valuesListDegrees = new List<string>() { "Celcius", "Fahrenheit", "Kelvin" };
        public List<string> ValuesListDegrees
        {
            get { return _valuesListDegrees; }
        }
        #endregion

        #region Convert Area
        //Square Inches
        public double SQI_TO_SQIN = 1.00000;
        public double SQI_TO_SQKM = 0.00000;
        public double SQI_TO_SQMI = 0.00000;
        public double SQI_TO_SQM = 0.00065;
        public double SQI_TO_SQFT = 0.00694;
        public double SQI_TO_SQCM = 6.45160;
        public double SQI_TO_SQYD = 0.00077;

        //Square Kilometers
        public double SQKM_TO_SQIN = 1550387596.89922;
        public double SQKM_TO_SQKM = 1.00000;
        public double SQKM_TO_SQMI = 0.38605;
        public double SQKM_TO_SQM = 1000248.06202;
        public double SQKM_TO_SQFT = 10766579.84496;
        public double SQKM_TO_SQCM = 10002480620.15500;
        public double SQKM_TO_SQYD = 1196286.82171;

        //Square Miles
        public double SQMI_TO_SQIN = 4016064257.02811;
        public double SQMI_TO_SQKM = 2.59036;
        public double SQMI_TO_SQMI = 1.00000;
        public double SQMI_TO_SQM = 2591004.01606;
        public double SQMI_TO_SQFT = 27889333.33333;
        public double SQMI_TO_SQCM = 25910040160.64260;
        public double SQMI_TO_SQYD = 3098815.26104;

        //Square Meters
        public double SQM_TO_SQIN = 1550.00310;
        public double SQM_TO_SQKM = 0.00000;
        public double SQM_TO_SQMI = 0.00000;
        public double SQM_TO_SQM = 1.00000;
        public double SQM_TO_SQFT = 10.76391;
        public double SQM_TO_SQCM = 10000.00000;
        public double SQM_TO_SQYD = 1.19599;

        //Square Feet
        public double SQFT_TO_SQIN = 144.00001;
        public double SQFT_TO_SQKM = 0.00000;
        public double SQFT_TO_SQMI = 0.00000;
        public double SQFT_TO_SQM = 0.09290;
        public double SQFT_TO_SQFT = 1.00000;
        public double SQFT_TO_SQCM = 929.03046;
        public double SQFT_TO_SQYD = 0.11111;

        //Square Feet
        public double SQCM_TO_SQIN = 0.15500;
        public double SQCM_TO_SQKM = 0.00000;
        public double SQCM_TO_SQMI = 0.00000;
        public double SQCM_TO_SQM = 0.00010;
        public double SQCM_TO_SQFT = 0.00108;
        public double SQCM_TO_SQCM = 1.00000;
        public double SQCM_TO_SQYD = 0.00012;

        //Square Yards
        public double SQYD_TO_SQIN = 1295.99990;
        public double SQYD_TO_SQKM = 0.00000;
        public double SQYD_TO_SQMI = 0.00000;
        public double SQYD_TO_SQM = 0.83613;
        public double SQYD_TO_SQFT = 9.00000;
        public double SQYD_TO_SQCM = 8361.27293;
        public double SQYD_TO_SQYD = 1.00000;

        //Conversion function
        public double ConvertArea(string Case, double Value)
        {
            if (double.TryParse(Value.ToString(), out Value))
            {
                switch (Case)
                {
                    //Square Inches
                    case "Square InchesSquare Inches":
                        return Value * SQI_TO_SQIN;
                    case "Square InchesSquare Kilometers":
                        return Value * SQI_TO_SQKM;
                    case "Square InchesSquare Miles":
                        return Value * SQI_TO_SQMI;
                    case "Square InchesSquare Meters":
                        return Value * SQI_TO_SQM;
                    case "Square InchesSquare Feet":
                        return Value * SQI_TO_SQFT;
                    case "Square InchesSquare Centimeters":
                        return Value * SQI_TO_SQCM;
                    case "Square InchesSquare Yards":
                        return Value * SQI_TO_SQYD;

                    //Square Kilometers
                    case "Square KilometersSquare Inches":
                        return Value * SQKM_TO_SQIN;
                    case "Square KilometersSquare Kilometers":
                        return Value * SQKM_TO_SQKM;
                    case "Square KilometersSquare Miles":
                        return Value * SQKM_TO_SQMI;
                    case "Square KilometersSquare Meters":
                        return Value * SQKM_TO_SQM;
                    case "Square KilometersSquare Feet":
                        return Value * SQKM_TO_SQFT;
                    case "Square KilometersSquare Centimeters":
                        return Value * SQKM_TO_SQCM;
                    case "Square KilometersSquare Yards":
                        return Value * SQKM_TO_SQYD;

                    //Square Miles
                    case "Square MilesSquare Inches":
                        return Value * SQMI_TO_SQIN;
                    case "Square MilesSquare Kilometers":
                        return Value * SQMI_TO_SQKM;
                    case "Square MilesSquare Miles":
                        return Value * SQMI_TO_SQMI;
                    case "Square MilesSquare Meters":
                        return Value * SQMI_TO_SQM;
                    case "Square MilesSquare Feet":
                        return Value * SQMI_TO_SQFT;
                    case "Square MilesSquare Centimeters":
                        return Value * SQMI_TO_SQCM;
                    case "Square MilesSquare Yards":
                        return Value * SQMI_TO_SQYD;

                    //Square Meters
                    case "Square MetersSquare Inches":
                        return Value * SQM_TO_SQIN;
                    case "Square MetersSquare Kilometers":
                        return Value * SQM_TO_SQKM;
                    case "Square MetersSquare Miles":
                        return Value * SQM_TO_SQMI;
                    case "Square MetersSquare Meters":
                        return Value * SQM_TO_SQM;
                    case "Square MetersSquare Feet":
                        return Value * SQM_TO_SQFT;
                    case "Square MetersSquare Centimeters":
                        return Value * SQM_TO_SQCM;
                    case "Square MetersSquare Yards":
                        return Value * SQM_TO_SQYD;

                    //Square Feet
                    case "Square FeetSquare Inches":
                        return Value * SQFT_TO_SQIN;
                    case "Square FeetSquare Kilometers":
                        return Value * SQFT_TO_SQKM;
                    case "Square FeetSquare Miles":
                        return Value * SQFT_TO_SQMI;
                    case "Square FeetSquare Meters":
                        return Value * SQFT_TO_SQM;
                    case "Square FeetSquare Feet":
                        return Value * SQFT_TO_SQFT;
                    case "Square FeetSquare Centimeters":
                        return Value * SQFT_TO_SQCM;
                    case "Square FeetSquare Yards":
                        return Value * SQFT_TO_SQYD;

                    //Square Centimeters
                    case "Square CentimetersSquare Inches":
                        return Value * SQCM_TO_SQIN;
                    case "Square CentimetersSquare Kilometers":
                        return Value * SQCM_TO_SQKM;
                    case "Square CentimetersSquare Miles":
                        return Value * SQCM_TO_SQMI;
                    case "Square CentimetersSquare Meters":
                        return Value * SQCM_TO_SQM;
                    case "Square CentimetersSquare Feet":
                        return Value * SQCM_TO_SQFT;
                    case "Square CentimetersSquare Centimeters":
                        return Value * SQCM_TO_SQCM;
                    case "Square CentimetersSquare Yards":
                        return Value * SQCM_TO_SQYD;

                    //Square Yards
                    case "Square YardsSquare Inches":
                        return Value * SQYD_TO_SQIN;
                    case "Square YardsSquare Kilometers":
                        return Value * SQYD_TO_SQKM;
                    case "Square YardsSquare Miles":
                        return Value * SQYD_TO_SQMI;
                    case "Square YardsSquare Meters":
                        return Value * SQYD_TO_SQM;
                    case "Square YardsSquare Feet":
                        return Value * SQYD_TO_SQFT;
                    case "Square YardsSquare Centimeters":
                        return Value * SQYD_TO_SQCM;
                    case "Square YardsSquare Yards":
                        return Value * SQYD_TO_SQYD;

                    //Default
                    default:
                        return 0;
                }
            }
            else
                return 0;
        }
        //List of Area Items
        private List<string> _valuesListArea = new List<string>() { "Square Inches", "Square Kilometers", "Square Miles", "Square Meters", "Square Feet", "Square Centimeters", "Square Yards" };
        public List<string> ValuesListArea
        {
            get { return _valuesListArea; }
        }
        #endregion

        #region Convert RadiansDegrees
        //Values
        const double PI = 3.1416;

        public double ConvertRadiansDegrees(string Case, double Value)
        {
            if (double.TryParse(Value.ToString(), out Value))
            {
                switch (Case)
                {
                    //Radians
                    case "RadiansDegrees":
                        return Value * (180 / PI);
                    case "RadiansRadians":
                        return Value;

                    //Degrees
                    case "DegreesDegrees":
                        return Value;
                    case "DegreesRadians":
                        return Value * (PI/180);

                    default:
                        return 0;
                }
            }
            else
                return 0;
        }
        //List of RadiansDegrees Items
        private List<string> _valuesListRadiansDegrees = new List<string>() { "Degrees", "Radians" };
        public List<string> ValuesListRadiansDegrees
        {
            get { return _valuesListRadiansDegrees; }
        }
        #endregion
    }
}
