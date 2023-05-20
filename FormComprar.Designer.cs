namespace ProyectoBDD
{
    partial class FormComprar
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
            this.components = new System.ComponentModel.Container();
            this.btnActualizarv = new System.Windows.Forms.Button();
            this.btnMostrarInventario = new System.Windows.Forms.Button();
            this.btnrealizarcompra = new System.Windows.Forms.Button();
            this.btnimprimirfacturav = new System.Windows.Forms.Button();
            this.dgvcompras = new System.Windows.Forms.DataGridView();
            this.idcomprasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet6 = new ProyectoBDD.ProyectoDataSet6();
            this.txtnitc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcorreoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdirecciónc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcodigoclientec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcantidadc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboboxcompras = new System.Windows.Forms.ComboBox();
            this.txtidproductoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttelefonoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxportal = new System.Windows.Forms.ComboBox();
            this.comprasTableAdapter = new ProyectoBDD.ProyectoDataSet6TableAdapters.ComprasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarv
            // 
            this.btnActualizarv.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarv.Location = new System.Drawing.Point(699, 497);
            this.btnActualizarv.Name = "btnActualizarv";
            this.btnActualizarv.Size = new System.Drawing.Size(242, 51);
            this.btnActualizarv.TabIndex = 50;
            this.btnActualizarv.Text = "Actualizar cuadro";
            this.btnActualizarv.UseVisualStyleBackColor = true;
            this.btnActualizarv.Click += new System.EventHandler(this.btnActualizarv_Click);
            // 
            // btnMostrarInventario
            // 
            this.btnMostrarInventario.BackColor = System.Drawing.Color.Lime;
            this.btnMostrarInventario.BackgroundImage = global::ProyectoBDD.Properties.Resources.kisspng_regresar_superintendencia_de_sociedades_informatio_web_5adf1550c0b367_4216011515245694247893;
            this.btnMostrarInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMostrarInventario.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarInventario.ForeColor = System.Drawing.Color.Black;
            this.btnMostrarInventario.Location = new System.Drawing.Point(1087, 516);
            this.btnMostrarInventario.Name = "btnMostrarInventario";
            this.btnMostrarInventario.Size = new System.Drawing.Size(96, 32);
            this.btnMostrarInventario.TabIndex = 49;
            this.btnMostrarInventario.Text = "Regresar";
            this.btnMostrarInventario.UseVisualStyleBackColor = false;
            this.btnMostrarInventario.Click += new System.EventHandler(this.btnMostrarInventario_Click);
            // 
            // btnrealizarcompra
            // 
            this.btnrealizarcompra.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrealizarcompra.Location = new System.Drawing.Point(435, 497);
            this.btnrealizarcompra.Name = "btnrealizarcompra";
            this.btnrealizarcompra.Size = new System.Drawing.Size(242, 51);
            this.btnrealizarcompra.TabIndex = 48;
            this.btnrealizarcompra.Text = "Realizar compra";
            this.btnrealizarcompra.UseVisualStyleBackColor = true;
            this.btnrealizarcompra.Click += new System.EventHandler(this.btnrealizarcompra_Click);
            // 
            // btnimprimirfacturav
            // 
            this.btnimprimirfacturav.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimirfacturav.Location = new System.Drawing.Point(168, 497);
            this.btnimprimirfacturav.Name = "btnimprimirfacturav";
            this.btnimprimirfacturav.Size = new System.Drawing.Size(233, 51);
            this.btnimprimirfacturav.TabIndex = 47;
            this.btnimprimirfacturav.Text = "Guardar factura";
            this.btnimprimirfacturav.UseVisualStyleBackColor = true;
            this.btnimprimirfacturav.Click += new System.EventHandler(this.btnimprimirfacturav_Click);
            // 
            // dgvcompras
            // 
            this.dgvcompras.AutoGenerateColumns = false;
            this.dgvcompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcomprasDataGridViewTextBoxColumn,
            this.idproductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.nITDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.portalDataGridViewTextBoxColumn});
            this.dgvcompras.DataSource = this.comprasBindingSource;
            this.dgvcompras.Location = new System.Drawing.Point(12, 194);
            this.dgvcompras.Name = "dgvcompras";
            this.dgvcompras.Size = new System.Drawing.Size(1168, 245);
            this.dgvcompras.TabIndex = 46;
            // 
            // idcomprasDataGridViewTextBoxColumn
            // 
            this.idcomprasDataGridViewTextBoxColumn.DataPropertyName = "id_compras";
            this.idcomprasDataGridViewTextBoxColumn.HeaderText = "id_compras";
            this.idcomprasDataGridViewTextBoxColumn.Name = "idcomprasDataGridViewTextBoxColumn";
            this.idcomprasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // nITDataGridViewTextBoxColumn
            // 
            this.nITDataGridViewTextBoxColumn.DataPropertyName = "NIT";
            this.nITDataGridViewTextBoxColumn.HeaderText = "NIT";
            this.nITDataGridViewTextBoxColumn.Name = "nITDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.Width = 200;
            // 
            // portalDataGridViewTextBoxColumn
            // 
            this.portalDataGridViewTextBoxColumn.DataPropertyName = "portal";
            this.portalDataGridViewTextBoxColumn.HeaderText = "portal";
            this.portalDataGridViewTextBoxColumn.Name = "portalDataGridViewTextBoxColumn";
            this.portalDataGridViewTextBoxColumn.Width = 80;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            this.comprasBindingSource.DataSource = this.proyectoDataSet6;
            // 
            // proyectoDataSet6
            // 
            this.proyectoDataSet6.DataSetName = "ProyectoDataSet6";
            this.proyectoDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtnitc
            // 
            this.txtnitc.Location = new System.Drawing.Point(780, 93);
            this.txtnitc.Name = "txtnitc";
            this.txtnitc.Size = new System.Drawing.Size(129, 23);
            this.txtnitc.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(777, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "NIT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Correo";
            // 
            // txtcorreoc
            // 
            this.txtcorreoc.Location = new System.Drawing.Point(362, 93);
            this.txtcorreoc.Name = "txtcorreoc";
            this.txtcorreoc.Size = new System.Drawing.Size(396, 23);
            this.txtcorreoc.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Dirección";
            // 
            // txtdirecciónc
            // 
            this.txtdirecciónc.Location = new System.Drawing.Point(7, 93);
            this.txtdirecciónc.Name = "txtdirecciónc";
            this.txtdirecciónc.Size = new System.Drawing.Size(328, 23);
            this.txtdirecciónc.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Código cliente";
            // 
            // txtcodigoclientec
            // 
            this.txtcodigoclientec.Location = new System.Drawing.Point(542, 41);
            this.txtcodigoclientec.Name = "txtcodigoclientec";
            this.txtcodigoclientec.Size = new System.Drawing.Size(135, 23);
            this.txtcodigoclientec.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Cantidad";
            // 
            // txtcantidadc
            // 
            this.txtcantidadc.Location = new System.Drawing.Point(372, 41);
            this.txtcantidadc.Name = "txtcantidadc";
            this.txtcantidadc.Size = new System.Drawing.Size(135, 23);
            this.txtcantidadc.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre";
            // 
            // comboboxcompras
            // 
            this.comboboxcompras.FormattingEnabled = true;
            this.comboboxcompras.Items.AddRange(new object[] {
            "Lapiceros",
            "Sacampuntas",
            "Borradores",
            "Mochilas",
            "Lapices",
            "Papel "});
            this.comboboxcompras.Location = new System.Drawing.Point(133, 40);
            this.comboboxcompras.Name = "comboboxcompras";
            this.comboboxcompras.Size = new System.Drawing.Size(202, 24);
            this.comboboxcompras.TabIndex = 34;
            // 
            // txtidproductoc
            // 
            this.txtidproductoc.Location = new System.Drawing.Point(7, 40);
            this.txtidproductoc.Name = "txtidproductoc";
            this.txtidproductoc.Size = new System.Drawing.Size(100, 23);
            this.txtidproductoc.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Id Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoBDD.Properties.Resources._1__13_;
            this.pictureBox1.Location = new System.Drawing.Point(1028, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(979, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 57);
            this.label3.TabIndex = 30;
            this.label3.Text = "Compras";
            // 
            // txttelefonoc
            // 
            this.txttelefonoc.Location = new System.Drawing.Point(10, 143);
            this.txttelefonoc.Name = "txttelefonoc";
            this.txttelefonoc.Size = new System.Drawing.Size(129, 23);
            this.txttelefonoc.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 51;
            this.label9.Text = "Teléfono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "Portal";
            // 
            // comboBoxportal
            // 
            this.comboBoxportal.FormattingEnabled = true;
            this.comboBoxportal.Items.AddRange(new object[] {
            "Físico",
            "Digital"});
            this.comboBoxportal.Location = new System.Drawing.Point(168, 143);
            this.comboBoxportal.Name = "comboBoxportal";
            this.comboBoxportal.Size = new System.Drawing.Size(147, 24);
            this.comboBoxportal.TabIndex = 54;
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // FormComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.comboBoxportal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txttelefonoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnActualizarv);
            this.Controls.Add(this.btnMostrarInventario);
            this.Controls.Add(this.btnrealizarcompra);
            this.Controls.Add(this.btnimprimirfacturav);
            this.Controls.Add(this.dgvcompras);
            this.Controls.Add(this.txtnitc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcorreoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdirecciónc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcodigoclientec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcantidadc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboboxcompras);
            this.Controls.Add(this.txtidproductoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "FormComprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormComprar";
            this.Load += new System.EventHandler(this.FormComprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarv;
        private System.Windows.Forms.Button btnMostrarInventario;
        private System.Windows.Forms.Button btnrealizarcompra;
        private System.Windows.Forms.Button btnimprimirfacturav;
        private System.Windows.Forms.DataGridView dgvcompras;
        private System.Windows.Forms.TextBox txtnitc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcorreoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdirecciónc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcodigoclientec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcantidadc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboboxcompras;
        private System.Windows.Forms.TextBox txtidproductoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttelefonoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxportal;
        private ProyectoDataSet6 proyectoDataSet6;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private ProyectoDataSet6TableAdapters.ComprasTableAdapter comprasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomprasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portalDataGridViewTextBoxColumn;
    }
}