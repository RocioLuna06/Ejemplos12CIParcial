namespace Ejemplos12CIParcial
{
    partial class frmFactura
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
            System.Windows.Forms.Label id_facturaLabel;
            System.Windows.Forms.Label fecha_facturaLabel;
            System.Windows.Forms.Label cantidad_compra_facLabel;
            System.Windows.Forms.Label total_compra_facLabel;
            System.Windows.Forms.Label id_farmaciaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.hospitalmedykalsystemDataSet = new Ejemplos12CIParcial.hospitalmedykalsystemDataSet();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaTableAdapter = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.FacturaTableAdapter();
            this.tableAdapterManager = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager();
            this.facturaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.facturaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.facturaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_facturaTextBox = new System.Windows.Forms.TextBox();
            this.fecha_facturaTextBox = new System.Windows.Forms.TextBox();
            this.cantidad_compra_facTextBox = new System.Windows.Forms.TextBox();
            this.total_compra_facTextBox = new System.Windows.Forms.TextBox();
            this.id_farmaciaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            id_facturaLabel = new System.Windows.Forms.Label();
            fecha_facturaLabel = new System.Windows.Forms.Label();
            cantidad_compra_facLabel = new System.Windows.Forms.Label();
            total_compra_facLabel = new System.Windows.Forms.Label();
            id_farmaciaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingNavigator)).BeginInit();
            this.facturaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_facturaLabel
            // 
            id_facturaLabel.AutoSize = true;
            id_facturaLabel.Location = new System.Drawing.Point(16, 101);
            id_facturaLabel.Name = "id_facturaLabel";
            id_facturaLabel.Size = new System.Drawing.Size(55, 13);
            id_facturaLabel.TabIndex = 2;
            id_facturaLabel.Text = "Id factura:";
            // 
            // fecha_facturaLabel
            // 
            fecha_facturaLabel.AutoSize = true;
            fecha_facturaLabel.Location = new System.Drawing.Point(16, 127);
            fecha_facturaLabel.Name = "fecha_facturaLabel";
            fecha_facturaLabel.Size = new System.Drawing.Size(73, 13);
            fecha_facturaLabel.TabIndex = 4;
            fecha_facturaLabel.Text = "fecha factura:";
            // 
            // cantidad_compra_facLabel
            // 
            cantidad_compra_facLabel.AutoSize = true;
            cantidad_compra_facLabel.Location = new System.Drawing.Point(273, 101);
            cantidad_compra_facLabel.Name = "cantidad_compra_facLabel";
            cantidad_compra_facLabel.Size = new System.Drawing.Size(107, 13);
            cantidad_compra_facLabel.TabIndex = 6;
            cantidad_compra_facLabel.Text = "cantidad compra fac:";
            // 
            // total_compra_facLabel
            // 
            total_compra_facLabel.AutoSize = true;
            total_compra_facLabel.Location = new System.Drawing.Point(163, 158);
            total_compra_facLabel.Name = "total_compra_facLabel";
            total_compra_facLabel.Size = new System.Drawing.Size(86, 13);
            total_compra_facLabel.TabIndex = 8;
            total_compra_facLabel.Text = "total compra fac:";
            // 
            // id_farmaciaLabel
            // 
            id_farmaciaLabel.AutoSize = true;
            id_farmaciaLabel.Location = new System.Drawing.Point(273, 130);
            id_farmaciaLabel.Name = "id_farmaciaLabel";
            id_farmaciaLabel.Size = new System.Drawing.Size(62, 13);
            id_farmaciaLabel.TabIndex = 10;
            id_farmaciaLabel.Text = "Id farmacia:";
            // 
            // hospitalmedykalsystemDataSet
            // 
            this.hospitalmedykalsystemDataSet.DataSetName = "hospitalmedykalsystemDataSet";
            this.hospitalmedykalsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "Factura";
            this.facturaBindingSource.DataSource = this.hospitalmedykalsystemDataSet;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = null;
            this.tableAdapterManager.ConsultorioTableAdapter = null;
            this.tableAdapterManager.EspecialidadTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = this.facturaTableAdapter;
            this.tableAdapterManager.FarmaciaTableAdapter = null;
            this.tableAdapterManager.PacienteTableAdapter = null;
            this.tableAdapterManager.Personal_MedicoTableAdapter = null;
            this.tableAdapterManager.SalaTableAdapter = null;
            this.tableAdapterManager.TurnosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // facturaBindingNavigator
            // 
            this.facturaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.facturaBindingNavigator.BindingSource = this.facturaBindingSource;
            this.facturaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.facturaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.facturaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.facturaBindingNavigatorSaveItem});
            this.facturaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.facturaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.facturaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.facturaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.facturaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.facturaBindingNavigator.Name = "facturaBindingNavigator";
            this.facturaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.facturaBindingNavigator.Size = new System.Drawing.Size(587, 25);
            this.facturaBindingNavigator.TabIndex = 0;
            this.facturaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // facturaBindingNavigatorSaveItem
            // 
            this.facturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facturaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("facturaBindingNavigatorSaveItem.Image")));
            this.facturaBindingNavigatorSaveItem.Name = "facturaBindingNavigatorSaveItem";
            this.facturaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.facturaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.facturaBindingNavigatorSaveItem.Click += new System.EventHandler(this.facturaBindingNavigatorSaveItem_Click);
            // 
            // facturaDataGridView
            // 
            this.facturaDataGridView.AutoGenerateColumns = false;
            this.facturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.facturaDataGridView.DataSource = this.facturaBindingSource;
            this.facturaDataGridView.Location = new System.Drawing.Point(13, 192);
            this.facturaDataGridView.Name = "facturaDataGridView";
            this.facturaDataGridView.Size = new System.Drawing.Size(531, 196);
            this.facturaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_factura";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_factura";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fecha_factura";
            this.dataGridViewTextBoxColumn2.HeaderText = "fecha_factura";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cantidad_compra_fac";
            this.dataGridViewTextBoxColumn3.HeaderText = "cantidad_compra_fac";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "total_compra_fac";
            this.dataGridViewTextBoxColumn4.HeaderText = "total_compra_fac";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id_farmacia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id_farmacia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // id_facturaTextBox
            // 
            this.id_facturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "Id_factura", true));
            this.id_facturaTextBox.Location = new System.Drawing.Point(129, 98);
            this.id_facturaTextBox.Name = "id_facturaTextBox";
            this.id_facturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_facturaTextBox.TabIndex = 3;
            // 
            // fecha_facturaTextBox
            // 
            this.fecha_facturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "fecha_factura", true));
            this.fecha_facturaTextBox.Location = new System.Drawing.Point(129, 124);
            this.fecha_facturaTextBox.Name = "fecha_facturaTextBox";
            this.fecha_facturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.fecha_facturaTextBox.TabIndex = 5;
            // 
            // cantidad_compra_facTextBox
            // 
            this.cantidad_compra_facTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "cantidad_compra_fac", true));
            this.cantidad_compra_facTextBox.Location = new System.Drawing.Point(386, 98);
            this.cantidad_compra_facTextBox.Name = "cantidad_compra_facTextBox";
            this.cantidad_compra_facTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidad_compra_facTextBox.TabIndex = 7;
            // 
            // total_compra_facTextBox
            // 
            this.total_compra_facTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "total_compra_fac", true));
            this.total_compra_facTextBox.Location = new System.Drawing.Point(276, 155);
            this.total_compra_facTextBox.Name = "total_compra_facTextBox";
            this.total_compra_facTextBox.Size = new System.Drawing.Size(100, 20);
            this.total_compra_facTextBox.TabIndex = 9;
            // 
            // id_farmaciaTextBox
            // 
            this.id_farmaciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "Id_farmacia", true));
            this.id_farmaciaTextBox.Location = new System.Drawing.Point(386, 127);
            this.id_farmaciaTextBox.Name = "id_farmaciaTextBox";
            this.id_farmaciaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_farmaciaTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(163)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(241, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Factura";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(163)))));
            this.pictureBox2.Location = new System.Drawing.Point(-241, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(836, 22);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejemplos12CIParcial.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(430, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(207)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(587, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(id_facturaLabel);
            this.Controls.Add(this.id_facturaTextBox);
            this.Controls.Add(fecha_facturaLabel);
            this.Controls.Add(this.fecha_facturaTextBox);
            this.Controls.Add(cantidad_compra_facLabel);
            this.Controls.Add(this.cantidad_compra_facTextBox);
            this.Controls.Add(total_compra_facLabel);
            this.Controls.Add(this.total_compra_facTextBox);
            this.Controls.Add(id_farmaciaLabel);
            this.Controls.Add(this.id_farmaciaTextBox);
            this.Controls.Add(this.facturaDataGridView);
            this.Controls.Add(this.facturaBindingNavigator);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingNavigator)).EndInit();
            this.facturaBindingNavigator.ResumeLayout(false);
            this.facturaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hospitalmedykalsystemDataSet hospitalmedykalsystemDataSet;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private hospitalmedykalsystemDataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator facturaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton facturaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView facturaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox id_facturaTextBox;
        private System.Windows.Forms.TextBox fecha_facturaTextBox;
        private System.Windows.Forms.TextBox cantidad_compra_facTextBox;
        private System.Windows.Forms.TextBox total_compra_facTextBox;
        private System.Windows.Forms.TextBox id_farmaciaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}