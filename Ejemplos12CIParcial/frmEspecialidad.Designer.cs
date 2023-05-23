namespace Ejemplos12CIParcial
{
    partial class frmEspecialidad
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
            System.Windows.Forms.Label id_pacienteLabel;
            System.Windows.Forms.Label area_especialidadLabel;
            System.Windows.Forms.Label id_especialidadLabel;
            System.Windows.Forms.Label nombre_especialidadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEspecialidad));
            this.hospitalmedykalsystemDataSet = new Ejemplos12CIParcial.hospitalmedykalsystemDataSet();
            this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadTableAdapter = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.EspecialidadTableAdapter();
            this.tableAdapterManager = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.especialidadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.especialidadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.id_pacienteTextBox = new System.Windows.Forms.TextBox();
            this.area_especialidadTextBox = new System.Windows.Forms.TextBox();
            this.id_especialidadTextBox = new System.Windows.Forms.TextBox();
            this.nombre_especialidadTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            id_pacienteLabel = new System.Windows.Forms.Label();
            area_especialidadLabel = new System.Windows.Forms.Label();
            id_especialidadLabel = new System.Windows.Forms.Label();
            nombre_especialidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingNavigator)).BeginInit();
            this.especialidadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_pacienteLabel
            // 
            id_pacienteLabel.AutoSize = true;
            id_pacienteLabel.Location = new System.Drawing.Point(261, 172);
            id_pacienteLabel.Name = "id_pacienteLabel";
            id_pacienteLabel.Size = new System.Drawing.Size(63, 13);
            id_pacienteLabel.TabIndex = 8;
            id_pacienteLabel.Text = "Id paciente:";
            // 
            // area_especialidadLabel
            // 
            area_especialidadLabel.AutoSize = true;
            area_especialidadLabel.Location = new System.Drawing.Point(261, 137);
            area_especialidadLabel.Name = "area_especialidadLabel";
            area_especialidadLabel.Size = new System.Drawing.Size(93, 13);
            area_especialidadLabel.TabIndex = 6;
            area_especialidadLabel.Text = "area especialidad:";
            // 
            // id_especialidadLabel
            // 
            id_especialidadLabel.AutoSize = true;
            id_especialidadLabel.Location = new System.Drawing.Point(22, 137);
            id_especialidadLabel.Name = "id_especialidadLabel";
            id_especialidadLabel.Size = new System.Drawing.Size(81, 13);
            id_especialidadLabel.TabIndex = 2;
            id_especialidadLabel.Text = "Id especialidad:";
            // 
            // nombre_especialidadLabel
            // 
            nombre_especialidadLabel.AutoSize = true;
            nombre_especialidadLabel.Location = new System.Drawing.Point(22, 169);
            nombre_especialidadLabel.Name = "nombre_especialidadLabel";
            nombre_especialidadLabel.Size = new System.Drawing.Size(107, 13);
            nombre_especialidadLabel.TabIndex = 4;
            nombre_especialidadLabel.Text = "nombre especialidad:";
            // 
            // hospitalmedykalsystemDataSet
            // 
            this.hospitalmedykalsystemDataSet.DataSetName = "hospitalmedykalsystemDataSet";
            this.hospitalmedykalsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // especialidadBindingSource
            // 
            this.especialidadBindingSource.DataMember = "Especialidad";
            this.especialidadBindingSource.DataSource = this.hospitalmedykalsystemDataSet;
            // 
            // especialidadTableAdapter
            // 
            this.especialidadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = null;
            this.tableAdapterManager.ConsultorioTableAdapter = null;
            this.tableAdapterManager.EspecialidadTableAdapter = this.especialidadTableAdapter;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.FarmaciaTableAdapter = null;
            this.tableAdapterManager.PacienteTableAdapter = null;
            this.tableAdapterManager.Personal_MedicoTableAdapter = null;
            this.tableAdapterManager.SalaTableAdapter = null;
            this.tableAdapterManager.TurnosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // especialidadBindingNavigatorSaveItem
            // 
            this.especialidadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.especialidadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("especialidadBindingNavigatorSaveItem.Image")));
            this.especialidadBindingNavigatorSaveItem.Name = "especialidadBindingNavigatorSaveItem";
            this.especialidadBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.especialidadBindingNavigatorSaveItem.Text = "Guardar datos";
            this.especialidadBindingNavigatorSaveItem.Click += new System.EventHandler(this.especialidadBindingNavigatorSaveItem_Click);
            // 
            // especialidadBindingNavigator
            // 
            this.especialidadBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.especialidadBindingNavigator.BindingSource = this.especialidadBindingSource;
            this.especialidadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.especialidadBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.especialidadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.especialidadBindingNavigatorSaveItem});
            this.especialidadBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.especialidadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.especialidadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.especialidadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.especialidadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.especialidadBindingNavigator.Name = "especialidadBindingNavigator";
            this.especialidadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.especialidadBindingNavigator.Size = new System.Drawing.Size(516, 25);
            this.especialidadBindingNavigator.TabIndex = 0;
            this.especialidadBindingNavigator.Text = "bindingNavigator1";
            // 
            // id_pacienteTextBox
            // 
            this.id_pacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.especialidadBindingSource, "Id_paciente", true));
            this.id_pacienteTextBox.Location = new System.Drawing.Point(374, 169);
            this.id_pacienteTextBox.Name = "id_pacienteTextBox";
            this.id_pacienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_pacienteTextBox.TabIndex = 9;
            // 
            // area_especialidadTextBox
            // 
            this.area_especialidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.especialidadBindingSource, "area_especialidad", true));
            this.area_especialidadTextBox.Location = new System.Drawing.Point(374, 134);
            this.area_especialidadTextBox.Name = "area_especialidadTextBox";
            this.area_especialidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.area_especialidadTextBox.TabIndex = 7;
            // 
            // id_especialidadTextBox
            // 
            this.id_especialidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.especialidadBindingSource, "Id_especialidad", true));
            this.id_especialidadTextBox.Location = new System.Drawing.Point(135, 134);
            this.id_especialidadTextBox.Name = "id_especialidadTextBox";
            this.id_especialidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_especialidadTextBox.TabIndex = 3;
            // 
            // nombre_especialidadTextBox
            // 
            this.nombre_especialidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.especialidadBindingSource, "nombre_especialidad", true));
            this.nombre_especialidadTextBox.Location = new System.Drawing.Point(135, 166);
            this.nombre_especialidadTextBox.Name = "nombre_especialidadTextBox";
            this.nombre_especialidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombre_especialidadTextBox.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id_paciente";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id_paciente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "area_especialidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "area_especialidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_especialidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre_especialidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_especialidad";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_especialidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // especialidadDataGridView
            // 
            this.especialidadDataGridView.AutoGenerateColumns = false;
            this.especialidadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.especialidadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.especialidadDataGridView.DataSource = this.especialidadBindingSource;
            this.especialidadDataGridView.Location = new System.Drawing.Point(25, 208);
            this.especialidadDataGridView.Name = "especialidadDataGridView";
            this.especialidadDataGridView.Size = new System.Drawing.Size(437, 204);
            this.especialidadDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(163)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(191, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Especialidad";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(163)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(516, 22);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejemplos12CIParcial.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(327, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(207)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(516, 434);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(id_especialidadLabel);
            this.Controls.Add(this.id_especialidadTextBox);
            this.Controls.Add(nombre_especialidadLabel);
            this.Controls.Add(this.nombre_especialidadTextBox);
            this.Controls.Add(area_especialidadLabel);
            this.Controls.Add(this.area_especialidadTextBox);
            this.Controls.Add(id_pacienteLabel);
            this.Controls.Add(this.id_pacienteTextBox);
            this.Controls.Add(this.especialidadDataGridView);
            this.Controls.Add(this.especialidadBindingNavigator);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmEspecialidad";
            this.Text = "frmEspecialidad";
            this.Load += new System.EventHandler(this.frmEspecialidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingNavigator)).EndInit();
            this.especialidadBindingNavigator.ResumeLayout(false);
            this.especialidadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hospitalmedykalsystemDataSet hospitalmedykalsystemDataSet;
        private System.Windows.Forms.BindingSource especialidadBindingSource;
        private hospitalmedykalsystemDataSetTableAdapters.EspecialidadTableAdapter especialidadTableAdapter;
        private hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton especialidadBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator especialidadBindingNavigator;
        private System.Windows.Forms.TextBox id_pacienteTextBox;
        private System.Windows.Forms.TextBox area_especialidadTextBox;
        private System.Windows.Forms.TextBox id_especialidadTextBox;
        private System.Windows.Forms.TextBox nombre_especialidadTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView especialidadDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}