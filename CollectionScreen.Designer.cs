﻿
namespace Capstone_Project
{
    partial class CollectionScreen
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
            this.backButton = new System.Windows.Forms.Button();
            this.singlePieceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(64, 358);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // singlePieceButton
            // 
            this.singlePieceButton.Location = new System.Drawing.Point(197, 358);
            this.singlePieceButton.Name = "singlePieceButton";
            this.singlePieceButton.Size = new System.Drawing.Size(75, 23);
            this.singlePieceButton.TabIndex = 1;
            this.singlePieceButton.Text = "This Piece";
            this.singlePieceButton.UseVisualStyleBackColor = true;
            this.singlePieceButton.Click += new System.EventHandler(this.singlePieceButton_Click);
            // 
            // CollectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.singlePieceButton);
            this.Controls.Add(this.backButton);
            this.Name = "CollectionScreen";
            this.Text = "CollectionScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button singlePieceButton;
    }
}