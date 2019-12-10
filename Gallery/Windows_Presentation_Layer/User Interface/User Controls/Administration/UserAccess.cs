using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer.Module.Class;
using Business_Logic_Layer.Module.Method;
using System.Dynamic;
using Data_Access_Layer.Repository;

namespace Windows_Presentation_Layer.User_Interface.User_Controls.Administration
{
    public partial class UserAccess : UserControl
    {
        #region  Business Logic and Data Access Layer Referance
        Method_UserAccess Method_UserAccess = new Method_UserAccess();
        Repository_DataMapper Repository_DataMapper = new Repository_DataMapper();
        Method_Common Method_Common = new Method_Common();
        #endregion

        public UserAccess()
        {
            InitializeComponent();
            LoadPanal();
        }

        public void LoadPanal()
        {
            P_StepOne.Height = 40;
            P_StepTwo.Height = 40;
            P_StepThree.Height = 40;
        }

        CheckBox headerCheckBox = new CheckBox();

        public void LoadClientMaping()
        {
            //DataGridViewCheckBoxColumn Select = new DataGridViewCheckBoxColumn();
            //DGV_ActiveClientMaping.DataSource = null;
            //if (DGV_ActiveClientMaping.Columns.Count >0)
            //{
            //    DGV_ActiveClientMaping.Columns.RemoveAt(0);
            //}

            DataSet dsClientMaping = new DataSet();
            dynamic dyn_Data = new ExpandoObject();
            dyn_Data.ClientStatus = "1";
            dsClientMaping = Repository_DataMapper.LoadClientMaping(dyn_Data);
            DGV_ActiveClientMaping.DataSource = dsClientMaping.Tables[0];
            DGV_ActiveClientMaping.Columns[1].Visible = false;
            DGV_ActiveClientMaping.Columns[3].Visible = false;
            DGV_ActiveClientMaping.Columns[5].Visible = false;
            DGV_ActiveClientMaping.Columns[0].FillWeight = 30;

            ////Add a CheckBox Column to the DataGridView Header Cell.

            ////Find the Location of Header Cell.
            //Point headerCellLocation = this.DGV_ActiveClientMaping.GetCellDisplayRectangle(0, -1, true).Location;

            ////Add a CheckBox Column to the DataGridView at the first position.
            //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            //checkBoxColumn.HeaderText = "";
            //checkBoxColumn.Name = "checkBoxColumn";
            //DGV_ActiveClientMaping.Columns.Insert(0, checkBoxColumn);
            //checkBoxColumn.FillWeight = 15;
            ////Assign Click event to the DataGridView Cell.
            //DGV_ActiveClientMaping.CellContentClick += new DataGridViewCellEventHandler(DataGridView_CellClick);
        }

        //private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //Check to ensure that the row CheckBox is clicked.
        //    if (e.RowIndex >= 0 && e.ColumnIndex == 0)
        //    {
        //        int SelectionCount = 0;
        //        //Loop to verify whether all row CheckBoxes are checked or not.
        //        foreach (DataGridViewRow row in DGV_ActiveClientMaping.Rows)
        //        {
        //            if (Convert.ToBoolean(row.Cells["checkBoxColumn"].EditedFormattedValue) == true )
        //            {
        //                SelectionCount = SelectionCount + 1;
        //            }
        //        }
        //        L_SelectedClientCount.Text = "(" + SelectionCount + ")";
        //    }
        //}

        private void P_HeaderStepOne_Click(object sender, EventArgs e)
        {
            if(P_StepOne.Height == 270)
            {
                P_SelectClient.Visible = false;
                P_StepOne.Height = 40;
            }
            else
            {
                P_StepThree.Height = 40;
                P_StepTwo.Height = 40;
                P_StepOne.Height = 270;
                P_SelectClient.Visible = true;
            }
        }

