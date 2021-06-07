namespace cadino_trade
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnorder = new FontAwesome.Sharp.IconButton();
            this.txtpid = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.cmbtable = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Binary X CHR BRK", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(57, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbtable);
            this.groupBox1.Controls.Add(this.btnorder);
            this.groupBox1.Controls.Add(this.txtpid);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 292);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request";
            // 
            // btnorder
            // 
            this.btnorder.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorder.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnorder.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.ForeColor = System.Drawing.Color.Red;
            this.btnorder.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnorder.IconColor = System.Drawing.Color.Red;
            this.btnorder.IconSize = 30;
            this.btnorder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorder.Location = new System.Drawing.Point(16, 191);
            this.btnorder.Name = "btnorder";
            this.btnorder.Rotation = 0D;
            this.btnorder.Size = new System.Drawing.Size(200, 64);
            this.btnorder.TabIndex = 3;
            this.btnorder.Text = "Search";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // txtpid
            // 
            this.txtpid.AcceptsReturn = false;
            this.txtpid.AcceptsTab = false;
            this.txtpid.AnimationSpeed = 200;
            this.txtpid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpid.BackColor = System.Drawing.Color.Transparent;
            this.txtpid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtpid.BackgroundImage")));
            this.txtpid.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtpid.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtpid.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtpid.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtpid.BorderRadius = 1;
            this.txtpid.BorderThickness = 1;
            this.txtpid.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtpid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpid.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtpid.DefaultText = "";
            this.txtpid.FillColor = System.Drawing.Color.Black;
            this.txtpid.HideSelection = true;
            this.txtpid.IconLeft = null;
            this.txtpid.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpid.IconPadding = 10;
            this.txtpid.IconRight = null;
            this.txtpid.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpid.Lines = new string[0];
            this.txtpid.Location = new System.Drawing.Point(16, 111);
            this.txtpid.MaxLength = 32767;
            this.txtpid.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtpid.Modified = false;
            this.txtpid.Multiline = false;
            this.txtpid.Name = "txtpid";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtpid.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Empty;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtpid.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtpid.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.Black;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtpid.OnIdleState = stateProperties12;
            this.txtpid.PasswordChar = '\0';
            this.txtpid.PlaceholderForeColor = System.Drawing.Color.Red;
            this.txtpid.PlaceholderText = "Enter PID";
            this.txtpid.ReadOnly = false;
            this.txtpid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpid.SelectedText = "";
            this.txtpid.SelectionLength = 0;
            this.txtpid.SelectionStart = 0;
            this.txtpid.ShortcutsEnabled = true;
            this.txtpid.Size = new System.Drawing.Size(200, 35);
            this.txtpid.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtpid.TabIndex = 1;
            this.txtpid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpid.TextMarginBottom = 0;
            this.txtpid.TextMarginLeft = 5;
            this.txtpid.TextMarginTop = 0;
            this.txtpid.TextPlaceholder = "Enter PID";
            this.txtpid.UseSystemPasswordChar = false;
            this.txtpid.WordWrap = true;
            // 
            // cmbtable
            // 
            this.cmbtable.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbtable.BorderRadius = 13;
            this.cmbtable.Color = System.Drawing.Color.Red;
            this.cmbtable.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbtable.DisabledColor = System.Drawing.Color.Gray;
            this.cmbtable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbtable.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.cmbtable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtable.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbtable.FillDropDown = false;
            this.cmbtable.FillIndicator = true;
            this.cmbtable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbtable.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtable.ForeColor = System.Drawing.Color.Red;
            this.cmbtable.FormattingEnabled = true;
            this.cmbtable.Icon = null;
            this.cmbtable.IndicatorColor = System.Drawing.Color.Red;
            this.cmbtable.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbtable.ItemBackColor = System.Drawing.Color.White;
            this.cmbtable.ItemBorderColor = System.Drawing.Color.White;
            this.cmbtable.ItemForeColor = System.Drawing.Color.Purple;
            this.cmbtable.ItemHeight = 26;
            this.cmbtable.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.cmbtable.Items.AddRange(new object[] {
            "Return Product"});
            this.cmbtable.Location = new System.Drawing.Point(7, 33);
            this.cmbtable.Name = "cmbtable";
            this.cmbtable.Size = new System.Drawing.Size(216, 32);
            this.cmbtable.TabIndex = 7;
            this.cmbtable.Text = "Return Product";
            // 
            // dgv
            // 
            this.dgv.AllowCustomTheming = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.ColumnHeadersHeight = 40;
            this.dgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.CurrentTheme.Name = null;
            this.dgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv.HeaderForeColor = System.Drawing.Color.White;
            this.dgv.Location = new System.Drawing.Point(256, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 40;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(460, 461);
            this.dgv.TabIndex = 7;
            this.dgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(728, 485);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnorder;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtpid;
        private Bunifu.UI.WinForms.BunifuDropdown cmbtable;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv;
    }
}