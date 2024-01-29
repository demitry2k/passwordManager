namespace PasswordManager
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.masterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.MD5selector = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bcryptselector = new System.Windows.Forms.RadioButton();
            this.SHA256selector = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.symbols40selector = new System.Windows.Forms.RadioButton();
            this.symbols20selector = new System.Windows.Forms.RadioButton();
            this.symbols10selector = new System.Windows.Forms.RadioButton();
            this.Сайт = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Получить пароль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Сайт});
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(333, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(15, 230);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(330, 20);
            this.loginTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сайт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Мастер-пароль:";
            // 
            // masterPasswordTextBox
            // 
            this.masterPasswordTextBox.Location = new System.Drawing.Point(14, 281);
            this.masterPasswordTextBox.Name = "masterPasswordTextBox";
            this.masterPasswordTextBox.Size = new System.Drawing.Size(330, 20);
            this.masterPasswordTextBox.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MD5selector
            // 
            this.MD5selector.AutoSize = true;
            this.MD5selector.Checked = true;
            this.MD5selector.Location = new System.Drawing.Point(6, 19);
            this.MD5selector.Name = "MD5selector";
            this.MD5selector.Size = new System.Drawing.Size(48, 17);
            this.MD5selector.TabIndex = 8;
            this.MD5selector.TabStop = true;
            this.MD5selector.Text = "MD5";
            this.MD5selector.UseVisualStyleBackColor = true;
            this.MD5selector.CheckedChanged += new System.EventHandler(this.MD5selector_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bcryptselector);
            this.groupBox1.Controls.Add(this.SHA256selector);
            this.groupBox1.Controls.Add(this.MD5selector);
            this.groupBox1.Location = new System.Drawing.Point(17, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 86);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод генерации";
            // 
            // bcryptselector
            // 
            this.bcryptselector.AutoSize = true;
            this.bcryptselector.Location = new System.Drawing.Point(6, 63);
            this.bcryptselector.Name = "bcryptselector";
            this.bcryptselector.Size = new System.Drawing.Size(157, 17);
            this.bcryptselector.TabIndex = 10;
            this.bcryptselector.Text = "bcrypt (неповторяющийся)";
            this.bcryptselector.UseVisualStyleBackColor = true;
            this.bcryptselector.CheckedChanged += new System.EventHandler(this.bcryptselector_CheckedChanged);
            // 
            // SHA256selector
            // 
            this.SHA256selector.AutoSize = true;
            this.SHA256selector.Location = new System.Drawing.Point(6, 42);
            this.SHA256selector.Name = "SHA256selector";
            this.SHA256selector.Size = new System.Drawing.Size(68, 17);
            this.SHA256selector.TabIndex = 9;
            this.SHA256selector.Text = "SHA-256";
            this.SHA256selector.UseVisualStyleBackColor = true;
            this.SHA256selector.CheckedChanged += new System.EventHandler(this.SHA256selector_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.symbols40selector);
            this.groupBox2.Controls.Add(this.symbols20selector);
            this.groupBox2.Controls.Add(this.symbols10selector);
            this.groupBox2.Location = new System.Drawing.Point(194, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 86);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Количество символов";
            // 
            // symbols40selector
            // 
            this.symbols40selector.AutoSize = true;
            this.symbols40selector.Enabled = false;
            this.symbols40selector.Location = new System.Drawing.Point(6, 63);
            this.symbols40selector.Name = "symbols40selector";
            this.symbols40selector.Size = new System.Drawing.Size(37, 17);
            this.symbols40selector.TabIndex = 10;
            this.symbols40selector.Text = "40";
            this.symbols40selector.UseVisualStyleBackColor = true;
            // 
            // symbols20selector
            // 
            this.symbols20selector.AutoSize = true;
            this.symbols20selector.Location = new System.Drawing.Point(6, 42);
            this.symbols20selector.Name = "symbols20selector";
            this.symbols20selector.Size = new System.Drawing.Size(37, 17);
            this.symbols20selector.TabIndex = 9;
            this.symbols20selector.Text = "20";
            this.symbols20selector.UseVisualStyleBackColor = true;
            // 
            // symbols10selector
            // 
            this.symbols10selector.AutoSize = true;
            this.symbols10selector.Checked = true;
            this.symbols10selector.Location = new System.Drawing.Point(6, 19);
            this.symbols10selector.Name = "symbols10selector";
            this.symbols10selector.Size = new System.Drawing.Size(37, 17);
            this.symbols10selector.TabIndex = 8;
            this.symbols10selector.TabStop = true;
            this.symbols10selector.Text = "10";
            this.symbols10selector.UseVisualStyleBackColor = true;
            // 
            // Сайт
            // 
            this.Сайт.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Сайт.HeaderText = "Сайт";
            this.Сайт.MinimumWidth = 255;
            this.Сайт.Name = "Сайт";
            this.Сайт.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Сайт.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.masterPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Менеджер паролей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox masterPasswordTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton MD5selector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bcryptselector;
        private System.Windows.Forms.RadioButton SHA256selector;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton symbols40selector;
        private System.Windows.Forms.RadioButton symbols20selector;
        private System.Windows.Forms.RadioButton symbols10selector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сайт;
    }
}

