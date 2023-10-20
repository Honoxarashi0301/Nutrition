using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Nutrition
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string WeightInput = Weight.Text;
      string MaterialInput = material.Text;
      string MenuInput = menuBox.Text; 
      double WeightDouble = Convert.ToDouble(WeightInput);
      //double CaroriesDouble = WeightDouble * ;

      // radio
      string RadioButtonLog = "";
      if (noneRadio.Checked == true)
      {
        RadioButtonLog = "無特定計算";
      }
      else if (CaloriesRadio.Checked == true) 
      {
        RadioButtonLog = "依據熱量計算";
      }

      // 下拉式
      string MealBoxLog = mealBox.SelectedItem.ToString();

      DataGridViewRowCollection rows = materialList.Rows;
      // DateTime date = DateTime.Now; // 現在時間
      rows.Add(new Object[] { MealBoxLog, MenuInput , WeightDouble ,});


      output.Text = String.Format("餐別：{2}\n菜單：{3}\n{1}的重量為: {0} 公克 ", WeightDouble, MaterialInput, MealBoxLog, MenuInput);

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void aBOUTToolStripMenuItem1_Click(object sender, EventArgs e)
    {

    }

    private void aBOUTToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      MessageBox.Show("This is about");
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      MessageBox.Show("hello world");
    }
  }
}
