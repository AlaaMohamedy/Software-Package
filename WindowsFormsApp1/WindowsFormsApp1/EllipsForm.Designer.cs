﻿namespace WindowsFormsApp1
{
    partial class EllipsForm
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
            this.Draw = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.rx = new System.Windows.Forms.TextBox();
            this.ry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Draw
            // 
            this.Draw.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Draw.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Draw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Draw.Location = new System.Drawing.Point(325, 483);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(104, 37);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = false;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Clear.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(122, 483);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(105, 37);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(52, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 297);
            this.panel1.TabIndex = 2;
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(284, 51);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(84, 20);
            this.x.TabIndex = 3;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(395, 51);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(79, 20);
            this.y.TabIndex = 4;
            // 
            // rx
            // 
            this.rx.Location = new System.Drawing.Point(284, 99);
            this.rx.Name = "rx";
            this.rx.Size = new System.Drawing.Size(84, 20);
            this.rx.TabIndex = 5;
            // 
            // ry
            // 
            this.ry.Location = new System.Drawing.Point(395, 99);
            this.ry.Name = "ry";
            this.ry.Size = new System.Drawing.Size(79, 20);
            this.ry.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Center Point ( x ,y ) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Raduis Value ( x , y) :";
            // 
            // EllipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(564, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ry);
            this.Controls.Add(this.rx);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Draw);
            this.Name = "EllipsForm";
            this.Text = "Ellips";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.TextBox rx;
        private System.Windows.Forms.TextBox ry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}