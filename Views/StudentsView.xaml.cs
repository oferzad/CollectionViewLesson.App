using CollectionViewLesson.ViewModels;

namespace CollectionViewLesson.Views;

public partial class StudentsView : ContentPage
{
	public StudentsView()
	{
		InitializeComponent();
		BindingContext = new StudentsViewModel();
	}
}