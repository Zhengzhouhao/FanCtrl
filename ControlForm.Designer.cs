﻿namespace FanCtrl
{
    partial class ControlForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlForm));
            this.mEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.mSensorGroupBox = new System.Windows.Forms.GroupBox();
            this.mSensorComboBox = new System.Windows.Forms.ComboBox();
            this.mFanGroupBox = new System.Windows.Forms.GroupBox();
            this.mRemoveButton = new System.Windows.Forms.Button();
            this.mAddButton = new System.Windows.Forms.Button();
            this.mFanListView = new System.Windows.Forms.ListView();
            this.mFanComboBox = new System.Windows.Forms.ComboBox();
            this.mGraphGroupBox = new System.Windows.Forms.GroupBox();
            this.mUnitLabel = new System.Windows.Forms.Label();
            this.mHysLabel = new System.Windows.Forms.Label();
            this.mStepCheckBox = new System.Windows.Forms.CheckBox();
            this.mGraph = new ZedGraph.ZedGraphControl();
            this.mOKButton = new System.Windows.Forms.Button();
            this.mApplyButton = new System.Windows.Forms.Button();
            this.mHysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mModeGroupBox = new System.Windows.Forms.GroupBox();
            this.mGameRadioButton = new System.Windows.Forms.RadioButton();
            this.mPerformanceRadioButton = new System.Windows.Forms.RadioButton();
            this.mSilenceRadioButton = new System.Windows.Forms.RadioButton();
            this.mNormalRadioButton = new System.Windows.Forms.RadioButton();
            this.mUnitComboBox = new System.Windows.Forms.ComboBox();
            this.mSensorGroupBox.SuspendLayout();
            this.mFanGroupBox.SuspendLayout();
            this.mGraphGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mHysNumericUpDown)).BeginInit();
            this.mModeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mEnableCheckBox
            // 
            this.mEnableCheckBox.AutoSize = true;
            this.mEnableCheckBox.Location = new System.Drawing.Point(19, 29);
            this.mEnableCheckBox.Name = "mEnableCheckBox";
            this.mEnableCheckBox.Size = new System.Drawing.Size(185, 16);
            this.mEnableCheckBox.TabIndex = 0;
            this.mEnableCheckBox.Text = "Enable automatic fan control";
            this.mEnableCheckBox.UseVisualStyleBackColor = true;
            // 
            // mSensorGroupBox
            // 
            this.mSensorGroupBox.Controls.Add(this.mSensorComboBox);
            this.mSensorGroupBox.Location = new System.Drawing.Point(12, 61);
            this.mSensorGroupBox.Name = "mSensorGroupBox";
            this.mSensorGroupBox.Size = new System.Drawing.Size(208, 51);
            this.mSensorGroupBox.TabIndex = 1;
            this.mSensorGroupBox.TabStop = false;
            this.mSensorGroupBox.Text = "Sensor";
            // 
            // mSensorComboBox
            // 
            this.mSensorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mSensorComboBox.FormattingEnabled = true;
            this.mSensorComboBox.Location = new System.Drawing.Point(7, 21);
            this.mSensorComboBox.Name = "mSensorComboBox";
            this.mSensorComboBox.Size = new System.Drawing.Size(195, 20);
            this.mSensorComboBox.TabIndex = 1;
            // 
            // mFanGroupBox
            // 
            this.mFanGroupBox.Controls.Add(this.mRemoveButton);
            this.mFanGroupBox.Controls.Add(this.mAddButton);
            this.mFanGroupBox.Controls.Add(this.mFanListView);
            this.mFanGroupBox.Controls.Add(this.mFanComboBox);
            this.mFanGroupBox.Location = new System.Drawing.Point(12, 118);
            this.mFanGroupBox.Name = "mFanGroupBox";
            this.mFanGroupBox.Size = new System.Drawing.Size(208, 210);
            this.mFanGroupBox.TabIndex = 2;
            this.mFanGroupBox.TabStop = false;
            this.mFanGroupBox.Text = "Fan";
            // 
            // mRemoveButton
            // 
            this.mRemoveButton.Location = new System.Drawing.Point(7, 171);
            this.mRemoveButton.Name = "mRemoveButton";
            this.mRemoveButton.Size = new System.Drawing.Size(195, 33);
            this.mRemoveButton.TabIndex = 2;
            this.mRemoveButton.Text = "Remove";
            this.mRemoveButton.UseVisualStyleBackColor = true;
            this.mRemoveButton.Click += new System.EventHandler(this.onRemoveButtonClick);
            // 
            // mAddButton
            // 
            this.mAddButton.Location = new System.Drawing.Point(135, 15);
            this.mAddButton.Name = "mAddButton";
            this.mAddButton.Size = new System.Drawing.Size(67, 28);
            this.mAddButton.TabIndex = 2;
            this.mAddButton.Text = "Add";
            this.mAddButton.UseVisualStyleBackColor = true;
            this.mAddButton.Click += new System.EventHandler(this.onAddButtonClick);
            // 
            // mFanListView
            // 
            this.mFanListView.FullRowSelect = true;
            this.mFanListView.HideSelection = false;
            this.mFanListView.Location = new System.Drawing.Point(7, 49);
            this.mFanListView.MultiSelect = false;
            this.mFanListView.Name = "mFanListView";
            this.mFanListView.Size = new System.Drawing.Size(195, 116);
            this.mFanListView.TabIndex = 2;
            this.mFanListView.UseCompatibleStateImageBehavior = false;
            this.mFanListView.View = System.Windows.Forms.View.List;
            // 
            // mFanComboBox
            // 
            this.mFanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mFanComboBox.FormattingEnabled = true;
            this.mFanComboBox.Location = new System.Drawing.Point(7, 20);
            this.mFanComboBox.Name = "mFanComboBox";
            this.mFanComboBox.Size = new System.Drawing.Size(125, 20);
            this.mFanComboBox.TabIndex = 2;
            // 
            // mGraphGroupBox
            // 
            this.mGraphGroupBox.Controls.Add(this.mUnitLabel);
            this.mGraphGroupBox.Controls.Add(this.mHysLabel);
            this.mGraphGroupBox.Controls.Add(this.mStepCheckBox);
            this.mGraphGroupBox.Controls.Add(this.mGraph);
            this.mGraphGroupBox.Location = new System.Drawing.Point(227, 61);
            this.mGraphGroupBox.Name = "mGraphGroupBox";
            this.mGraphGroupBox.Size = new System.Drawing.Size(493, 267);
            this.mGraphGroupBox.TabIndex = 4;
            this.mGraphGroupBox.TabStop = false;
            this.mGraphGroupBox.Text = "Graph";
            // 
            // mUnitLabel
            // 
            this.mUnitLabel.AutoSize = true;
            this.mUnitLabel.Location = new System.Drawing.Point(214, 1);
            this.mUnitLabel.Name = "mUnitLabel";
            this.mUnitLabel.Size = new System.Drawing.Size(34, 12);
            this.mUnitLabel.TabIndex = 4;
            this.mUnitLabel.Text = "Unit :";
            this.mUnitLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mHysLabel
            // 
            this.mHysLabel.AutoSize = true;
            this.mHysLabel.Location = new System.Drawing.Point(306, 1);
            this.mHysLabel.Name = "mHysLabel";
            this.mHysLabel.Size = new System.Drawing.Size(73, 12);
            this.mHysLabel.TabIndex = 4;
            this.mHysLabel.Text = "Hysteresis :";
            this.mHysLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mStepCheckBox
            // 
            this.mStepCheckBox.AutoSize = true;
            this.mStepCheckBox.Location = new System.Drawing.Point(434, 1);
            this.mStepCheckBox.Name = "mStepCheckBox";
            this.mStepCheckBox.Size = new System.Drawing.Size(49, 16);
            this.mStepCheckBox.TabIndex = 4;
            this.mStepCheckBox.Text = "Step";
            this.mStepCheckBox.UseVisualStyleBackColor = true;
            this.mStepCheckBox.CheckedChanged += new System.EventHandler(this.onStepCheckBoxCheckedChanged);
            // 
            // mGraph
            // 
            this.mGraph.Location = new System.Drawing.Point(6, 23);
            this.mGraph.Name = "mGraph";
            this.mGraph.ScrollGrace = 0D;
            this.mGraph.ScrollMaxX = 0D;
            this.mGraph.ScrollMaxY = 0D;
            this.mGraph.ScrollMaxY2 = 0D;
            this.mGraph.ScrollMinX = 0D;
            this.mGraph.ScrollMinY = 0D;
            this.mGraph.ScrollMinY2 = 0D;
            this.mGraph.Size = new System.Drawing.Size(481, 238);
            this.mGraph.TabIndex = 4;
            this.mGraph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // mOKButton
            // 
            this.mOKButton.Location = new System.Drawing.Point(585, 334);
            this.mOKButton.Name = "mOKButton";
            this.mOKButton.Size = new System.Drawing.Size(135, 33);
            this.mOKButton.TabIndex = 4;
            this.mOKButton.Text = "OK";
            this.mOKButton.UseVisualStyleBackColor = true;
            this.mOKButton.Click += new System.EventHandler(this.onOKButtonClick);
            // 
            // mApplyButton
            // 
            this.mApplyButton.Location = new System.Drawing.Point(444, 334);
            this.mApplyButton.Name = "mApplyButton";
            this.mApplyButton.Size = new System.Drawing.Size(135, 33);
            this.mApplyButton.TabIndex = 5;
            this.mApplyButton.Text = "Apply";
            this.mApplyButton.UseVisualStyleBackColor = true;
            this.mApplyButton.Click += new System.EventHandler(this.onApplyButtonClick);
            // 
            // mHysNumericUpDown
            // 
            this.mHysNumericUpDown.Location = new System.Drawing.Point(608, 59);
            this.mHysNumericUpDown.Name = "mHysNumericUpDown";
            this.mHysNumericUpDown.Size = new System.Drawing.Size(38, 21);
            this.mHysNumericUpDown.TabIndex = 4;
            // 
            // mModeGroupBox
            // 
            this.mModeGroupBox.Controls.Add(this.mGameRadioButton);
            this.mModeGroupBox.Controls.Add(this.mPerformanceRadioButton);
            this.mModeGroupBox.Controls.Add(this.mSilenceRadioButton);
            this.mModeGroupBox.Controls.Add(this.mNormalRadioButton);
            this.mModeGroupBox.Location = new System.Drawing.Point(227, 9);
            this.mModeGroupBox.Name = "mModeGroupBox";
            this.mModeGroupBox.Size = new System.Drawing.Size(493, 43);
            this.mModeGroupBox.TabIndex = 3;
            this.mModeGroupBox.TabStop = false;
            this.mModeGroupBox.Text = "Mode";
            // 
            // mGameRadioButton
            // 
            this.mGameRadioButton.AutoSize = true;
            this.mGameRadioButton.Location = new System.Drawing.Point(384, 20);
            this.mGameRadioButton.Name = "mGameRadioButton";
            this.mGameRadioButton.Size = new System.Drawing.Size(57, 16);
            this.mGameRadioButton.TabIndex = 3;
            this.mGameRadioButton.TabStop = true;
            this.mGameRadioButton.Text = "Game";
            this.mGameRadioButton.UseVisualStyleBackColor = true;
            // 
            // mPerformanceRadioButton
            // 
            this.mPerformanceRadioButton.AutoSize = true;
            this.mPerformanceRadioButton.Location = new System.Drawing.Point(255, 20);
            this.mPerformanceRadioButton.Name = "mPerformanceRadioButton";
            this.mPerformanceRadioButton.Size = new System.Drawing.Size(95, 16);
            this.mPerformanceRadioButton.TabIndex = 3;
            this.mPerformanceRadioButton.TabStop = true;
            this.mPerformanceRadioButton.Text = "Performance";
            this.mPerformanceRadioButton.UseVisualStyleBackColor = true;
            // 
            // mSilenceRadioButton
            // 
            this.mSilenceRadioButton.AutoSize = true;
            this.mSilenceRadioButton.Location = new System.Drawing.Point(146, 20);
            this.mSilenceRadioButton.Name = "mSilenceRadioButton";
            this.mSilenceRadioButton.Size = new System.Drawing.Size(65, 16);
            this.mSilenceRadioButton.TabIndex = 3;
            this.mSilenceRadioButton.TabStop = true;
            this.mSilenceRadioButton.Text = "Silence";
            this.mSilenceRadioButton.UseVisualStyleBackColor = true;
            // 
            // mNormalRadioButton
            // 
            this.mNormalRadioButton.AutoSize = true;
            this.mNormalRadioButton.Location = new System.Drawing.Point(41, 20);
            this.mNormalRadioButton.Name = "mNormalRadioButton";
            this.mNormalRadioButton.Size = new System.Drawing.Size(64, 16);
            this.mNormalRadioButton.TabIndex = 3;
            this.mNormalRadioButton.TabStop = true;
            this.mNormalRadioButton.Text = "Normal";
            this.mNormalRadioButton.UseVisualStyleBackColor = true;
            // 
            // mUnitComboBox
            // 
            this.mUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mUnitComboBox.FormattingEnabled = true;
            this.mUnitComboBox.Location = new System.Drawing.Point(478, 58);
            this.mUnitComboBox.Name = "mUnitComboBox";
            this.mUnitComboBox.Size = new System.Drawing.Size(44, 20);
            this.mUnitComboBox.TabIndex = 4;
            // 
            // FanControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 375);
            this.Controls.Add(this.mUnitComboBox);
            this.Controls.Add(this.mModeGroupBox);
            this.Controls.Add(this.mHysNumericUpDown);
            this.Controls.Add(this.mApplyButton);
            this.Controls.Add(this.mOKButton);
            this.Controls.Add(this.mGraphGroupBox);
            this.Controls.Add(this.mFanGroupBox);
            this.Controls.Add(this.mSensorGroupBox);
            this.Controls.Add(this.mEnableCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(748, 414);
            this.Name = "FanControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FanControl";
            this.mSensorGroupBox.ResumeLayout(false);
            this.mFanGroupBox.ResumeLayout(false);
            this.mGraphGroupBox.ResumeLayout(false);
            this.mGraphGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mHysNumericUpDown)).EndInit();
            this.mModeGroupBox.ResumeLayout(false);
            this.mModeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox mEnableCheckBox;
        private System.Windows.Forms.GroupBox mSensorGroupBox;
        private System.Windows.Forms.ComboBox mSensorComboBox;
        private System.Windows.Forms.GroupBox mFanGroupBox;
        private System.Windows.Forms.ListView mFanListView;
        private System.Windows.Forms.ComboBox mFanComboBox;
        private System.Windows.Forms.Button mRemoveButton;
        private System.Windows.Forms.Button mAddButton;
        private System.Windows.Forms.GroupBox mGraphGroupBox;
        private ZedGraph.ZedGraphControl mGraph;
        private System.Windows.Forms.CheckBox mStepCheckBox;
        private System.Windows.Forms.Button mOKButton;
        private System.Windows.Forms.Button mApplyButton;
        private System.Windows.Forms.NumericUpDown mHysNumericUpDown;
        private System.Windows.Forms.Label mHysLabel;
        private System.Windows.Forms.GroupBox mModeGroupBox;
        private System.Windows.Forms.RadioButton mGameRadioButton;
        private System.Windows.Forms.RadioButton mPerformanceRadioButton;
        private System.Windows.Forms.RadioButton mSilenceRadioButton;
        private System.Windows.Forms.RadioButton mNormalRadioButton;
        private System.Windows.Forms.Label mUnitLabel;
        private System.Windows.Forms.ComboBox mUnitComboBox;
    }
}