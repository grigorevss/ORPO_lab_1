
namespace ORPO_lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewSQLite = new System.Windows.Forms.DataGridView();
            this.dataGridViewPostgreSQL = new System.Windows.Forms.DataGridView();
            this.SQLiteFill = new System.Windows.Forms.Button();
            this.SQLiteUpdate = new System.Windows.Forms.Button();
            this.PostgreSQLFill = new System.Windows.Forms.Button();
            this.PostgreSQLUpdate = new System.Windows.Forms.Button();
            this.bindingNavigatorSQLite = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPosrtgreSQL = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQLite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostgreSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSQLite)).BeginInit();
            this.bindingNavigatorSQLite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPosrtgreSQL)).BeginInit();
            this.bindingNavigatorPosrtgreSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSQLite
            // 
            this.dataGridViewSQLite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSQLite.Location = new System.Drawing.Point(50, 100);
            this.dataGridViewSQLite.Name = "dataGridViewSQLite";
            this.dataGridViewSQLite.RowHeadersWidth = 51;
            this.dataGridViewSQLite.RowTemplate.Height = 24;
            this.dataGridViewSQLite.Size = new System.Drawing.Size(600, 600);
            this.dataGridViewSQLite.TabIndex = 0;
            // 
            // dataGridViewPostgreSQL
            // 
            this.dataGridViewPostgreSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPostgreSQL.Location = new System.Drawing.Point(700, 100);
            this.dataGridViewPostgreSQL.Name = "dataGridViewPostgreSQL";
            this.dataGridViewPostgreSQL.RowHeadersWidth = 51;
            this.dataGridViewPostgreSQL.RowTemplate.Height = 24;
            this.dataGridViewPostgreSQL.Size = new System.Drawing.Size(600, 600);
            this.dataGridViewPostgreSQL.TabIndex = 1;
            // 
            // SQLiteFill
            // 
            this.SQLiteFill.Location = new System.Drawing.Point(50, 25);
            this.SQLiteFill.Name = "SQLiteFill";
            this.SQLiteFill.Size = new System.Drawing.Size(150, 50);
            this.SQLiteFill.TabIndex = 2;
            this.SQLiteFill.Text = "Fill";
            this.SQLiteFill.UseVisualStyleBackColor = true;
            this.SQLiteFill.Click += new System.EventHandler(this.SQLiteFill_Click);
            // 
            // SQLiteUpdate
            // 
            this.SQLiteUpdate.Location = new System.Drawing.Point(500, 25);
            this.SQLiteUpdate.Name = "SQLiteUpdate";
            this.SQLiteUpdate.Size = new System.Drawing.Size(150, 50);
            this.SQLiteUpdate.TabIndex = 3;
            this.SQLiteUpdate.Text = "Update";
            this.SQLiteUpdate.UseVisualStyleBackColor = true;
            this.SQLiteUpdate.Click += new System.EventHandler(this.SQLiteUpdate_Click);
            // 
            // PostgreSQLFill
            // 
            this.PostgreSQLFill.Location = new System.Drawing.Point(700, 25);
            this.PostgreSQLFill.Name = "PostgreSQLFill";
            this.PostgreSQLFill.Size = new System.Drawing.Size(150, 50);
            this.PostgreSQLFill.TabIndex = 4;
            this.PostgreSQLFill.Text = "Fill";
            this.PostgreSQLFill.UseVisualStyleBackColor = true;
            this.PostgreSQLFill.Click += new System.EventHandler(this.PostgreSQLFill_Click);
            // 
            // PostgreSQLUpdate
            // 
            this.PostgreSQLUpdate.Location = new System.Drawing.Point(1150, 25);
            this.PostgreSQLUpdate.Name = "PostgreSQLUpdate";
            this.PostgreSQLUpdate.Size = new System.Drawing.Size(150, 50);
            this.PostgreSQLUpdate.TabIndex = 5;
            this.PostgreSQLUpdate.Text = "Update";
            this.PostgreSQLUpdate.UseVisualStyleBackColor = true;
            this.PostgreSQLUpdate.Click += new System.EventHandler(this.PostgreSQLUpdate_Click);
            // 
            // bindingNavigatorSQLite
            // 
            this.bindingNavigatorSQLite.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorSQLite.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorSQLite.DeleteItem = null;
            this.bindingNavigatorSQLite.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorSQLite.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorSQLite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.bindingNavigatorSQLite.Location = new System.Drawing.Point(50, 707);
            this.bindingNavigatorSQLite.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorSQLite.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorSQLite.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorSQLite.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorSQLite.Name = "bindingNavigatorSQLite";
            this.bindingNavigatorSQLite.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorSQLite.Size = new System.Drawing.Size(283, 31);
            this.bindingNavigatorSQLite.TabIndex = 6;
            this.bindingNavigatorSQLite.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPosrtgreSQL
            // 
            this.bindingNavigatorPosrtgreSQL.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigatorPosrtgreSQL.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigatorPosrtgreSQL.DeleteItem = null;
            this.bindingNavigatorPosrtgreSQL.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorPosrtgreSQL.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorPosrtgreSQL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1});
            this.bindingNavigatorPosrtgreSQL.Location = new System.Drawing.Point(700, 707);
            this.bindingNavigatorPosrtgreSQL.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigatorPosrtgreSQL.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigatorPosrtgreSQL.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigatorPosrtgreSQL.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigatorPosrtgreSQL.Name = "bindingNavigatorPosrtgreSQL";
            this.bindingNavigatorPosrtgreSQL.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigatorPosrtgreSQL.Size = new System.Drawing.Size(283, 31);
            this.bindingNavigatorPosrtgreSQL.TabIndex = 7;
            this.bindingNavigatorPosrtgreSQL.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "SQLite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(958, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "PostgreSQL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 753);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigatorPosrtgreSQL);
            this.Controls.Add(this.bindingNavigatorSQLite);
            this.Controls.Add(this.PostgreSQLUpdate);
            this.Controls.Add(this.PostgreSQLFill);
            this.Controls.Add(this.SQLiteUpdate);
            this.Controls.Add(this.SQLiteFill);
            this.Controls.Add(this.dataGridViewPostgreSQL);
            this.Controls.Add(this.dataGridViewSQLite);
            this.Name = "Form1";
            this.Text = "Lab 1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQLite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostgreSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSQLite)).EndInit();
            this.bindingNavigatorSQLite.ResumeLayout(false);
            this.bindingNavigatorSQLite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPosrtgreSQL)).EndInit();
            this.bindingNavigatorPosrtgreSQL.ResumeLayout(false);
            this.bindingNavigatorPosrtgreSQL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSQLite;
        private System.Windows.Forms.DataGridView dataGridViewPostgreSQL;
        private System.Windows.Forms.Button SQLiteFill;
        private System.Windows.Forms.Button SQLiteUpdate;
        private System.Windows.Forms.Button PostgreSQLFill;
        private System.Windows.Forms.Button PostgreSQLUpdate;
        private System.Windows.Forms.BindingNavigator bindingNavigatorSQLite;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator bindingNavigatorPosrtgreSQL;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

