using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBasicCalculator
{
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion
        #region Operator Methods

        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = string.Empty;
            FocusInputText();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
        }

        private void AddButton_Click(object sender, EventArgs e)
        { 
            InsertTextValue("+");
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("=");
        }

        #endregion

        #region Clearing_Methods

        private void DelButton_Click(object sender, EventArgs e)
        {

        }
        
        private void CButton_Click(object sender, EventArgs e)
        {

        }

        #endregion
        #region Number_Methods

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            sendCursorToEnd();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            sendCursorToEnd();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            sendCursorToEnd();
        }

        private void PeriodButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            sendCursorToEnd();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            sendCursorToEnd();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            sendCursorToEnd();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            sendCursorToEnd();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            sendCursorToEnd();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            sendCursorToEnd();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            sendCursorToEnd();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
        }

        #endregion

        #region Private_Helpers

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            UserInputText.Focus();
        }

        /// <summary>
        /// Inserts given text into the user input textbox
        /// </summary>
        /// <param name="numValue"></param>
        /// <returns></returns>
        private string InsertTextValue(string numValue)
        {
            return this.UserInputText.Text = this.UserInputText.Text.Insert(UserInputText.SelectionStart, numValue);
        }

        private void sendCursorToEnd()
        {
            UserInputText.SelectionStart = UserInputText.Text.Length + 1;
        }

        #endregion
    }
}
