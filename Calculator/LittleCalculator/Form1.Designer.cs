namespace LittleCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonmc = new System.Windows.Forms.Button();
            this.buttonmr = new System.Windows.Forms.Button();
            this.buttonms = new System.Windows.Forms.Button();
            this.buttonmplus = new System.Windows.Forms.Button();
            this.buttonmdec = new System.Windows.Forms.Button();
            this.buttoncheck = new System.Windows.Forms.Button();
            this.buttonpd = new System.Windows.Forms.Button();
            this.buttonc = new System.Windows.Forms.Button();
            this.buttonce = new System.Windows.Forms.Button();
            this.buttonleft = new System.Windows.Forms.Button();
            this.buttonpercent = new System.Windows.Forms.Button();
            this.buttondiv = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttondown = new System.Windows.Forms.Button();
            this.buttonmulti = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonequal = new System.Windows.Forms.Button();
            this.buttondec = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonplus = new System.Windows.Forms.Button();
            this.buttonpoint = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.labelm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonmc
            // 
            this.buttonmc.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmc.Location = new System.Drawing.Point(24, 100);
            this.buttonmc.Name = "buttonmc";
            this.buttonmc.Size = new System.Drawing.Size(50, 44);
            this.buttonmc.TabIndex = 0;
            this.buttonmc.Tag = "c";
            this.buttonmc.Text = "MC";
            this.buttonmc.UseVisualStyleBackColor = true;
            this.buttonmc.Click += new System.EventHandler(this.buttonMemory_Click);
            // 
            // buttonmr
            // 
            this.buttonmr.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmr.Location = new System.Drawing.Point(90, 100);
            this.buttonmr.Name = "buttonmr";
            this.buttonmr.Size = new System.Drawing.Size(50, 44);
            this.buttonmr.TabIndex = 1;
            this.buttonmr.Tag = "r";
            this.buttonmr.Text = "MR";
            this.buttonmr.UseVisualStyleBackColor = true;
            this.buttonmr.Click += new System.EventHandler(this.buttonMemory_Click);
            // 
            // buttonms
            // 
            this.buttonms.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonms.Location = new System.Drawing.Point(156, 100);
            this.buttonms.Name = "buttonms";
            this.buttonms.Size = new System.Drawing.Size(50, 44);
            this.buttonms.TabIndex = 2;
            this.buttonms.Tag = "s";
            this.buttonms.Text = "MS";
            this.buttonms.UseVisualStyleBackColor = true;
            this.buttonms.Click += new System.EventHandler(this.buttonMemory_Click);
            // 
            // buttonmplus
            // 
            this.buttonmplus.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmplus.Location = new System.Drawing.Point(222, 100);
            this.buttonmplus.Name = "buttonmplus";
            this.buttonmplus.Size = new System.Drawing.Size(50, 44);
            this.buttonmplus.TabIndex = 3;
            this.buttonmplus.Tag = "+";
            this.buttonmplus.Text = "M+";
            this.buttonmplus.UseVisualStyleBackColor = true;
            this.buttonmplus.Click += new System.EventHandler(this.buttonMemory_Click);
            // 
            // buttonmdec
            // 
            this.buttonmdec.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmdec.Location = new System.Drawing.Point(288, 100);
            this.buttonmdec.Name = "buttonmdec";
            this.buttonmdec.Size = new System.Drawing.Size(50, 44);
            this.buttonmdec.TabIndex = 4;
            this.buttonmdec.Tag = "-";
            this.buttonmdec.Text = "M-";
            this.buttonmdec.UseVisualStyleBackColor = true;
            this.buttonmdec.Click += new System.EventHandler(this.buttonMemory_Click);
            // 
            // buttoncheck
            // 
            this.buttoncheck.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncheck.Location = new System.Drawing.Point(288, 154);
            this.buttoncheck.Name = "buttoncheck";
            this.buttoncheck.Size = new System.Drawing.Size(50, 44);
            this.buttoncheck.TabIndex = 9;
            this.buttoncheck.Tag = "v";
            this.buttoncheck.Text = "v";
            this.buttoncheck.UseVisualStyleBackColor = true;
            this.buttoncheck.Click += new System.EventHandler(this.buttonSpecial_Click);
            // 
            // buttonpd
            // 
            this.buttonpd.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpd.Location = new System.Drawing.Point(222, 154);
            this.buttonpd.Name = "buttonpd";
            this.buttonpd.Size = new System.Drawing.Size(50, 44);
            this.buttonpd.TabIndex = 8;
            this.buttonpd.Tag = "n";
            this.buttonpd.Text = "+-";
            this.buttonpd.UseVisualStyleBackColor = true;
            this.buttonpd.Click += new System.EventHandler(this.buttonSpecial_Click);
            // 
            // buttonc
            // 
            this.buttonc.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonc.Location = new System.Drawing.Point(156, 154);
            this.buttonc.Name = "buttonc";
            this.buttonc.Size = new System.Drawing.Size(50, 44);
            this.buttonc.TabIndex = 7;
            this.buttonc.Text = "C";
            this.buttonc.UseVisualStyleBackColor = true;
            this.buttonc.Click += new System.EventHandler(this.buttonc_Click);
            // 
            // buttonce
            // 
            this.buttonce.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonce.Location = new System.Drawing.Point(90, 154);
            this.buttonce.Name = "buttonce";
            this.buttonce.Size = new System.Drawing.Size(50, 44);
            this.buttonce.TabIndex = 6;
            this.buttonce.Text = "CE";
            this.buttonce.UseVisualStyleBackColor = true;
            this.buttonce.Click += new System.EventHandler(this.buttonce_Click);
            // 
            // buttonleft
            // 
            this.buttonleft.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonleft.Location = new System.Drawing.Point(24, 154);
            this.buttonleft.Name = "buttonleft";
            this.buttonleft.Size = new System.Drawing.Size(50, 44);
            this.buttonleft.TabIndex = 5;
            this.buttonleft.Tag = "<";
            this.buttonleft.Text = "<-";
            this.buttonleft.UseVisualStyleBackColor = true;
            this.buttonleft.Click += new System.EventHandler(this.buttonSpecial_Click);
            // 
            // buttonpercent
            // 
            this.buttonpercent.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpercent.Location = new System.Drawing.Point(288, 208);
            this.buttonpercent.Name = "buttonpercent";
            this.buttonpercent.Size = new System.Drawing.Size(50, 44);
            this.buttonpercent.TabIndex = 14;
            this.buttonpercent.Tag = "%";
            this.buttonpercent.Text = "%";
            this.buttonpercent.UseVisualStyleBackColor = true;
            this.buttonpercent.Click += new System.EventHandler(this.buttonSpecial_Click);
            // 
            // buttondiv
            // 
            this.buttondiv.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondiv.Location = new System.Drawing.Point(222, 208);
            this.buttondiv.Name = "buttondiv";
            this.buttondiv.Size = new System.Drawing.Size(50, 44);
            this.buttondiv.TabIndex = 13;
            this.buttondiv.Text = "/";
            this.buttondiv.UseVisualStyleBackColor = true;
            this.buttondiv.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(156, 208);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 44);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(90, 208);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 44);
            this.button8.TabIndex = 11;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(24, 208);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 44);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // buttondown
            // 
            this.buttondown.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondown.Location = new System.Drawing.Point(288, 262);
            this.buttondown.Name = "buttondown";
            this.buttondown.Size = new System.Drawing.Size(50, 44);
            this.buttondown.TabIndex = 19;
            this.buttondown.Tag = "d";
            this.buttondown.Text = "1/x";
            this.buttondown.UseVisualStyleBackColor = true;
            this.buttondown.Click += new System.EventHandler(this.buttonSpecial_Click);
            // 
            // buttonmulti
            // 
            this.buttonmulti.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmulti.Location = new System.Drawing.Point(222, 262);
            this.buttonmulti.Name = "buttonmulti";
            this.buttonmulti.Size = new System.Drawing.Size(50, 44);
            this.buttonmulti.TabIndex = 18;
            this.buttonmulti.Text = "*";
            this.buttonmulti.UseVisualStyleBackColor = true;
            this.buttonmulti.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(156, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 44);
            this.button6.TabIndex = 17;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(90, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 44);
            this.button5.TabIndex = 16;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(24, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 44);
            this.button4.TabIndex = 15;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonequal
            // 
            this.buttonequal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonequal.Location = new System.Drawing.Point(288, 316);
            this.buttonequal.Name = "buttonequal";
            this.buttonequal.Size = new System.Drawing.Size(50, 98);
            this.buttonequal.TabIndex = 24;
            this.buttonequal.Text = "=";
            this.buttonequal.UseVisualStyleBackColor = true;
            this.buttonequal.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttondec
            // 
            this.buttondec.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondec.Location = new System.Drawing.Point(222, 316);
            this.buttondec.Name = "buttondec";
            this.buttondec.Size = new System.Drawing.Size(50, 44);
            this.buttondec.TabIndex = 23;
            this.buttondec.Text = "-";
            this.buttondec.UseVisualStyleBackColor = true;
            this.buttondec.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(156, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 44);
            this.button3.TabIndex = 22;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(90, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 44);
            this.button2.TabIndex = 21;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 44);
            this.button1.TabIndex = 20;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonplus
            // 
            this.buttonplus.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonplus.Location = new System.Drawing.Point(222, 370);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(50, 44);
            this.buttonplus.TabIndex = 27;
            this.buttonplus.Text = "+";
            this.buttonplus.UseVisualStyleBackColor = true;
            this.buttonplus.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonpoint
            // 
            this.buttonpoint.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpoint.Location = new System.Drawing.Point(156, 370);
            this.buttonpoint.Name = "buttonpoint";
            this.buttonpoint.Size = new System.Drawing.Size(50, 44);
            this.buttonpoint.TabIndex = 26;
            this.buttonpoint.Text = ".";
            this.buttonpoint.UseVisualStyleBackColor = true;
            this.buttonpoint.Click += new System.EventHandler(this.button_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(24, 370);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(119, 44);
            this.button0.TabIndex = 25;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Black;
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.display.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.Color.White;
            this.display.Location = new System.Drawing.Point(24, 21);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(314, 67);
            this.display.TabIndex = 28;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelm
            // 
            this.labelm.AutoSize = true;
            this.labelm.BackColor = System.Drawing.Color.Black;
            this.labelm.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelm.ForeColor = System.Drawing.Color.White;
            this.labelm.Location = new System.Drawing.Point(32, 69);
            this.labelm.Name = "labelm";
            this.labelm.Size = new System.Drawing.Size(16, 12);
            this.labelm.TabIndex = 29;
            this.labelm.Text = "M";
            this.labelm.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 434);
            this.Controls.Add(this.labelm);
            this.Controls.Add(this.display);
            this.Controls.Add(this.buttonplus);
            this.Controls.Add(this.buttonpoint);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonequal);
            this.Controls.Add(this.buttondec);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttondown);
            this.Controls.Add(this.buttonmulti);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonpercent);
            this.Controls.Add(this.buttondiv);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttoncheck);
            this.Controls.Add(this.buttonpd);
            this.Controls.Add(this.buttonc);
            this.Controls.Add(this.buttonce);
            this.Controls.Add(this.buttonleft);
            this.Controls.Add(this.buttonmdec);
            this.Controls.Add(this.buttonmplus);
            this.Controls.Add(this.buttonms);
            this.Controls.Add(this.buttonmr);
            this.Controls.Add(this.buttonmc);
            this.Name = "Form1";
            this.Text = "計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonmc;
        private System.Windows.Forms.Button buttonmr;
        private System.Windows.Forms.Button buttonms;
        private System.Windows.Forms.Button buttonmplus;
        private System.Windows.Forms.Button buttonmdec;
        private System.Windows.Forms.Button buttoncheck;
        private System.Windows.Forms.Button buttonpd;
        private System.Windows.Forms.Button buttonc;
        private System.Windows.Forms.Button buttonce;
        private System.Windows.Forms.Button buttonleft;
        private System.Windows.Forms.Button buttonpercent;
        private System.Windows.Forms.Button buttondiv;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttondown;
        private System.Windows.Forms.Button buttonmulti;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonequal;
        private System.Windows.Forms.Button buttondec;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.Button buttonpoint;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Label labelm;
    }
}

