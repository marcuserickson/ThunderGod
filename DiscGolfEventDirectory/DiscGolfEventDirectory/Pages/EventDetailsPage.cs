using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DiscGolfEventDirectory
{
	public class EventDetailsPage : ContentPage
	{
		public EventDetailsPage()
		{

            this.SetBinding(ContentPage.TitleProperty, "Name");

            NavigationPage.SetHasNavigationBar(this, true);
            var nameLabel = new Label { Text = "Name:" };
            var nameDetails = new Label();
            nameDetails.SetBinding(Label.TextProperty, "Name");

            var typeLabel = new Label { Text = "Type:" };
            var typeDetails = new Label();
            typeDetails.SetBinding(Label.TextProperty, "Type");
            var dataLabel = new Label { Text = "Date:" };
            var dataDetails = new Label();
            dataDetails.SetBinding(Label.TextProperty, "Date");
            var addrLabel = new Label { Text = "Address:" };
            var addrDetails = new Label();
            addrDetails.SetBinding(Label.TextProperty, "Address");
            var infoLabel = new Label { Text = "Information:" };
            var infoDetails = new Label();
            infoDetails.SetBinding(Label.TextProperty, "Information");
            Content = new StackLayout {
				Children = {
					nameLabel,nameDetails,
                    typeLabel,typeDetails,
                    dataLabel,dataDetails,
                    addrLabel,addrDetails,
                    infoLabel,infoDetails
				}
			};
		}
	}
}
