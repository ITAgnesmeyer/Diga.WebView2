﻿using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Diga.WebView2.WinForms
{
    public sealed class FolderNameEditor : UITypeEditor
    {
        private FolderBrowser _folderBrowser;
 
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if (this._folderBrowser is null)
            {
                this._folderBrowser = new FolderBrowser();
                InitializeDialog(this._folderBrowser);
            }
 
            if (this._folderBrowser.ShowDialog() == DialogResult.OK)
            {
                return this._folderBrowser.DirectoryPath;
            }
 
            return value;
        }
 
        /// <summary>
        ///  Retrieves the editing style of the Edit method.
        /// </summary>
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
 
        /// <summary>
        ///  Initializes the folder browser dialog when it is created. This gives you an opportunity
        ///  to configure the dialog as you please. The default implementation provides a generic folder browser.
        /// </summary>
        private void InitializeDialog(FolderBrowser folderBrowser)
        {
            this._folderBrowser = folderBrowser;
        }

        private sealed class FolderBrowser : Component
        {
            // Description text to show.
            private string _descriptionText = string.Empty;
 
          
            /// <summary>
            ///  Gets the directory path of the folder the user picked.
            /// </summary>
            public string DirectoryPath { get; private set; } = string.Empty;
 
            /// <summary>
            ///  Gets/sets the start location of the root node.
            /// </summary>
            public Environment.SpecialFolder StartLocation { get; set; } = Environment.SpecialFolder.Desktop;
 
            /// <summary>
            ///  Gets or sets a description to show above the folders. Here you can provide instructions for
            ///  selecting a folder.
            /// </summary>
            public string Description
            {
                get => this._descriptionText;
                set => this._descriptionText = value ?? string.Empty;
            }
 
            /// <summary>
            ///  Shows the folder browser dialog.
            /// </summary>
            public DialogResult ShowDialog() => ShowDialog(null);
 
            /// <summary>
            ///  Shows the folder browser dialog with the specified owner.
            /// </summary>
            public  DialogResult ShowDialog(IWin32Window owner)
            {
                IWin32Window activeForm = Form.ActiveForm;
                if (owner != null)
                {
                    activeForm = owner;
                }


                FolderBrowserDialog dialog = new FolderBrowserDialog {RootFolder = Environment.SpecialFolder.Desktop};
                DialogResult result = dialog.ShowDialog(activeForm);
                if (result != DialogResult.OK)
                    return result;

                this.DirectoryPath = dialog.SelectedPath;
                return result;


            }
        }

        

       
       


       
 
        
    }
}