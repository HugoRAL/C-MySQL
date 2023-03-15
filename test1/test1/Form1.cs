using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace test1
{
    public partial class Form1 : Form
    {
        public static MySqlConnection Conexao;//conexao
        public static MySqlCommand Comando;//comandos
        public static MySqlDataAdapter Adaptador;//inserir dados numa tabela
        public static DataTable datTabela;//ligar a db em controlos com prop de DataSource
        public Form1()
        {
            InitializeComponent();
        }

        int op = 0;
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case 0:
                    LabelSus.Text = Global.Add(BoxName.Text, BoxPass.Text);
                    break;
                case 1:
                    LabelSus.Text = Global.Update(BoxName.Text, BoxPass.Text, int.Parse(TBID.Text));
                    break;
                case 2:
                    LabelSus.Text = Global.Remove(int.Parse(TBID.Text));
                    break;
                default:
                    LabelSus.Text = "erro";
                    break;

            }
            LabelSus.ForeColor = "sucesso" == LabelSus.Text ? Color.Green : Color.Red;
            Dados.DataSource = Global.Data();

        }

        private void BntInsert_Click(object sender, EventArgs e)
        {
            op = 0;
            TBID.Hide();
            LabelID.Hide();
            BoxName.Show();
            LabelName.Show();
            BoxPass.Show();
            labelPass.Show();


            BntInsert.BackColor = Color.Gray;
            BntRemove.BackColor = Color.LightGray;
            BntUpdate.BackColor = Color.LightGray;   
        }

        private void BntUpdate_Click(object sender, EventArgs e)
        {
            op = 1;

            TBID.Show();
            LabelID.Show();
            BoxName.Show();
            LabelName.Show();
            BoxPass.Show();
            labelPass.Show();


            BntInsert.BackColor = Color.LightGray;
            BntRemove.BackColor = Color.LightGray;
            BntUpdate.BackColor = Color.Gray;
        }

        private void BntRemove_Click(object sender, EventArgs e)
        {
            op = 2;

            TBID.Show();
            LabelID.Show();
            BoxName.Hide();
            LabelName.Hide();
            BoxPass.Hide();
            labelPass.Hide();

            BntInsert.BackColor = Color.LightGray;
            BntRemove.BackColor = Color.Gray;
            BntUpdate.BackColor = Color.LightGray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dados.DataSource = Global.Data();
            op = 3;
            LabelSus.Text = "";
            BntInsert.BackColor = Color.LightGray;
            BntRemove.BackColor = Color.LightGray;
            BntUpdate.BackColor = Color.LightGray;
            TBID.Hide();
            LabelID.Hide();
            BoxName.Hide();
            LabelName.Hide();
            BoxPass.Hide();
            labelPass.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
