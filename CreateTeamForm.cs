using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {

        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        private ITeamRequester callingForm;
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            //CreateSampleData();
            callingForm = caller;

            WireUpLists();
        }







        private void WireUpLists()
        {
            SelectTeamMemberDropDown.DataSource = null;
            SelectTeamMemberDropDown.DataSource = availableTeamMembers;
            SelectTeamMemberDropDown.DisplayMember = "FullName";


            TeamMemberListBox.DataSource = null;
            TeamMemberListBox.DataSource = selectedTeamMembers;
            TeamMemberListBox.DisplayMember = "FullName";
        }


        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Sam", LastName = "Ford" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sam", LastName = "Peter" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });
        }


        private void CreateTeamButton_Click(object sender, EventArgs e)
        {

            TeamModel t = new TeamModel();

            t.TeamName = TeamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);
            this.Close();




        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = FirstNameValue.Text;
                p.LastName = LastNameTextValue.Text;
                p.EmailAddress = EmailValue.Text;
                p.CellPhoneNumber = CellPhoneValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
                FirstNameValue.Text = "";
                LastNameTextValue.Text = "";
                EmailValue.Text = "";
                CellPhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields");
            }
        }


        private bool ValidateForm()
        {
            if (FirstNameValue.Text.Length == 0) { return false; }
            if (LastNameTextValue.Text.Length == 0) { return false; }
            if (EmailValue.Text.Length == 0) { return false; }
            if (CellPhoneValue.Text.Length == 0) { return false; }

            return true;


        }

        private void TeamMemberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TeamNameValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)SelectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }

        }   

        private void SelectTeamMemberDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMemberListBox.SelectedItem;

            if (p != null) 
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }
        }
    }
}
