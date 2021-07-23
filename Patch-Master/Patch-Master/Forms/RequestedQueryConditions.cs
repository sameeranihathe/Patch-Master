using Patch_Master.CustomElements;
using Patch_Master.DbContext.Database;
using Patch_Master.DbContext.QueryReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Patch_Master.Forms
{
    public partial class RequestedQueryConditions : Form
    {
        RequestedQueries requestedQueriesForm;
        string QeryBeforerWhereString;
        int RequestedQueryID;
        public RequestedQueryConditions()
        {
            InitializeComponent();
        }
        public RequestedQueryConditions(List<string> TrimmedConditionsList,string QeryAfterWhere, string QeryBeforerWhere, int PassedRequestedQueryID, RequestedQueries PassedrequestedQueriesForm)
        {
            InitializeComponent();
            requestedQueriesForm = PassedrequestedQueriesForm;
            QeryBeforerWhereString = QeryBeforerWhere;
            RequestedQueryID = PassedRequestedQueryID;
            int LocationY = 50;
            int i = 1;
            foreach (string Condition in TrimmedConditionsList)
            {
                #region get open and close brackets
                int OpenBrackindex = -1;
                int CloseBrackindex = -1;
                string OpenBraket = "";
                string ConditionWTOpenBR = Condition;
                string CloseBraket = "";
                string ConditionWTCloseBR = ConditionWTOpenBR;
                OpenBrackindex = Condition.IndexOf("(");
                if (OpenBrackindex !=-1)
                {
                    OpenBraket = "(";
                    ConditionWTOpenBR = Condition.Remove(OpenBrackindex, 1);
                    ConditionWTOpenBR = ConditionWTOpenBR.Trim();
                }
                CloseBrackindex = ConditionWTOpenBR.IndexOf(")");
                if (CloseBrackindex != -1)
                {
                    CloseBraket = ")";
                    ConditionWTCloseBR = ConditionWTOpenBR.Remove(CloseBrackindex, 1);
                    ConditionWTCloseBR = ConditionWTCloseBR.Trim();
                }
                #endregion
                #region Get Left TableColunm and Value
                String[] spearator = { "=", ">", ">=", "<", "<=", "!=" };
                String[] RightLeftCondition = ConditionWTCloseBR.Split(spearator,
                   StringSplitOptions.RemoveEmptyEntries);
                string LeftTableCulunm = RightLeftCondition[0];
                LeftTableCulunm = LeftTableCulunm.Trim();
                string RightValue = RightLeftCondition[1];
                RightValue =RightValue.Trim();
                #endregion
                #region Get Comparer
                int EndLeftCondition = ConditionWTCloseBR.IndexOf(RightLeftCondition[0]) + RightLeftCondition[0].Length;
                int StartOfRigntCondition = ConditionWTCloseBR.IndexOf(RightLeftCondition[1]);
                string Comparer = ConditionWTCloseBR.Substring(EndLeftCondition, StartOfRigntCondition - EndLeftCondition);
                Comparer = Comparer.Trim();
                #endregion
                #region Get ConditionOparater
                string ConditionOparater="";
                QeryAfterWhere = QeryAfterWhere.Replace(Condition,"");
                QeryAfterWhere = QeryAfterWhere.Trim();
                if (QeryAfterWhere!="")
                {
                    string QeryAfterWhereBeforANDorOR = QeryAfterWhere.Substring(0, QeryAfterWhere.IndexOf(" "));
                    QeryAfterWhere = QeryAfterWhere.Substring(QeryAfterWhere.IndexOf(" ") + 1);
                    QeryAfterWhere = QeryAfterWhere.Trim();
                    ConditionOparater = QeryAfterWhereBeforANDorOR;
                }
                
                #endregion
                
                if (i > 1)
                {
                    LocationY = LocationY + 96;
                }
                #region Groupbox
                customGroupBox ConditionRow = new customGroupBox();
                {
                    ConditionRow.Location = new System.Drawing.Point(26, LocationY);
                    ConditionRow.Name = "GroupConditionRow_" + i;
                    ConditionRow.Size = new System.Drawing.Size(1204, 66);
                    ConditionRow.TabIndex = 0;
                    ConditionRow.TabStop = false;
                    ConditionRow.GroupBoxOrderNumber = i;
                    ConditionRow.Text = "Condition Row";
                    this.Controls.Add(ConditionRow);
                }
                #endregion
                #region Open Bracket 
                TextBox OpenBracket = new TextBox();
                {
                    OpenBracket.Location = new System.Drawing.Point(20, 26);
                   OpenBracket.Name = "OpenBracket_" + i;
                   OpenBracket.Size = new System.Drawing.Size(98, 27);
                    OpenBracket.TabIndex = 1;
                   OpenBracket.ReadOnly = true;
                   OpenBracket.Text = OpenBraket;
                }
                #endregion
                #region TableColunm
                TextBox TableColunm = new TextBox();
                {
                    TableColunm.Location = new System.Drawing.Point(119, 26);
                    TableColunm.Name = "TableColunm_" + i;
                    TableColunm.ReadOnly = true;
                    TableColunm.Size = new System.Drawing.Size(336, 27);
                    TableColunm.Text = LeftTableCulunm;
                    TableColunm.ScrollBars =ScrollBars.Vertical;
                    TableColunm.TabIndex = 2;

                    ToolTip TC = new ToolTip();
                    TC.IsBalloon = true;
                    TC.InitialDelay = 0;
                    TC.ShowAlways = true;
                    TC.SetToolTip(TableColunm, LeftTableCulunm);
                }
                #endregion
                #region Comparer
                ComboBox ComboComparer = new ComboBox();
                {
                    ComboComparer.FormattingEnabled = true;
                    ComboComparer.Location = new System.Drawing.Point(461, 25);
                    ComboComparer.Name = "ComboComparer_" + i;
                    ComboComparer.Size = new System.Drawing.Size(114, 28);
                    ComboComparer.TabIndex = 3;
                    ComboComparer.Text = Comparer;
                    ComboComparer.Items.AddRange(new object[] {
            "like",
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "!="});
                }
                #endregion
                #region Value 
               TextBox Value = new TextBox();
                {
                    Value.Location = new System.Drawing.Point(581, 25);
                    Value.Name = "Value_" + i;
                    Value.Size = new System.Drawing.Size(329, 27);
                    Value.Text = RightValue;
                    Value.TabIndex = 4;

                    ToolTip TC = new ToolTip();
                    TC.IsBalloon = true;
                    TC.InitialDelay = 0;
                    TC.ShowAlways = true;
                    TC.SetToolTip(Value, RightValue);
                }
                #endregion
                #region Close Bracket
                TextBox CloseBracket = new TextBox();
                {
                    CloseBracket.Location = new System.Drawing.Point(923, 25);
                    CloseBracket.Name = "CloseBracket_" + i;
                    CloseBracket.Size = new System.Drawing.Size(98, 27);
                    CloseBracket.TabIndex = 5;
                    CloseBracket.ReadOnly = true;
                    CloseBracket.Text = CloseBraket;
                }
                #endregion
                #region Condition
                TextBox TextCondition = new TextBox();
                {
                    TextCondition.Location = new System.Drawing.Point(1042, 25);
                    TextCondition.Name = "TextCondition_" + i;
                    TextCondition.Size = new System.Drawing.Size(98, 27);
                    TextCondition.TabIndex = 6;
                    TextCondition.ReadOnly = true;
                    TextCondition.Text = ConditionOparater;
                    
                }
                #endregion
                ConditionRow.Controls.Add(OpenBracket);
                ConditionRow.Controls.Add(TableColunm);
                ConditionRow.Controls.Add(ComboComparer);
                ConditionRow.Controls.Add(Value);
                ConditionRow.Controls.Add(CloseBracket);
                ConditionRow.Controls.Add(TextCondition);

                panelRequestedConditions.Controls.Add(ConditionRow);
                i++;
            }
        }
        private void buttonGenarate_Click(object sender, EventArgs e)
        {
            String generateRequestedCondition = GenerateRequestedCondition();
            richTextBoxCondition.Text = generateRequestedCondition;
        }
        private string GenerateRequestedCondition()
        {
            string GenaratedConditionString = "";
            string ConditionString="";
            List<customGroupBox> PannelGroupBoxList = getAllGroupBoxRowConditions();
            PannelGroupBoxList.OrderBy(e => e.GroupBoxOrderNumber);
            foreach (customGroupBox GroupBoxRow in PannelGroupBoxList)
            {
                ConditionString = "";
                foreach (Control ctn in GroupBoxRow.Controls)
                {
                    ConditionString = ConditionString + " " +ctn.Text;
                    ConditionString = ConditionString.Trim();
                }
                GenaratedConditionString = GenaratedConditionString + " " + ConditionString;
            }
            return GenaratedConditionString;
        }
        private List<customGroupBox> getAllGroupBoxRowConditions()
        {
            string ControllerName = "";
            List<customGroupBox> PannelGroupBoxList = new List<customGroupBox>();
            foreach (Control ctn in this.panelRequestedConditions.Controls)
            {
                if (ctn is GroupBox)
                {
                    ControllerName = ctn.Name.ToString();
                        if (ControllerName.Split("_")[0] == "GroupConditionRow")
                        {
                            customGroupBox customGroupBox = (customGroupBox)this.panelRequestedConditions.Controls[ControllerName];
                            PannelGroupBoxList.Add(customGroupBox);
                        }
                }
            }
            return PannelGroupBoxList;
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (richTextBoxCondition.Text != "")
            {
                requestedQueriesForm.richTextBoxQuery.Text = string.Empty;
                string ModifiedQuery = QeryBeforerWhereString + " " + "WHERE " + richTextBoxCondition.Text;
                requestedQueriesForm.richTextBoxQuery.Text = ModifiedQuery;
                UpdateModifiedQuery(ModifiedQuery);
                this.Close();
            }
            else
            {
                string message = "You have not Generated the Modified Conditions. Do you want to exit";
                string title = "Done";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            
        }
        private void UpdateModifiedQuery(string ModifiedQuery)
        {
            DbConnector dbContext = new DbConnector();

            try
            {
                string queryString = SqlQueryStringReader.GetQueryStringById("UpadteModifiedQuery", "RequestedQueries");
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("RequestedQueryID", RequestedQueryID));
                sqlParams.Add(new SqlParameter("ModifiedQueryString", ModifiedQuery));
                var dataReaders = dbContext.ExecuteQueryWithIDataReader(queryString, sqlParams);
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

                dbContext.CloseConnection();
            }
        }
    }
}
