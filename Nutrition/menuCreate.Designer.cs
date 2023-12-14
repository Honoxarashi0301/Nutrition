namespace Nutrition
{
  partial class menuCreate
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.tabPage1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("標楷體", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label1.Location = new System.Drawing.Point(139, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(428, 96);
      this.label1.TabIndex = 0;
      this.label1.Text = "菜單操作";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.button1.Location = new System.Drawing.Point(180, 180);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(350, 130);
      this.button1.TabIndex = 1;
      this.button1.Text = "新增";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.button2.Location = new System.Drawing.Point(180, 375);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(350, 130);
      this.button2.TabIndex = 2;
      this.button2.Text = "編輯";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.button3.Location = new System.Drawing.Point(180, 570);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(350, 130);
      this.button3.TabIndex = 3;
      this.button3.Text = "刪除";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.button4.Location = new System.Drawing.Point(180, 765);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(350, 130);
      this.button4.TabIndex = 4;
      this.button4.Text = "詳細";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("標楷體", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label2.Location = new System.Drawing.Point(1088, 31);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(428, 96);
      this.label2.TabIndex = 5;
      this.label2.Text = "菜單一覽";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label3.Location = new System.Drawing.Point(810, 180);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(118, 48);
      this.label3.TabIndex = 6;
      this.label3.Text = "名稱";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label4.Location = new System.Drawing.Point(1184, 180);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(216, 48);
      this.label4.TabIndex = 7;
      this.label4.Text = "創立日期";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label5.Location = new System.Drawing.Point(1648, 180);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(118, 48);
      this.label5.TabIndex = 8;
      this.label5.Text = "備註";
      // 
      // sqLiteCommand1
      // 
      this.sqLiteCommand1.CommandText = null;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dataGridView1);
      this.tabPage1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(1262, 610);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "一覽";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Location = new System.Drawing.Point(605, 259);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(1270, 636);
      this.tabControl1.TabIndex = 9;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(1262, 610);
      this.dataGridView1.TabIndex = 0;
      // 
      // menuCreate
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1924, 1061);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Name = "menuCreate";
      this.Text = "菜單清單頁面";
      this.Load += new System.EventHandler(this.menuCreate_Load);
      this.tabPage1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}