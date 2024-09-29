namespace CarEvent.AdminForms
{
    partial class AdminDashboard
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
            this.eventMngBtn = new System.Windows.Forms.Button();
            this.userMng = new System.Windows.Forms.Button();
            this.bookinhBng = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            // 
            // eventMngBtn
            // 
            this.eventMngBtn.BackColor = System.Drawing.Color.DarkRed;
            this.eventMngBtn.FlatAppearance.BorderSize = 0;
            this.eventMngBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventMngBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventMngBtn.ForeColor = System.Drawing.Color.White;
            this.eventMngBtn.Location = new System.Drawing.Point(33, 61);
            this.eventMngBtn.Name = "eventMngBtn";
            this.eventMngBtn.Size = new System.Drawing.Size(217, 53);
            this.eventMngBtn.TabIndex = 1;
            this.eventMngBtn.Text = "Manage Events";
            this.eventMngBtn.UseVisualStyleBackColor = false;
            this.eventMngBtn.Click += new System.EventHandler(this.eventMngBtn_Click);
            // 
            // userMng
            // 
            this.userMng.BackColor = System.Drawing.Color.DarkRed;
            this.userMng.FlatAppearance.BorderSize = 0;
            this.userMng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userMng.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMng.ForeColor = System.Drawing.Color.White;
            this.userMng.Location = new System.Drawing.Point(323, 61);
            this.userMng.Name = "userMng";
            this.userMng.Size = new System.Drawing.Size(260, 53);
            this.userMng.TabIndex = 2;
            this.userMng.Text = "Manage Participants";
            this.userMng.UseVisualStyleBackColor = false;
            this.userMng.Click += new System.EventHandler(this.userMng_Click);
            // 
            // bookinhBng
            // 
            this.bookinhBng.BackColor = System.Drawing.Color.DarkRed;
            this.bookinhBng.FlatAppearance.BorderSize = 0;
            this.bookinhBng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookinhBng.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookinhBng.ForeColor = System.Drawing.Color.White;
            this.bookinhBng.Location = new System.Drawing.Point(622, 61);
            this.bookinhBng.Name = "bookinhBng";
            this.bookinhBng.Size = new System.Drawing.Size(260, 53);
            this.bookinhBng.TabIndex = 3;
            this.bookinhBng.Text = "View Bookings";
            this.bookinhBng.UseVisualStyleBackColor = false;
            this.bookinhBng.Click += new System.EventHandler(this.bookinhBng_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.dataGridViewBookings);
            this.panelContainer.Controls.Add(this.dataGridViewEvents);
            this.panelContainer.Location = new System.Drawing.Point(12, 132);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1001, 412);
            this.panelContainer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(699, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bookings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Events";
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Location = new System.Drawing.Point(546, 86);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.Size = new System.Drawing.Size(424, 290);
            this.dataGridViewBookings.TabIndex = 6;
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Location = new System.Drawing.Point(44, 86);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.Size = new System.Drawing.Size(424, 290);
            this.dataGridViewEvents.TabIndex = 5;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(975, -1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(47, 36);
            this.closeBtn.TabIndex = 38;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarEvent.Properties.Resources.caradmin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 556);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.bookinhBng);
            this.Controls.Add(this.userMng);
            this.Controls.Add(this.eventMngBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eventMngBtn;
        private System.Windows.Forms.Button userMng;
        private System.Windows.Forms.Button bookinhBng;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.Button closeBtn;
    }
}