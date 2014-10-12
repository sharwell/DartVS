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
    /// Interaction logic for FormattingSpacingOptionsTree.xaml
    /// </summary>
    public partial class FormattingSpacingOptionsTree : UserControl
    {
        public FormattingSpacingOptionsTree()
        {
            ManualInitializeComponent();
        }

        public FormattingSpacingOptions OptionsPage
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
            System.Uri resourceLocater = new System.Uri( "/" + assembly + ";component/uclanguage/optionspages/formattingspacingoptionstree.xaml", System.UriKind.Relative );

            System.Windows.Application.LoadComponent( this, resourceLocater );
        }

        public void ReloadSettings()
        {
            // method declarations
            chkSpaceInMethodDeclarationNameParenthesis.IsChecked = OptionsPage.SpaceInMethodDeclarationNameParenthesis;
            chkSpaceInDeclarationArgumentListParentheses.IsChecked = OptionsPage.SpaceInDeclarationArgumentListParentheses;
            chkSpaceInDeclarationEmptyArgumentList.IsChecked = OptionsPage.SpaceInDeclarationEmptyArgumentList;

            // method calls
            chkSpaceInMethodCallNameParenthesis.IsChecked = OptionsPage.SpaceInMethodCallNameParenthesis;
            chkSpaceInCallArgumentListParentheses.IsChecked = OptionsPage.SpaceInCallArgumentListParentheses;
            chkSpaceInCallEmptyArgumentList.IsChecked = OptionsPage.SpaceInCallEmptyArgumentList;

            // other spacing options
            chkSpaceAfterKeywordsInControlFlow.IsChecked = OptionsPage.SpaceAfterKeywordsInControlFlow;
            chkSpaceInExpressionParentheses.IsChecked = OptionsPage.SpaceInExpressionParentheses;
            chkSpaceInTypeCastParentheses.IsChecked = OptionsPage.SpaceInTypeCastParentheses;
            chkSpaceInControlFlowParentheses.IsChecked = OptionsPage.SpaceInControlFlowParentheses;
            chkSpaceAfterCast.IsChecked = OptionsPage.SpaceAfterCast;
            chkIgnoreSpaceInDeclarations.IsChecked = OptionsPage.IgnoreSpaceInDeclarations;

            // spacing for brackets
            chkSpaceBeforeOpenBracket.IsChecked = OptionsPage.SpaceBeforeOpenBracket;
            chkSpaceInEmptyBrackets.IsChecked = OptionsPage.SpaceInEmptyBrackets;
            chkSpaceInBrackets.IsChecked = OptionsPage.SpaceInBrackets;

            // spacing for delimiters
            chkSpaceAfterColonInTypeDeclaration.IsChecked = OptionsPage.SpaceAfterColonInTypeDeclaration;
            chkSpaceAfterComma.IsChecked = OptionsPage.SpaceAfterComma;
            chkSpaceAfterDot.IsChecked = OptionsPage.SpaceAfterDot;
            chkSpaceAfterSemiInForStatement.IsChecked = OptionsPage.SpaceAfterSemiInForStatement;
            chkSpaceBeforeColonInTypeDeclaration.IsChecked = OptionsPage.SpaceBeforeColonInTypeDeclaration;
            chkSpaceBeforeComma.IsChecked = OptionsPage.SpaceBeforeComma;
            chkSpaceBeforeDot.IsChecked = OptionsPage.SpaceBeforeDot;
            chkSpaceBeforeSemiInForStatement.IsChecked = OptionsPage.SpaceBeforeSemiInForStatement;

            // spacing for operators
            radOperatorInsertSpace.IsChecked = ( OptionsPage.OperatorSpacing == OperatorSpacingMode.Insert );
            radOperatorIgnoreSpace.IsChecked = ( OptionsPage.OperatorSpacing == OperatorSpacingMode.Ignore );
            radOperatorRemoveSpace.IsChecked = ( OptionsPage.OperatorSpacing == OperatorSpacingMode.Remove );
        }

        public void ApplyChanges()
        {
            // method declarations
            OptionsPage.SpaceInMethodDeclarationNameParenthesis = chkSpaceInMethodDeclarationNameParenthesis.IsChecked ?? false;
            OptionsPage.SpaceInDeclarationArgumentListParentheses = chkSpaceInDeclarationArgumentListParentheses.IsChecked ?? false;
            OptionsPage.SpaceInDeclarationEmptyArgumentList = chkSpaceInDeclarationEmptyArgumentList.IsChecked ?? false;

            // method calls
            OptionsPage.SpaceInMethodCallNameParenthesis = chkSpaceInMethodCallNameParenthesis.IsChecked ?? false;
            OptionsPage.SpaceInCallArgumentListParentheses = chkSpaceInCallArgumentListParentheses.IsChecked ?? false;
            OptionsPage.SpaceInCallEmptyArgumentList = chkSpaceInCallEmptyArgumentList.IsChecked ?? false;

            // other spacing options
            OptionsPage.SpaceAfterKeywordsInControlFlow = chkSpaceAfterKeywordsInControlFlow.IsChecked ?? false;
            OptionsPage.SpaceInExpressionParentheses = chkSpaceInExpressionParentheses.IsChecked ?? false;
            OptionsPage.SpaceInTypeCastParentheses = chkSpaceInTypeCastParentheses.IsChecked ?? false;
            OptionsPage.SpaceInControlFlowParentheses = chkSpaceInControlFlowParentheses.IsChecked ?? false;
            OptionsPage.SpaceAfterCast = chkSpaceAfterCast.IsChecked ?? false;
            OptionsPage.IgnoreSpaceInDeclarations = chkIgnoreSpaceInDeclarations.IsChecked ?? false;

            // spacing for brackets
            OptionsPage.SpaceBeforeOpenBracket = chkSpaceBeforeOpenBracket.IsChecked ?? false;
            OptionsPage.SpaceInEmptyBrackets = chkSpaceInEmptyBrackets.IsChecked ?? false;
            OptionsPage.SpaceInBrackets = chkSpaceInBrackets.IsChecked ?? false;

            // spacing for delimiters
            OptionsPage.SpaceAfterColonInTypeDeclaration = chkSpaceAfterColonInTypeDeclaration.IsChecked ?? false;
            OptionsPage.SpaceAfterComma = chkSpaceAfterComma.IsChecked ?? false;
            OptionsPage.SpaceAfterDot = chkSpaceAfterDot.IsChecked ?? false;
            OptionsPage.SpaceAfterSemiInForStatement = chkSpaceAfterSemiInForStatement.IsChecked ?? false;
            OptionsPage.SpaceBeforeColonInTypeDeclaration = chkSpaceBeforeColonInTypeDeclaration.IsChecked ?? false;
            OptionsPage.SpaceBeforeComma = chkSpaceBeforeComma.IsChecked ?? false;
            OptionsPage.SpaceBeforeDot = chkSpaceBeforeDot.IsChecked ?? false;
            OptionsPage.SpaceBeforeSemiInForStatement = chkSpaceBeforeSemiInForStatement.IsChecked ?? false;

            // spacing for operators
            if ( radOperatorInsertSpace.IsChecked ?? false )
                OptionsPage.OperatorSpacing = OperatorSpacingMode.Insert;
            else if ( radOperatorIgnoreSpace.IsChecked ?? false )
                OptionsPage.OperatorSpacing = OperatorSpacingMode.Ignore;
            else if ( radOperatorRemoveSpace.IsChecked ?? false )
                OptionsPage.OperatorSpacing = OperatorSpacingMode.Remove;
        }
    }
}
