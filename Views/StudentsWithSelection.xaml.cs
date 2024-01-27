using CollectionViewLesson.ViewModels;

namespace CollectionViewLesson.Views;

public partial class StudentsWithSelection : ContentPage
{
	public StudentsWithSelection()
	{
		InitializeComponent();
		BindingContext = new StudentsViewModel();
	}
}