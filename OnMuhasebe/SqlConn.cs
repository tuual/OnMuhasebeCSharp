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
        public SqlConnection sqlConnection = new SqlConnection("Server=192.168.2.208;Database=OnMuhasebe;User Id=biltekbilisim;Password=Bilisim20037816");
        
    }
}
