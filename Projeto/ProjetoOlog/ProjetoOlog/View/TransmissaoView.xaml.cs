using ProjetoOlog.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace ProjetoOlog
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TransmissaoView : Page
    {
        ControladorTransmissao transmissao;
        bool Transmitindo;
        public TransmissaoView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btnTransmissaoClick(object sender, RoutedEventArgs e)
        {
            if (this.Transmitindo)
            {
                PararTransmissao();
                btnTransmissao.Content = "Inciar Transmissão";
            }
            else
            {
                IniciarTransmissao();
                btnTransmissao.Content = "Parar Transmissão";
            }
        }

        private void IniciarTransmissao() {
            //controlador
            this.Transmitindo = true;
        }

        private void PararTransmissao() {
            //controlador
            this.Transmitindo = false;
        }
    }
}
