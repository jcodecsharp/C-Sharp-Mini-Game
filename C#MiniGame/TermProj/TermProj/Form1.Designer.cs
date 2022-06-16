namespace TermProj
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
            this.newGame = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.abort = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gameHistory = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.showSolution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newGame
            // 
            this.newGame.Location = new System.Drawing.Point(34, 38);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(75, 23);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(34, 76);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 1;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // abort
            // 
            this.abort.Location = new System.Drawing.Point(34, 118);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(75, 23);
            this.abort.TabIndex = 2;
            this.abort.Text = "Abort";
            this.abort.UseVisualStyleBackColor = true;
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox1.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox1.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 38);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox2.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox2.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(220, 38);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(25, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox3.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox3.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(245, 38);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(25, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox4.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox4.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(270, 38);
            this.textBox5.Margin = new System.Windows.Forms.Padding(0);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(25, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox5.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox5.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(170, 58);
            this.textBox6.Margin = new System.Windows.Forms.Padding(0);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(25, 20);
            this.textBox6.TabIndex = 10;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox6.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox6.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(195, 58);
            this.textBox7.Margin = new System.Windows.Forms.Padding(0);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(25, 20);
            this.textBox7.TabIndex = 11;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox7.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox7.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(220, 58);
            this.textBox8.Margin = new System.Windows.Forms.Padding(0);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(25, 20);
            this.textBox8.TabIndex = 12;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox8.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox8.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(245, 58);
            this.textBox9.Margin = new System.Windows.Forms.Padding(0);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(25, 20);
            this.textBox9.TabIndex = 13;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox9.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox9.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(270, 58);
            this.textBox10.Margin = new System.Windows.Forms.Padding(0);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(25, 20);
            this.textBox10.TabIndex = 14;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox10.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox10.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox10.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(170, 78);
            this.textBox11.Margin = new System.Windows.Forms.Padding(0);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(25, 20);
            this.textBox11.TabIndex = 15;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox11.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox11.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox11.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(195, 78);
            this.textBox12.Margin = new System.Windows.Forms.Padding(0);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(25, 20);
            this.textBox12.TabIndex = 16;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox12.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox12.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox12.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(220, 78);
            this.textBox13.Margin = new System.Windows.Forms.Padding(0);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(25, 20);
            this.textBox13.TabIndex = 17;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox13.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox13.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox13.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(245, 78);
            this.textBox14.Margin = new System.Windows.Forms.Padding(0);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(25, 20);
            this.textBox14.TabIndex = 18;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox14.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox14.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox14.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(270, 78);
            this.textBox15.Margin = new System.Windows.Forms.Padding(0);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(25, 20);
            this.textBox15.TabIndex = 19;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox15.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox15.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox15.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(170, 98);
            this.textBox16.Margin = new System.Windows.Forms.Padding(0);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(25, 20);
            this.textBox16.TabIndex = 20;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox16.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox16.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox16.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(195, 98);
            this.textBox17.Margin = new System.Windows.Forms.Padding(0);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(25, 20);
            this.textBox17.TabIndex = 21;
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox17.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox17.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox17.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(220, 98);
            this.textBox18.Margin = new System.Windows.Forms.Padding(0);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(25, 20);
            this.textBox18.TabIndex = 22;
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox18.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox18.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox18.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(245, 98);
            this.textBox19.Margin = new System.Windows.Forms.Padding(0);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(25, 20);
            this.textBox19.TabIndex = 23;
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox19.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox19.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox19.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(270, 98);
            this.textBox20.Margin = new System.Windows.Forms.Padding(0);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(25, 20);
            this.textBox20.TabIndex = 24;
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox20.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox20.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox20.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(170, 118);
            this.textBox21.Margin = new System.Windows.Forms.Padding(0);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(25, 20);
            this.textBox21.TabIndex = 25;
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox21.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox21.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox21.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(195, 118);
            this.textBox22.Margin = new System.Windows.Forms.Padding(0);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(25, 20);
            this.textBox22.TabIndex = 26;
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox22.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox22.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox22.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(220, 118);
            this.textBox23.Margin = new System.Windows.Forms.Padding(0);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(25, 20);
            this.textBox23.TabIndex = 27;
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox23.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox23.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox23.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(245, 118);
            this.textBox24.Margin = new System.Windows.Forms.Padding(0);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(25, 20);
            this.textBox24.TabIndex = 28;
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox24.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox24.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox24.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(270, 118);
            this.textBox25.Margin = new System.Windows.Forms.Padding(0);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(25, 20);
            this.textBox25.TabIndex = 29;
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox25.TextChanged += new System.EventHandler(this.ifTextChanged);
            this.textBox25.Enter += new System.EventHandler(this.resumeTimer_pause);
            this.textBox25.Leave += new System.EventHandler(this.LeaveTextBox);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "0 Seconds";
            // 
            // gameHistory
            // 
            this.gameHistory.Location = new System.Drawing.Point(34, 161);
            this.gameHistory.Name = "gameHistory";
            this.gameHistory.Size = new System.Drawing.Size(75, 39);
            this.gameHistory.TabIndex = 31;
            this.gameHistory.Text = "View Game History";
            this.gameHistory.UseVisualStyleBackColor = true;
            this.gameHistory.Click += new System.EventHandler(this.gameHistory_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.myTimer_Tick2);
            // 
            // showSolution
            // 
            this.showSolution.Location = new System.Drawing.Point(34, 215);
            this.showSolution.Name = "showSolution";
            this.showSolution.Size = new System.Drawing.Size(75, 40);
            this.showSolution.TabIndex = 32;
            this.showSolution.Text = "Show Solution";
            this.showSolution.UseVisualStyleBackColor = true;
            this.showSolution.Click += new System.EventHandler(this.showSolution_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 372);
            this.Controls.Add(this.showSolution);
            this.Controls.Add(this.gameHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.newGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gameHistory;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button showSolution;
    }
}

