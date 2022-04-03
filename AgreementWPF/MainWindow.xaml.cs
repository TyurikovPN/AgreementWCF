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
using ServiceReference1;
using System.Collections;

namespace AgreementWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            AgreementServiceClient asc = new AgreementServiceClient();
            InitializeComponent();
            List<Agreements> agreements = asc.FindAll();
            List<AgreementRow> agreementRows = new List <AgreementRow>();            
            for (int i = 0; i < agreements.Count(); i++)
            {
                if (agreements[i].DateUpdate > DateTime.Today.AddDays (-60))
                {
                    agreementRows.Add(new AgreementRow() { Id = agreements[i].Id, DateCreate = agreements[i].DateCreate, DateUpdate = agreements[i].DateUpdate, IsChecked = true });
                }
                else
                {
                    agreementRows.Add(new AgreementRow() { Id = agreements[i].Id, DateCreate = agreements[i].DateCreate, DateUpdate = agreements[i].DateUpdate, IsChecked = false });
                }                
            }

            DataGridAgreement.ItemsSource = agreementRows;
        }
        public class AgreementRow
        {
            public int Id { get; set; }
            public DateTime DateCreate { get; set; }
            public DateTime DateUpdate { get; set; }
            public bool IsChecked { get; set; }
        }
    }
}
