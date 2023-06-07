namespace AutoComp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbToltal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbAbs = new System.Windows.Forms.CheckBox();
            this.chbCondition = new System.Windows.Forms.CheckBox();
            this.chbElectro = new System.Windows.Forms.CheckBox();
            this.tbPriceAbs = new System.Windows.Forms.TextBox();
            this.tbPriceCondition = new System.Windows.Forms.TextBox();
            this.tbPriceElectro = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mercedes Benz";
            // 
            // lbToltal
            // 
            this.lbToltal.Location = new System.Drawing.Point(57, 109);
            this.lbToltal.Name = "lbToltal";
            this.lbToltal.Size = new System.Drawing.Size(486, 60);
            this.lbToltal.TabIndex = 1;
            this.lbToltal.Text = "Базовая комплектация:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPriceElectro);
            this.groupBox1.Controls.Add(this.tbPriceCondition);
            this.groupBox1.Controls.Add(this.tbPriceAbs);
            this.groupBox1.Controls.Add(this.chbElectro);
            this.groupBox1.Controls.Add(this.chbCondition);
            this.groupBox1.Controls.Add(this.chbAbs);
            this.groupBox1.Location = new System.Drawing.Point(57, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите комплектацию";
            // 
            // chbAbs
            // 
            this.chbAbs.AutoSize = true;
            this.chbAbs.Location = new System.Drawing.Point(19, 31);
            this.chbAbs.Name = "chbAbs";
            this.chbAbs.Size = new System.Drawing.Size(62, 29);
            this.chbAbs.TabIndex = 0;
            this.chbAbs.Text = "Abs";
            this.chbAbs.UseVisualStyleBackColor = true;
            // 
            // chbCondition
            // 
            this.chbCondition.AutoSize = true;
            this.chbCondition.Location = new System.Drawing.Point(19, 66);
            this.chbCondition.Name = "chbCondition";
            this.chbCondition.Size = new System.Drawing.Size(150, 29);
            this.chbCondition.TabIndex = 1;
            this.chbCondition.Text = "Кондиционер";
            this.chbCondition.UseVisualStyleBackColor = true;
            // 
            // chbElectro
            // 
            this.chbElectro.AutoSize = true;
            this.chbElectro.Location = new System.Drawing.Point(19, 108);
            this.chbElectro.Name = "chbElectro";
            this.chbElectro.Size = new System.Drawing.Size(246, 29);
            this.chbElectro.TabIndex = 2;
            this.chbElectro.Text = "Элетростеклоподьемник";
            this.chbElectro.UseVisualStyleBackColor = true;
            // 
            // tbPriceAbs
            // 
            this.tbPriceAbs.Location = new System.Drawing.Point(271, 31);
            this.tbPriceAbs.Name = "tbPriceAbs";
            this.tbPriceAbs.Size = new System.Drawing.Size(188, 32);
            this.tbPriceAbs.TabIndex = 3;
            // 
            // tbPriceCondition
            // 
            this.tbPriceCondition.Location = new System.Drawing.Point(271, 69);
            this.tbPriceCondition.Name = "tbPriceCondition";
            this.tbPriceCondition.Size = new System.Drawing.Size(188, 32);
            this.tbPriceCondition.TabIndex = 4;
            // 
            // tbPriceElectro
            // 
            this.tbPriceElectro.Location = new System.Drawing.Point(271, 108);
            this.tbPriceElectro.Name = "tbPriceElectro";
            this.tbPriceElectro.Size = new System.Drawing.Size(188, 32);
            this.tbPriceElectro.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbToltal);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Комплектации";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbToltal;
        private GroupBox groupBox1;
        private TextBox tbPriceElectro;
        private TextBox tbPriceCondition;
        private TextBox tbPriceAbs;
        private CheckBox chbElectro;
        private CheckBox chbCondition;
        private CheckBox chbAbs;
    }
}