using DataAccess.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DbHandiler;

namespace DataAccess.Buisness
{
    public class DataPreprocessor
    {
        

        public string LoadDataUsingDb(int item)
        {
            DbHandiler.DbHandiler DbHandle = new DbHandiler.DbHandiler();
            List<StudentDetailsData> returnList = new List<StudentDetailsData>();
            string sql = string.Empty;
            if (item == 0)
            {
                sql = @"SELECT `student_data`.`ID`,
                                `student_data`.`UID`,
                                `student_data`.`SUBJECT1`,
                                `student_data`.`SUBJECT2`,
                                `student_data`.`ADDRESS`,
                                `student_data`.`MARKS1`,
                                 `student_data`.`MARKS2`,
                                 `student_data`.`NAME`,
                                 `student_data`.`CLASS`,
                                 `student_data`.`AGE`,
                                 `student_data`.`SEX`
                            FROM `samle_my_students`.`student_data`;";
            }
            else
            {
                sql = string.Concat (@"SELECT `student_data`.`ID`,
                                 `student_data`.`UID`,
                                `student_data`.`SUBJECT1`,
                                `student_data`.`SUBJECT2`,
                                `student_data`.`ADDRESS`,
                                `student_data`.`MARKS1`,
                                 `student_data`.`MARKS2`,
                                 `student_data`.`NAME`,
                                 `student_data`.`CLASS`,
                                 `student_data`.`AGE`,
                                 `student_data`.`SEX`
                            FROM `samle_my_students`.`student_data`
                              where id = ", item, ";");

            }

            returnList = DbHandle.LoadData<StudentDetailsData>(sql);

            string json = JsonConvert.SerializeObject(returnList);

            return json;

        }

        public object UpdateToDb(StudentDetailsData data)
        {
            DbHandiler.DbHandiler DbHandle = new DbHandiler.DbHandiler();
            
            string sql = @"UPDATE student_data SET SUBJECT1 = @SUBJECT1,SUBJECT2 = @SUBJECT2,ADDRESS = @ADDRESS ,MARKS1 = @MARKS1, 
                           MARKS2 = @MARKS2,NAME = @NAME,CLASS = @CLASS ,AGE = @AGE,SEX = @SEX,UID = @UID
                           where ID = @ID ";
            return DbHandle.SaveData<StudentDetailsData>(sql, data);
        }

        public int InsertData(StudentDetailsData data)
        {
            DbHandiler.DbHandiler DbHandle = new DbHandiler.DbHandiler();
           
            string sql = @"insert into student_data (SUBJECT1,SUBJECT2,ADDRESS,MARKS1,MARKS2,NAME,CLASS,AGE,SEX,UID) VALUES (@SUBJECT1,@SUBJECT2,@ADDRESS,@MARKS1,@MARKS2,@NAME,@CLASS,@AGE,@SEX,@UID);";
            return DbHandle.SaveData<StudentDetailsData>(sql, data);
        }
    }
}
