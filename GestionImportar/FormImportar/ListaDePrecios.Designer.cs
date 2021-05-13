namespace FormImportar
{
    partial class ListaDePrecios
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
            this.dgListaPrecios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCargar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkLista71 = new System.Windows.Forms.CheckBox();
            this.chkLista41 = new System.Windows.Forms.CheckBox();
            this.chkLista60 = new System.Windows.Forms.CheckBox();
            this.chkLista40 = new System.Windows.Forms.CheckBox();
            this.chkLista20 = new System.Windows.Forms.CheckBox();
            this.chkLista10 = new System.Windows.Forms.CheckBox();
            this.chkLista30 = new System.Windows.Forms.CheckBox();
            this.chkLista31 = new System.Windows.Forms.CheckBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkLista27 = new System.Windows.Forms.CheckBox();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lista31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lista30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lista10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lista20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lista40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lista60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lista41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lista71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lista27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaPrecios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgListaPrecios
            // 
            this.dgListaPrecios.AllowUserToAddRows = false;
            this.dgListaPrecios.AllowUserToDeleteRows = false;
            this.dgListaPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.NombreProducto,
            this.Lista31,
            this.Lista30,
            this.Lista10,
            this.Lista20,
            this.Lista40,
            this.Lista60,
            this.Lista41,
            this.Lista71,
            this.Lista27});
            this.dgListaPrecios.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgListaPrecios.Location = new System.Drawing.Point(0, 0);
            this.dgListaPrecios.Name = "dgListaPrecios";
            this.dgListaPrecios.ReadOnly = true;
            this.dgListaPrecios.Size = new System.Drawing.Size(961, 614);
            this.dgListaPrecios.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboSucursal);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 614);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 129);
            this.panel1.TabIndex = 2;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 6);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 42);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar Lista";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkLista27);
            this.panel2.Controls.Add(this.chkLista71);
            this.panel2.Controls.Add(this.chkLista41);
            this.panel2.Controls.Add(this.chkLista60);
            this.panel2.Controls.Add(this.chkLista40);
            this.panel2.Controls.Add(this.chkLista20);
            this.panel2.Controls.Add(this.chkLista10);
            this.panel2.Controls.Add(this.chkLista30);
            this.panel2.Controls.Add(this.chkLista31);
            this.panel2.Controls.Add(this.btnProcesar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 694);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 49);
            this.panel2.TabIndex = 3;
            // 
            // chkLista71
            // 
            this.chkLista71.AutoSize = true;
            this.chkLista71.Location = new System.Drawing.Point(654, 17);
            this.chkLista71.Name = "chkLista71";
            this.chkLista71.Size = new System.Drawing.Size(71, 17);
            this.chkLista71.TabIndex = 10;
            this.chkLista71.Text = "LISTA 71";
            this.chkLista71.UseVisualStyleBackColor = true;
            // 
            // chkLista41
            // 
            this.chkLista41.AutoSize = true;
            this.chkLista41.Location = new System.Drawing.Point(577, 17);
            this.chkLista41.Name = "chkLista41";
            this.chkLista41.Size = new System.Drawing.Size(71, 17);
            this.chkLista41.TabIndex = 9;
            this.chkLista41.Text = "LISTA 41";
            this.chkLista41.UseVisualStyleBackColor = true;
            // 
            // chkLista60
            // 
            this.chkLista60.AutoSize = true;
            this.chkLista60.Location = new System.Drawing.Point(500, 17);
            this.chkLista60.Name = "chkLista60";
            this.chkLista60.Size = new System.Drawing.Size(71, 17);
            this.chkLista60.TabIndex = 8;
            this.chkLista60.Text = "LISTA 60";
            this.chkLista60.UseVisualStyleBackColor = true;
            // 
            // chkLista40
            // 
            this.chkLista40.AutoSize = true;
            this.chkLista40.Location = new System.Drawing.Point(423, 17);
            this.chkLista40.Name = "chkLista40";
            this.chkLista40.Size = new System.Drawing.Size(71, 17);
            this.chkLista40.TabIndex = 7;
            this.chkLista40.Text = "LISTA 40";
            this.chkLista40.UseVisualStyleBackColor = true;
            // 
            // chkLista20
            // 
            this.chkLista20.AutoSize = true;
            this.chkLista20.Location = new System.Drawing.Point(346, 17);
            this.chkLista20.Name = "chkLista20";
            this.chkLista20.Size = new System.Drawing.Size(71, 17);
            this.chkLista20.TabIndex = 6;
            this.chkLista20.Text = "LISTA 20";
            this.chkLista20.UseVisualStyleBackColor = true;
            // 
            // chkLista10
            // 
            this.chkLista10.AutoSize = true;
            this.chkLista10.Location = new System.Drawing.Point(269, 17);
            this.chkLista10.Name = "chkLista10";
            this.chkLista10.Size = new System.Drawing.Size(71, 17);
            this.chkLista10.TabIndex = 5;
            this.chkLista10.Text = "LISTA 10";
            this.chkLista10.UseVisualStyleBackColor = true;
            // 
            // chkLista30
            // 
            this.chkLista30.AutoSize = true;
            this.chkLista30.Location = new System.Drawing.Point(192, 17);
            this.chkLista30.Name = "chkLista30";
            this.chkLista30.Size = new System.Drawing.Size(71, 17);
            this.chkLista30.TabIndex = 4;
            this.chkLista30.Text = "LISTA 30";
            this.chkLista30.UseVisualStyleBackColor = true;
            // 
            // chkLista31
            // 
            this.chkLista31.AutoSize = true;
            this.chkLista31.Location = new System.Drawing.Point(115, 17);
            this.chkLista31.Name = "chkLista31";
            this.chkLista31.Size = new System.Drawing.Size(71, 17);
            this.chkLista31.TabIndex = 3;
            this.chkLista31.Text = "LISTA 31";
            this.chkLista31.UseVisualStyleBackColor = true;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(12, 13);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Items.AddRange(new object[] {
            "TUCUMAN",
            "SALTA",
            "SANTIAGO DEL ESTERO"});
            this.cboSucursal.Location = new System.Drawing.Point(702, 18);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(213, 21);
            this.cboSucursal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SUCURSALES :";
            // 
            // chkLista27
            // 
            this.chkLista27.AutoSize = true;
            this.chkLista27.Location = new System.Drawing.Point(731, 17);
            this.chkLista27.Name = "chkLista27";
            this.chkLista27.Size = new System.Drawing.Size(71, 17);
            this.chkLista27.TabIndex = 11;
            this.chkLista27.Text = "LISTA 27";
            this.chkLista27.UseVisualStyleBackColor = true;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Lista31
            // 
            this.Lista31.HeaderText = "Lista 31";
            this.Lista31.Name = "Lista31";
            this.Lista31.ReadOnly = true;
            // 
            // Lista30
            // 
            this.Lista30.HeaderText = "Lista 30";
            this.Lista30.Name = "Lista30";
            this.Lista30.ReadOnly = true;
            // 
            // Lista10
            // 
            this.Lista10.HeaderText = "Lista 10";
            this.Lista10.Name = "Lista10";
            this.Lista10.ReadOnly = true;
            // 
            // Lista20
            // 
            this.Lista20.HeaderText = "Lista 20";
            this.Lista20.Name = "Lista20";
            this.Lista20.ReadOnly = true;
            // 
            // Lista40
            // 
            this.Lista40.HeaderText = "Lista 40";
            this.Lista40.Name = "Lista40";
            this.Lista40.ReadOnly = true;
            // 
            // Lista60
            // 
            this.Lista60.HeaderText = "Lista 60";
            this.Lista60.Name = "Lista60";
            this.Lista60.ReadOnly = true;
            // 
            // Lista41
            // 
            this.Lista41.HeaderText = "Lista 41";
            this.Lista41.Name = "Lista41";
            this.Lista41.ReadOnly = true;
            // 
            // Lista71
            // 
            this.Lista71.HeaderText = "Lista 71";
            this.Lista71.Name = "Lista71";
            this.Lista71.ReadOnly = true;
            // 
            // Lista27
            // 
            this.Lista27.HeaderText = "Lista 27";
            this.Lista27.Name = "Lista27";
            this.Lista27.ReadOnly = true;
            // 
            // ListaDePrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 743);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgListaPrecios);
            this.Name = "ListaDePrecios";
            this.Text = "Importar Listas de Precios";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaPrecios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaPrecios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.CheckBox chkLista71;
        private System.Windows.Forms.CheckBox chkLista41;
        private System.Windows.Forms.CheckBox chkLista60;
        private System.Windows.Forms.CheckBox chkLista40;
        private System.Windows.Forms.CheckBox chkLista20;
        private System.Windows.Forms.CheckBox chkLista10;
        private System.Windows.Forms.CheckBox chkLista30;
        private System.Windows.Forms.CheckBox chkLista31;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lista31;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lista30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lista10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lista20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lista40;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lista60;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lista41;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lista71;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lista27;
        private System.Windows.Forms.CheckBox chkLista27;
    }
}