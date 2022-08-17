
namespace CalcValidation___Katharine_Wunderle
{
    partial class CalcValidation
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
            this.BeginOdoInput = new System.Windows.Forms.TextBox();
            this.beginOdoLbl = new System.Windows.Forms.Label();
            this.endOdoInput = new System.Windows.Forms.TextBox();
            this.gasPriceInput = new System.Windows.Forms.TextBox();
            this.endOdoLbl = new System.Windows.Forms.Label();
            this.gasPriceLbl = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.milesLbl = new System.Windows.Forms.Label();
            this.mpgLbl = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.milesOutput = new System.Windows.Forms.Label();
            this.mpgOutput = new System.Windows.Forms.Label();
            this.gallonLbl = new System.Windows.Forms.Label();
            this.gallonInput = new System.Windows.Forms.TextBox();
            this.dollar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BeginOdoInput
            // 
            this.BeginOdoInput.Location = new System.Drawing.Point(224, 25);
            this.BeginOdoInput.Name = "BeginOdoInput";
            this.BeginOdoInput.Size = new System.Drawing.Size(100, 20);
            this.BeginOdoInput.TabIndex = 7;
            // 
            // beginOdoLbl
            // 
            this.beginOdoLbl.AutoSize = true;
            this.beginOdoLbl.Location = new System.Drawing.Point(12, 32);
            this.beginOdoLbl.Name = "beginOdoLbl";
            this.beginOdoLbl.Size = new System.Drawing.Size(180, 13);
            this.beginOdoLbl.TabIndex = 0;
            this.beginOdoLbl.Text = "Beginning Mileage at Gas Station #1";
            // 
            // endOdoInput
            // 
            this.endOdoInput.Location = new System.Drawing.Point(224, 55);
            this.endOdoInput.Name = "endOdoInput";
            this.endOdoInput.Size = new System.Drawing.Size(100, 20);
            this.endOdoInput.TabIndex = 8;
            // 
            // gasPriceInput
            // 
            this.gasPriceInput.Location = new System.Drawing.Point(224, 113);
            this.gasPriceInput.Name = "gasPriceInput";
            this.gasPriceInput.Size = new System.Drawing.Size(100, 20);
            this.gasPriceInput.TabIndex = 10;
            // 
            // endOdoLbl
            // 
            this.endOdoLbl.AutoSize = true;
            this.endOdoLbl.Location = new System.Drawing.Point(12, 62);
            this.endOdoLbl.Name = "endOdoLbl";
            this.endOdoLbl.Size = new System.Drawing.Size(166, 13);
            this.endOdoLbl.TabIndex = 1;
            this.endOdoLbl.Text = "Ending Mileage at Gas Station #2";
            // 
            // gasPriceLbl
            // 
            this.gasPriceLbl.AutoSize = true;
            this.gasPriceLbl.Location = new System.Drawing.Point(12, 120);
            this.gasPriceLbl.Name = "gasPriceLbl";
            this.gasPriceLbl.Size = new System.Drawing.Size(151, 13);
            this.gasPriceLbl.TabIndex = 3;
            this.gasPriceLbl.Text = "Price of Gas at Gas Station #2";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(249, 145);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 11;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Location = new System.Drawing.Point(12, 192);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(164, 13);
            this.totalCostLbl.TabIndex = 4;
            this.totalCostLbl.Text = "Total cost of the fill-up at Stop #2";
            // 
            // milesLbl
            // 
            this.milesLbl.AutoSize = true;
            this.milesLbl.Location = new System.Drawing.Point(12, 225);
            this.milesLbl.Name = "milesLbl";
            this.milesLbl.Size = new System.Drawing.Size(223, 13);
            this.milesLbl.TabIndex = 5;
            this.milesLbl.Text = "Miles Traveled between Stop #1 and Stop #2";
            // 
            // mpgLbl
            // 
            this.mpgLbl.AutoSize = true;
            this.mpgLbl.Location = new System.Drawing.Point(12, 259);
            this.mpgLbl.Name = "mpgLbl";
            this.mpgLbl.Size = new System.Drawing.Size(230, 13);
            this.mpgLbl.TabIndex = 6;
            this.mpgLbl.Text = "Miles Per Gallon between Stop #1 and Stop #2";
            // 
            // totalOutput
            // 
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalOutput.Location = new System.Drawing.Point(249, 182);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(75, 23);
            this.totalOutput.TabIndex = 12;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // milesOutput
            // 
            this.milesOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.milesOutput.Location = new System.Drawing.Point(249, 215);
            this.milesOutput.Name = "milesOutput";
            this.milesOutput.Size = new System.Drawing.Size(75, 23);
            this.milesOutput.TabIndex = 13;
            this.milesOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mpgOutput
            // 
            this.mpgOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mpgOutput.Location = new System.Drawing.Point(249, 249);
            this.mpgOutput.Name = "mpgOutput";
            this.mpgOutput.Size = new System.Drawing.Size(75, 23);
            this.mpgOutput.TabIndex = 14;
            this.mpgOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gallonLbl
            // 
            this.gallonLbl.AutoSize = true;
            this.gallonLbl.Location = new System.Drawing.Point(12, 91);
            this.gallonLbl.Name = "gallonLbl";
            this.gallonLbl.Size = new System.Drawing.Size(129, 13);
            this.gallonLbl.TabIndex = 2;
            this.gallonLbl.Text = "Gallons needed to fill tank";
            // 
            // gallonInput
            // 
            this.gallonInput.Location = new System.Drawing.Point(224, 84);
            this.gallonInput.Name = "gallonInput";
            this.gallonInput.Size = new System.Drawing.Size(100, 20);
            this.gallonInput.TabIndex = 9;
            // 
            // dollar
            // 
            this.dollar.AutoSize = true;
            this.dollar.Location = new System.Drawing.Point(210, 116);
            this.dollar.Name = "dollar";
            this.dollar.Size = new System.Drawing.Size(13, 13);
            this.dollar.TabIndex = 15;
            this.dollar.Text = "$";
            // 
            // CalcValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 299);
            this.Controls.Add(this.dollar);
            this.Controls.Add(this.gallonInput);
            this.Controls.Add(this.gallonLbl);
            this.Controls.Add(this.mpgOutput);
            this.Controls.Add(this.milesOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.mpgLbl);
            this.Controls.Add(this.milesLbl);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.gasPriceLbl);
            this.Controls.Add(this.endOdoLbl);
            this.Controls.Add(this.gasPriceInput);
            this.Controls.Add(this.endOdoInput);
            this.Controls.Add(this.beginOdoLbl);
            this.Controls.Add(this.BeginOdoInput);
            this.Name = "CalcValidation";
            this.Text = "Auto Miles Per Gallon Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BeginOdoInput;
        private System.Windows.Forms.Label beginOdoLbl;
        private System.Windows.Forms.TextBox endOdoInput;
        private System.Windows.Forms.TextBox gasPriceInput;
        private System.Windows.Forms.Label endOdoLbl;
        private System.Windows.Forms.Label gasPriceLbl;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label totalCostLbl;
        private System.Windows.Forms.Label milesLbl;
        private System.Windows.Forms.Label mpgLbl;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label milesOutput;
        private System.Windows.Forms.Label mpgOutput;
        private System.Windows.Forms.Label gallonLbl;
        private System.Windows.Forms.TextBox gallonInput;
        private System.Windows.Forms.Label dollar;
    }
}

