using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OctupsCenter.Types
{
    public partial class frmTypes : Form
    {
        public frmTypes()
        {
            InitializeComponent();
            
              var typeList = new List<TripType>();
            typeList.Add(new TripType() { TypeId = 1, TypeName = "Test" });
            typeList.Add(new TripType() { TypeId = 2, TypeName = "Test1" });
            typeList.Add(new TripType() { TypeId = 3, TypeName = "Test2" });
            typeList.Add(new TripType() { TypeId = 4, TypeName = "Test3" });
            typeList.Add(new TripType() { TypeId = 5, TypeName = "Test3ee" });
            typeList.Add(new TripType() { TypeId = 6, TypeName = "Test3e1" });
            typeList.Add(new TripType() { TypeId = 7, TypeName = "Test3e" });
            typeList.Add(new TripType() { TypeId = 8, TypeName = "Test3w" });
            typeList.Add(new TripType() { TypeId = 9, TypeName = "Test3q" });
            typeList.Add(new TripType() { TypeId = 10, TypeName = "Test11" });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
    public class TripType
    {
        public int TypeId { set; get; }
        public string TypeName { set; get; }
    }
}
