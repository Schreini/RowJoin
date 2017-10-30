namespace RowJoin.Views
{
    partial class MainView
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.CbxTemplate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TxtOutput = new DevExpress.XtraEditors.MemoEdit();
            this.TxtInput = new DevExpress.XtraEditors.MemoEdit();
            this.TxtFooter = new DevExpress.XtraEditors.TextEdit();
            this.TxtAfter = new DevExpress.XtraEditors.TextEdit();
            this.TxtBetween = new DevExpress.XtraEditors.TextEdit();
            this.TxtBefore = new DevExpress.XtraEditors.TextEdit();
            this.TxtHeader = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Header = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.BeforEach = new DevExpress.XtraLayout.LayoutControlItem();
            this.Input = new DevExpress.XtraLayout.LayoutControlItem();
            this.Output = new DevExpress.XtraLayout.LayoutControlItem();
            this.Footer = new DevExpress.XtraLayout.LayoutControlItem();
            this.BetweenEach = new DevExpress.XtraLayout.LayoutControlItem();
            this.AfterEach = new DevExpress.XtraLayout.LayoutControlItem();
            this.Template = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbxTemplate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOutput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFooter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAfter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBetween.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBefore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeforEach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Footer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetweenEach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AfterEach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Template)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.CbxTemplate);
            this.layoutControl1.Controls.Add(this.TxtOutput);
            this.layoutControl1.Controls.Add(this.TxtInput);
            this.layoutControl1.Controls.Add(this.TxtFooter);
            this.layoutControl1.Controls.Add(this.TxtAfter);
            this.layoutControl1.Controls.Add(this.TxtBetween);
            this.layoutControl1.Controls.Add(this.TxtBefore);
            this.layoutControl1.Controls.Add(this.TxtHeader);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(786, 241, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(894, 489);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CbxTemplate
            // 
            this.CbxTemplate.EditValue = "Select * From $TABLE$ where $COLUMN$ like \'%...%\' or ...";
            this.CbxTemplate.Location = new System.Drawing.Point(83, 12);
            this.CbxTemplate.Name = "CbxTemplate";
            this.CbxTemplate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbxTemplate.Properties.Items.AddRange(new object[] {
            "Select * From $TABLE$ where $COLUMN$ like \'%...%\' or ...",
            "(\'...\', ...)"});
            this.CbxTemplate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CbxTemplate.Size = new System.Drawing.Size(799, 20);
            this.CbxTemplate.StyleController = this.layoutControl1;
            this.CbxTemplate.TabIndex = 11;
            this.CbxTemplate.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // TxtOutput
            // 
            this.TxtOutput.Location = new System.Drawing.Point(520, 156);
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.TxtOutput.Properties.Appearance.Options.UseFont = true;
            this.TxtOutput.Properties.ReadOnly = true;
            this.TxtOutput.Size = new System.Drawing.Size(362, 321);
            this.TxtOutput.StyleController = this.layoutControl1;
            this.TxtOutput.TabIndex = 10;
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(83, 156);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.TxtInput.Properties.Appearance.Options.UseFont = true;
            this.TxtInput.Size = new System.Drawing.Size(362, 321);
            this.TxtInput.StyleController = this.layoutControl1;
            this.TxtInput.TabIndex = 9;
            this.TxtInput.TextChanged += new System.EventHandler(this.TxtHeader_TextChanged);
            // 
            // TxtFooter
            // 
            this.TxtFooter.EditValue = ")";
            this.TxtFooter.Location = new System.Drawing.Point(83, 132);
            this.TxtFooter.Name = "TxtFooter";
            this.TxtFooter.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.TxtFooter.Properties.Appearance.Options.UseFont = true;
            this.TxtFooter.Size = new System.Drawing.Size(799, 20);
            this.TxtFooter.StyleController = this.layoutControl1;
            this.TxtFooter.TabIndex = 8;
            this.TxtFooter.TextChanged += new System.EventHandler(this.TxtHeader_TextChanged);
            // 
            // TxtAfter
            // 
            this.TxtAfter.EditValue = "\'";
            this.TxtAfter.Location = new System.Drawing.Point(83, 108);
            this.TxtAfter.Name = "TxtAfter";
            this.TxtAfter.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.TxtAfter.Properties.Appearance.Options.UseFont = true;
            this.TxtAfter.Size = new System.Drawing.Size(799, 20);
            this.TxtAfter.StyleController = this.layoutControl1;
            this.TxtAfter.TabIndex = 7;
            this.TxtAfter.TextChanged += new System.EventHandler(this.TxtHeader_TextChanged);
            // 
            // TxtBetween
            // 
            this.TxtBetween.EditValue = ", ";
            this.TxtBetween.Location = new System.Drawing.Point(83, 84);
            this.TxtBetween.Name = "TxtBetween";
            this.TxtBetween.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.TxtBetween.Properties.Appearance.Options.UseFont = true;
            this.TxtBetween.Size = new System.Drawing.Size(799, 20);
            this.TxtBetween.StyleController = this.layoutControl1;
            this.TxtBetween.TabIndex = 6;
            this.TxtBetween.TextChanged += new System.EventHandler(this.TxtHeader_TextChanged);
            // 
            // TxtBefore
            // 
            this.TxtBefore.EditValue = "\'";
            this.TxtBefore.Location = new System.Drawing.Point(83, 60);
            this.TxtBefore.Name = "TxtBefore";
            this.TxtBefore.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.TxtBefore.Properties.Appearance.Options.UseFont = true;
            this.TxtBefore.Size = new System.Drawing.Size(799, 20);
            this.TxtBefore.StyleController = this.layoutControl1;
            this.TxtBefore.TabIndex = 5;
            this.TxtBefore.TextChanged += new System.EventHandler(this.TxtHeader_TextChanged);
            // 
            // TxtHeader
            // 
            this.TxtHeader.EditValue = "(";
            this.TxtHeader.Location = new System.Drawing.Point(83, 36);
            this.TxtHeader.Name = "TxtHeader";
            this.TxtHeader.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.TxtHeader.Properties.Appearance.Options.UseFont = true;
            this.TxtHeader.Size = new System.Drawing.Size(799, 20);
            this.TxtHeader.StyleController = this.layoutControl1;
            this.TxtHeader.TabIndex = 4;
            this.TxtHeader.TextChanged += new System.EventHandler(this.TxtHeader_TextChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Header,
            this.emptySpaceItem1,
            this.BeforEach,
            this.Input,
            this.Output,
            this.Footer,
            this.BetweenEach,
            this.AfterEach,
            this.Template});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 50D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 50D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition6.Height = 24D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition7.Height = 100D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6,
            rowDefinition7});
            this.layoutControlGroup1.Size = new System.Drawing.Size(894, 489);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // Header
            // 
            this.Header.Control = this.TxtHeader;
            this.Header.Location = new System.Drawing.Point(0, 24);
            this.Header.Name = "Header";
            this.Header.OptionsTableLayoutItem.ColumnSpan = 2;
            this.Header.OptionsTableLayoutItem.RowIndex = 1;
            this.Header.Size = new System.Drawing.Size(874, 24);
            this.Header.TextSize = new System.Drawing.Size(68, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(437, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.OptionsTableLayoutItem.ColumnIndex = 1;
            this.emptySpaceItem1.OptionsTableLayoutItem.RowIndex = 1;
            this.emptySpaceItem1.Size = new System.Drawing.Size(437, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // BeforEach
            // 
            this.BeforEach.Control = this.TxtBefore;
            this.BeforEach.Location = new System.Drawing.Point(0, 48);
            this.BeforEach.Name = "BeforEach";
            this.BeforEach.OptionsTableLayoutItem.ColumnSpan = 2;
            this.BeforEach.OptionsTableLayoutItem.RowIndex = 2;
            this.BeforEach.Size = new System.Drawing.Size(874, 24);
            this.BeforEach.Text = "Befor each";
            this.BeforEach.TextSize = new System.Drawing.Size(68, 13);
            // 
            // Input
            // 
            this.Input.Control = this.TxtInput;
            this.Input.Location = new System.Drawing.Point(0, 144);
            this.Input.Name = "Input";
            this.Input.OptionsTableLayoutItem.RowIndex = 6;
            this.Input.Size = new System.Drawing.Size(437, 325);
            this.Input.TextSize = new System.Drawing.Size(68, 13);
            // 
            // Output
            // 
            this.Output.Control = this.TxtOutput;
            this.Output.Location = new System.Drawing.Point(437, 144);
            this.Output.Name = "Output";
            this.Output.OptionsTableLayoutItem.ColumnIndex = 1;
            this.Output.OptionsTableLayoutItem.RowIndex = 6;
            this.Output.Size = new System.Drawing.Size(437, 325);
            this.Output.TextSize = new System.Drawing.Size(68, 13);
            // 
            // Footer
            // 
            this.Footer.Control = this.TxtFooter;
            this.Footer.Location = new System.Drawing.Point(0, 120);
            this.Footer.Name = "Footer";
            this.Footer.OptionsTableLayoutItem.ColumnSpan = 2;
            this.Footer.OptionsTableLayoutItem.RowIndex = 5;
            this.Footer.Size = new System.Drawing.Size(874, 24);
            this.Footer.TextSize = new System.Drawing.Size(68, 13);
            // 
            // BetweenEach
            // 
            this.BetweenEach.Control = this.TxtBetween;
            this.BetweenEach.Location = new System.Drawing.Point(0, 72);
            this.BetweenEach.Name = "BetweenEach";
            this.BetweenEach.OptionsTableLayoutItem.ColumnSpan = 2;
            this.BetweenEach.OptionsTableLayoutItem.RowIndex = 3;
            this.BetweenEach.Size = new System.Drawing.Size(874, 24);
            this.BetweenEach.Text = "Between each";
            this.BetweenEach.TextSize = new System.Drawing.Size(68, 13);
            // 
            // AfterEach
            // 
            this.AfterEach.Control = this.TxtAfter;
            this.AfterEach.Location = new System.Drawing.Point(0, 96);
            this.AfterEach.Name = "AfterEach";
            this.AfterEach.OptionsTableLayoutItem.ColumnSpan = 2;
            this.AfterEach.OptionsTableLayoutItem.RowIndex = 4;
            this.AfterEach.Size = new System.Drawing.Size(874, 24);
            this.AfterEach.Text = "After each";
            this.AfterEach.TextSize = new System.Drawing.Size(68, 13);
            // 
            // Template
            // 
            this.Template.Control = this.CbxTemplate;
            this.Template.Location = new System.Drawing.Point(0, 0);
            this.Template.Name = "Template";
            this.Template.OptionsTableLayoutItem.ColumnSpan = 2;
            this.Template.Size = new System.Drawing.Size(874, 24);
            this.Template.TextSize = new System.Drawing.Size(68, 13);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 489);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.Text = "RowJoin";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CbxTemplate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOutput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFooter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAfter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBetween.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBefore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeforEach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Footer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetweenEach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AfterEach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Template)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit TxtFooter;
        private DevExpress.XtraEditors.TextEdit TxtAfter;
        private DevExpress.XtraEditors.TextEdit TxtBetween;
        private DevExpress.XtraEditors.TextEdit TxtBefore;
        private DevExpress.XtraEditors.TextEdit TxtHeader;
        private DevExpress.XtraLayout.LayoutControlItem Header;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem BeforEach;
        private DevExpress.XtraEditors.MemoEdit TxtOutput;
        private DevExpress.XtraEditors.MemoEdit TxtInput;
        private DevExpress.XtraLayout.LayoutControlItem Input;
        private DevExpress.XtraLayout.LayoutControlItem Output;
        private DevExpress.XtraLayout.LayoutControlItem Footer;
        private DevExpress.XtraLayout.LayoutControlItem BetweenEach;
        private DevExpress.XtraLayout.LayoutControlItem AfterEach;
        private DevExpress.XtraEditors.ComboBoxEdit CbxTemplate;
        private DevExpress.XtraLayout.LayoutControlItem Template;
    }
}