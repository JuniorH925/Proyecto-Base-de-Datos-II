namespace ProyectoBDD
{
    partial class FormVender
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proyectoDataSet4 = new ProyectoBDD.ProyectoDataSet4();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new ProyectoBDD.ProyectoDataSet4TableAdapters.productosTableAdapter();
            this.txtidproductov = new System.Windows.Forms.TextBox();
            this.comboboxventas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidadv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigoclientev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdirecciónv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcorreov = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnitv = new System.Windows.Forms.TextBox();
            this.dgvventas = new System.Windows.Forms.DataGridView();
            this.idventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet5 = new ProyectoBDD.ProyectoDataSet5();
            this.ventasTableAdapter = new ProyectoBDD.ProyectoDataSet5TableAdapters.VentasTableAdapter();
            this.btnimprimirfacturav = new System.Windows.Forms.Button();
            this.btnguardarfacturav = new System.Windows.Forms.Button();
            this.btnMostrarInventario = new System.Windows.Forms.Button();
            this.btnActualizarv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1012, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 57);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ventas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoBDD.Properties.Resources._1__13_;
            this.pictureBox1.Location = new System.Drawing.Point(1033, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id Producto";
            // 
            // proyectoDataSet4
            // 
            this.proyectoDataSet4.DataSetName = "ProyectoDataSet4";
            this.proyectoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.proyectoDataSet4;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // txtidproductov
            // 
            this.txtidproductov.Location = new System.Drawing.Point(12, 34);
            this.txtidproductov.Name = "txtidproductov";
            this.txtidproductov.Size = new System.Drawing.Size(100, 23);
            this.txtidproductov.TabIndex = 12;
            // 
            // comboboxventas
            // 
            this.comboboxventas.FormattingEnabled = true;
            this.comboboxventas.Items.AddRange(new object[] {
            "Lapiceros",
            "Sacampuntas",
            "Borradores",
            "Mochilas",
            "Lapices",
            "Papel "});
            this.comboboxventas.Location = new System.Drawing.Point(138, 34);
            this.comboboxventas.Name = "comboboxventas";
            this.comboboxventas.Size = new System.Drawing.Size(202, 24);
            this.comboboxventas.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // txtcantidadv
            // 
            this.txtcantidadv.Location = new System.Drawing.Point(377, 35);
            this.txtcantidadv.Name = "txtcantidadv";
            this.txtcantidadv.Size = new System.Drawing.Size(135, 23);
            this.txtcantidadv.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cantidad";
            // 
            // txtcodigoclientev
            // 
            this.txtcodigoclientev.Location = new System.Drawing.Point(547, 35);
            this.txtcodigoclientev.Name = "txtcodigoclientev";
            this.txtcodigoclientev.Size = new System.Drawing.Size(135, 23);
            this.txtcodigoclientev.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Código cliente";
            // 
            // txtdirecciónv
            // 
            this.txtdirecciónv.Location = new System.Drawing.Point(12, 110);
            this.txtdirecciónv.Name = "txtdirecciónv";
            this.txtdirecciónv.Size = new System.Drawing.Size(328, 23);
            this.txtdirecciónv.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Dirección";
            // 
            // txtcorreov
            // 
            this.txtcorreov.Location = new System.Drawing.Point(367, 110);
            this.txtcorreov.Name = "txtcorreov";
            this.txtcorreov.Size = new System.Drawing.Size(396, 23);
            this.txtcorreov.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Correo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(782, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "NIT";
            // 
            // txtnitv
            // 
            this.txtnitv.Location = new System.Drawing.Point(785, 110);
            this.txtnitv.Name = "txtnitv";
            this.txtnitv.Size = new System.Drawing.Size(129, 23);
            this.txtnitv.TabIndex = 24;
            // 
            // dgvventas
            // 
            this.dgvventas.AutoGenerateColumns = false;
            this.dgvventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idventaDataGridViewTextBoxColumn,
            this.idproductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.codigoclienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.nitDataGridViewTextBoxColumn});
            this.dgvventas.DataSource = this.ventasBindingSource;
            this.dgvventas.Location = new System.Drawing.Point(25, 187);
            this.dgvventas.Name = "dgvventas";
            this.dgvventas.Size = new System.Drawing.Size(1141, 245);
            this.dgvventas.TabIndex = 25;
            // 
            // idventaDataGridViewTextBoxColumn
            // 
            this.idventaDataGridViewTextBoxColumn.DataPropertyName = "id_venta";
            this.idventaDataGridViewTextBoxColumn.HeaderText = "id_venta";
            this.idventaDataGridViewTextBoxColumn.Name = "idventaDataGridViewTextBoxColumn";
            this.idventaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // codigoclienteDataGridViewTextBoxColumn
            // 
            this.codigoclienteDataGridViewTextBoxColumn.DataPropertyName = "codigo_cliente";
            this.codigoclienteDataGridViewTextBoxColumn.HeaderText = "codigo_cliente";
            this.codigoclienteDataGridViewTextBoxColumn.Name = "codigoclienteDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Width = 200;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.Width = 200;
            // 
            // nitDataGridViewTextBoxColumn
            // 
            this.nitDataGridViewTextBoxColumn.DataPropertyName = "nit";
            this.nitDataGridViewTextBoxColumn.HeaderText = "nit";
            this.nitDataGridViewTextBoxColumn.Name = "nitDataGridViewTextBoxColumn";
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.proyectoDataSet5;
            // 
            // proyectoDataSet5
            // 
            this.proyectoDataSet5.DataSetName = "ProyectoDataSet5";
            this.proyectoDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // btnimprimirfacturav
            // 
            this.btnimprimirfacturav.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimirfacturav.Location = new System.Drawing.Point(173, 491);
            this.btnimprimirfacturav.Name = "btnimprimirfacturav";
            this.btnimprimirfacturav.Size = new System.Drawing.Size(233, 51);
            this.btnimprimirfacturav.TabIndex = 26;
            this.btnimprimirfacturav.Text = "Imprimir factura";
            this.btnimprimirfacturav.UseVisualStyleBackColor = true;
            this.btnimprimirfacturav.Click += new System.EventHandler(this.btnimprimirfacturav_Click);
            // 
            // btnguardarfacturav
            // 
            this.btnguardarfacturav.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarfacturav.Location = new System.Drawing.Point(440, 491);
            this.btnguardarfacturav.Name = "btnguardarfacturav";
            this.btnguardarfacturav.Size = new System.Drawing.Size(242, 51);
            this.btnguardarfacturav.TabIndex = 27;
            this.btnguardarfacturav.Text = "Realizar venta";
            this.btnguardarfacturav.UseVisualStyleBackColor = true;
            this.btnguardarfacturav.Click += new System.EventHandler(this.btnguardarfacturav_Click);
            // 
            // btnMostrarInventario
            // 
            this.btnMostrarInventario.BackColor = System.Drawing.Color.Lime;
            this.btnMostrarInventario.BackgroundImage = global::ProyectoBDD.Properties.Resources.kisspng_regresar_superintendencia_de_sociedades_informatio_web_5adf1550c0b367_4216011515245694247893;
            this.btnMostrarInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMostrarInventario.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarInventario.ForeColor = System.Drawing.Color.Black;
            this.btnMostrarInventario.Location = new System.Drawing.Point(1092, 510);
            this.btnMostrarInventario.Name = "btnMostrarInventario";
            this.btnMostrarInventario.Size = new System.Drawing.Size(96, 32);
            this.btnMostrarInventario.TabIndex = 28;
            this.btnMostrarInventario.Text = "Regresar";
            this.btnMostrarInventario.UseVisualStyleBackColor = false;
            this.btnMostrarInventario.Click += new System.EventHandler(this.btnMostrarInventario_Click);
            // 
            // btnActualizarv
            // 
            this.btnActualizarv.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarv.Location = new System.Drawing.Point(704, 491);
            this.btnActualizarv.Name = "btnActualizarv";
            this.btnActualizarv.Size = new System.Drawing.Size(242, 51);
            this.btnActualizarv.TabIndex = 29;
            this.btnActualizarv.Text = "Actualizar cuadro";
            this.btnActualizarv.UseVisualStyleBackColor = true;
            this.btnActualizarv.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.btnActualizarv);
            this.Controls.Add(this.btnMostrarInventario);
            this.Controls.Add(this.btnguardarfacturav);
            this.Controls.Add(this.btnimprimirfacturav);
            this.Controls.Add(this.dgvventas);
            this.Controls.Add(this.txtnitv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcorreov);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdirecciónv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcodigoclientev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcantidadv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboboxventas);
            this.Controls.Add(this.txtidproductov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "FormVender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVender";
            this.Load += new System.EventHandler(this.FormVender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ProyectoDataSet4 proyectoDataSet4;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private ProyectoDataSet4TableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.TextBox txtidproductov;
        private System.Windows.Forms.ComboBox comboboxventas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidadv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigoclientev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdirecciónv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcorreov;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnitv;
        private System.Windows.Forms.DataGridView dgvventas;
        private ProyectoDataSet5 proyectoDataSet5;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private ProyectoDataSet5TableAdapters.VentasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnimprimirfacturav;
        private System.Windows.Forms.Button btnguardarfacturav;
        private System.Windows.Forms.Button btnMostrarInventario;
        private System.Windows.Forms.Button btnActualizarv;
    }
}