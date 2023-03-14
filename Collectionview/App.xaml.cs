namespace Collectionview;
using View;
public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ClothStoreView();
	}
}
