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
    /// Interaction logic for FormattingNewLinesOptionsTree.xaml
    /// </summary>
    public partial class FormattingNewLinesOptionsTree : UserControl
    {
        public FormattingNewLinesOptionsTree()
        {
            ManualInitializeComponent();
        }

        public FormattingNewLinesOptions OptionsPage
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
            System.Uri resourceLocater = new System.Uri( "/" + assembly + ";component/uclanguage/optionspages/formattingnewlinesoptionstree.xaml", System.UriKind.Relative );

            System.Windows.Application.LoadComponent( this, resourceLocater );
        }

        public void ReloadSettings()
        {
            // options for braces
            chkOpenBraceOnNewLineTypes.IsChecked = OptionsPage.OpenBraceOnNewLineTypes;
            chkOpenBraceOnNewLineMethods.IsChecked = OptionsPage.OpenBraceOnNewLineMethods;
            chkOpenBraceOnNewLineControlBlocks.IsChecked = OptionsPage.OpenBraceOnNewLineControlBlocks;

            // new line options for keywords
            chkElseOnNewLine.IsChecked = OptionsPage.ElseOnNewLine;
        }

        public void ApplyChanges()
        {
            // options for braces
            OptionsPage.OpenBraceOnNewLineTypes = chkOpenBraceOnNewLineTypes.IsChecked ?? false;
            OptionsPage.OpenBraceOnNewLineMethods = chkOpenBraceOnNewLineMethods.IsChecked ?? false;
            OptionsPage.OpenBraceOnNewLineControlBlocks = chkOpenBraceOnNewLineControlBlocks.IsChecked ?? false;

            // new line options for keywords
            OptionsPage.ElseOnNewLine = chkElseOnNewLine.IsChecked ?? false;
        }
    }
}
