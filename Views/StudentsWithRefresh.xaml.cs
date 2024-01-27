using CollectionViewLesson.ViewModels;

namespace CollectionViewLesson.Views;

public partial class StudentsWithRefresh : ContentPage
{
	public StudentsWithRefresh()
	{
		InitializeComponent();
		BindingContext = new StudentsViewModel();
	}
}