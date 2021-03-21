
namespace CollatzApp
{
    partial class Output
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_maxMember = new System.Windows.Forms.TextBox();
            this.tb_Odd = new System.Windows.Forms.TextBox();
            this.tb_even = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Sequence = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.01754F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.98246F));
            this.tableLayoutPanel1.Controls.Add(this.tb_maxMember, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Odd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_even, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Sequence, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 150);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tb_maxMember
            // 
            this.tb_maxMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_maxMember.Enabled = false;
            this.tb_maxMember.Location = new System.Drawing.Point(139, 128);
            this.tb_maxMember.Name = "tb_maxMember";
            this.tb_maxMember.Size = new System.Drawing.Size(663, 20);
            this.tb_maxMember.TabIndex = 7;
            this.tb_maxMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Odd
            // 
            this.tb_Odd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Odd.Enabled = false;
            this.tb_Odd.Location = new System.Drawing.Point(139, 103);
            this.tb_Odd.Name = "tb_Odd";
            this.tb_Odd.Size = new System.Drawing.Size(663, 20);
            this.tb_Odd.TabIndex = 6;
            this.tb_Odd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_even
            // 
            this.tb_even.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_even.Enabled = false;
            this.tb_even.Location = new System.Drawing.Point(139, 78);
            this.tb_even.Name = "tb_even";
            this.tb_even.Size = new System.Drawing.Size(663, 20);
            this.tb_even.TabIndex = 5;
            this.tb_even.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sequence";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max member";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odd";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Even";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Sequence
            // 
            this.tb_Sequence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Sequence.Enabled = false;
            this.tb_Sequence.Location = new System.Drawing.Point(139, 3);
            this.tb_Sequence.Multiline = true;
            this.tb_Sequence.Name = "tb_Sequence";
            this.tb_Sequence.Size = new System.Drawing.Size(663, 69);
            this.tb_Sequence.TabIndex = 4;
            this.tb_Sequence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Output";
            this.Size = new System.Drawing.Size(805, 150);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_maxMember;
        private System.Windows.Forms.TextBox tb_Odd;
        private System.Windows.Forms.TextBox tb_even;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Sequence;
    }
}
