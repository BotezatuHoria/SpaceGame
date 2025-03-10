﻿
namespace SpaceGame
{
    partial class Questions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questions));
            this.ansPanel = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.explButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.validButton = new System.Windows.Forms.Button();
            this.mistakeLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ansPanel
            // 
            this.ansPanel.BackColor = System.Drawing.Color.Transparent;
            this.ansPanel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ansPanel.Location = new System.Drawing.Point(12, 145);
            this.ansPanel.Name = "ansPanel";
            this.ansPanel.Size = new System.Drawing.Size(776, 390);
            this.ansPanel.TabIndex = 1;
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(678, 555);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "button1";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Visible = false;
            // 
            // explButton
            // 
            this.explButton.BackColor = System.Drawing.Color.Transparent;
            this.explButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.explButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.explButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.explButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.explButton.Location = new System.Drawing.Point(794, 164);
            this.explButton.Name = "explButton";
            this.explButton.Size = new System.Drawing.Size(244, 81);
            this.explButton.TabIndex = 3;
            this.explButton.UseVisualStyleBackColor = false;
            this.explButton.Visible = false;
            this.explButton.Click += new System.EventHandler(this.explButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Enabled = false;
            this.prevButton.Location = new System.Drawing.Point(34, 555);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 4;
            this.prevButton.Text = "button1";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Visible = false;
            // 
            // validButton
            // 
            this.validButton.BackColor = System.Drawing.Color.Transparent;
            this.validButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.validButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.validButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.validButton.Location = new System.Drawing.Point(794, 478);
            this.validButton.Name = "validButton";
            this.validButton.Size = new System.Drawing.Size(244, 82);
            this.validButton.TabIndex = 5;
            this.validButton.UseVisualStyleBackColor = false;
            this.validButton.Click += new System.EventHandler(this.validButton_Click);
            // 
            // mistakeLabel
            // 
            this.mistakeLabel.BackColor = System.Drawing.Color.Transparent;
            this.mistakeLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mistakeLabel.ForeColor = System.Drawing.Color.Red;
            this.mistakeLabel.Location = new System.Drawing.Point(811, 273);
            this.mistakeLabel.Name = "mistakeLabel";
            this.mistakeLabel.Size = new System.Drawing.Size(227, 139);
            this.mistakeLabel.TabIndex = 6;
            this.mistakeLabel.Text = "Răspuns greșit, verifică explicația.";
            this.mistakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(12, 9);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(1038, 130);
            this.questionLabel.TabIndex = 7;
            this.questionLabel.Text = "label1";
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.Explicatienobutton1;
            this.ClientSize = new System.Drawing.Size(1062, 590);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.mistakeLabel);
            this.Controls.Add(this.validButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.explButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.ansPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Questions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Questions_FormClosing);
            this.Load += new System.EventHandler(this.Questions_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ansPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button explButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button validButton;
        private System.Windows.Forms.Label mistakeLabel;
        private System.Windows.Forms.Label questionLabel;
    }
}