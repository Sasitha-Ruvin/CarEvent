namespace CarEvent.UserControls
{
    partial class ManageUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.removetext = new System.Windows.Forms.TextBox();
            this.removeEvent = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // removetext
            // 
            this.removetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removetext.Location = new System.Drawing.Point(478, 341);
            this.removetext.Name = "removetext";
            this.removetext.Size = new System.Drawing.Size(165, 29);
            this.removetext.TabIndex = 7;
            // 
            // removeEvent
            // 
            this.removeEvent.BackColor = System.Drawing.Color.Red;
            this.removeEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeEvent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEvent.ForeColor = System.Drawing.Color.White;
            this.removeEvent.Location = new System.Drawing.Point(656, 339);
            this.removeEvent.Name = "removeEvent";
            this.removeEvent.Size = new System.Drawing.Size(100, 33);
            this.removeEvent.TabIndex = 6;
            this.removeEvent.Text = "Remove";
            this.removeEvent.UseVisualStyleBackColor = false;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(39, 40);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(922, 281);
            this.dataGridViewUsers.TabIndex = 5;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removetext);
            this.Controls.Add(this.removeEvent);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "ManageUsers";
            this.Size = new System.Drawing.Size(1001, 412);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox removetext;
        private System.Windows.Forms.Button removeEvent;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
    }
}
