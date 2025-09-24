# Disable selection for particular items

The selection of a particular set of items can be disabled based on the [SfListView.SelectedItems](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~SelectedItems.html) of the underlying collections.

## Sample

```xaml
<listView:SfListView x:Name="listView" ItemSize="70" ItemsSource="{Binding contactsinfo}" 
                      ItemSpacing="0,0,5,0" SelectionMode="Multiple">
    <listView:SfListView.Behaviors>
        <local:Behavior/>
    </listView:SfListView.Behaviors>
    
    <listView:SfListView.ItemTemplate>
        <DataTemplate>
            <ViewCell>
                <ViewCell.View>
                    <code>
                    . . .
                    . . .
                    <code>
                </ViewCell.View>
            </ViewCell>
        </DataTemplate>
    </listView:SfListView.ItemTemplate>
</listView:SfListView>
```

```
public partial class MainPage : ContentPage
{
  public MainPage()
  {
    InitializeComponent();
  }

  private void listView_SelectionChanging(object sender, Syncfusion.ListView.XForms.ItemSelectionChangingEventArgs e)
  {
  if (e.AddedItems.Count > 0 && (e.AddedItems[0] as Contacts).Category == "Non-Selectable items")
      e.Cancel = true;
  }
}
```

To know more about the Selection in ListView, please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/selection)