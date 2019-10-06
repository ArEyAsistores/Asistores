namespace Copro3_Project
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
            this.btnDragAndDrop = new System.Windows.Forms.Button();
            this.btnMultipleChoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDragAndDrop
            // 
            this.btnDragAndDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnDragAndDrop.BackgroundImage = global::Copro3_Project.Properties.Resources.Board_Games;
            this.btnDragAndDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDragAndDrop.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDragAndDrop.Location = new System.Drawing.Point(463, 107);
            this.btnDragAndDrop.Name = "btnDragAndDrop";
            this.btnDragAndDrop.Size = new System.Drawing.Size(281, 239);
            this.btnDragAndDrop.TabIndex = 1;
            this.btnDragAndDrop.UseVisualStyleBackColor = false;
            this.btnDragAndDrop.Click += new System.EventHandler(this.BtnDragAndDrop_Click);
            // 
            // btnMultipleChoice
            // 
            this.btnMultipleChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.btnMultipleChoice.BackgroundImage = global::Copro3_Project.Properties.Resources.Quiz_Games1;
            this.btnMultipleChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMultipleChoice.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultipleChoice.Location = new System.Drawing.Point(63, 107);
            this.btnMultipleChoice.Name = "btnMultipleChoice";
            this.btnMultipleChoice.Size = new System.Drawing.Size(281, 239);
            this.btnMultipleChoice.TabIndex = 0;
            this.btnMultipleChoice.UseVisualStyleBackColor = false;
            this.btnMultipleChoice.Click += new System.EventHandler(this.BtnMultipleChoice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDragAndDrop);
            this.Controls.Add(this.btnMultipleChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMultipleChoice;
        private System.Windows.Forms.Button btnDragAndDrop;
    }
}

