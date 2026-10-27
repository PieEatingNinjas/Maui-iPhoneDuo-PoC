using System.Collections.ObjectModel;

namespace IphoneDuo_PoC;

public partial class ItemsPage : ContentPage
{
	public ObservableCollection<ItemEntry> Items { get; } = new(
		Enumerable.Range(1, 50)
			.Select(number => new ItemEntry(number, $"Item {number:00}", $"Description for item {number:00}.")));

	public ItemsPage()
	{
		InitializeComponent();
		BindingContext = this;
	}
}

public sealed record ItemEntry(int Number, string Title, string Description);