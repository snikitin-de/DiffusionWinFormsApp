namespace DiffusionWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            renderPictureBox = new PictureBox();
            rightRedBallCountLabel = new Label();
            rightBlueBallCountLabel = new Label();
            leftBlueBallCountLabel = new Label();
            leftRedBallCountLabel = new Label();
            topRedBallCountLabel = new Label();
            topBlueBallCountLabel = new Label();
            bottomBlueBallCountLabel = new Label();
            bottomRedBallCountLabel = new Label();
            redBallsCountTrackBar = new TrackBar();
            redBallsCountLabel = new Label();
            blueBallsCountLabel = new Label();
            blueBallsCountTrackBar = new TrackBar();
            evennessFactorRedBallsGroupBox = new GroupBox();
            redBallsEpsilonLabel = new Label();
            redBallsEvennessFactorRightLabel = new Label();
            redBallsEvennessFactorLeftLabel = new Label();
            redBallsEvennessFactorBottomLabel = new Label();
            redBallsEvennessFactorTopLabel = new Label();
            evennessFactorBlueBallsGroupBox = new GroupBox();
            blueBallsEpsilonLabel = new Label();
            blueBallsEvennessFactorRightLabel = new Label();
            blueBallsEvennessFactorLeftLabel = new Label();
            blueBallsEvennessFactorBottomLabel = new Label();
            blueBallsEvennessFactorTopLabel = new Label();
            settingsGroupBox = new GroupBox();
            blueBallsSettingsGroupBox = new GroupBox();
            label2 = new Label();
            blueBallsEpsilonNumericUpDown = new NumericUpDown();
            label1 = new Label();
            redBallsSettingsGroupBox = new GroupBox();
            redBallsSettingsCount = new Label();
            redBallsEpsilonSettingsLabel = new Label();
            redBallsEpsilonNumericUpDown = new NumericUpDown();
            ResetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)renderPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redBallsCountTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueBallsCountTrackBar).BeginInit();
            evennessFactorRedBallsGroupBox.SuspendLayout();
            evennessFactorBlueBallsGroupBox.SuspendLayout();
            settingsGroupBox.SuspendLayout();
            blueBallsSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blueBallsEpsilonNumericUpDown).BeginInit();
            redBallsSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)redBallsEpsilonNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // renderPictureBox
            // 
            renderPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            renderPictureBox.Location = new Point(0, 194);
            renderPictureBox.Name = "renderPictureBox";
            renderPictureBox.Size = new Size(1488, 709);
            renderPictureBox.TabIndex = 0;
            renderPictureBox.TabStop = false;
            renderPictureBox.Paint += renderPictureBox_Paint;
            renderPictureBox.MouseDown += renderPictureBox_MouseDown;
            renderPictureBox.Resize += renderPictureBox_Resize;
            // 
            // rightRedBallCountLabel
            // 
            rightRedBallCountLabel.Anchor = AnchorStyles.Right;
            rightRedBallCountLabel.AutoSize = true;
            rightRedBallCountLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rightRedBallCountLabel.ForeColor = Color.Red;
            rightRedBallCountLabel.Location = new Point(1426, 494);
            rightRedBallCountLabel.Margin = new Padding(15);
            rightRedBallCountLabel.Name = "rightRedBallCountLabel";
            rightRedBallCountLabel.Size = new Size(18, 19);
            rightRedBallCountLabel.TabIndex = 2;
            rightRedBallCountLabel.Text = "0";
            // 
            // rightBlueBallCountLabel
            // 
            rightBlueBallCountLabel.Anchor = AnchorStyles.Right;
            rightBlueBallCountLabel.AutoSize = true;
            rightBlueBallCountLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rightBlueBallCountLabel.ForeColor = Color.Blue;
            rightBlueBallCountLabel.Location = new Point(1426, 559);
            rightBlueBallCountLabel.Margin = new Padding(15);
            rightBlueBallCountLabel.Name = "rightBlueBallCountLabel";
            rightBlueBallCountLabel.Size = new Size(18, 19);
            rightBlueBallCountLabel.TabIndex = 3;
            rightBlueBallCountLabel.Text = "0";
            // 
            // leftBlueBallCountLabel
            // 
            leftBlueBallCountLabel.Anchor = AnchorStyles.Left;
            leftBlueBallCountLabel.AutoSize = true;
            leftBlueBallCountLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            leftBlueBallCountLabel.ForeColor = Color.Blue;
            leftBlueBallCountLabel.Location = new Point(45, 559);
            leftBlueBallCountLabel.Margin = new Padding(15);
            leftBlueBallCountLabel.Name = "leftBlueBallCountLabel";
            leftBlueBallCountLabel.Size = new Size(18, 19);
            leftBlueBallCountLabel.TabIndex = 5;
            leftBlueBallCountLabel.Text = "0";
            // 
            // leftRedBallCountLabel
            // 
            leftRedBallCountLabel.Anchor = AnchorStyles.Left;
            leftRedBallCountLabel.AutoSize = true;
            leftRedBallCountLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            leftRedBallCountLabel.ForeColor = Color.Red;
            leftRedBallCountLabel.Location = new Point(45, 494);
            leftRedBallCountLabel.Margin = new Padding(15);
            leftRedBallCountLabel.Name = "leftRedBallCountLabel";
            leftRedBallCountLabel.Size = new Size(18, 19);
            leftRedBallCountLabel.TabIndex = 4;
            leftRedBallCountLabel.Text = "0";
            // 
            // topRedBallCountLabel
            // 
            topRedBallCountLabel.Anchor = AnchorStyles.Top;
            topRedBallCountLabel.AutoSize = true;
            topRedBallCountLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            topRedBallCountLabel.ForeColor = Color.Red;
            topRedBallCountLabel.Location = new Point(703, 218);
            topRedBallCountLabel.Margin = new Padding(15);
            topRedBallCountLabel.Name = "topRedBallCountLabel";
            topRedBallCountLabel.Size = new Size(18, 19);
            topRedBallCountLabel.TabIndex = 6;
            topRedBallCountLabel.Text = "0";
            // 
            // topBlueBallCountLabel
            // 
            topBlueBallCountLabel.Anchor = AnchorStyles.Top;
            topBlueBallCountLabel.AutoSize = true;
            topBlueBallCountLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            topBlueBallCountLabel.ForeColor = Color.Blue;
            topBlueBallCountLabel.Location = new Point(767, 218);
            topBlueBallCountLabel.Margin = new Padding(15);
            topBlueBallCountLabel.Name = "topBlueBallCountLabel";
            topBlueBallCountLabel.Size = new Size(18, 19);
            topBlueBallCountLabel.TabIndex = 7;
            topBlueBallCountLabel.Text = "0";
            // 
            // bottomBlueBallCountLabel
            // 
            bottomBlueBallCountLabel.Anchor = AnchorStyles.Bottom;
            bottomBlueBallCountLabel.AutoSize = true;
            bottomBlueBallCountLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bottomBlueBallCountLabel.ForeColor = Color.Blue;
            bottomBlueBallCountLabel.Location = new Point(767, 860);
            bottomBlueBallCountLabel.Margin = new Padding(15);
            bottomBlueBallCountLabel.Name = "bottomBlueBallCountLabel";
            bottomBlueBallCountLabel.Size = new Size(18, 19);
            bottomBlueBallCountLabel.TabIndex = 9;
            bottomBlueBallCountLabel.Text = "0";
            // 
            // bottomRedBallCountLabel
            // 
            bottomRedBallCountLabel.Anchor = AnchorStyles.Bottom;
            bottomRedBallCountLabel.AutoSize = true;
            bottomRedBallCountLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bottomRedBallCountLabel.ForeColor = Color.Red;
            bottomRedBallCountLabel.Location = new Point(703, 860);
            bottomRedBallCountLabel.Margin = new Padding(15);
            bottomRedBallCountLabel.Name = "bottomRedBallCountLabel";
            bottomRedBallCountLabel.Size = new Size(18, 19);
            bottomRedBallCountLabel.TabIndex = 8;
            bottomRedBallCountLabel.Text = "0";
            // 
            // redBallsCountTrackBar
            // 
            redBallsCountTrackBar.Anchor = AnchorStyles.Top;
            redBallsCountTrackBar.LargeChange = 10;
            redBallsCountTrackBar.Location = new Point(98, 72);
            redBallsCountTrackBar.Maximum = 1000;
            redBallsCountTrackBar.Minimum = 1;
            redBallsCountTrackBar.Name = "redBallsCountTrackBar";
            redBallsCountTrackBar.Size = new Size(157, 45);
            redBallsCountTrackBar.TabIndex = 10;
            redBallsCountTrackBar.TickFrequency = 10;
            redBallsCountTrackBar.Value = 1;
            redBallsCountTrackBar.ValueChanged += redBallsCountTrackBar_ValueChanged;
            // 
            // redBallsCountLabel
            // 
            redBallsCountLabel.Anchor = AnchorStyles.Top;
            redBallsCountLabel.AutoSize = true;
            redBallsCountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            redBallsCountLabel.ForeColor = Color.Black;
            redBallsCountLabel.Location = new Point(254, 72);
            redBallsCountLabel.Name = "redBallsCountLabel";
            redBallsCountLabel.Size = new Size(13, 15);
            redBallsCountLabel.TabIndex = 11;
            redBallsCountLabel.Text = "0";
            // 
            // blueBallsCountLabel
            // 
            blueBallsCountLabel.Anchor = AnchorStyles.Top;
            blueBallsCountLabel.AutoSize = true;
            blueBallsCountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            blueBallsCountLabel.ForeColor = Color.Black;
            blueBallsCountLabel.Location = new Point(252, 72);
            blueBallsCountLabel.Name = "blueBallsCountLabel";
            blueBallsCountLabel.Size = new Size(13, 15);
            blueBallsCountLabel.TabIndex = 13;
            blueBallsCountLabel.Text = "0";
            // 
            // blueBallsCountTrackBar
            // 
            blueBallsCountTrackBar.Anchor = AnchorStyles.Top;
            blueBallsCountTrackBar.LargeChange = 10;
            blueBallsCountTrackBar.Location = new Point(102, 72);
            blueBallsCountTrackBar.Maximum = 1000;
            blueBallsCountTrackBar.Minimum = 1;
            blueBallsCountTrackBar.Name = "blueBallsCountTrackBar";
            blueBallsCountTrackBar.Size = new Size(151, 45);
            blueBallsCountTrackBar.TabIndex = 12;
            blueBallsCountTrackBar.TickFrequency = 10;
            blueBallsCountTrackBar.Value = 1;
            blueBallsCountTrackBar.ValueChanged += blueBallsCountTrackBar_ValueChanged;
            // 
            // evennessFactorRedBallsGroupBox
            // 
            evennessFactorRedBallsGroupBox.Anchor = AnchorStyles.Top;
            evennessFactorRedBallsGroupBox.Controls.Add(redBallsEpsilonLabel);
            evennessFactorRedBallsGroupBox.Controls.Add(redBallsEvennessFactorRightLabel);
            evennessFactorRedBallsGroupBox.Controls.Add(redBallsEvennessFactorLeftLabel);
            evennessFactorRedBallsGroupBox.Controls.Add(redBallsEvennessFactorBottomLabel);
            evennessFactorRedBallsGroupBox.Controls.Add(redBallsEvennessFactorTopLabel);
            evennessFactorRedBallsGroupBox.Location = new Point(11, 12);
            evennessFactorRedBallsGroupBox.Name = "evennessFactorRedBallsGroupBox";
            evennessFactorRedBallsGroupBox.Size = new Size(309, 166);
            evennessFactorRedBallsGroupBox.TabIndex = 16;
            evennessFactorRedBallsGroupBox.TabStop = false;
            evennessFactorRedBallsGroupBox.Text = "Равномерность распределения красных шариков";
            // 
            // redBallsEpsilonLabel
            // 
            redBallsEpsilonLabel.AutoSize = true;
            redBallsEpsilonLabel.Location = new Point(6, 138);
            redBallsEpsilonLabel.Name = "redBallsEpsilonLabel";
            redBallsEpsilonLabel.Size = new Size(95, 15);
            redBallsEpsilonLabel.TabIndex = 4;
            redBallsEpsilonLabel.Text = "Погрешность: 0";
            // 
            // redBallsEvennessFactorRightLabel
            // 
            redBallsEvennessFactorRightLabel.AutoSize = true;
            redBallsEvennessFactorRightLabel.Location = new Point(6, 111);
            redBallsEvennessFactorRightLabel.Name = "redBallsEvennessFactorRightLabel";
            redBallsEvennessFactorRightLabel.Size = new Size(202, 15);
            redBallsEvennessFactorRightLabel.TabIndex = 3;
            redBallsEvennessFactorRightLabel.Text = "Распределение по правой стенке: 0";
            // 
            // redBallsEvennessFactorLeftLabel
            // 
            redBallsEvennessFactorLeftLabel.AutoSize = true;
            redBallsEvennessFactorLeftLabel.Location = new Point(6, 84);
            redBallsEvennessFactorLeftLabel.Name = "redBallsEvennessFactorLeftLabel";
            redBallsEvennessFactorLeftLabel.Size = new Size(195, 15);
            redBallsEvennessFactorLeftLabel.TabIndex = 2;
            redBallsEvennessFactorLeftLabel.Text = "Распределение по левой стенке: 0";
            // 
            // redBallsEvennessFactorBottomLabel
            // 
            redBallsEvennessFactorBottomLabel.AutoSize = true;
            redBallsEvennessFactorBottomLabel.Location = new Point(6, 57);
            redBallsEvennessFactorBottomLabel.Name = "redBallsEvennessFactorBottomLabel";
            redBallsEvennessFactorBottomLabel.Size = new Size(205, 15);
            redBallsEvennessFactorBottomLabel.TabIndex = 1;
            redBallsEvennessFactorBottomLabel.Text = "Распределение по нижней стенке: 0";
            // 
            // redBallsEvennessFactorTopLabel
            // 
            redBallsEvennessFactorTopLabel.AutoSize = true;
            redBallsEvennessFactorTopLabel.Location = new Point(6, 30);
            redBallsEvennessFactorTopLabel.Name = "redBallsEvennessFactorTopLabel";
            redBallsEvennessFactorTopLabel.Size = new Size(207, 15);
            redBallsEvennessFactorTopLabel.TabIndex = 0;
            redBallsEvennessFactorTopLabel.Text = "Распределение по верхней стенке: 0";
            // 
            // evennessFactorBlueBallsGroupBox
            // 
            evennessFactorBlueBallsGroupBox.Anchor = AnchorStyles.Top;
            evennessFactorBlueBallsGroupBox.Controls.Add(blueBallsEpsilonLabel);
            evennessFactorBlueBallsGroupBox.Controls.Add(blueBallsEvennessFactorRightLabel);
            evennessFactorBlueBallsGroupBox.Controls.Add(blueBallsEvennessFactorLeftLabel);
            evennessFactorBlueBallsGroupBox.Controls.Add(blueBallsEvennessFactorBottomLabel);
            evennessFactorBlueBallsGroupBox.Controls.Add(blueBallsEvennessFactorTopLabel);
            evennessFactorBlueBallsGroupBox.Location = new Point(326, 12);
            evennessFactorBlueBallsGroupBox.Name = "evennessFactorBlueBallsGroupBox";
            evennessFactorBlueBallsGroupBox.Size = new Size(309, 166);
            evennessFactorBlueBallsGroupBox.TabIndex = 17;
            evennessFactorBlueBallsGroupBox.TabStop = false;
            evennessFactorBlueBallsGroupBox.Text = "Равномерность распределения синих шариков";
            // 
            // blueBallsEpsilonLabel
            // 
            blueBallsEpsilonLabel.AutoSize = true;
            blueBallsEpsilonLabel.Location = new Point(6, 138);
            blueBallsEpsilonLabel.Name = "blueBallsEpsilonLabel";
            blueBallsEpsilonLabel.Size = new Size(95, 15);
            blueBallsEpsilonLabel.TabIndex = 4;
            blueBallsEpsilonLabel.Text = "Погрешность: 0";
            // 
            // blueBallsEvennessFactorRightLabel
            // 
            blueBallsEvennessFactorRightLabel.AutoSize = true;
            blueBallsEvennessFactorRightLabel.Location = new Point(6, 111);
            blueBallsEvennessFactorRightLabel.Name = "blueBallsEvennessFactorRightLabel";
            blueBallsEvennessFactorRightLabel.Size = new Size(202, 15);
            blueBallsEvennessFactorRightLabel.TabIndex = 3;
            blueBallsEvennessFactorRightLabel.Text = "Распределение по правой стенке: 0";
            // 
            // blueBallsEvennessFactorLeftLabel
            // 
            blueBallsEvennessFactorLeftLabel.AutoSize = true;
            blueBallsEvennessFactorLeftLabel.Location = new Point(6, 84);
            blueBallsEvennessFactorLeftLabel.Name = "blueBallsEvennessFactorLeftLabel";
            blueBallsEvennessFactorLeftLabel.Size = new Size(195, 15);
            blueBallsEvennessFactorLeftLabel.TabIndex = 2;
            blueBallsEvennessFactorLeftLabel.Text = "Распределение по левой стенке: 0";
            // 
            // blueBallsEvennessFactorBottomLabel
            // 
            blueBallsEvennessFactorBottomLabel.AutoSize = true;
            blueBallsEvennessFactorBottomLabel.Location = new Point(6, 57);
            blueBallsEvennessFactorBottomLabel.Name = "blueBallsEvennessFactorBottomLabel";
            blueBallsEvennessFactorBottomLabel.Size = new Size(205, 15);
            blueBallsEvennessFactorBottomLabel.TabIndex = 1;
            blueBallsEvennessFactorBottomLabel.Text = "Распределение по нижней стенке: 0";
            // 
            // blueBallsEvennessFactorTopLabel
            // 
            blueBallsEvennessFactorTopLabel.AutoSize = true;
            blueBallsEvennessFactorTopLabel.Location = new Point(6, 30);
            blueBallsEvennessFactorTopLabel.Name = "blueBallsEvennessFactorTopLabel";
            blueBallsEvennessFactorTopLabel.Size = new Size(207, 15);
            blueBallsEvennessFactorTopLabel.TabIndex = 0;
            blueBallsEvennessFactorTopLabel.Text = "Распределение по верхней стенке: 0";
            // 
            // settingsGroupBox
            // 
            settingsGroupBox.Anchor = AnchorStyles.Top;
            settingsGroupBox.Controls.Add(blueBallsSettingsGroupBox);
            settingsGroupBox.Controls.Add(redBallsSettingsGroupBox);
            settingsGroupBox.Controls.Add(ResetButton);
            settingsGroupBox.Location = new Point(641, 12);
            settingsGroupBox.Name = "settingsGroupBox";
            settingsGroupBox.Size = new Size(837, 166);
            settingsGroupBox.TabIndex = 18;
            settingsGroupBox.TabStop = false;
            settingsGroupBox.Text = "Настройки";
            // 
            // blueBallsSettingsGroupBox
            // 
            blueBallsSettingsGroupBox.Controls.Add(label2);
            blueBallsSettingsGroupBox.Controls.Add(blueBallsEpsilonNumericUpDown);
            blueBallsSettingsGroupBox.Controls.Add(label1);
            blueBallsSettingsGroupBox.Controls.Add(blueBallsCountTrackBar);
            blueBallsSettingsGroupBox.Controls.Add(blueBallsCountLabel);
            blueBallsSettingsGroupBox.Location = new Point(311, 22);
            blueBallsSettingsGroupBox.Name = "blueBallsSettingsGroupBox";
            blueBallsSettingsGroupBox.Size = new Size(292, 131);
            blueBallsSettingsGroupBox.TabIndex = 20;
            blueBallsSettingsGroupBox.TabStop = false;
            blueBallsSettingsGroupBox.Text = "Синии шарики";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 43);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 23;
            label2.Text = "Погрешность";
            // 
            // blueBallsEpsilonNumericUpDown
            // 
            blueBallsEpsilonNumericUpDown.Location = new Point(110, 39);
            blueBallsEpsilonNumericUpDown.Name = "blueBallsEpsilonNumericUpDown";
            blueBallsEpsilonNumericUpDown.Size = new Size(91, 23);
            blueBallsEpsilonNumericUpDown.TabIndex = 22;
            blueBallsEpsilonNumericUpDown.ValueChanged += blueBallsEpsilonNumericUpDown_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 72);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 21;
            label1.Text = "Количество";
            // 
            // redBallsSettingsGroupBox
            // 
            redBallsSettingsGroupBox.Controls.Add(redBallsSettingsCount);
            redBallsSettingsGroupBox.Controls.Add(redBallsEpsilonSettingsLabel);
            redBallsSettingsGroupBox.Controls.Add(redBallsEpsilonNumericUpDown);
            redBallsSettingsGroupBox.Controls.Add(redBallsCountTrackBar);
            redBallsSettingsGroupBox.Controls.Add(redBallsCountLabel);
            redBallsSettingsGroupBox.Location = new Point(13, 22);
            redBallsSettingsGroupBox.Name = "redBallsSettingsGroupBox";
            redBallsSettingsGroupBox.Size = new Size(292, 131);
            redBallsSettingsGroupBox.TabIndex = 19;
            redBallsSettingsGroupBox.TabStop = false;
            redBallsSettingsGroupBox.Text = "Красные шарики";
            // 
            // redBallsSettingsCount
            // 
            redBallsSettingsCount.AutoSize = true;
            redBallsSettingsCount.Location = new Point(18, 72);
            redBallsSettingsCount.Name = "redBallsSettingsCount";
            redBallsSettingsCount.Size = new Size(72, 15);
            redBallsSettingsCount.TabIndex = 20;
            redBallsSettingsCount.Text = "Количество";
            // 
            // redBallsEpsilonSettingsLabel
            // 
            redBallsEpsilonSettingsLabel.AutoSize = true;
            redBallsEpsilonSettingsLabel.Location = new Point(18, 43);
            redBallsEpsilonSettingsLabel.Name = "redBallsEpsilonSettingsLabel";
            redBallsEpsilonSettingsLabel.Size = new Size(83, 15);
            redBallsEpsilonSettingsLabel.TabIndex = 19;
            redBallsEpsilonSettingsLabel.Text = "Погрешность";
            // 
            // redBallsEpsilonNumericUpDown
            // 
            redBallsEpsilonNumericUpDown.Location = new Point(107, 40);
            redBallsEpsilonNumericUpDown.Name = "redBallsEpsilonNumericUpDown";
            redBallsEpsilonNumericUpDown.Size = new Size(91, 23);
            redBallsEpsilonNumericUpDown.TabIndex = 18;
            redBallsEpsilonNumericUpDown.ValueChanged += redBallsEpsilonNumericUpDown_ValueChanged;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(642, 117);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(157, 36);
            ResetButton.TabIndex = 16;
            ResetButton.Text = "Сбросить эмуляцию";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 903);
            Controls.Add(settingsGroupBox);
            Controls.Add(evennessFactorBlueBallsGroupBox);
            Controls.Add(evennessFactorRedBallsGroupBox);
            Controls.Add(bottomBlueBallCountLabel);
            Controls.Add(bottomRedBallCountLabel);
            Controls.Add(topBlueBallCountLabel);
            Controls.Add(topRedBallCountLabel);
            Controls.Add(leftBlueBallCountLabel);
            Controls.Add(leftRedBallCountLabel);
            Controls.Add(rightBlueBallCountLabel);
            Controls.Add(rightRedBallCountLabel);
            Controls.Add(renderPictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1505, 942);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Диффузия";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)renderPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)redBallsCountTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueBallsCountTrackBar).EndInit();
            evennessFactorRedBallsGroupBox.ResumeLayout(false);
            evennessFactorRedBallsGroupBox.PerformLayout();
            evennessFactorBlueBallsGroupBox.ResumeLayout(false);
            evennessFactorBlueBallsGroupBox.PerformLayout();
            settingsGroupBox.ResumeLayout(false);
            blueBallsSettingsGroupBox.ResumeLayout(false);
            blueBallsSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)blueBallsEpsilonNumericUpDown).EndInit();
            redBallsSettingsGroupBox.ResumeLayout(false);
            redBallsSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)redBallsEpsilonNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox renderPictureBox;
        private Label rightRedBallCountLabel;
        private Label rightBlueBallCountLabel;
        private Label leftBlueBallCountLabel;
        private Label leftRedBallCountLabel;
        private Label topRedBallCountLabel;
        private Label topBlueBallCountLabel;
        private Label bottomBlueBallCountLabel;
        private Label bottomRedBallCountLabel;
        private TrackBar redBallsCountTrackBar;
        private Label redBallsCountLabel;
        private Label blueBallsCountLabel;
        private TrackBar blueBallsCountTrackBar;
        private GroupBox evennessFactorRedBallsGroupBox;
        private Label redBallsEpsilonLabel;
        private Label redBallsEvennessFactorRightLabel;
        private Label redBallsEvennessFactorLeftLabel;
        private Label redBallsEvennessFactorBottomLabel;
        private Label redBallsEvennessFactorTopLabel;
        private GroupBox evennessFactorBlueBallsGroupBox;
        private Label blueBallsEpsilonLabel;
        private Label blueBallsEvennessFactorRightLabel;
        private Label blueBallsEvennessFactorLeftLabel;
        private Label blueBallsEvennessFactorBottomLabel;
        private Label blueBallsEvennessFactorTopLabel;
        private GroupBox settingsGroupBox;
        private Button ResetButton;
        private NumericUpDown redBallsEpsilonNumericUpDown;
        private GroupBox redBallsSettingsGroupBox;
        private Label redBallsSettingsCount;
        private Label redBallsEpsilonSettingsLabel;
        private GroupBox blueBallsSettingsGroupBox;
        private Label label2;
        private NumericUpDown blueBallsEpsilonNumericUpDown;
        private Label label1;
    }
}