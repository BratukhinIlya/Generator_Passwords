namespace GeneratorPasswords
{
    partial class GeneratePassword
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IsclNonBukv = new System.Windows.Forms.CheckBox();
            this.IsclPohozh = new System.Windows.Forms.CheckBox();
            this.lengthPass = new System.Windows.Forms.NumericUpDown();
            this.textPass = new System.Windows.Forms.RichTextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthPass)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.textLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IsclNonBukv);
            this.groupBox1.Controls.Add(this.IsclPohozh);
            this.groupBox1.Controls.Add(this.lengthPass);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(512, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(131, 199);
            this.textLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(299, 22);
            this.textLogin.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите логин:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Длина пароля";
            // 
            // IsclNonBukv
            // 
            this.IsclNonBukv.AutoSize = true;
            this.IsclNonBukv.Location = new System.Drawing.Point(8, 82);
            this.IsclNonBukv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IsclNonBukv.Name = "IsclNonBukv";
            this.IsclNonBukv.Size = new System.Drawing.Size(472, 20);
            this.IsclNonBukv.TabIndex = 4;
            this.IsclNonBukv.Text = "Исключить небуквенные символы (например { } [ ] ( ) / \\ \' \" ` ~  ,  ;  :  . < >)";
            this.IsclNonBukv.UseVisualStyleBackColor = true;
            // 
            // IsclPohozh
            // 
            this.IsclPohozh.AutoSize = true;
            this.IsclPohozh.Location = new System.Drawing.Point(8, 54);
            this.IsclPohozh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IsclPohozh.Name = "IsclPohozh";
            this.IsclPohozh.Size = new System.Drawing.Size(376, 20);
            this.IsclPohozh.TabIndex = 2;
            this.IsclPohozh.Text = "Исключить похожие символы (например i, l, 1, L, o, 0, O)";
            this.IsclPohozh.UseVisualStyleBackColor = true;
            // 
            // lengthPass
            // 
            this.lengthPass.Location = new System.Drawing.Point(123, 22);
            this.lengthPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lengthPass.Name = "lengthPass";
            this.lengthPass.Size = new System.Drawing.Size(160, 22);
            this.lengthPass.TabIndex = 0;
            // 
            // textPass
            // 
            this.textPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPass.Location = new System.Drawing.Point(537, 32);
            this.textPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(513, 334);
            this.textPass.TabIndex = 1;
            this.textPass.Text = "";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonGenerate.Location = new System.Drawing.Point(917, 373);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(132, 46);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Сгенерировать";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Location = new System.Drawing.Point(537, 373);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(136, 44);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // GeneratePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 433);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1083, 472);
            this.MinimumSize = new System.Drawing.Size(1083, 472);
            this.Name = "GeneratePassword";
            this.ShowIcon = false;
            this.Text = "Generator Passwords";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox textPass;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.CheckBox IsclNonBukv;
        private System.Windows.Forms.CheckBox IsclPohozh;
        private System.Windows.Forms.NumericUpDown lengthPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
    }
}

