
namespace OrderingSystemUI
{
    partial class SplitBill
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
            this.comboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bttFinishPayment = new System.Windows.Forms.Button();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.txtBoxPaymentAmt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalRemainingAmt = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxAddTIP = new System.Windows.Forms.CheckBox();
            this.txtBoxTIPsplitForm = new System.Windows.Forms.TextBox();
            this.labelTotalwithTipSplit = new System.Windows.Forms.Label();
            this.labelTotalWithTIPsplitDisplay = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.Enabled = false;
            this.comboBoxPaymentType.FormattingEnabled = true;
            this.comboBoxPaymentType.Items.AddRange(new object[] {
            "Credit Card",
            "Debit Card",
            "Cash",
            "Mixed Payment"});
            this.comboBoxPaymentType.Location = new System.Drawing.Point(252, 270);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(178, 28);
            this.comboBoxPaymentType.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(44, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Select Payment Type:";
            // 
            // bttFinishPayment
            // 
            this.bttFinishPayment.BackColor = System.Drawing.Color.Teal;
            this.bttFinishPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttFinishPayment.ForeColor = System.Drawing.Color.White;
            this.bttFinishPayment.Location = new System.Drawing.Point(252, 360);
            this.bttFinishPayment.Name = "bttFinishPayment";
            this.bttFinishPayment.Size = new System.Drawing.Size(178, 45);
            this.bttFinishPayment.TabIndex = 44;
            this.bttFinishPayment.Text = "Finilize Payment";
            this.bttFinishPayment.UseVisualStyleBackColor = false;
            this.bttFinishPayment.Click += new System.EventHandler(this.bttFinishPayment_Click);
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentAmount.Location = new System.Drawing.Point(44, 172);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(188, 23);
            this.lblPaymentAmount.TabIndex = 47;
            this.lblPaymentAmount.Text = "Enter Payment Amount";
            // 
            // txtBoxPaymentAmt
            // 
            this.txtBoxPaymentAmt.Location = new System.Drawing.Point(252, 168);
            this.txtBoxPaymentAmt.Name = "txtBoxPaymentAmt";
            this.txtBoxPaymentAmt.Size = new System.Drawing.Size(178, 27);
            this.txtBoxPaymentAmt.TabIndex = 48;
            this.txtBoxPaymentAmt.TextChanged += new System.EventHandler(this.txtBoxPaymentAmt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "Bill Total Remaining";
            // 
            // lblTotalRemainingAmt
            // 
            this.lblTotalRemainingAmt.AutoSize = true;
            this.lblTotalRemainingAmt.Location = new System.Drawing.Point(252, 113);
            this.lblTotalRemainingAmt.Name = "lblTotalRemainingAmt";
            this.lblTotalRemainingAmt.Size = new System.Drawing.Size(52, 20);
            this.lblTotalRemainingAmt.TabIndex = 50;
            this.lblTotalRemainingAmt.Text = "holder";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomer.ForeColor = System.Drawing.Color.Teal;
            this.lblCustomer.Location = new System.Drawing.Point(151, 35);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(0, 25);
            this.lblCustomer.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OrderingSystemUI.Properties.Resources.chapeauLog;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(318, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 53;
            // 
            // checkBoxAddTIP
            // 
            this.checkBoxAddTIP.AutoSize = true;
            this.checkBoxAddTIP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAddTIP.Location = new System.Drawing.Point(44, 217);
            this.checkBoxAddTIP.Name = "checkBoxAddTIP";
            this.checkBoxAddTIP.Size = new System.Drawing.Size(92, 27);
            this.checkBoxAddTIP.TabIndex = 54;
            this.checkBoxAddTIP.Text = "Add TIP";
            this.checkBoxAddTIP.UseVisualStyleBackColor = true;
            this.checkBoxAddTIP.CheckedChanged += new System.EventHandler(this.checkBoxAddTIP_CheckedChanged);
            // 
            // txtBoxTIPsplitForm
            // 
            this.txtBoxTIPsplitForm.Location = new System.Drawing.Point(132, 217);
            this.txtBoxTIPsplitForm.Name = "txtBoxTIPsplitForm";
            this.txtBoxTIPsplitForm.Size = new System.Drawing.Size(100, 27);
            this.txtBoxTIPsplitForm.TabIndex = 55;
            // 
            // labelTotalwithTipSplit
            // 
            this.labelTotalwithTipSplit.AutoSize = true;
            this.labelTotalwithTipSplit.Location = new System.Drawing.Point(252, 220);
            this.labelTotalwithTipSplit.Name = "labelTotalwithTipSplit";
            this.labelTotalwithTipSplit.Size = new System.Drawing.Size(104, 20);
            this.labelTotalwithTipSplit.TabIndex = 56;
            this.labelTotalwithTipSplit.Text = "Total With TIP:";
            // 
            // labelTotalWithTIPsplitDisplay
            // 
            this.labelTotalWithTIPsplitDisplay.AutoSize = true;
            this.labelTotalWithTIPsplitDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalWithTIPsplitDisplay.Location = new System.Drawing.Point(362, 220);
            this.labelTotalWithTIPsplitDisplay.Name = "labelTotalWithTIPsplitDisplay";
            this.labelTotalWithTIPsplitDisplay.Size = new System.Drawing.Size(54, 20);
            this.labelTotalWithTIPsplitDisplay.TabIndex = 57;
            this.labelTotalWithTIPsplitDisplay.Text = "holder";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(44, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 45);
            this.button1.TabIndex = 58;
            this.button1.Text = "Add Feedback";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SplitBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTotalWithTIPsplitDisplay);
            this.Controls.Add(this.labelTotalwithTipSplit);
            this.Controls.Add(this.txtBoxTIPsplitForm);
            this.Controls.Add(this.checkBoxAddTIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblTotalRemainingAmt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPaymentAmt);
            this.Controls.Add(this.lblPaymentAmount);
            this.Controls.Add(this.bttFinishPayment);
            this.Controls.Add(this.comboBoxPaymentType);
            this.Controls.Add(this.label6);
            this.Name = "SplitBill";
            this.Text = "SplitBill";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPaymentType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttFinishPayment;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.TextBox txtBoxPaymentAmt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalRemainingAmt;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAddTIP;
        private System.Windows.Forms.TextBox txtBoxTIPsplitForm;
        private System.Windows.Forms.Label labelTotalwithTipSplit;
        private System.Windows.Forms.Label labelTotalWithTIPsplitDisplay;
        private System.Windows.Forms.Button button1;
    }
}