using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace foodBudget2018
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{

            InitializeComponent();
            new MainPage();		}

       /* when you click the Add Recipe button; this returns the Add Recipe view  */
        async void recipeAdd(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new recipeAdd());
                }
       
    }
}
