using System.Linq;
using System.Windows.Forms;

namespace DoAn.Forms
{
    public partial class FormMakeListGetMedicine : Form
    {
        public FormMakeListGetMedicine()
        {
            InitializeComponent();
        }

        private void InitializeData()
        {
            using (var db = new DataPKEntities())
            {
                var medicine = from s in db.THUOCs
                               select s;

            }
        }

    }
}
