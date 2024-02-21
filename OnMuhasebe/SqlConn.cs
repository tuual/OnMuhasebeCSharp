using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace OnMuhasebe
{
    class  SqlConn
    {
        public SqlConnection sqlConnection = new SqlConnection("Server=;Database=OnMuhasebe;User Id=;Password=");
   
    }
}
