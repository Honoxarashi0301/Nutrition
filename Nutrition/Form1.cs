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

using System.Data.SQLite;

namespace Nutrition
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      Load_DB();
      Show_DB();
      this.label5.Text = index.ToString();
    }
    int index = 1;

    public class DBConfig
    {
      //log.db要放在【bin\Debug底下】      
      public static string dbFile = Application.StartupPath + @"\log.db";

      public static string dbPath = "Data source=" + dbFile;

      public static SQLiteConnection sqlite_connect;
      public static SQLiteCommand sqlite_cmd;
      public static SQLiteDataReader sqlite_datareader;
    }

    private void Load_DB()
    {
      DBConfig.sqlite_connect = new SQLiteConnection(DBConfig.dbPath);
      DBConfig.sqlite_connect.Open();// Open

    }

    private void Show_DB()
    {
      this.materialList.Rows.Clear();

      string sql = @"SELECT * from record;";
      DBConfig.sqlite_cmd = new SQLiteCommand(sql, DBConfig.sqlite_connect);
      DBConfig.sqlite_datareader = DBConfig.sqlite_cmd.ExecuteReader();

      if (DBConfig.sqlite_datareader.HasRows)
      {
        while (DBConfig.sqlite_datareader.Read()) //read every data
        {
          int _serial = Convert.ToInt32(DBConfig.sqlite_datareader["serial"]);
          int _date = Convert.ToInt32(DBConfig.sqlite_datareader["date"]);
          int _type = Convert.ToInt32(DBConfig.sqlite_datareader["type"]);
          string _name = Convert.ToString(DBConfig.sqlite_datareader["name"]);
          double _price = Convert.ToDouble(DBConfig.sqlite_datareader["price"]);
          double _number = Convert.ToDouble(DBConfig.sqlite_datareader["number"]);
          double _total = _price * _number;

          string _date_str = DateTimeOffset.FromUnixTimeSeconds(_date).ToString("yy-MM-dd hh:mm:ss");

          string _type_str = "";
          if (_type == 1)
          { _type_str = "預設"; }
          else { _type_str = "依據熱量"; }

          index = _serial;
          DataGridViewRowCollection rows = materialList.Rows;
          rows.Add(new Object[] { index, _date_str, _type_str, _name, _price, _number
                                               , _total });
        }
        DBConfig.sqlite_datareader.Close();
      }
    }

    private void dataGridView1_CellDoubleClick(object sender
                                                                   , DataGridViewCellEventArgs e)
    {

      DataGridViewCellCollection selRowData = materialList.Rows[e.RowIndex].Cells;

      string _type = "";
      _type = Convert.ToString(selRowData[2].Value);

      if (_type.Equals("預設"))
      {
        noneRadio.Checked = true;
      }
      else
      {
        CaloriesRadio.Checked = true;
      }


      this.mealBox.Text = Convert.ToString(selRowData[3].Value);
      this.noneRadio.Text = Convert.ToString(selRowData[4].Value);
      this.Weight.Text = Convert.ToString(selRowData[5].Value);

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
      MessageBox.Show("今天我們講中文");
      MessageBox.Show("大家好");
    }

    private void tabPage2_Click(object sender, EventArgs e)
    {

    }

    private void materialList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
