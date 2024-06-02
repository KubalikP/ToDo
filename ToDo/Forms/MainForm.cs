using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ToDo
{
    public partial class MainForm : KryptonForm
    {
        private string taskPlaceholderText = "Enter your task";
        private string searchPlaceholderText = "Search";
        private LoginForm loginForm = new LoginForm();
        private UserProfileForm upf;
        private UserAccess ua = new UserAccess();
        private List<Task> tasks = new List<Task>();

        public MainForm(int userId)
        {
            loginForm.LoggedUserId = userId;
            InitializeComponent();
            loadTasks();
            initialize();
        }

        private void initialize()
        {
            taskTextBox.Enter += taskTextBox_Focused;
            taskTextBox.LostFocus += taskTextBox_LostFocus;
            searchTextBox.Enter += searchTextBox_Focused;
            searchTextBox.LostFocus += searchTextBox_LostFocus;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            removeButton.Click += removeButton_Click;
            StartDateTimePicker.ValueChanged += startDateTimePicker_ValueChanged;
            EndDateTimePicker.ValueChanged += endDateTimePicker_ValueChanged;
            taskTable.CellContentClick += taskTable_CellContentClick;
            Settings.Click += Settings_Click;
            this.FormClosed += closeMainForm;
        }

        //Resets the task placeholder text when the text box losts focus
        private void setPlaceholderText(KryptonTextBox textBox, string placeholderText)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholderText;
            }
        }

        //Clears the placeholder text
        private void clearPlaceholderText(KryptonTextBox textBox, string placeholderText)
        {
            if (textBox.Text == placeholderText)
            {
                textBox.Text = string.Empty;
            }
        }

        //Clears the task placeholder text when the text box is focused
        private void taskTextBox_Focused(object sender, EventArgs e)
        {
            clearPlaceholderText(taskTextBox, taskTextBox.Text);
            taskTable.ClearSelection();
        }

        //Resets the task placeholder text when the text box losts focus
        private void taskTextBox_LostFocus(object sender, EventArgs e)
        {
            setPlaceholderText(taskTextBox, taskPlaceholderText);
        }

        //Clears the search placeholder text when the text box is focused
        private void searchTextBox_Focused(object sender, EventArgs e)
        {
            clearPlaceholderText(searchTextBox, searchTextBox.Text);
            taskTable.ClearSelection();
        }

        //Resets the search placeholder text when the text box losts focus
        private void searchTextBox_LostFocus(object sender, EventArgs e)
        {
            setPlaceholderText(searchTextBox, searchPlaceholderText);
        }

        //Unfocus when form starts
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.ActiveControl = null;
            taskTable.ClearSelection();
        }

        //Add button
        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(taskTextBox.Text) || taskTextBox.Text == "Enter your task")
            {
                MessageBox.Show("Task name cannot be empty");
            }
            else
            {
                Task task = new Task(0, taskTextBox.Text, StartDateTimePicker.Value, EndDateTimePicker.Value, EndTimeDateTimePicker.Value, false);
                ua.addTask(task, loginForm.LoggedUserId);
                loadTasks();
                clearPlaceholderText(taskTextBox, taskTextBox.Text);
                setPlaceholderText(taskTextBox, taskPlaceholderText);
            }
        }

        //Remove button
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (taskTable.SelectedRows.Count > 0)
            {
                DialogResult decision = MessageBox.Show("Are you sure you want to remove the selected task(s)?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (decision == DialogResult.Yes)
                {
                    List<int> taskIds = new List<int>();

                    foreach (DataGridViewRow selectedRow in taskTable.SelectedRows)
                    {
                        int taskId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                        taskIds.Add(taskId);
                    }

                    foreach (int taskId in taskIds)
                    {
                        ua.removeTask(taskId, loginForm.LoggedUserId);
                        taskTable.ClearSelection();
                    }
                    loadTasks();
                }
                else
                {
                    taskTable.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Please select a row");
            }

            taskTable.ClearSelection();
        }

        //Remove all button
        private void removeAll_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("Are you sure you want to remove All tasks?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (decision == DialogResult.Yes)
            {
                ua.removeAllTasks(loginForm.LoggedUserId);
                loadTasks();
            }
            else
            {
                taskTable.ClearSelection();
            }
        }

        //Loads all tasks
        private void loadTasks()
        {
            tasks = ua.getTasks(loginForm.LoggedUserId);
            taskTable.Rows.Clear();
            tasks.Reverse();
            foreach (Task task in tasks)
            {
                taskTable.Rows.Add(task.Id, task.TaskName, task.Start_date.ToString("yyyy-MM-dd"), task.End_date.ToString("yyyy-MM-dd"), task.End_time.ToString(@"HH\:mm"), task.Completed);
            }

            taskTable.ClearSelection();
        }

        //When search box is empty load all tasks
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;

            if (string.IsNullOrWhiteSpace(searchText) || searchText == searchPlaceholderText)
            {
                loadTasks();
            }

            taskTable.ClearSelection();
        }

        //Search button
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;

            if (string.IsNullOrWhiteSpace(searchText) || searchText == searchPlaceholderText)
            {
                loadTasks();
            }
            else
            {
                bool found = false;
                taskTable.Rows.Clear();

                foreach (Task task in tasks)
                {
                    if (task.TaskName.Contains(searchText))
                    {
                        taskTable.Rows.Add(task.Id, task.TaskName, task.Start_date.ToString("yyyy-MM-dd"), task.End_date.ToString("yyyy-MM-dd"), task.End_time.ToString("HH:mm"), task.Completed);
                        found = true;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("No results found");
                }
            }

            taskTable.ClearSelection();
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (StartDateTimePicker.Value > EndDateTimePicker.Value)
            {
                MessageBox.Show("Start date cannot be later than End date");
                StartDateTimePicker.Value = EndDateTimePicker.Value;
                this.Focus();
            }
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (EndDateTimePicker.Value < StartDateTimePicker.Value)
            {
                EndDateTimePicker.Value = StartDateTimePicker.Value;
                MessageBox.Show("End date cannot be earlier than Start date");
                this.Focus();
            }
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTasks();
        }

        //Shows in progress tasks after clicking
        private void inProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTasks();
            taskTable.Rows.Clear();

            foreach (Task task in tasks)
            {
                if (!task.Completed)
                {
                    taskTable.Rows.Add(task.Id, task.TaskName, task.Start_date.ToString("yyyy-MM-dd"), task.End_date.ToString("yyyy-MM-dd"), task.End_time.ToString("HH:mm"), task.Completed);
                }
            }

            taskTable.ClearSelection();
        }

        //Shows completed tasks after clicking
        private void completedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTasks();
            taskTable.Rows.Clear();

            foreach (Task task in tasks)
            {
                if (task.Completed)
                {
                    taskTable.Rows.Add(task.Id, task.TaskName, task.Start_date.ToString("yyyy-MM-dd"), task.End_date.ToString("yyyy-MM-dd"), task.End_time.ToString("HH:mm"), task.Completed);
                }
            }

            taskTable.ClearSelection();
        }

        //Saves completed columns after changes
        private void taskTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in taskTable.Rows)
            {
                if (e.ColumnIndex == taskTable.Columns["completed"].Index)
                {
                    DataGridViewCheckBoxCell checkboxCell = (DataGridViewCheckBoxCell)taskTable.Rows[e.RowIndex].Cells["completed"];
                    bool isChecked = (bool)checkboxCell.EditedFormattedValue;
                    int taskId = (int)taskTable.Rows[e.RowIndex].Cells["id"].Value;
                    string taskName = (string)taskTable.Rows[e.RowIndex].Cells["task"].Value;
                    DateTime startDate = Convert.ToDateTime(taskTable.Rows[e.RowIndex].Cells["start_date"].Value);
                    DateTime endDate = Convert.ToDateTime(taskTable.Rows[e.RowIndex].Cells["end_date"].Value);
                    DateTime endTime = Convert.ToDateTime(taskTable.Rows[e.RowIndex].Cells["end_time"].Value);

                    Task task = new Task(taskId, taskName, startDate, endDate, endTime, isChecked);
                    tasks.Add(task);
                }
            }

            ua.saveCompleted(tasks, loginForm.LoggedUserId);
        }

        //Settings button
        private void Settings_Click(object sender, EventArgs e)
        {
            if (upf == null || upf.IsDisposed)
            {
                upf = new UserProfileForm(loginForm.LoggedUserId);
            }

            upf.Show();
        }

        //Ends application after closing form
        private void closeMainForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
