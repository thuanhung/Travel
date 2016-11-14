namespace Travel_Plans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_flights = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_hotels = new System.Windows.Forms.ComboBox();
            this.grp_activities = new System.Windows.Forms.GroupBox();
            this.chkcoconuts = new System.Windows.Forms.CheckBox();
            this.chkmahi = new System.Windows.Forms.CheckBox();
            this.chkcoral = new System.Windows.Forms.CheckBox();
            this.chkmarathon = new System.Windows.Forms.CheckBox();
            this.chkholiday = new System.Windows.Forms.CheckBox();
            this.chkseafish = new System.Windows.Forms.CheckBox();
            this.chkhike = new System.Windows.Forms.CheckBox();
            this.chkhorse = new System.Windows.Forms.CheckBox();
            this.chksnork = new System.Windows.Forms.CheckBox();
            this.chkscuba = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_order = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.rtxtFlights = new System.Windows.Forms.RichTextBox();
            this.rtxtHotels = new System.Windows.Forms.RichTextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnorder = new System.Windows.Forms.Button();
            this.grp_activities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patrick, Tommy and Hung (Lab 14 - Team 3)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trips:";
            // 
            // cbo_flights
            // 
            this.cbo_flights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_flights.FormattingEnabled = true;
            this.cbo_flights.Location = new System.Drawing.Point(100, 80);
            this.cbo_flights.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_flights.Name = "cbo_flights";
            this.cbo_flights.Size = new System.Drawing.Size(292, 28);
            this.cbo_flights.TabIndex = 2;
            this.cbo_flights.SelectedIndexChanged += new System.EventHandler(this.cbo_flights_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hotels:";
            // 
            // cbo_hotels
            // 
            this.cbo_hotels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_hotels.FormattingEnabled = true;
            this.cbo_hotels.Location = new System.Drawing.Point(100, 202);
            this.cbo_hotels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_hotels.Name = "cbo_hotels";
            this.cbo_hotels.Size = new System.Drawing.Size(292, 28);
            this.cbo_hotels.TabIndex = 4;
            this.cbo_hotels.SelectedIndexChanged += new System.EventHandler(this.cbo_flights_SelectedIndexChanged);
            // 
            // grp_activities
            // 
            this.grp_activities.Controls.Add(this.chkcoconuts);
            this.grp_activities.Controls.Add(this.chkmahi);
            this.grp_activities.Controls.Add(this.chkcoral);
            this.grp_activities.Controls.Add(this.chkmarathon);
            this.grp_activities.Controls.Add(this.chkholiday);
            this.grp_activities.Controls.Add(this.chkseafish);
            this.grp_activities.Controls.Add(this.chkhike);
            this.grp_activities.Controls.Add(this.chkhorse);
            this.grp_activities.Controls.Add(this.chksnork);
            this.grp_activities.Controls.Add(this.chkscuba);
            this.grp_activities.Location = new System.Drawing.Point(22, 454);
            this.grp_activities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_activities.Name = "grp_activities";
            this.grp_activities.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_activities.Size = new System.Drawing.Size(372, 386);
            this.grp_activities.TabIndex = 5;
            this.grp_activities.TabStop = false;
            this.grp_activities.Text = "Activities";
            // 
            // chkcoconuts
            // 
            this.chkcoconuts.AutoSize = true;
            this.chkcoconuts.Location = new System.Drawing.Point(9, 348);
            this.chkcoconuts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkcoconuts.Name = "chkcoconuts";
            this.chkcoconuts.Size = new System.Drawing.Size(294, 24);
            this.chkcoconuts.TabIndex = 9;
            this.chkcoconuts.Text = "Collect Coconuts on the Beach - $99";
            this.chkcoconuts.UseVisualStyleBackColor = true;
            this.chkcoconuts.CheckedChanged += new System.EventHandler(this.activities_CheckedChanged);
            // 
            // chkmahi
            // 
            this.chkmahi.AutoSize = true;
            this.chkmahi.Location = new System.Drawing.Point(9, 312);
            this.chkmahi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkmahi.Name = "chkmahi";
            this.chkmahi.Size = new System.Drawing.Size(247, 24);
            this.chkmahi.TabIndex = 8;
            this.chkmahi.Text = "Mahi\'s Seaside Seafood - $89";
            this.chkmahi.UseVisualStyleBackColor = true;
            this.chkmahi.CheckedChanged += new System.EventHandler(this.activities_CheckedChanged);
            // 
            // chkcoral
            // 
            this.chkcoral.AutoSize = true;
            this.chkcoral.Location = new System.Drawing.Point(9, 277);
            this.chkcoral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkcoral.Name = "chkcoral";
            this.chkcoral.Size = new System.Drawing.Size(301, 24);
            this.chkcoral.TabIndex = 7;
            this.chkcoral.Text = "Coral Bay Bizarre Bazaar Event  - $79";
            this.chkcoral.UseVisualStyleBackColor = true;
            this.chkcoral.CheckedChanged += new System.EventHandler(this.activities_CheckedChanged);
            // 
            // chkmarathon
            // 
            this.chkmarathon.AutoSize = true;
            this.chkmarathon.Location = new System.Drawing.Point(9, 242);
            this.chkmarathon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkmarathon.Name = "chkmarathon";
            this.chkmarathon.Size = new System.Drawing.Size(267, 24);
            this.chkmarathon.TabIndex = 6;
            this.chkmarathon.Text = "Virgin Island Half Marathon - $49";
            this.chkmarathon.UseVisualStyleBackColor = true;
            this.chkmarathon.CheckedChanged += new System.EventHandler(this.activities_CheckedChanged);
            // 
            // chkholiday
            // 
            this.chkholiday.AutoSize = true;
            this.chkholiday.Location = new System.Drawing.Point(9, 206);
            this.chkholiday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkholiday.Name = "chkholiday";
            this.chkholiday.Size = new System.Drawing.Size(187, 24);
            this.chkholiday.TabIndex = 5;
            this.chkholiday.Text = "Holiday Carnival - $50";
            this.chkholiday.UseVisualStyleBackColor = true;
            this.chkholiday.CheckedChanged += new System.EventHandler(this.activities_CheckedChanged);
            // 
            // chkseafish
            // 
            this.chkseafish.AutoSize = true;
            this.chkseafish.Location = new System.Drawing.Point(9, 171);
            this.chkseafish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkseafish.Name = "chkseafish";
            this.chkseafish.Size = new System.Drawing.Size(168, 24);
            this.chkseafish.TabIndex = 4;
            this.chkseafish.Text = "Sea Fishing - $399";
            this.chkseafish.UseVisualStyleBackColor = true;
            this.chkseafish.CheckedChanged += new System.EventHandler(this.activities_CheckedChanged);
            // 
            // chkhike
            // 
            this.chkhike.AutoSize = true;
            this.chkhike.Location = new System.Drawing.Point(9, 135);
            this.chkhike.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkhike.Name = "chkhike";
            this.chkhike.Size = new System.Drawing.Size(245, 24);
            this.chkhike.TabIndex = 3;
            this.chkhike.Text = "Hiking Tour at St. Croix - $199";
            this.chkhike.UseVisualStyleBackColor = true;
            this.chkhike.CheckedChanged += new System.EventHandler(this.activities_CheckedChanged);
            // 
            // chkhorse
            // 
            this.chkhorse.AutoSize = true;
            this.chkhorse.Location = new System.Drawing.Point(9, 100);
            this.chkhorse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkhorse.Name = "chkhorse";
            this.chkhorse.Size = new System.Drawing.Size(216, 24);
            this.chkhorse.TabIndex = 2;
            this.chkhorse.Text = "Horse Back Riding - $149";
            this.chkhorse.UseVisualStyleBackColor = true;
            this.chkhorse.CheckedChanged += new System.EventHandler(this.activities_CheckedChanged);
            // 
            // chksnork
            // 
            this.chksnork.AutoSize = true;
            this.chksnork.Location = new System.Drawing.Point(9, 65);
            this.chksnork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chksnork.Name = "chksnork";
            this.chksnork.Size = new System.Drawing.Size(141, 24);
            this.chksnork.TabIndex = 1;
            this.chksnork.Text = "Snorkling - $99";
            this.chksnork.UseVisualStyleBackColor = true;
            this.chksnork.CheckedChanged += new System.EventHandler(this.activities_CheckedChanged);
            // 
            // chkscuba
            // 
            this.chkscuba.AutoSize = true;
            this.chkscuba.Location = new System.Drawing.Point(9, 29);
            this.chkscuba.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkscuba.Name = "chkscuba";
            this.chkscuba.Size = new System.Drawing.Size(177, 24);
            this.chkscuba.TabIndex = 0;
            this.chkscuba.Text = "Scuba Diving - $169";
            this.chkscuba.UseVisualStyleBackColor = true;
            this.chkscuba.CheckedChanged += new System.EventHandler(this.activities_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1244, 1025);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txt_order
            // 
            this.txt_order.Location = new System.Drawing.Point(606, 122);
            this.txt_order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_order.Name = "txt_order";
            this.txt_order.ReadOnly = true;
            this.txt_order.Size = new System.Drawing.Size(506, 575);
            this.txt_order.TabIndex = 7;
            this.txt_order.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Activities Information:";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(22, 894);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 35);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(1000, 894);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(112, 35);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check Out";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // rtxtFlights
            // 
            this.rtxtFlights.Location = new System.Drawing.Point(100, 122);
            this.rtxtFlights.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtFlights.Name = "rtxtFlights";
            this.rtxtFlights.ReadOnly = true;
            this.rtxtFlights.Size = new System.Drawing.Size(292, 54);
            this.rtxtFlights.TabIndex = 13;
            this.rtxtFlights.Text = "";
            // 
            // rtxtHotels
            // 
            this.rtxtHotels.Location = new System.Drawing.Point(100, 240);
            this.rtxtHotels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtHotels.Name = "rtxtHotels";
            this.rtxtHotels.ReadOnly = true;
            this.rtxtHotels.Size = new System.Drawing.Size(294, 204);
            this.rtxtHotels.TabIndex = 14;
            this.rtxtHotels.Text = "";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(709, 729);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(100, 26);
            this.txt_subtotal.TabIndex = 15;
            // 
            // txt_tax
            // 
            this.txt_tax.Location = new System.Drawing.Point(709, 777);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(100, 26);
            this.txt_tax.TabIndex = 16;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(709, 824);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 26);
            this.txt_total.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 735);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Subtotal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(623, 783);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tax:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 830);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total:";
            // 
            // btnorder
            // 
            this.btnorder.Location = new System.Drawing.Point(192, 894);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(200, 40);
            this.btnorder.TabIndex = 21;
            this.btnorder.Text = "View Order Summary";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 1002);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_tax);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.rtxtHotels);
            this.Controls.Add(this.rtxtFlights);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_order);
            this.Controls.Add(this.grp_activities);
            this.Controls.Add(this.cbo_hotels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_flights);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Travel to the Virgin Islands ";
            this.grp_activities.ResumeLayout(false);
            this.grp_activities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_flights;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_hotels;
        private System.Windows.Forms.GroupBox grp_activities;
        private System.Windows.Forms.CheckBox chkcoconuts;
        private System.Windows.Forms.CheckBox chkmahi;
        private System.Windows.Forms.CheckBox chkcoral;
        private System.Windows.Forms.CheckBox chkmarathon;
        private System.Windows.Forms.CheckBox chkholiday;
        private System.Windows.Forms.CheckBox chkseafish;
        private System.Windows.Forms.CheckBox chkhike;
        private System.Windows.Forms.CheckBox chkhorse;
        private System.Windows.Forms.CheckBox chksnork;
        private System.Windows.Forms.CheckBox chkscuba;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox txt_order;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.RichTextBox rtxtFlights;
        private System.Windows.Forms.RichTextBox rtxtHotels;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnorder;
    }
}

