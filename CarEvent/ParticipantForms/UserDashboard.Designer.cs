namespace CarEvent.ParticipantForms
{
    partial class UserDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookinhBng = new System.Windows.Forms.Button();
            this.userMng = new System.Windows.Forms.Button();
            this.eventMngBtn = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // bookinhBng
            // 
            this.bookinhBng.BackColor = System.Drawing.Color.DarkRed;
            this.bookinhBng.FlatAppearance.BorderSize = 0;
            this.bookinhBng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookinhBng.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookinhBng.ForeColor = System.Drawing.Color.White;
            this.bookinhBng.Location = new System.Drawing.Point(823, 494);
            this.bookinhBng.Name = "bookinhBng";
            this.bookinhBng.Size = new System.Drawing.Size(113, 39);
            this.bookinhBng.TabIndex = 6;
            this.bookinhBng.Text = "Logout";
            this.bookinhBng.UseVisualStyleBackColor = false;
            this.bookinhBng.Click += new System.EventHandler(this.bookinhBng_Click);
            // 
            // userMng
            // 
            this.userMng.BackColor = System.Drawing.Color.DarkRed;
            this.userMng.FlatAppearance.BorderSize = 0;
            this.userMng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userMng.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMng.ForeColor = System.Drawing.Color.White;
            this.userMng.Location = new System.Drawing.Point(498, 76);
            this.userMng.Name = "userMng";
            this.userMng.Size = new System.Drawing.Size(260, 53);
            this.userMng.TabIndex = 5;
            this.userMng.Text = "My Bookings";
            this.userMng.UseVisualStyleBackColor = false;
            this.userMng.Click += new System.EventHandler(this.userMng_Click);
            // 
            // eventMngBtn
            // 
            this.eventMngBtn.BackColor = System.Drawing.Color.DarkRed;
            this.eventMngBtn.FlatAppearance.BorderSize = 0;
            this.eventMngBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventMngBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventMngBtn.ForeColor = System.Drawing.Color.White;
            this.eventMngBtn.Location = new System.Drawing.Point(195, 76);
            this.eventMngBtn.Name = "eventMngBtn";
            this.eventMngBtn.Size = new System.Drawing.Size(217, 53);
            this.eventMngBtn.TabIndex = 4;
            this.eventMngBtn.Text = "Book Event";
            this.eventMngBtn.UseVisualStyleBackColor = false;
            this.eventMngBtn.Click += new System.EventHandler(this.eventMngBtn_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.dataGridView1);
            this.panelContainer.Location = new System.Drawing.Point(12, 135);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(913, 353);
            this.panelContainer.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(910, 353);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(886, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(47, 36);
            this.closeBtn.TabIndex = 38;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarEvent.Properties.Resources.usercar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 533);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.bookinhBng);
            this.Controls.Add(this.userMng);
            this.Controls.Add(this.eventMngBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bookinhBng;
        private System.Windows.Forms.Button userMng;
        private System.Windows.Forms.Button eventMngBtn;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}