using CollectionViewLesson.ViewModels;

namespace CollectionViewLesson.Views;

public partial class StudentsWithContextMenuView : ContentPage
{
	public StudentsWithContextMenuView()
	{
		InitializeComponent();
        BindingContext = new StudentsViewModel();
    }
}