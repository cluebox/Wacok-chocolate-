using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WacokParsing
{
    class DB_insertion_wacok
    {
        SqlConnection connection = new SqlConnection("Data Source=52.74.59.117;Initial Catalog=ClueboxMobile;Persist Security Info=True;User ID=sa;Password=ClueBox123*;");
        internal void insert_Dashboard_values(string userID, int SurveyID, string AttendedOn, decimal Weight, string country, string Location, string Gender, string MaritalStatus, string Occupation, string Education, string AgeGroup, string SES, string BrTom, string BrSpont_BengBeng, string BrSpont_Cadbury, string BrSpont_Chacha, string BrSpont_Cheweez, string BrSpont_ChicChoc, string BrSpont_Cloud9, string BrSpont_ChokiChoki, string BrSpont_Dove, string BrSpont_Fullo, string BrSpont_GeryPasta, string BrSpont_KinderJoy, string BrSpont_KitKat, string BrSpont_Nockers, string BrSpont_Silverqueen, string BrSpont_Snickers, string BrSpont_Top, string BrSpont_OthersSpecify, string AdTom, string AdSpont_BengBeng, string AdSpont_Cadbury, string AdSpont_Chacha, string AdSpont_Cheweez, string AdSpont_ChicChoc, string AdSpont_Cloud9, string AdSpont_ChokiChoki, string AdSpont_Dove, string AdSpont_Fullo, string AdSpont_GeryPasta, string AdSpont_KinderJoy, string AdSpont_KitKat, string AdSpont_Nockers, string AdSpont_Silverqueen, string AdSpont_Snickers, string AdSpont_Top, string AdSpont_OthersSpecify, string Bumo, string Favourite_Brand, string ConL1M_BengBeng, string ConL1M_Cadbury, string ConL1M_Chacha, string ConL1M_Cheweez, string ConL1M_ChicChoc, string ConL1M_Cloud9, string ConL1M_ChokiChoki, string ConL1M_Dove, string ConL1M_Fullo, string ConL1M_GeryPasta, string ConL1M_KinderJoy, string ConL1M_KitKat, string ConL1M_Nockers, string ConL1M_Silverqueen, string ConL1M_Snickers, string ConL1M_Top, string ConL1M_OthersSpecify, string ConL3M_BengBeng, string ConL3M_Cadbury, string ConL3M_Chacha, string ConL3M_Cheweez, string ConL3M_ChicChoc, string ConL3M_Cloud9, string ConL3M_ChokiChoki, string ConL3M_Dove, string ConL3M_Fullo, string ConL3M_GeryPasta, string ConL3M_KinderJoy, string ConL3M_KitKat, string ConL3M_Nockers, string ConL3M_Silverqueen, string ConL3M_Snickers, string ConL3M_Top, string ConL3M_OthersSpecify, string ConL1W_BengBeng, string ConL1W_Cadbury, string ConL1W_Chacha, string ConL1W_Cheweez, string ConL1W_ChicChoc, string ConL1W_Cloud9, string ConL1W_ChokiChoki, string ConL1W_Dove, string ConL1W_Fullo, string ConL1W_GeryPasta, string ConL1W_KinderJoy, string ConL1W_KitKat, string ConL1W_Nockers, string ConL1W_Silverqueen, string ConL1W_Snickers, string ConL1W_Top, string ConL1W_OthersSpecify, string ConYestOrToday_BengBeng, string ConYestOrToday_Cadbury, string ConYestOrToday_Chacha, string ConYestOrToday_Cheweez, string ConYestOrToday_ChicChoc, string ConYestOrToday_Cloud9, string ConYestOrToday_ChokiChoki, string ConYestOrToday_Dove, string ConYestOrToday_Fullo, string ConYestOrToday_GeryPasta, string ConYestOrToday_KinderJoy, string ConYestOrToday_KitKat, string ConYestOrToday_Nockers, string ConYestOrToday_Silverqueen, string ConYestOrToday_Snickers, string ConYestOrToday_Top, string ConYestOrToday_OthersSpecify, string CH15, string CH16, string CH17, string CH18, string CH19, string CH20, string CH21, string CH22, string CH23, string S13_1, string S13_2, string S13_3, string S13_4, string S13_5, string S13_6, string S13_7, string S13_8, string S13_99, string S14_1, string S14_2, string S14_3, string S14_4, string S14_5, string S14_6, string S14_7, string S14_8, string S14_99, string CH25, string CH26, string CH29, string CH30, string CH6, string CHAP39, string CHAP40, string CHNOV39, string CHNOV40)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardFlatTabJava_Wacok_temp (UserID,AttendedOn,Weight,SurveyID,Country,SES,Location,AgeGroup,Gender,MaritalStatus,Occupation,Education,BrTom,BrSpont_BengBeng,BrSpont_Cadbury,BrSpont_Chacha,BrSpont_Cheweez,BrSpont_ChicChoc,BrSpont_Cloud9,BrSpont_ChokiChoki,BrSpont_Dove,BrSpont_Fullo,BrSpont_GeryPasta,BrSpont_KinderJoy,BrSpont_KitKat,BrSpont_Nockers,BrSpont_Silverqueen,BrSpont_Snickers,BrSpont_Top,BrSpont_OthersSpecify,AdTom,AdSpont_BengBeng,AdSpont_Cadbury,AdSpont_Chacha,AdSpont_Cheweez,AdSpont_ChicChoc,AdSpont_Cloud9,AdSpont_ChokiChoki,AdSpont_Dove,AdSpont_Fullo,AdSpont_GeryPasta,AdSpont_KinderJoy,AdSpont_KitKat,AdSpont_Nockers,AdSpont_Silverqueen,AdSpont_Snickers,AdSpont_Top,AdSpont_OthersSpecify,Bumo,Favourite_Brand,ConL1M_BengBeng,ConL1M_Cadbury,ConL1M_Chacha,ConL1M_Cheweez,ConL1M_ChicChoc,ConL1M_Cloud9,ConL1M_ChokiChoki,ConL1M_Dove,ConL1M_Fullo,ConL1M_GeryPasta,ConL1M_KinderJoy,ConL1M_KitKat,ConL1M_Nockers,ConL1M_Silverqueen,ConL1M_Snickers,ConL1M_Top,ConL1M_OthersSpecify,ConL3M_BengBeng,ConL3M_Cadbury,ConL3M_Chacha,ConL3M_Cheweez,ConL3M_ChicChoc,ConL3M_Cloud9,ConL3M_ChokiChoki,ConL3M_Dove,ConL3M_Fullo,ConL3M_GeryPasta,ConL3M_KinderJoy,ConL3M_KitKat,ConL3M_Nockers,ConL3M_Silverqueen,ConL3M_Snickers,ConL3M_Top,ConL3M_OthersSpecify,ConL1W_BengBeng,ConL1W_Cadbury,ConL1W_Chacha,ConL1W_Cheweez,ConL1W_ChicChoc,ConL1W_Cloud9,ConL1W_ChokiChoki,ConL1W_Dove,ConL1W_Fullo,ConL1W_GeryPasta,ConL1W_KinderJoy,ConL1W_KitKat,ConL1W_Nockers,ConL1W_Silverqueen,ConL1W_Snickers,ConL1W_Top,ConL1W_OthersSpecify,ConYestOrToday_BengBeng,ConYestOrToday_Cadbury,ConYestOrToday_Chacha,ConYestOrToday_Cheweez,ConYestOrToday_ChicChoc,ConYestOrToday_Cloud9,ConYestOrToday_ChokiChoki,ConYestOrToday_Dove,ConYestOrToday_Fullo,ConYestOrToday_GeryPasta,ConYestOrToday_KinderJoy,ConYestOrToday_KitKat,ConYestOrToday_Nockers,ConYestOrToday_Silverqueen,ConYestOrToday_Snickers,ConYestOrToday_Top,ConYestOrToday_OthersSpecify,CH15,CH16,CH17,CH18,CH19,CH20,CH21,CH22,CH23,S13_1,S13_2,S13_3,S13_4,S13_5,P1M_Chocolate,S13_7,S13_8,S13_99,S14_1,S14_2,S14_3,S14_4,S14_5,P1W_Chocolate,S14_7,S14_8,S14_99, Ad_visibility,CH26,CH29,CH30,CH6,CHAP39,CHAP40,CHNOV39,CHNOV40) " + "VALUES('" + userID + "','" + AttendedOn + "','" + Weight + "','" + SurveyID + "','" + country + "','" + SES + "','" + Location + "','" + AgeGroup + "','" + Gender + "','" + MaritalStatus + "','" + Occupation + "','" + Education + "','" + BrTom + "','" + BrSpont_BengBeng + "','" + BrSpont_Cadbury + "','" + BrSpont_Chacha + "','" + BrSpont_Cheweez + "','" + BrSpont_ChicChoc + "','" + BrSpont_Cloud9 + "','" + BrSpont_ChokiChoki + "','" + BrSpont_Dove + "','" + BrSpont_Fullo + "','" + BrSpont_GeryPasta + "','" + BrSpont_KinderJoy + "','" + BrSpont_KitKat + "','" + BrSpont_Nockers + "','" + BrSpont_Silverqueen + "','" + BrSpont_Snickers + "','" + BrSpont_Top + "','" + BrSpont_OthersSpecify + "','" + AdTom + "','" + AdSpont_BengBeng + "','" + AdSpont_Cadbury + "','" + AdSpont_Chacha + "','" + AdSpont_Cheweez + "','" + AdSpont_ChicChoc + "','" + AdSpont_Cloud9 + "','" + AdSpont_ChokiChoki + "','" + AdSpont_Dove + "','" + AdSpont_Fullo + "','" + AdSpont_GeryPasta + "','" + AdSpont_KinderJoy + "','" + AdSpont_KitKat + "','" + AdSpont_Nockers + "','" + AdSpont_Silverqueen + "','" + AdSpont_Snickers + "','" + AdSpont_Top + "','" + AdSpont_OthersSpecify + "','" + Bumo + "','" + Favourite_Brand + "','" + ConL1M_BengBeng + "','" + ConL1M_Cadbury + "','" + ConL1M_Chacha + "','" + ConL1M_Cheweez + "','" + ConL1M_ChicChoc + "','" + ConL1M_Cloud9 + "','" + ConL1M_ChokiChoki + "','" + ConL1M_Dove + "','" + ConL1M_Fullo + "','" + ConL1M_GeryPasta + "','" + ConL1M_KinderJoy + "','" + ConL1M_KitKat + "','" + ConL1M_Nockers + "','" + ConL1M_Silverqueen + "','" + ConL1M_Snickers + "','" + ConL1M_Top + "','" + ConL1M_OthersSpecify + "','" + ConL3M_BengBeng + "','" + ConL3M_Cadbury + "','" + ConL3M_Chacha + "','" + ConL3M_Cheweez + "','" + ConL3M_ChicChoc + "','" + ConL3M_Cloud9 + "','" + ConL3M_ChokiChoki + "','" + ConL3M_Dove + "','" + ConL3M_Fullo + "','" + ConL3M_GeryPasta + "','" + ConL3M_KinderJoy + "','" + ConL3M_KitKat + "','" + ConL3M_Nockers + "','" + ConL3M_Silverqueen + "','" + ConL3M_Snickers + "','" + ConL3M_Top + "','" + ConL3M_OthersSpecify + "','" + ConL1W_BengBeng + "','" + ConL1W_Cadbury + "','" + ConL1W_Chacha + "','" + ConL1W_Cheweez + "','" + ConL1W_ChicChoc + "','" + ConL1W_Cloud9 + "','" + ConL1W_ChokiChoki + "','" + ConL1W_Dove + "','" + ConL1W_Fullo + "','" + ConL1W_GeryPasta + "','" + ConL1W_KinderJoy + "','" + ConL1W_KitKat + "','" + ConL1W_Nockers + "','" + ConL1W_Silverqueen + "','" + ConL1W_Snickers + "','" + ConL1W_Top + "','" + ConL1W_OthersSpecify + "','" + ConYestOrToday_BengBeng + "','" + ConYestOrToday_Cadbury + "','" + ConYestOrToday_Chacha + "','" + ConYestOrToday_Cheweez + "','" + ConYestOrToday_ChicChoc + "','" + ConYestOrToday_Cloud9 + "','" + ConYestOrToday_ChokiChoki + "','" + ConYestOrToday_Dove + "','" + ConYestOrToday_Fullo + "','" + ConYestOrToday_GeryPasta + "','" + ConYestOrToday_KinderJoy + "','" + ConYestOrToday_KitKat + "','" + ConYestOrToday_Nockers + "','" + ConYestOrToday_Silverqueen + "','" + ConYestOrToday_Snickers + "','" + ConYestOrToday_Top + "','" + ConYestOrToday_OthersSpecify + "','" + CH15 + "','" + CH16 + "','" + CH17 + "','" + CH18 + "','" + CH19 + "','" + CH20 + "','" + CH21 + "','" + CH22 + "','" + CH23 + "','" + S13_1 + "','" + S13_2 + "','" + S13_3 + "','" + S13_4 + "','" + S13_5 + "','" + S13_6 + "','" + S13_7 + "','" + S13_8 + "','" + S13_99 + "','" + S14_1 + "','" + S14_2 + "','" + S14_3 + "','" + S14_4 + "','" + S14_5 + "','" + S14_6 + "','" + S14_7 + "','" + S14_8 + "','" + S14_99 + "','" + CH25 + "','" + CH26 + "','" + CH29 + "','" + CH30 + "','" + CH6 + "','" + CHAP39 + "','" + CHAP40 + "','" + CHNOV39 + "','" + CHNOV40 + "')", connection);
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");

            }
            catch (Exception ex)
            {

                connection.Close();
                Console.WriteLine("Exception occured" + ex.ToString());
                Console.WriteLine("Exception occured");

                Console.ReadLine();
            }
            connection.Close();
        }

        internal void insert_Dashboard_variable_values(string VARIABLE_NAME, string VARIABLE_NAME_SUB_NAME, string VARIABLE_ID, string VARIABLE_VALUE, string VARIABLE_NAME_QUESTION, int SurveyID, string country, string BASE_VARIABLE_NAME, string AttendedOn)
        {
            String VARIABLEVALUE = VARIABLE_VALUE.Replace("'", "");
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardSPS_Variable_Values (VARIABLE_NAME,VARIABLE_NAME_SUB_NAME,VARIABLE_ID,VARIABLE_VALUE,VARIABLE_NAME_QUESTION,SURVEY_ID,SURVEY_COUNTRY,BASE_VARIABLE_NAME,SURVEY_PERIOD) " + "VALUES('" + VARIABLE_NAME + "','" + VARIABLE_NAME_SUB_NAME + "','" + VARIABLE_ID + "','" + VARIABLEVALUE + "','" + VARIABLE_NAME_QUESTION + "','" + SurveyID + "','" + country + "','" + BASE_VARIABLE_NAME + "','" + AttendedOn + "')", connection);
            try
            {


                cmd.ExecuteNonQuery();
                Console.WriteLine("Dashboard variable values inserted successfully");

                connection.Close();



            }
            catch (Exception)
            {

                Console.WriteLine("Exception occured");
                Console.ReadLine();
            }
        }
    }
}
