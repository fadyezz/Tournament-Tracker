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
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {

        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();

        List<TeamModel> selectedTeams = new List<TeamModel>();


        List<PrizeModel> selectedPrizes = new List<PrizeModel>();


        public CreateTournamentForm()
        {
            InitializeComponent();


            WireUpLists();
        }


        private void WireUpLists()
        {
            SelectTeamDropDown.DataSource = null;
            SelectTeamDropDown.DataSource = availableTeams;
            SelectTeamDropDown.DisplayMember = "TeamName";
            TournamentTeamListBox.DataSource = null;
            TournamentTeamListBox.DataSource = selectedTeams;
            TournamentTeamListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void TeamOneScoreValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectTeamDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TournamentPlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)SelectTeamDropDown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            // call the create prize form get from ot the data
            // take the prize model and put it into our lists of selected prizes

            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();

        }

        private void CreateNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void RemoveSelectedPlayersButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)TournamentTeamListBox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
        }

        private void prizesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrizeModel t = (PrizeModel)prizesListBox.SelectedItem;
            if (t != null)
            {
                selectedPrizes.Remove(t);

                WireUpLists();

            }
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            decimal fee = 0;
            bool feeACceptable  = decimal.TryParse(EntreFeeValue.Text,out fee);

            if (!feeACceptable)
            {
                MessageBox.Show("You Enter Invalid Fee","Invalid Fee" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TournamentModel tm = new TournamentModel();

            tm.TournamentName = TournamentName.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // wire our matchups
            // order the list random
            //create our first round of match ups
            // create every round after that 8 matchups - 4 matchups - 2 matchups - 1 matchups

            TournamentLogic.CreateRounds(tm);


            GlobalConfig.Connection.CreateTournament(tm);



        }
    }
}
