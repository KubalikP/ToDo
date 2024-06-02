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
    public partial class OfflineForm : KryptonForm
    {
        private string taskPlaceholderText = "Enter your task";
        private string searchPlaceholderText = "Search";
        private List<Task> tasks = new List<Task>();

        public OfflineForm()
        {
            InitializeComponent();
            tasks.Reverse();
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
            if (string.IsNullOrWhiteSpace(taskTextBox.Text) || taskTextBox.Text == taskPlaceholderText)
            {
                MessageBox.Show("Task name cannot be empty");
            }
            else
            {

                int newId = 1;

                if (tasks.Count > 0)
                {
                    int maxId = 0;
                    foreach (Task t in tasks)
                    {
                        if (t.Id > maxId)
                        {
                            maxId = t.Id;
                        }
                    }
                    newId = maxId + 1;
                }

                Task task = new Task(newId, taskTextBox.Text, StartDateTimePicker.Value, EndDateTimePicker.Value, EndTimeDateTimePicker.Value, false);
                tasks.Add(task);
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
                DialogResult decision = MessageBox.Show("Are you sure you want to remove the selected task(s)?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (decision == DialogResult.Yes)
                {
                    List<int> taskIdsToRemove = new List<int>();
                    foreach (DataGridViewRow selectedRow in taskTable.SelectedRows)
                    {
                        int taskId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                        taskIdsToRemove.Add(taskId);
                    }

                    foreach (int taskIdToRemove in taskIdsToRemove)
                    {
                        Task taskToRemove = null;
                        foreach (Task task in tasks)
                        {
                            if (task.Id == taskIdToRemove)
                            {
                                taskToRemove = task;
                                break;
                            }
                        }

                        if (taskToRemove != null)
                        {
                            tasks.Remove(taskToRemove);
                        }
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
            DialogResult decision = MessageBox.Show("Are you sure you want to remove All tasks?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (decision == DialogResult.Yes)
            {
                tasks.Clear();
                loadTasks();
            }
            else
            {
                taskTable.ClearSelection();
            }

            taskTable.ClearSelection();
        }

        //Loads all tasks
        private void loadTasks()
        {
            taskTable.Rows.Clear();

            foreach (Task task in tasks)
            {
                taskTable.Rows.Add(task.Id, task.TaskName, task.Start_date.ToString("yyyy-MM-dd"), task.End_date.ToString("yyyy-MM-dd"), task.End_time.ToString(@"HH\:mm"), task.Completed);
            }

            taskTable.ClearSelection();
        }

        //Search text box
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
            if (e.ColumnIndex == taskTable.Columns["completed"].Index)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)taskTable.Rows[e.RowIndex].Cells["completed"];
                bool isChecked = (bool)checkbox.EditedFormattedValue;
                int taskId = (int)taskTable.Rows[e.RowIndex].Cells["id"].Value;
                Task taskToUpdate = null;

                foreach (Task task in tasks)
                {
                    if (task.Id == taskId)
                    {
                        taskToUpdate = task;
                        break;
                    }
                }

                if (taskToUpdate != null)
                {
                    taskToUpdate.Completed = isChecked;
                }
            }
        }


        //Ends application after closing form
        private void closeMainForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
