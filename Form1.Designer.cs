
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
            this.button_ll = new System.Windows.Forms.Button();
            this.button_lr = new System.Windows.Forms.Button();
            this.button_rl = new System.Windows.Forms.Button();
            this.button_rr = new System.Windows.Forms.Button();
            this.bindingNavigatorSQLite = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindingNavigatorPosrtgreSQL = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
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
            this.dataGridViewSQLite.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // button_ll
            // 
            this.button_ll.Location = new System.Drawing.Point(50, 25);
            this.button_ll.Name = "button_ll";
            this.button_ll.Size = new System.Drawing.Size(150, 50);
            this.button_ll.TabIndex = 2;
            this.button_ll.Text = "button_ll";
            this.button_ll.UseVisualStyleBackColor = true;
            this.button_ll.Click += new System.EventHandler(this.button_ll_Click);
            // 
            // button_lr
            // 
            this.button_lr.Location = new System.Drawing.Point(500, 25);
            this.button_lr.Name = "button_lr";
            this.button_lr.Size = new System.Drawing.Size(150, 50);
            this.button_lr.TabIndex = 3;
            this.button_lr.Text = "button_lr";
            this.button_lr.UseVisualStyleBackColor = true;
            this.button_lr.Click += new System.EventHandler(this.button_lr_Click);
            // 
            // button_rl
            // 
            this.button_rl.Location = new System.Drawing.Point(700, 25);
            this.button_rl.Name = "button_rl";
            this.button_rl.Size = new System.Drawing.Size(150, 50);
            this.button_rl.TabIndex = 4;
            this.button_rl.Text = "button_rl";
            this.button_rl.UseVisualStyleBackColor = true;
            this.button_rl.Click += new System.EventHandler(this.button_rl_Click);
            // 
            // button_rr
            // 
            this.button_rr.Location = new System.Drawing.Point(1150, 25);
            this.button_rr.Name = "button_rr";
            this.button_rr.Size = new System.Drawing.Size(150, 50);
            this.button_rr.TabIndex = 5;
            this.button_rr.Text = "button_rr";
            this.button_rr.UseVisualStyleBackColor = true;
            this.button_rr.Click += new System.EventHandler(this.button_rr_Click);
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
            this.bindingNavigatorSQLite.Size = new System.Drawing.Size(283, 27);
            this.bindingNavigatorSQLite.TabIndex = 6;
            this.bindingNavigatorSQLite.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
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
            this.bindingNavigatorPosrtgreSQL.Size = new System.Drawing.Size(283, 27);
            this.bindingNavigatorPosrtgreSQL.TabIndex = 7;
            this.bindingNavigatorPosrtgreSQL.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 753);
            this.Controls.Add(this.bindingNavigatorPosrtgreSQL);
            this.Controls.Add(this.bindingNavigatorSQLite);
            this.Controls.Add(this.button_rr);
            this.Controls.Add(this.button_rl);
            this.Controls.Add(this.button_lr);
            this.Controls.Add(this.button_ll);
            this.Controls.Add(this.dataGridViewPostgreSQL);
            this.Controls.Add(this.dataGridViewSQLite);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button_ll;
        private System.Windows.Forms.Button button_lr;
        private System.Windows.Forms.Button button_rl;
        private System.Windows.Forms.Button button_rr;
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
    }
}

