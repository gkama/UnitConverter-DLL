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
        #endregion

        #region Convert Number
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
        #endregion
    }
}
