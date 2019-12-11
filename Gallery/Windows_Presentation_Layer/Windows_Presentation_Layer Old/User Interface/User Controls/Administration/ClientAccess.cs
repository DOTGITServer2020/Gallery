using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Dynamic;
using Business_Logic_Layer.Module.Class;
using Business_Logic_Layer.Module.Method;
using Data_Access_Layer.Repository;

namespace Windows_Presentation_Layer.User_Interface.User_Controls.Administration
{
    public partial class ClientAccess : UserControl
    {

        #region  Business Logic and Data Access Layer Referance

        Method_ClientAccess Method_ClientAccess = new Method_ClientAccess();
        Repository_DataMapper Repository_DataMapper = new Repository_DataMapper();
        Method_Common Method_Common = new Method_Common();

        #endregion

        #region  Method

        public ClientAccess()
        {
            InitializeComponent();
        }

        public void MessageBox(string Error)
        {
            Method_Common.ShowNotification("Error", Error);
            TabStop = true; TabStop = false;
        }

        public void LoadClientMaping()
        {
            DataSet dsClientMaping = new DataSet();
            dynamic dyn_Data = new ExpandoObject();
            if (L_ClientStatus.Text == "Active Client")
            {
                dyn_Data.ClientStatus = "1";
            }
            else
            {
                dyn_Data.ClientStatus = "0";
            }
            dsClientMaping = Repository_DataMapper.LoadClientMaping(dyn_Data);
            DGV_ClientMapingInfo.DataSource = dsClientMaping.Tables[0];
            DGV_ClientMapingInfo.Columns[1].Visible = false;
            DGV_ClientMapingInfo.Columns[3].Visible = false;
            DGV_ClientMapingInfo.Columns[5].Visible = false;
            DGV_ClientMapingInfo.Columns[0].FillWeight = 25;

        }

        public void LoadClient()
        {
            DataSet dsClient = new DataSet();
            dsClient = Repository_DataMapper.LoadClient();
            DataRow r = dsClient.Tables[0].NewRow(); r["ClientID"] = 0; r["ClientName"] = "-Select-";
            dsClient.Tables[0].Rows.InsertAt(r, 0);
            CB_Client.DataSource = dsClient.Tables[0];
            CB_Client.DisplayMember = "ClientName";
            CB_Client.ValueMember = "ClientID";
            CB_Client.SelectedValue = 0;
        }

        public void LoadPractice()
        {
            DataSet dsPractice = new DataSet();
            dsPractice = Repository_DataMapper.LoadPractice();
            DataRow r = dsPractice.Tables[0].NewRow(); r["PracticeID"] = 0; r["PracticeName"] = "-Select-";
            dsPractice.Tables[0].Rows.InsertAt(r, 0);
            CB_Practice.DataSource = dsPractice.Tables[0];
            CB_Practice.DisplayMember = "PracticeName";
            CB_Practice.ValueMember = "PracticeID";
            CB_Practice.SelectedValue = 0;
        }

        public void LoadSubPractice()
        {
            DataSet dsSubPractice = new DataSet();
            dsSubPractice = Repository_DataMapper.LoadSubPractice();
            DataRow r = dsSubPractice.Tables[0].NewRow(); r["SubPracticeID"] = 0; r["SubPracticeName"] = "-Select-";
            dsSubPractice.Tables[0].Rows.InsertAt(r, 0);
            CB_SubPractice.DataSource = dsSubPractice.Tables[0];
            CB_SubPractice.DisplayMember = "SubPracticeName";
            CB_SubPractice.ValueMember = "SubPracticeID";
            CB_SubPractice.SelectedValue = 0;
        }

