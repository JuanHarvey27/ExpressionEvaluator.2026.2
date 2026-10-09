namespace Frontend.Windows;
using Backend;
using System.Globalization;
using System.Linq.Expressions;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btn7_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "7";
    }

    private void btn6_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "6";
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtDisplay.Text = string.Empty;
    }

    private void btnPow_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "^";
    }

    private void btn8_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "8";
    }

    private void btn9_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "9";
    }

    private void btn4_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "4";
    }

    private void btn1_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "1";
    }

    private void btn2_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "2";
    }

    private void btn3_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "3";
    }

    private void btn0_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "0";
    }

    private void btnDot_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += ".";
    }

    private void btnOpenParenthesis_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "(";
    }

    private void btnCloseParenthesis_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += ")";
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
    }

    private void btnMultiply_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "*";
    }

    private void btnDivide_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "/";
    }

    private void btnPlus_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "+";
    }

    private void btnMinus_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "-";
    }

    private void btnResult_Click(object sender, EventArgs e)
    {
        double result = ExpressionEvaluator.Evaluate(txtDisplay.Text);
        txtDisplay.Text += $"={result.ToString(CultureInfo.InvariantCulture)}";
    }

    private void btn5_Click(object sender, EventArgs e)
    {
        txtDisplay.Text += "5";
    }
}
