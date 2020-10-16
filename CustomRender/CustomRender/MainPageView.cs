using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomRender
{
	public   class MainPageView : ContentPage
	{
        public MainPageView()       
		{
			Content = new StackLayout
			{
				Children = {
					new Label {
						//Text = "First Name",
					},
					new MyEntry {
					

					}
				},
				VerticalOptions = LayoutOptions.CenterAndExpand,
				//HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
		}
	}
}
