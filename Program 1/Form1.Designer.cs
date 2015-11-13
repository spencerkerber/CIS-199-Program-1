namespace Program_1
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
            this.SQUARE_FEET_TEXTBOX = new System.Windows.Forms.TextBox();
            this.NUMBER_OF_COATS_TEXTBOX = new System.Windows.Forms.TextBox();
            this.PRICE_PER_GALLON_TEXTBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TOTAL_SQUARE_FEET_LABEL = new System.Windows.Forms.Label();
            this.NUMBER_OF_GALLONS_REQUIRED_LABEL = new System.Windows.Forms.Label();
            this.HOURS_OF_LABOR_REQUIRED_LABEL = new System.Windows.Forms.Label();
            this.PAINT_COST_LABEL = new System.Windows.Forms.Label();
            this.LABOR_COST_LABEL = new System.Windows.Forms.Label();
            this.TOTAL_COST_LABEL = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SQUARE_FEET_TEXTBOX
            // 
            this.SQUARE_FEET_TEXTBOX.Location = new System.Drawing.Point(220, 30);
            this.SQUARE_FEET_TEXTBOX.Name = "SQUARE_FEET_TEXTBOX";
            this.SQUARE_FEET_TEXTBOX.Size = new System.Drawing.Size(100, 20);
            this.SQUARE_FEET_TEXTBOX.TabIndex = 0;
            // 
            // NUMBER_OF_COATS_TEXTBOX
            // 
            this.NUMBER_OF_COATS_TEXTBOX.Location = new System.Drawing.Point(220, 56);
            this.NUMBER_OF_COATS_TEXTBOX.Name = "NUMBER_OF_COATS_TEXTBOX";
            this.NUMBER_OF_COATS_TEXTBOX.Size = new System.Drawing.Size(100, 20);
            this.NUMBER_OF_COATS_TEXTBOX.TabIndex = 1;
            // 
            // PRICE_PER_GALLON_TEXTBOX
            // 
            this.PRICE_PER_GALLON_TEXTBOX.Location = new System.Drawing.Point(220, 82);
            this.PRICE_PER_GALLON_TEXTBOX.Name = "PRICE_PER_GALLON_TEXTBOX";
            this.PRICE_PER_GALLON_TEXTBOX.Size = new System.Drawing.Size(100, 20);
            this.PRICE_PER_GALLON_TEXTBOX.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Square feet of wall space to be painted:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of coats of paint desired:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price of the paint per gallon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total squre feet to be painted:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of gallons of paint required:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hours of labor required:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cost of paint:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cost of labor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total cost:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TOTAL_SQUARE_FEET_LABEL
            // 
            this.TOTAL_SQUARE_FEET_LABEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOTAL_SQUARE_FEET_LABEL.Location = new System.Drawing.Point(220, 143);
            this.TOTAL_SQUARE_FEET_LABEL.Name = "TOTAL_SQUARE_FEET_LABEL";
            this.TOTAL_SQUARE_FEET_LABEL.Size = new System.Drawing.Size(100, 20);
            this.TOTAL_SQUARE_FEET_LABEL.TabIndex = 12;
            // 
            // NUMBER_OF_GALLONS_REQUIRED_LABEL
            // 
            this.NUMBER_OF_GALLONS_REQUIRED_LABEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUMBER_OF_GALLONS_REQUIRED_LABEL.Location = new System.Drawing.Point(220, 170);
            this.NUMBER_OF_GALLONS_REQUIRED_LABEL.Name = "NUMBER_OF_GALLONS_REQUIRED_LABEL";
            this.NUMBER_OF_GALLONS_REQUIRED_LABEL.Size = new System.Drawing.Size(100, 20);
            this.NUMBER_OF_GALLONS_REQUIRED_LABEL.TabIndex = 13;
            // 
            // HOURS_OF_LABOR_REQUIRED_LABEL
            // 
            this.HOURS_OF_LABOR_REQUIRED_LABEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HOURS_OF_LABOR_REQUIRED_LABEL.Location = new System.Drawing.Point(220, 198);
            this.HOURS_OF_LABOR_REQUIRED_LABEL.Name = "HOURS_OF_LABOR_REQUIRED_LABEL";
            this.HOURS_OF_LABOR_REQUIRED_LABEL.Size = new System.Drawing.Size(100, 20);
            this.HOURS_OF_LABOR_REQUIRED_LABEL.TabIndex = 14;
            // 
            // PAINT_COST_LABEL
            // 
            this.PAINT_COST_LABEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PAINT_COST_LABEL.Location = new System.Drawing.Point(220, 227);
            this.PAINT_COST_LABEL.Name = "PAINT_COST_LABEL";
            this.PAINT_COST_LABEL.Size = new System.Drawing.Size(100, 20);
            this.PAINT_COST_LABEL.TabIndex = 15;
            // 
            // LABOR_COST_LABEL
            // 
            this.LABOR_COST_LABEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LABOR_COST_LABEL.Location = new System.Drawing.Point(220, 257);
            this.LABOR_COST_LABEL.Name = "LABOR_COST_LABEL";
            this.LABOR_COST_LABEL.Size = new System.Drawing.Size(100, 20);
            this.LABOR_COST_LABEL.TabIndex = 16;
            // 
            // TOTAL_COST_LABEL
            // 
            this.TOTAL_COST_LABEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOTAL_COST_LABEL.Location = new System.Drawing.Point(220, 286);
            this.TOTAL_COST_LABEL.Name = "TOTAL_COST_LABEL";
            this.TOTAL_COST_LABEL.Size = new System.Drawing.Size(100, 20);
            this.TOTAL_COST_LABEL.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TOTAL_COST_LABEL);
            this.Controls.Add(this.LABOR_COST_LABEL);
            this.Controls.Add(this.PAINT_COST_LABEL);
            this.Controls.Add(this.HOURS_OF_LABOR_REQUIRED_LABEL);
            this.Controls.Add(this.NUMBER_OF_GALLONS_REQUIRED_LABEL);
            this.Controls.Add(this.TOTAL_SQUARE_FEET_LABEL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PRICE_PER_GALLON_TEXTBOX);
            this.Controls.Add(this.NUMBER_OF_COATS_TEXTBOX);
            this.Controls.Add(this.SQUARE_FEET_TEXTBOX);
            this.Name = "Form1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SQUARE_FEET_TEXTBOX;
        private System.Windows.Forms.TextBox NUMBER_OF_COATS_TEXTBOX;
        private System.Windows.Forms.TextBox PRICE_PER_GALLON_TEXTBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TOTAL_SQUARE_FEET_LABEL;
        private System.Windows.Forms.Label NUMBER_OF_GALLONS_REQUIRED_LABEL;
        private System.Windows.Forms.Label HOURS_OF_LABOR_REQUIRED_LABEL;
        private System.Windows.Forms.Label PAINT_COST_LABEL;
        private System.Windows.Forms.Label LABOR_COST_LABEL;
        private System.Windows.Forms.Label TOTAL_COST_LABEL;
        private System.Windows.Forms.Button button1;
    }
}

