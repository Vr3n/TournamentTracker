using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TournamentTracker;
using TournamentTracker.Models;

namespace TournamentTrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connections.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        /// <summary>
        /// Associating Dropdowns to the Available, and Selected Team members list.
        /// 
        /// Select Team Member Dropdown -> AvailableTeamMembers.
        /// Team Members List Dropdown -> SelectedTeamMembers.
        /// </summary>
        private void WireUpLists()
        {
            selectTeamDropDown.DataSource = null;

            // Select Team Dropdown  to available Team members;
            selectTeamDropDown.DataSource = availableTeamMembers;
            selectTeamDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {

                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellPhoneNumber = cellPhoneValue.Text;

                PersonModel saved_person = GlobalConfig.Connections.CreatePerson(p);

                MessageBox.Show("Persons Created Successfully!");

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";

                selectedTeamMembers.Add(saved_person);
                WireUpLists();
            }
            else
            {
                MessageBox.Show("You need to fill all Fields!");
            }
            // Validate Form.
            // Save to model.
            // Clear Form.

        }

        private bool ValidateForm()
        {
            bool output = true;

            if (firstNameValue.Text.Length == 0)
            {
                output = false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                output = false;
            }

            if (emailValue.Text.Length == 0)
            {
                output = false;
            }

            if (cellPhoneValue.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }

        private void teamMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();

            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {

            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {

                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();

            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel team_model = new TeamModel();

            team_model.TeamName = teamNameValue.Text;
            team_model.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connections.CreateTeam(team_model);

            MessageBox.Show("Saved Successfully!");

            // TODO: Reset the Form after save.
        }
    }
}
