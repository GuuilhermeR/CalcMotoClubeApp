using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMotoClube
{
    public partial class frmCalculadora : MaterialSkin.Controls.MaterialForm
    {
        public frmCalculadora()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Cyan400, Primary.Cyan500,
                Primary.Cyan600, Accent.Cyan100,
                TextShade.WHITE
            );

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtPassaporte.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtBau.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtMecanico.Text = string.Empty;
            chkBooster.Checked = false;
            Clipboard.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassaporte.Text))
            {
                MessageBox.Show("Favor informar o passaporte para realizar o cálculo.");
                return;
            }

            double PCT_VAL_BAU = 35;
            double PCT_VAL_CLI = 35;
            double PCT_VAL_MEC = 30;
            double PCT_EXT_PARCEIRO = 5;
            double PCT_EXT_BOOSTER = 5;
            double PCT_EXT_ALIANCA = 15;
            double VAL_TOTAL = Convert.ToDouble(txtTotal.Text);

            if (cbxParceria.SelectedIndex == 1)
            {
                PCT_VAL_MEC -= PCT_EXT_PARCEIRO;
                PCT_VAL_CLI += PCT_EXT_PARCEIRO;
            }
            else if (cbxParceria.SelectedIndex == 2)
            {
                PCT_VAL_MEC -= PCT_EXT_ALIANCA;
                PCT_VAL_CLI += PCT_EXT_ALIANCA;
            }

            if (chkBooster.Checked)
            {
                PCT_VAL_BAU -= PCT_EXT_BOOSTER;
                PCT_VAL_MEC += PCT_EXT_BOOSTER;
            }

            txtBau.Text = Convert.ToString((VAL_TOTAL / 100) * PCT_VAL_BAU);
            txtCliente.Text = Convert.ToString((VAL_TOTAL / 100) * PCT_VAL_CLI);
            txtMecanico.Text = Convert.ToString((VAL_TOTAL / 100) * PCT_VAL_MEC);
            string Texto = string.Empty;

            if (chkBooster.Checked)
            {
                Texto = $@"**Nº:**
**Passaporte:** {txtPassaporte.Text}
**Valor Baú:** {txtBau.Text}
**Valor Cliente:** {txtCliente.Text}
***Valor Mecânico:*** {txtMecanico.Text}
**Valor Total:** {VAL_TOTAL}";
            }
            else
            {
                Texto = $@"**Nº:**
**Passaporte:** {txtPassaporte.Text}
**Valor Baú:** {txtBau.Text}
**Valor Cliente:** {txtCliente.Text}
**Valor Mecânico:** {txtMecanico.Text}
**Valor Total:** {VAL_TOTAL}";
            }
            

            DataObject dataObj = new DataObject();
            dataObj.SetData(DataFormats.StringFormat, Texto);
            if (Clipboard.ContainsImage())
            {
                //dataObj.SetData(DataFormats.StringFormat, Clipboard.GetImage());
            }
            Clipboard.SetDataObject(dataObj);
        }
    }
}
