// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 11: Creating MVC Applications
// AUTHOR: Steven Partlow
// DATE: 22/02/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntroToWebForms
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text; // Set the value of Label1 text property to the value of the text property of TextBox1
        } // End Button1_Click
    }
}