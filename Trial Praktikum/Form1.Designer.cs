
namespace Trial_Praktikum
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
            this.labelData = new System.Windows.Forms.Label();
            this.labelKoleksi = new System.Windows.Forms.Label();
            this.txtBoxData = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelSetting = new System.Windows.Forms.Label();
            this.radioBtnRed = new System.Windows.Forms.RadioButton();
            this.labelOutputTittle = new System.Windows.Forms.Label();
            this.radioBtnBlue = new System.Windows.Forms.RadioButton();
            this.ckBoxAktif = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.listBoxCollection = new System.Windows.Forms.ListBox();
            this.labelOutputResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(79, 56);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(48, 20);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data:";
            // 
            // labelKoleksi
            // 
            this.labelKoleksi.AutoSize = true;
            this.labelKoleksi.Location = new System.Drawing.Point(79, 95);
            this.labelKoleksi.Name = "labelKoleksi";
            this.labelKoleksi.Size = new System.Drawing.Size(63, 20);
            this.labelKoleksi.TabIndex = 1;
            this.labelKoleksi.Text = "Koleksi:";
            // 
            // txtBoxData
            // 
            this.txtBoxData.Location = new System.Drawing.Point(133, 57);
            this.txtBoxData.Name = "txtBoxData";
            this.txtBoxData.Size = new System.Drawing.Size(313, 26);
            this.txtBoxData.TabIndex = 2;
            this.txtBoxData.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(468, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(373, 104);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(64, 20);
            this.labelSetting.TabIndex = 4;
            this.labelSetting.Text = "Setting:";
            // 
            // radioBtnRed
            // 
            this.radioBtnRed.AutoSize = true;
            this.radioBtnRed.Location = new System.Drawing.Point(400, 154);
            this.radioBtnRed.Name = "radioBtnRed";
            this.radioBtnRed.Size = new System.Drawing.Size(130, 24);
            this.radioBtnRed.TabIndex = 5;
            this.radioBtnRed.TabStop = true;
            this.radioBtnRed.Text = "Warna Merah";
            this.radioBtnRed.UseVisualStyleBackColor = true;
            this.radioBtnRed.CheckedChanged += new System.EventHandler(this.radioBtnRed_CheckedChanged);
            // 
            // labelOutputTittle
            // 
            this.labelOutputTittle.AutoSize = true;
            this.labelOutputTittle.Location = new System.Drawing.Point(396, 217);
            this.labelOutputTittle.Name = "labelOutputTittle";
            this.labelOutputTittle.Size = new System.Drawing.Size(62, 20);
            this.labelOutputTittle.TabIndex = 6;
            this.labelOutputTittle.Text = "Output:";
            // 
            // radioBtnBlue
            // 
            this.radioBtnBlue.AutoSize = true;
            this.radioBtnBlue.Location = new System.Drawing.Point(400, 184);
            this.radioBtnBlue.Name = "radioBtnBlue";
            this.radioBtnBlue.Size = new System.Drawing.Size(113, 24);
            this.radioBtnBlue.TabIndex = 7;
            this.radioBtnBlue.TabStop = true;
            this.radioBtnBlue.Text = "Warna Biru";
            this.radioBtnBlue.UseVisualStyleBackColor = true;
            this.radioBtnBlue.CheckedChanged += new System.EventHandler(this.radioBtnBlue_CheckedChanged);
            // 
            // ckBoxAktif
            // 
            this.ckBoxAktif.AutoSize = true;
            this.ckBoxAktif.Location = new System.Drawing.Point(443, 104);
            this.ckBoxAktif.Name = "ckBoxAktif";
            this.ckBoxAktif.Size = new System.Drawing.Size(67, 24);
            this.ckBoxAktif.TabIndex = 8;
            this.ckBoxAktif.Text = "Aktif";
            this.ckBoxAktif.UseVisualStyleBackColor = true;
            this.ckBoxAktif.CheckedChanged += new System.EventHandler(this.ckBoxAktif_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(400, 368);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(271, 29);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // listBoxCollection
            // 
            this.listBoxCollection.FormattingEnabled = true;
            this.listBoxCollection.ItemHeight = 20;
            this.listBoxCollection.Location = new System.Drawing.Point(83, 132);
            this.listBoxCollection.Name = "listBoxCollection";
            this.listBoxCollection.Size = new System.Drawing.Size(283, 284);
            this.listBoxCollection.TabIndex = 10;
            this.listBoxCollection.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // labelOutputResult
            // 
            this.labelOutputResult.AutoSize = true;
            this.labelOutputResult.Location = new System.Drawing.Point(461, 269);
            this.labelOutputResult.Name = "labelOutputResult";
            this.labelOutputResult.Size = new System.Drawing.Size(25, 20);
            this.labelOutputResult.TabIndex = 11;
            this.labelOutputResult.Text = "....";
            this.labelOutputResult.Click += new System.EventHandler(this.labelOutputResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.labelOutputResult);
            this.Controls.Add(this.listBoxCollection);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.ckBoxAktif);
            this.Controls.Add(this.radioBtnBlue);
            this.Controls.Add(this.labelOutputTittle);
            this.Controls.Add(this.radioBtnRed);
            this.Controls.Add(this.labelSetting);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxData);
            this.Controls.Add(this.labelKoleksi);
            this.Controls.Add(this.labelData);
            this.Name = "Form1";
            this.Text = "Form Materi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelKoleksi;
        private System.Windows.Forms.TextBox txtBoxData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.RadioButton radioBtnRed;
        private System.Windows.Forms.Label labelOutputTittle;
        private System.Windows.Forms.RadioButton radioBtnBlue;
        private System.Windows.Forms.CheckBox ckBoxAktif;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listBoxCollection;
        private System.Windows.Forms.Label labelOutputResult;
    }
}

