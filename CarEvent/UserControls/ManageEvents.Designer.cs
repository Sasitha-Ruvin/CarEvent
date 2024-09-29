namespace CarEvent.UserControls
{
    partial class ManageEvents
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
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.removeEvent = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.removetext = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Location = new System.Drawing.Point(37, 59);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.Size = new System.Drawing.Size(922, 281);
            this.dataGridViewEvents.TabIndex = 0;
            this.dataGridViewEvents.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEvents_CellContentDoubleClick);
            // 
            // removeEvent
            // 
            this.removeEvent.BackColor = System.Drawing.Color.Red;
            this.removeEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeEvent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEvent.ForeColor = System.Drawing.Color.White;
            this.removeEvent.Location = new System.Drawing.Point(654, 358);
            this.removeEvent.Name = "removeEvent";
            this.removeEvent.Size = new System.Drawing.Size(100, 33);
            this.removeEvent.TabIndex = 2;
            this.removeEvent.Text = "Remove";
            this.removeEvent.UseVisualStyleBackColor = false;
            this.removeEvent.Click += new System.EventHandler(this.removeEvent_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(859, 20);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 33);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removetext
            // 
            this.removetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removetext.Location = new System.Drawing.Point(476, 360);
            this.removetext.Name = "removetext";
            this.removetext.Size = new System.Drawing.Size(165, 29);
            this.removetext.TabIndex = 4;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.DarkSlateGray;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(772, 358);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 33);
            this.update.TabIndex = 5;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // ManageEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.update);
            this.Controls.Add(this.removetext);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.removeEvent);
            this.Controls.Add(this.dataGridViewEvents);
            this.Name = "ManageEvents";
            this.Size = new System.Drawing.Size(1001, 412);
            this.Load += new System.EventHandler(this.ManageEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.Button removeEvent;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox removetext;
        private System.Windows.Forms.Button update;
    }
}
