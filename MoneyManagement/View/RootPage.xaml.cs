using System;
using Xamarin.Forms;

namespace MoneyManagement
{
	public partial class RootPage : MasterDetailPage
	{
		void Report_Display(object sender, System.EventArgs e)
		{
			Detail=new DateViewPage();
			IsPresented = false;
		}

		void Data_Entry(object sender, System.EventArgs e)
		{
			Detail = new DataEntryPage();
			IsPresented = false;
		}


		void Quit(object sender, System.EventArgs e)
		{
			Environment.Exit(0);
		}


		public RootPage()
		{
			InitializeComponent();
			Detail=new DataEntryPage();
			IsPresented = false;
		}
	}
}
