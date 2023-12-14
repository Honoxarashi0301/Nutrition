namespace Nutrition
{
  partial class dishesList
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
      this.label2 = new System.Windows.Forms.Label();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.DishGridView = new System.Windows.Forms.DataGridView();
      this.mealType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.protein = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fat = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.carbohydrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.button5 = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DishGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("標楷體", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label2.Location = new System.Drawing.Point(1094, 33);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(428, 96);
      this.label2.TabIndex = 14;
      this.label2.Text = "菜餚一覽";
      // 
      // button4
      // 
      this.button4.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.button4.Location = new System.Drawing.Point(186, 767);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(350, 130);
      this.button4.TabIndex = 13;
      this.button4.Text = "輸出PDF";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.button3.Location = new System.Drawing.Point(186, 572);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(350, 130);
      this.button3.TabIndex = 12;
      this.button3.Text = "刪除";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.button2.Location = new System.Drawing.Point(186, 377);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(350, 130);
      this.button2.TabIndex = 11;
      this.button2.Text = "編輯";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.button1.Location = new System.Drawing.Point(186, 182);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(350, 130);
      this.button1.TabIndex = 10;
      this.button1.Text = "新增";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("標楷體", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label1.Location = new System.Drawing.Point(145, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(428, 96);
      this.label1.TabIndex = 9;
      this.label1.Text = "菜餚操作";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(600, 182);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(1295, 715);
      this.tabControl1.TabIndex = 21;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.DishGridView);
      this.tabPage2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(1287, 689);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "一覽";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // DishGridView
      // 
      this.DishGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.DishGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DishGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mealType,
            this.dishName,
            this.protein,
            this.fat,
            this.carbohydrate,
            this.calories});
      this.DishGridView.Location = new System.Drawing.Point(0, 0);
      this.DishGridView.Name = "DishGridView";
      this.DishGridView.RowTemplate.Height = 24;
      this.DishGridView.Size = new System.Drawing.Size(1287, 689);
      this.DishGridView.TabIndex = 0;
      // 
      // mealType
      // 
      this.mealType.FillWeight = 50F;
      this.mealType.HeaderText = "餐別";
      this.mealType.Name = "mealType";
      // 
      // dishName
      // 
      this.dishName.FillWeight = 150F;
      this.dishName.HeaderText = "菜名";
      this.dishName.Name = "dishName";
      // 
      // protein
      // 
      this.protein.FillWeight = 50F;
      this.protein.HeaderText = "蛋白質";
      this.protein.Name = "protein";
      // 
      // fat
      // 
      this.fat.FillWeight = 50F;
      this.fat.HeaderText = "脂質";
      this.fat.Name = "fat";
      // 
      // carbohydrate
      // 
      this.carbohydrate.FillWeight = 50F;
      this.carbohydrate.HeaderText = "醣類";
      this.carbohydrate.Name = "carbohydrate";
      // 
      // calories
      // 
      this.calories.FillWeight = 50F;
      this.calories.HeaderText = "熱量";
      this.calories.Name = "calories";
      // 
      // button5
      // 
      this.button5.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.button5.Location = new System.Drawing.Point(12, 919);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(390, 130);
      this.button5.TabIndex = 22;
      this.button5.Text = "上一頁";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // dishesList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1924, 1061);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Name = "dishesList";
      this.Text = "菜餚清單頁面   ";
      this.tabControl1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DishGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DataGridView DishGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn mealType;
    private System.Windows.Forms.DataGridViewTextBoxColumn dishName;
    private System.Windows.Forms.DataGridViewTextBoxColumn protein;
    private System.Windows.Forms.DataGridViewTextBoxColumn fat;
    private System.Windows.Forms.DataGridViewTextBoxColumn carbohydrate;
    private System.Windows.Forms.DataGridViewTextBoxColumn calories;
    private System.Windows.Forms.Button button5;
  }
}