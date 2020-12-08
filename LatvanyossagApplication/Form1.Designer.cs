namespace LatvanyossagApplication
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
            this.varosok_listBox = new System.Windows.Forms.ListBox();
            this.varosneve_txtBox = new System.Windows.Forms.TextBox();
            this.lakossag_varos_updown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttn_varoshoz = new System.Windows.Forms.Button();
            this.latvanyossag_listBox = new System.Windows.Forms.ListBox();
            this.latvanyossagneve_txtBox = new System.Windows.Forms.TextBox();
            this.leiras_txtBox = new System.Windows.Forms.TextBox();
            this.latvanyar_upDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bttn_latvanyhoz = new System.Windows.Forms.Button();
            this.bttn_varosTorles = new System.Windows.Forms.Button();
            this.bttn_latvanyTorles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lakossag_varos_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyar_upDown)).BeginInit();
            this.SuspendLayout();
            // 
            // varosok_listBox
            // 
            this.varosok_listBox.FormattingEnabled = true;
            this.varosok_listBox.HorizontalScrollbar = true;
            this.varosok_listBox.IntegralHeight = false;
            this.varosok_listBox.Location = new System.Drawing.Point(13, 13);
            this.varosok_listBox.Name = "varosok_listBox";
            this.varosok_listBox.Size = new System.Drawing.Size(162, 425);
            this.varosok_listBox.TabIndex = 0;
            this.varosok_listBox.SelectedIndexChanged += new System.EventHandler(this.Városok_SelectedIndexChanged);
            // 
            // varosneve_txtBox
            // 
            this.varosneve_txtBox.Location = new System.Drawing.Point(194, 31);
            this.varosneve_txtBox.Name = "varosneve_txtBox";
            this.varosneve_txtBox.Size = new System.Drawing.Size(100, 20);
            this.varosneve_txtBox.TabIndex = 1;
            // 
            // lakossag_varos_updown
            // 
            this.lakossag_varos_updown.Location = new System.Drawing.Point(194, 76);
            this.lakossag_varos_updown.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.lakossag_varos_updown.Name = "lakossag_varos_updown";
            this.lakossag_varos_updown.Size = new System.Drawing.Size(100, 20);
            this.lakossag_varos_updown.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Város neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lakosság:";
            // 
            // bttn_varoshoz
            // 
            this.bttn_varoshoz.Location = new System.Drawing.Point(194, 113);
            this.bttn_varoshoz.Name = "bttn_varoshoz";
            this.bttn_varoshoz.Size = new System.Drawing.Size(100, 23);
            this.bttn_varoshoz.TabIndex = 5;
            this.bttn_varoshoz.Text = "Hozzáadás";
            this.bttn_varoshoz.UseVisualStyleBackColor = true;
            this.bttn_varoshoz.Click += new System.EventHandler(this.bttn_varoshoz_Click);
            // 
            // latvanyossag_listBox
            // 
            this.latvanyossag_listBox.FormattingEnabled = true;
            this.latvanyossag_listBox.HorizontalScrollbar = true;
            this.latvanyossag_listBox.IntegralHeight = false;
            this.latvanyossag_listBox.Location = new System.Drawing.Point(349, 13);
            this.latvanyossag_listBox.Name = "latvanyossag_listBox";
            this.latvanyossag_listBox.Size = new System.Drawing.Size(152, 425);
            this.latvanyossag_listBox.TabIndex = 6;
            // 
            // latvanyossagneve_txtBox
            // 
            this.latvanyossagneve_txtBox.Location = new System.Drawing.Point(508, 31);
            this.latvanyossagneve_txtBox.Name = "latvanyossagneve_txtBox";
            this.latvanyossagneve_txtBox.Size = new System.Drawing.Size(100, 20);
            this.latvanyossagneve_txtBox.TabIndex = 7;
            // 
            // leiras_txtBox
            // 
            this.leiras_txtBox.Location = new System.Drawing.Point(508, 76);
            this.leiras_txtBox.Multiline = true;
            this.leiras_txtBox.Name = "leiras_txtBox";
            this.leiras_txtBox.Size = new System.Drawing.Size(100, 96);
            this.leiras_txtBox.TabIndex = 8;
            // 
            // latvanyar_upDown
            // 
            this.latvanyar_upDown.Location = new System.Drawing.Point(508, 195);
            this.latvanyar_upDown.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.latvanyar_upDown.Name = "latvanyar_upDown";
            this.latvanyar_upDown.Size = new System.Drawing.Size(100, 20);
            this.latvanyar_upDown.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Látványosság neve:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Leírás:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ár:";
            // 
            // bttn_latvanyhoz
            // 
            this.bttn_latvanyhoz.Location = new System.Drawing.Point(508, 233);
            this.bttn_latvanyhoz.Name = "bttn_latvanyhoz";
            this.bttn_latvanyhoz.Size = new System.Drawing.Size(100, 23);
            this.bttn_latvanyhoz.TabIndex = 13;
            this.bttn_latvanyhoz.Text = "Hozzáadás";
            this.bttn_latvanyhoz.UseVisualStyleBackColor = true;
            this.bttn_latvanyhoz.Click += new System.EventHandler(this.bttn_latvanyhoz_Click);
            // 
            // bttn_varosTorles
            // 
            this.bttn_varosTorles.Location = new System.Drawing.Point(194, 142);
            this.bttn_varosTorles.Name = "bttn_varosTorles";
            this.bttn_varosTorles.Size = new System.Drawing.Size(100, 23);
            this.bttn_varosTorles.TabIndex = 14;
            this.bttn_varosTorles.Text = "Törlés";
            this.bttn_varosTorles.UseVisualStyleBackColor = true;
            this.bttn_varosTorles.Click += new System.EventHandler(this.bttn_varosTorles_Click);
            // 
            // bttn_latvanyTorles
            // 
            this.bttn_latvanyTorles.Location = new System.Drawing.Point(508, 262);
            this.bttn_latvanyTorles.Name = "bttn_latvanyTorles";
            this.bttn_latvanyTorles.Size = new System.Drawing.Size(100, 23);
            this.bttn_latvanyTorles.TabIndex = 15;
            this.bttn_latvanyTorles.Text = "Törlés";
            this.bttn_latvanyTorles.UseVisualStyleBackColor = true;
            this.bttn_latvanyTorles.Click += new System.EventHandler(this.bttn_latvanyTorles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.bttn_latvanyTorles);
            this.Controls.Add(this.bttn_varosTorles);
            this.Controls.Add(this.bttn_latvanyhoz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.latvanyar_upDown);
            this.Controls.Add(this.leiras_txtBox);
            this.Controls.Add(this.latvanyossagneve_txtBox);
            this.Controls.Add(this.latvanyossag_listBox);
            this.Controls.Add(this.bttn_varoshoz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lakossag_varos_updown);
            this.Controls.Add(this.varosneve_txtBox);
            this.Controls.Add(this.varosok_listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lakossag_varos_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyar_upDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox varosok_listBox;
        private System.Windows.Forms.TextBox varosneve_txtBox;
        private System.Windows.Forms.NumericUpDown lakossag_varos_updown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttn_varoshoz;
        private System.Windows.Forms.ListBox latvanyossag_listBox;
        private System.Windows.Forms.TextBox latvanyossagneve_txtBox;
        private System.Windows.Forms.TextBox leiras_txtBox;
        private System.Windows.Forms.NumericUpDown latvanyar_upDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttn_latvanyhoz;
        private System.Windows.Forms.Button bttn_varosTorles;
        private System.Windows.Forms.Button bttn_latvanyTorles;
    }
}

