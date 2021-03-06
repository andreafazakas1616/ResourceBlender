﻿namespace ResourceBlender.WindowsForms
{
  partial class EditForm
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
            this.updateAndGenerateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.resourceLabel = new System.Windows.Forms.Label();
            this.romanianTranslationLabel = new System.Windows.Forms.Label();
            this.englishTranslationLabel = new System.Windows.Forms.Label();
            this.resourceTextBox = new System.Windows.Forms.TextBox();
            this.romanianTranslationTextBox = new System.Windows.Forms.TextBox();
            this.englishTranslationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updateAndGenerateButton
            // 
            this.updateAndGenerateButton.Location = new System.Drawing.Point(187, 205);
            this.updateAndGenerateButton.Name = "updateAndGenerateButton";
            this.updateAndGenerateButton.Size = new System.Drawing.Size(119, 23);
            this.updateAndGenerateButton.TabIndex = 0;
            this.updateAndGenerateButton.Text = "Update and Generate";
            this.updateAndGenerateButton.UseVisualStyleBackColor = true;
            this.updateAndGenerateButton.Click += new System.EventHandler(this.updateAndGenerateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.Location = new System.Drawing.Point(436, 205);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // resourceLabel
            // 
            this.resourceLabel.AutoSize = true;
            this.resourceLabel.Location = new System.Drawing.Point(184, 87);
            this.resourceLabel.Name = "resourceLabel";
            this.resourceLabel.Size = new System.Drawing.Size(101, 13);
            this.resourceLabel.TabIndex = 3;
            this.resourceLabel.Text = "Resource to update";
            // 
            // romanianTranslationLabel
            // 
            this.romanianTranslationLabel.AutoSize = true;
            this.romanianTranslationLabel.Location = new System.Drawing.Point(184, 118);
            this.romanianTranslationLabel.Name = "romanianTranslationLabel";
            this.romanianTranslationLabel.Size = new System.Drawing.Size(135, 13);
            this.romanianTranslationLabel.TabIndex = 4;
            this.romanianTranslationLabel.Text = "New Romanian Translation";
            // 
            // englishTranslationLabel
            // 
            this.englishTranslationLabel.AutoSize = true;
            this.englishTranslationLabel.Location = new System.Drawing.Point(184, 151);
            this.englishTranslationLabel.Name = "englishTranslationLabel";
            this.englishTranslationLabel.Size = new System.Drawing.Size(121, 13);
            this.englishTranslationLabel.TabIndex = 5;
            this.englishTranslationLabel.Text = "New English Translation";
            // 
            // resourceTextBox
            // 
            this.resourceTextBox.Location = new System.Drawing.Point(337, 84);
            this.resourceTextBox.Name = "resourceTextBox";
            this.resourceTextBox.Size = new System.Drawing.Size(174, 20);
            this.resourceTextBox.TabIndex = 6;
            this.resourceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // romanianTranslationTextBox
            // 
            this.romanianTranslationTextBox.CausesValidation = false;
            this.romanianTranslationTextBox.Location = new System.Drawing.Point(336, 115);
            this.romanianTranslationTextBox.Name = "romanianTranslationTextBox";
            this.romanianTranslationTextBox.Size = new System.Drawing.Size(175, 20);
            this.romanianTranslationTextBox.TabIndex = 7;
            // 
            // englishTranslationTextBox
            // 
            this.englishTranslationTextBox.CausesValidation = false;
            this.englishTranslationTextBox.Location = new System.Drawing.Point(337, 148);
            this.englishTranslationTextBox.Name = "englishTranslationTextBox";
            this.englishTranslationTextBox.Size = new System.Drawing.Size(174, 20);
            this.englishTranslationTextBox.TabIndex = 8;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.englishTranslationTextBox);
            this.Controls.Add(this.romanianTranslationTextBox);
            this.Controls.Add(this.resourceTextBox);
            this.Controls.Add(this.englishTranslationLabel);
            this.Controls.Add(this.romanianTranslationLabel);
            this.Controls.Add(this.resourceLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateAndGenerateButton);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button updateAndGenerateButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Label resourceLabel;
    private System.Windows.Forms.Label romanianTranslationLabel;
    private System.Windows.Forms.Label englishTranslationLabel;
    private System.Windows.Forms.TextBox resourceTextBox;
    private System.Windows.Forms.TextBox romanianTranslationTextBox;
    private System.Windows.Forms.TextBox englishTranslationTextBox;
  }
}