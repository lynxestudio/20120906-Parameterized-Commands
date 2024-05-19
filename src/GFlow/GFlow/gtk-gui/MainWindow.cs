
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.Table table1;
	private global::Gtk.Label label1;
	private global::Gtk.Label label2;
	private global::Gtk.Label label5;
	private global::Gtk.Entry txtArea;
	private global::Gtk.Entry txtAssignedTo;
	private global::Gtk.Entry txtTitle;
	private global::Gtk.Label label7;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TextView txtReason;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Button btnOk;
	private global::Gtk.Label lbMsg;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("New work item");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(3));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		this.vbox1.BorderWidth = ((uint)(3));
		// Container child vbox1.Gtk.Box+BoxChild
		this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.Xalign = 0F;
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Title: ");
		this.table1.Add (this.label1);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
		w1.XOptions = ((global::Gtk.AttachOptions)(4));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.Xalign = 0F;
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Assigned to: ");
		this.table1.Add (this.label2);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
		w2.TopAttach = ((uint)(1));
		w2.BottomAttach = ((uint)(2));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.Xalign = 0F;
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Area: ");
		this.table1.Add (this.label5);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
		w3.TopAttach = ((uint)(2));
		w3.BottomAttach = ((uint)(3));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.txtArea = new global::Gtk.Entry ();
		this.txtArea.CanFocus = true;
		this.txtArea.Name = "txtArea";
		this.txtArea.IsEditable = true;
		this.txtArea.InvisibleChar = '●';
		this.table1.Add (this.txtArea);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtArea]));
		w4.TopAttach = ((uint)(2));
		w4.BottomAttach = ((uint)(3));
		w4.LeftAttach = ((uint)(1));
		w4.RightAttach = ((uint)(2));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.txtAssignedTo = new global::Gtk.Entry ();
		this.txtAssignedTo.CanFocus = true;
		this.txtAssignedTo.Name = "txtAssignedTo";
		this.txtAssignedTo.IsEditable = true;
		this.txtAssignedTo.InvisibleChar = '●';
		this.table1.Add (this.txtAssignedTo);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtAssignedTo]));
		w5.TopAttach = ((uint)(1));
		w5.BottomAttach = ((uint)(2));
		w5.LeftAttach = ((uint)(1));
		w5.RightAttach = ((uint)(2));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.txtTitle = new global::Gtk.Entry ();
		this.txtTitle.CanFocus = true;
		this.txtTitle.Name = "txtTitle";
		this.txtTitle.IsEditable = true;
		this.txtTitle.InvisibleChar = '●';
		this.table1.Add (this.txtTitle);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtTitle]));
		w6.LeftAttach = ((uint)(1));
		w6.RightAttach = ((uint)(2));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox1.Add (this.table1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Reason: ");
		this.vbox1.Add (this.label7);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label7]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.txtReason = new global::Gtk.TextView ();
		this.txtReason.CanFocus = true;
		this.txtReason.Name = "txtReason";
		this.txtReason.AcceptsTab = false;
		this.txtReason.WrapMode = ((global::Gtk.WrapMode)(1));
		this.GtkScrolledWindow.Add (this.txtReason);
		this.vbox1.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
		w10.Position = 2;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Homogeneous = true;
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.btnOk = new global::Gtk.Button ();
		this.btnOk.CanFocus = true;
		this.btnOk.Name = "btnOk";
		this.btnOk.UseStock = true;
		this.btnOk.UseUnderline = true;
		this.btnOk.Label = "gtk-ok";
		this.hbox1.Add (this.btnOk);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnOk]));
		w11.Position = 0;
		w11.Expand = false;
		w11.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.lbMsg = new global::Gtk.Label ();
		this.lbMsg.Name = "lbMsg";
		this.lbMsg.LabelProp = global::Mono.Unix.Catalog.GetString ("Running");
		this.hbox1.Add (this.lbMsg);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.lbMsg]));
		w12.Position = 1;
		w12.Expand = false;
		w12.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w13.Position = 3;
		w13.Expand = false;
		w13.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnOk.Clicked += new global::System.EventHandler (this.OnBtnOkClicked);
	}
}