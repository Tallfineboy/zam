using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zam
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarouselView : ContentPage
	{
		public CarouselView ()
		{
			InitializeComponent ();
		}
	}
}