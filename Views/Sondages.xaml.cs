using firstMobileApp.Models;

namespace firstMobileApp.Views;

public partial class Sondages : ContentPage
{
	public Sondages()
	{
		InitializeComponent();

        // Cr�er une instance de votre ViewModel
        SondagesModel sondagesModel = new SondagesModel();

        // D�finir le BindingContext sur votre ViewModel
        BindingContext = sondagesModel;
    }
}