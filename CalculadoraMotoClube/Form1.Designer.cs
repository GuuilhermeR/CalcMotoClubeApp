namespace CalculadoraMotoClube
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPassaporte = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtTotal = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtBau = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMecanico = new MaterialSkin.Controls.MaterialTextBox2();
            this.chkBooster = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbxParceria = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCalcular = new MaterialSkin.Controls.MaterialButton();
            this.btnApagar = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassaporte
            // 
            this.txtPassaporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassaporte.AnimateReadOnly = false;
            this.txtPassaporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassaporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassaporte.Depth = 0;
            this.txtPassaporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassaporte.HelperText = "Informe o passaporte do cliente";
            this.txtPassaporte.HideSelection = true;
            this.txtPassaporte.Hint = "Passaporte";
            this.txtPassaporte.LeadingIcon = null;
            this.txtPassaporte.Location = new System.Drawing.Point(72, 237);
            this.txtPassaporte.MaxLength = 32767;
            this.txtPassaporte.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassaporte.Name = "txtPassaporte";
            this.txtPassaporte.PasswordChar = '\0';
            this.txtPassaporte.PrefixSuffixText = null;
            this.txtPassaporte.ReadOnly = false;
            this.txtPassaporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassaporte.SelectedText = "";
            this.txtPassaporte.SelectionLength = 0;
            this.txtPassaporte.SelectionStart = 0;
            this.txtPassaporte.ShortcutsEnabled = true;
            this.txtPassaporte.Size = new System.Drawing.Size(347, 48);
            this.txtPassaporte.TabIndex = 0;
            this.txtPassaporte.TabStop = false;
            this.txtPassaporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassaporte.TrailingIcon = null;
            this.txtPassaporte.UseSystemPasswordChar = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.AnimateReadOnly = false;
            this.txtTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Depth = 0;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotal.HideSelection = true;
            this.txtTotal.Hint = "Total";
            this.txtTotal.LeadingIcon = null;
            this.txtTotal.Location = new System.Drawing.Point(72, 293);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PrefixSuffixText = null;
            this.txtTotal.ReadOnly = false;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(347, 48);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.TrailingIcon = null;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // txtBau
            // 
            this.txtBau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBau.AnimateReadOnly = false;
            this.txtBau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBau.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBau.Depth = 0;
            this.txtBau.Enabled = false;
            this.txtBau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBau.HideSelection = true;
            this.txtBau.Hint = "Baú";
            this.txtBau.LeadingIcon = null;
            this.txtBau.Location = new System.Drawing.Point(72, 349);
            this.txtBau.MaxLength = 32767;
            this.txtBau.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBau.Name = "txtBau";
            this.txtBau.PasswordChar = '\0';
            this.txtBau.PrefixSuffixText = null;
            this.txtBau.ReadOnly = false;
            this.txtBau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBau.SelectedText = "";
            this.txtBau.SelectionLength = 0;
            this.txtBau.SelectionStart = 0;
            this.txtBau.ShortcutsEnabled = true;
            this.txtBau.Size = new System.Drawing.Size(347, 48);
            this.txtBau.TabIndex = 2;
            this.txtBau.TabStop = false;
            this.txtBau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBau.TrailingIcon = null;
            this.txtBau.UseSystemPasswordChar = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCliente.AnimateReadOnly = false;
            this.txtCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCliente.Depth = 0;
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCliente.HideSelection = true;
            this.txtCliente.Hint = "Cliente";
            this.txtCliente.LeadingIcon = null;
            this.txtCliente.Location = new System.Drawing.Point(72, 405);
            this.txtCliente.MaxLength = 32767;
            this.txtCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.PrefixSuffixText = null;
            this.txtCliente.ReadOnly = false;
            this.txtCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCliente.SelectedText = "";
            this.txtCliente.SelectionLength = 0;
            this.txtCliente.SelectionStart = 0;
            this.txtCliente.ShortcutsEnabled = true;
            this.txtCliente.Size = new System.Drawing.Size(347, 48);
            this.txtCliente.TabIndex = 3;
            this.txtCliente.TabStop = false;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCliente.TrailingIcon = null;
            this.txtCliente.UseSystemPasswordChar = false;
            // 
            // txtMecanico
            // 
            this.txtMecanico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMecanico.AnimateReadOnly = false;
            this.txtMecanico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMecanico.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMecanico.Depth = 0;
            this.txtMecanico.Enabled = false;
            this.txtMecanico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMecanico.HideSelection = true;
            this.txtMecanico.Hint = "Mecânico";
            this.txtMecanico.LeadingIcon = null;
            this.txtMecanico.Location = new System.Drawing.Point(72, 461);
            this.txtMecanico.MaxLength = 32767;
            this.txtMecanico.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMecanico.Name = "txtMecanico";
            this.txtMecanico.PasswordChar = '\0';
            this.txtMecanico.PrefixSuffixText = null;
            this.txtMecanico.ReadOnly = false;
            this.txtMecanico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMecanico.SelectedText = "";
            this.txtMecanico.SelectionLength = 0;
            this.txtMecanico.SelectionStart = 0;
            this.txtMecanico.ShortcutsEnabled = true;
            this.txtMecanico.Size = new System.Drawing.Size(306, 48);
            this.txtMecanico.TabIndex = 4;
            this.txtMecanico.TabStop = false;
            this.txtMecanico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMecanico.TrailingIcon = null;
            this.txtMecanico.UseSystemPasswordChar = false;
            // 
            // chkBooster
            // 
            this.chkBooster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBooster.AutoSize = true;
            this.chkBooster.Depth = 0;
            this.chkBooster.Location = new System.Drawing.Point(381, 467);
            this.chkBooster.Margin = new System.Windows.Forms.Padding(0);
            this.chkBooster.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkBooster.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkBooster.Name = "chkBooster";
            this.chkBooster.ReadOnly = false;
            this.chkBooster.Ripple = true;
            this.chkBooster.Size = new System.Drawing.Size(89, 37);
            this.chkBooster.TabIndex = 7;
            this.chkBooster.Text = "Booster";
            this.chkBooster.UseVisualStyleBackColor = true;
            // 
            // cbxParceria
            // 
            this.cbxParceria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxParceria.AutoResize = false;
            this.cbxParceria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxParceria.Depth = 0;
            this.cbxParceria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxParceria.DropDownHeight = 174;
            this.cbxParceria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParceria.DropDownWidth = 121;
            this.cbxParceria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxParceria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxParceria.FormattingEnabled = true;
            this.cbxParceria.Hint = "Parceria";
            this.cbxParceria.IntegralHeight = false;
            this.cbxParceria.ItemHeight = 43;
            this.cbxParceria.Items.AddRange(new object[] {
            "Sem Parceria",
            "Parceiro",
            "Aliança"});
            this.cbxParceria.Location = new System.Drawing.Point(72, 517);
            this.cbxParceria.MaxDropDownItems = 4;
            this.cbxParceria.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxParceria.Name = "cbxParceria";
            this.cbxParceria.Size = new System.Drawing.Size(347, 49);
            this.cbxParceria.StartIndex = 0;
            this.cbxParceria.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalcular.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCalcular.Depth = 0;
            this.btnCalcular.HighEmphasis = true;
            this.btnCalcular.Icon = null;
            this.btnCalcular.Location = new System.Drawing.Point(303, 585);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCalcular.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCalcular.Size = new System.Drawing.Size(95, 36);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCalcular.UseAccentColor = false;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApagar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApagar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnApagar.Depth = 0;
            this.btnApagar.HighEmphasis = true;
            this.btnApagar.Icon = null;
            this.btnApagar.Location = new System.Drawing.Point(406, 585);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnApagar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnApagar.Size = new System.Drawing.Size(79, 36);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnApagar.UseAccentColor = false;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CalculadoraMotoClube.Properties.Resources.Argentina;
            this.pictureBox1.Location = new System.Drawing.Point(47, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 200);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 630);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbxParceria);
            this.Controls.Add(this.chkBooster);
            this.Controls.Add(this.txtMecanico);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtBau);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPassaporte);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtPassaporte;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotal;
        private MaterialSkin.Controls.MaterialTextBox2 txtBau;
        private MaterialSkin.Controls.MaterialTextBox2 txtCliente;
        private MaterialSkin.Controls.MaterialTextBox2 txtMecanico;
        private MaterialSkin.Controls.MaterialCheckbox chkBooster;
        private MaterialSkin.Controls.MaterialComboBox cbxParceria;
        private MaterialSkin.Controls.MaterialButton btnCalcular;
        private MaterialSkin.Controls.MaterialButton btnApagar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

