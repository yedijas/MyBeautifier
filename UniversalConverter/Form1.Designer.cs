namespace UniversalConverter
{
    partial class UniversalFormatter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSQL = new System.Windows.Forms.RadioButton();
            this.rbXML = new System.Windows.Forms.RadioButton();
            this.rbJSON = new System.Windows.Forms.RadioButton();
            this.rbHTML = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btBeautify = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbContent
            // 
            this.tbContent.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContent.Location = new System.Drawing.Point(12, 94);
            this.tbContent.MaxLength = 2147483647;
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbContent.Size = new System.Drawing.Size(1055, 522);
            this.tbContent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Make your text beautiful!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Step 1. Pick your format";
            // 
            // rbSQL
            // 
            this.rbSQL.AutoSize = true;
            this.rbSQL.Location = new System.Drawing.Point(12, 58);
            this.rbSQL.Name = "rbSQL";
            this.rbSQL.Size = new System.Drawing.Size(46, 17);
            this.rbSQL.TabIndex = 4;
            this.rbSQL.TabStop = true;
            this.rbSQL.Text = "SQL";
            this.rbSQL.UseVisualStyleBackColor = true;
            // 
            // rbXML
            // 
            this.rbXML.AutoSize = true;
            this.rbXML.Location = new System.Drawing.Point(64, 58);
            this.rbXML.Name = "rbXML";
            this.rbXML.Size = new System.Drawing.Size(47, 17);
            this.rbXML.TabIndex = 5;
            this.rbXML.TabStop = true;
            this.rbXML.Text = "XML";
            this.rbXML.UseVisualStyleBackColor = true;
            // 
            // rbJSON
            // 
            this.rbJSON.AutoSize = true;
            this.rbJSON.Location = new System.Drawing.Point(117, 58);
            this.rbJSON.Name = "rbJSON";
            this.rbJSON.Size = new System.Drawing.Size(53, 17);
            this.rbJSON.TabIndex = 6;
            this.rbJSON.TabStop = true;
            this.rbJSON.Text = "JSON";
            this.rbJSON.UseVisualStyleBackColor = true;
            // 
            // rbHTML
            // 
            this.rbHTML.AutoSize = true;
            this.rbHTML.Location = new System.Drawing.Point(176, 58);
            this.rbHTML.Name = "rbHTML";
            this.rbHTML.Size = new System.Drawing.Size(55, 17);
            this.rbHTML.TabIndex = 7;
            this.rbHTML.TabStop = true;
            this.rbHTML.Text = "HTML";
            this.rbHTML.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Step 2. Paste the ugly text";
            // 
            // btBeautify
            // 
            this.btBeautify.Location = new System.Drawing.Point(12, 622);
            this.btBeautify.Name = "btBeautify";
            this.btBeautify.Size = new System.Drawing.Size(1055, 23);
            this.btBeautify.TabIndex = 9;
            this.btBeautify.Text = "Step 3. Beautify that ugly text!";
            this.btBeautify.UseVisualStyleBackColor = true;
            this.btBeautify.Click += new System.EventHandler(this.btBeautify_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(429, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "This is a beautifier made with love and stress because it is hard to read those S" +
    "QL dumps!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UniversalFormatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 656);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btBeautify);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbHTML);
            this.Controls.Add(this.rbJSON);
            this.Controls.Add(this.rbXML);
            this.Controls.Add(this.rbSQL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbContent);
            this.Name = "UniversalFormatter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adit\'s Universal Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSQL;
        private System.Windows.Forms.RadioButton rbXML;
        private System.Windows.Forms.RadioButton rbJSON;
        private System.Windows.Forms.RadioButton rbHTML;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btBeautify;
        private System.Windows.Forms.Label label4;
    }
}

