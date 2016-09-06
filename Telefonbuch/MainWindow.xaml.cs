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

namespace Telefonbuch
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSpeichern_Click(object sender, RoutedEventArgs e)
        {
            this.tbEintrag.Text += TextSpeichern(this.btnSpeichern.Name);
        }
        string TextSpeichern(string sKnopf)
        {
           
            return sKnopf + "\n" + "Vorname: " + this.tbVorname.Text + "\nName: " + this.tbName.Text + "\nTelefonnummer: " + this.tbTeleNum.Text + "\n\n";
        }

        private void btnLoeschen_Click(object sender, RoutedEventArgs e)
        {
            if (this.cbAlles.IsChecked == true)
            {
                MessageBoxResult MR = MessageBox.Show("Wirklich alles Löschen?", "Löschen?", MessageBoxButton.YesNo, MessageBoxImage.Warning,MessageBoxResult.No);

                if (MR == MessageBoxResult.Yes)
                {
                    DeleteAlles();
                }
            }
            else
            {
                DeleteOben();
                
            }
        }
        void DeleteOben()
        {
            this.tbName.Text = "";
            this.tbVorname.Text = "";
            this.tbTeleNum.Text = "";
        }
        void DeleteAlles()
        {
            this.tbName.Text = "";
            this.tbVorname.Text = "";
            this.tbTeleNum.Text = "";
            this.tbEintrag.Text = "";
        }
    }
}
