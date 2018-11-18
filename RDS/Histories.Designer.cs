namespace RDS
{
    partial class Histories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Histories));
            this.tbreg = new System.Windows.Forms.TabControl();
            this.tabdonatedhistory = new System.Windows.Forms.TabPage();
            this.grpuserHistories = new System.Windows.Forms.GroupBox();
            this.btnGetall = new System.Windows.Forms.Button();
            this.GriddonatedHistories = new System.Windows.Forms.DataGridView();
            this.lblsearchError = new System.Windows.Forms.Label();
            this.btnhistoryCancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbhistoryBlood = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txthistoeyname = new System.Windows.Forms.TextBox();
            this.GriddonatedHistories1 = new System.Windows.Forms.DataGridView();
            this.tbreg.SuspendLayout();
            this.tabdonatedhistory.SuspendLayout();
            this.grpuserHistories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GriddonatedHistories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GriddonatedHistories1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbreg
            // 
            this.tbreg.Controls.Add(this.tabdonatedhistory);
            this.tbreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbreg.Location = new System.Drawing.Point(2, 3);
            this.tbreg.Name = "tbreg";
            this.tbreg.SelectedIndex = 0;
            this.tbreg.Size = new System.Drawing.Size(1271, 600);
            this.tbreg.TabIndex = 1;
            // 
            // tabdonatedhistory
            // 
            this.tabdonatedhistory.Controls.Add(this.GriddonatedHistories1);
            this.tabdonatedhistory.Controls.Add(this.grpuserHistories);
            this.tabdonatedhistory.Location = new System.Drawing.Point(4, 25);
            this.tabdonatedhistory.Name = "tabdonatedhistory";
            this.tabdonatedhistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabdonatedhistory.Size = new System.Drawing.Size(1263, 571);
            this.tabdonatedhistory.TabIndex = 3;
            this.tabdonatedhistory.Text = "Donated Histories";
            this.tabdonatedhistory.UseVisualStyleBackColor = true;
            // 
            // grpuserHistories
            // 
            this.grpuserHistories.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpuserHistories.Controls.Add(this.btnGetall);
            this.grpuserHistories.Controls.Add(this.GriddonatedHistories);
            this.grpuserHistories.Controls.Add(this.lblsearchError);
            this.grpuserHistories.Controls.Add(this.btnhistoryCancel);
            this.grpuserHistories.Controls.Add(this.button2);
            this.grpuserHistories.Controls.Add(this.cmbhistoryBlood);
            this.grpuserHistories.Controls.Add(this.label11);
            this.grpuserHistories.Controls.Add(this.label12);
            this.grpuserHistories.Controls.Add(this.txthistoeyname);
            this.grpuserHistories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpuserHistories.Location = new System.Drawing.Point(7, 6);
            this.grpuserHistories.Name = "grpuserHistories";
            this.grpuserHistories.Size = new System.Drawing.Size(1251, 94);
            this.grpuserHistories.TabIndex = 5;
            this.grpuserHistories.TabStop = false;
            this.grpuserHistories.Text = "Blood Donated Histories";
            // 
            // btnGetall
            // 
            this.btnGetall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetall.Location = new System.Drawing.Point(729, 40);
            this.btnGetall.Name = "btnGetall";
            this.btnGetall.Size = new System.Drawing.Size(105, 23);
            this.btnGetall.TabIndex = 30;
            this.btnGetall.Text = "Get all data";
            this.btnGetall.UseVisualStyleBackColor = true;
            this.btnGetall.Click += new System.EventHandler(this.btnGetall_Click);
            // 
            // GriddonatedHistories
            // 
            this.GriddonatedHistories.AllowUserToAddRows = false;
            this.GriddonatedHistories.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.GriddonatedHistories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GriddonatedHistories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GriddonatedHistories.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GriddonatedHistories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GriddonatedHistories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GriddonatedHistories.Location = new System.Drawing.Point(-1, 100);
            this.GriddonatedHistories.Name = "GriddonatedHistories";
            this.GriddonatedHistories.ReadOnly = true;
            this.GriddonatedHistories.Size = new System.Drawing.Size(1251, 463);
            this.GriddonatedHistories.TabIndex = 4;
            // 
            // lblsearchError
            // 
            this.lblsearchError.AutoSize = true;
            this.lblsearchError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchError.ForeColor = System.Drawing.Color.Red;
            this.lblsearchError.Location = new System.Drawing.Point(347, 18);
            this.lblsearchError.Name = "lblsearchError";
            this.lblsearchError.Size = new System.Drawing.Size(170, 16);
            this.lblsearchError.TabIndex = 29;
            this.lblsearchError.Text = "No Matching Search Result";
            this.lblsearchError.Visible = false;
            // 
            // btnhistoryCancel
            // 
            this.btnhistoryCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhistoryCancel.Location = new System.Drawing.Point(856, 40);
            this.btnhistoryCancel.Name = "btnhistoryCancel";
            this.btnhistoryCancel.Size = new System.Drawing.Size(94, 23);
            this.btnhistoryCancel.TabIndex = 28;
            this.btnhistoryCancel.Text = "Clear All";
            this.btnhistoryCancel.UseVisualStyleBackColor = true;
            this.btnhistoryCancel.Click += new System.EventHandler(this.btnhistoryCancel_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(583, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbhistoryBlood
            // 
            this.cmbhistoryBlood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbhistoryBlood.DisplayMember = "Select";
            this.cmbhistoryBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbhistoryBlood.FormattingEnabled = true;
            this.cmbhistoryBlood.Location = new System.Drawing.Point(471, 40);
            this.cmbhistoryBlood.Name = "cmbhistoryBlood";
            this.cmbhistoryBlood.Size = new System.Drawing.Size(66, 24);
            this.cmbhistoryBlood.TabIndex = 25;
            this.cmbhistoryBlood.Tag = "";
            this.cmbhistoryBlood.Text = "Select";
            this.cmbhistoryBlood.ValueMember = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(359, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Blood Group *";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(44, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Name *";
            // 
            // txthistoeyname
            // 
            this.txthistoeyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthistoeyname.ForeColor = System.Drawing.Color.Black;
            this.txthistoeyname.Location = new System.Drawing.Point(117, 40);
            this.txthistoeyname.Name = "txthistoeyname";
            this.txthistoeyname.Size = new System.Drawing.Size(221, 22);
            this.txthistoeyname.TabIndex = 22;
            // 
            // GriddonatedHistories1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.GriddonatedHistories1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GriddonatedHistories1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GriddonatedHistories1.BackgroundColor = System.Drawing.Color.White;
            this.GriddonatedHistories1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GriddonatedHistories1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GriddonatedHistories1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GriddonatedHistories1.Location = new System.Drawing.Point(7, 106);
            this.GriddonatedHistories1.Name = "GriddonatedHistories1";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.GriddonatedHistories1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GriddonatedHistories1.ShowCellToolTips = false;
            this.GriddonatedHistories1.Size = new System.Drawing.Size(1251, 459);
            this.GriddonatedHistories1.TabIndex = 25;
            // 
            // Histories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 609);
            this.Controls.Add(this.tbreg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Histories";
            this.Text = "Histories";
            this.Load += new System.EventHandler(this.Histories_Load);
            this.tbreg.ResumeLayout(false);
            this.tabdonatedhistory.ResumeLayout(false);
            this.grpuserHistories.ResumeLayout(false);
            this.grpuserHistories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GriddonatedHistories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GriddonatedHistories1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbreg;
        private System.Windows.Forms.TabPage tabdonatedhistory;
        private System.Windows.Forms.GroupBox grpuserHistories;
        private System.Windows.Forms.Button btnGetall;
        private System.Windows.Forms.Label lblsearchError;
        private System.Windows.Forms.Button btnhistoryCancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbhistoryBlood;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txthistoeyname;
        private System.Windows.Forms.DataGridView GriddonatedHistories;
        private System.Windows.Forms.DataGridView GriddonatedHistories1;
    }
}