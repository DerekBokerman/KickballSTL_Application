#region PDFsharp - A .NET library for processing PDF
//
// Authors:
//   PDFsharp Team (mailto:PDFsharpSupport@pdfsharp.de)
//
// Copyright (c) 2005-2009 empira Software GmbH, Cologne (Germany)
//
// http://www.pdfsharp.com
// http://sourceforge.net/projects/pdfsharp
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Diagnostics;
using System.IO;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

using System;
using System.Diagnostics;
using System.IO;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Data.OleDb;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {



            //MS Access SQL Initializer
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source= C:\Users\Lee\Desktop\Rottman Project\KickballSTL\kickballTeams.accdb";

            String kickballSQL = "SELECT season,divisionLocation,teamName FROM kickballTeams";

            conn.Open();

            



            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Times New Roman", 20, XFontStyle.BoldItalic);

            gfx.DrawString(season, font, XBrushes.Black, new XRect(40, 100, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString(divisionLocation, font, XBrushes.Black, new XRect(40, 100, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString(teamName, font, XBrushes.Black, new XRect(40, 100, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

            const string filename = "kickballTeams_Sample.pdf";
            document.Save(filename); //not saving the location, just saving it as a filename.

            Process.Start(filename); //instantly opens PDF file

            OleDbCommand cmd = new OleDbCommand(kickballSQL, conn);
            cmd.ExecuteNonQuery();


          //  OleDbDataAdapter ds = new OleDbDataAdapter(cmd);



            conn.Close();

        }
    }
}
