namespace Ejemplos12CIParcial
{
    partial class frmConsulta
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
            System.Windows.Forms.Label id_consultaLabel;
            System.Windows.Forms.Label fecha_consultaLabel;
            System.Windows.Forms.Label hora_consultaLabel;
            System.Windows.Forms.Label diagnostico_consultaLabel;
            System.Windows.Forms.Label tratamiento_consultaLabel;
            System.Windows.Forms.Label id_consultorioLabel;
            System.Windows.Forms.Label id_personal_medicoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.hospitalmedykalsystemDataSet = new Ejemplos12CIParcial.hospitalmedykalsystemDataSet();
            this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaTableAdapter = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.ConsultaTableAdapter();
            this.tableAdapterManager = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager();
            this.consultaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.consultaDataGridView = new System.Windows.Forms.DataGridView();
            this.id_consultaTextBox = new System.Windows.Forms.TextBox();
            this.fecha_consultaTextBox = new System.Windows.Forms.TextBox();
            this.hora_consultaTextBox = new System.Windows.Forms.TextBox();
            this.diagnostico_consultaTextBox = new System.Windows.Forms.TextBox();
            this.tratamiento_consultaTextBox = new System.Windows.Forms.TextBox();
            this.id_consultorioTextBox = new System.Windows.Forms.TextBox();
            this.id_personal_medicoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.consultaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            id_consultaLabel = new System.Windows.Forms.Label();
            fecha_consultaLabel = new System.Windows.Forms.Label();
            hora_consultaLabel = new System.Windows.Forms.Label();
            diagnostico_consultaLabel = new System.Windows.Forms.Label();
            tratamiento_consultaLabel = new System.Windows.Forms.Label();
            id_consultorioLabel = new System.Windows.Forms.Label();
            id_personal_medicoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).BeginInit();
            this.consultaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // hospitalmedykalsystemDataSet
            // 
            this.hospitalmedykalsystemDataSet.DataSetName = "hospitalmedykalsystemDataSet";
            this.hospitalmedykalsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultaBindingSource
            // 
            this.consultaBindingSource.DataMember = "Consulta";
            this.consultaBindingSource.DataSource = this.hospitalmedykalsystemDataSet;
            // 
            // consultaTableAdapter
            // 
            this.consultaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = this.consultaTableAdapter;
            this.tableAdapterManager.ConsultorioTableAdapter = null;
            this.tableAdapterManager.EspecialidadTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.FarmaciaTableAdapter = null;
            this.tableAdapterManager.PacienteTableAdapter = null;
            this.tableAdapterManager.Personal_MedicoTableAdapter = null;
            this.tableAdapterManager.SalaTableAdapter = null;
            this.tableAdapterManager.TurnosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // consultaBindingNavigator
            // 
            this.consultaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultaBindingNavigator.BindingSource = this.consultaBindingSource;
            this.consultaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consultaBindingNavigatorSaveItem});
            this.consultaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultaBindingNavigator.Name = "consultaBindingNavigator";
            this.consultaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.consultaBindingNavigator.TabIndex = 0;
            this.consultaBindingNavigator.Text = "bindingNavigator1";
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
            // consultaDataGridView
            // 
            this.consultaDataGridView.AutoGenerateColumns = false;
            this.consultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.consultaDataGridView.DataSource = this.consultaBindingSource;
            this.consultaDataGridView.Location = new System.Drawing.Point(154, 193);
            this.consultaDataGridView.Name = "consultaDataGridView";
            this.consultaDataGridView.Size = new System.Drawing.Size(504, 205);
            this.consultaDataGridView.TabIndex = 1;
            // 
            // id_consultaLabel
            // 
            id_consultaLabel.AutoSize = true;
            id_consultaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_consultaLabel.Location = new System.Drawing.Point(23, 95);
            id_consultaLabel.Name = "id_consultaLabel";
            id_consultaLabel.Size = new System.Drawing.Size(81, 15);
            id_consultaLabel.TabIndex = 2;
            id_consultaLabel.Text = "Id consulta:";
            // 
            // id_consultaTextBox
            // 
            this.id_consultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "Id_consulta", true));
            this.id_consultaTextBox.Location = new System.Drawing.Point(183, 95);
            this.id_consultaTextBox.Name = "id_consultaTextBox";
            this.id_consultaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_consultaTextBox.TabIndex = 3;
            // 
            // fecha_consultaLabel
            // 
            fecha_consultaLabel.AutoSize = true;
            fecha_consultaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fecha_consultaLabel.Location = new System.Drawing.Point(23, 126);
            fecha_consultaLabel.Name = "fecha_consultaLabel";
            fecha_consultaLabel.Size = new System.Drawing.Size(104, 15);
            fecha_consultaLabel.TabIndex = 4;
            fecha_consultaLabel.Text = "fecha consulta:";
            // 
            // fecha_consultaTextBox
            // 
            this.fecha_consultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "fecha_consulta", true));
            this.fecha_consultaTextBox.Location = new System.Drawing.Point(183, 126);
            this.fecha_consultaTextBox.Name = "fecha_consultaTextBox";
            this.fecha_consultaTextBox.Size = new System.Drawing.Size(100, 20);
            this.fecha_consultaTextBox.TabIndex = 5;
            // 
            // hora_consultaLabel
            // 
            hora_consultaLabel.AutoSize = true;
            hora_consultaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hora_consultaLabel.Location = new System.Drawing.Point(352, 101);
            hora_consultaLabel.Name = "hora_consultaLabel";
            hora_consultaLabel.Size = new System.Drawing.Size(98, 15);
            hora_consultaLabel.TabIndex = 6;
            hora_consultaLabel.Text = "hora consulta:";
            // 
            // hora_consultaTextBox
            // 
            this.hora_consultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "hora_consulta", true));
            this.hora_consultaTextBox.Location = new System.Drawing.Point(496, 100);
            this.hora_consultaTextBox.Name = "hora_consultaTextBox";
            this.hora_consultaTextBox.Size = new System.Drawing.Size(100, 20);
            this.hora_consultaTextBox.TabIndex = 7;
            // 
            // diagnostico_consultaLabel
            // 
            diagnostico_consultaLabel.AutoSize = true;
            diagnostico_consultaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diagnostico_consultaLabel.Location = new System.Drawing.Point(645, 117);
            diagnostico_consultaLabel.Name = "diagnostico_consultaLabel";
            diagnostico_consultaLabel.Size = new System.Drawing.Size(143, 15);
            diagnostico_consultaLabel.TabIndex = 8;
            diagnostico_consultaLabel.Text = "diagnostico consulta:";
            // 
            // diagnostico_consultaTextBox
            // 
            this.diagnostico_consultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "diagnostico_consulta", true));
            this.diagnostico_consultaTextBox.Location = new System.Drawing.Point(664, 147);
            this.diagnostico_consultaTextBox.Name = "diagnostico_consultaTextBox";
            this.diagnostico_consultaTextBox.Size = new System.Drawing.Size(100, 20);
            this.diagnostico_consultaTextBox.TabIndex = 9;
            // 
            // tratamiento_consultaLabel
            // 
            tratamiento_consultaLabel.AutoSize = true;
            tratamiento_consultaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tratamiento_consultaLabel.Location = new System.Drawing.Point(23, 155);
            tratamiento_consultaLabel.Name = "tratamiento_consultaLabel";
            tratamiento_consultaLabel.Size = new System.Drawing.Size(142, 15);
            tratamiento_consultaLabel.TabIndex = 10;
            tratamiento_consultaLabel.Text = "tratamiento consulta:";
            // 
            // tratamiento_consultaTextBox
            // 
            this.tratamiento_consultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "tratamiento_consulta", true));
            this.tratamiento_consultaTextBox.Location = new System.Drawing.Point(183, 155);
            this.tratamiento_consultaTextBox.Name = "tratamiento_consultaTextBox";
            this.tratamiento_consultaTextBox.Size = new System.Drawing.Size(100, 20);
            this.tratamiento_consultaTextBox.TabIndex = 11;
            // 
            // id_consultorioLabel
            // 
            id_consultorioLabel.AutoSize = true;
            id_consultorioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_consultorioLabel.Location = new System.Drawing.Point(352, 127);
            id_consultorioLabel.Name = "id_consultorioLabel";
            id_consultorioLabel.Size = new System.Drawing.Size(98, 15);
            id_consultorioLabel.TabIndex = 12;
            id_consultorioLabel.Text = "Id consultorio:";
            // 
            // id_consultorioTextBox
            // 
            this.id_consultorioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "Id_consultorio", true));
            this.id_consultorioTextBox.Location = new System.Drawing.Point(496, 126);
            this.id_consultorioTextBox.Name = "id_consultorioTextBox";
            this.id_consultorioTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_consultorioTextBox.TabIndex = 13;
            // 
            // id_personal_medicoLabel
            // 
            id_personal_medicoLabel.AutoSize = true;
            id_personal_medicoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_personal_medicoLabel.Location = new System.Drawing.Point(352, 156);
            id_personal_medicoLabel.Name = "id_personal_medicoLabel";
            id_personal_medicoLabel.Size = new System.Drawing.Size(134, 15);
            id_personal_medicoLabel.TabIndex = 14;
            id_personal_medicoLabel.Text = "Id personal medico:";
            // 
            // id_personal_medicoTextBox
            // 
            this.id_personal_medicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "Id_personal_medico", true));
            this.id_personal_medicoTextBox.Location = new System.Drawing.Point(496, 155);
            this.id_personal_medicoTextBox.Name = "id_personal_medicoTextBox";
            this.id_personal_medicoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_personal_medicoTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(163)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(360, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Consulta";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_consulta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Consulta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fecha_consulta";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha Consulta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "hora_consulta";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hora Consulta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "diagnostico_consulta";
            this.dataGridViewTextBoxColumn4.HeaderText = "Diagnostico Consulta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tratamiento_consulta";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tratamiento Consulta";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id_consultorio";
            this.dataGridViewTextBoxColumn6.HeaderText = "Código Consultorio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id_personal_medico";
            this.dataGridViewTextBoxColumn7.HeaderText = "Consulta Personal Medico";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejemplos12CIParcial.Properties.Resources.logo_sistema12;
            this.pictureBox1.Location = new System.Drawing.Point(621, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(163)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 22);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
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
            // consultaBindingNavigatorSaveItem
            // 
            this.consultaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaBindingNavigatorSaveItem.Image")));
            this.consultaBindingNavigatorSaveItem.Name = "consultaBindingNavigatorSaveItem";
            this.consultaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.consultaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.consultaBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultaBindingNavigatorSaveItem_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(207)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(id_consultaLabel);
            this.Controls.Add(this.id_consultaTextBox);
            this.Controls.Add(fecha_consultaLabel);
            this.Controls.Add(this.fecha_consultaTextBox);
            this.Controls.Add(hora_consultaLabel);
            this.Controls.Add(this.hora_consultaTextBox);
            this.Controls.Add(diagnostico_consultaLabel);
            this.Controls.Add(this.diagnostico_consultaTextBox);
            this.Controls.Add(tratamiento_consultaLabel);
            this.Controls.Add(this.tratamiento_consultaTextBox);
            this.Controls.Add(id_consultorioLabel);
            this.Controls.Add(this.id_consultorioTextBox);
            this.Controls.Add(id_personal_medicoLabel);
            this.Controls.Add(this.id_personal_medicoTextBox);
            this.Controls.Add(this.consultaDataGridView);
            this.Controls.Add(this.consultaBindingNavigator);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmConsulta";
            this.Text = "frmConsulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).EndInit();
            this.consultaBindingNavigator.ResumeLayout(false);
            this.consultaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hospitalmedykalsystemDataSet hospitalmedykalsystemDataSet;
        private System.Windows.Forms.BindingSource consultaBindingSource;
        private hospitalmedykalsystemDataSetTableAdapters.ConsultaTableAdapter consultaTableAdapter;
        private hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton consultaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView consultaDataGridView;
        private System.Windows.Forms.TextBox id_consultaTextBox;
        private System.Windows.Forms.TextBox fecha_consultaTextBox;
        private System.Windows.Forms.TextBox hora_consultaTextBox;
        private System.Windows.Forms.TextBox diagnostico_consultaTextBox;
        private System.Windows.Forms.TextBox tratamiento_consultaTextBox;
        private System.Windows.Forms.TextBox id_consultorioTextBox;
        private System.Windows.Forms.TextBox id_personal_medicoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}