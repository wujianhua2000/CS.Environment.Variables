namespace EnvironmentVariables
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip( );
            this.ButtonClose = new System.Windows.Forms.Button( );
            this.DialogPath = new System.Windows.Forms.FolderBrowserDialog( );
            this.tabControl1 = new System.Windows.Forms.TabControl( );
            this.tabPage1 = new System.Windows.Forms.TabPage( );
            this.tabPage2 = new System.Windows.Forms.TabPage( );
            this.ButtonPathDelete = new System.Windows.Forms.Button( );
            this.button1 = new System.Windows.Forms.Button( );
            this.label2 = new System.Windows.Forms.Label( );
            this.ListPath = new System.Windows.Forms.ListBox( );
            this.ButtonPathSave = new System.Windows.Forms.Button( );
            this.label1 = new System.Windows.Forms.Label( );
            this.TextPath = new System.Windows.Forms.TextBox( );
            this.ButtonShowPath = new System.Windows.Forms.Button( );
            this.ButtonSaveCust = new System.Windows.Forms.Button( );
            this.ButtonShowCust = new System.Windows.Forms.Button( );
            this.label4 = new System.Windows.Forms.Label( );
            this.TextCustValue = new System.Windows.Forms.TextBox( );
            this.label3 = new System.Windows.Forms.Label( );
            this.TextCustName = new System.Windows.Forms.TextBox( );
            this.tabPage3 = new System.Windows.Forms.TabPage( );
            this.ButtonListVars = new System.Windows.Forms.Button( );
            this.label5 = new System.Windows.Forms.Label( );
            this.ListSysVar = new System.Windows.Forms.ListBox( );
            this.tabControl1.SuspendLayout( );
            this.tabPage1.SuspendLayout( );
            this.tabPage2.SuspendLayout( );
            this.tabPage3.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point( 0, 484 );
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size( 869, 22 );
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point( 367, 449 );
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonClose.TabIndex = 14;
            this.ButtonClose.Text = "退出";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler( this.ButtonClose_Click );
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add( this.tabPage1 );
            this.tabControl1.Controls.Add( this.tabPage2 );
            this.tabControl1.Controls.Add( this.tabPage3 );
            this.tabControl1.Location = new System.Drawing.Point( 12, 12 );
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size( 845, 419 );
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add( this.ButtonPathDelete );
            this.tabPage1.Controls.Add( this.button1 );
            this.tabPage1.Controls.Add( this.label2 );
            this.tabPage1.Controls.Add( this.ListPath );
            this.tabPage1.Controls.Add( this.ButtonPathSave );
            this.tabPage1.Controls.Add( this.label1 );
            this.tabPage1.Controls.Add( this.TextPath );
            this.tabPage1.Controls.Add( this.ButtonShowPath );
            this.tabPage1.Location = new System.Drawing.Point( 4, 22 );
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding( 3 );
            this.tabPage1.Size = new System.Drawing.Size( 837, 393 );
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "环境变量 PATH  ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add( this.ButtonSaveCust );
            this.tabPage2.Controls.Add( this.ButtonShowCust );
            this.tabPage2.Controls.Add( this.label4 );
            this.tabPage2.Controls.Add( this.TextCustValue );
            this.tabPage2.Controls.Add( this.label3 );
            this.tabPage2.Controls.Add( this.TextCustName );
            this.tabPage2.Location = new System.Drawing.Point( 4, 22 );
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding( 3 );
            this.tabPage2.Size = new System.Drawing.Size( 837, 393 );
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "自定义环境变量  ";
            // 
            // ButtonPathDelete
            // 
            this.ButtonPathDelete.Location = new System.Drawing.Point( 583, 315 );
            this.ButtonPathDelete.Name = "ButtonPathDelete";
            this.ButtonPathDelete.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonPathDelete.TabIndex = 21;
            this.ButtonPathDelete.Text = "删除目录";
            this.ButtonPathDelete.UseVisualStyleBackColor = true;
            this.ButtonPathDelete.Click += new System.EventHandler( this.ButtonPathDelete_Click );
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point( 664, 43 );
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size( 75, 23 );
            this.button1.TabIndex = 20;
            this.button1.Text = "选择目录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler( this.ButtonSelectPath_Click );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 14, 101 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 53, 12 );
            this.label2.TabIndex = 19;
            this.label2.Text = "PATH 键:";
            // 
            // ListPath
            // 
            this.ListPath.FormattingEnabled = true;
            this.ListPath.ItemHeight = 12;
            this.ListPath.Location = new System.Drawing.Point( 85, 101 );
            this.ListPath.Name = "ListPath";
            this.ListPath.Size = new System.Drawing.Size( 654, 208 );
            this.ListPath.TabIndex = 18;
            this.ListPath.SelectedIndexChanged += new System.EventHandler( this.ListPath_SelectedIndexChanged );
            // 
            // ButtonPathSave
            // 
            this.ButtonPathSave.Location = new System.Drawing.Point( 583, 43 );
            this.ButtonPathSave.Name = "ButtonPathSave";
            this.ButtonPathSave.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonPathSave.TabIndex = 17;
            this.ButtonPathSave.Text = "保存目录";
            this.ButtonPathSave.UseVisualStyleBackColor = true;
            this.ButtonPathSave.Click += new System.EventHandler( this.ButtonPathSave_Click );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 14, 19 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 65, 12 );
            this.label1.TabIndex = 16;
            this.label1.Text = "选中目录：";
            // 
            // TextPath
            // 
            this.TextPath.Location = new System.Drawing.Point( 85, 16 );
            this.TextPath.Name = "TextPath";
            this.TextPath.Size = new System.Drawing.Size( 654, 21 );
            this.TextPath.TabIndex = 15;
            // 
            // ButtonShowPath
            // 
            this.ButtonShowPath.Location = new System.Drawing.Point( 664, 315 );
            this.ButtonShowPath.Name = "ButtonShowPath";
            this.ButtonShowPath.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonShowPath.TabIndex = 14;
            this.ButtonShowPath.Text = "查询";
            this.ButtonShowPath.UseVisualStyleBackColor = true;
            this.ButtonShowPath.Click += new System.EventHandler( this.ButtonShowPath_Click );
            // 
            // ButtonSaveCust
            // 
            this.ButtonSaveCust.Location = new System.Drawing.Point( 660, 97 );
            this.ButtonSaveCust.Name = "ButtonSaveCust";
            this.ButtonSaveCust.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonSaveCust.TabIndex = 20;
            this.ButtonSaveCust.Text = "保存";
            this.ButtonSaveCust.UseVisualStyleBackColor = true;
            // 
            // ButtonShowCust
            // 
            this.ButtonShowCust.Location = new System.Drawing.Point( 741, 97 );
            this.ButtonShowCust.Name = "ButtonShowCust";
            this.ButtonShowCust.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonShowCust.TabIndex = 19;
            this.ButtonShowCust.Text = "查询";
            this.ButtonShowCust.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 10, 64 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 65, 12 );
            this.label4.TabIndex = 18;
            this.label4.Text = "变量内容：";
            // 
            // TextCustValue
            // 
            this.TextCustValue.Location = new System.Drawing.Point( 81, 61 );
            this.TextCustValue.Name = "TextCustValue";
            this.TextCustValue.Size = new System.Drawing.Size( 735, 21 );
            this.TextCustValue.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 10, 28 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 65, 12 );
            this.label3.TabIndex = 16;
            this.label3.Text = "变量名称：";
            // 
            // TextCustName
            // 
            this.TextCustName.Location = new System.Drawing.Point( 81, 25 );
            this.TextCustName.Name = "TextCustName";
            this.TextCustName.Size = new System.Drawing.Size( 735, 21 );
            this.TextCustName.TabIndex = 15;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add( this.ButtonListVars );
            this.tabPage3.Controls.Add( this.label5 );
            this.tabPage3.Controls.Add( this.ListSysVar );
            this.tabPage3.Location = new System.Drawing.Point( 4, 22 );
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size( 837, 393 );
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "环境变量列表  ";
            // 
            // ButtonListVars
            // 
            this.ButtonListVars.Location = new System.Drawing.Point( 748, 351 );
            this.ButtonListVars.Name = "ButtonListVars";
            this.ButtonListVars.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonListVars.TabIndex = 17;
            this.ButtonListVars.Text = "查询";
            this.ButtonListVars.UseVisualStyleBackColor = true;
            this.ButtonListVars.Click += new System.EventHandler( this.ButtonListVars_Click );
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 15, 17 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 65, 12 );
            this.label5.TabIndex = 16;
            this.label5.Text = "变量键值：";
            // 
            // ListSysVar
            // 
            this.ListSysVar.FormattingEnabled = true;
            this.ListSysVar.HorizontalScrollbar = true;
            this.ListSysVar.ItemHeight = 12;
            this.ListSysVar.Location = new System.Drawing.Point( 82, 17 );
            this.ListSysVar.Name = "ListSysVar";
            this.ListSysVar.Size = new System.Drawing.Size( 741, 328 );
            this.ListSysVar.TabIndex = 15;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 869, 506 );
            this.Controls.Add( this.tabControl1 );
            this.Controls.Add( this.ButtonClose );
            this.Controls.Add( this.statusStrip1 );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "环境变量设置";
            this.Load += new System.EventHandler( this.FormMain_Load );
            this.Resize += new System.EventHandler( this.FormMain_Resize );
            this.tabControl1.ResumeLayout( false );
            this.tabPage1.ResumeLayout( false );
            this.tabPage1.PerformLayout( );
            this.tabPage2.ResumeLayout( false );
            this.tabPage2.PerformLayout( );
            this.tabPage3.ResumeLayout( false );
            this.tabPage3.PerformLayout( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.FolderBrowserDialog DialogPath;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ButtonPathDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListPath;
        private System.Windows.Forms.Button ButtonPathSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextPath;
        private System.Windows.Forms.Button ButtonShowPath;
        private System.Windows.Forms.Button ButtonSaveCust;
        private System.Windows.Forms.Button ButtonShowCust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextCustValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextCustName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ButtonListVars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ListSysVar;

    }
}

