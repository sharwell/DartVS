using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DanTup.DartVS.OptionsPages
{
    /// <summary>
    /// Interaction logic for FormattingWrappingOptionsTree.xaml
    /// </summary>
    public partial class FormattingWrappingOptionsTree : UserControl
    {
        public FormattingWrappingOptionsTree()
        {
            ManualInitializeComponent();
        }

        public FormattingWrappingOptions OptionsPage
        {
            get;
            set;
        }

        void ManualInitializeComponent()
        {
            if ( _contentLoaded )
            {
                return;
            }

            string assembly = GetType().Assembly.GetName().Name;
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri( "/" + assembly + ";component/uclanguage/optionspages/formattingwrappingoptionstree.xaml", System.UriKind.Relative );

            System.Windows.Application.LoadComponent( this, resourceLocater );
        }

        public void ReloadSettings()
        {
            chkLeaveBlockOnSingleLine.IsChecked = OptionsPage.LeaveBlockOnSingleLine;
            chkLeaveStatementsOnSameLine.IsChecked = OptionsPage.LeaveStatementsOnSameLine;
        }

        public void ApplyChanges()
        {
            OptionsPage.LeaveBlockOnSingleLine = chkLeaveBlockOnSingleLine.IsChecked ?? false;
            OptionsPage.LeaveStatementsOnSameLine = chkLeaveStatementsOnSameLine.IsChecked ?? false;
        }
    }
}
