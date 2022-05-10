
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
            this.dataGridViewSQLite = new System.Windows.Forms.DataGridView();
            this.dataGridViewPostgreSQL = new System.Windows.Forms.DataGridView();
            this.button_ll = new System.Windows.Forms.Button();
            this.button_lr = new System.Windows.Forms.Button();
            this.button_rl = new System.Windows.Forms.Button();
            this.button_rr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQLite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostgreSQL)).BeginInit();
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
            // 
            // button_lr
            // 
            this.button_lr.Location = new System.Drawing.Point(500, 25);
            this.button_lr.Name = "button_lr";
            this.button_lr.Size = new System.Drawing.Size(150, 50);
            this.button_lr.TabIndex = 3;
            this.button_lr.Text = "button_lr";
            this.button_lr.UseVisualStyleBackColor = true;
            // 
            // button_rl
            // 
            this.button_rl.Location = new System.Drawing.Point(700, 25);
            this.button_rl.Name = "button_rl";
            this.button_rl.Size = new System.Drawing.Size(150, 50);
            this.button_rl.TabIndex = 4;
            this.button_rl.Text = "button_rl";
            this.button_rl.UseVisualStyleBackColor = true;
            // 
            // button_rr
            // 
            this.button_rr.Location = new System.Drawing.Point(1150, 25);
            this.button_rr.Name = "button_rr";
            this.button_rr.Size = new System.Drawing.Size(150, 50);
            this.button_rr.TabIndex = 5;
            this.button_rr.Text = "button_rr";
            this.button_rr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 753);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSQLite;
        private System.Windows.Forms.DataGridView dataGridViewPostgreSQL;
        private System.Windows.Forms.Button button_ll;
        private System.Windows.Forms.Button button_lr;
        private System.Windows.Forms.Button button_rl;
        private System.Windows.Forms.Button button_rr;
    }
}

