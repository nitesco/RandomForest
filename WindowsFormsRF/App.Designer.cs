namespace WindowsFormsRF
{
    partial class App
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenTrainingButton = new System.Windows.Forms.Button();
            this.MaxTreeDepthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfigBox = new System.Windows.Forms.GroupBox();
            this.MinItemsCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ThresholdUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfTreesUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buildingButton = new System.Windows.Forms.Button();
            this.LoadBox = new System.Windows.Forms.GroupBox();
            this.OpenInputButton = new System.Windows.Forms.Button();
            this.CommandBox = new System.Windows.Forms.GroupBox();
            this.classifyButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.resultsTab = new System.Windows.Forms.TabPage();
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            this.inputTab = new System.Windows.Forms.TabPage();
            this.inputGridView = new System.Windows.Forms.DataGridView();
            this.trainingTab = new System.Windows.Forms.TabPage();
            this.trainingGridView = new System.Windows.Forms.DataGridView();
            this.DataTabs = new System.Windows.Forms.TabControl();
            this.DataBox = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTreeDepthUpDown)).BeginInit();
            this.ConfigBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinItemsCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfTreesUpDown)).BeginInit();
            this.LoadBox.SuspendLayout();
            this.CommandBox.SuspendLayout();
            this.resultsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            this.inputTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputGridView)).BeginInit();
            this.trainingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingGridView)).BeginInit();
            this.DataTabs.SuspendLayout();
            this.DataBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // OpenTrainingButton
            // 
            this.OpenTrainingButton.Location = new System.Drawing.Point(5, 17);
            this.OpenTrainingButton.Name = "OpenTrainingButton";
            this.OpenTrainingButton.Size = new System.Drawing.Size(110, 24);
            this.OpenTrainingButton.TabIndex = 1;
            this.OpenTrainingButton.Text = "Open Training File";
            this.OpenTrainingButton.UseVisualStyleBackColor = true;
            this.OpenTrainingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaxTreeDepthUpDown
            // 
            this.MaxTreeDepthUpDown.Location = new System.Drawing.Point(248, 13);
            this.MaxTreeDepthUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxTreeDepthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxTreeDepthUpDown.Name = "MaxTreeDepthUpDown";
            this.MaxTreeDepthUpDown.Size = new System.Drawing.Size(44, 20);
            this.MaxTreeDepthUpDown.TabIndex = 2;
            this.MaxTreeDepthUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.MaxTreeDepthUpDown.ValueChanged += new System.EventHandler(this.MaxTreeDepthUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of trees";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConfigBox
            // 
            this.ConfigBox.Controls.Add(this.MinItemsCountUpDown);
            this.ConfigBox.Controls.Add(this.label4);
            this.ConfigBox.Controls.Add(this.ThresholdUpDown);
            this.ConfigBox.Controls.Add(this.label3);
            this.ConfigBox.Controls.Add(this.NumberOfTreesUpDown);
            this.ConfigBox.Controls.Add(this.label2);
            this.ConfigBox.Controls.Add(this.label1);
            this.ConfigBox.Controls.Add(this.MaxTreeDepthUpDown);
            this.ConfigBox.Enabled = false;
            this.ConfigBox.Location = new System.Drawing.Point(140, 12);
            this.ConfigBox.Name = "ConfigBox";
            this.ConfigBox.Size = new System.Drawing.Size(308, 84);
            this.ConfigBox.TabIndex = 4;
            this.ConfigBox.TabStop = false;
            this.ConfigBox.Text = "Configuration";
            this.ConfigBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MinItemsCountUpDown
            // 
            this.MinItemsCountUpDown.Location = new System.Drawing.Point(94, 47);
            this.MinItemsCountUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MinItemsCountUpDown.Name = "MinItemsCountUpDown";
            this.MinItemsCountUpDown.Size = new System.Drawing.Size(44, 20);
            this.MinItemsCountUpDown.TabIndex = 9;
            this.MinItemsCountUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MinItemsCountUpDown.ValueChanged += new System.EventHandler(this.MinItemsCountUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Min items split";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ThresholdUpDown
            // 
            this.ThresholdUpDown.DecimalPlaces = 2;
            this.ThresholdUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ThresholdUpDown.Location = new System.Drawing.Point(248, 47);
            this.ThresholdUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ThresholdUpDown.Name = "ThresholdUpDown";
            this.ThresholdUpDown.Size = new System.Drawing.Size(44, 20);
            this.ThresholdUpDown.TabIndex = 7;
            this.ThresholdUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ThresholdUpDown.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Entropy threshold";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // NumberOfTreesUpDown
            // 
            this.NumberOfTreesUpDown.Location = new System.Drawing.Point(94, 13);
            this.NumberOfTreesUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumberOfTreesUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfTreesUpDown.Name = "NumberOfTreesUpDown";
            this.NumberOfTreesUpDown.Size = new System.Drawing.Size(44, 20);
            this.NumberOfTreesUpDown.TabIndex = 5;
            this.NumberOfTreesUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumberOfTreesUpDown.ValueChanged += new System.EventHandler(this.NumberOfTreesUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max tree depth";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buildingButton
            // 
            this.buildingButton.Enabled = false;
            this.buildingButton.Location = new System.Drawing.Point(6, 19);
            this.buildingButton.Name = "buildingButton";
            this.buildingButton.Size = new System.Drawing.Size(136, 37);
            this.buildingButton.TabIndex = 5;
            this.buildingButton.Text = "Build Random Forest";
            this.buildingButton.UseVisualStyleBackColor = true;
            this.buildingButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoadBox
            // 
            this.LoadBox.Controls.Add(this.OpenInputButton);
            this.LoadBox.Controls.Add(this.OpenTrainingButton);
            this.LoadBox.Location = new System.Drawing.Point(12, 12);
            this.LoadBox.Name = "LoadBox";
            this.LoadBox.Size = new System.Drawing.Size(122, 84);
            this.LoadBox.TabIndex = 8;
            this.LoadBox.TabStop = false;
            this.LoadBox.Text = "FileLoad";
            // 
            // OpenInputButton
            // 
            this.OpenInputButton.Enabled = false;
            this.OpenInputButton.Location = new System.Drawing.Point(6, 47);
            this.OpenInputButton.Name = "OpenInputButton";
            this.OpenInputButton.Size = new System.Drawing.Size(110, 24);
            this.OpenInputButton.TabIndex = 2;
            this.OpenInputButton.Text = "Open Input File";
            this.OpenInputButton.UseVisualStyleBackColor = true;
            this.OpenInputButton.Click += new System.EventHandler(this.OpenLearningButton_Click);
            // 
            // CommandBox
            // 
            this.CommandBox.Controls.Add(this.classifyButton);
            this.CommandBox.Controls.Add(this.clearButton);
            this.CommandBox.Controls.Add(this.buildingButton);
            this.CommandBox.Location = new System.Drawing.Point(10, 102);
            this.CommandBox.Name = "CommandBox";
            this.CommandBox.Size = new System.Drawing.Size(437, 69);
            this.CommandBox.TabIndex = 8;
            this.CommandBox.TabStop = false;
            this.CommandBox.Text = "Commands";
            // 
            // classifyButton
            // 
            this.classifyButton.Enabled = false;
            this.classifyButton.Location = new System.Drawing.Point(148, 19);
            this.classifyButton.Name = "classifyButton";
            this.classifyButton.Size = new System.Drawing.Size(136, 37);
            this.classifyButton.TabIndex = 7;
            this.classifyButton.Text = "Classify Input Items";
            this.classifyButton.UseVisualStyleBackColor = true;
            this.classifyButton.Click += new System.EventHandler(this.classifyButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(293, 19);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(136, 37);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // resultsTab
            // 
            this.resultsTab.Controls.Add(this.resultsGridView);
            this.resultsTab.Location = new System.Drawing.Point(4, 22);
            this.resultsTab.Name = "resultsTab";
            this.resultsTab.Padding = new System.Windows.Forms.Padding(3);
            this.resultsTab.Size = new System.Drawing.Size(428, 357);
            this.resultsTab.TabIndex = 3;
            this.resultsTab.Text = "Results";
            this.resultsTab.UseVisualStyleBackColor = true;
            // 
            // resultsGridView
            // 
            this.resultsGridView.AllowUserToAddRows = false;
            this.resultsGridView.AllowUserToDeleteRows = false;
            this.resultsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultsGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.resultsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.resultsGridView.ColumnHeadersVisible = false;
            this.resultsGridView.Location = new System.Drawing.Point(-4, 0);
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.ReadOnly = true;
            this.resultsGridView.RowHeadersVisible = false;
            this.resultsGridView.Size = new System.Drawing.Size(436, 359);
            this.resultsGridView.TabIndex = 10;
            // 
            // inputTab
            // 
            this.inputTab.Controls.Add(this.inputGridView);
            this.inputTab.Location = new System.Drawing.Point(4, 22);
            this.inputTab.Name = "inputTab";
            this.inputTab.Padding = new System.Windows.Forms.Padding(3);
            this.inputTab.Size = new System.Drawing.Size(428, 357);
            this.inputTab.TabIndex = 1;
            this.inputTab.Text = "Input Data";
            this.inputTab.UseVisualStyleBackColor = true;
            // 
            // inputGridView
            // 
            this.inputGridView.AllowUserToAddRows = false;
            this.inputGridView.AllowUserToDeleteRows = false;
            this.inputGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inputGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.inputGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.inputGridView.ColumnHeadersVisible = false;
            this.inputGridView.Location = new System.Drawing.Point(-4, 0);
            this.inputGridView.Name = "inputGridView";
            this.inputGridView.ReadOnly = true;
            this.inputGridView.RowHeadersVisible = false;
            this.inputGridView.Size = new System.Drawing.Size(445, 359);
            this.inputGridView.TabIndex = 10;
            // 
            // trainingTab
            // 
            this.trainingTab.Controls.Add(this.trainingGridView);
            this.trainingTab.Location = new System.Drawing.Point(4, 22);
            this.trainingTab.Name = "trainingTab";
            this.trainingTab.Padding = new System.Windows.Forms.Padding(3);
            this.trainingTab.Size = new System.Drawing.Size(428, 357);
            this.trainingTab.TabIndex = 0;
            this.trainingTab.Text = "Training Data";
            this.trainingTab.UseVisualStyleBackColor = true;
            // 
            // trainingGridView
            // 
            this.trainingGridView.AllowUserToAddRows = false;
            this.trainingGridView.AllowUserToDeleteRows = false;
            this.trainingGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.trainingGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.trainingGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.trainingGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.trainingGridView.ColumnHeadersVisible = false;
            this.trainingGridView.Location = new System.Drawing.Point(-4, 0);
            this.trainingGridView.Name = "trainingGridView";
            this.trainingGridView.ReadOnly = true;
            this.trainingGridView.RowHeadersVisible = false;
            this.trainingGridView.Size = new System.Drawing.Size(435, 359);
            this.trainingGridView.TabIndex = 9;
            this.trainingGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DataTabs
            // 
            this.DataTabs.Controls.Add(this.trainingTab);
            this.DataTabs.Controls.Add(this.inputTab);
            this.DataTabs.Controls.Add(this.resultsTab);
            this.DataTabs.Location = new System.Drawing.Point(0, 13);
            this.DataTabs.Multiline = true;
            this.DataTabs.Name = "DataTabs";
            this.DataTabs.SelectedIndex = 0;
            this.DataTabs.Size = new System.Drawing.Size(436, 383);
            this.DataTabs.TabIndex = 11;
            // 
            // DataBox
            // 
            this.DataBox.Controls.Add(this.DataTabs);
            this.DataBox.Location = new System.Drawing.Point(11, 177);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(436, 383);
            this.DataBox.TabIndex = 8;
            this.DataBox.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Enabled = false;
            this.progressBar.Location = new System.Drawing.Point(10, 161);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(436, 23);
            this.progressBar.TabIndex = 9;
            this.progressBar.Visible = false;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click_1);
            // 
            // App
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(452, 564);
            this.Controls.Add(this.CommandBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.LoadBox);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.ConfigBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "App";
            this.Text = "Random Forest Classification";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaxTreeDepthUpDown)).EndInit();
            this.ConfigBox.ResumeLayout(false);
            this.ConfigBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinItemsCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfTreesUpDown)).EndInit();
            this.LoadBox.ResumeLayout(false);
            this.CommandBox.ResumeLayout(false);
            this.resultsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            this.inputTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputGridView)).EndInit();
            this.trainingTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainingGridView)).EndInit();
            this.DataTabs.ResumeLayout(false);
            this.DataBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button OpenTrainingButton;
        private System.Windows.Forms.NumericUpDown MaxTreeDepthUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ConfigBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ThresholdUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumberOfTreesUpDown;
        private System.Windows.Forms.Button buildingButton;
        private System.Windows.Forms.GroupBox LoadBox;
        private System.Windows.Forms.GroupBox CommandBox;
        private System.Windows.Forms.NumericUpDown MinItemsCountUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OpenInputButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage resultsTab;
        private System.Windows.Forms.DataGridView resultsGridView;
        private System.Windows.Forms.TabPage inputTab;
        private System.Windows.Forms.DataGridView inputGridView;
        private System.Windows.Forms.TabPage trainingTab;
        private System.Windows.Forms.DataGridView trainingGridView;
        private System.Windows.Forms.TabControl DataTabs;
        private System.Windows.Forms.GroupBox DataBox;
        private System.Windows.Forms.Button clearButton;
        public System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button classifyButton;
    }
}

