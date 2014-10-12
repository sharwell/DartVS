using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DanTup.DartVS.OptionsPages
{
    public partial class FormattingGeneralOptionsControl : UserControl
    {
        public FormattingGeneralOptionsControl( FormattingGeneralOptions optionsPage )
        {
            InitializeComponent();

            OptionsPage = optionsPage;
            ReloadOptions();
        }

        FormattingGeneralOptions OptionsPage
        {
            get;
            set;
        }

        public void ReloadOptions()
        {
            chkFormatOnSemi.Checked = OptionsPage.AutoFormatOnSemi;
            chkFormatOnCloseBrace.Checked = OptionsPage.AutoFormatOnCloseBrace;
            chkFormatOnPaste.Checked = OptionsPage.AutoFormatOnPaste;
            chkOutlineRegions.Checked = OptionsPage.Experimental;
        }

        public void ApplyChanges()
        {
            OptionsPage.AutoFormatOnSemi = chkFormatOnSemi.Checked;
            OptionsPage.AutoFormatOnCloseBrace = chkFormatOnCloseBrace.Checked;
            OptionsPage.AutoFormatOnPaste = chkFormatOnPaste.Checked;
            OptionsPage.Experimental = chkOutlineRegions.Checked;
        }
    }
}
