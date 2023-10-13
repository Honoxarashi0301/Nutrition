namespace Nutrition
{
  partial class Form1
  {
    /// <summary>
    /// 設計工具所需的變數。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清除任何使用中的資源。
    /// </summary>
    /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 設計工具產生的程式碼

    /// <summary>
    /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
    /// 這個方法的內容。
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.AddButton = new System.Windows.Forms.Button();
      this.DeleteButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.menuBox = new System.Windows.Forms.TextBox();
      this.mealBox = new System.Windows.Forms.ComboBox();
      this.noneRadio = new System.Windows.Forms.RadioButton();
      this.CaloriesRadio = new System.Windows.Forms.RadioButton();
      this.material = new System.Windows.Forms.RichTextBox();
      this.Weight = new System.Windows.Forms.RichTextBox();
      this.output = new System.Windows.Forms.RichTextBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.rEADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aBOUTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.aBOUTToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.materialList = new System.Windows.Forms.DataGridView();
      this.meal = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.heavy = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Carories = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.materialList)).BeginInit();
      this.SuspendLayout();
      // 
      // AddButton
      // 
      this.AddButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.AddButton.Location = new System.Drawing.Point(17, 678);
      this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.AddButton.Name = "AddButton";
      this.AddButton.Size = new System.Drawing.Size(267, 62);
      this.AddButton.TabIndex = 0;
      this.AddButton.Text = "新增";
      this.AddButton.UseVisualStyleBackColor = true;
      this.AddButton.Click += new System.EventHandler(this.button1_Click);
      // 
      // DeleteButton
      // 
      this.DeleteButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.DeleteButton.Location = new System.Drawing.Point(292, 678);
      this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.DeleteButton.Name = "DeleteButton";
      this.DeleteButton.Size = new System.Drawing.Size(267, 62);
      this.DeleteButton.TabIndex = 1;
      this.DeleteButton.Text = "刪除";
      this.DeleteButton.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label1.Location = new System.Drawing.Point(108, 105);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(73, 30);
      this.label1.TabIndex = 2;
      this.label1.Text = "餐別";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label2.Location = new System.Drawing.Point(108, 349);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 30);
      this.label2.TabIndex = 3;
      this.label2.Text = "食材";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label3.Location = new System.Drawing.Point(48, 282);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(133, 30);
      this.label3.TabIndex = 4;
      this.label3.Text = "可食重量";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label4.Location = new System.Drawing.Point(48, 195);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(133, 30);
      this.label4.TabIndex = 5;
      this.label4.Text = "計算方式";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label5.Location = new System.Drawing.Point(48, 43);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(133, 30);
      this.label5.TabIndex = 6;
      this.label5.Text = "菜單名稱";
      this.label5.Click += new System.EventHandler(this.label5_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.groupBox1.Controls.Add(this.CaloriesRadio);
      this.groupBox1.Controls.Add(this.noneRadio);
      this.groupBox1.Location = new System.Drawing.Point(188, 177);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(300, 60);
      this.groupBox1.TabIndex = 7;
      this.groupBox1.TabStop = false;
      // 
      // menuBox
      // 
      this.menuBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.menuBox.Location = new System.Drawing.Point(188, 43);
      this.menuBox.Name = "menuBox";
      this.menuBox.Size = new System.Drawing.Size(200, 34);
      this.menuBox.TabIndex = 8;
      // 
      // mealBox
      // 
      this.mealBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.mealBox.FormattingEnabled = true;
      this.mealBox.Items.AddRange(new object[] {
            "早餐",
            "早點",
            "午餐",
            "午點",
            "晚餐",
            "晚點",
            "灌食"});
      this.mealBox.Location = new System.Drawing.Point(188, 102);
      this.mealBox.Name = "mealBox";
      this.mealBox.Size = new System.Drawing.Size(121, 33);
      this.mealBox.TabIndex = 10;
      // 
      // noneRadio
      // 
      this.noneRadio.AutoSize = true;
      this.noneRadio.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.noneRadio.Location = new System.Drawing.Point(6, 22);
      this.noneRadio.Name = "noneRadio";
      this.noneRadio.Size = new System.Drawing.Size(62, 26);
      this.noneRadio.TabIndex = 12;
      this.noneRadio.TabStop = true;
      this.noneRadio.Text = "預設";
      this.noneRadio.UseVisualStyleBackColor = true;
      // 
      // CaloriesRadio
      // 
      this.CaloriesRadio.AutoSize = true;
      this.CaloriesRadio.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.CaloriesRadio.Location = new System.Drawing.Point(144, 22);
      this.CaloriesRadio.Name = "CaloriesRadio";
      this.CaloriesRadio.Size = new System.Drawing.Size(96, 26);
      this.CaloriesRadio.TabIndex = 13;
      this.CaloriesRadio.TabStop = true;
      this.CaloriesRadio.Text = "依據熱量";
      this.CaloriesRadio.UseVisualStyleBackColor = true;
      // 
      // material
      // 
      this.material.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.material.Location = new System.Drawing.Point(188, 349);
      this.material.Name = "material";
      this.material.Size = new System.Drawing.Size(200, 30);
      this.material.TabIndex = 13;
      this.material.Text = "";
      // 
      // Weight
      // 
      this.Weight.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.Weight.Location = new System.Drawing.Point(188, 282);
      this.Weight.Name = "Weight";
      this.Weight.Size = new System.Drawing.Size(200, 30);
      this.Weight.TabIndex = 14;
      this.Weight.Text = "";
      // 
      // output
      // 
      this.output.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.output.Location = new System.Drawing.Point(17, 407);
      this.output.Name = "output";
      this.output.Size = new System.Drawing.Size(542, 207);
      this.output.TabIndex = 15;
      this.output.Text = "";
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEADToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1262, 30);
      this.menuStrip1.TabIndex = 16;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // rEADToolStripMenuItem
      // 
      this.rEADToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBOUTToolStripMenuItem1,
            this.aBOUTToolStripMenuItem2});
      this.rEADToolStripMenuItem.Name = "rEADToolStripMenuItem";
      this.rEADToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
      this.rEADToolStripMenuItem.Text = "READ";
      // 
      // aBOUTToolStripMenuItem1
      // 
      this.aBOUTToolStripMenuItem1.Name = "aBOUTToolStripMenuItem1";
      this.aBOUTToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
      this.aBOUTToolStripMenuItem1.Text = "README";
      this.aBOUTToolStripMenuItem1.Click += new System.EventHandler(this.aBOUTToolStripMenuItem1_Click);
      // 
      // aBOUTToolStripMenuItem2
      // 
      this.aBOUTToolStripMenuItem2.Name = "aBOUTToolStripMenuItem2";
      this.aBOUTToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
      this.aBOUTToolStripMenuItem2.Text = "ABOUT";
      this.aBOUTToolStripMenuItem2.Click += new System.EventHandler(this.aBOUTToolStripMenuItem2_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.tabControl1.Location = new System.Drawing.Point(570, 43);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(667, 525);
      this.tabControl1.TabIndex = 17;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.materialList);
      this.tabPage1.Location = new System.Drawing.Point(4, 28);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(659, 493);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "食材列表";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Location = new System.Drawing.Point(4, 28);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(659, 493);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "菜餚列表";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.chart1);
      this.tabPage3.Location = new System.Drawing.Point(4, 28);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(659, 493);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "統計圖表";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // tabPage4
      // 
      this.tabPage4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.tabPage4.Location = new System.Drawing.Point(4, 28);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage4.Size = new System.Drawing.Size(659, 493);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "tabPage4";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // chart1
      // 
      chartArea4.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea4);
      legend4.Name = "Legend1";
      this.chart1.Legends.Add(legend4);
      this.chart1.Location = new System.Drawing.Point(303, 8);
      this.chart1.Name = "chart1";
      series4.ChartArea = "ChartArea1";
      series4.Legend = "Legend1";
      series4.Name = "stocks";
      this.chart1.Series.Add(series4);
      this.chart1.Size = new System.Drawing.Size(300, 300);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      // 
      // materialList
      // 
      this.materialList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.materialList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
      this.materialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.materialList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.meal,
            this.menu,
            this.heavy,
            this.Carories});
      this.materialList.Location = new System.Drawing.Point(0, 0);
      this.materialList.Name = "materialList";
      this.materialList.RowHeadersWidth = 51;
      this.materialList.RowTemplate.Height = 27;
      this.materialList.Size = new System.Drawing.Size(659, 497);
      this.materialList.TabIndex = 0;
      // 
      // meal
      // 
      this.meal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.meal.HeaderText = "餐別";
      this.meal.MinimumWidth = 6;
      this.meal.Name = "meal";
      // 
      // menu
      // 
      this.menu.HeaderText = "菜單";
      this.menu.MinimumWidth = 6;
      this.menu.Name = "menu";
      // 
      // heavy
      // 
      this.heavy.HeaderText = "可食重量";
      this.heavy.MinimumWidth = 6;
      this.heavy.Name = "heavy";
      // 
      // Carories
      // 
      this.Carories.HeaderText = "熱量";
      this.Carories.MinimumWidth = 6;
      this.Carories.Name = "Carories";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1262, 753);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.output);
      this.Controls.Add(this.Weight);
      this.Controls.Add(this.material);
      this.Controls.Add(this.mealBox);
      this.Controls.Add(this.menuBox);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.DeleteButton);
      this.Controls.Add(this.AddButton);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.materialList)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.Button DeleteButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox menuBox;
    private System.Windows.Forms.ComboBox mealBox;
    private System.Windows.Forms.RadioButton noneRadio;
    private System.Windows.Forms.RadioButton CaloriesRadio;
    private System.Windows.Forms.RichTextBox material;
    private System.Windows.Forms.RichTextBox Weight;
    private System.Windows.Forms.RichTextBox output;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem rEADToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem2;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.DataGridView materialList;
    private System.Windows.Forms.DataGridViewTextBoxColumn meal;
    private System.Windows.Forms.DataGridViewTextBoxColumn menu;
    private System.Windows.Forms.DataGridViewTextBoxColumn heavy;
    private System.Windows.Forms.DataGridViewTextBoxColumn Carories;
  }
}

