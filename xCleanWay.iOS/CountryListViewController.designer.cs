// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace xCleanWay.iOS
{
	[Register ("CountryListViewController")]
	partial class CountryListViewController
	{
		[Outlet]
		UIKit.UITableView countryTableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (countryTableView != null) {
				countryTableView.Dispose ();
				countryTableView = null;
			}
		}
	}
}
