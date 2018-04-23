using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Grid;

namespace DXTreeList_NodeTraversing {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            treeListControl1.ItemsSource = Stuff.GetStuff();
        }

        private void treeListControl1_Loaded(object sender, RoutedEventArgs e) {
            SmartExpandNodes(4);
        }

        private void SmartExpandNodes(int minChildCount) {
            TreeListNodeIterator nodeIterator = new TreeListNodeIterator(treeListView1.Nodes, true);
            while (nodeIterator.MoveNext())
                nodeIterator.Current.IsExpanded = nodeIterator.Current.Nodes.Count >= minChildCount;
        }
    }
}
