using System.Windows.Forms;

namespace MidtermsLabExam
{
    partial class StudentPage
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewStudents;
        private Button btnView;

        private void InitializeComponent()
        {
            this.dataGridViewStudents = new DataGridView();
            this.btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(760, 350);
            this.dataGridViewStudents.TabIndex = 0;

            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(12, 375);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);

            // 
            // StudentPage
            // 
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "StudentPage";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.StudentPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
