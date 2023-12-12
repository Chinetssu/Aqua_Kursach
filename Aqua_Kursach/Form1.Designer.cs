
namespace Aqua_Kursach
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbGravitonPower = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonRadar = new System.Windows.Forms.Button();
            this.labelScanHP = new System.Windows.Forms.Label();
            this.checkBox_Step = new System.Windows.Forms.CheckBox();
            this.tbTimeTrack = new System.Windows.Forms.TrackBar();
            this.buttonStep = new System.Windows.Forms.Button();
            this.buttonDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGravitonPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(0, 0);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(768, 445);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(168, 471);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 17);
            this.lblDirection.TabIndex = 2;
            // 
            // tbGravitonPower
            // 
            this.tbGravitonPower.Location = new System.Drawing.Point(793, 57);
            this.tbGravitonPower.Maximum = 100;
            this.tbGravitonPower.Name = "tbGravitonPower";
            this.tbGravitonPower.Size = new System.Drawing.Size(154, 56);
            this.tbGravitonPower.TabIndex = 3;
            this.tbGravitonPower.Scroll += new System.EventHandler(this.tbGravitonPower_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сила гравит. области";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(808, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Дождь";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_Changed);
            // 
            // buttonRadar
            // 
            this.buttonRadar.Location = new System.Drawing.Point(808, 168);
            this.buttonRadar.Name = "buttonRadar";
            this.buttonRadar.Size = new System.Drawing.Size(101, 29);
            this.buttonRadar.TabIndex = 7;
            this.buttonRadar.Text = "Сканер";
            this.buttonRadar.UseVisualStyleBackColor = true;
            this.buttonRadar.Click += new System.EventHandler(this.ButtonRadar_Click);
            // 
            // labelScanHP
            // 
            this.labelScanHP.AutoSize = true;
            this.labelScanHP.Location = new System.Drawing.Point(923, 174);
            this.labelScanHP.Name = "labelScanHP";
            this.labelScanHP.Size = new System.Drawing.Size(24, 17);
            this.labelScanHP.TabIndex = 8;
            this.labelScanHP.Text = "hp";
            // 
            // checkBox_Step
            // 
            this.checkBox_Step.AutoSize = true;
            this.checkBox_Step.Location = new System.Drawing.Point(808, 231);
            this.checkBox_Step.Name = "checkBox_Step";
            this.checkBox_Step.Size = new System.Drawing.Size(95, 21);
            this.checkBox_Step.TabIndex = 9;
            this.checkBox_Step.Text = "Пошагово";
            this.checkBox_Step.UseVisualStyleBackColor = true;
            this.checkBox_Step.CheckedChanged += new System.EventHandler(this.checkBox_Step_CheckedChanged);
            // 
            // tbTimeTrack
            // 
            this.tbTimeTrack.Location = new System.Drawing.Point(793, 259);
            this.tbTimeTrack.Maximum = 150;
            this.tbTimeTrack.Minimum = 10;
            this.tbTimeTrack.Name = "tbTimeTrack";
            this.tbTimeTrack.Size = new System.Drawing.Size(154, 56);
            this.tbTimeTrack.TabIndex = 10;
            this.tbTimeTrack.Value = 10;
            this.tbTimeTrack.Scroll += new System.EventHandler(this.tbTimeTrack_Scroll);
            // 
            // buttonStep
            // 
            this.buttonStep.Enabled = false;
            this.buttonStep.Location = new System.Drawing.Point(808, 303);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(101, 27);
            this.buttonStep.TabIndex = 11;
            this.buttonStep.Text = "Шаг";
            this.buttonStep.UseVisualStyleBackColor = true;
            this.buttonStep.Click += new System.EventHandler(this.buttonStep_Click);
            // 
            // buttonDetails
            // 
            this.buttonDetails.Location = new System.Drawing.Point(808, 357);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(101, 29);
            this.buttonDetails.TabIndex = 12;
            this.buttonDetails.Text = "Детали";
            this.buttonDetails.UseVisualStyleBackColor = true;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 500);
            this.Controls.Add(this.buttonDetails);
            this.Controls.Add(this.buttonStep);
            this.Controls.Add(this.tbTimeTrack);
            this.Controls.Add(this.checkBox_Step);
            this.Controls.Add(this.labelScanHP);
            this.Controls.Add(this.buttonRadar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGravitonPower);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGravitonPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar tbGravitonPower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonRadar;
        private System.Windows.Forms.Label labelScanHP;
        private System.Windows.Forms.CheckBox checkBox_Step;
        private System.Windows.Forms.TrackBar tbTimeTrack;
        private System.Windows.Forms.Button buttonStep;
        private System.Windows.Forms.Button buttonDetails;
    }
}

