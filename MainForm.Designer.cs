namespace AdvancedAutoClicker
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.numericInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gbClickType = new System.Windows.Forms.GroupBox();
            this.rbDoubleClick = new System.Windows.Forms.RadioButton();
            this.rbRightClick = new System.Windows.Forms.RadioButton();
            this.rbLeftClick = new System.Windows.Forms.RadioButton();
            this.gbCoordinates = new System.Windows.Forms.GroupBox();
            this.btnGetCurrentPos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.cbUseCoordinates = new System.Windows.Forms.CheckBox();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbSequence = new System.Windows.Forms.RadioButton();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.gbSingleClick = new System.Windows.Forms.GroupBox();
            this.gbSequence = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericPointDelay = new System.Windows.Forms.NumericUpDown();
            this.btnClearSequence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).BeginInit();
            this.gbClickType.SuspendLayout();
            this.gbCoordinates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            this.gbMode.SuspendLayout();
            this.gbSingleClick.SuspendLayout();
            this.gbSequence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPointDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 322);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(360, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт (F6)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numericInterval
            // 
            this.numericInterval.Location = new System.Drawing.Point(172, 19);
            this.numericInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericInterval.Name = "numericInterval";
            this.numericInterval.Size = new System.Drawing.Size(100, 20);
            this.numericInterval.TabIndex = 1;
            this.numericInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Интервал между кликами (мс):";
            // 
            // gbClickType
            // 
            this.gbClickType.Controls.Add(this.rbDoubleClick);
            this.gbClickType.Controls.Add(this.rbRightClick);
            this.gbClickType.Controls.Add(this.rbLeftClick);
            this.gbClickType.Location = new System.Drawing.Point(12, 250);
            this.gbClickType.Name = "gbClickType";
            this.gbClickType.Size = new System.Drawing.Size(360, 45);
            this.gbClickType.TabIndex = 3;
            this.gbClickType.TabStop = false;
            this.gbClickType.Text = "Тип клика";
            // 
            // rbDoubleClick
            // 
            this.rbDoubleClick.AutoSize = true;
            this.rbDoubleClick.Location = new System.Drawing.Point(236, 19);
            this.rbDoubleClick.Name = "rbDoubleClick";
            this.rbDoubleClick.Size = new System.Drawing.Size(96, 17);
            this.rbDoubleClick.TabIndex = 2;
            this.rbDoubleClick.Text = "Двойной клик";
            this.rbDoubleClick.UseVisualStyleBackColor = true;
            // 
            // rbRightClick
            // 
            this.rbRightClick.AutoSize = true;
            this.rbRightClick.Location = new System.Drawing.Point(119, 19);
            this.rbRightClick.Name = "rbRightClick";
            this.rbRightClick.Size = new System.Drawing.Size(111, 17);
            this.rbRightClick.TabIndex = 1;
            this.rbRightClick.Text = "Правый клик";
            this.rbRightClick.UseVisualStyleBackColor = true;
            // 
            // rbLeftClick
            // 
            this.rbLeftClick.AutoSize = true;
            this.rbLeftClick.Checked = true;
            this.rbLeftClick.Location = new System.Drawing.Point(6, 19);
            this.rbLeftClick.Name = "rbLeftClick";
            this.rbLeftClick.Size = new System.Drawing.Size(107, 17);
            this.rbLeftClick.TabIndex = 0;
            this.rbLeftClick.TabStop = true;
            this.rbLeftClick.Text = "Левый клик";
            this.rbLeftClick.UseVisualStyleBackColor = true;
            // 
            // gbCoordinates
            // 
            this.gbCoordinates.Controls.Add(this.btnGetCurrentPos);
            this.gbCoordinates.Controls.Add(this.label3);
            this.gbCoordinates.Controls.Add(this.numericY);
            this.gbCoordinates.Controls.Add(this.label2);
            this.gbCoordinates.Controls.Add(this.numericX);
            this.gbCoordinates.Controls.Add(this.cbUseCoordinates);
            this.gbCoordinates.Location = new System.Drawing.Point(6, 96);
            this.gbCoordinates.Name = "gbCoordinates";
            this.gbCoordinates.Size = new System.Drawing.Size(348, 80);
            this.gbCoordinates.TabIndex = 4;
            this.gbCoordinates.TabStop = false;
            this.gbCoordinates.Text = "Координаты";
            // 
            // btnGetCurrentPos
            // 
            this.btnGetCurrentPos.Location = new System.Drawing.Point(236, 45);
            this.btnGetCurrentPos.Name = "btnGetCurrentPos";
            this.btnGetCurrentPos.Size = new System.Drawing.Size(106, 23);
            this.btnGetCurrentPos.TabIndex = 5;
            this.btnGetCurrentPos.Text = "Текущая позиция";
            this.btnGetCurrentPos.UseVisualStyleBackColor = true;
            this.btnGetCurrentPos.Click += new System.EventHandler(this.btnGetCurrentPos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(168, 48);
            this.numericY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(62, 20);
            this.numericY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(26, 48);
            this.numericX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(62, 20);
            this.numericX.TabIndex = 1;
            // 
            // cbUseCoordinates
            // 
            this.cbUseCoordinates.AutoSize = true;
            this.cbUseCoordinates.Location = new System.Drawing.Point(6, 19);
            this.cbUseCoordinates.Name = "cbUseCoordinates";
            this.cbUseCoordinates.Size = new System.Drawing.Size(168, 17);
            this.cbUseCoordinates.TabIndex = 0;
            this.cbUseCoordinates.Text = "Использовать координаты";
            this.cbUseCoordinates.UseVisualStyleBackColor = true;
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbSequence);
            this.gbMode.Controls.Add(this.rbSingle);
            this.gbMode.Location = new System.Drawing.Point(12, 12);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(360, 44);
            this.gbMode.TabIndex = 5;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Режим работы";
            // 
            // rbSequence
            // 
            this.rbSequence.AutoSize = true;
            this.rbSequence.Location = new System.Drawing.Point(119, 19);
            this.rbSequence.Name = "rbSequence";
            this.rbSequence.Size = new System.Drawing.Size(193, 17);
            this.rbSequence.TabIndex = 1;
            this.rbSequence.Text = "Воспроизведение последовательности";
            this.rbSequence.UseVisualStyleBackColor = true;
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Checked = true;
            this.rbSingle.Location = new System.Drawing.Point(6, 19);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(107, 17);
            this.rbSingle.TabIndex = 0;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Одиночный клик";
            this.rbSingle.UseVisualStyleBackColor = true;
            this.rbSingle.CheckedChanged += new System.EventHandler(this.rbSingle_CheckedChanged);
            // 
            // gbSingleClick
            // 
            this.gbSingleClick.Controls.Add(this.label1);
            this.gbSingleClick.Controls.Add(this.numericInterval);
            this.gbSingleClick.Controls.Add(this.gbCoordinates);
            this.gbSingleClick.Location = new System.Drawing.Point(12, 62);
            this.gbSingleClick.Name = "gbSingleClick";
            this.gbSingleClick.Size = new System.Drawing.Size(360, 182);
            this.gbSingleClick.TabIndex = 6;
            this.gbSingleClick.TabStop = false;
            this.gbSingleClick.Text = "Одиночный клик";
            // 
            // gbSequence
            // 
            this.gbSequence.Controls.Add(this.lblStatus);
            this.gbSequence.Controls.Add(this.btnRecord);
            this.gbSequence.Controls.Add(this.label4);
            this.gbSequence.Controls.Add(this.numericPointDelay);
            this.gbSequence.Controls.Add(this.btnClearSequence);
            this.gbSequence.Enabled = false;
            this.gbSequence.Location = new System.Drawing.Point(12, 62);
            this.gbSequence.Name = "gbSequence";
            this.gbSequence.Size = new System.Drawing.Size(360, 182);
            this.gbSequence.TabIndex = 7;
            this.gbSequence.TabStop = false;
            this.gbSequence.Text = "Последовательность кликов";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(6, 117);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(348, 62);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Готов к записи";
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(6, 74);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(348, 40);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "Записать последовательность";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Задержка после (мс):";
            // 
            // numericPointDelay
            // 
            this.numericPointDelay.Location = new System.Drawing.Point(119, 19);
            this.numericPointDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPointDelay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericPointDelay.Name = "numericPointDelay";
            this.numericPointDelay.Size = new System.Drawing.Size(100, 20);
            this.numericPointDelay.TabIndex = 1;
            this.numericPointDelay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnClearSequence
            // 
            this.btnClearSequence.Location = new System.Drawing.Point(6, 45);
            this.btnClearSequence.Name = "btnClearSequence";
            this.btnClearSequence.Size = new System.Drawing.Size(348, 23);
            this.btnClearSequence.TabIndex = 0;
            this.btnClearSequence.Text = "Очистить последовательность";
            this.btnClearSequence.UseVisualStyleBackColor = true;
            this.btnClearSequence.Click += new System.EventHandler(this.btnClearSequence_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 374);
            this.Controls.Add(this.gbClickType);
            this.Controls.Add(this.gbSequence);
            this.Controls.Add(this.gbSingleClick);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Автокликер | by Yorik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).EndInit();
            this.gbClickType.ResumeLayout(false);
            this.gbClickType.PerformLayout();
            this.gbCoordinates.ResumeLayout(false);
            this.gbCoordinates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbSingleClick.ResumeLayout(false);
            this.gbSingleClick.PerformLayout();
            this.gbSequence.ResumeLayout(false);
            this.gbSequence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPointDelay)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numericInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbClickType;
        private System.Windows.Forms.RadioButton rbDoubleClick;
        private System.Windows.Forms.RadioButton rbRightClick;
        private System.Windows.Forms.RadioButton rbLeftClick;
        private System.Windows.Forms.GroupBox gbCoordinates;
        private System.Windows.Forms.Button btnGetCurrentPos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.CheckBox cbUseCoordinates;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbSequence;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.GroupBox gbSingleClick;
        private System.Windows.Forms.GroupBox gbSequence;
        private System.Windows.Forms.Button btnClearSequence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericPointDelay;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label lblStatus;
    }
}
