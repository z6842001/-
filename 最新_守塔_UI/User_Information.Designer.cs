namespace 最新_守塔_UI
{
    partial class User_Information
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
            this.label1 = new System.Windows.Forms.Label();
            this.Attack_Add = new System.Windows.Forms.Button();
            this.Attack_Low = new System.Windows.Forms.Button();
            this.Speed_Add = new System.Windows.Forms.Button();
            this.Speed_Low = new System.Windows.Forms.Button();
            this.Crit_Add = new System.Windows.Forms.Button();
            this.Crit_Low = new System.Windows.Forms.Button();
            this.CritAttack_Add = new System.Windows.Forms.Button();
            this.CritAttack_Low = new System.Windows.Forms.Button();
            this.Attack = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.Crit機率 = new System.Windows.Forms.Label();
            this.Crit傷害 = new System.Windows.Forms.Label();
            this.Points = new System.Windows.Forms.TextBox();
            this.Level = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 272);
            this.label1.TabIndex = 0;
            this.label1.Text = "腳色資訊 等級\r\n\r\n傷害\r\n\r\n攻速\r\n\r\n暴擊率\r\n\r\n暴擊傷害\r\n\r\n剩餘點數\r\n\r\n";
            // 
            // Attack_Add
            // 
            this.Attack_Add.BackColor = System.Drawing.Color.Transparent;
            this.Attack_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Attack_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Attack_Add.FlatAppearance.BorderSize = 0;
            this.Attack_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attack_Add.Location = new System.Drawing.Point(274, 71);
            this.Attack_Add.Name = "Attack_Add";
            this.Attack_Add.Size = new System.Drawing.Size(35, 35);
            this.Attack_Add.TabIndex = 1;
            this.Attack_Add.UseVisualStyleBackColor = false;
            this.Attack_Add.Click += new System.EventHandler(this.AddorLow_Click);
            // 
            // Attack_Low
            // 
            this.Attack_Low.BackColor = System.Drawing.Color.Transparent;
            this.Attack_Low.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Attack_Low.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Attack_Low.FlatAppearance.BorderSize = 0;
            this.Attack_Low.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attack_Low.Location = new System.Drawing.Point(331, 71);
            this.Attack_Low.Name = "Attack_Low";
            this.Attack_Low.Size = new System.Drawing.Size(35, 35);
            this.Attack_Low.TabIndex = 2;
            this.Attack_Low.UseVisualStyleBackColor = false;
            this.Attack_Low.Click += new System.EventHandler(this.AddorLow_Click);
            // 
            // Speed_Add
            // 
            this.Speed_Add.BackColor = System.Drawing.Color.Transparent;
            this.Speed_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Speed_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Speed_Add.FlatAppearance.BorderSize = 0;
            this.Speed_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Speed_Add.Location = new System.Drawing.Point(274, 119);
            this.Speed_Add.Name = "Speed_Add";
            this.Speed_Add.Size = new System.Drawing.Size(35, 35);
            this.Speed_Add.TabIndex = 3;
            this.Speed_Add.UseVisualStyleBackColor = false;
            this.Speed_Add.Click += new System.EventHandler(this.AddorLow_Click);
            // 
            // Speed_Low
            // 
            this.Speed_Low.BackColor = System.Drawing.Color.Transparent;
            this.Speed_Low.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Speed_Low.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Speed_Low.FlatAppearance.BorderSize = 0;
            this.Speed_Low.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Speed_Low.Location = new System.Drawing.Point(331, 119);
            this.Speed_Low.Name = "Speed_Low";
            this.Speed_Low.Size = new System.Drawing.Size(35, 35);
            this.Speed_Low.TabIndex = 4;
            this.Speed_Low.UseVisualStyleBackColor = false;
            this.Speed_Low.Click += new System.EventHandler(this.AddorLow_Click);
            // 
            // Crit_Add
            // 
            this.Crit_Add.BackColor = System.Drawing.Color.Transparent;
            this.Crit_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Crit_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Crit_Add.FlatAppearance.BorderSize = 0;
            this.Crit_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Crit_Add.Location = new System.Drawing.Point(274, 167);
            this.Crit_Add.Name = "Crit_Add";
            this.Crit_Add.Size = new System.Drawing.Size(35, 35);
            this.Crit_Add.TabIndex = 5;
            this.Crit_Add.UseVisualStyleBackColor = false;
            this.Crit_Add.Click += new System.EventHandler(this.AddorLow_Click);
            // 
            // Crit_Low
            // 
            this.Crit_Low.BackColor = System.Drawing.Color.Transparent;
            this.Crit_Low.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Crit_Low.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Crit_Low.FlatAppearance.BorderSize = 0;
            this.Crit_Low.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Crit_Low.Location = new System.Drawing.Point(331, 167);
            this.Crit_Low.Name = "Crit_Low";
            this.Crit_Low.Size = new System.Drawing.Size(35, 35);
            this.Crit_Low.TabIndex = 6;
            this.Crit_Low.UseVisualStyleBackColor = false;
            this.Crit_Low.Click += new System.EventHandler(this.AddorLow_Click);
            // 
            // CritAttack_Add
            // 
            this.CritAttack_Add.BackColor = System.Drawing.Color.Transparent;
            this.CritAttack_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CritAttack_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CritAttack_Add.FlatAppearance.BorderSize = 0;
            this.CritAttack_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CritAttack_Add.Location = new System.Drawing.Point(274, 215);
            this.CritAttack_Add.Name = "CritAttack_Add";
            this.CritAttack_Add.Size = new System.Drawing.Size(35, 35);
            this.CritAttack_Add.TabIndex = 7;
            this.CritAttack_Add.UseVisualStyleBackColor = false;
            this.CritAttack_Add.Click += new System.EventHandler(this.AddorLow_Click);
            // 
            // CritAttack_Low
            // 
            this.CritAttack_Low.BackColor = System.Drawing.Color.Transparent;
            this.CritAttack_Low.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CritAttack_Low.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CritAttack_Low.FlatAppearance.BorderSize = 0;
            this.CritAttack_Low.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CritAttack_Low.Location = new System.Drawing.Point(331, 215);
            this.CritAttack_Low.Name = "CritAttack_Low";
            this.CritAttack_Low.Size = new System.Drawing.Size(35, 35);
            this.CritAttack_Low.TabIndex = 8;
            this.CritAttack_Low.UseVisualStyleBackColor = false;
            this.CritAttack_Low.Click += new System.EventHandler(this.AddorLow_Click);
            // 
            // Attack
            // 
            this.Attack.BackColor = System.Drawing.Color.Transparent;
            this.Attack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attack.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Attack.ForeColor = System.Drawing.Color.Gold;
            this.Attack.Location = new System.Drawing.Point(71, 68);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(197, 35);
            this.Attack.TabIndex = 9;
            this.Attack.Text = "Attack";
            this.Attack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Speed
            // 
            this.Speed.BackColor = System.Drawing.Color.Transparent;
            this.Speed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Speed.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Speed.ForeColor = System.Drawing.Color.Gold;
            this.Speed.Location = new System.Drawing.Point(113, 116);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(145, 35);
            this.Speed.TabIndex = 10;
            this.Speed.Text = "Speed";
            this.Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Crit機率
            // 
            this.Crit機率.BackColor = System.Drawing.Color.Transparent;
            this.Crit機率.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Crit機率.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Crit機率.ForeColor = System.Drawing.Color.Gold;
            this.Crit機率.Location = new System.Drawing.Point(113, 164);
            this.Crit機率.Name = "Crit機率";
            this.Crit機率.Size = new System.Drawing.Size(145, 35);
            this.Crit機率.TabIndex = 11;
            this.Crit機率.Text = "Crit機率";
            this.Crit機率.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Crit傷害
            // 
            this.Crit傷害.BackColor = System.Drawing.Color.Transparent;
            this.Crit傷害.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Crit傷害.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Crit傷害.ForeColor = System.Drawing.Color.Gold;
            this.Crit傷害.Location = new System.Drawing.Point(113, 212);
            this.Crit傷害.Name = "Crit傷害";
            this.Crit傷害.Size = new System.Drawing.Size(145, 35);
            this.Crit傷害.TabIndex = 12;
            this.Crit傷害.Text = "Crit傷害";
            this.Crit傷害.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Points
            // 
            this.Points.Enabled = false;
            this.Points.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Points.Location = new System.Drawing.Point(134, 257);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(70, 36);
            this.Points.TabIndex = 13;
            this.Points.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Level
            // 
            this.Level.BackColor = System.Drawing.Color.Transparent;
            this.Level.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Level.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Level.ForeColor = System.Drawing.Color.Gold;
            this.Level.Location = new System.Drawing.Point(191, 22);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(145, 35);
            this.Level.TabIndex = 14;
            this.Level.Text = "level";
            this.Level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Save.ForeColor = System.Drawing.Color.Lime;
            this.Save.Location = new System.Drawing.Point(141, 304);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 35);
            this.Save.TabIndex = 15;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            this.Save.MouseLeave += new System.EventHandler(this.Save_MouseLeave);
            this.Save.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Save_MouseMove);
            // 
            // User_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(435, 352);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.Crit傷害);
            this.Controls.Add(this.Crit機率);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Attack);
            this.Controls.Add(this.CritAttack_Low);
            this.Controls.Add(this.CritAttack_Add);
            this.Controls.Add(this.Crit_Low);
            this.Controls.Add(this.Crit_Add);
            this.Controls.Add(this.Speed_Low);
            this.Controls.Add(this.Speed_Add);
            this.Controls.Add(this.Attack_Low);
            this.Controls.Add(this.Attack_Add);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "User_Information";
            this.Text = "User_Information";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.User_Information_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Attack_Add;
        private System.Windows.Forms.Button Attack_Low;
        private System.Windows.Forms.Button Speed_Add;
        private System.Windows.Forms.Button Speed_Low;
        private System.Windows.Forms.Button Crit_Add;
        private System.Windows.Forms.Button Crit_Low;
        private System.Windows.Forms.Button CritAttack_Add;
        private System.Windows.Forms.Button CritAttack_Low;
        private System.Windows.Forms.Label Attack;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label Crit機率;
        private System.Windows.Forms.Label Crit傷害;
        private System.Windows.Forms.TextBox Points;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Button Save;
    }
}