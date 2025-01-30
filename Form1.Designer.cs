namespace XO
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button11 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.buttonRozpocznij = new System.Windows.Forms.Button();
            this.comboBoxKtoGra = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(692, 26);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(164, 123);
            this.button11.TabIndex = 0;
            this.button11.Text = "button1";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(692, 155);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(164, 123);
            this.button21.TabIndex = 1;
            this.button21.Text = "button2";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(692, 284);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(164, 123);
            this.button31.TabIndex = 2;
            this.button31.Text = "button3";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(862, 26);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(164, 123);
            this.button12.TabIndex = 5;
            this.button12.Text = "button4";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(862, 155);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(164, 123);
            this.button22.TabIndex = 4;
            this.button22.Text = "button5";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(862, 284);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(164, 123);
            this.button32.TabIndex = 3;
            this.button32.Text = "button6";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(1032, 26);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(164, 123);
            this.button13.TabIndex = 8;
            this.button13.Text = "button7";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(1032, 155);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(164, 123);
            this.button23.TabIndex = 7;
            this.button23.Text = "button8";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(1032, 284);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(164, 123);
            this.button33.TabIndex = 6;
            this.button33.Text = "button9";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // buttonRozpocznij
            // 
            this.buttonRozpocznij.Location = new System.Drawing.Point(168, 24);
            this.buttonRozpocznij.Name = "buttonRozpocznij";
            this.buttonRozpocznij.Size = new System.Drawing.Size(166, 48);
            this.buttonRozpocznij.TabIndex = 11;
            this.buttonRozpocznij.Text = "Rozpocznij";
            this.buttonRozpocznij.UseVisualStyleBackColor = true;
            this.buttonRozpocznij.Click += new System.EventHandler(this.buttonRozpocznij_Click);
            // 
            // comboBoxKtoGra
            // 
            this.comboBoxKtoGra.FormattingEnabled = true;
            this.comboBoxKtoGra.Items.AddRange(new object[] {
            "Graj z komputerem",
            "Graj z kolegą"});
            this.comboBoxKtoGra.Location = new System.Drawing.Point(41, 37);
            this.comboBoxKtoGra.Name = "comboBoxKtoGra";
            this.comboBoxKtoGra.Size = new System.Drawing.Size(121, 24);
            this.comboBoxKtoGra.TabIndex = 12;
            this.comboBoxKtoGra.SelectedIndexChanged += new System.EventHandler(this.comboBoxKtoGra_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 625);
            this.Controls.Add(this.comboBoxKtoGra);
            this.Controls.Add(this.buttonRozpocznij);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button buttonRozpocznij;
        private System.Windows.Forms.ComboBox comboBoxKtoGra;
    }
}

