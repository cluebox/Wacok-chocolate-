using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpssLib.SpssDataset;
using SpssLib.DataReader;
using System.IO;

namespace WacokParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            int SurveyID = 600593;
            //string SurveyPeriod = "2014-09-30";//survey period
            string AttendedOn = "2018-11-30";
            //string year = getYear(SurveyPeriod); 
            string country = "Indonesia";//survey country
            DB_insertion_wacok iobj = new DB_insertion_wacok();
            //string questions = "id,weight,S9,S8,S2,S7,S10,S11,S12,CH1,CH2_1,CH2_2,CH2_3,CH2_4,CH2_5,CH2_6,CH2_7,CH2_8,CH2_9,CH2_10,CH2_11,CH2_12,CH2_13,CH2_14,CH2_15,CH2_16,CH2_99,CH4,CH8_1,CH8_2,CH8_3,CH8_4,CH8_5,CH8_6,CH8_7,CH8_8,CH8_9,CH8_10,CH8_11,CH8_12,CH8_13,CH8_14,CH8_15,CH8_16,CH8_99,CH13,CH3,CH10_1,CH10_2,CH10_3,CH10_4,CH10_5,CH10_6,CH10_7,CH10_8,CH10_9,CH10_10,CH10_11,CH10_12,CH10_13,CH10_14,CH10_15,CH10_16,CH10_99,CH9_1,CH9_2,CH9_3,CH9_4,CH9_5,CH9_6,CH9_7,CH9_8,CH9_9,CH9_10,CH9_11,CH9_12,CH9_13,CH9_14,CH9_15,CH9_16,CH9_99,CH11_1,CH11_2,CH11_3,CH11_4,CH11_5,CH11_6,CH11_7,CH11_8,CH11_9,CH11_10,CH11_11,CH11_12,CH11_13,CH11_14,CH11_15,CH11_16,CH11_99,CH12_1,CH12_2,CH12_3,CH12_4,CH12_5,CH12_6,CH12_7,CH12_8,CH12_9,CH12_10,CH12_11,CH12_12,CH12_13,CH12_14,CH12_15,CH12_16,CH12_99,CH15,CH16,CH17,CH18,CH19,CH20,CH21,CH22,CH23,S13_1,S13_2,S13_3,S13_4,S13_5,S13_6,S13_7,S13_8,S13_99,S14_1,S14_2,S14_3,S14_4,S14_5,S14_6,S14_7,S14_8,S14_99,CH25,CH26,CH29,CH30,CH6,CHAP39,CHAP40,CHNOV39,CHNOV40";// dashboard variable value          
            string questions = "CHNOV39,CHNOV40";// dashboard variable value          
            string[] spss_variable_name = questions.Split(',');
            SpssReader spssDataset;
            using (FileStream fileStream = new FileStream(@"D:\spssparsing\wacok\WacockChocolateSet2_Nov2018.sav", FileMode.Open, FileAccess.Read, FileShare.Read, 2048 * 10, FileOptions.SequentialScan))
            {
                spssDataset = new SpssReader(fileStream); // Create the reader, this will read the file header
                foreach (string spss_v in spss_variable_name)
                {
                    foreach (var variable in spssDataset.Variables)  // Iterate through all the varaibles
                    {
                        if (variable.Name.Equals(spss_v))
                        {
                            foreach (KeyValuePair<double, string> label in variable.ValueLabels)
                            {
                                string VARIABLE_NAME = spss_v;
                                string VARIABLE_NAME_SUB_NAME = variable.Name;
                                string VARIABLE_ID = label.Key.ToString();
                                string VARIABLE_VALUE = label.Value;
                                string VARIABLE_NAME_QUESTION = variable.Label;
                                string BASE_VARIABLE_NAME = variable.Name;
                                iobj.insert_Dashboard_variable_values(VARIABLE_NAME, VARIABLE_NAME_SUB_NAME, VARIABLE_ID, VARIABLE_VALUE, VARIABLE_NAME_QUESTION, SurveyID, country, BASE_VARIABLE_NAME, AttendedOn);
                            }
                        }

                    }
                }
                foreach (var record in spssDataset.Records)
                {
                    string userID = null;
                    string u_id = null;
                    string variable_name;
                    decimal Weight = 0;
                    string Country = "-- Not Available --";
                    string Education = "-- Not Available --";
                    string Location = "-- Not Available --";
                    string Gender = "-- Not Available --";
                    string MaritalStatus = "-- Not Available --";
                    string AgeGroup = "-- Not Available --";
                    string SES = "-- Not Available --";
                    string Occupation = "-- Not Available --";
                    string BrTom = "-- Not Available --";
                    string BrSpont_BengBeng = "-- Not Available --";
                    string BrSpont_Cadbury = "-- Not Available --";
                    string BrSpont_Chacha = "-- Not Available --";
                    string BrSpont_Cheweez = "-- Not Available --";
                    string BrSpont_ChicChoc = "-- Not Available --";
                    string BrSpont_Cloud9 = "-- Not Available --";
                    string BrSpont_ChokiChoki = "-- Not Available --";
                    string BrSpont_Dove = "-- Not Available --";
                    string BrSpont_Fullo = "-- Not Available --";
                    string BrSpont_GeryPasta = "-- Not Available --";
                    string BrSpont_KinderJoy = "-- Not Available --";
                    string BrSpont_KitKat = "-- Not Available --";
                    string BrSpont_Nockers = "-- Not Available --";
                    string BrSpont_Silverqueen = "-- Not Available --";
                    string BrSpont_Snickers = "-- Not Available --";
                    string BrSpont_Top = "-- Not Available --";
                    string BrSpont_OthersSpecify = "-- Not Available --";
                    string AdTom = "-- Not Available --";
                    string AdSpont_BengBeng = "-- Not Available --";
                    string AdSpont_Cadbury = "-- Not Available --";
                    string AdSpont_Chacha = "-- Not Available --";
                    string AdSpont_Cheweez = "-- Not Available --";
                    string AdSpont_ChicChoc = "-- Not Available --";
                    string AdSpont_Cloud9 = "-- Not Available --";
                    string AdSpont_ChokiChoki = "-- Not Available --";
                    string AdSpont_Dove = "-- Not Available --";
                    string AdSpont_Fullo = "-- Not Available --";
                    string AdSpont_GeryPasta = "-- Not Available --";
                    string AdSpont_KinderJoy = "-- Not Available --";
                    string AdSpont_KitKat = "-- Not Available --";
                    string AdSpont_Nockers = "-- Not Available --";
                    string AdSpont_Silverqueen = "-- Not Available --";
                    string AdSpont_Snickers = "-- Not Available --";
                    string AdSpont_Top = "-- Not Available --";
                    string AdSpont_OthersSpecify = "-- Not Available --";
                    string Bumo = "-- Not Available --";
                    string Favourite_Brand = "-- Not Available --";
                    string ConL1M_BengBeng = "-- Not Available --";
                    string ConL1M_Cadbury = "-- Not Available --";
                    string ConL1M_Chacha = "-- Not Available --";
                    string ConL1M_Cheweez = "-- Not Available --";
                    string ConL1M_ChicChoc = "-- Not Available --";
                    string ConL1M_Cloud9 = "-- Not Available --";
                    string ConL1M_ChokiChoki = "-- Not Available --";
                    string ConL1M_Dove = "-- Not Available --";
                    string ConL1M_Fullo = "-- Not Available --";
                    string ConL1M_GeryPasta = "-- Not Available --";
                    string ConL1M_KinderJoy = "-- Not Available --";
                    string ConL1M_KitKat = "-- Not Available --";
                    string ConL1M_Nockers = "-- Not Available --";
                    string ConL1M_Silverqueen = "-- Not Available --";
                    string ConL1M_Snickers = "-- Not Available --";
                    string ConL1M_Top = "-- Not Available --";
                    string ConL1M_OthersSpecify = "-- Not Available --";
                    string ConL3M_BengBeng = "-- Not Available --";
                    string ConL3M_Cadbury = "-- Not Available --";
                    string ConL3M_Chacha = "-- Not Available --";
                    string ConL3M_Cheweez = "-- Not Available --";
                    string ConL3M_ChicChoc = "-- Not Available --";
                    string ConL3M_Cloud9 = "-- Not Available --";
                    string ConL3M_ChokiChoki = "-- Not Available --";
                    string ConL3M_Dove = "-- Not Available --";
                    string ConL3M_Fullo = "-- Not Available --";
                    string ConL3M_GeryPasta = "-- Not Available --";
                    string ConL3M_KinderJoy = "-- Not Available --";
                    string ConL3M_KitKat = "-- Not Available --";
                    string ConL3M_Nockers = "-- Not Available --";
                    string ConL3M_Silverqueen = "-- Not Available --";
                    string ConL3M_Snickers = "-- Not Available --";
                    string ConL3M_Top = "-- Not Available --";
                    string ConL3M_OthersSpecify = "-- Not Available --";
                    string ConL1W_BengBeng = "-- Not Available --";
                    string ConL1W_Cadbury = "-- Not Available --";
                    string ConL1W_Chacha = "-- Not Available --";
                    string ConL1W_Cheweez = "-- Not Available --";
                    string ConL1W_ChicChoc = "-- Not Available --";
                    string ConL1W_Cloud9 = "-- Not Available --";
                    string ConL1W_ChokiChoki = "-- Not Available --";
                    string ConL1W_Dove = "-- Not Available --";
                    string ConL1W_Fullo = "-- Not Available --";
                    string ConL1W_GeryPasta = "-- Not Available --";
                    string ConL1W_KinderJoy = "-- Not Available --";
                    string ConL1W_KitKat = "-- Not Available --";
                    string ConL1W_Nockers = "-- Not Available --";
                    string ConL1W_Silverqueen = "-- Not Available --";
                    string ConL1W_Snickers = "-- Not Available --";
                    string ConL1W_Top = "-- Not Available --";
                    string ConL1W_OthersSpecify = "-- Not Available --";
                    string ConYestOrToday_BengBeng = "-- Not Available --";
                    string ConYestOrToday_Cadbury = "-- Not Available --";
                    string ConYestOrToday_Chacha = "-- Not Available --";
                    string ConYestOrToday_Cheweez = "-- Not Available --";
                    string ConYestOrToday_ChicChoc = "-- Not Available --";
                    string ConYestOrToday_Cloud9 = "-- Not Available --";
                    string ConYestOrToday_ChokiChoki = "-- Not Available --";
                    string ConYestOrToday_Dove = "-- Not Available --";
                    string ConYestOrToday_Fullo = "-- Not Available --";
                    string ConYestOrToday_GeryPasta = "-- Not Available --";
                    string ConYestOrToday_KinderJoy = "-- Not Available --";
                    string ConYestOrToday_KitKat = "-- Not Available --";
                    string ConYestOrToday_Nockers = "-- Not Available --";
                    string ConYestOrToday_Silverqueen = "-- Not Available --";
                    string ConYestOrToday_Snickers = "-- Not Available --";
                    string ConYestOrToday_Top = "-- Not Available --";
                    string ConYestOrToday_OthersSpecify = "-- Not Available --";
                    string CH15 = "-- Not Available --";
                    string CH16 = "-- Not Available --";
                    string CH17 = "-- Not Available --";
                    string CH18 = "-- Not Available --";
                    string CH19 = "-- Not Available --";
                    string CH20 = "-- Not Available --";
                    string CH21 = "-- Not Available --";
                    string CH22 = "-- Not Available --";
                    string CH23 = "-- Not Available --";
                    string S13_1 = "-- Not Available --";
                    string S13_2 = "-- Not Available --";
                    string S13_3 = "-- Not Available --";
                    string S13_4 = "-- Not Available --";
                    string S13_5 = "-- Not Available --";
                    string S13_6 = "-- Not Available --";
                    string S13_7 = "-- Not Available --";
                    string S13_8 = "-- Not Available --";
                    string S13_99 = "-- Not Available --";
                    string S14_1 = "-- Not Available --";
                    string S14_2 = "-- Not Available --";
                    string S14_3 = "-- Not Available --";
                    string S14_4 = "-- Not Available --";
                    string S14_5 = "-- Not Available --";
                    string S14_6 = "-- Not Available --";
                    string S14_7 = "-- Not Available --";
                    string S14_8 = "-- Not Available --";
                    string S14_99 = "-- Not Available --";
                    string CH25 = "-- Not Available --";
                    string CH26 = "-- Not Available --";
                    string CH29 = "-- Not Available --";
                    string CH30 = "-- Not Available --";
                    string CH6 = "-- Not Available --";
                    string CHAP39 = "-- Not Available --";
                    string CHAP40 = "-- Not Available --";
                    string CHNOV39 = "-- Not Available --";
                    string CHNOV40 = "-- Not Available --";
                    foreach (var variable in spssDataset.Variables)
                    {
                        foreach (string spss_v in spss_variable_name)
                        {
                            if (variable.Name.Equals(spss_v))
                            {
                                variable_name = variable.Name;

                                switch (variable_name)
                                {
                                case "id":
                                        {
                                            u_id = Convert.ToString(record.GetValue(variable));
                                            userID = find_UserId(SurveyID, AttendedOn, u_id);
                                            break;
                                        }
                                case "weight":
                                        {
                                Weight = Convert.ToDecimal(record.GetValue(variable));
                                break;
                                }
                                case "S10":
                                    {
                                        MaritalStatus = Convert.ToString(record.GetValue(variable));
                                        break;
                                    }
                                case "S11":
                                    {
                                        Occupation = Convert.ToString(record.GetValue(variable));
                                        break;
                                    }
                                case "S12":
                                    {
                                        Education = Convert.ToString(record.GetValue(variable));
                                        break;
                                    }
                                case "S9":{
                                SES = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "S8":{
                                Location = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "S2":{
                                AgeGroup = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "S7":{
                                Gender = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "CH1":{
                                BrTom = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "CH2_1":{
                                BrSpont_BengBeng = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "CH2_2":{
                                BrSpont_Cadbury = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "CH2_3":{
                                BrSpont_Chacha = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "CH2_4":{
                                BrSpont_Cheweez = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "CH2_5":{
                                BrSpont_ChicChoc = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "CH2_6":{
                                BrSpont_Cloud9 = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "CH2_7":{
                                BrSpont_ChokiChoki = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "CH2_8":{
                                BrSpont_Dove = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "CH2_9":{
                                BrSpont_Fullo = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "CH2_10":{
                                BrSpont_GeryPasta = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "CH2_11":{
                                BrSpont_KinderJoy = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "CH2_12":{
                                BrSpont_KitKat = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "CH2_13":{
                                BrSpont_Nockers = Convert.ToString(record.GetValue(variable));
                                break;
                                }
                                case "CH2_14":{
                                BrSpont_Silverqueen = Convert.ToString(record.GetValue(variable));
                                break;}
                                case "CH2_15":{
                                BrSpont_Snickers = Convert.ToString(record.GetValue(variable));
                                break;}
                                case "CH2_16":{
                                BrSpont_Top = Convert.ToString(record.GetValue(variable));
                                break;}
                                case "CH2_99":{
                                BrSpont_OthersSpecify = Convert.ToString(record.GetValue(variable));break;}
                                case "CH4":{
                                AdTom = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_1":{
                                AdSpont_BengBeng = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_2":{
                                AdSpont_Cadbury = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_3":{
                                AdSpont_Chacha = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_4":{
                                AdSpont_Cheweez = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_5":{
                                AdSpont_ChicChoc = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_6":{
                                AdSpont_Cloud9 = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_7":{
                                AdSpont_ChokiChoki = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_8":{
                                AdSpont_Dove = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_9":{
                                AdSpont_Fullo = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_10":{
                                AdSpont_GeryPasta = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_11":{
                                AdSpont_KinderJoy = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_12":{
                                AdSpont_KitKat = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_13":{
                                AdSpont_Nockers = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_14":{
                                AdSpont_Silverqueen = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_15":{
                                AdSpont_Snickers = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_16":{
                                AdSpont_Top = Convert.ToString(record.GetValue(variable));break;}
                                case "CH8_99":{
                                AdSpont_OthersSpecify = Convert.ToString(record.GetValue(variable));break;}
                                case "CH13":{
                                Bumo = Convert.ToString(record.GetValue(variable));break;}
                                case "CH3":{
                                Favourite_Brand = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_1":{
                                ConL1M_BengBeng = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_2":{
                                ConL1M_Cadbury = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_3":{
                                ConL1M_Chacha = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_4":{
                                ConL1M_Cheweez = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_5":{
                                ConL1M_ChicChoc = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_6":{
                                ConL1M_Cloud9 = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_7":{
                                ConL1M_ChokiChoki = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_8":{
                                ConL1M_Dove = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_9":{
                                ConL1M_Fullo = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_10":{
                                ConL1M_GeryPasta = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_11":{
                                ConL1M_KinderJoy = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_12":{
                                ConL1M_KitKat = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_13":{
                                ConL1M_Nockers = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_14":{
                                ConL1M_Silverqueen = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_15":{
                                ConL1M_Snickers = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_16":{
                                ConL1M_Top = Convert.ToString(record.GetValue(variable));break;}
                                case "CH10_99":{
                                ConL1M_OthersSpecify = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_1":{
                                ConL3M_BengBeng = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_2":{
                                ConL3M_Cadbury = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_3":{
                                ConL3M_Chacha = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_4":{
                                ConL3M_Cheweez = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_5":{
                                ConL3M_ChicChoc = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_6":{
                                ConL3M_Cloud9 = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_7":{
                                ConL3M_ChokiChoki = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_8":{
                                ConL3M_Dove = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_9":{
                                ConL3M_Fullo = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_10":{
                                ConL3M_GeryPasta = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_11":{
                                ConL3M_KinderJoy = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_12":{
                                ConL3M_KitKat = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_13":{
                                ConL3M_Nockers = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_14":{
                                ConL3M_Silverqueen = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_15":{
                                ConL3M_Snickers = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_16":{
                                ConL3M_Top = Convert.ToString(record.GetValue(variable));break;}
                                case "CH9_99":{
                                ConL3M_OthersSpecify = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_1":{
                                ConL1W_BengBeng = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_2":{
                                ConL1W_Cadbury = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_3":{
                                ConL1W_Chacha = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_4":{
                                ConL1W_Cheweez = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_5":{
                                ConL1W_ChicChoc = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_6":{
                                ConL1W_Cloud9 = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_7":{
                                ConL1W_ChokiChoki = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_8":{
                                ConL1W_Dove = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_9":{
                                ConL1W_Fullo = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_10":{
                                ConL1W_GeryPasta = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_11":{
                                ConL1W_KinderJoy = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_12":{
                                ConL1W_KitKat = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_13":{
                                ConL1W_Nockers = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_14":{
                                ConL1W_Silverqueen = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_15":{
                                ConL1W_Snickers = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_16":{
                                ConL1W_Top = Convert.ToString(record.GetValue(variable));break;}
                                case "CH11_99":{
                                ConL1W_OthersSpecify = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_1":{
                                ConYestOrToday_BengBeng = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_2":{
                                ConYestOrToday_Cadbury = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_3":{
                                ConYestOrToday_Chacha = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_4":{
                                ConYestOrToday_Cheweez = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_5":{
                                ConYestOrToday_ChicChoc = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_6":{
                                ConYestOrToday_Cloud9 = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_7":{
                                ConYestOrToday_ChokiChoki = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_8":{
                                ConYestOrToday_Dove = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_9":{
                                ConYestOrToday_Fullo = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_10":{
                                ConYestOrToday_GeryPasta = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_11":{
                                ConYestOrToday_KinderJoy = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_12":{
                                ConYestOrToday_KitKat = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_13":{
                                ConYestOrToday_Nockers = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_14":{
                                ConYestOrToday_Silverqueen = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_15":{
                                ConYestOrToday_Snickers = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_16":{
                                ConYestOrToday_Top = Convert.ToString(record.GetValue(variable));break;}
                                case "CH12_99":{
                                ConYestOrToday_OthersSpecify = Convert.ToString(record.GetValue(variable));break;}
                                case "CH15":{
                                CH15 = Convert.ToString(record.GetValue(variable));break;}
                                case "CH16":{
                                CH16 = Convert.ToString(record.GetValue(variable));break;}
                                case "CH17":{
                                CH17 = Convert.ToString(record.GetValue(variable));break;}
                                case "CH18":{
                                CH18 = Convert.ToString(record.GetValue(variable));break;}
                                case "CH19":{
                                CH19 = Convert.ToString(record.GetValue(variable));break;}
                                case "CH20":{
                                CH20 = Convert.ToString(record.GetValue(variable));break;}
                                case "CH21":{
                                CH21 = Convert.ToString(record.GetValue(variable));break;}
                                case "CH22":{
                                CH22 = Convert.ToString(record.GetValue(variable));break;}
                                case "CH23":{
                                CH23 = Convert.ToString(record.GetValue(variable));break;}
                                case "S13_1": { S13_1 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S13_2": { S13_2 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S13_3": { S13_3 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S13_4": { S13_4 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S13_5": { S13_5 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S13_6": { S13_6 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S13_7": { S13_7 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S13_8": { S13_8 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S13_99": { S13_99 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S14_1": { S14_1 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S14_2": { S14_2 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S14_3": { S14_3 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S14_4": { S14_4 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S14_5": { S14_5 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S14_6": { S14_6 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S14_7": { S14_7 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S14_8": { S14_8 = Convert.ToString(record.GetValue(variable)); break; }
                                case "S14_99":{ S14_99 = Convert.ToString(record.GetValue(variable)); break;}
                                case "CH25": { CH25 = Convert.ToString(record.GetValue(variable)); break; }
                                case "CH26": { CH26 = Convert.ToString(record.GetValue(variable)); break; }
                                case "CH29": { CH29 = Convert.ToString(record.GetValue(variable)); break; }
                                case "CH30": { CH30 = Convert.ToString(record.GetValue(variable)); break; }
                                case "CH6": { CH6 = Convert.ToString(record.GetValue(variable)); break; }
                                case "CHAP39": { CHAP39 = Convert.ToString(record.GetValue(variable)); break; }
                                case "CHAP40": { CHAP40 = Convert.ToString(record.GetValue(variable)); break; }
                                case "CHNOV39": { CHNOV39 = Convert.ToString(record.GetValue(variable)); break; }
                                case "CHNOV40": { CHNOV40 = Convert.ToString(record.GetValue(variable)); break; }
                                }

                            }
                        }
                    }
                   
                    if (userID != null && Weight != 0)
                    {
                        //iobj.insert_Dashboard_values(userID, SurveyID, AttendedOn, Weight, country, Location, Gender, MaritalStatus, Occupation, Education, AgeGroup, SES, BrTom, BrSpont_BengBeng, BrSpont_Cadbury, BrSpont_Chacha, BrSpont_Cheweez, BrSpont_ChicChoc, BrSpont_Cloud9, BrSpont_ChokiChoki, BrSpont_Dove, BrSpont_Fullo, BrSpont_GeryPasta, BrSpont_KinderJoy, BrSpont_KitKat, BrSpont_Nockers, BrSpont_Silverqueen, BrSpont_Snickers, BrSpont_Top, BrSpont_OthersSpecify, AdTom, AdSpont_BengBeng, AdSpont_Cadbury, AdSpont_Chacha, AdSpont_Cheweez, AdSpont_ChicChoc, AdSpont_Cloud9, AdSpont_ChokiChoki, AdSpont_Dove, AdSpont_Fullo, AdSpont_GeryPasta, AdSpont_KinderJoy, AdSpont_KitKat, AdSpont_Nockers, AdSpont_Silverqueen, AdSpont_Snickers, AdSpont_Top, AdSpont_OthersSpecify, Bumo, Favourite_Brand, ConL1M_BengBeng, ConL1M_Cadbury, ConL1M_Chacha, ConL1M_Cheweez, ConL1M_ChicChoc, ConL1M_Cloud9, ConL1M_ChokiChoki, ConL1M_Dove, ConL1M_Fullo, ConL1M_GeryPasta, ConL1M_KinderJoy, ConL1M_KitKat, ConL1M_Nockers, ConL1M_Silverqueen, ConL1M_Snickers, ConL1M_Top, ConL1M_OthersSpecify, ConL3M_BengBeng, ConL3M_Cadbury, ConL3M_Chacha, ConL3M_Cheweez, ConL3M_ChicChoc, ConL3M_Cloud9, ConL3M_ChokiChoki, ConL3M_Dove, ConL3M_Fullo, ConL3M_GeryPasta, ConL3M_KinderJoy, ConL3M_KitKat, ConL3M_Nockers, ConL3M_Silverqueen, ConL3M_Snickers, ConL3M_Top, ConL3M_OthersSpecify, ConL1W_BengBeng, ConL1W_Cadbury, ConL1W_Chacha, ConL1W_Cheweez, ConL1W_ChicChoc, ConL1W_Cloud9, ConL1W_ChokiChoki, ConL1W_Dove, ConL1W_Fullo, ConL1W_GeryPasta, ConL1W_KinderJoy, ConL1W_KitKat, ConL1W_Nockers, ConL1W_Silverqueen, ConL1W_Snickers, ConL1W_Top, ConL1W_OthersSpecify, ConYestOrToday_BengBeng, ConYestOrToday_Cadbury, ConYestOrToday_Chacha, ConYestOrToday_Cheweez, ConYestOrToday_ChicChoc, ConYestOrToday_Cloud9, ConYestOrToday_ChokiChoki, ConYestOrToday_Dove, ConYestOrToday_Fullo, ConYestOrToday_GeryPasta, ConYestOrToday_KinderJoy, ConYestOrToday_KitKat, ConYestOrToday_Nockers, ConYestOrToday_Silverqueen, ConYestOrToday_Snickers, ConYestOrToday_Top, ConYestOrToday_OthersSpecify, CH15, CH16, CH17, CH18, CH19, CH20, CH21, CH22, CH23, S13_1, S13_2, S13_3, S13_4, S13_5, S13_6, S13_7, S13_8, S13_99, S14_1, S14_2, S14_3, S14_4, S14_5, S14_6, S14_7, S14_8, S14_99, CH25, CH26, CH29, CH30, CH6, CHAP39, CHAP40,CHNOV39,CHNOV40);
                    }
                }
            }
        }
        private static string find_UserId(int SurveyID, string SurveyPeriod, string u_id)
        {
            string sum = "";
            string[] date = SurveyPeriod.Split('-');
            foreach (string d in date)
            {
                sum = sum + d;

            }
            return u_id + SurveyID + sum;
        }
    }
}
