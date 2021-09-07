
namespace Client_RestConsumer
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
            this.btnRestConsumer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestConsumer
            // 
            this.btnRestConsumer.Location = new System.Drawing.Point(119, 36);
            this.btnRestConsumer.Name = "btnRestConsumer";
            this.btnRestConsumer.Size = new System.Drawing.Size(177, 50);
            this.btnRestConsumer.TabIndex = 0;
            this.btnRestConsumer.Text = "Rest Consumer";
            this.btnRestConsumer.UseVisualStyleBackColor = true;
            this.btnRestConsumer.Click += new System.EventHandler(this.btnRestConsumer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 118);
            this.Controls.Add(this.btnRestConsumer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestConsumer;
    }
}

