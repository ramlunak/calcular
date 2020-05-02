using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calcular
{

    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            SumarCUC();
        }

        private void Entry_TextChangedCUP(object sender, TextChangedEventArgs e)
        {
            SumarCUP();
        }

        #region

        public void SumarCUC()
        {
            decimal vcuc = 0; try { vcuc = decimal.Parse(ValorCUC.Text.Replace(".", ",")); } catch { }
            decimal v100cuc = 0; try { v100cuc = decimal.Parse(C100CUC.Text.Replace(".", ",")) * 100; } catch { }
            decimal v50cuc = 0; try { v50cuc = decimal.Parse(C50CUC.Text.Replace(".", ",")) * 50; } catch { }
            decimal v20cuc = 0; try { v20cuc = decimal.Parse(C20CUC.Text.Replace(".", ",")) * 20; } catch { }
            decimal v10cuc = 0; try { v10cuc = decimal.Parse(C10CUC.Text.Replace(".", ",")) * 10; } catch { }
            decimal v5cuc = 0; try { v5cuc = decimal.Parse(C5CUC.Text.Replace(".", ",")) * 5; } catch { }
            decimal v3cuc = 0; try { v3cuc = decimal.Parse(C3CUC.Text.Replace(".", ",")) * 3; } catch { }
            decimal v1cuc = 0; try { v1cuc = decimal.Parse(C1CUC.Text.Replace(".", ",")) * 1; } catch { }
            decimal v050cuc = 0; try { v050cuc = decimal.Parse(C050CUC.Text.Replace(".", ",")) * decimal.Parse("0,50"); } catch { }
            decimal v025cuc = 0; try { v025cuc = decimal.Parse(C025CUC.Text.Replace(".", ",")) * decimal.Parse("0,25"); } catch { }
            decimal v010cuc = 0; try { v010cuc = decimal.Parse(C010CUC.Text.Replace(".", ",")) * decimal.Parse("0,10"); } catch { }
            decimal v005cuc = 0; try { v005cuc = decimal.Parse(C005CUC.Text.Replace(".", ",")) * decimal.Parse("0,05"); } catch { }

            if (v100cuc > 0)
                LC100CUC.Text = "= $" + v100cuc.ToString();
            else LC100CUC.Text = string.Empty;
            if (v50cuc > 0)
                LC50CUC.Text = "= $" + v50cuc.ToString();
            else LC50CUC.Text = string.Empty;
            if (v20cuc > 0)
                LC20CUC.Text = "= $" + v20cuc.ToString();
            else LC20CUC.Text = string.Empty;
            if (v10cuc > 0)
                LC10CUC.Text = "= $" + v10cuc.ToString();
            else LC10CUC.Text = string.Empty;
            if (v5cuc > 0)
                LC5CUC.Text = "= $" + v5cuc.ToString();
            else LC5CUC.Text = string.Empty;
            if (v3cuc > 0)
                LC3CUC.Text = "= $" + v3cuc.ToString();
            else LC3CUC.Text = string.Empty;
            if (v1cuc > 0)
                LC1CUC.Text = "= $" + v1cuc.ToString();
            else LC1CUC.Text = string.Empty;
            if (v050cuc > 0)
                LC050CUC.Text = "= $" + v050cuc.ToString();
            else LC050CUC.Text = string.Empty;
            if (v010cuc > 0)
                LC010CUC.Text = "= $" + v010cuc.ToString();
            else LC010CUC.Text = string.Empty;
            if (v025cuc > 0)
                LC025CUC.Text = "= $" + v025cuc.ToString();
            else LC025CUC.Text = string.Empty;
            if (v005cuc > 0)
                LC005CUC.Text = "= $" + v005cuc.ToString();
            else LC005CUC.Text = string.Empty;

            TotalParcialCUC.Text = "$ " + (vcuc + v100cuc + v50cuc + v20cuc + v10cuc + v5cuc + v3cuc + v1cuc + v050cuc + v010cuc + v025cuc + v005cuc).ToString() + " CUC";

            calcularTotalCUC();
            calcularTotalCUP();

        }

        public void SumarCUP()
        {
            decimal vcup = 0; try { vcup = decimal.Parse(ValorCUP.Text.Replace(".", ",")); } catch { }
            decimal v1000cup = 0; try { v1000cup = decimal.Parse(C1000CUP.Text.Replace(".", ",")) * 1000; } catch { }
            decimal v500cup = 0; try { v500cup = decimal.Parse(C500CUP.Text.Replace(".", ",")) * 500; } catch { }
            decimal v200cup = 0; try { v200cup = decimal.Parse(C200CUP.Text.Replace(".", ",")) * 200; } catch { }
            decimal v100cup = 0; try { v100cup = decimal.Parse(C100CUP.Text.Replace(".", ",")) * 100; } catch { }
            decimal v50cup = 0; try { v50cup = decimal.Parse(C50CUP.Text.Replace(".", ",")) * 50; } catch { }
            decimal v20cup = 0; try { v20cup = decimal.Parse(C20CUP.Text.Replace(".", ",")) * 20; } catch { }
            decimal v10cup = 0; try { v10cup = decimal.Parse(C10CUP.Text.Replace(".", ",")) * 10; } catch { }
            decimal v5cup = 0; try { v5cup = decimal.Parse(C5CUP.Text.Replace(".", ",")) * 5; } catch { }
            decimal v3cup = 0; try { v3cup = decimal.Parse(C3CUP.Text.Replace(".", ",")) * 3; } catch { }
            decimal v1cup = 0; try { v1cup = decimal.Parse(C1CUP.Text.Replace(".", ",")) * 1; } catch { }
            decimal v020cup = 0; try { v020cup = decimal.Parse(C020CUP.Text.Replace(".", ",")) * decimal.Parse("0,20"); } catch { }

            if (v1000cup > 0)
                LC1000CUP.Text = "= $" + v1000cup.ToString();
            else LC1000CUP.Text = string.Empty;
            if (v500cup > 0)
                LC500CUP.Text = "= $" + v500cup.ToString();
            else LC500CUP.Text = string.Empty;
            if (v200cup > 0)
                LC200CUP.Text = "= $" + v200cup.ToString();
            else LC200CUP.Text = string.Empty;
            if (v100cup > 0)
                LC100CUP.Text = "= $" + v100cup.ToString();
            else LC100CUP.Text = string.Empty;
            if (v50cup > 0)
                LC50CUP.Text = "= $" + v50cup.ToString();
            else LC50CUP.Text = string.Empty;
            if (v20cup > 0)
                LC20CUP.Text = "= $" + v20cup.ToString();
            else LC20CUP.Text = string.Empty;
            if (v10cup > 0)
                LC10CUP.Text = "= $" + v10cup.ToString();
            else LC10CUP.Text = string.Empty;
            if (v5cup > 0)
                LC5CUP.Text = "= $" + v5cup.ToString();
            else LC5CUP.Text = string.Empty;
            if (v3cup > 0)
                LC3CUP.Text = "= $" + v3cup.ToString();
            else LC3CUP.Text = string.Empty;
            if (v1cup > 0)
                LC1CUP.Text = "= $" + v1cup.ToString();
            else LC1CUP.Text = string.Empty;
            if (v020cup > 0)
                LC020CUP.Text = "= $" + v020cup.ToString();
            else LC020CUP.Text = string.Empty;

            TotalParcialCUP.Text = "$ " + (vcup + v1000cup + v500cup + v200cup + v100cup + v50cup + v20cup + v10cup + v5cup + v3cup + v1cup + v020cup).ToString() + " CUP";

            calcularTotalCUC();
            calcularTotalCUP();
        }

        public void calcularTotalCUC()
        {
            decimal tcuc = 0;

            try
            {
                tcuc = decimal.Parse(TotalParcialCUP.Text.Replace("$", "").Replace(" ", "").Replace("C", "").Replace("U", "").Replace("P", "").Trim()) / 25;
            }
            catch
            {


            }

            try
            {
                TotalCUC.Text = "$ " + (decimal.Parse(TotalParcialCUC.Text.Replace("$", "").Replace(" ", "").Replace("C", "").Replace("U", "").Replace("P", "").Trim()) + tcuc).ToString() + " CUC";
            }
            catch
            {
                TotalCUC.Text = "$ " + tcuc.ToString() + " CUC";
            }

        }

        public void calcularTotalCUP()
        {
            decimal tcup = 0;

            try
            {
                tcup = 25 * decimal.Parse(TotalParcialCUC.Text.Replace("$", "").Replace(" ", "").Replace("C", "").Replace("U", "").Replace("P", "").Trim());
            }
            catch
            {


            }

            try
            {
                TotalCUP.Text = "$ " + (decimal.Parse(TotalParcialCUP.Text.Replace("$", "").Replace(" ", "").Replace("C", "").Replace("U", "").Replace("P", "").Trim()) + tcup).ToString() + " CUP";
            }
            catch
            {
                TotalCUP.Text = "$ " + tcup.ToString() + " CUP";
            }

        }

        #endregion
    }
}
