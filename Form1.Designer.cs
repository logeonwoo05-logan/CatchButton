namespace CatchButton
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
            runningbutton = new Button();
            reset = new Button();
            SuspendLayout();
            // 
            // runningbutton
            // 
            runningbutton.BackColor = Color.Red;
            runningbutton.Font = new Font("맑은 고딕", 15F, FontStyle.Bold);
            runningbutton.ForeColor = Color.Yellow;
            runningbutton.Location = new Point(294, 122);
            runningbutton.Name = "runningbutton";
            runningbutton.Size = new Size(250, 100);
            runningbutton.TabIndex = 0;
            runningbutton.Text = "나를 잡아봐";
            runningbutton.UseVisualStyleBackColor = false;
            runningbutton.Click += runningbutton_Click;
            runningbutton.MouseEnter += runningbutton_MouseEnter;
            // 
            // reset
            // 
            reset.Location = new Point(650, -2);
            reset.Name = "reset";
            reset.Size = new Size(150, 46);
            reset.TabIndex = 1;
            reset.Text = "다시시작";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reset);
            Controls.Add(runningbutton);
            Name = "Form1";
            Text = "버튼 잡기 게임";
            ResumeLayout(false);
        }

        #endregion

        private Button runningbutton;
        private Button reset;
    }
}
