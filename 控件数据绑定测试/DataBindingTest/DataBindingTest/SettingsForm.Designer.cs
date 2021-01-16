namespace DataBindingTest
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.peopleInfoControl1 = new DataBindingTest.PeopleInfoControl();
            this.SuspendLayout();
            // 
            // peopleInfoControl1
            // 
            this.peopleInfoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peopleInfoControl1.Location = new System.Drawing.Point(0, 0);
            this.peopleInfoControl1.Name = "peopleInfoControl1";
            this.peopleInfoControl1.Size = new System.Drawing.Size(318, 308);
            this.peopleInfoControl1.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 308);
            this.Controls.Add(this.peopleInfoControl1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PeopleInfoControl peopleInfoControl1;
    }
}