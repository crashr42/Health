﻿namespace Prototype.Forms
{
    partial class WorkWeeksEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkWeeksEditForm));
            this.healthDatabaseDataSet = new Prototype.HealthDatabaseDataSet();
            this.workWeeksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workWeeksTableAdapter = new Prototype.HealthDatabaseDataSetTableAdapters.WorkWeeksTableAdapter();
            this.tableAdapterManager = new Prototype.HealthDatabaseDataSetTableAdapters.TableAdapterManager();
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
            this.workWeeksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.workWeeksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.workWeeksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.healthDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWeeksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWeeksBindingNavigator)).BeginInit();
            this.workWeeksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workWeeksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // healthDatabaseDataSet
            // 
            this.healthDatabaseDataSet.DataSetName = "HealthDatabaseDataSet";
            this.healthDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workWeeksBindingSource
            // 
            this.workWeeksBindingSource.DataMember = "WorkWeeks";
            this.workWeeksBindingSource.DataSource = this.healthDatabaseDataSet;
            // 
            // workWeeksTableAdapter
            // 
            this.workWeeksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CandidatesTableAdapter = null;
            this.tableAdapterManager.DefaultScheduleTableAdapter = null;
            this.tableAdapterManager.DiagnosisClassTableAdapter = null;
            this.tableAdapterManager.DiagnosisTableAdapter = null;
            this.tableAdapterManager.DoctorsTableAdapter = null;
            this.tableAdapterManager.FunctionalClassesTableAdapter = null;
            this.tableAdapterManager.FunctionalDisordersTableAdapter = null;
            this.tableAdapterManager.FunctionalDisordersToPatientsTableAdapter = null;
            this.tableAdapterManager.ParametersTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.PatientsToDiagnosisTableAdapter = null;
            this.tableAdapterManager.PatientsToDoctorsTableAdapter = null;
            this.tableAdapterManager.PatientsToSurgerysTableAdapter = null;
            this.tableAdapterManager.PersonalScheduleTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SpecialtiesTableAdapter = null;
            this.tableAdapterManager.SurgerysTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Prototype.HealthDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WorkWeeksTableAdapter = this.workWeeksTableAdapter;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
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
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // workWeeksBindingNavigatorSaveItem
            // 
            this.workWeeksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.workWeeksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("workWeeksBindingNavigatorSaveItem.Image")));
            this.workWeeksBindingNavigatorSaveItem.Name = "workWeeksBindingNavigatorSaveItem";
            this.workWeeksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.workWeeksBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.workWeeksBindingNavigatorSaveItem.Click += new System.EventHandler(this.workWeeksBindingNavigatorSaveItem_Click);
            // 
            // workWeeksBindingNavigator
            // 
            this.workWeeksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.workWeeksBindingNavigator.BindingSource = this.workWeeksBindingSource;
            this.workWeeksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.workWeeksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.workWeeksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.workWeeksBindingNavigatorSaveItem});
            this.workWeeksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.workWeeksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.workWeeksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.workWeeksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.workWeeksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.workWeeksBindingNavigator.Name = "workWeeksBindingNavigator";
            this.workWeeksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.workWeeksBindingNavigator.Size = new System.Drawing.Size(701, 25);
            this.workWeeksBindingNavigator.TabIndex = 0;
            this.workWeeksBindingNavigator.Text = "bindingNavigator1";
            // 
            // workWeeksDataGridView
            // 
            this.workWeeksDataGridView.AutoGenerateColumns = false;
            this.workWeeksDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.workWeeksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workWeeksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.workWeeksDataGridView.DataSource = this.workWeeksBindingSource;
            this.workWeeksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workWeeksDataGridView.Location = new System.Drawing.Point(0, 25);
            this.workWeeksDataGridView.Name = "workWeeksDataGridView";
            this.workWeeksDataGridView.Size = new System.Drawing.Size(701, 427);
            this.workWeeksDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DoctorId";
            this.dataGridViewTextBoxColumn1.HeaderText = "DoctorId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DayInWeek";
            this.dataGridViewTextBoxColumn2.HeaderText = "DayInWeek";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TimeStart";
            this.dataGridViewTextBoxColumn3.HeaderText = "TimeStart";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TimeEnd";
            this.dataGridViewTextBoxColumn4.HeaderText = "TimeEnd";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DinnerStart";
            this.dataGridViewTextBoxColumn5.HeaderText = "DinnerStart";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DinnerEnd";
            this.dataGridViewTextBoxColumn6.HeaderText = "DinnerEnd";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AttendingHoursStart";
            this.dataGridViewTextBoxColumn7.HeaderText = "AttendingHoursStart";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AttendingHoursEnd";
            this.dataGridViewTextBoxColumn8.HeaderText = "AttendingHoursEnd";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "AttendingMinutes";
            this.dataGridViewTextBoxColumn9.HeaderText = "AttendingMinutes";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // WorkWeeksEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 452);
            this.Controls.Add(this.workWeeksDataGridView);
            this.Controls.Add(this.workWeeksBindingNavigator);
            this.Name = "WorkWeeksEditForm";
            this.Text = "WorkWeeksEditForm";
            this.Load += new System.EventHandler(this.WorkWeeksEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.healthDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWeeksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workWeeksBindingNavigator)).EndInit();
            this.workWeeksBindingNavigator.ResumeLayout(false);
            this.workWeeksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workWeeksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HealthDatabaseDataSet healthDatabaseDataSet;
        private System.Windows.Forms.BindingSource workWeeksBindingSource;
        private HealthDatabaseDataSetTableAdapters.WorkWeeksTableAdapter workWeeksTableAdapter;
        private HealthDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.ToolStripButton workWeeksBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator workWeeksBindingNavigator;
        private System.Windows.Forms.DataGridView workWeeksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}