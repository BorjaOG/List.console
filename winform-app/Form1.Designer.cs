namespace winform_app
{
    partial class frmPokemon
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
            this.dgvPokemons = new System.Windows.Forms.DataGridView();
            this.pcbpokemon = new System.Windows.Forms.PictureBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminarfisico = new System.Windows.Forms.Button();
            this.btneliminarlogico = new System.Windows.Forms.Button();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblcampo = new System.Windows.Forms.Label();
            this.cbcriterio = new System.Windows.Forms.ComboBox();
            this.lblcritecrio = new System.Windows.Forms.Label();
            this.lblfiltr = new System.Windows.Forms.Label();
            this.cbcampo = new System.Windows.Forms.ComboBox();
            this.txbfiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbpokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemons
            // 
            this.dgvPokemons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokemons.Location = new System.Drawing.Point(23, 48);
            this.dgvPokemons.MultiSelect = false;
            this.dgvPokemons.Name = "dgvPokemons";
            this.dgvPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemons.Size = new System.Drawing.Size(564, 282);
            this.dgvPokemons.TabIndex = 0;
            this.dgvPokemons.SelectionChanged += new System.EventHandler(this.dgvPokemons_SelectionChanged);
            // 
            // pcbpokemon
            // 
            this.pcbpokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbpokemon.BackColor = System.Drawing.Color.Gainsboro;
            this.pcbpokemon.Location = new System.Drawing.Point(602, 48);
            this.pcbpokemon.Name = "pcbpokemon";
            this.pcbpokemon.Size = new System.Drawing.Size(330, 282);
            this.pcbpokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbpokemon.TabIndex = 1;
            this.pcbpokemon.TabStop = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnagregar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.Location = new System.Drawing.Point(23, 345);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(114, 23);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Add";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnmodificar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmodificar.Location = new System.Drawing.Point(143, 345);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(126, 23);
            this.btnmodificar.TabIndex = 16;
            this.btnmodificar.Text = "Modify";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminarfisico
            // 
            this.btneliminarfisico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btneliminarfisico.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btneliminarfisico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminarfisico.Location = new System.Drawing.Point(284, 345);
            this.btneliminarfisico.Name = "btneliminarfisico";
            this.btneliminarfisico.Size = new System.Drawing.Size(145, 23);
            this.btneliminarfisico.TabIndex = 17;
            this.btneliminarfisico.Text = "Delete F.";
            this.btneliminarfisico.UseVisualStyleBackColor = false;
            this.btneliminarfisico.Click += new System.EventHandler(this.btneliminarfisico_Click);
            // 
            // btneliminarlogico
            // 
            this.btneliminarlogico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btneliminarlogico.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btneliminarlogico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminarlogico.Location = new System.Drawing.Point(439, 345);
            this.btneliminarlogico.Name = "btneliminarlogico";
            this.btneliminarlogico.Size = new System.Drawing.Size(148, 23);
            this.btneliminarlogico.TabIndex = 18;
            this.btneliminarlogico.Text = "Delete L.";
            this.btneliminarlogico.UseVisualStyleBackColor = false;
            this.btneliminarlogico.Click += new System.EventHandler(this.btneliminarlogico_Click);
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfiltro.Location = new System.Drawing.Point(24, 24);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(84, 15);
            this.lblfiltro.TabIndex = 19;
            this.lblfiltro.Text = "Quick filtering:";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(110, 24);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(292, 20);
            this.txtfiltro.TabIndex = 20;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnbuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnbuscar.Location = new System.Drawing.Point(588, 399);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(150, 23);
            this.btnbuscar.TabIndex = 21;
            this.btnbuscar.Text = "Search";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblcampo
            // 
            this.lblcampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblcampo.AutoSize = true;
            this.lblcampo.Location = new System.Drawing.Point(24, 409);
            this.lblcampo.Name = "lblcampo";
            this.lblcampo.Size = new System.Drawing.Size(42, 13);
            this.lblcampo.TabIndex = 22;
            this.lblcampo.Text = "Column";
            // 
            // cbcriterio
            // 
            this.cbcriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbcriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcriterio.FormattingEnabled = true;
            this.cbcriterio.Location = new System.Drawing.Point(263, 401);
            this.cbcriterio.Name = "cbcriterio";
            this.cbcriterio.Size = new System.Drawing.Size(121, 21);
            this.cbcriterio.TabIndex = 23;
            // 
            // lblcritecrio
            // 
            this.lblcritecrio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblcritecrio.AutoSize = true;
            this.lblcritecrio.Location = new System.Drawing.Point(212, 409);
            this.lblcritecrio.Name = "lblcritecrio";
            this.lblcritecrio.Size = new System.Drawing.Size(41, 13);
            this.lblcritecrio.TabIndex = 24;
            this.lblcritecrio.Text = "Criterial";
            // 
            // lblfiltr
            // 
            this.lblfiltr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblfiltr.AutoSize = true;
            this.lblfiltr.Location = new System.Drawing.Point(400, 409);
            this.lblfiltr.Name = "lblfiltr";
            this.lblfiltr.Size = new System.Drawing.Size(29, 13);
            this.lblfiltr.TabIndex = 26;
            this.lblfiltr.Text = "Filter";
            // 
            // cbcampo
            // 
            this.cbcampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbcampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcampo.FormattingEnabled = true;
            this.cbcampo.Location = new System.Drawing.Point(75, 401);
            this.cbcampo.Name = "cbcampo";
            this.cbcampo.Size = new System.Drawing.Size(121, 21);
            this.cbcampo.TabIndex = 27;
            this.cbcampo.SelectedIndexChanged += new System.EventHandler(this.cbcampo_SelectedIndexChanged);
            // 
            // txbfiltro
            // 
            this.txbfiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbfiltro.Location = new System.Drawing.Point(451, 401);
            this.txbfiltro.Name = "txbfiltro";
            this.txbfiltro.Size = new System.Drawing.Size(123, 20);
            this.txbfiltro.TabIndex = 28;
            // 
            // frmPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(957, 448);
            this.Controls.Add(this.txbfiltro);
            this.Controls.Add(this.cbcampo);
            this.Controls.Add(this.lblfiltr);
            this.Controls.Add(this.lblcritecrio);
            this.Controls.Add(this.cbcriterio);
            this.Controls.Add(this.lblcampo);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.lblfiltro);
            this.Controls.Add(this.btneliminarlogico);
            this.Controls.Add(this.btneliminarfisico);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.pcbpokemon);
            this.Controls.Add(this.dgvPokemons);
            this.Name = "frmPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemons";
            this.Load += new System.EventHandler(this.frmPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbpokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemons;
        private System.Windows.Forms.PictureBox pcbpokemon;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminarfisico;
        private System.Windows.Forms.Button btneliminarlogico;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblcampo;
        private System.Windows.Forms.ComboBox cbcriterio;
        private System.Windows.Forms.Label lblcritecrio;
        private System.Windows.Forms.Label lblfiltr;
        private System.Windows.Forms.ComboBox cbcampo;
        private System.Windows.Forms.TextBox txbfiltro;
    }
}

