using System;
using Gtk;
using GFlow.Data;

public partial class MainWindow: Gtk.Window
{	
public MainWindow (): base (Gtk.WindowType.Toplevel)
{
Build ();
}

protected void OnDeleteEvent (object sender, DeleteEventArgs a)
{
Application.Quit ();
a.RetVal = true;
}
protected void OnBtnOkClicked (object sender, EventArgs e)
{
try {
WorkItem messageIn = new WorkItem{
	Title = txtTitle.Text,
	Area = txtArea.Text,
	AssignedTo = txtAssignedTo.Text,
	Reason = txtReason.Buffer.Text
};
WorkItem messageOut = MessageDAC.Create(messageIn);
ShowMessageBox(string.Format("Reference: {0} created on: {1}",messageOut.Numref
                             ,messageOut.Created));
} catch (Exception ex) {
ShowMessageBox(ex.Message);
}
}

void ShowMessageBox(string msg){
using (Dialog dialog = new MessageDialog (this,
	  DialogFlags.Modal | DialogFlags.DestroyWithParent,
	  MessageType.Info,
	  ButtonsType.Ok,
	  msg)) {
dialog.Run ();
dialog.Hide ();
}

}

}
