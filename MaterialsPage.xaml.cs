using ADONETpractice.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ADONETpractice
{
    /// <summary>
    /// Логика взаимодействия для MaterialsPage.xaml
    /// </summary>
    public partial class MaterialsPage : Page
    {
        adonetpracticeEntities entities = new adonetpracticeEntities();
        public MaterialsPage()
        {
            InitializeComponent();

            

        }
        protected override void OnInitialized(EventArgs e)
        {
            materialsLV.ItemsSource = entities.Material.ToList();
            base.OnInitialized(e);
        }
    }
}
