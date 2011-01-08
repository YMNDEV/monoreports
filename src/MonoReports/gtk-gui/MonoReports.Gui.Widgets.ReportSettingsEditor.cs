
// This file has been generated by the GUI designer. Do not modify.
namespace MonoReports.Gui.Widgets
{
	public partial class ReportSettingsEditor
	{
		private global::Gtk.VPaned vpaned1;
		private global::PropertyGrid.PropertyGrid reportPropertygrid;
		private global::PropertyGrid.PropertyGrid settingsPeportPropertygrid;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoReports.Gui.Widgets.ReportSettingsEditor
			this.Name = "MonoReports.Gui.Widgets.ReportSettingsEditor";
			this.Title = global::Mono.Unix.Catalog.GetString ("Report Settings");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child MonoReports.Gui.Widgets.ReportSettingsEditor.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vpaned1 = new global::Gtk.VPaned ();
			this.vpaned1.CanFocus = true;
			this.vpaned1.Name = "vpaned1";
			this.vpaned1.Position = 279;
			// Container child vpaned1.Gtk.Paned+PanedChild
			this.reportPropertygrid = new global::PropertyGrid.PropertyGrid ();
			this.reportPropertygrid.Name = "reportPropertygrid";
			this.reportPropertygrid.ShowToolbar = false;
			this.reportPropertygrid.ShowHelp = false;
			this.vpaned1.Add (this.reportPropertygrid);
			global::Gtk.Paned.PanedChild w2 = ((global::Gtk.Paned.PanedChild)(this.vpaned1 [this.reportPropertygrid]));
			w2.Resize = false;
			// Container child vpaned1.Gtk.Paned+PanedChild
			this.settingsPeportPropertygrid = new global::PropertyGrid.PropertyGrid ();
			this.settingsPeportPropertygrid.Name = "settingsPeportPropertygrid";
			this.settingsPeportPropertygrid.ShowToolbar = false;
			this.settingsPeportPropertygrid.ShowHelp = false;
			this.vpaned1.Add (this.settingsPeportPropertygrid);
			w1.Add (this.vpaned1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(w1 [this.vpaned1]));
			w4.PackType = ((global::Gtk.PackType)(1));
			w4.Position = 1;
			// Internal child MonoReports.Gui.Widgets.ReportSettingsEditor.ActionArea
			global::Gtk.HButtonBox w5 = this.ActionArea;
			w5.Name = "dialog1_ActionArea";
			w5.Spacing = 10;
			w5.BorderWidth = ((uint)(5));
			w5.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w6 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5 [this.buttonCancel]));
			w6.Expand = false;
			w6.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w7 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5 [this.buttonOk]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 517;
			this.DefaultHeight = 504;
			this.Show ();
		}
	}
}
