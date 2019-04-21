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
            this.groupBox1 = new System.Windows.Forms.GroupBox( );
            this.button1 = new System.Windows.Forms.Button( );
            this.label2 = new System.Windows.Forms.Label( );
            this.ListPath = new System.Windows.Forms.ListBox( );
            this.ButtonPathSave = new System.Windows.Forms.Button( );
            this.label1 = new System.Windows.Forms.Label( );
            this.TextPath = new System.Windows.Forms.TextBox( );
            this.ButtonShowPath = new System.Windows.Forms.Button( );
            this.statusStrip1 = new System.Windows.Forms.StatusStrip( );
            this.groupBox2 = new System.Windows.Forms.GroupBox( );
            this.ButtonSaveCust = new System.Windows.Forms.Button( );
            this.ButtonShowCust = new System.Windows.Forms.Button( );
            this.label4 = new System.Windows.Forms.Label( );
            this.TextCustValue = new System.Windows.Forms.TextBox( );
            this.label3 = new System.Windows.Forms.Label( );
            this.TextCustName = new System.Windows.Forms.TextBox( );
            this.ButtonClose = new System.Windows.Forms.Button( );
            this.DialogPath = new System.Windows.Forms.FolderBrowserDialog( );
            this.groupBox3 = new System.Windows.Forms.GroupBox( );
            this.label5 = new System.Windows.Forms.Label( );
            this.ListSysVar = new System.Windows.Forms.ListBox( );
            this.ButtonListVars = new System.Windows.Forms.Button( );
            this.ButtonPathDelete = new System.Windows.Forms.Button( );
            this.groupBox1.SuspendLayout( );
            this.groupBox2.SuspendLayout( );
            this.groupBox3.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.ButtonPathDelete );
            this.groupBox1.Controls.Add( this.button1 );
            this.groupBox1.Controls.Add( this.label2 );
            this.groupBox1.Controls.Add( this.ListPath );
            this.groupBox1.Controls.Add( this.ButtonPathSave );
            this.groupBox1.Controls.Add( this.label1 );
            this.groupBox1.Controls.Add( this.TextPath );
            this.groupBox1.Controls.Add( this.ButtonShowPath );
            this.groupBox1.Location = new System.Drawing.Point( 12, 12 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 872, 217 );
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "环境变量 PATH";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point( 764, 18 );
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size( 75, 23 );
            this.button1.TabIndex = 12;
            this.button1.Text = "选择目录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler( this.ButtonSelectPath_Click );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 15, 57 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 53, 12 );
            this.label2.TabIndex = 11;
            this.label2.Text = "PATH 键:";
            // 
            // ListPath
            // 
            this.ListPath.FormattingEnabled = true;
            this.ListPath.ItemHeight = 12;
            this.ListPath.Location = new System.Drawing.Point( 86, 57 );
            this.ListPath.Name = "ListPath";
            this.ListPath.Size = new System.Drawing.Size( 661, 148 );
            this.ListPath.TabIndex = 10;
            // 
            // ButtonPathSave
            // 
            this.ButtonPathSave.Location = new System.Drawing.Point( 764, 47 );
            this.ButtonPathSave.Name = "ButtonPathSave";
            this.ButtonPathSave.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonPathSave.TabIndex = 9;
            this.ButtonPathSave.Text = "保存目录";
            this.ButtonPathSave.UseVisualStyleBackColor = true;
            this.ButtonPathSave.Click += new System.EventHandler( this.ButtonPathSave_Click );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 15, 23 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 65, 12 );
            this.label1.TabIndex = 8;
            this.label1.Text = "选中目录：";
            // 
            // TextPath
            // 
            this.TextPath.Location = new System.Drawing.Point( 86, 20 );
            this.TextPath.Name = "TextPath";
            this.TextPath.Size = new System.Drawing.Size( 661, 21 );
            this.TextPath.TabIndex = 7;
            // 
            // ButtonShowPath
            // 
            this.ButtonShowPath.Location = new System.Drawing.Point( 764, 182 );
            this.ButtonShowPath.Name = "ButtonShowPath";
            this.ButtonShowPath.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonShowPath.TabIndex = 6;
            this.ButtonShowPath.Text = "查询";
            this.ButtonShowPath.UseVisualStyleBackColor = true;
            this.ButtonShowPath.Click += new System.EventHandler( this.ButtonShowPath_Click );
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point( 0, 579 );
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size( 900, 22 );
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add( this.ButtonSaveCust );
            this.groupBox2.Controls.Add( this.ButtonShowCust );
            this.groupBox2.Controls.Add( this.label4 );
            this.groupBox2.Controls.Add( this.TextCustValue );
            this.groupBox2.Controls.Add( this.label3 );
            this.groupBox2.Controls.Add( this.TextCustName );
            this.groupBox2.Location = new System.Drawing.Point( 12, 235 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 872, 96 );
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自定义环境变量";
            // 
            // ButtonSaveCust
            // 
            this.ButtonSaveCust.Location = new System.Drawing.Point( 764, 54 );
            this.ButtonSaveCust.Name = "ButtonSaveCust";
            this.ButtonSaveCust.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonSaveCust.TabIndex = 14;
            this.ButtonSaveCust.Text = "保存";
            this.ButtonSaveCust.UseVisualStyleBackColor = true;
            // 
            // ButtonShowCust
            // 
            this.ButtonShowCust.Location = new System.Drawing.Point( 764, 18 );
            this.ButtonShowCust.Name = "ButtonShowCust";
            this.ButtonShowCust.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonShowCust.TabIndex = 13;
            this.ButtonShowCust.Text = "查询";
            this.ButtonShowCust.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 15, 59 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 65, 12 );
            this.label4.TabIndex = 12;
            this.label4.Text = "变量内容：";
            // 
            // TextCustValue
            // 
            this.TextCustValue.Location = new System.Drawing.Point( 86, 56 );
            this.TextCustValue.Name = "TextCustValue";
            this.TextCustValue.Size = new System.Drawing.Size( 661, 21 );
            this.TextCustValue.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 15, 23 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 65, 12 );
            this.label3.TabIndex = 10;
            this.label3.Text = "变量名称：";
            // 
            // TextCustName
            // 
            this.TextCustName.Location = new System.Drawing.Point( 86, 20 );
            this.TextCustName.Name = "TextCustName";
            this.TextCustName.Size = new System.Drawing.Size( 661, 21 );
            this.TextCustName.TabIndex = 9;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point( 394, 544 );
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonClose.TabIndex = 14;
            this.ButtonClose.Text = "退出";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler( this.ButtonClose_Click );
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add( this.ButtonListVars );
            this.groupBox3.Controls.Add( this.label5 );
            this.groupBox3.Controls.Add( this.ListSysVar );
            this.groupBox3.Location = new System.Drawing.Point( 12, 347 );
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size( 872, 176 );
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "环境变量列表：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 15, 20 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 65, 12 );
            this.label5.TabIndex = 13;
            this.label5.Text = "变量键值：";
            // 
            // ListSysVar
            // 
            this.ListSysVar.FormattingEnabled = true;
            this.ListSysVar.ItemHeight = 12;
            this.ListSysVar.Location = new System.Drawing.Point( 86, 20 );
            this.ListSysVar.Name = "ListSysVar";
            this.ListSysVar.Size = new System.Drawing.Size( 661, 148 );
            this.ListSysVar.TabIndex = 12;
            // 
            // ButtonListVars
            // 
            this.ButtonListVars.Location = new System.Drawing.Point( 764, 20 );
            this.ButtonListVars.Name = "ButtonListVars";
            this.ButtonListVars.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonListVars.TabIndex = 14;
            this.ButtonListVars.Text = "查询";
            this.ButtonListVars.UseVisualStyleBackColor = true;
            this.ButtonListVars.Click += new System.EventHandler( this.ButtonListVars_Click );
            // 
            // ButtonPathDelete
            // 
            this.ButtonPathDelete.Location = new System.Drawing.Point( 764, 76 );
            this.ButtonPathDelete.Name = "ButtonPathDelete";
            this.ButtonPathDelete.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonPathDelete.TabIndex = 13;
            this.ButtonPathDelete.Text = "删除目录";
            this.ButtonPathDelete.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 900, 601 );
            this.Controls.Add( this.groupBox3 );
            this.Controls.Add( this.ButtonClose );
            this.Controls.Add( this.groupBox2 );
            this.Controls.Add( this.statusStrip1 );
            this.Controls.Add( this.groupBox1 );
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "环境变量设置";
            this.Load += new System.EventHandler( this.FormMain_Load );
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout( );
            this.groupBox2.ResumeLayout( false );
            this.groupBox2.PerformLayout( );
            this.groupBox3.ResumeLayout( false );
            this.groupBox3.PerformLayout( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListPath;
        private System.Windows.Forms.Button ButtonPathSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextPath;
        private System.Windows.Forms.Button ButtonShowPath;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonSaveCust;
        private System.Windows.Forms.Button ButtonShowCust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextCustValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextCustName;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.FolderBrowserDialog DialogPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ButtonListVars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ListSysVar;
        private System.Windows.Forms.Button ButtonPathDelete;

    }
}

