using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SfListViewSample
{
   public class Behavior : Behavior<SfListView>
    {
        SfListView ListView;
        protected override void OnAttachedTo(SfListView bindable)
        {
            ListView = bindable;
            ListView.SelectionChanging += ListView_SelectionChanging;
            base.OnAttachedTo(bindable);
        }

        private void ListView_SelectionChanging(object sender, ItemSelectionChangingEventArgs e)
        {
          if (e.AddedItems.Count > 0 && (e.AddedItems[0] as Contacts).Category == "Non-Selectable items")
          {
             e.Cancel = true;
          }
        }

        protected override void OnDetachingFrom(SfListView bindable)
        {
            ListView.SelectionChanging += ListView_SelectionChanging;
            base.OnDetachingFrom(bindable);
        }
    }
}
