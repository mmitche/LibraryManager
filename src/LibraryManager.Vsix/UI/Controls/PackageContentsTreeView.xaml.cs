﻿using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Web.LibraryManager.Vsix.UI.Models;

namespace Microsoft.Web.LibraryManager.Vsix.UI.Controls
{
    /// <summary>
    /// Interaction logic for PackageContentsTreeView.xaml
    /// </summary>
    public partial class PackageContentsTreeView
    {
        public PackageContentsTreeView()
        {
            InitializeComponent();
        }

        protected override AutomationPeer OnCreateAutomationPeer()
        {
            return new PackageContentsTreeViewAutomationPeer(this);
        }

        private void OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                TreeView treeView = (TreeView)sender;
                PackageItem packageItem = treeView.SelectedItem as PackageItem;

                if (packageItem != null)
                {
                    packageItem.IsChecked = !packageItem.IsChecked;
                    e.Handled = true;
                }
            }
        }
    }
}