        public void ClientAddOrSave()
        {
            if (B_ClientAddOrSave.Tag.ToString() == "New")
            {
                CB_Client.DropDownStyle = ComboBoxStyle.DropDown;
                CB_Client.Text = null;
                B_ClientAddOrSave.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.S_Save_Green;
                B_ClientAddOrSave.Tag = "Save";
            }
            else if (B_ClientAddOrSave.Tag.ToString() == "Save")
            {
                dynamic dyn_Data = new ExpandoObject();
                dyn_Data.ClientName = CB_Client.Text;
                if (CB_Client.Text == "-Select-")
                {
                    MessageBox("Client Exist");
                }
                else
                {
                    Repository_DataMapper.CheckIsClientExist(dyn_Data);
                    if (Repository_Class.Repository.dv == "1")
                    {
                        MessageBox("Client Exist");
                    }
                    else
                    {
                        Repository_DataMapper.AddClient(dyn_Data);
                        LoadClient();
                        B_ClientAddOrSave.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.New;
                        B_ClientAddOrSave.Tag = "New";
                        CB_Client.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }
            }
        }

        public void PracticeAddOrSave()
        {
            if (B_PracticeAddOrSave.Tag.ToString() == "New")
            {
                CB_Practice.DropDownStyle = ComboBoxStyle.DropDown;
                CB_Practice.Text = null;
                B_PracticeAddOrSave.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.S_Save_Green;
                B_PracticeAddOrSave.Tag = "Save";
            }
            else if (B_PracticeAddOrSave.Tag.ToString() == "Save")
            {
                dynamic dyn_Data = new ExpandoObject();
                dyn_Data.PracticeName = CB_Practice.Text;
                if (CB_Practice.Text == "-Select-")
                {
                    MessageBox("Practice Exist");
                }
                else
                {
                    Repository_DataMapper.CheckIsPracticeExist(dyn_Data);
                    if (Repository_Class.Repository.dv == "1")
                    {
                        MessageBox("Practice Exist");
                    }
                    else
                    {
                        Repository_DataMapper.AddPractice(dyn_Data);
                        LoadPractice();
                        B_PracticeAddOrSave.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.New;
                        B_PracticeAddOrSave.Tag = "New";
                        CB_Practice.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }
            }
        }

        public void SubPracticeAddOrSave()
        {
            if (B_SubPracticeAddOrSave.Tag.ToString() == "New")
            {
                CB_SubPractice.DropDownStyle = ComboBoxStyle.DropDown;
                CB_SubPractice.Text = null;
                B_SubPracticeAddOrSave.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.S_Save_Green;
                B_SubPracticeAddOrSave.Tag = "Save";
            }
            else if (B_SubPracticeAddOrSave.Tag.ToString() == "Save")
            {
                dynamic dyn_Data = new ExpandoObject();
                dyn_Data.SubPracticeName = CB_SubPractice.Text;
                if (CB_SubPractice.Text == "-Select-")
                {
                    MessageBox("SubPractice Exist");
                }
                else
                {
                    Repository_DataMapper.CheckIsSubPracticeExist(dyn_Data);
                    if (Repository_Class.Repository.dv == "1")
                    {
                        MessageBox("SubPractice Exist");
                    }
                    else
                    {
                        Repository_DataMapper.AddSubPractice(dyn_Data);
                        LoadSubPractice();
                        B_SubPracticeAddOrSave.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.New;
                        B_SubPracticeAddOrSave.Tag = "New";
                        CB_SubPractice.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }
            }
        }

        public void ClientMaping()
        {
            if ((B_ClientAddOrSave.Tag).ToString() == "Save")
            {
                MessageBox("Please Save Client");
            }
            else if ((B_PracticeAddOrSave.Tag).ToString() == "Save")
            {
                MessageBox("Please Save Practice");
            }
            else if ((B_SubPracticeAddOrSave.Tag).ToString() == "Save")
            {
                MessageBox("Please Save SubPractice");
            }
            else if (CB_Client.SelectedValue.ToString() == "0")
            {
                MessageBox("Client Not Selected");
            }
            else if (CB_Practice.SelectedValue.ToString() == "0")
            {
                MessageBox("Practice Not Selected");
            }
            else if (CB_SubPractice.SelectedValue.ToString() == "0")
            {
                MessageBox("SubPractice Not Selected");
            }
            else
            {
                dynamic dyn_Data = new ExpandoObject();
                dyn_Data.ClientID = CB_Client.SelectedValue.ToString();
                dyn_Data.PracticeID = CB_Practice.SelectedValue.ToString();
                dyn_Data.SubPracticeID = CB_SubPractice.SelectedValue.ToString();
                Method_ClientAccess.MapClientPracticeSubPractice(dyn_Data);
                if (Class_Common.Execute.E_Method == "MessageBox")
                {
                    if (Class_Common.MessageBox.Description == "Updated Sucessfully")
                    {
                        P_Shadow.Visible = false;
                        P_Front.Visible = false;
                        LoadClientMaping();
                    }
                }
                TabStop = true; TabStop = false;
            }
        }

        public void ClientStatusChange()
        {
            if (L_Status.Text == "DeActivate")
            {
                if (DGV_ClientMapingInfo.SelectedCells.Count > 0)
                {
                    int selectedrowindex = DGV_ClientMapingInfo.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = DGV_ClientMapingInfo.Rows[selectedrowindex];
                    dynamic dyn_Data = new ExpandoObject();
                    dyn_Data.CMapID = Convert.ToString(selectedRow.Cells["CMapID"].Value);
                    Repository_DataMapper.DeActivateClientMaping(dyn_Data);
                    LoadClientMaping();
                    Method_Common.ShowNotification("Success", "DeActivated Sucessfully");
                    TabStop = true; TabStop = false;
                }
            }
            else
            {
                if (DGV_ClientMapingInfo.SelectedCells.Count > 0)
                {
                    int selectedrowindex = DGV_ClientMapingInfo.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = DGV_ClientMapingInfo.Rows[selectedrowindex];
                    dynamic dyn_Data = new ExpandoObject();
                    dyn_Data.CMapID = Convert.ToString(selectedRow.Cells["CMapID"].Value);
                    Repository_DataMapper.ActivateClientMaping(dyn_Data);
                    LoadClientMaping();
                    Method_Common.ShowNotification("Success", "Activated Sucessfully");
                    TabStop = true; TabStop = false;
                }
            }
            
        }

        public void ClientStatus()
        {
            if (L_ClientStatus.Text == "Active Client")
            {
                L_ClientStatus.Text = "InActive Client";
                L_Status.Text = "Activate";
                B_ClientSatus.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.Toggle_Off;
                B_Status.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.R_Save_Green;
            }
            else
            {
                L_ClientStatus.Text = "Active Client";
                L_Status.Text = "DeActivate";
                B_ClientSatus.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.Toggle_On;
                B_Status.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.Block;
            }
            LoadClientMaping();
        }

        #endregion

        #region  Event

        private void B_New_Click(object sender, EventArgs e)
        {
            LoadClient();
            LoadPractice();
            LoadSubPractice();
            P_Front.Visible = true;
            P_Shadow.Visible = true;
        }

        private void L_Close_Click(object sender, EventArgs e)
        {
            B_ClientAddOrSave.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.New;
            B_ClientAddOrSave.Tag = "New";
            CB_Client.DropDownStyle = ComboBoxStyle.DropDownList;
            B_PracticeAddOrSave.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.New;
            B_PracticeAddOrSave.Tag = "New";
            CB_Practice.DropDownStyle = ComboBoxStyle.DropDownList;
            B_SubPracticeAddOrSave.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.New;
            B_SubPracticeAddOrSave.Tag = "New";
            CB_SubPractice.DropDownStyle = ComboBoxStyle.DropDownList;
            P_Shadow.Visible = false;
            P_Front.Visible = false;
        }

        private void B_ClientAddOrSave_Click(object sender, EventArgs e)
        {
            ClientAddOrSave();
        }

        private void B_PracticeAddOrSave_Click(object sender, EventArgs e)
        {
            PracticeAddOrSave();
        }

        private void B_SubPracticeAddOrSave_Click(object sender, EventArgs e)
        {
            SubPracticeAddOrSave();
        }

        private void RB_ClientMaping_MouseDown(object sender, MouseEventArgs e)
        {
            ClientMaping();
        }

        private void ClientAccess_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                L_ClientStatus.Text = "Active Client";
                L_Status.Text = "DeActivate";
                B_ClientSatus.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.Toggle_On;
                B_Status.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.Block;
                LoadClientMaping();
            }
        }

        private void B_ClientSatus_Click(object sender, EventArgs e)
        {
            ClientStatus();
        }

        private void B_Status_Click(object sender, EventArgs e)
        {
            ClientStatusChange();
        }



        #endregion

    }
}
