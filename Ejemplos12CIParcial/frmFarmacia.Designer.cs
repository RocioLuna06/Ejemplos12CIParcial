namespace Ejemplos12CIParcial
{
    partial class frmFarmacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFarmacia));
            System.Windows.Forms.Label id_farmaciaLabel;
            System.Windows.Forms.Label nombre_farmaciaLabel;
            System.Windows.Forms.Label nom_medicina_farmLabel;
            System.Windows.Forms.Label cantidad_medicina_farmLabel;
            System.Windows.Forms.Label precio_unid_med_farmLabel;
            System.Windows.Forms.Label fecha_elab_med_farmLabel;
            System.Windows.Forms.Label fecha_venc_med_farmLabel;
            System.Windows.Forms.Label id_consultaLabel;
            this.hospitalmedykalsystemDataSet = new Ejemplos12CIParcial.hospitalmedykalsystemDataSet();
            this.farmaciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmaciaTableAdapter = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.FarmaciaTableAdapter();
            this.tableAdapterManager = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager();
            this.farmaciaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.farmaciaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.farmaciaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_farmaciaTextBox = new System.Windows.Forms.TextBox();
            this.nombre_farmaciaTextBox = new System.Windows.Forms.TextBox();
            this.nom_medicina_farmTextBox = new System.Windows.Forms.TextBox();
            this.cantidad_medicina_farmTextBox = new System.Windows.Forms.TextBox();
            this.precio_unid_med_farmTextBox = new System.Windows.Forms.TextBox();
            this.fecha_elab_med_farmTextBox = new System.Windows.Forms.TextBox();
            this.fecha_venc_med_farmTextBox = new System.Windows.Forms.TextBox();
            this.id_consultaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            id_farmaciaLabel = new System.Windows.Forms.Label();
            nombre_farmaciaLabel = new System.Windows.Forms.Label();
            nom_medicina_farmLabel = new System.Windows.Forms.Label();
            cantidad_medicina_farmLabel = new System.Windows.Forms.Label();
            precio_unid_med_farmLabel = new System.Windows.Forms.Label();
            fecha_elab_med_farmLabel = new System.Windows.Forms.Label();
            fecha_venc_med_farmLabel = new System.Windows.Forms.Label();
            id_consultaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaBindingNavigator)).BeginInit();
            this.farmaciaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hospitalmedykalsystemDataSet
            // 
            this.hospitalmedykalsystemDataSet.DataSetName = "hospitalmedykalsystemDataSet";
            this.hospitalmedykalsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // farmaciaBindingSource
            // 
            this.farmaciaBindingSource.DataMember = "Farmacia";
            this.farmaciaBindingSource.DataSource = this.hospitalmedykalsystemDataSet;
            // 
            // farmaciaTableAdapter
            // 
            this.farmaciaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = null;
            this.tableAdapterManager.ConsultorioTableAdapter = null;
            this.tableAdapterManager.EspecialidadTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.FarmaciaTableAdapter = this.farmaciaTableAdapter;
            this.tableAdapterManager.PacienteTableAdapter = null;
            this.tableAdapterManager.Personal_MedicoTableAdapter = null;
            this.tableAdapterManager.SalaTableAdapter = null;
            this.tableAdapterManager.TurnosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // farmaciaBindingNavigator
            // 
            this.farmaciaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.farmaciaBindingNavigator.BindingSource = this.farmaciaBindingSource;
            this.farmaciaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.farmaciaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.farmaciaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.farmaciaBindingNavigatorSaveItem});
            this.farmaciaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.farmaciaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.farmaciaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.farmaciaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.farmaciaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.farmaciaBindingNavigator.Name = "farmaciaBindingNavigator";
            this.farmaciaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.farmaciaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.farmaciaBindingNavigator.TabIndex = 0;
            this.farmaciaBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // farmaciaDataGridView
            // 
            this.farmaciaDataGridView.AutoGenerateColumns = false;
            this.farmaciaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.farmaciaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.farmaciaDataGridView.DataSource = this.farmaciaBindingSource;
            this.farmaciaDataGridView.Location = new System.Drawing.Point(12, 239);
            this.farmaciaDataGridView.Name = "farmaciaDataGridView";
            this.farmaciaDataGridView.Size = new System.Drawing.Size(764, 216);
            this.farmaciaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_farmacia";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_farmacia";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_farmacia";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre_farmacia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nom_medicina_farm";
            this.dataGridViewTextBoxColumn3.HeaderText = "nom_medicina_farm";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cantidad_medicina_farm";
            this.dataGridViewTextBoxColumn4.HeaderText = "cantidad_medicina_farm";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "precio_unid_med_farm";
            this.dataGridViewTextBoxColumn5.HeaderText = "precio_unid_med_farm";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fecha_elab_med_farm";
            this.dataGridViewTextBoxColumn6.HeaderText = "fecha_elab_med_farm";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fecha_venc_med_farm";
            this.dataGridViewTextBoxColumn7.HeaderText = "fecha_venc_med_farm";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id_consulta";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id_consulta";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
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
            // farmaciaBindingNavigatorSaveItem
            // 
            this.farmaciaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.farmaciaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("farmaciaBindingNavigatorSaveItem.Image")));
            this.farmaciaBindingNavigatorSaveItem.Name = "farmaciaBindingNavigatorSaveItem";
            this.farmaciaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.farmaciaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.farmaciaBindingNavigatorSaveItem.Click += new System.EventHandler(this.farmaciaBindingNavigatorSaveItem_Click);
            // 
            // id_farmaciaLabel
            // 
            id_farmaciaLabel.AutoSize = true;
            id_farmaciaLabel.Location = new System.Drawing.Point(25, 128);
            id_farmaciaLabel.Name = "id_farmaciaLabel";
            id_farmaciaLabel.Size = new System.Drawing.Size(62, 13);
            id_farmaciaLabel.TabIndex = 2;
            id_farmaciaLabel.Text = "Id farmacia:";
            // 
            // id_farmaciaTextBox
            // 
            this.id_farmaciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.farmaciaBindingSource, "Id_farmacia", true));
            this.id_farmaciaTextBox.Location = new System.Drawing.Point(124, 125);
            this.id_farmaciaTextBox.Name = "id_farmaciaTextBox";
            this.id_farmaciaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_farmaciaTextBox.TabIndex = 3;
            // 
            // nombre_farmaciaLabel
            // 
            nombre_farmaciaLabel.AutoSize = true;
            nombre_farmaciaLabel.Location = new System.Drawing.Point(25, 154);
            nombre_farmaciaLabel.Name = "nombre_farmaciaLabel";
            nombre_farmaciaLabel.Size = new System.Drawing.Size(88, 13);
            nombre_farmaciaLabel.TabIndex = 4;
            nombre_farmaciaLabel.Text = "nombre farmacia:";
            // 
            // nombre_farmaciaTextBox
            // 
            this.nombre_farmaciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.farmaciaBindingSource, "nombre_farmacia", true));
            this.nombre_farmaciaTextBox.Location = new System.Drawing.Point(124, 151);
            this.nombre_farmaciaTextBox.Name = "nombre_farmaciaTextBox";
            this.nombre_farmaciaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombre_farmaciaTextBox.TabIndex = 5;
            // 
            // nom_medicina_farmLabel
            // 
            nom_medicina_farmLabel.AutoSize = true;
            nom_medicina_farmLabel.Location = new System.Drawing.Point(264, 128);
            nom_medicina_farmLabel.Name = "nom_medicina_farmLabel";
            nom_medicina_farmLabel.Size = new System.Drawing.Size(98, 13);
            nom_medicina_farmLabel.TabIndex = 6;
            nom_medicina_farmLabel.Text = "nom medicina farm:";
            // 
            // nom_medicina_farmTextBox
            // 
            this.nom_medicina_farmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.farmaciaBindingSource, "nom_medicina_farm", true));
            this.nom_medicina_farmTextBox.Location = new System.Drawing.Point(396, 131);
            this.nom_medicina_farmTextBox.Name = "nom_medicina_farmTextBox";
            this.nom_medicina_farmTextBox.Size = new System.Drawing.Size(100, 20);
            this.nom_medicina_farmTextBox.TabIndex = 7;
            // 
            // cantidad_medicina_farmLabel
            // 
            cantidad_medicina_farmLabel.AutoSize = true;
            cantidad_medicina_farmLabel.Location = new System.Drawing.Point(264, 154);
            cantidad_medicina_farmLabel.Name = "cantidad_medicina_farmLabel";
            cantidad_medicina_farmLabel.Size = new System.Drawing.Size(119, 13);
            cantidad_medicina_farmLabel.TabIndex = 8;
            cantidad_medicina_farmLabel.Text = "cantidad medicina farm:";
            // 
            // cantidad_medicina_farmTextBox
            // 
            this.cantidad_medicina_farmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.farmaciaBindingSource, "cantidad_medicina_farm", true));
            this.cantidad_medicina_farmTextBox.Location = new System.Drawing.Point(396, 157);
            this.cantidad_medicina_farmTextBox.Name = "cantidad_medicina_farmTextBox";
            this.cantidad_medicina_farmTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidad_medicina_farmTextBox.TabIndex = 9;
            // 
            // precio_unid_med_farmLabel
            // 
            precio_unid_med_farmLabel.AutoSize = true;
            precio_unid_med_farmLabel.Location = new System.Drawing.Point(526, 134);
            precio_unid_med_farmLabel.Name = "precio_unid_med_farmLabel";
            precio_unid_med_farmLabel.Size = new System.Drawing.Size(108, 13);
            precio_unid_med_farmLabel.TabIndex = 10;
            precio_unid_med_farmLabel.Text = "precio unid med farm:";
            // 
            // precio_unid_med_farmTextBox
            // 
            this.precio_unid_med_farmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.farmaciaBindingSource, "precio_unid_med_farm", true));
            this.precio_unid_med_farmTextBox.Location = new System.Drawing.Point(647, 131);
            this.precio_unid_med_farmTextBox.Name = "precio_unid_med_farmTextBox";
            this.precio_unid_med_farmTextBox.Size = new System.Drawing.Size(100, 20);
            this.precio_unid_med_farmTextBox.TabIndex = 11;
            // 
            // fecha_elab_med_farmLabel
            // 
            fecha_elab_med_farmLabel.AutoSize = true;
            fecha_elab_med_farmLabel.Location = new System.Drawing.Point(526, 160);
            fecha_elab_med_farmLabel.Name = "fecha_elab_med_farmLabel";
            fecha_elab_med_farmLabel.Size = new System.Drawing.Size(106, 13);
            fecha_elab_med_farmLabel.TabIndex = 12;
            fecha_elab_med_farmLabel.Text = "fecha elab med farm:";
            // 
            // fecha_elab_med_farmTextBox
            // 
            this.fecha_elab_med_farmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.farmaciaBindingSource, "fecha_elab_med_farm", true));
            this.fecha_elab_med_farmTextBox.Location = new System.Drawing.Point(647, 157);
            this.fecha_elab_med_farmTextBox.Name = "fecha_elab_med_farmTextBox";
            this.fecha_elab_med_farmTextBox.Size = new System.Drawing.Size(100, 20);
            this.fecha_elab_med_farmTextBox.TabIndex = 13;
            // 
            // fecha_venc_med_farmLabel
            // 
            fecha_venc_med_farmLabel.AutoSize = true;
            fecha_venc_med_farmLabel.Location = new System.Drawing.Point(114, 200);
            fecha_venc_med_farmLabel.Name = "fecha_venc_med_farmLabel";
            fecha_venc_med_farmLabel.Size = new System.Drawing.Size(110, 13);
            fecha_venc_med_farmLabel.TabIndex = 14;
            fecha_venc_med_farmLabel.Text = "fecha venc med farm:";
            // 
            // fecha_venc_med_farmTextBox
            // 
            this.fecha_venc_med_farmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.farmaciaBindingSource, "fecha_venc_med_farm", true));
            this.fecha_venc_med_farmTextBox.Location = new System.Drawing.Point(239, 197);
            this.fecha_venc_med_farmTextBox.Name = "fecha_venc_med_farmTextBox";
            this.fecha_venc_med_farmTextBox.Size = new System.Drawing.Size(100, 20);
            this.fecha_venc_med_farmTextBox.TabIndex = 15;
            // 
            // id_consultaLabel
            // 
            id_consultaLabel.AutoSize = true;
            id_consultaLabel.Location = new System.Drawing.Point(382, 203);
            id_consultaLabel.Name = "id_consultaLabel";
            id_consultaLabel.Size = new System.Drawing.Size(62, 13);
            id_consultaLabel.TabIndex = 16;
            id_consultaLabel.Text = "Id consulta:";
            // 
            // id_consultaTextBox
            // 
            this.id_consultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.farmaciaBindingSource, "Id_consulta", true));
            this.id_consultaTextBox.Location = new System.Drawing.Point(507, 200);
            this.id_consultaTextBox.Name = "id_consultaTextBox";
            this.id_consultaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_consultaTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(163)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(352, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Farmacia";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(163)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 22);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejemplos12CIParcial.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(562, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmFarmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(207)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(id_farmaciaLabel);
            this.Controls.Add(this.id_farmaciaTextBox);
            this.Controls.Add(nombre_farmaciaLabel);
            this.Controls.Add(this.nombre_farmaciaTextBox);
            this.Controls.Add(nom_medicina_farmLabel);
            this.Controls.Add(this.nom_medicina_farmTextBox);
            this.Controls.Add(cantidad_medicina_farmLabel);
            this.Controls.Add(this.cantidad_medicina_farmTextBox);
            this.Controls.Add(precio_unid_med_farmLabel);
            this.Controls.Add(this.precio_unid_med_farmTextBox);
            this.Controls.Add(fecha_elab_med_farmLabel);
            this.Controls.Add(this.fecha_elab_med_farmTextBox);
            this.Controls.Add(fecha_venc_med_farmLabel);
            this.Controls.Add(this.fecha_venc_med_farmTextBox);
            this.Controls.Add(id_consultaLabel);
            this.Controls.Add(this.id_consultaTextBox);
            this.Controls.Add(this.farmaciaDataGridView);
            this.Controls.Add(this.farmaciaBindingNavigator);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmFarmacia";
            this.Text = "frmFarmacia";
            this.Load += new System.EventHandler(this.frmFarmacia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaBindingNavigator)).EndInit();
            this.farmaciaBindingNavigator.ResumeLayout(false);
            this.farmaciaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hospitalmedykalsystemDataSet hospitalmedykalsystemDataSet;
        private System.Windows.Forms.BindingSource farmaciaBindingSource;
        private hospitalmedykalsystemDataSetTableAdapters.FarmaciaTableAdapter farmaciaTableAdapter;
        private hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator farmaciaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton farmaciaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView farmaciaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox id_farmaciaTextBox;
        private System.Windows.Forms.TextBox nombre_farmaciaTextBox;
        private System.Windows.Forms.TextBox nom_medicina_farmTextBox;
        private System.Windows.Forms.TextBox cantidad_medicina_farmTextBox;
        private System.Windows.Forms.TextBox precio_unid_med_farmTextBox;
        private System.Windows.Forms.TextBox fecha_elab_med_farmTextBox;
        private System.Windows.Forms.TextBox fecha_venc_med_farmTextBox;
        private System.Windows.Forms.TextBox id_consultaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}