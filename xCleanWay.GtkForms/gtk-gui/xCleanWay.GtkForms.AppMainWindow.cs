
// This file has been generated by the GUI designer. Do not modify.
namespace xCleanWay.GtkForms
{
	public partial class AppMainWindow
	{
		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget xCleanWay.GtkForms.AppMainWindow
			this.Name = "xCleanWay.GtkForms.AppMainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		}
	}
}
