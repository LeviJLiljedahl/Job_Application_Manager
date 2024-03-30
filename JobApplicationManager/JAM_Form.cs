namespace JobApplicationManager
{
    public partial class JAM_Form : Form
    {
        public JAM_Form()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
        }

        private void applicationsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void JAM_Form_Load(object sender, EventArgs e)
        {

        }

        private void ClearCompanyInfo()
        {
            cNameTextBox.Text = string.Empty;
            cAboutTextBox.Text = string.Empty;
            cAddressTextBox.Text = string.Empty;
            cManagerTextBox.Text = string.Empty;
            cEmailTextBox.Text = string.Empty;
        }

        private void ClearApplicationInfo()
        {
            aDateTextBox.Text = string.Empty;
            aSinceTextBox.Text = string.Empty;
            aTypeComboBox.Text = string.Empty;
            aWebsiteTextBox.Text = string.Empty;
            aCloseTextBox.Text = string.Empty;
            aStatusComboBox.Text = string.Empty;
        }

        private void ClearExtraInfo()
        {
            eNotesTextBox.Text = string.Empty;
            eExtrasTextBox.Text = string.Empty;
            eFitComboBox.Text = string.Empty;
            eInterestComboBox.Text = string.Empty;
        }

        private void ClearJobInfo()
        {
            jTitleTextBox.Text = string.Empty;
            jRemoteComboBox.Text = string.Empty;
            jExperienceComboBox.Text = string.Empty;
            jRateTextBox.Text = string.Empty;
            jPayTypeComboBox.Text = string.Empty;
            jDocumentTextBox.Text = string.Empty;
            jTypeComboBox.Text= string.Empty;
            jLocationTextBox.Text = string.Empty;
            jAboutTextBox.Text = string.Empty;
            jSkillsTextBox.Text = string.Empty;
            jResponsibilitesTextBox.Text = string.Empty;
            jQualificationsTextBox.Text = string.Empty;
            jPreferredTextBox.Text = string.Empty;
            jEducationTextBox.Text = string.Empty;
        }

        private void ClearAllTextBoxes()
        {
            ClearCompanyInfo();
            ClearApplicationInfo();
            ClearExtraInfo();
            ClearJobInfo();
        }
    }
}
