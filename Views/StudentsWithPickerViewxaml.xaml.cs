using CollectionViewLesson.ViewModels;

namespace CollectionViewLesson.Views;

public partial class StudentsWithPickerViewxaml : ContentPage
{
	public StudentsWithPickerViewxaml()
	{
		InitializeComponent();
		this.BindingContext = new StudentsViewModel();
	}
}