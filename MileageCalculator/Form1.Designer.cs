namespace MileageCalculator
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
            this.btnGetMileage = new System.Windows.Forms.Button();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblGallons = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtGallons = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetMileage
            // 
            this.btnGetMileage.Location = new System.Drawing.Point(111, 117);
            this.btnGetMileage.Name = "btnGetMileage";
            this.btnGetMileage.Size = new System.Drawing.Size(75, 23);
            this.btnGetMileage.TabIndex = 0;
            this.btnGetMileage.Text = "Get Mileage";
            this.btnGetMileage.UseVisualStyleBackColor = true;
            this.btnGetMileage.Click += new System.EventHandler(this.btnGetMileage_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(28, 25);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(49, 13);
            this.lblDistance.TabIndex = 1;
            this.lblDistance.Text = "Distance";
            // 
            // lblGallons
            // 
            this.lblGallons.AutoSize = true;
            this.lblGallons.Location = new System.Drawing.Point(28, 70);
            this.lblGallons.Name = "lblGallons";
            this.lblGallons.Size = new System.Drawing.Size(42, 13);
            this.lblGallons.TabIndex = 2;
            this.lblGallons.Text = "Gallons";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(100, 22);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 3;
            this.txtDistance.Text = "100";
            // 
            // txtGallons
            // 
            this.txtGallons.Location = new System.Drawing.Point(100, 67);
            this.txtGallons.Name = "txtGallons";
            this.txtGallons.Size = new System.Drawing.Size(100, 20);
            this.txtGallons.TabIndex = 4;
            this.txtGallons.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 165);
            this.Controls.Add(this.txtGallons);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblGallons);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.btnGetMileage);
            this.Name = "Form1";
            this.Text = "MileageCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetMileage;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblGallons;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtGallons;
    }
}

