using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnvironmentVariables
{
    public partial class FormMain : Form
    {
        private int rectH;

        private int rectW;

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public FormMain( )
        {
            InitializeComponent( );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShowPath_Click( object sender, EventArgs e )
        {
            this.ListPathValues( );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        private void ListPathValues( )
        {
            string pathname = Environment.GetEnvironmentVariable( "PATH", EnvironmentVariableTarget.Machine );

            string[ ] pathlist = pathname.Split( ";".ToCharArray( ), StringSplitOptions.RemoveEmptyEntries );

            this.ListPath.Items.Clear( );
            this.ListPath.Items.AddRange( pathlist );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClose_Click( object sender, EventArgs e )
        {
            this.Close( );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSelectPath_Click( object sender, EventArgs e )
        {
            if ( this.DialogPath.ShowDialog( ) != System.Windows.Forms.DialogResult.OK ) return;

            string pathname = this.DialogPath.SelectedPath;

            this.TextPath.Text = pathname;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load( object sender, EventArgs e )
        {
            int rectWID = this.Width;
            int exitWID = this.ButtonClose.Width;

            this.ButtonClose.Left = ( int ) ( 0.5 * ( rectWID - exitWID ) );

            this.rectH = this.Height;
            this.rectW = this.Width;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonListVars_Click( object sender, EventArgs e )
        {
            IDictionary listing =  Environment.GetEnvironmentVariables( EnvironmentVariableTarget.Machine );

            this.ListSysVar.Items.Clear( );

            foreach ( DictionaryEntry name in listing ) 
            {
                this.ListSysVar.Items.Add( "-".PadRight( 80, '-' ) );
                this.ListSysVar.Items.Add( name.Key );
                this.ListSysVar.Items.Add( "      = " + name.Value );
                this.ListSysVar.Items.Add( string.Empty );
            }

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPathSave_Click( object sender, EventArgs e )
        {
            string newPathNam = this.TextPath.Text;

            if ( string.IsNullOrEmpty( newPathNam ) ) return;

            string pathvalues = Environment.GetEnvironmentVariable( "PATH", EnvironmentVariableTarget.Machine );

            string[ ] pathlist = pathvalues.Split( ";".ToCharArray( ), StringSplitOptions.RemoveEmptyEntries );

            bool found = false;

            foreach ( string name in pathlist )
            {
                bool same = ( name.ToUpper( ).Equals( newPathNam.ToUpper( ) ) );

                if ( same ) found = true;
            }

            if ( found ) MessageBox.Show( "PATH 环境变量已经包含需要的路径，无需二次添加。" );
            if ( found ) return;

            bool gutEND = pathvalues.EndsWith( ";" );

            string newpathing = ( gutEND ) ? pathvalues + newPathNam + ";" 
                                           : pathvalues + ";" + newPathNam + ";";

            Environment.SetEnvironmentVariable( "PATH", newpathing, EnvironmentVariableTarget.Machine );

            this.ListPathValues( );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPathDelete_Click( object sender, EventArgs e )
        {
            string firepath = this.TextPathFire.Text;
            if ( string.IsNullOrEmpty( firepath ) ) return;

            int indexSelected = this.ListPath.SelectedIndex;

            StringBuilder buffer = new StringBuilder( );

            int count = this.ListPath.Items.Count;
            for ( int idx = 0; idx < count; idx++ ) 
            {
                if ( idx == indexSelected ) continue;

                string pathname = this.ListPath.Items[idx].ToString();
                buffer.AppendFormat( "{0};", pathname );
            }

            DialogResult result = MessageBox.Show( "确认修改一下信息吗？\n\n" + "新的 PATH 内容如下：\n\n" + buffer.ToString( ),
                                                   "提示信息",
                                                   MessageBoxButtons.YesNoCancel
                                                   );
            if ( result != DialogResult.Yes ) return;

            DialogResult again = MessageBox.Show( "再次确认修改一下信息吗？", "提示信息", MessageBoxButtons.YesNoCancel );
            if ( again != DialogResult.Yes ) return;

            Environment.SetEnvironmentVariable( "PATH", buffer.ToString( ), EnvironmentVariableTarget.Machine );

            this.ListPathValues( );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Resize( object sender, EventArgs e )
        {
            this.Height = this.rectH;
            this.Width = this.rectW;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListPath_SelectedIndexChanged( object sender, EventArgs e )
        {
            int index = this.ListPath.SelectedIndex;

            if ( index < 0 ) return;

            string item = this.ListPath.Items[ index ].ToString( );

            this.TextPathFire.Text = item;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCustSelePath_Click( object sender, EventArgs e )
        {
            if ( this.DialogPath.ShowDialog( ) != System.Windows.Forms.DialogResult.OK ) return;

            string pathname = this.DialogPath.SelectedPath;

            this.TextCustPath.Text = pathname;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 保存一个目录名到自定义的 KEY 中。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCustSavePath_Click( object sender, EventArgs e )
        {
            string newPathNam = this.TextCustPath.Text;

            if ( string.IsNullOrEmpty( newPathNam ) ) return;

            string custSvarName = this.TextCustName.Text;

            string pathvalues = Environment.GetEnvironmentVariable( custSvarName, EnvironmentVariableTarget.Machine );

            bool found = false;

            if ( !string.IsNullOrEmpty( pathvalues ) )
            {
                string[ ] pathlist = pathvalues.Split( ";".ToCharArray( ), StringSplitOptions.RemoveEmptyEntries );

                foreach ( string name in pathlist )
                {
                    bool same = ( name.ToUpper( ).Equals( newPathNam.ToUpper( ) ) );

                    if ( same ) found = true;
                }
            }

            if ( found ) MessageBox.Show( "自定义环境变量已经包含需要的路径，无需二次添加。" );
            if ( found ) return;

            pathvalues = ( string.IsNullOrEmpty( pathvalues ) ) ? string.Empty : pathvalues;

            bool gutEND = ( string.IsNullOrEmpty( pathvalues ) ) ? true : pathvalues.EndsWith( ";" );

            string newpathing = ( gutEND ) ? pathvalues + newPathNam + ";"
                                           : pathvalues + ";" + newPathNam + ";";

            Environment.SetEnvironmentVariable( custSvarName, newpathing, EnvironmentVariableTarget.Machine );

            //  显示新数据
            this.TextCustValue.Text = Environment.GetEnvironmentVariable( custSvarName, EnvironmentVariableTarget.Machine );

            return;
        }

        //.....................................................................
    }
}
