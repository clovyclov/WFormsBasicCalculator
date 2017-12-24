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
            sendCursorToEnd();
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
            sendCursorToEnd();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
            sendCursorToEnd();
        }

        private void AddButton_Click(object sender, EventArgs e)
        { 
            InsertTextValue("+");
            sendCursorToEnd();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();
        }

        #endregion

        #region Clearing_Methods

        private void DelButton_Click(object sender, EventArgs e)
        {

            DeleteTextValue();
            //if (UserInputText.Text.Length >= UserInputText.SelectionStart + 1)
            //    return;
            
            //this.UserInputText.Text = this.UserInputText.Text.Remove(UserInputText.SelectionStart - 1, 1);
           
            //sendCursorToEnd();

            FocusInputText();
        }
        
        private void CButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Number_Methods

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
        }

        private void PeriodButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
        }

        #endregion

        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {

        }

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
        private void InsertTextValue(string numValue)
        {
            //Remember selection start
            var selectionStart = UserInputText.SelectionStart;

            //Set new text
            UserInputText.Text = UserInputText.Text.Insert(UserInputText.SelectionStart, numValue);

            //Restore the selection start
            this.UserInputText.SelectionStart = selectionStart + numValue.Length;

            //Set selection length to 0
            UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Deletes the character to the right of the selection start.
        /// </summary>
        public void DeleteTextValue()
        {
            var selectionStart = UserInputText.SelectionStart;

            if (UserInputText.SelectionStart <= 0)
                return;

            UserInputText.Text = UserInputText.Text.Remove(UserInputText.SelectionStart - 1, 1);

            UserInputText.SelectionStart = selectionStart - 1;
        }

        private void sendCursorToEnd()
        {
            UserInputText.SelectionStart = UserInputText.Text.Length + 1;

            if (UserInputText.Text.Length >= UserInputText.SelectionStart + 1);

        }

        #endregion
    }

}
