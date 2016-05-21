namespace BreakReminder
{
    partial class Form_Default
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
            this.Lbl_Frequency = new System.Windows.Forms.Label();
            this.TB_DelayLength = new System.Windows.Forms.TextBox();
            this.Tb_BreakDuration = new System.Windows.Forms.TextBox();
            this.Lbl_Duration = new System.Windows.Forms.Label();
            this.Lbl_StateTag = new System.Windows.Forms.Label();
            this.Lbl_State = new System.Windows.Forms.Label();
            this.Lbl_TimeRemaining = new System.Windows.Forms.Label();
            this.Lbl_TimeRemainingTag = new System.Windows.Forms.Label();
            this.Btn_StartStop = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Lbl_Behavior = new System.Windows.Forms.Label();
            this.CB_Minimize = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Frequency
            // 
            this.Lbl_Frequency.AutoSize = true;
            this.Lbl_Frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Frequency.Location = new System.Drawing.Point(12, 28);
            this.Lbl_Frequency.Name = "Lbl_Frequency";
            this.Lbl_Frequency.Size = new System.Drawing.Size(178, 20);
            this.Lbl_Frequency.TabIndex = 0;
            this.Lbl_Frequency.Text = "Work Duration (mins)";
            // 
            // TB_DelayLength
            // 
            this.TB_DelayLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DelayLength.Location = new System.Drawing.Point(17, 54);
            this.TB_DelayLength.Name = "TB_DelayLength";
            this.TB_DelayLength.Size = new System.Drawing.Size(173, 22);
            this.TB_DelayLength.TabIndex = 1;
            this.TB_DelayLength.Text = "8";
            this.TB_DelayLength.TextChanged += new System.EventHandler(this.TB_DelayLength_TextChanged);
            // 
            // Tb_BreakDuration
            // 
            this.Tb_BreakDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_BreakDuration.Location = new System.Drawing.Point(230, 54);
            this.Tb_BreakDuration.Name = "Tb_BreakDuration";
            this.Tb_BreakDuration.Size = new System.Drawing.Size(171, 22);
            this.Tb_BreakDuration.TabIndex = 2;
            this.Tb_BreakDuration.Text = "1";
            this.Tb_BreakDuration.TextChanged += new System.EventHandler(this.Tb_BreakDuration_TextChanged);
            // 
            // Lbl_Duration
            // 
            this.Lbl_Duration.AutoSize = true;
            this.Lbl_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Duration.Location = new System.Drawing.Point(226, 28);
            this.Lbl_Duration.Name = "Lbl_Duration";
            this.Lbl_Duration.Size = new System.Drawing.Size(175, 20);
            this.Lbl_Duration.TabIndex = 3;
            this.Lbl_Duration.Text = "Break Duration (min)";
            // 
            // Lbl_StateTag
            // 
            this.Lbl_StateTag.AutoSize = true;
            this.Lbl_StateTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_StateTag.Location = new System.Drawing.Point(12, 99);
            this.Lbl_StateTag.Name = "Lbl_StateTag";
            this.Lbl_StateTag.Size = new System.Drawing.Size(58, 20);
            this.Lbl_StateTag.TabIndex = 4;
            this.Lbl_StateTag.Text = "State:";
            // 
            // Lbl_State
            // 
            this.Lbl_State.AutoSize = true;
            this.Lbl_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_State.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Lbl_State.Location = new System.Drawing.Point(12, 130);
            this.Lbl_State.Name = "Lbl_State";
            this.Lbl_State.Size = new System.Drawing.Size(119, 20);
            this.Lbl_State.TabIndex = 5;
            this.Lbl_State.Text = "Waiting to Start";
            // 
            // Lbl_TimeRemaining
            // 
            this.Lbl_TimeRemaining.AutoSize = true;
            this.Lbl_TimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TimeRemaining.Location = new System.Drawing.Point(226, 130);
            this.Lbl_TimeRemaining.Name = "Lbl_TimeRemaining";
            this.Lbl_TimeRemaining.Size = new System.Drawing.Size(18, 20);
            this.Lbl_TimeRemaining.TabIndex = 7;
            this.Lbl_TimeRemaining.Text = "0";
            // 
            // Lbl_TimeRemainingTag
            // 
            this.Lbl_TimeRemainingTag.AutoSize = true;
            this.Lbl_TimeRemainingTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TimeRemainingTag.Location = new System.Drawing.Point(226, 99);
            this.Lbl_TimeRemainingTag.Name = "Lbl_TimeRemainingTag";
            this.Lbl_TimeRemainingTag.Size = new System.Drawing.Size(137, 20);
            this.Lbl_TimeRemainingTag.TabIndex = 6;
            this.Lbl_TimeRemainingTag.Text = "Time Remaining";
            // 
            // Btn_StartStop
            // 
            this.Btn_StartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_StartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_StartStop.Location = new System.Drawing.Point(574, 123);
            this.Btn_StartStop.Name = "Btn_StartStop";
            this.Btn_StartStop.Size = new System.Drawing.Size(112, 35);
            this.Btn_StartStop.TabIndex = 8;
            this.Btn_StartStop.Text = "Start";
            this.Btn_StartStop.UseVisualStyleBackColor = true;
            this.Btn_StartStop.Click += new System.EventHandler(this.Btn_StartStop_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Lbl_Behavior
            // 
            this.Lbl_Behavior.AutoSize = true;
            this.Lbl_Behavior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Behavior.Location = new System.Drawing.Point(444, 28);
            this.Lbl_Behavior.Name = "Lbl_Behavior";
            this.Lbl_Behavior.Size = new System.Drawing.Size(89, 20);
            this.Lbl_Behavior.TabIndex = 9;
            this.Lbl_Behavior.Text = "Behaviour";
            // 
            // CB_Minimize
            // 
            this.CB_Minimize.AutoSize = true;
            this.CB_Minimize.Checked = true;
            this.CB_Minimize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Minimize.Location = new System.Drawing.Point(448, 54);
            this.CB_Minimize.Name = "CB_Minimize";
            this.CB_Minimize.Size = new System.Drawing.Size(178, 24);
            this.CB_Minimize.TabIndex = 13;
            this.CB_Minimize.Text = "Minimize All on Break";
            this.CB_Minimize.UseVisualStyleBackColor = true;
            this.CB_Minimize.CheckedChanged += new System.EventHandler(this.CB_Minimize_CheckedChanged);
            // 
            // Form_Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 170);
            this.Controls.Add(this.CB_Minimize);
            this.Controls.Add(this.Lbl_Behavior);
            this.Controls.Add(this.Btn_StartStop);
            this.Controls.Add(this.Lbl_TimeRemaining);
            this.Controls.Add(this.Lbl_TimeRemainingTag);
            this.Controls.Add(this.Lbl_State);
            this.Controls.Add(this.Lbl_StateTag);
            this.Controls.Add(this.Lbl_Duration);
            this.Controls.Add(this.Tb_BreakDuration);
            this.Controls.Add(this.TB_DelayLength);
            this.Controls.Add(this.Lbl_Frequency);
            this.Name = "Form_Default";
            this.Text = "Break Reminder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Frequency;
        private System.Windows.Forms.TextBox TB_DelayLength;
        private System.Windows.Forms.TextBox Tb_BreakDuration;
        private System.Windows.Forms.Label Lbl_Duration;
        private System.Windows.Forms.Label Lbl_StateTag;
        private System.Windows.Forms.Label Lbl_State;
        private System.Windows.Forms.Label Lbl_TimeRemaining;
        private System.Windows.Forms.Label Lbl_TimeRemainingTag;
        private System.Windows.Forms.Button Btn_StartStop;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox CB_Minimize;
        private System.Windows.Forms.Label Lbl_Behavior;
    }
}

