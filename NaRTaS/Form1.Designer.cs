
namespace NaRTaS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputsBox = new System.Windows.Forms.ListBox();
            this.recordButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inGameTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.levelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerCoords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.clearInputs = new System.Windows.Forms.Button();
            this.addInput = new System.Windows.Forms.Button();
            this.delInput = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eventsCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputsBox
            // 
            this.inputsBox.FormattingEnabled = true;
            this.inputsBox.HorizontalExtent = 400;
            this.inputsBox.HorizontalScrollbar = true;
            this.inputsBox.Location = new System.Drawing.Point(6, 19);
            this.inputsBox.Name = "inputsBox";
            this.inputsBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.inputsBox.Size = new System.Drawing.Size(252, 394);
            this.inputsBox.TabIndex = 0;
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(280, 19);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(75, 36);
            this.recordButton.TabIndex = 1;
            this.recordButton.Text = "Record";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inGameTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.levelName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.playerCoords);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(388, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 283);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game State";
            // 
            // inGameTime
            // 
            this.inGameTime.AutoSize = true;
            this.inGameTime.Location = new System.Drawing.Point(81, 89);
            this.inGameTime.Name = "inGameTime";
            this.inGameTime.Size = new System.Drawing.Size(75, 13);
            this.inGameTime.TabIndex = 5;
            this.inGameTime.Text = "INGAMETIME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "In-Game Time : ";
            // 
            // levelName
            // 
            this.levelName.AutoSize = true;
            this.levelName.Location = new System.Drawing.Point(81, 32);
            this.levelName.Name = "levelName";
            this.levelName.Size = new System.Drawing.Size(71, 13);
            this.levelName.TabIndex = 3;
            this.levelName.Text = "LEVELNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Level :";
            // 
            // playerCoords
            // 
            this.playerCoords.AutoSize = true;
            this.playerCoords.Location = new System.Drawing.Point(81, 49);
            this.playerCoords.Name = "playerCoords";
            this.playerCoords.Size = new System.Drawing.Size(62, 13);
            this.playerCoords.TabIndex = 1;
            this.playerCoords.Text = "X : | Y : | Z :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coordinates :";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(280, 61);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 34);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // clearInputs
            // 
            this.clearInputs.Location = new System.Drawing.Point(281, 388);
            this.clearInputs.Name = "clearInputs";
            this.clearInputs.Size = new System.Drawing.Size(75, 43);
            this.clearInputs.TabIndex = 4;
            this.clearInputs.Text = "Clear";
            this.clearInputs.UseVisualStyleBackColor = true;
            this.clearInputs.Click += new System.EventHandler(this.clearInputs_Click);
            // 
            // addInput
            // 
            this.addInput.Location = new System.Drawing.Point(281, 359);
            this.addInput.Name = "addInput";
            this.addInput.Size = new System.Drawing.Size(37, 23);
            this.addInput.TabIndex = 5;
            this.addInput.Text = "+";
            this.addInput.UseVisualStyleBackColor = true;
            this.addInput.Click += new System.EventHandler(this.addInput_Click);
            // 
            // delInput
            // 
            this.delInput.Location = new System.Drawing.Point(319, 359);
            this.delInput.Name = "delInput";
            this.delInput.Size = new System.Drawing.Size(37, 23);
            this.delInput.TabIndex = 6;
            this.delInput.Text = "-";
            this.delInput.UseVisualStyleBackColor = true;
            this.delInput.Click += new System.EventHandler(this.delInput_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputsBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 419);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inputs";
            // 
            // eventsCount
            // 
            this.eventsCount.AutoSize = true;
            this.eventsCount.Location = new System.Drawing.Point(15, 434);
            this.eventsCount.Name = "eventsCount";
            this.eventsCount.Size = new System.Drawing.Size(88, 13);
            this.eventsCount.TabIndex = 8;
            this.eventsCount.Text = "EVENTSCOUNT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.eventsCount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.delInput);
            this.Controls.Add(this.addInput);
            this.Controls.Add(this.clearInputs);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.recordButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NaRTaS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inputsBox;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label playerCoords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label levelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label inGameTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearInputs;
        private System.Windows.Forms.Button addInput;
        private System.Windows.Forms.Button delInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label eventsCount;
    }
}

