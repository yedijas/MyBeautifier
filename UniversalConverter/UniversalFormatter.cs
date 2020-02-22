using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using PoorMansTSqlFormatterLib;
using TidyManaged;

namespace UniversalConverter
{
    public partial class UniversalFormatter : Form
    {
        private enum ToFormat { SQL, XML, JSON, HTML, Invalid }
        private ToFormat formatType;

        public UniversalFormatter()
        {
            InitializeComponent();
        }

        private void btBeautify_Click(object sender, EventArgs e)
        {
            if (ValidateTheInputs())
            {
                switch (formatType)
                {
                    case ToFormat.SQL:
                        BeautifyThatSQLShit();
                        break;
                    case ToFormat.JSON:
                        BeautifyThatJSONShit();
                        break;
                    case ToFormat.XML:
                        BeautifyThatXMLShit();
                        break;
                    case ToFormat.HTML:
                        BeautifyThatHTMLShit();
                        break;
                    default:
                        MessageBox.Show("Follow the steps, do step 2 first!", "Damn, you're too fast!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void BeautifyThatSQLShit()
        {
            StringBuilder sb = new StringBuilder();
            SqlFormattingManager sqlFormatManager = new SqlFormattingManager();
            sb.Append(sqlFormatManager.Format(tbContent.Text));
            tbContent.Text = sb.ToString();
            return;
        }

        private void BeautifyThatXMLShit()
        {
            var stringBuilder = new StringBuilder();
            try
            {
                var element = XElement.Parse(tbContent.Text);

                var settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.NewLineOnAttributes = true;
                settings.NewLineHandling = NewLineHandling.Replace;


                using (var xmlWriter = XmlWriter.Create(stringBuilder, settings))
                {
                    element.Save(xmlWriter);
                }
            }
            catch (XmlException xmlex)
            {
                MessageBox.Show("Your XML format is bad, please check again! \n\n" + xmlex.Message, "Damn, you're causin' errors!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tbContent.Text = stringBuilder.ToString();
            return;
        }

        private void BeautifyThatJSONShit()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(JToken.Parse(tbContent.Text).ToString(Newtonsoft.Json.Formatting.Indented));
                tbContent.Text = sb.ToString();
            }catch (Newtonsoft.Json.JsonReaderException jrex)
            {
                MessageBox.Show("Your JSON format is bad, please check again! \n\n" + jrex.Message, "Damn, you're causin' errors!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        private void BeautifyThatHTMLShit()
        {
            using (Document doc = Document.FromString(tbContent.Text))
            {
                doc.Quiet = true;
                doc.OutputXhtml = true;
                doc.IndentAttributes = true;
                doc.MakeClean = true;
                doc.NewLine = NewlineType.CarriageReturnLinefeed;
                doc.IndentBlockElements  = AutoBool.Yes;
                doc.CleanAndRepair();
                tbContent.Text = doc.Save();
            }
            return;
        }

        private bool ValidateTheInputs()
        {
            if (!rbSQL.Checked && !rbXML.Checked && !rbJSON.Checked && !rbHTML.Checked)
            {
                MessageBox.Show("Follow the steps, do step 1 first!", "Damn, you're too fast!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((rbSQL.Checked || rbXML.Checked || rbJSON.Checked || rbHTML.Checked) && String.IsNullOrEmpty(tbContent.Text))
            {
                MessageBox.Show("Follow the steps, do step 2 first!", "Damn, you're too fast!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (rbSQL.Checked)
            {
                formatType = ToFormat.SQL;
                return true;
            }
            if (rbXML.Checked)
            {
                formatType = ToFormat.XML;
                return true;
            }
            if (rbJSON.Checked)
            {
                formatType = ToFormat.JSON;
                return true;
            }
            if (rbHTML.Checked)
            {
                formatType = ToFormat.HTML;
                return true;
            }
            formatType = ToFormat.Invalid;
            return false;
        }
    }
}
