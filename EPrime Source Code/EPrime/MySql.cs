using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPrime
{
    class MySql
    {
        // The Connection String Used By All Queries
        private readonly string connectStr = new FileOps().TxtRead("Resources/" + "db.txt");

        // Class Objects Below
        public class Button
        {
            public int id { get; set; }
            public string label { get; set; }
            public bool visible { get; set; }
            public int stepid { get; set; }
        }

        public class Step
        {
            public int StepID { get; set; }
            public string SetText { get; set; }
            public string Options { get; set; }
            public string OptionsSteps { get; set; }
            public string YesButtonText { get; set; }
            public string NoButtonText { get; set; }
            public int ShowEdit { get; set; }
            public int YesStepID { get; set; }
            public int NoStepID { get; set; }
            public int SetFieldsID { get; set; }
            public int PreviousStepID { get; set; }
            public string HelpText { get; set; }
        }

        public class Field
        {
            public int SetFieldsID { get; set; }
            public string Subject { get; set; }
            public string Description { get; set; }
            public string Resolution { get; set; }
            public string LMSSystem { get; set; }
            public string Service { get; set; }
            public string Category { get; set; }
            public string Subcategory { get; set; }
            public string Priority { get; set; }
            public string Impact { get; set; }
            public string Urgency { get; set; }
            public string Cause { get; set; }
            public string Command { get; set; }
        }

        public class Ticket
        {
            public string DateTime { get; set; }
            public string IncidentID { get; set; }
            public string OwnedBy { get; set; }
            public string Email { get; set; }
            public string FullName { get; set; }
            public string Campus { get; set; }
            public string SSN { get; set; }
            public string Status { get; set; }
            public string LastAction { get; set; }
            public string Time { get; set; }
            public string Subject { get; set; }
            public string Description { get; set; }
            public string Resolution { get; set; }
            public string Service { get; set; }
            public string Category { get; set; }
            public string Subcategory { get; set; }
            public string Priority { get; set; }
            public string Impact { get; set; }
            public string Urgency { get; set; }
            public string CourseID { get; set; }
            public string LMSSystem { get; set; }
        }

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }

        public class Error
        {
            public string ComputerName { get; set; }
            public string Username { get; set; }
            public string ErrorText { get; set; }
        }

        public int ParseLogin(string username, string password)
        {
            int role = -1;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    var reader = new MySqlCommand("SELECT * FROM users WHERE username='" + MySqlHelper.EscapeString(username) + "' and password='" + MySqlHelper.EscapeString(password) + "'", conn).ExecuteReader();
                    while (reader.Read())
                    {
                        role = Convert.ToInt32(reader["role"]);
                    }
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.ParseLogin() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
            return role;
        }

        public List<Ticket> GetTickets()
        {
            var list = new List<Ticket>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    var reader = new MySqlCommand("SELECT * FROM tickets", conn).ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Ticket()
                        {
                            DateTime = Convert.ToString(reader["datetime"]),
                            OwnedBy = Convert.ToString(reader["useremail"]),
                            Subject = Convert.ToString(reader["subject"]),
                            Description = Convert.ToString(reader["description"]),
                            Resolution = Convert.ToString(reader["resolution"]),
                            CourseID = Convert.ToString(reader["courseid"]),
                            LMSSystem = Convert.ToString(reader["lmssystem"]),
                            Service = Convert.ToString(reader["service"]),
                            Category = Convert.ToString(reader["category"]),
                            Subcategory = Convert.ToString(reader["subcategory"]),
                            Priority = Convert.ToString(reader["priority"]),
                            Impact = Convert.ToString(reader["impact"]),
                            Urgency = Convert.ToString(reader["urgency"]),
                            IncidentID = Convert.ToString(reader["incidentid"]),
                            FullName = Convert.ToString(reader["fullname"]),
                            Email = Convert.ToString(reader["email"]),
                            Campus = Convert.ToString(reader["campus"]),
                            SSN = Convert.ToString(reader["ssn"]),
                            Time = Convert.ToString(reader["time"]),
                            Status = Convert.ToString(reader["status"]),
                            LastAction = Convert.ToString(reader["lastaction"])
                        });
                    }
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.GetTickets() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
            return list.OrderBy(o => o.DateTime).ToList();
        }

        public void AddField(int id, string subject, string description, string resolution, string lmssystem, string service, string category, string subcategory, string priority, string impact, string urgency, string cause, string command)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    new MySqlCommand("INSERT INTO setfields (subject,description,resolution,lmssystem,service,category,subcategory,priority,impact,urgency,cause,command) VALUES ('" + MySqlHelper.EscapeString(subject) + "','" + MySqlHelper.EscapeString(description) + "','" + MySqlHelper.EscapeString(resolution) + "','" + MySqlHelper.EscapeString(lmssystem) + "','" + MySqlHelper.EscapeString(service) + "','" + MySqlHelper.EscapeString(category) + "','" + MySqlHelper.EscapeString(subcategory) + "','" + MySqlHelper.EscapeString(priority) + "','" + MySqlHelper.EscapeString(impact) + "','" + MySqlHelper.EscapeString(urgency) + "','" + MySqlHelper.EscapeString(cause) + "','" + MySqlHelper.EscapeString(command) + "')", conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.AddField() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public void AddStep(string settext, string options, string optionssteps, string yesbtntext, string nobtntext, int showedit, int yesnextstep, int nonextstep, int setfieldsid, int prevstep, string helptext)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    new MySqlCommand("INSERT INTO steps (set_text,options,options_steps,yesbtn_text,nobtn_text,show_edit,yes_next_step,no_next_step,set_fields_id,prev_step,help_text) VALUES ('" + MySqlHelper.EscapeString(settext) + "','" + MySqlHelper.EscapeString(options) + "','" + MySqlHelper.EscapeString(optionssteps) + "','" + MySqlHelper.EscapeString(yesbtntext) + "','"  + MySqlHelper.EscapeString(nobtntext) + "',"  + showedit + "," + yesnextstep + "," + nonextstep + "," + setfieldsid + "," + prevstep + ",'" + MySqlHelper.EscapeString(helptext) + "')", conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.AddStep() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public void AddUser(string user, string password, string role)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    int rRole = 0;
                    if (role == "Developer") rRole = 1;
                    new MySqlCommand("INSERT INTO users (username,password,role) VALUES ('" + MySqlHelper.EscapeString(user) + "','" + MySqlHelper.EscapeString(password) + "'," + rRole + ")", conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.AddUser() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public void DeleteTicket(string id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    new MySqlCommand("DELETE FROM tickets WHERE incidentid='" + MySqlHelper.EscapeString(id) + "'", conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.DeleteTicket() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public void DeleteStep(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    new MySqlCommand("DELETE FROM steps WHERE id=" + id, conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.DeleteStep() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public void DeleteField(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    new MySqlCommand("DELETE FROM setfields WHERE id=" + id, conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.DeleteField() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public void DeleteError(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    new MySqlCommand("DELETE FROM errors WHERE id=" + id, conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.DeleteError() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public void DeleteUser(string user)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    new MySqlCommand("DELETE FROM users WHERE username='" + MySqlHelper.EscapeString(user) + "'", conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.DeleteUser() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public void PurgeTickets()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    new MySqlCommand("TRUNCATE TABLE tickets", conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.PurgeTickets() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public void PurgeErrors()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    new MySqlCommand("TRUNCATE TABLE errors", conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.PurgeErrors() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public void UpdateButton(int id, string label, string visible, string stepid)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    new MySqlCommand("UPDATE buttons SET label='" + MySqlHelper.EscapeString(label) + "', visible=" + Convert.ToInt32(Convert.ToBoolean(visible)) + ", stepid=" + Convert.ToInt32(stepid) + " WHERE id=" + id, conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.UpdateButton() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public void UpdateStep(int id, string settext, string options, string optionssteps, string yesbtntext, string nobtntext, int showedit, int yesnextstep, int nonextstep, int setfieldsid, int prevstep, string helptext)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    new MySqlCommand("UPDATE steps SET set_text='" + MySqlHelper.EscapeString(settext) + "', options='" + MySqlHelper.EscapeString(options) + "', options_steps='" + MySqlHelper.EscapeString(optionssteps) + "', yesbtn_text='" + MySqlHelper.EscapeString(yesbtntext) + "', nobtn_text='" + MySqlHelper.EscapeString(nobtntext) + "', show_edit=" + showedit + ", yes_next_step=" + yesnextstep + ", no_next_step=" + nonextstep + ", set_fields_id=" + setfieldsid + ", prev_step=" + prevstep + ", help_text='" + MySqlHelper.EscapeString(helptext) + "' WHERE id=" + id, conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.UpdateStep() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public void UpdateField(int id, string subject, string description, string resolution, string lmssystem, string service, string category, string subcategory, string priority, string impact, string urgency, string cause, string command)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    new MySqlCommand("UPDATE setfields SET subject='" + MySqlHelper.EscapeString(subject) + "', description='" + MySqlHelper.EscapeString(description) + "', resolution='" + MySqlHelper.EscapeString(resolution) + "', lmssystem='" + MySqlHelper.EscapeString(lmssystem) + "', service='" + MySqlHelper.EscapeString(service) + "', category='" + MySqlHelper.EscapeString(category) + "', subcategory='" + MySqlHelper.EscapeString(subcategory) + "', priority='" + MySqlHelper.EscapeString(priority) + "', impact='" + MySqlHelper.EscapeString(impact) + "', urgency='" + MySqlHelper.EscapeString(urgency) + "', cause='" + MySqlHelper.EscapeString(cause) + "', command='" + MySqlHelper.EscapeString(command) + "' WHERE id=" + id, conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.UpdateField() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public void UpdateUser(string user, string password, string role)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    int rRole = 0;
                    if (role == "Developer") rRole = 1;
                    new MySqlCommand("UPDATE users SET password='" + MySqlHelper.EscapeString(password) + "', role=" + rRole + " WHERE username='" + MySqlHelper.EscapeString(user) + "'", conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.UpdateUser() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public List<Button> GetButtons()
        {
            var list = new List<Button>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    var reader = new MySqlCommand("SELECT * FROM buttons", conn).ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Button()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            label = Convert.ToString(reader["label"]),
                            visible = Convert.ToBoolean(reader["visible"]),
                            stepid = Convert.ToInt32(reader["stepid"])
                        });
                    }
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.GetButtons() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
            return list;
        }

        public List<Field> GetFields()
        {
            var list = new List<Field>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    var reader = new MySqlCommand("SELECT * FROM setfields", conn).ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Field()
                        {
                            SetFieldsID = Convert.ToInt32(reader["id"]),
                            Subject = Convert.ToString(reader["subject"]),
                            Description = Convert.ToString(reader["description"]),
                            Resolution = Convert.ToString(reader["resolution"]),
                            LMSSystem = Convert.ToString(reader["lmssystem"]),
                            Service = Convert.ToString(reader["service"]),
                            Category = Convert.ToString(reader["category"]),
                            Subcategory = Convert.ToString(reader["subcategory"]),
                            Priority = Convert.ToString(reader["priority"]),
                            Impact = Convert.ToString(reader["impact"]),
                            Urgency = Convert.ToString(reader["urgency"]),
                            Cause = Convert.ToString(reader["cause"]),
                            Command = Convert.ToString(reader["command"])
                        });
                    }
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.GetFields() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
            return list;
        }

        public List<Error> GetErrors()
        {
            var list = new List<Error>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    var reader = new MySqlCommand("SELECT * FROM errors", conn).ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Error()
                        {
                            ComputerName = Convert.ToString(reader["computername"]),
                            Username = Convert.ToString(reader["user"]),
                            ErrorText = Convert.ToString(reader["error"]),
                        });
                    }
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.GetErrors() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
            return list;
        }

        public List<User> GetUsers()
        {
            var list = new List<User>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    var reader = new MySqlCommand("SELECT * FROM users", conn).ExecuteReader();
                    while (reader.Read())
                    {
                        int role = Convert.ToInt32(reader["role"]);
                        string roleText = "";
                        if (role == 0) roleText = "QA";
                        if (role == 1) roleText = "Developer";
                        list.Add(new User()
                        {
                            Username = Convert.ToString(reader["username"]),
                            Password = Convert.ToString(reader["password"]),
                            Role = roleText
                        });
                    }
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.GetUsers() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
            return list;
        }

        public Step GetStep(int id)
        {
            var list = new Step();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    var reader = new MySqlCommand("SELECT * FROM steps WHERE id=" + id, conn).ExecuteReader();
                    while (reader.Read())
                    {
                        list.StepID = Convert.ToInt32(reader["id"]);
                        list.SetText = Convert.ToString(reader["set_text"]);
                        list.Options = Convert.ToString(reader["options"]);
                        list.OptionsSteps = Convert.ToString(reader["options_steps"]);
                        list.YesButtonText = Convert.ToString(reader["yesbtn_text"]);
                        list.NoButtonText = Convert.ToString(reader["nobtn_text"]);
                        list.ShowEdit = Convert.ToInt32(reader["show_edit"]);
                        list.YesStepID = Convert.ToInt32(reader["yes_next_step"]);
                        list.NoStepID = Convert.ToInt32(reader["no_next_step"]);
                        list.SetFieldsID = Convert.ToInt32(reader["set_fields_id"]);
                        list.PreviousStepID = Convert.ToInt32(reader["prev_step"]);
                        list.HelpText = Convert.ToString(reader["help_text"]);
                    }
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.GetStep() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
            return list;
        }

        public List<Step> GetSteps()
        {
            var list = new List<Step>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    var reader = new MySqlCommand("SELECT * FROM steps", conn).ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Step()
                        {
                            StepID = Convert.ToInt32(reader["id"]),
                            SetText = Convert.ToString(reader["set_text"]),
                            Options = Convert.ToString(reader["options"]),
                            OptionsSteps = Convert.ToString(reader["options_steps"]),
                            YesButtonText = Convert.ToString(reader["yesbtn_text"]),
                            NoButtonText = Convert.ToString(reader["nobtn_text"]),
                            ShowEdit = Convert.ToInt32(reader["show_edit"]),
                            YesStepID = Convert.ToInt32(reader["yes_next_step"]),
                            NoStepID = Convert.ToInt32(reader["no_next_step"]),
                            SetFieldsID = Convert.ToInt32(reader["set_fields_id"]),
                            PreviousStepID = Convert.ToInt32(reader["prev_step"]),
                            HelpText = Convert.ToString(reader["help_text"])
                        });
                    }
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.GetStep() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
            return list;
        }

        public Field GetField(int id)
        {
            var list = new Field();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    var reader = new MySqlCommand("SELECT * FROM setfields WHERE id=" + id, conn).ExecuteReader();
                    while (reader.Read())
                    {
                        list.SetFieldsID = Convert.ToInt32(reader["id"]);
                        list.Subject = Convert.ToString(reader["subject"]);
                        list.Description = Convert.ToString(reader["description"]);
                        list.Resolution = Convert.ToString(reader["resolution"]);
                        list.LMSSystem = Convert.ToString(reader["lmssystem"]);
                        list.Service = Convert.ToString(reader["service"]);
                        list.Category = Convert.ToString(reader["category"]);
                        list.Subcategory = Convert.ToString(reader["subcategory"]);
                        list.Priority = Convert.ToString(reader["priority"]);
                        list.Impact = Convert.ToString(reader["impact"]);
                        list.Urgency = Convert.ToString(reader["urgency"]);
                        list.Cause = Convert.ToString(reader["cause"]);
                        list.Command = Convert.ToString(reader["command"]);
                    }
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.GetField() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
            return list;
        }

        public void SendErrors()
        {
            try {
                using (MySqlConnection conn = new MySqlConnection(connectStr)) {
                    conn.Open();
                    FileOps.ReadLog().ForEach(f => new MySqlCommand("INSERT INTO errors (computername, user, error) VALUES ('" + MySqlHelper.EscapeString(Environment.MachineName) + "','" + MySqlHelper.EscapeString(Environment.UserName) + "','" + MySqlHelper.EscapeString(f) + "')", conn).ExecuteNonQuery());
                }
                FileOps.DeleteLog();
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.SendErrors() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public void SendPending(string incident,string value)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    new MySqlCommand("INSERT INTO pending_values (incidentid,value) VALUES ('" + MySqlHelper.EscapeString(incident) + "','" + MySqlHelper.EscapeString(value) + "')", conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.SendPending() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public List<string> GetPending(string id)
        {
            var list = new List<string>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    var reader = new MySqlCommand("SELECT * FROM pending_values WHERE incidentid='" + MySqlHelper.EscapeString(id) + "'", conn).ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader["value"].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.GetPending() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
            return list;
        }

        public void DeletePending(string id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    new MySqlCommand("DELETE FROM pending_values WHERE incidentid='" + MySqlHelper.EscapeString(id) + "'", conn).ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.DeletePending() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }

        public void UpdateTicket(List<string> fields, string action)
        {
            int RowCount = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    var reader = new MySqlCommand("SELECT * FROM tickets WHERE incidentid='" + MySqlHelper.EscapeString(fields[12]) + "'", conn).ExecuteReader();
                    while (reader.Read()) RowCount++;
                }
                using (MySqlConnection conn = new MySqlConnection(connectStr))
                {
                    conn.Open();
                    if (RowCount < 1)
                    {
                        new MySqlCommand(@"INSERT INTO tickets (datetime,useremail,subject,description,resolution,courseid,lmssystem,service,category,subcategory,priority,impact,urgency,incidentid,fullname,email,campus,ssn,time,status,lastaction) VALUES ('" + MySqlHelper.EscapeString(DateTime.Now.ToString("G")) + "','" + MySqlHelper.EscapeString(fields[0]) + "','" + MySqlHelper.EscapeString(fields[1]) + "','" + MySqlHelper.EscapeString(fields[2]) + "','" + MySqlHelper.EscapeString(fields[3]) + "','" + MySqlHelper.EscapeString(fields[4]) + "','" + MySqlHelper.EscapeString(fields[5]) + "','" + MySqlHelper.EscapeString(fields[6]) + "','" + MySqlHelper.EscapeString(fields[7]) + "','" + MySqlHelper.EscapeString(fields[8]) + "','" + MySqlHelper.EscapeString(fields[9]) + "','" + MySqlHelper.EscapeString(fields[10]) + "','" + MySqlHelper.EscapeString(fields[11]) + "','" + MySqlHelper.EscapeString(fields[12]) + "','" + MySqlHelper.EscapeString(fields[13]) + "','" + MySqlHelper.EscapeString(fields[14]) + "','" + MySqlHelper.EscapeString(fields[15]) + "','" + MySqlHelper.EscapeString(fields[16]) + "','" + MySqlHelper.EscapeString(fields[17]) + "','" + MySqlHelper.EscapeString(fields[18]) + "','" + MySqlHelper.EscapeString(action) + "')", conn).ExecuteNonQuery();
                    }
                    else
                    {
                        new MySqlCommand("UPDATE tickets SET datetime='" + MySqlHelper.EscapeString(DateTime.Now.ToString("G")) + "',useremail='" + MySqlHelper.EscapeString(fields[0]) + "',subject='" + MySqlHelper.EscapeString(fields[1]) + "',description= '" + MySqlHelper.EscapeString(fields[2]) + "', resolution= '" + MySqlHelper.EscapeString(fields[3]) + "', courseid= '" + MySqlHelper.EscapeString(fields[4]) + "',lmssystem= '" + MySqlHelper.EscapeString(fields[5]) + "', service= '" + MySqlHelper.EscapeString(fields[6]) + "', category= '" + MySqlHelper.EscapeString(fields[7]) + "', subcategory= '" + MySqlHelper.EscapeString(fields[8]) + "',priority= '" + MySqlHelper.EscapeString(fields[9]) + "', impact= '" + MySqlHelper.EscapeString(fields[10]) + "', urgency= '" + MySqlHelper.EscapeString(fields[11]) + "', fullname= '" + MySqlHelper.EscapeString(fields[13]) + "', email= '" + MySqlHelper.EscapeString(fields[14]) + "',campus= '" + MySqlHelper.EscapeString(fields[15]) + "', ssn= '" + MySqlHelper.EscapeString(fields[16]) + "', time= '" + MySqlHelper.EscapeString(fields[17]) + "', status= '" + MySqlHelper.EscapeString(fields[18]) + "',lastaction= '" + MySqlHelper.EscapeString(action) + "' WHERE incidentid= '" + MySqlHelper.EscapeString(fields[12]) + "'", conn).ExecuteNonQuery();
                    }
                } 
            }
            catch (Exception e)
            {
                FileOps.WriteLog("MySql.UpdateTicket() failed due to " + e.GetType().ToString() + " with message: " + e.Message);
            }
        }
    }
}