        private void UserAccess_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                LoadClientMaping();
                LoadUser();
            }
        }

        private void DGV_ActiveClientMaping_Sorted(object sender, EventArgs e)
        {
            //L_SelectedClientCount.Text = "(0)";
        }

        private void RB_AddNewUser_MouseDown(object sender, MouseEventArgs e)
        {
            TB_EmployeeID.Text = null;
            TB_EmployeeName.Text = null;
            P_NewUser.Visible = true;
        }

        private void RB_Save_MouseDown(object sender, MouseEventArgs e)
        {
            AddUser();
        }

        public void AddUser()
        {
            dynamic dyn_Data = new ExpandoObject();
            dyn_Data.EmployeeID = TB_EmployeeID.Text;
            dyn_Data.EmployeeName = TB_EmployeeName.Text;
            Method_UserAccess.AddEmployee(dyn_Data);
            if (Class_Common.MessageBox.Description == "Employee Added")
            {
                P_NewUser.Visible = false;
                LoadUser();
            }
            TabStop = true; TabStop = false;
        }

        public void LoadUser()
        {
            DataSet dsUser = new DataSet();
            dsUser = Repository_DataMapper.LoadUsers();
            DataRow r = dsUser.Tables[0].NewRow(); r["UserID"] = 0; r["Users"] = "-Select-";
            dsUser.Tables[0].Rows.InsertAt(r, 0);
            CB_Users.DataSource = dsUser.Tables[0];
            CB_Users.DisplayMember = "Users";
            CB_Users.ValueMember = "UserID";
            CB_Users.SelectedValue = 0;
        }

        private void DGV_SelectedUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (DGV_SelectedUser.CurrentCell != null)
                {
                    int selectedIndex = DGV_SelectedUser.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        DGV_SelectedUser.Rows.RemoveAt(selectedIndex);
                        DGV_SelectedUser.Refresh();
                        //string Count = ((L_SelectedUsersCount.Text.Split(new Char[] { '(' }))[1].Split(new Char[] { ')' }))[0].ToString();
                        //L_SelectedUsersCount.Text = "(" + (Convert.ToInt32(Count) - 1).ToString() + ")";
                    }
                }
            }
        }

        private void RB_Select_MouseDown(object sender, MouseEventArgs e)
        {
            if (CB_Users.Text != "-Select-")
            {
                dynamic dyn_Data = new ExpandoObject();
                if (DGV_ActiveClientMaping.SelectedCells.Count > 0)
                {
                    int selectedrowindex = DGV_ActiveClientMaping.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = DGV_ActiveClientMaping.Rows[selectedrowindex];
                    dyn_Data.CMapID = Convert.ToString(selectedRow.Cells["CMapID"].Value);
                    dyn_Data.UserID = CB_Users.SelectedValue.ToString();
                    Repository_DataMapper.CheckIsUserAccessExist(dyn_Data);
                    if (Repository_Class.Repository.dv == "1")
                    {
                        Method_Common.ShowNotification("Error", "Access Exit For Selected Client");
                        TabStop = true; TabStop = false;
                    }
                    else
                    {
                        int Result = 0;
                        foreach (DataGridViewRow row in DGV_SelectedUser.Rows)
                        {
                            if (row.Cells[0].Value.ToString() == CB_Users.SelectedValue.ToString())
                            {
                                Result = 1;
                            }
                        }
                        if (Result == 0)
                        {
                            string[] UserInfo = CB_Users.Text.Split(new Char[] { '-' });
                            DGV_SelectedUser.Rows.Add(CB_Users.SelectedValue, UserInfo[0], UserInfo[1]);
                            CB_Users.SelectedIndex = 0;
                            //string Count = ((L_SelectedUsersCount.Text.Split(new Char[] { '(' }))[1].Split(new Char[] { ')' }))[0].ToString();
                            //L_SelectedUsersCount.Text = "(" + (Convert.ToInt32(Count) + 1).ToString() + ")";
                        }
                        else
                        {
                            Method_Common.ShowNotification("Error", "User Already Selected");
                            TabStop = true; TabStop = false;
                        }
                    }
                }
                else
                {
                    Method_Common.ShowNotification("Error", "Please Select Client");
                    TabStop = true; TabStop = false;
                }
            }
        }

        private void P_HeaderStepTwo_Click(object sender, EventArgs e)
        {
            if (P_StepTwo.Height == 270)
            {
                P_SelectUsers.Visible = false;
                P_StepTwo.Height = 40;
            }
            else
            {
                P_StepOne.Height = 40;
                P_StepThree.Height = 40;
                P_StepTwo.Height = 270;
                P_SelectUsers.Visible = true;
            }
        }

        private void L_Close_Click(object sender, EventArgs e)
        {
            P_NewUser.Visible = false;           
        }

        private void P_HeaderStepThree_Click(object sender, EventArgs e)
        {
            if (P_StepThree.Height == 330)
            {
                P_ConfigInfo.Visible = false;
                P_StepThree.Height = 40;
            }
            else
            {
                P_StepOne.Height = 40;
                P_StepTwo.Height = 40;
                P_StepThree.Height = 330;
                P_ConfigInfo.Visible = true;
            }
        }

        private void RB_Upload_MouseDown(object sender, MouseEventArgs e)
        {
            UploadUserAccess();
        }

        public void UploadUserAccess()
        {

        }
    }
    
}
