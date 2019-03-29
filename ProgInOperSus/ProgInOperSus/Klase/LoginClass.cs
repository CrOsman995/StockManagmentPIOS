using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgInOperSus.Klase
{
    public class LoginClass
    {
        public Guid LoginId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Oib { get; set; }
        public string Uloga { get; set; }

        public bool PostojiLiZapis(string Username,string Password)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6BQCTSM\KITERON;Initial Catalog=New;Integrated Security=True");
            string query = "Select 1 from LoginUser where Username='" + Username + "' and Password ='" + Password.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count==1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Provjerite podatke još jednom!!");
                return false;
            }
           
        }
    }

   
}
  