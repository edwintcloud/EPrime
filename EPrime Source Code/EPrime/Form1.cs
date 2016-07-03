using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace EPrime
{
    public partial class EPrime : Form
    {

        private long lTick = 1000;

        public string incidentFromFile = "";
        public string currentUser = "";
        public string helpText = "";
        public int currentStepId = -999;
        public int noStepId = -999;
        public int yesStepId = -999;
        public int prevStepId = -999;
        public int setFieldsId = -999;
        public List<int> nextStepId = new List<int>();

        public EPrime()
        {
            InitializeComponent();
            Hide();
            StartPosition = FormStartPosition.CenterScreen;
            try
            {
                string[] args = Environment.GetCommandLineArgs();
                incidentFromFile = args[1];
            }
            catch (Exception e)
            {
                FileOps.WriteLog("Environment.GetCommandLineArgs() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
            if(incidentFromFile == "admin")
            {
                var loginForm = new LoginForm(this);
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                CheckState(loginForm);
                Enabled = false;
                loginForm.TopMost = true;
                loginForm.Show();
            } else
            {
                Show();
                FileOps.CleanSaves();
                StartForm();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void autoBtn1_Click(object sender, EventArgs e)
        {
            MySql conn = new MySql();
            List<MySql.Button> button = conn.GetButtons();
            conn.DeletePending(incidentidBox.Text);
            if (button.Count == 12) SetWizard(button[0].stepid);
        }

        private void resetVars()
        {
            currentStepId = -999;
            noStepId = -999;
            yesStepId = -999;
            prevStepId = -999;
            helpText = "";
            nextStepId = new List<int>();
        }
        private void StartForm()
        {
            LoadBtns();
            LoadResources();
            LoadFields();


            var conn = new MySql();
            conn.UpdateTicket(getFields(), "Start Program");

        }
        private void LoadResources()
        {
            CherwellCsvImport csv = new CherwellCsvImport();
            FileOps file = new FileOps();
            lmssystemCombo.DataSource = file.CsvRead("Resources/lmssystem.csv");
            serviceCombo.DataSource = csv.getService();
            categoryCombo.DataSource = csv.returnCategories(serviceCombo.SelectedItem.ToString());
            subcategoryCombo.DataSource = csv.returnSubcategories(serviceCombo.SelectedItem.ToString(), categoryCombo.SelectedItem.ToString());
            priorityCombo.DataSource = file.CsvRead("Resources/priority.csv");
            impactCombo.DataSource = file.CsvRead("Resources/impact.csv");
            urgencyCombo.DataSource = file.CsvRead("Resources/urgency.csv");
        }

        private void LoadFields()
        {
            // Read our Files into a string or list of strings
            FileOps file = new FileOps();
            List<string> list1 = new List<string>();
            if (incidentFromFile != "")
            {
                list1 = file.CsvRead("Cherwell_Exports/" + incidentFromFile + "/cherwellExport.csv");
                resolutionBox.Text = file.TxtRead("Cherwell_Exports/" + incidentFromFile + "/resExport.txt");
                descriptionBox.Text = file.TxtRead("Cherwell_Exports/" + incidentFromFile + "/descExport.txt");
            }
            else
            {
                list1 = file.CsvRead("Cherwell_Exports/cherwellExport.csv");
                resolutionBox.Text = file.TxtRead("Cherwell_Exports/resExport.txt");
                descriptionBox.Text = file.TxtRead("Cherwell_Exports/descExport.txt");
            }

            // Update fields
            try
            {
                this.Text = "EPrime - " + list1[15] + " - " + list1[9];
                yesBtn.Visible = false;
                noBtn.Visible = false;
                backBtn.Visible = false;
                helpBtn.Visible = false;
                wizardBox.Text = "Use an AUTOCATEGORIZE button below to start the Troubleshooting Wizard.";
                wizardCombo.DropDownStyle = ComboBoxStyle.DropDownList;
                wizardCombo.DataSource = new List<string>();
                wizardCombo.Visible = false;
                var conn = new MySql();
                conn.DeletePending(incidentidBox.Text);

                subjectBox.Text = list1[0];
                courseidBox.Text = list1[1];
                lmssystemCombo.SelectedItem = list1[2];
                serviceCombo.SelectedItem = list1[3];
                categoryCombo.SelectedItem = list1[4];
                subcategoryCombo.SelectedItem = list1[5];
                priorityCombo.SelectedItem = list1[6];
                impactCombo.SelectedItem = list1[7];
                urgencyCombo.SelectedItem = list1[8];
                incidentidBox.Text = list1[9];
                fullnameBox.Text = list1[10];
                campusBox.Text = list1[11];
                ssnBox.Text = list1[12];
                emailBox.Text = list1[13];

                // Set Status
                updatestatusLbl.Text = list1[14];
                if (list1[14] == "In Progress")
                {
                    updatestatusLbl.ForeColor = Color.Blue;
                }
                else if (list1[14] == "Resolved")
                {
                    updatestatusLbl.ForeColor = Color.Green;
                }
                else if (list1[14] == "Reopened")
                {
                    updatestatusLbl.ForeColor = Color.Orange;
                }
                else
                {
                    updatestatusLbl.ForeColor = Color.Black;
                }
                currentUser = list1[15];
            }
            catch (Exception e)
            {

                FileOps.WriteLog("Form1.LoadFields() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }
        private List<string> getFields()
        {
            List<string> list = new List<string>();
            list.Add(currentUser);
            list.Add(subjectBox.Text);
            list.Add(descriptionBox.Text);
            list.Add(resolutionBox.Text);
            list.Add(courseidBox.Text);
            list.Add(lmssystemCombo.SelectedItem.ToString());
            list.Add(serviceCombo.SelectedItem.ToString());
            list.Add(categoryCombo.SelectedItem.ToString());
            list.Add(subcategoryCombo.SelectedItem.ToString());
            list.Add(priorityCombo.SelectedItem.ToString());
            list.Add(impactCombo.SelectedItem.ToString());
            list.Add(urgencyCombo.SelectedItem.ToString());
            list.Add(incidentidBox.Text);
            list.Add(fullnameBox.Text);
            list.Add(emailBox.Text);
            list.Add(campusBox.Text);
            list.Add(ssnBox.Text);
            list.Add(timerBox.Text);
            list.Add(updatestatusLbl.Text);

            return list;
        }
        private void LoadBtns()
        {
            MySql conn = new MySql();
            List<MySql.Button> button = conn.GetButtons();
            try
            {
                autoBtn1.Visible = button[0].visible;
                autoBtn1.Text = button[0].label;
                autoBtn2.Visible = button[1].visible;
                autoBtn2.Text = button[1].label;
                autoBtn3.Visible = button[2].visible;
                autoBtn3.Text = button[2].label;
                autoBtn4.Visible = button[3].visible;
                autoBtn4.Text = button[3].label;
                autoBtn5.Visible = button[4].visible;
                autoBtn5.Text = button[4].label;
                autoBtn6.Visible = button[5].visible;
                autoBtn6.Text = button[5].label;
                autoBtn7.Visible = button[6].visible;
                autoBtn7.Text = button[6].label;
                autoBtn8.Visible = button[7].visible;
                autoBtn8.Text = button[7].label;
                autoBtn9.Visible = button[8].visible;
                autoBtn9.Text = button[8].label;
                autoBtn10.Visible = button[9].visible;
                autoBtn10.Text = button[9].label;
                autoBtn11.Visible = button[10].visible;
                autoBtn11.Text = button[10].label;
                autoBtn12.Visible = button[11].visible;
                autoBtn12.Text = button[11].label;
            }
            catch (Exception e)
            {
                FileOps.WriteLog("Form1.LoadBtns() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        private void SetWizard(int id)
        {
            try
            {
                var conn = new MySql();
                MySql.Step step = conn.GetStep(id);
                resetVars();
                currentStepId = step.StepID;
                noStepId = step.NoStepID;
                yesStepId = step.YesStepID;
                prevStepId = step.PreviousStepID;
                nextStepId = step.OptionsSteps.Split(',').Select(str => {
                    int value;
                    bool success = int.TryParse(str, out value);
                    return new { value, success };
                })
                  .Where(pair => pair.success)
                  .Select(pair => pair.value).ToList();
                setFieldsId = step.SetFieldsID;
                helpText = step.HelpText;

                if(step.HelpText.Length < 1)
                {
                    helpBtn.Visible = false;
                }
                else
                {
                    helpBtn.Visible = true;
                }

                if (step.PreviousStepID == -999)
                {
                    backBtn.Visible = false;
                }
                else
                {
                    backBtn.Visible = true;
                }
                string setText = step.SetText;
                while (setText.Contains("$name")) setText = setText.Replace("$name", fullnameBox.Text.Substring(0, fullnameBox.Text.IndexOf(' ')));
                wizardBox.Text = setText;
                if (step.ShowEdit == 1)
                {
                    wizardCombo.DropDownStyle = ComboBoxStyle.Simple;
                    wizardCombo.Text = "";
                }
                else
                {
                    wizardCombo.DropDownStyle = ComboBoxStyle.DropDownList;
                    wizardCombo.DataSource = step.Options.Split(',').ToList();
                }

                if (step.YesStepID == 0)
                {
                    yesBtn.Visible = false;
                }
                else
                {
                    yesBtn.Text = step.YesButtonText;
                    yesBtn.Visible = true;
                }

                if (step.NoStepID == 0)
                {
                    noBtn.Visible = false;
                }
                else
                {
                    noBtn.Text = step.NoButtonText;
                    noBtn.Visible = true;
                }

                if (wizardCombo.Items.Count < 2 && wizardCombo.DropDownStyle != ComboBoxStyle.Simple)
                {
                    wizardCombo.Visible = false;
                }
                else
                {
                    wizardCombo.Visible = true;
                }
            } catch(Exception e)
            {
                FileOps.WriteLog("Form1.SetWizard() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        private void WizardSetField(int stepid)
        {
            try
            {
                var conn = new MySql();
                MySql.Field field = conn.GetField(stepid);

                subjectBox.Text = field.Subject;
                string description = field.Description;
                string resolution = field.Resolution;
                List<string> pending = conn.GetPending(incidentidBox.Text);
                for (int i = 0; i < pending.Count; i++)
                {
                    description = description.Replace("$" + i.ToString(), pending[i]);
                    resolution = resolution.Replace("$" + i.ToString(), pending[i]);
                }
                while (description.Contains("$name")) description = description.Replace("$name", fullnameBox.Text.Substring(0, fullnameBox.Text.IndexOf(' ')));
                while (resolution.Contains("$name")) resolution = resolution.Replace("$name", fullnameBox.Text.Substring(0, fullnameBox.Text.IndexOf(' ')));
                if (descriptionBox.Text.Length > 0) descriptionBox.Text += Environment.NewLine;
                descriptionBox.Text += description;
                if (resolutionBox.Text.Length > 0) resolutionBox.Text += Environment.NewLine;
                resolutionBox.Text += resolution;
                lmssystemCombo.SelectedItem = field.LMSSystem;
                serviceCombo.SelectedItem = field.Service;
                categoryCombo.SelectedItem = field.Category;
                subcategoryCombo.SelectedItem = field.Subcategory;
                priorityCombo.SelectedItem = field.Priority;
                impactCombo.SelectedItem = field.Impact;
                urgencyCombo.SelectedItem = field.Urgency;

                FileOps.SaveFileWrite(incidentidBox.Text, "cause", field.Cause);
                FileOps.SaveFileWrite(incidentidBox.Text, "command", field.Command);
            }
            catch (Exception e)
            {
                FileOps.WriteLog("Form1.WizardSetField() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        private void SaveTicket()
        {
            FileOps.SaveFileWrite(incidentidBox.Text, "subject", subjectBox.Text);
            FileOps.SaveFileWrite(incidentidBox.Text, "courseid", courseidBox.Text);
            FileOps.SaveFileWrite(incidentidBox.Text, "lmssystem", lmssystemCombo.SelectedItem.ToString());
            FileOps.SaveFileWrite(incidentidBox.Text, "service", serviceCombo.SelectedItem.ToString());
            FileOps.SaveFileWrite(incidentidBox.Text, "category", categoryCombo.SelectedItem.ToString());
            FileOps.SaveFileWrite(incidentidBox.Text, "subcategory", subcategoryCombo.SelectedItem.ToString());
            FileOps.SaveFileWrite(incidentidBox.Text, "priority", priorityCombo.SelectedItem.ToString());
            FileOps.SaveFileWrite(incidentidBox.Text, "impact", impactCombo.SelectedItem.ToString());
            FileOps.SaveFileWrite(incidentidBox.Text, "urgency", urgencyCombo.SelectedItem.ToString());
            FileOps.SaveFileWrite(incidentidBox.Text, "description", descriptionBox.Text);
            FileOps.SaveFileWrite(incidentidBox.Text, "resolution", resolutionBox.Text);
            FileOps.SaveFileWrite(incidentidBox.Text, "time", timerBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerBox.Text = String.Format("{0:00.00}", TimeSpan.FromMilliseconds(lTick).TotalMinutes);
            if (TimeSpan.FromMilliseconds(lTick).TotalMinutes >= 10)
            {
                escalatestatusLbl.Visible = true;
            }
            lTick += 1000;
        }

        private void serviceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CherwellCsvImport csv = new CherwellCsvImport();
            categoryCombo.DataSource = csv.returnCategories(serviceCombo.SelectedItem.ToString());
        }

        private void categoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CherwellCsvImport csv = new CherwellCsvImport();
            subcategoryCombo.DataSource = csv.returnSubcategories(serviceCombo.SelectedItem.ToString(), categoryCombo.SelectedItem.ToString());
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void copyincidentidBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(incidentidBox.Text);
        }

        private void copyfullnameBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fullnameBox.Text);
        }

        private void campuscopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(campusBox.Text);
        }

        private void copyssnBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ssnBox.Text);
        }

        private void emailcopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(emailBox.Text);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            var conn = new MySql();
            conn.UpdateTicket(getFields(), "Exit Without Saving");
            SaveTicket();
            FileOps.SaveFileWrite(incidentidBox.Text, "action", "exit");
            Application.Exit();
        }

        private void saveandexitBtn_Click(object sender, EventArgs e)
        {
            var conn = new MySql();
            conn.UpdateTicket(getFields(), "Save and Exit");
            SaveTicket();
            FileOps.SaveFileWrite(incidentidBox.Text, "action", "save");
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (prevStepId != -999)
            {
                SetWizard(prevStepId);
            }
        }

        private void wizardCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            if (wizardCombo.DropDownStyle == ComboBoxStyle.Simple && wizardCombo.Text != null && wizardCombo.Text != "")
            {
                var conn = new MySql();
                conn.SendPending(incidentidBox.Text, wizardCombo.Text);
            }
            if (yesStepId != -999 && yesStepId != -1)
            {
                SetWizard(yesStepId);
            }
            else if (yesStepId == -1)
            {
                if (setFieldsId > 0)
                {
                    WizardSetField(setFieldsId);
                    yesBtn.Visible = false;
                    noBtn.Visible = false;
                    backBtn.Visible = false;
                    wizardBox.Text = "Use an AUTOCATEGORIZE button below to start the Troubleshooting Wizard.";
                    wizardCombo.DropDownStyle = ComboBoxStyle.DropDownList;
                    wizardCombo.Text = "";
                    var conn = new MySql();
                    conn.DeletePending(incidentidBox.Text);
                }
            }
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            if (wizardCombo.DropDownStyle == ComboBoxStyle.Simple && wizardCombo.Text != null && wizardCombo.Text != "")
            {
                var conn = new MySql();
                conn.SendPending(incidentidBox.Text, wizardCombo.Text);
            }
            if (noStepId != -999 && noStepId != -1)
            {
                SetWizard(noStepId);
            }
            else if (noStepId == -1)
            {
                if (setFieldsId > 0)
                {
                    WizardSetField(setFieldsId);
                    yesBtn.Visible = false;
                    noBtn.Visible = false;
                    backBtn.Visible = false;
                    wizardBox.Text = "Use an AUTOCATEGORIZE button below to start the Troubleshooting Wizard.";
                    wizardCombo.DropDownStyle = ComboBoxStyle.DropDownList;
                    wizardCombo.Text = "";
                    var conn = new MySql();
                    conn.DeletePending(incidentidBox.Text);
                }
            }
        }

        private void autoBtn2_Click(object sender, EventArgs e)
        {
            MySql conn = new MySql();
            List<MySql.Button> button = conn.GetButtons();
            conn.DeletePending(incidentidBox.Text);
            if (button.Count == 12) SetWizard(button[1].stepid);
        }

        private void autoBtn3_Click(object sender, EventArgs e)
        {
            MySql conn = new MySql();
            List<MySql.Button> button = conn.GetButtons();
            conn.DeletePending(incidentidBox.Text);
            if (button.Count == 12) SetWizard(button[2].stepid);
        }

        private void autoBtn4_Click(object sender, EventArgs e)
        {
            MySql conn = new MySql();
            List<MySql.Button> button = conn.GetButtons();
            conn.DeletePending(incidentidBox.Text);
            if (button.Count == 12) SetWizard(button[3].stepid);
        }

        private void autoBtn5_Click(object sender, EventArgs e)
        {
            MySql conn = new MySql();
            List<MySql.Button> button = conn.GetButtons();
            conn.DeletePending(incidentidBox.Text);
            if (button.Count == 12) SetWizard(button[4].stepid);
        }

        private void autoBtn6_Click(object sender, EventArgs e)
        {
            MySql conn = new MySql();
            List<MySql.Button> button = conn.GetButtons();
            conn.DeletePending(incidentidBox.Text);
            if (button.Count == 12) SetWizard(button[5].stepid);
        }

        private void autoBtn7_Click(object sender, EventArgs e)
        {
            MySql conn = new MySql();
            List<MySql.Button> button = conn.GetButtons();
            conn.DeletePending(incidentidBox.Text);
            if (button.Count == 12) SetWizard(button[6].stepid);
        }

        private void autoBtn8_Click(object sender, EventArgs e)
        {
            MySql conn = new MySql();
            List<MySql.Button> button = conn.GetButtons();
            conn.DeletePending(incidentidBox.Text);
            if (button.Count == 12) SetWizard(button[7].stepid);
        }

        private void autoBtn9_Click(object sender, EventArgs e)
        {
            MySql conn = new MySql();
            List<MySql.Button> button = conn.GetButtons();
            conn.DeletePending(incidentidBox.Text);
            if (button.Count == 12) SetWizard(button[8].stepid);
        }

        private void autoBtn10_Click(object sender, EventArgs e)
        {
            MySql conn = new MySql();
            List<MySql.Button> button = conn.GetButtons();
            conn.DeletePending(incidentidBox.Text);
            if (button.Count == 12) SetWizard(button[9].stepid);
        }

        private void autoBtn11_Click(object sender, EventArgs e)
        {
            MySql conn = new MySql();
            List<MySql.Button> button = conn.GetButtons();
            conn.DeletePending(incidentidBox.Text);
            if (button.Count == 12) SetWizard(button[10].stepid);
        }

        private void autoBtn12_Click(object sender, EventArgs e)
        {
            MySql conn = new MySql();
            List<MySql.Button> button = conn.GetButtons();
            conn.DeletePending(incidentidBox.Text);
            if (button.Count == 12) SetWizard(button[11].stepid);
        }

        private void wizardCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (nextStepId.Count != wizardCombo.Items.Count) return;
            if (nextStepId.Count > 0 && nextStepId[wizardCombo.SelectedIndex] != -999)
            {
                SetWizard(nextStepId[wizardCombo.SelectedIndex]);
            }
        }

        private void resolveBtn_Click(object sender, EventArgs e)
        {
            var conn = new MySql();
            conn.UpdateTicket(getFields(), "Resolve");
            SaveTicket();
            FileOps.SaveFileWrite(incidentidBox.Text, "action", "resolve");
            Application.Exit();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            LoadFields();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileOps.CleanExports();
            MySql conn = new MySql();
            conn.SendErrors();

            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                conn.UpdateTicket(getFields(), "Forcefully Closed");
                SaveTicket();
                FileOps.SaveFileWrite(incidentidBox.Text, "action", "exit");
            }
        }

        private void campusdirectoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://sotd.us/PSC/rasmussen/directory.html");
            }
            catch (Exception er)
            {
                FileOps.WriteLog("Form1.campusdirectoryBtn_Click() failed due to " + er.GetType().ToString() + " with message: " + er.Message);
            }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            if(helpText != "")
            {
                var helpForm = new helpForm(helpText,helpBtn);
                helpForm.StartPosition = FormStartPosition.CenterScreen;
                CheckState(helpForm);
                helpBtn.Enabled = false;
                helpForm.TopMost = true;
                helpForm.Show();
            }
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(this);
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            CheckState(loginForm);
            Enabled = false;
            loginForm.TopMost = true;
            loginForm.Show();
        }

        private async void CheckState(Form formName)
        {
            while(!formName.IsDisposed)
            {
                await Task.Delay(150);
                if (WindowState == FormWindowState.Minimized && formName.WindowState != FormWindowState.Minimized)
                {
                    formName.TopMost = false;
                    formName.WindowState = FormWindowState.Minimized;
                }
                if (WindowState == FormWindowState.Normal && formName.WindowState != FormWindowState.Normal)
                {
                    formName.WindowState = FormWindowState.Normal;
                    formName.TopMost = true;
                }
                if(formName.WindowState == FormWindowState.Minimized && WindowState != FormWindowState.Minimized)
                {
                    formName.WindowState = FormWindowState.Normal;
                    formName.TopMost = true;
                }
            }
        }

        private void wizardBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
