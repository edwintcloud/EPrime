using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPrime
{
    public partial class adminForm : Form
    {
        private int role = 0;
        private string user = "";

        public class Option
        {
            public string Text { get; set; }
            public string StepID { get; set; }
        }

        public adminForm(string user, int role)
        {
            InitializeComponent();
            this.role = role;
            this.user = user;
            Text += " - " + user;
            setRole ();
            fillTabs();
        }

        private void setRole()
        {
            switch(role)
            {
                case 0:
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Add(tabPage1);
                    tabControl1.TabPages.Add(tabPage5);
                    deleteticketBtn.Visible = false;
                    wipeticketsBtn.Visible = false;
                    break;
                case 1:
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Add(tabPage1);
                    tabControl1.TabPages.Add(tabPage2);
                    tabControl1.TabPages.Add(tabPage3);
                    tabControl1.TabPages.Add(tabPage4);
                    tabControl1.TabPages.Add(tabPage5);
                    tabControl1.TabPages.Add(tabPage6);
                    deleteticketBtn.Visible = true;
                    wipeticketsBtn.Visible = true;
                    break;
            }
            
        }
        private void setDefaults(string tab)
        {
            switch (tab) {
                case "steps":
                    stepidBox.Text = "";
                    prevstepidBox.Text = "";
                    settextBox.Text = "";
                    steptypeCombo.DataSource = new List<string> {"Drop-Down Options", "Text Input"};
                    setfieldsidBox.Text = "";
                    stepsoptionsTable.DataSource = null;
                    stepsaddoptionBtn.Visible = false;
                    stepsdeleteoptionBtn.Visible = false;
                    yesbtnlblBox.Text = "";
                    yesbtnstepidBox.Text = "";
                    nobtnlblBox.Text = "";
                    nobtnstepidBox.Text = "";
                    helptxtBox.Text = "";
                    stepsBtn1.Visible = false;
                    stepsBtn2.Text = "Delete";
                    stepsBtn2.ForeColor = Color.Black;
                    stepsBtn2.Visible = false;
                    stepsBtn3.Visible = false;
                    stepsBtn4.Text = "Add";
                    stepsBtn4.Visible = true;
                    stepsTable.Enabled = true;
                    break;
                case "fields":
                    break;
                case "users":
                    break;
            }  
        }
        private void fillTabs()
        {
            var conn = new MySql();

            try
            {

                //Tickets
                ticketsTable.DataSource = testClass.ToDataTable(conn.GetTickets());
                searchticketsCombo.DataSource = ticketsTable.Columns.OfType<DataGridViewColumn>().Select(f => f.HeaderText).ToList();

                //Errors
                errorsTable.DataSource = testClass.ToDataTable(conn.GetErrors());
                searcherrorsCombo.DataSource = errorsTable.Columns.OfType<DataGridViewColumn>().Select(f => f.HeaderText).ToList();

                if (role == 1)
                {
                    //Buttons
                    var buttons = conn.GetButtons();
                    button1lblBox.Text = buttons[0].label;
                    button1ivCombo.SelectedItem = buttons[0].visible.ToString();
                    button1siBox.Text = buttons[0].stepid.ToString();
                    button2lblBox.Text = buttons[1].label;
                    button2ivCombo.SelectedItem = buttons[1].visible.ToString();
                    button2siBox.Text = buttons[1].stepid.ToString();
                    button3lblBox.Text = buttons[2].label;
                    button3ivCombo.SelectedItem = buttons[2].visible.ToString();
                    button3siBox.Text = buttons[2].stepid.ToString();
                    button4lblBox.Text = buttons[3].label;
                    button4ivCombo.SelectedItem = buttons[3].visible.ToString();
                    button4siBox.Text = buttons[3].stepid.ToString();
                    button5lblBox.Text = buttons[4].label;
                    button5ivCombo.SelectedItem = buttons[4].visible.ToString();
                    button5siBox.Text = buttons[4].stepid.ToString();
                    button6lblBox.Text = buttons[5].label;
                    button6ivCombo.SelectedItem = buttons[5].visible.ToString();
                    button6siBox.Text = buttons[5].stepid.ToString();
                    button7lblBox.Text = buttons[6].label;
                    button7ivCombo.SelectedItem = buttons[6].visible.ToString();
                    button7siBox.Text = buttons[6].stepid.ToString();
                    button8lblBox.Text = buttons[7].label;
                    button8ivCombo.SelectedItem = buttons[7].visible.ToString();
                    button8siBox.Text = buttons[7].stepid.ToString();
                    button9lblBox.Text = buttons[8].label;
                    button9ivCombo.SelectedItem = buttons[8].visible.ToString();
                    button9siBox.Text = buttons[8].stepid.ToString();
                    button10lblBox.Text = buttons[9].label;
                    button10ivCombo.SelectedItem = buttons[9].visible.ToString();
                    button10siBox.Text = buttons[9].stepid.ToString();
                    button11lblBox.Text = buttons[10].label;
                    button11ivCombo.SelectedItem = buttons[10].visible.ToString();
                    button11siBox.Text = buttons[10].stepid.ToString();
                    button12lblBox.Text = buttons[11].label;
                    button12ivCombo.SelectedItem = buttons[11].visible.ToString();
                    button12siBox.Text = buttons[11].stepid.ToString();

                    //Steps
                    stepsTable.DataSource = testClass.ToDataTable(conn.GetSteps());
                    searchstepsCombo.DataSource = stepsTable.Columns.OfType<DataGridViewColumn>().Select(f => f.HeaderText).ToList();

                    //Fields
                    fieldsTable.DataSource = testClass.ToDataTable(conn.GetFields());
                    searchfieldsCombo.DataSource = fieldsTable.Columns.OfType<DataGridViewColumn>().Select(f => f.HeaderText).ToList();

                    //Users
                    usersTable.DataSource = testClass.ToDataTable(conn.GetUsers());
                    searchusersCombo.DataSource = usersTable.Columns.OfType<DataGridViewColumn>().Select(f => f.HeaderText).ToList();
                }
            }catch(Exception e)
            {
                FileOps.WriteLog("AdminForm.fillTabs() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        private void ticketsTable_SelectionChanged(object sender, EventArgs e)
        {
            if (ticketsTable.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = ticketsTable.Rows[ticketsTable.SelectedCells[0].RowIndex];
                datetimeBox.Text = Convert.ToString(selectedRow.Cells["DateTime"].Value);
                incidentidBox.Text = Convert.ToString(selectedRow.Cells["IncidentID"].Value);
                ownedbyBox.Text = Convert.ToString(selectedRow.Cells["OwnedBy"].Value);
                emailBox.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
                fullnameBox.Text = Convert.ToString(selectedRow.Cells["FullName"].Value);
                campusBox.Text = Convert.ToString(selectedRow.Cells["Campus"].Value);
                ssnBox.Text = Convert.ToString(selectedRow.Cells["SSN"].Value);
                statusBox.Text = Convert.ToString(selectedRow.Cells["Status"].Value);
                lastactionBox.Text = Convert.ToString(selectedRow.Cells["LastAction"].Value);
                resolvetimeBox.Text = Convert.ToString(selectedRow.Cells["Time"].Value);
                subjectBox.Text = Convert.ToString(selectedRow.Cells["Subject"].Value);
                descriptionBox.Text = Convert.ToString(selectedRow.Cells["Description"].Value);
                resolutionBox.Text = Convert.ToString(selectedRow.Cells["Resolution"].Value);
                serviceBox.Text = Convert.ToString(selectedRow.Cells["Service"].Value);
                categoryBox.Text = Convert.ToString(selectedRow.Cells["Category"].Value);
                subcategoryBox.Text = Convert.ToString(selectedRow.Cells["Subcategory"].Value);
                priorityBox.Text = Convert.ToString(selectedRow.Cells["Priority"].Value);
                impactBox.Text = Convert.ToString(selectedRow.Cells["Impact"].Value);
                urgencyBox.Text = Convert.ToString(selectedRow.Cells["Urgency"].Value);
                courseidBox.Text = Convert.ToString(selectedRow.Cells["CourseID"].Value);
                lmssystemBox.Text = Convert.ToString(selectedRow.Cells["LMSSystem"].Value);
            } else
            {
                datetimeBox.Text = "";
                incidentidBox.Text = "";
                ownedbyBox.Text = "";
                emailBox.Text = "";
                fullnameBox.Text = "";
                campusBox.Text = "";
                ssnBox.Text = "";
                statusBox.Text = "";
                lastactionBox.Text = "";
                resolvetimeBox.Text = "";
                subjectBox.Text = "";
                descriptionBox.Text = "";
                resolutionBox.Text = "";
                serviceBox.Text = "";
                categoryBox.Text = "";
                subcategoryBox.Text = "";
                priorityBox.Text = "";
                impactBox.Text = "";
                urgencyBox.Text = "";
                courseidBox.Text = "";
                lmssystemBox.Text = "";
            }
        }

        private void deleteticketBtn_Click(object sender, EventArgs e)
        {
            if (ticketsTable.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = ticketsTable.Rows[ticketsTable.SelectedCells[0].RowIndex];
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete incident #" + Convert.ToString(selectedRow.Cells["IncidentID"].Value) + "? This action is irreversible!!" , "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var conn = new MySql();
                    conn.DeleteTicket(Convert.ToString(selectedRow.Cells["IncidentID"].Value));
                    int selRow = ticketsTable.CurrentCell.RowIndex;
                    if (ticketsTable.Rows.Count > 1) selRow = ticketsTable.CurrentCell.RowIndex - 1;
                    ticketsTable.DataSource = testClass.ToDataTable(conn.GetTickets());
                    if(ticketsTable.Rows.Count > 1) ticketsTable.CurrentCell = ticketsTable.Rows[selRow].Cells[0];
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void searchticketsBox_TextChanged(object sender, EventArgs e)
        {
            var conn = new MySql();
            List<MySql.Ticket> list = conn.GetTickets();
            DataTable dt = testClass.ToDataTable(list);
            dt.DefaultView.RowFilter = string.Format(searchticketsCombo.SelectedItem.ToString() + " like '%{0}%'", searchticketsBox.Text.Trim().Replace("'", "''"));
            ticketsTable.DataSource = dt;
        }

        private void wipeticketsBtn_Click(object sender, EventArgs e)
        {
            if (ticketsTable.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = ticketsTable.Rows[ticketsTable.SelectedCells[0].RowIndex];
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to purge all tickets? This action is irreversible!!", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var conn = new MySql();
                    conn.PurgeTickets();
                    ticketsTable.DataSource = testClass.ToDataTable(conn.GetTickets());
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void refreshticketsBtn_Click(object sender, EventArgs e)
        {
            var conn = new MySql();
            int selRow = ticketsTable.CurrentCell.RowIndex;
            ticketsTable.DataSource = testClass.ToDataTable(conn.GetTickets());
            ticketsTable.CurrentCell = ticketsTable.Rows[selRow].Cells[0];
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedIndex)
            {
                case 1:
                    AcceptButton = buttonssaveBtn;
                    break;
                case 2:
                    AcceptButton = stepsBtn4;
                    setDefaults("steps");
                    break;
            }
        }

        private void buttonsrevertBtn_Click(object sender, EventArgs e)
        {
            var buttons = new MySql().GetButtons();
            button1lblBox.Text = buttons[0].label;
            button1ivCombo.SelectedItem = buttons[0].visible.ToString();
            button1siBox.Text = buttons[0].stepid.ToString();
            button2lblBox.Text = buttons[1].label;
            button2ivCombo.SelectedItem = buttons[1].visible.ToString();
            button2siBox.Text = buttons[1].stepid.ToString();
            button3lblBox.Text = buttons[2].label;
            button3ivCombo.SelectedItem = buttons[2].visible.ToString();
            button3siBox.Text = buttons[2].stepid.ToString();
            button4lblBox.Text = buttons[3].label;
            button4ivCombo.SelectedItem = buttons[3].visible.ToString();
            button4siBox.Text = buttons[3].stepid.ToString();
            button5lblBox.Text = buttons[4].label;
            button5ivCombo.SelectedItem = buttons[4].visible.ToString();
            button5siBox.Text = buttons[4].stepid.ToString();
            button6lblBox.Text = buttons[5].label;
            button6ivCombo.SelectedItem = buttons[5].visible.ToString();
            button6siBox.Text = buttons[5].stepid.ToString();
            button7lblBox.Text = buttons[6].label;
            button7ivCombo.SelectedItem = buttons[6].visible.ToString();
            button7siBox.Text = buttons[6].stepid.ToString();
            button8lblBox.Text = buttons[7].label;
            button8ivCombo.SelectedItem = buttons[7].visible.ToString();
            button8siBox.Text = buttons[7].stepid.ToString();
            button9lblBox.Text = buttons[8].label;
            button9ivCombo.SelectedItem = buttons[8].visible.ToString();
            button9siBox.Text = buttons[8].stepid.ToString();
            button10lblBox.Text = buttons[9].label;
            button10ivCombo.SelectedItem = buttons[9].visible.ToString();
            button10siBox.Text = buttons[9].stepid.ToString();
            button11lblBox.Text = buttons[10].label;
            button11ivCombo.SelectedItem = buttons[10].visible.ToString();
            button11siBox.Text = buttons[10].stepid.ToString();
            button12lblBox.Text = buttons[11].label;
            button12ivCombo.SelectedItem = buttons[11].visible.ToString();
            button12siBox.Text = buttons[11].stepid.ToString();
        }
        private async void Blink(string tab)
        {
            switch (tab)
            {
                case "buttons":
                    buttonsstatusLbl.Visible = true;
                    await Task.Delay(700);
                    buttonsstatusLbl.Visible = false;
                    break;
                case "steps":
                    stepsstatusLbl.Visible = true;
                    await Task.Delay(700);
                    stepsstatusLbl.Visible = false;
                    break;
                case "fields":
                    fieldsstatusLbl.Visible = true;
                    await Task.Delay(700);
                    fieldsstatusLbl.Visible = false;
                    break;
                case "users":
                    usersstatusLbl.Visible = true;
                    await Task.Delay(700);
                    usersstatusLbl.Visible = false;
                    break;
            }
        }

        private void buttonssaveBtn_Click(object sender, EventArgs e)
        {
            var conn = new MySql();
            conn.UpdateButton(1, button1lblBox.Text, button1ivCombo.SelectedItem.ToString(), button1siBox.Text);
            conn.UpdateButton(2, button2lblBox.Text, button2ivCombo.SelectedItem.ToString(), button2siBox.Text);
            conn.UpdateButton(3, button3lblBox.Text, button3ivCombo.SelectedItem.ToString(), button3siBox.Text);
            conn.UpdateButton(4, button4lblBox.Text, button4ivCombo.SelectedItem.ToString(), button4siBox.Text);
            conn.UpdateButton(5, button5lblBox.Text, button5ivCombo.SelectedItem.ToString(), button5siBox.Text);
            conn.UpdateButton(6, button6lblBox.Text, button6ivCombo.SelectedItem.ToString(), button6siBox.Text);
            conn.UpdateButton(7, button7lblBox.Text, button7ivCombo.SelectedItem.ToString(), button7siBox.Text);
            conn.UpdateButton(8, button8lblBox.Text, button8ivCombo.SelectedItem.ToString(), button8siBox.Text);
            conn.UpdateButton(9, button9lblBox.Text, button9ivCombo.SelectedItem.ToString(), button9siBox.Text);
            conn.UpdateButton(10, button10lblBox.Text, button10ivCombo.SelectedItem.ToString(), button10siBox.Text);
            conn.UpdateButton(11, button11lblBox.Text, button11ivCombo.SelectedItem.ToString(), button11siBox.Text);
            conn.UpdateButton(12, button12lblBox.Text, button12ivCombo.SelectedItem.ToString(), button12siBox.Text);
            Blink("buttons");
        }

        private void buttonssiBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stepsBtn4_Click(object sender, EventArgs e)
        {
            if(stepsBtn4.Text == "Cancel")
            {
                setDefaults("steps");
                return;
            }
            stepidBox.Text = "";
            prevstepidBox.Text = "";
            settextBox.Text = "";
            steptypeCombo.DataSource = new List<string> { "Drop-Down Options", "Text Input" };
            setfieldsidBox.Text = "";
            stepsoptionsTable.DataSource = null;
            stepsaddoptionBtn.Visible = false;
            stepsdeleteoptionBtn.Visible = false;
            yesbtnlblBox.Text = "";
            yesbtnstepidBox.Text = "";
            nobtnlblBox.Text = "";
            nobtnstepidBox.Text = "";
            helptxtBox.Text = "";
            stepsaddoptionBtn.Visible = true;
            stepsdeleteoptionBtn.Visible = true;
            stepsBtn1.Visible = false;
            stepsBtn2.Text = "Revert";
            stepsBtn2.ForeColor = Color.Red;
            stepsBtn2.Visible = true;
            stepsBtn3.Visible = true;
            stepsBtn4.Text = "Cancel";
            stepsBtn4.Visible = true;
            stepsTable.Enabled = false;
        }

        private void searchstepsBox_TextChanged(object sender, EventArgs e)
        {
            var conn = new MySql();
            List<MySql.Step> list = conn.GetSteps();
            DataTable dt = testClass.ToDataTable(list);
            dt.DefaultView.RowFilter = string.Format(searchstepsCombo.SelectedItem.ToString() + " like '%{0}%'", searchstepsBox.Text.Trim().Replace("'", "''"));
            ticketsTable.DataSource = dt;
        }

        private void searchfieldsBox_TextChanged(object sender, EventArgs e)
        {
            var conn = new MySql();
            List<MySql.Field> list = conn.GetFields();
            DataTable dt = testClass.ToDataTable(list);
            dt.DefaultView.RowFilter = string.Format(searchfieldsCombo.SelectedItem.ToString() + " like '%{0}%'", searchfieldsBox.Text.Trim().Replace("'", "''"));
            ticketsTable.DataSource = dt;
        }

        private void searcherrorsBox_TextChanged(object sender, EventArgs e)
        {
            var conn = new MySql();
            List<MySql.Error> list = conn.GetErrors();
            DataTable dt = testClass.ToDataTable(list);
            dt.DefaultView.RowFilter = string.Format(searcherrorsCombo.SelectedItem.ToString() + " like '%{0}%'", searcherrorsBox.Text.Trim().Replace("'", "''"));
            ticketsTable.DataSource = dt;
        }

        private void searchusersBox_TextChanged(object sender, EventArgs e)
        {
            var conn = new MySql();
            List<MySql.User> list = conn.GetUsers();
            DataTable dt = testClass.ToDataTable(list);
            dt.DefaultView.RowFilter = string.Format(searchusersCombo.SelectedItem.ToString() + " like '%{0}%'", searchusersBox.Text.Trim().Replace("'", "''"));
            ticketsTable.DataSource = dt;
        }

        private void stepsTable_SelectionChanged(object sender, EventArgs e)
        {
            if (stepsTable.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = stepsTable.Rows[stepsTable.SelectedCells[0].RowIndex];
                stepidBox.Text = Convert.ToString(selectedRow.Cells["StepID"].Value);
                prevstepidBox.Text = Convert.ToString(selectedRow.Cells["PreviousStepID"].Value);
                settextBox.Text = Convert.ToString(selectedRow.Cells["SetText"].Value);
                steptypeCombo.DataSource = new List<string> { "Drop-Down Options", "Text Input" };
                steptypeCombo.SelectedIndex = Convert.ToInt32(selectedRow.Cells["ShowEdit"].Value);
                setfieldsidBox.Text = Convert.ToString(selectedRow.Cells["SetFieldsID"].Value);
                if (steptypeCombo.SelectedIndex == 1 || (Convert.ToString(selectedRow.Cells["Options"].Value).Length) < 1) {
                    stepsoptionsTable.DataSource = null;
                    if (steptypeCombo.SelectedIndex != 1)
                    {
                        stepsaddoptionBtn.Visible = true;
                        stepsdeleteoptionBtn.Visible = true;
                    } else
                    {
                        stepsaddoptionBtn.Visible = false;
                        stepsdeleteoptionBtn.Visible = false;
                    }
                } else
                {
                    var optionslist = new List<Option>();
                    string[] options = Convert.ToString(selectedRow.Cells["Options"].Value).Split(',');
                    string[] optionsSteps = Convert.ToString(selectedRow.Cells["OptionsSteps"].Value).Split(',');
                    foreach(string s in options) { 
                        optionslist.Add(new Option() {
                            Text = s
                        });
                    }
                    for(int i=0;i<optionsSteps.Length;i++)
                    {
                        optionslist[i].StepID = optionsSteps[i];
                    }
                    stepsaddoptionBtn.Visible = true;
                    stepsdeleteoptionBtn.Visible = true;
                    stepsoptionsTable.DataSource = testClass.ToDataTable(optionslist);
                }                
                yesbtnlblBox.Text = Convert.ToString(selectedRow.Cells["YesButtonText"].Value);
                yesbtnstepidBox.Text = Convert.ToString(selectedRow.Cells["YesStepID"].Value);
                nobtnlblBox.Text = Convert.ToString(selectedRow.Cells["NoButtonText"].Value);
                nobtnstepidBox.Text = Convert.ToString(selectedRow.Cells["NoStepID"].Value);
                helptxtBox.Text = Convert.ToString(selectedRow.Cells["HelpText"].Value);
                stepsBtn1.Visible = true;
                stepsBtn2.Text = "Delete";
                stepsBtn2.ForeColor = Color.Black;
                stepsBtn2.Visible = true;
                stepsBtn3.Visible = true;
                stepsBtn4.Text = "Add";
                stepsBtn4.Visible = true;
                stepsTable.Enabled = true;
            }
            else
            {
                setDefaults("steps");
            }
        }

        private void purgeerrorsBtn_Click(object sender, EventArgs e)
        {

        }

        private void steptypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (steptypeCombo.SelectedIndex != 1)
            {
                if (stepsTable.SelectedCells.Count > 0)
                {
                    if ((Convert.ToString(stepsTable.SelectedRows[0].Cells["Options"].Value)).Length < 1)
                    {
                        stepsoptionsTable.DataSource = null;
                        if (steptypeCombo.SelectedIndex != 1)
                        {
                            stepsaddoptionBtn.Visible = true;
                            stepsdeleteoptionBtn.Visible = true;
                        }
                        else
                        {
                            stepsaddoptionBtn.Visible = false;
                            stepsdeleteoptionBtn.Visible = false;
                        }
                    }
                    else
                    {
                        var optionslist = new List<Option>();
                        string[] options = Convert.ToString(stepsTable.SelectedRows[0].Cells["Options"].Value).Split(',');
                        string[] optionsSteps = Convert.ToString(stepsTable.SelectedRows[0].Cells["OptionsSteps"].Value).Split(',');
                        foreach (string s in options)
                        {
                            optionslist.Add(new Option()
                            {
                                Text = s
                            });
                        }
                        for (int i = 0; i < optionsSteps.Length; i++)
                        {
                            optionslist[i].StepID = optionsSteps[i];
                        }
                        stepsaddoptionBtn.Visible = true;
                        stepsdeleteoptionBtn.Visible = true;
                        stepsoptionsTable.DataSource = testClass.ToDataTable(optionslist);
                    }
                }
                stepsaddoptionBtn.Visible = true;
                stepsdeleteoptionBtn.Visible = true;
            }
            else
            {
                stepsoptionsTable.DataSource = null;
                stepsaddoptionBtn.Visible = false;
                stepsdeleteoptionBtn.Visible = false;
            }
        }

        private void helptxtBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void settextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void stepsaddoptionBtn_Click(object sender, EventArgs e)
        {
            var oForm = new OptionsForm(-1, "", "", this);
            oForm.Show();
        }

        internal void setOptions(int index,string text, string id)
        {
            if(stepsoptionsTable.DataSource == null)
            {
                var list = new List<Option>();
                list.Add(new Option() {
                    Text = text,
                    StepID = id
                });
                stepsoptionsTable.DataSource = testClass.ToDataTable(list);
            } else
            {              
                DataTable dt = (DataTable)stepsoptionsTable.DataSource;
                if(index >= 0) dt.Rows.RemoveAt(index);
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = text;
                dr[1] = id;
                if (index >= 0)
                {
                    dt.Rows.InsertAt(dr, index);
                }else
                {
                    dt.Rows.Add(dr);
                }
                stepsoptionsTable.DataSource = dt;
                if (index == -1)
                {
                    stepsoptionsTable.CurrentCell = stepsoptionsTable.Rows[stepsoptionsTable.Rows.Count-1].Cells[0];
                }
                else
                {
                    stepsoptionsTable.CurrentCell = stepsoptionsTable.Rows[index].Cells[0];
                }
            }
        }

        private void stepsoptionsTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stepsoptionsTable.SelectedCells.Count > 0)
            {
                var oForm = new OptionsForm(stepsoptionsTable.SelectedRows[0].Index, Convert.ToString(stepsoptionsTable.SelectedRows[0].Cells["Text"].Value), Convert.ToString(stepsoptionsTable.SelectedRows[0].Cells["StepID"].Value), this);
                oForm.Show();
            } 
        }

        private void refreshstepsBtn_Click(object sender, EventArgs e)
        {
            var conn = new MySql();
            int selRow = stepsTable.CurrentCell.RowIndex;
            stepsTable.DataSource = testClass.ToDataTable(conn.GetSteps());
            stepsTable.CurrentCell = stepsTable.Rows[selRow].Cells[0];
        }

        private void stepsdeleteoptionBtn_Click(object sender, EventArgs e)
        {
            if (stepsoptionsTable.SelectedRows.Count > 0)
            {
                DataTable dt = (DataTable)stepsoptionsTable.DataSource;
                int selRow = 0;
                if (stepsoptionsTable.Rows.Count > 1) selRow = stepsoptionsTable.CurrentCell.RowIndex - 1;
                dt.Rows.RemoveAt(stepsoptionsTable.CurrentCell.RowIndex);
                stepsoptionsTable.DataSource = dt;
                if (stepsoptionsTable.Rows.Count > 1) stepsoptionsTable.CurrentCell = stepsoptionsTable.Rows[selRow].Cells[0];
            }
        }

        private void stepsBtn3_Click(object sender, EventArgs e)
        {
            var conn = new MySql();
            int showedit = 0;
            int selRow = 0;
            string options = "";
            string optionssteps = "";

            if (stepsBtn4.Text == "Cancel")
            {
                options = "";
                optionssteps = "";
                if (stepsoptionsTable.Rows.Count > 0)
                {
                    for (int i = 0; i < stepsoptionsTable.Rows.Count; i++)
                    {
                        string del = ",";
                        if (i == stepsoptionsTable.Rows.Count-1) del = "";
                        DataGridViewRow selectedRow = stepsoptionsTable.Rows[stepsoptionsTable.SelectedCells[i].RowIndex];
                        options += (Convert.ToString(selectedRow.Cells["Text"].Value) + del);
                        optionssteps += (Convert.ToString(selectedRow.Cells["StepID"].Value) + del);
                    }
                }
                showedit = 0;
                if (steptypeCombo.SelectedItem.ToString() == "Text Input") showedit = 1;   
                conn.AddStep(settextBox.Text, options, optionssteps, yesbtnlblBox.Text, nobtnlblBox.Text, showedit, testClass.ParseInt(yesbtnstepidBox.Text), testClass.ParseInt(nobtnstepidBox.Text), testClass.ParseInt(setfieldsidBox.Text), testClass.ParseInt(prevstepidBox.Text), helptxtBox.Text);
                stepsstatusLbl.Text = "Step Successfully Added!";
                selRow = stepsTable.CurrentCell.RowIndex;
                stepsTable.DataSource = testClass.ToDataTable(conn.GetSteps());
                stepsTable.CurrentCell = stepsTable.Rows[selRow].Cells[0];
                Blink("steps");
                setDefaults("steps");
                return;
            }

            options = "";
            optionssteps = "";
            if (stepsoptionsTable.Rows.Count > 0)
            {
                for (int i = 0; i < stepsoptionsTable.Rows.Count; i++)
                {
                    string del = ",";
                    if (i == stepsoptionsTable.Rows.Count-1) del = "";
                    DataGridViewRow selectedRow = stepsoptionsTable.Rows[stepsoptionsTable.SelectedCells[i].RowIndex];
                    options += (Convert.ToString(selectedRow.Cells["Text"].Value) + del);
                    optionssteps += (Convert.ToString(selectedRow.Cells["StepID"].Value) + del);
                }
            }
            showedit = 0;
            if (steptypeCombo.SelectedItem.ToString() == "Text Input") showedit = 1;
            conn.UpdateStep(testClass.ParseInt(stepidBox.Text),settextBox.Text, options, optionssteps, yesbtnlblBox.Text, nobtnlblBox.Text, showedit, testClass.ParseInt(yesbtnstepidBox.Text), testClass.ParseInt(nobtnstepidBox.Text), testClass.ParseInt(setfieldsidBox.Text), testClass.ParseInt(prevstepidBox.Text), helptxtBox.Text);
            stepsstatusLbl.Text = "Step Successfully Updated!";
            selRow = stepsTable.CurrentCell.RowIndex;
            stepsTable.DataSource = testClass.ToDataTable(conn.GetSteps());
            stepsTable.CurrentCell = stepsTable.Rows[selRow].Cells[0];
            Blink("steps");
        }

        private void stepsBtn2_Click(object sender, EventArgs e)
        {
            if (stepsBtn2.Text == "Revert")
            {
                return;
            }
            else
            {
                if (stepsTable.SelectedCells.Count > 0)
                {
                    DataGridViewRow selectedRow = stepsTable.Rows[stepsTable.SelectedCells[0].RowIndex];
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Step ID " + Convert.ToString(selectedRow.Cells["StepID"].Value) + "? This action is irreversible!!", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var conn = new MySql();
                        conn.DeleteStep(Convert.ToInt32(selectedRow.Cells["StepID"].Value));
                        int selRow = stepsTable.CurrentCell.RowIndex;
                        if (stepsTable.Rows.Count > 1) selRow = stepsTable.CurrentCell.RowIndex - 1;
                        stepsTable.DataSource = testClass.ToDataTable(conn.GetSteps());
                        if (stepsTable.Rows.Count > 1) stepsTable.CurrentCell = stepsTable.Rows[selRow].Cells[0];
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
        }

        private void stepsoptionsTable_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                if (stepsoptionsTable.SelectedCells.Count > 0)
                {
                    var oForm = new OptionsForm(stepsoptionsTable.SelectedRows[0].Index, Convert.ToString(stepsoptionsTable.SelectedRows[0].Cells["Text"].Value), Convert.ToString(stepsoptionsTable.SelectedRows[0].Cells["StepID"].Value), this);
                    oForm.Show();
                }
            }
        }
    }

    public static class testClass
    {
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        public static int ParseInt(string input)
        {
            int ret;
            if (int.TryParse(input, out ret)) return ret;
            return 0;
        }
    }
}
