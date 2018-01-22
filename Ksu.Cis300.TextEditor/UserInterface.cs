﻿/* UserInterface.cs
 * Author: Rod Howell
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// A user interface for a simple text editor.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Error printing stuff
        /// </summary>
        /// <param name="e">the Thrown Exception</param>
        private static void Error(Exception e)
        {
            MessageBox.Show("The following error occured: " + e);
        }
        /// <summary>
        /// Handles a Click event on the "Open . . ." button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxOpenDialog.ShowDialog() == DialogResult.OK)
                {
                    uxDisplay.Text = File.ReadAllText(uxOpenDialog.FileName);

                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        /// <summary>
        /// Handles a Click event on the "Save As . . ." button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxSaveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(uxSaveDialog.FileName, uxDisplay.Text);
                   
                }
            }
            catch (Exception ex)
            {

                Error(ex);
            }
        }

        private void uxDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
