
// This file has been generated by the GUI designer. Do not modify.
namespace MonoReports.Gui.Widgets
{
	public partial class PreferencesEditor
	{
		private global::Gtk.Notebook mainNotebook;
		private global::Gtk.VBox vbox5;
		private global::Gtk.Label label6;
		private global::Gtk.Table table4;
		private global::Gtk.Entry bottomMarginEntry;
		private global::Gtk.Label label10;
		private global::Gtk.Label label7;
		private global::Gtk.Label label8;
		private global::Gtk.Label label9;
		private global::Gtk.Entry leftMarginEntry;
		private global::Gtk.Entry rightMarginEntry;
		private global::Gtk.Entry topMarginEntry;
		private global::Gtk.Label label1;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Label label4;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Button removeReferenceButton;
		private global::Gtk.FileChooserButton addReferenceFilechooserbutton;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.NodeView referencesNodeView;
		private global::Gtk.Label label5;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Button removeUsingButton;
		private global::Gtk.Button addUsingButton;
		private global::Gtk.Entry usingEntry;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.NodeView usingsNodeview;
		private global::Gtk.Label label2;
		private global::PropertyGrid.PropertyGrid generalSettingsPropertygrid;
		private global::Gtk.Label label3;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoReports.Gui.Widgets.PreferencesEditor
			this.Name = "MonoReports.Gui.Widgets.PreferencesEditor";
			this.Title = global::Mono.Unix.Catalog.GetString ("Settings");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child MonoReports.Gui.Widgets.PreferencesEditor.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.mainNotebook = new global::Gtk.Notebook ();
			this.mainNotebook.CanFocus = true;
			this.mainNotebook.Name = "mainNotebook";
			this.mainNotebook.CurrentPage = 1;
			// Container child mainNotebook.Gtk.Notebook+NotebookChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Page Margin");
			this.vbox5.Add (this.label6);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label6]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.table4 = new global::Gtk.Table (((uint)(4)), ((uint)(2)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(6));
			this.table4.ColumnSpacing = ((uint)(6));
			// Container child table4.Gtk.Table+TableChild
			this.bottomMarginEntry = new global::Gtk.Entry ();
			this.bottomMarginEntry.CanFocus = true;
			this.bottomMarginEntry.Name = "bottomMarginEntry";
			this.bottomMarginEntry.IsEditable = true;
			this.bottomMarginEntry.InvisibleChar = '•';
			this.table4.Add (this.bottomMarginEntry);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table4 [this.bottomMarginEntry]));
			w3.TopAttach = ((uint)(3));
			w3.BottomAttach = ((uint)(4));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xalign = 1F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Left");
			this.table4.Add (this.label10);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table4 [this.label10]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Top");
			this.table4.Add (this.label7);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table4 [this.label7]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Right");
			this.table4.Add (this.label8);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table4 [this.label8]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Bottom");
			this.table4.Add (this.label9);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table4 [this.label9]));
			w7.TopAttach = ((uint)(3));
			w7.BottomAttach = ((uint)(4));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.leftMarginEntry = new global::Gtk.Entry ();
			this.leftMarginEntry.CanFocus = true;
			this.leftMarginEntry.Name = "leftMarginEntry";
			this.leftMarginEntry.IsEditable = true;
			this.leftMarginEntry.InvisibleChar = '•';
			this.table4.Add (this.leftMarginEntry);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table4 [this.leftMarginEntry]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.rightMarginEntry = new global::Gtk.Entry ();
			this.rightMarginEntry.CanFocus = true;
			this.rightMarginEntry.Name = "rightMarginEntry";
			this.rightMarginEntry.IsEditable = true;
			this.rightMarginEntry.InvisibleChar = '•';
			this.table4.Add (this.rightMarginEntry);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table4 [this.rightMarginEntry]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.topMarginEntry = new global::Gtk.Entry ();
			this.topMarginEntry.CanFocus = true;
			this.topMarginEntry.Name = "topMarginEntry";
			this.topMarginEntry.IsEditable = true;
			this.topMarginEntry.InvisibleChar = '•';
			this.table4.Add (this.topMarginEntry);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table4 [this.topMarginEntry]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox5.Add (this.table4);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.table4]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.mainNotebook.Add (this.vbox5);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Page Settings");
			this.mainNotebook.SetTabLabel (this.vbox5, this.label1);
			this.label1.ShowAll ();
			// Container child mainNotebook.Gtk.Notebook+NotebookChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("References:");
			this.vbox4.Add (this.label4);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label4]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.removeReferenceButton = new global::Gtk.Button ();
			this.removeReferenceButton.CanFocus = true;
			this.removeReferenceButton.Name = "removeReferenceButton";
			this.removeReferenceButton.UseStock = true;
			this.removeReferenceButton.UseUnderline = true;
			this.removeReferenceButton.Label = "gtk-remove";
			this.hbox1.Add (this.removeReferenceButton);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.removeReferenceButton]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.addReferenceFilechooserbutton = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Wybór pliku"), ((global::Gtk.FileChooserAction)(0)));
			this.addReferenceFilechooserbutton.Name = "addReferenceFilechooserbutton";
			this.addReferenceFilechooserbutton.ShowHidden = true;
			this.hbox1.Add (this.addReferenceFilechooserbutton);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.addReferenceFilechooserbutton]));
			w15.Position = 1;
			this.vbox4.Add (this.hbox1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox1]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.referencesNodeView = new global::Gtk.NodeView ();
			this.referencesNodeView.CanFocus = true;
			this.referencesNodeView.Events = ((global::Gdk.EventMask)(256));
			this.referencesNodeView.Name = "referencesNodeView";
			this.GtkScrolledWindow.Add (this.referencesNodeView);
			this.vbox4.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.GtkScrolledWindow]));
			w18.Position = 2;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Usings:");
			this.vbox4.Add (this.label5);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label5]));
			w19.Position = 3;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.removeUsingButton = new global::Gtk.Button ();
			this.removeUsingButton.CanFocus = true;
			this.removeUsingButton.Name = "removeUsingButton";
			this.removeUsingButton.UseStock = true;
			this.removeUsingButton.UseUnderline = true;
			this.removeUsingButton.Label = "gtk-remove";
			this.hbox4.Add (this.removeUsingButton);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.removeUsingButton]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.addUsingButton = new global::Gtk.Button ();
			this.addUsingButton.CanFocus = true;
			this.addUsingButton.Name = "addUsingButton";
			this.addUsingButton.UseStock = true;
			this.addUsingButton.UseUnderline = true;
			this.addUsingButton.Label = "gtk-add";
			this.hbox4.Add (this.addUsingButton);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.addUsingButton]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.usingEntry = new global::Gtk.Entry ();
			this.usingEntry.CanFocus = true;
			this.usingEntry.Name = "usingEntry";
			this.usingEntry.IsEditable = true;
			this.usingEntry.InvisibleChar = '•';
			this.hbox4.Add (this.usingEntry);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.usingEntry]));
			w22.Position = 2;
			this.vbox4.Add (this.hbox4);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox4]));
			w23.Position = 4;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.usingsNodeview = new global::Gtk.NodeView ();
			this.usingsNodeview.CanFocus = true;
			this.usingsNodeview.Events = ((global::Gdk.EventMask)(256));
			this.usingsNodeview.Name = "usingsNodeview";
			this.GtkScrolledWindow1.Add (this.usingsNodeview);
			this.vbox4.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.GtkScrolledWindow1]));
			w25.Position = 5;
			this.mainNotebook.Add (this.vbox4);
			global::Gtk.Notebook.NotebookChild w26 = ((global::Gtk.Notebook.NotebookChild)(this.mainNotebook [this.vbox4]));
			w26.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Script Settings");
			this.mainNotebook.SetTabLabel (this.vbox4, this.label2);
			this.label2.ShowAll ();
			// Container child mainNotebook.Gtk.Notebook+NotebookChild
			this.generalSettingsPropertygrid = new global::PropertyGrid.PropertyGrid ();
			this.generalSettingsPropertygrid.Name = "generalSettingsPropertygrid";
			this.generalSettingsPropertygrid.ShowToolbar = false;
			this.generalSettingsPropertygrid.ShowHelp = false;
			this.mainNotebook.Add (this.generalSettingsPropertygrid);
			global::Gtk.Notebook.NotebookChild w27 = ((global::Gtk.Notebook.NotebookChild)(this.mainNotebook [this.generalSettingsPropertygrid]));
			w27.Position = 2;
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Debug");
			this.mainNotebook.SetTabLabel (this.generalSettingsPropertygrid, this.label3);
			this.label3.ShowAll ();
			w1.Add (this.mainNotebook);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(w1 [this.mainNotebook]));
			w28.Position = 0;
			// Internal child MonoReports.Gui.Widgets.PreferencesEditor.ActionArea
			global::Gtk.HButtonBox w29 = this.ActionArea;
			w29.Name = "dialog1_ActionArea";
			w29.Spacing = 10;
			w29.BorderWidth = ((uint)(5));
			w29.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w30 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w29 [this.buttonOk]));
			w30.Expand = false;
			w30.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 597;
			this.DefaultHeight = 551;
			this.Show ();
			this.topMarginEntry.Changed += new global::System.EventHandler (this.OnTopMarginEntryChanged);
			this.rightMarginEntry.Changed += new global::System.EventHandler (this.OnRightMarginEntryChanged);
			this.leftMarginEntry.Changed += new global::System.EventHandler (this.OnLeftMarginEntryChanged);
			this.bottomMarginEntry.Changed += new global::System.EventHandler (this.OnBottomMarginEntryChanged);
			this.removeReferenceButton.Clicked += new global::System.EventHandler (this.OnRemoveReferenceButtonClicked);
			this.addReferenceFilechooserbutton.SelectionChanged += new global::System.EventHandler (this.OnAddReferenceFilechooserbuttonSelectionChanged);
			this.referencesNodeView.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnReferencesNodeViewButtonPressEvent);
			this.removeUsingButton.Clicked += new global::System.EventHandler (this.OnRemoveUsingButtonClicked);
			this.addUsingButton.Clicked += new global::System.EventHandler (this.OnAddUsingButtonClicked);
			this.usingEntry.Changed += new global::System.EventHandler (this.OnUsingEntryChanged);
			this.usingsNodeview.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnUsingsNodeviewButtonPressEvent);
		}
	}
}
