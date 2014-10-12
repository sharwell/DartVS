namespace DanTup.DartVS.OptionsPages
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Windows.Forms;
    using System.Windows.Forms.VisualStyles;
    //using ImageName = Microsoft.VisualStudio.Project.ImageName;
    //using ProjectNode = Microsoft.VisualStudio.Project.ProjectNode;

    public class OptionsTreeView : TreeView
    {
        public OptionsTreeView()
        {
            ImageList = CreateImageList();
        }

        static ImageList CreateImageList()
        {
            ImageList list = new ImageList();
            list.ColorDepth = ColorDepth.Depth32Bit;

            // folder images
            list.Images.AddStrip( GetFolderImages() );

            // check boxes
            list.Images.Add( CreateImage( VisualStyleElement.Button.CheckBox.UncheckedDisabled ) );
            list.Images.Add( CreateImage( VisualStyleElement.Button.CheckBox.UncheckedNormal ) );
            list.Images.Add( CreateImage( VisualStyleElement.Button.CheckBox.UncheckedPressed ) );
            list.Images.Add( CreateImage( VisualStyleElement.Button.CheckBox.CheckedDisabled ) );
            list.Images.Add( CreateImage( VisualStyleElement.Button.CheckBox.CheckedNormal ) );
            list.Images.Add( CreateImage( VisualStyleElement.Button.CheckBox.CheckedPressed ) );

            // radio buttons
            list.Images.Add( CreateImage( VisualStyleElement.Button.RadioButton.UncheckedDisabled ) );
            list.Images.Add( CreateImage( VisualStyleElement.Button.RadioButton.UncheckedNormal ) );
            list.Images.Add( CreateImage( VisualStyleElement.Button.RadioButton.UncheckedPressed ) );
            list.Images.Add( CreateImage( VisualStyleElement.Button.RadioButton.CheckedDisabled ) );
            list.Images.Add( CreateImage( VisualStyleElement.Button.RadioButton.CheckedNormal ) );
            list.Images.Add( CreateImage( VisualStyleElement.Button.RadioButton.CheckedPressed ) );

            return list;
        }

        static Image GetFolderImages()
        {
            return new Bitmap(16, 16);
            //string resourceName = "Microsoft.VisualStudio.Project.Resources.imagelis.bmp";
            //System.IO.Stream stream = typeof( ProjectNode ).Assembly.GetManifestResourceStream(resourceName);
            //Bitmap image = new Bitmap( Bitmap.FromStream( stream ) );
            //image.MakeTransparent();
            //int offset = (int)ImageName.Folder;
            //return image.Clone( Rectangle.FromLTRB( 16 * offset, 0, 16 * offset + 32, 16 ), System.Drawing.Imaging.PixelFormat.Format32bppArgb );
        }

        static Image CreateImage( VisualStyleElement element )
        {
            VisualStyleRenderer renderer = new VisualStyleRenderer( element );
            Rectangle boundingRect = Rectangle.FromLTRB( 0, 0, 16, 16 );

            Bitmap image = new Bitmap( boundingRect.Width, boundingRect.Height, PixelFormat.Format32bppArgb );
            using ( var dc = Graphics.FromImage( image ) )
            {
                if ( renderer.IsBackgroundPartiallyTransparent() )
                {
                    BufferedGraphicsContext currentContext = BufferedGraphicsManager.Current;
                    using ( BufferedGraphics myBuffer = currentContext.Allocate( dc, boundingRect ) )
                    {
                        Graphics gr = myBuffer.Graphics;
                        gr.FillRectangle( Brushes.White, boundingRect );
                        renderer.DrawBackground( gr, boundingRect );
                        myBuffer.Render();
                    }
                }
                else
                {
                    renderer.DrawBackground( dc, boundingRect );
                }
            }

            return image;
        }

        static bool UseVisualStyles
        {
            get
            {
                switch ( Application.VisualStyleState )
                {
                case VisualStyleState.ClientAreaEnabled:
                case VisualStyleState.ClientAndNonClientAreasEnabled:
                    return true;

                default:
                    return false;
                }
            }
        }

        static bool IsRadioButton( TreeNode node )
        {
            return node.ImageIndex >= 8;
        }

        void UpdateStateImages( TreeNode node )
        {
            int index = 0;
            if ( node.Nodes.Count > 0 )
            {
                if ( node.IsExpanded )
                    index++;
            }
            else
            {
                index += 2;
                if ( IsRadioButton( node ) )
                    index += 6;

                if ( node.Checked )
                    index += 3;

                if ( Enabled )
                    index++;

                bool pressed = false;
                if ( pressed )
                    index++;
            }

            node.ImageIndex = index;
            node.SelectedImageIndex = index;

            if ( node.IsExpanded )
            {
                foreach ( TreeNode child in node.Nodes )
                    UpdateStateImages( child );
            }
        }
        void UpdateStateImages()
        {
            foreach ( TreeNode node in Nodes )
                UpdateStateImages( node );
        }

        protected override void OnAfterCheck( TreeViewEventArgs e )
        {
            TreeNode node = e.Node;
            if ( IsRadioButton( node ) && node.Checked )
            {
                TreeNode parent = node.Parent;
                foreach ( TreeNode child in parent.Nodes )
                {
                    if ( child != node )
                        child.Checked = false;
                }
            }

            UpdateStateImages();
            base.OnAfterCheck( e );
        }
        protected override void OnAfterCollapse( TreeViewEventArgs e )
        {
            UpdateStateImages();
            base.OnAfterCollapse( e );
        }
        protected override void OnAfterExpand( TreeViewEventArgs e )
        {
            UpdateStateImages();
            base.OnAfterExpand( e );
        }

        protected override void OnNodeMouseClick( TreeNodeMouseClickEventArgs e )
        {
            TreeNode node = e.Node;
            if ( node.Nodes.Count == 0 && node.IsSelected )
            {
                node.Checked = !node.Checked;
            }

            base.OnNodeMouseClick( e );
        }
        protected override void OnNodeMouseDoubleClick( TreeNodeMouseClickEventArgs e )
        {
            TreeNode node = e.Node;
            if ( node.Nodes.Count == 0 )
            {
                node.Checked = !node.Checked;
            }

            base.OnNodeMouseDoubleClick( e );
        }

        protected override void WndProc( ref Message m )
        {
            // TVM_INSERTITEMW || TVM_INSERTITEMA
            if ( m.Msg == 4402 || m.Msg == 4352 )
                UpdateStateImages();

            base.WndProc( ref m );
        }
    }
}
