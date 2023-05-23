namespace Ejemplos12CIParcial
{
    partial class frmPacienteD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacienteD));
            System.Windows.Forms.Label id_pacienteLabel;
            System.Windows.Forms.Label nombre_pacLabel;
            System.Windows.Forms.Label direccion_pacLabel;
            System.Windows.Forms.Label telefono_pacLabel;
            System.Windows.Forms.Label dni_pacLabel;
            System.Windows.Forms.Label edad_pacLabel;
            System.Windows.Forms.Label fecha_nacLabel;
            System.Windows.Forms.Label foto_pacLabel;
            System.Windows.Forms.Label id_salaLabel;
            this.hospitalmedykalsystemDataSet = new Ejemplos12CIParcial.hospitalmedykalsystemDataSet();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.PacienteTableAdapter();
            this.tableAdapterManager = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager();
            this.pacienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pacienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.pacienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_pacienteTextBox = new System.Windows.Forms.TextBox();
            this.nombre_pacTextBox = new System.Windows.Forms.TextBox();
            this.direccion_pacTextBox = new System.Windows.Forms.TextBox();
            this.telefono_pacTextBox = new System.Windows.Forms.TextBox();
            this.dni_pacTextBox = new System.Windows.Forms.TextBox();
            this.edad_pacTextBox = new System.Windows.Forms.TextBox();
            this.fecha_nacTextBox = new System.Windows.Forms.TextBox();
            this.foto_pacTextBox = new System.Windows.Forms.TextBox();
            this.id_salaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            id_pacienteLabel = new System.Windows.Forms.Label();
            nombre_pacLabel = new System.Windows.Forms.Label();
            direccion_pacLabel = new System.Windows.Forms.Label();
            telefono_pacLabel = new System.Windows.Forms.Label();
            dni_pacLabel = new System.Windows.Forms.Label();
            edad_pacLabel = new System.Windows.Forms.Label();
            fecha_nacLabel = new System.Windows.Forms.Label();
            foto_pacLabel = new System.Windows.Forms.Label();
            id_salaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).BeginInit();
            this.pacienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hospitalmedykalsystemDataSet
            // 
            this.hospitalmedykalsystemDataSet.DataSetName = "hospitalmedykalsystemDataSet";
            this.hospitalmedykalsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.hospitalmedykalsystemDataSet;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = null;
            this.tableAdapterManager.ConsultorioTableAdapter = null;
            this.tableAdapterManager.EspecialidadTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.FarmaciaTableAdapter = null;
            this.tableAdapterManager.PacienteTableAdapter = this.pacienteTableAdapter;
            this.tableAdapterManager.Personal_MedicoTableAdapter = null;
            this.tableAdapterManager.SalaTableAdapter = null;
            this.tableAdapterManager.TurnosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pacienteBindingNavigator
            // 
            this.pacienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacienteBindingNavigator.BindingSource = this.pacienteBindingSource;
            this.pacienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pacienteBindingNavigatorSaveItem});
            this.pacienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacienteBindingNavigator.Name = "pacienteBindingNavigator";
            this.pacienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacienteBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.pacienteBindingNavigator.TabIndex = 0;
            this.pacienteBindingNavigator.Text = "bindingNavigator1";
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
            // pacienteDataGridView
            // 
            this.pacienteDataGridView.AutoGenerateColumns = false;
            this.pacienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.pacienteDataGridView.DataSource = this.pacienteBindingSource;
            this.pacienteDataGridView.Location = new System.Drawing.Point(37, 215);
            this.pacienteDataGridView.Name = "pacienteDataGridView";
            this.pacienteDataGridView.Size = new System.Drawing.Size(721, 223);
            this.pacienteDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_paciente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_paciente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_pac";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre_pac";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "direccion_pac";
            this.dataGridViewTextBoxColumn3.HeaderText = "direccion_pac";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefono_pac";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefono_pac";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dni_pac";
            this.dataGridViewTextBoxColumn5.HeaderText = "dni_pac";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "edad_pac";
            this.dataGridViewTextBoxColumn6.HeaderText = "edad_pac";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fecha_nac";
            this.dataGridViewTextBoxColumn7.HeaderText = "fecha_nac";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "foto_pac";
            this.dataGridViewTextBoxColumn8.HeaderText = "foto_pac";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id_sala";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id_sala";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
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
            // pacienteBindingNavigatorSaveItem
            // 
            this.pacienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacienteBindingNavigatorSaveItem.Image")));
            this.pacienteBindingNavigatorSaveItem.Name = "pacienteBindingNavigatorSaveItem";
            this.pacienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pacienteBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pacienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.pacienteBindingNavigatorSaveItem_Click);
            // 
            // id_pacienteLabel
            // 
            id_pacienteLabel.AutoSize = true;
            id_pacienteLabel.Location = new System.Drawing.Point(34, 116);
            id_pacienteLabel.Name = "id_pacienteLabel";
            id_pacienteLabel.Size = new System.Drawing.Size(63, 13);
            id_pacienteLabel.TabIndex = 2;
            id_pacienteLabel.Text = "Id paciente:";
            // 
            // id_pacienteTextBox
            // 
            this.id_pacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "Id_paciente", true));
            this.id_pacienteTextBox.Location = new System.Drawing.Point(114, 113);
            this.id_pacienteTextBox.Name = "id_pacienteTextBox";
            this.id_pacienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_pacienteTextBox.TabIndex = 3;
            // 
            // nombre_pacLabel
            // 
            nombre_pacLabel.AutoSize = true;
            nombre_pacLabel.Location = new System.Drawing.Point(34, 142);
            nombre_pacLabel.Name = "nombre_pacLabel";
            nombre_pacLabel.Size = new System.Drawing.Size(66, 13);
            nombre_pacLabel.TabIndex = 4;
            nombre_pacLabel.Text = "nombre pac:";
            // 
            // nombre_pacTextBox
            // 
            this.nombre_pacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "nombre_pac", true));
            this.nombre_pacTextBox.Location = new System.Drawing.Point(114, 139);
            this.nombre_pacTextBox.Name = "nombre_pacTextBox";
            this.nombre_pacTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombre_pacTextBox.TabIndex = 5;
            // 
            // direccion_pacLabel
            // 
            direccion_pacLabel.AutoSize = true;
            direccion_pacLabel.Location = new System.Drawing.Point(276, 119);
            direccion_pacLabel.Name = "direccion_pacLabel";
            direccion_pacLabel.Size = new System.Drawing.Size(74, 13);
            direccion_pacLabel.TabIndex = 6;
            direccion_pacLabel.Text = "direccion pac:";
            // 
            // direccion_pacTextBox
            // 
            this.direccion_pacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "direccion_pac", true));
            this.direccion_pacTextBox.Location = new System.Drawing.Point(356, 116);
            this.direccion_pacTextBox.Name = "direccion_pacTextBox";
            this.direccion_pacTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccion_pacTextBox.TabIndex = 7;
            // 
            // telefono_pacLabel
            // 
            telefono_pacLabel.AutoSize = true;
            telefono_pacLabel.Location = new System.Drawing.Point(276, 145);
            telefono_pacLabel.Name = "telefono_pacLabel";
            telefono_pacLabel.Size = new System.Drawing.Size(73, 13);
            telefono_pacLabel.TabIndex = 8;
            telefono_pacLabel.Text = "Telefono pac:";
            // 
            // telefono_pacTextBox
            // 
            this.telefono_pacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "Telefono_pac", true));
            this.telefono_pacTextBox.Location = new System.Drawing.Point(356, 142);
            this.telefono_pacTextBox.Name = "telefono_pacTextBox";
            this.telefono_pacTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefono_pacTextBox.TabIndex = 9;
            // 
            // dni_pacLabel
            // 
            dni_pacLabel.AutoSize = true;
            dni_pacLabel.Location = new System.Drawing.Point(521, 122);
            dni_pacLabel.Name = "dni_pacLabel";
            dni_pacLabel.Size = new System.Drawing.Size(45, 13);
            dni_pacLabel.TabIndex = 10;
            dni_pacLabel.Text = "dni pac:";
            // 
            // dni_pacTextBox
            // 
            this.dni_pacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "dni_pac", true));
            this.dni_pacTextBox.Location = new System.Drawing.Point(601, 119);
            this.dni_pacTextBox.Name = "dni_pacTextBox";
            this.dni_pacTextBox.Size = new System.Drawing.Size(100, 20);
            this.dni_pacTextBox.TabIndex = 11;
            // 
            // edad_pacLabel
            // 
            edad_pacLabel.AutoSize = true;
            edad_pacLabel.Location = new System.Drawing.Point(521, 148);
            edad_pacLabel.Name = "edad_pacLabel";
            edad_pacLabel.Size = new System.Drawing.Size(55, 13);
            edad_pacLabel.TabIndex = 12;
            edad_pacLabel.Text = "edad pac:";
            // 
            // edad_pacTextBox
            // 
            this.edad_pacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "edad_pac", true));
            this.edad_pacTextBox.Location = new System.Drawing.Point(601, 145);
            this.edad_pacTextBox.Name = "edad_pacTextBox";
            this.edad_pacTextBox.Size = new System.Drawing.Size(100, 20);
            this.edad_pacTextBox.TabIndex = 13;
            // 
            // fecha_nacLabel
            // 
            fecha_nacLabel.AutoSize = true;
            fecha_nacLabel.Location = new System.Drawing.Point(34, 174);
            fecha_nacLabel.Name = "fecha_nacLabel";
            fecha_nacLabel.Size = new System.Drawing.Size(58, 13);
            fecha_nacLabel.TabIndex = 14;
            fecha_nacLabel.Text = "fecha nac:";
            // 
            // fecha_nacTextBox
            // 
            this.fecha_nacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "fecha_nac", true));
            this.fecha_nacTextBox.Location = new System.Drawing.Point(114, 171);
            this.fecha_nacTextBox.Name = "fecha_nacTextBox";
            this.fecha_nacTextBox.Size = new System.Drawing.Size(100, 20);
            this.fecha_nacTextBox.TabIndex = 15;
            // 
            // foto_pacLabel
            // 
            foto_pacLabel.AutoSize = true;
            foto_pacLabel.Location = new System.Drawing.Point(276, 177);
            foto_pacLabel.Name = "foto_pacLabel";
            foto_pacLabel.Size = new System.Drawing.Size(49, 13);
            foto_pacLabel.TabIndex = 16;
            foto_pacLabel.Text = "foto pac:";
            // 
            // foto_pacTextBox
            // 
            this.foto_pacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "foto_pac", true));
            this.foto_pacTextBox.Location = new System.Drawing.Point(356, 174);
            this.foto_pacTextBox.Name = "foto_pacTextBox";
            this.foto_pacTextBox.Size = new System.Drawing.Size(100, 20);
            this.foto_pacTextBox.TabIndex = 17;
            // 
            // id_salaLabel
            // 
            id_salaLabel.AutoSize = true;
            id_salaLabel.Location = new System.Drawing.Point(521, 179);
            id_salaLabel.Name = "id_salaLabel";
            id_salaLabel.Size = new System.Drawing.Size(41, 13);
            id_salaLabel.TabIndex = 18;
            id_salaLabel.Text = "Id sala:";
            // 
            // id_salaTextBox
            // 
            this.id_salaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "Id_sala", true));
            this.id_salaTextBox.Location = new System.Drawing.Point(601, 176);
            this.id_salaTextBox.Name = "id_salaTextBox";
            this.id_salaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_salaTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(163)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(335, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Paciente";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(163)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(812, 22);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejemplos12CIParcial.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(601, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmPacienteD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(207)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(id_pacienteLabel);
            this.Controls.Add(this.id_pacienteTextBox);
            this.Controls.Add(nombre_pacLabel);
            this.Controls.Add(this.nombre_pacTextBox);
            this.Controls.Add(direccion_pacLabel);
            this.Controls.Add(this.direccion_pacTextBox);
            this.Controls.Add(telefono_pacLabel);
            this.Controls.Add(this.telefono_pacTextBox);
            this.Controls.Add(dni_pacLabel);
            this.Controls.Add(this.dni_pacTextBox);
            this.Controls.Add(edad_pacLabel);
            this.Controls.Add(this.edad_pacTextBox);
            this.Controls.Add(fecha_nacLabel);
            this.Controls.Add(this.fecha_nacTextBox);
            this.Controls.Add(foto_pacLabel);
            this.Controls.Add(this.foto_pacTextBox);
            this.Controls.Add(id_salaLabel);
            this.Controls.Add(this.id_salaTextBox);
            this.Controls.Add(this.pacienteDataGridView);
            this.Controls.Add(this.pacienteBindingNavigator);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmPacienteD";
            this.Text = "frmPacienteD";
            this.Load += new System.EventHandler(this.frmPacienteD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).EndInit();
            this.pacienteBindingNavigator.ResumeLayout(false);
            this.pacienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hospitalmedykalsystemDataSet hospitalmedykalsystemDataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private hospitalmedykalsystemDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pacienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pacienteBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pacienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox id_pacienteTextBox;
        private System.Windows.Forms.TextBox nombre_pacTextBox;
        private System.Windows.Forms.TextBox direccion_pacTextBox;
        private System.Windows.Forms.TextBox telefono_pacTextBox;
        private System.Windows.Forms.TextBox dni_pacTextBox;
        private System.Windows.Forms.TextBox edad_pacTextBox;
        private System.Windows.Forms.TextBox fecha_nacTextBox;
        private System.Windows.Forms.TextBox foto_pacTextBox;
        private System.Windows.Forms.TextBox id_salaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}