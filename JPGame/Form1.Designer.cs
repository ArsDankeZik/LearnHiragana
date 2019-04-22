namespace JPGame
{
    partial class JpLearn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHiragana = new System.Windows.Forms.Label();
            this.txtCheckSpell = new System.Windows.Forms.TextBox();
            this.lblBad = new System.Windows.Forms.Label();
            this.lblGood = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHiragana
            // 
            this.lblHiragana.AutoSize = true;
            this.lblHiragana.Font = new System.Drawing.Font("Segoe Print", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiragana.Location = new System.Drawing.Point(161, 164);
            this.lblHiragana.Name = "lblHiragana";
            this.lblHiragana.Size = new System.Drawing.Size(0, 168);
            this.lblHiragana.TabIndex = 0;
            this.lblHiragana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCheckSpell
            // 
            this.txtCheckSpell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheckSpell.Location = new System.Drawing.Point(212, 449);
            this.txtCheckSpell.Name = "txtCheckSpell";
            this.txtCheckSpell.Size = new System.Drawing.Size(100, 50);
            this.txtCheckSpell.TabIndex = 1;
            this.txtCheckSpell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check);
            // 
            // lblBad
            // 
            this.lblBad.AutoSize = true;
            this.lblBad.Location = new System.Drawing.Point(12, 9);
            this.lblBad.Name = "lblBad";
            this.lblBad.Size = new System.Drawing.Size(101, 42);
            this.lblBad.TabIndex = 2;
            this.lblBad.Text = "Bad: 0";
            // 
            // lblGood
            // 
            this.lblGood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGood.AutoSize = true;
            this.lblGood.Location = new System.Drawing.Point(392, 9);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(116, 42);
            this.lblGood.TabIndex = 3;
            this.lblGood.Text = "Good: 0";
            // 
            // JpLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.lblGood);
            this.Controls.Add(this.lblBad);
            this.Controls.Add(this.txtCheckSpell);
            this.Controls.Add(this.lblHiragana);
            this.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 550);
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "JpLearn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JPLearn";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.actionsOnWindow);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHiragana;
        private System.Windows.Forms.TextBox txtCheckSpell;
        private System.Windows.Forms.Label lblBad;
        private System.Windows.Forms.Label lblGood;
    }
}

