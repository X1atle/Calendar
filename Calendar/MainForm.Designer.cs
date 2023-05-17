namespace Calendar
{
    partial class MainForm
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
            this.daysContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btPrevious = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daysContainer
            // 
            this.daysContainer.BackColor = System.Drawing.Color.Linen;
            this.daysContainer.Location = new System.Drawing.Point(10, 129);
            this.daysContainer.Name = "daysContainer";
            this.daysContainer.Size = new System.Drawing.Size(930, 420);
            this.daysContainer.TabIndex = 0;
            // 
            // btPrevious
            // 
            this.btPrevious.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrevious.Location = new System.Drawing.Point(676, 555);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(129, 38);
            this.btPrevious.TabIndex = 1;
            this.btPrevious.Text = "Previous";
            this.btPrevious.UseVisualStyleBackColor = false;
            this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Location = new System.Drawing.Point(811, 555);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(129, 38);
            this.btNext.TabIndex = 2;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 64);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tuesday";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 64);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thursday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 64);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wednesday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label5.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 64);
            this.label5.TabIndex = 9;
            this.label5.Text = "Friday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.NavajoWhite;
            this.label6.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(673, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 64);
            this.label6.TabIndex = 8;
            this.label6.Text = "Saturday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.NavajoWhite;
            this.label7.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(805, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 64);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sunday";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbdate
            // 
            this.lbdate.BackColor = System.Drawing.Color.PapayaWhip;
            this.lbdate.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(276, 9);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(391, 38);
            this.lbdate.TabIndex = 10;
            this.lbdate.Text = "MONTH DAY";
            this.lbdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(954, 603);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrevious);
            this.Controls.Add(this.daysContainer);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lbdate;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.FlowLayoutPanel daysContainer;
        private System.Windows.Forms.Button btPrevious;
        private System.Windows.Forms.Button btNext;

        #endregion
    }
}