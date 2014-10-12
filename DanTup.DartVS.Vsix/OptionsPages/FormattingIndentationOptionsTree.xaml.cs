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
    /// Interaction logic for FormattingIndentationOptionsTree.xaml
    /// </summary>
    public partial class FormattingIndentationOptionsTree : UserControl
    {
        public FormattingIndentationOptionsTree()
        {
            ManualInitializeComponent();
        }

        public FormattingIndentationOptions OptionsPage
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
            System.Uri resourceLocater = new System.Uri( "/" + assembly + ";component/uclanguage/optionspages/formattingindentationoptionstree.xaml", System.UriKind.Relative );

            System.Windows.Application.LoadComponent( this, resourceLocater );
        }

        public void ReloadSettings()
        {
            chkIndentBlockContents.IsChecked = OptionsPage.IndentBlockContents;
            chkIndentOpenAndCloseBraces.IsChecked = OptionsPage.IndentOpenAndCloseBraces;
            chkIndentCaseContents.IsChecked = OptionsPage.IndentCaseContents;
            chkIndentCaseLabels.IsChecked = OptionsPage.IndentCaseLabels;

            radLabelsLeftmost.IsChecked = ( OptionsPage.LabelIndentation == LabelIndentationMode.LeftmostColumn );
            radLabelsOneLeft.IsChecked = ( OptionsPage.LabelIndentation == LabelIndentationMode.OneIndentLess );
            radLabelsNormal.IsChecked = ( OptionsPage.LabelIndentation == LabelIndentationMode.IndentNormally );
        }

        public void ApplyChanges()
        {
            OptionsPage.IndentBlockContents = chkIndentBlockContents.IsChecked ?? false;
            OptionsPage.IndentOpenAndCloseBraces = chkIndentOpenAndCloseBraces.IsChecked ?? false;
            OptionsPage.IndentCaseContents = chkIndentCaseContents.IsChecked ?? false;
            OptionsPage.IndentCaseLabels = chkIndentCaseLabels.IsChecked ?? false;

            if ( radLabelsLeftmost.IsChecked ?? false )
                OptionsPage.LabelIndentation = LabelIndentationMode.LeftmostColumn;
            else if ( radLabelsOneLeft.IsChecked ?? false )
                OptionsPage.LabelIndentation = LabelIndentationMode.OneIndentLess;
            else if ( radLabelsNormal.IsChecked ?? false )
                OptionsPage.LabelIndentation = LabelIndentationMode.IndentNormally;
        }
    }
}
