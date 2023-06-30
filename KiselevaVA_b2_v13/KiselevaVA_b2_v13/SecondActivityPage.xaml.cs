using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KiselevaVA_b2_v13
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondActivityPage :ContentPage
    {
        public SecondActivityPage ()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

    }
}