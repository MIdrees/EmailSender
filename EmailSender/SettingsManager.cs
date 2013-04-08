using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace EmailSender
{
    internal class SettingsManager
    {
        #region DataMembers 
        public const string CnTo = "To";
        public const string CnCC = "CC";
        public const string CnBC = "BC";
        public const string CnSubject = "Subject";
        public const string CnBody = "Body";
        
        public const string DATA_TABLE_NAME = "MISettings";
        private string filePath = "";
        public DataTable Data = null;
        #endregion

        #region Ctor
        public SettingsManager()
        {
            Init();
        } 
        #endregion

        #region Instance 
        private static SettingsManager instance = null;
        public static SettingsManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SettingsManager();
                }

                return instance;
            }
        } 
        #endregion

        #region Properties 
        public DataRow Row
        {
            get { return Data.Rows[0]; }
        }

        public string To
        {
            get { return Row[CnTo].ToString(); }
            set { Row[CnTo] = value; }
        }

        public string CC
        {
            get { return Row[CnCC].ToString(); }
            set { Row[CnCC] = value; }
        }

        public string BC
        {
            get { return Row[CnBC].ToString(); }
            set { Row[CnBC] = value; }
        }

        public string Subject
        {
            get { return Row[CnSubject].ToString(); }
            set { Row[CnSubject] = value; }
        }

        public string Body
        {
            get { return Row[CnBody].ToString(); }
            set { Row[CnBody] = value; }
        }
        #endregion

        #region Helpers
        private void Init()
        {
            filePath = System.Windows.Forms.Application.StartupPath;
            filePath = Path.Combine(filePath, "Settings.mie");

            Read();
        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable(DATA_TABLE_NAME);
            dt.Columns.Add(CnTo);
            dt.Columns.Add(CnCC);
            dt.Columns.Add(CnBC);
            dt.Columns.Add(CnSubject);
            dt.Columns.Add(CnBody);

            return dt;
        }

        private void AddEmptyRow()
        {
            Data.Rows.Add(new object[] { "", "", "", "", "" });
        }

        private void Read()
        {
            Data = GetData();

            if (!File.Exists(filePath))
            {
                AddEmptyRow();
                
                Save();
            }
            else
            {
                Data.ReadXml(filePath);
            }
        }

        public void Save()
        {
            Data.WriteXml(filePath);
        }
        #endregion
    }
}
