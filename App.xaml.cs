namespace CollectionViewLesson;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		//MainPage = new Views.StudentsView();
		//MainPage = new Views.StudentsWithSelection();
		//MainPage = new Views.StudentsWithContextMenuView();
        MainPage = new Views.StudentsWithRefresh();
	}
}
