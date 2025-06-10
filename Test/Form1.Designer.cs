namespace Test
{
    partial class Form1
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
            ctlAlarmClock1 = new ctlClockLib2.ctlAlarmClock();
            dtpTest = new DateTimePicker();
            lblTest = new Label();
            SuspendLayout();
            // 
            // ctlAlarmClock1
            // 
            ctlAlarmClock1.AlarmSet = false;
            ctlAlarmClock1.AlarmTime = new DateTime(0L);
            ctlAlarmClock1.ClockBackColor = Color.Empty;
            ctlAlarmClock1.ClockForeColor = Color.Empty;
            ctlAlarmClock1.Location = new Point(41, 52);
            ctlAlarmClock1.Name = "ctlAlarmClock1";
            ctlAlarmClock1.Size = new Size(613, 349);
            ctlAlarmClock1.TabIndex = 0;
            // 
            // dtpTest
            // 
            dtpTest.Format = DateTimePickerFormat.Time;
            dtpTest.Location = new Point(77, 19);
            dtpTest.Name = "dtpTest";
            dtpTest.Size = new Size(250, 27);
            dtpTest.TabIndex = 1;
            dtpTest.ValueChanged += dtpTest_ValueChanged;
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(376, 19);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(0, 20);
            lblTest.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTest);
            Controls.Add(dtpTest);
            Controls.Add(ctlAlarmClock1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctlClockLib2.ctlAlarmClock ctlAlarmClock1;
        private DateTimePicker dtpTest;
        private Label lblTest;
    }
}
