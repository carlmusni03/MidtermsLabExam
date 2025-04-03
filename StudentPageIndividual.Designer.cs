using System.Windows.Forms;

namespace MidtermsLabExam
{
    partial class StudentPageIndividual
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblStudentId, lblFullName, lblAddress, lblBirthdate, lblAge, lblContact, lblEmail, lblGuardian, lblHobbies, lblNickname, lblCourse, lblYear;
        private System.Windows.Forms.Label lblStudentIdValue, lblFullNameValue, lblAddressValue, lblBirthdateValue, lblAgeValue, lblContactValue, lblEmailValue, lblGuardianValue, lblHobbiesValue, lblNicknameValue, lblCourseValue, lblYearValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Labels (Static Text)
            lblStudentId = new System.Windows.Forms.Label();
            lblFullName = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblBirthdate = new System.Windows.Forms.Label();
            lblAge = new System.Windows.Forms.Label();
            lblContact = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblGuardian = new System.Windows.Forms.Label();
            lblHobbies = new System.Windows.Forms.Label();
            lblNickname = new System.Windows.Forms.Label();
            lblCourse = new System.Windows.Forms.Label();
            lblYear = new System.Windows.Forms.Label();

            // Labels (Dynamic Text)
            lblStudentIdValue = new System.Windows.Forms.Label();
            lblFullNameValue = new System.Windows.Forms.Label();
            lblAddressValue = new System.Windows.Forms.Label();
            lblBirthdateValue = new System.Windows.Forms.Label();
            lblAgeValue = new System.Windows.Forms.Label();
            lblContactValue = new System.Windows.Forms.Label();
            lblEmailValue = new System.Windows.Forms.Label();
            lblGuardianValue = new System.Windows.Forms.Label();
            lblHobbiesValue = new System.Windows.Forms.Label();
            lblNicknameValue = new System.Windows.Forms.Label();
            lblCourseValue = new System.Windows.Forms.Label();
            lblYearValue = new System.Windows.Forms.Label();

            // Set Text
            lblStudentId.Text = "Student ID:";
            lblFullName.Text = "Full Name:";
            lblAddress.Text = "Address:";
            lblBirthdate.Text = "Birthdate:";
            lblAge.Text = "Age:";
            lblContact.Text = "Contact No.:";
            lblEmail.Text = "Email:";
            lblGuardian.Text = "Guardian:";
            lblHobbies.Text = "Hobbies:";
            lblNickname.Text = "Nickname:";
            lblCourse.Text = "Course:";
            lblYear.Text = "Year Level:";

            // Set Positions
            int xLabel = 20, xValue = 150, y = 20, gap = 30;
            lblStudentId.SetBounds(xLabel, y, 120, 25);
            lblStudentIdValue.SetBounds(xValue, y, 200, 25);
            y += gap;

            lblFullName.SetBounds(xLabel, y, 120, 25);
            lblFullNameValue.SetBounds(xValue, y, 250, 25);
            y += gap;

            lblAddress.SetBounds(xLabel, y, 120, 25);
            lblAddressValue.SetBounds(xValue, y, 400, 25);
            y += gap;

            lblBirthdate.SetBounds(xLabel, y, 120, 25);
            lblBirthdateValue.SetBounds(xValue, y, 150, 25);
            y += gap;

            lblAge.SetBounds(xLabel, y, 120, 25);
            lblAgeValue.SetBounds(xValue, y, 100, 25);
            y += gap;

            lblContact.SetBounds(xLabel, y, 120, 25);
            lblContactValue.SetBounds(xValue, y, 200, 25);
            y += gap;

            lblEmail.SetBounds(xLabel, y, 120, 25);
            lblEmailValue.SetBounds(xValue, y, 250, 25);
            y += gap;

            lblGuardian.SetBounds(xLabel, y, 120, 25);
            lblGuardianValue.SetBounds(xValue, y, 250, 25);
            y += gap;

            lblHobbies.SetBounds(xLabel, y, 120, 25);
            lblHobbiesValue.SetBounds(xValue, y, 300, 25);
            y += gap;

            lblNickname.SetBounds(xLabel, y, 120, 25);
            lblNicknameValue.SetBounds(xValue, y, 200, 25);
            y += gap;

            lblCourse.SetBounds(xLabel, y, 120, 25);
            lblCourseValue.SetBounds(xValue, y, 200, 25);
            y += gap;

            lblYear.SetBounds(xLabel, y, 120, 25);
            lblYearValue.SetBounds(xValue, y, 100, 25);
            y += gap;

            // Add Controls
            this.Controls.AddRange(new Control[] {
                lblStudentId, lblStudentIdValue,
                lblFullName, lblFullNameValue,
                lblAddress, lblAddressValue,
                lblBirthdate, lblBirthdateValue,
                lblAge, lblAgeValue,
                lblContact, lblContactValue,
                lblEmail, lblEmailValue,
                lblGuardian, lblGuardianValue,
                lblHobbies, lblHobbiesValue,
                lblNickname, lblNicknameValue,
                lblCourse, lblCourseValue,
                lblYear, lblYearValue
            });

            // Form Settings
            this.Text = "Student Details";
            this.Size = new System.Drawing.Size(600, y + 50);
            this.Load += new System.EventHandler(this.StudentPageIndividual_Load);
            this.ResumeLayout(false);
        }
    }
}
