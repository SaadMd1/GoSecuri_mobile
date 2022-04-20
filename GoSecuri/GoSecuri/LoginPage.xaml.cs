using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoSecuri
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
     
        public LoginPage()
        {
            InitializeComponent();
        }

       /* public static SqlConnection ocon = new SqlConnection(@"Data Source=DESKTOP-37FSTD5\SQLEXPRESS;Initial Catalog=GoSecuri;Integrated Security=false");
        public static SqlCommand ocmd = new SqlCommand();
        public static SqlDataReader odr;
        //public static DataTable odt = new DataTable();

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            ocon.Open();
            ocmd.Connection = ocon;
            ocmd.CommandText = "select pwd from agents where nom='" + txtNom.Text + "'";
            if (txtNom.Text == ocmd.ExecuteScalar().ToString())
            {
                Application.Current.Properties["Name"] = txtNom.Text;
                Navigation.PushAsync(new LoginPage());
            }
            ocon.Close();

        }

        private void btnLogin_BindingContextChanged(object sender, EventArgs e)
        {

        }*/
    }
}