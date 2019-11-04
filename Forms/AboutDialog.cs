﻿using System;
using System.IO;
using System.Windows.Forms;
using CDBurnerXP;

namespace Toolkit.Forms
{
    /// <summary>
    /// Represents a dialog which shows the about information
    /// for GeGeek. The path to the database file is also included.
    /// </summary>
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            CancelButton = bClose;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            lblVersion.Text = Application.ProductVersion;
            lblDatabasePath.Text = Utility.CompactString(DbManager.DatabasePath, Width - 170, Font, "");
            lblDatabasePath.Url = Path.GetDirectoryName(DbManager.DatabasePath);
            txtAuthor.Text = Settings.GetValue("AuthorGuid").ToString().ToUpper();
        }
    }
}
