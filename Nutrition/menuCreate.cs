using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutrition
{
  public partial class menuCreate : Form
  {
    public menuCreate()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void menuCreate_Load(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      dishesList dishesList;
      dishesList = new dishesList();

      // 會鎖定這個頁面，開啟下一個頁面
      dishesList.ShowDialog();

    }
  }
}
