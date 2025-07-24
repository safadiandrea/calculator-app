
namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            operatButtons = new TableLayoutPanel();
            eqlButton = new Button();
            decmlButton = new Button();
            zeroButton = new Button();
            posnegButton = new Button();
            addButton = new Button();
            threeButton = new Button();
            twoButton = new Button();
            oneButton = new Button();
            minButton = new Button();
            sixButton = new Button();
            fiveButton = new Button();
            fourButton = new Button();
            multButton = new Button();
            nineButton = new Button();
            eightButton = new Button();
            sevenButton = new Button();
            divButton = new Button();
            rootButton = new Button();
            sqrButton = new Button();
            recipButton = new Button();
            delButton = new Button();
            clrButton = new Button();
            clrallButton = new Button();
            pcentButton = new Button();
            memButtons = new TableLayoutPanel();
            memdwn = new Button();
            memS = new Button();
            memmin = new Button();
            memplus = new Button();
            memR = new Button();
            memC = new Button();
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            operatButtons.SuspendLayout();
            memButtons.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // operatButtons
            // 
            operatButtons.AutoSize = true;
            operatButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            operatButtons.ColumnCount = 4;
            operatButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            operatButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            operatButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            operatButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            operatButtons.Controls.Add(eqlButton, 3, 5);
            operatButtons.Controls.Add(decmlButton, 2, 5);
            operatButtons.Controls.Add(zeroButton, 1, 5);
            operatButtons.Controls.Add(posnegButton, 0, 5);
            operatButtons.Controls.Add(addButton, 3, 4);
            operatButtons.Controls.Add(threeButton, 2, 4);
            operatButtons.Controls.Add(twoButton, 1, 4);
            operatButtons.Controls.Add(oneButton, 0, 4);
            operatButtons.Controls.Add(minButton, 3, 3);
            operatButtons.Controls.Add(sixButton, 2, 3);
            operatButtons.Controls.Add(fiveButton, 1, 3);
            operatButtons.Controls.Add(fourButton, 0, 3);
            operatButtons.Controls.Add(multButton, 3, 2);
            operatButtons.Controls.Add(nineButton, 2, 2);
            operatButtons.Controls.Add(eightButton, 1, 2);
            operatButtons.Controls.Add(sevenButton, 0, 2);
            operatButtons.Controls.Add(divButton, 3, 1);
            operatButtons.Controls.Add(rootButton, 2, 1);
            operatButtons.Controls.Add(sqrButton, 1, 1);
            operatButtons.Controls.Add(recipButton, 0, 1);
            operatButtons.Controls.Add(delButton, 3, 0);
            operatButtons.Controls.Add(clrButton, 2, 0);
            operatButtons.Controls.Add(clrallButton, 1, 0);
            operatButtons.Controls.Add(pcentButton, 0, 0);
            operatButtons.Location = new Point(6, 149);
            operatButtons.Margin = new Padding(3, 2, 3, 2);
            operatButtons.Name = "operatButtons";
            operatButtons.RowCount = 6;
            operatButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            operatButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            operatButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            operatButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            operatButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            operatButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            operatButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            operatButtons.Size = new Size(356, 318);
            operatButtons.TabIndex = 0;
            operatButtons.Paint += tableLayoutPanel1_Paint;
            // 
            // eqlButton
            // 
            eqlButton.Dock = DockStyle.Fill;
            eqlButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eqlButton.Location = new Point(270, 267);
            eqlButton.Margin = new Padding(3, 2, 3, 2);
            eqlButton.Name = "eqlButton";
            eqlButton.Size = new Size(83, 49);
            eqlButton.TabIndex = 23;
            eqlButton.Text = "=";
            eqlButton.UseVisualStyleBackColor = true;
            eqlButton.Click += eqlButton_Click;
            // 
            // decmlButton
            // 
            decmlButton.Dock = DockStyle.Fill;
            decmlButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            decmlButton.Location = new Point(181, 267);
            decmlButton.Margin = new Padding(3, 2, 3, 2);
            decmlButton.Name = "decmlButton";
            decmlButton.Size = new Size(83, 49);
            decmlButton.TabIndex = 22;
            decmlButton.Text = ".";
            decmlButton.UseVisualStyleBackColor = true;
            decmlButton.Click += decmlButton_Click;
            // 
            // zeroButton
            // 
            zeroButton.Dock = DockStyle.Fill;
            zeroButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zeroButton.Location = new Point(92, 267);
            zeroButton.Margin = new Padding(3, 2, 3, 2);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(83, 49);
            zeroButton.TabIndex = 21;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            zeroButton.Click += NumberButton_Click;
            // 
            // posnegButton
            // 
            posnegButton.Dock = DockStyle.Fill;
            posnegButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            posnegButton.Location = new Point(3, 267);
            posnegButton.Margin = new Padding(3, 2, 3, 2);
            posnegButton.Name = "posnegButton";
            posnegButton.Size = new Size(83, 49);
            posnegButton.TabIndex = 20;
            posnegButton.Text = "±";
            posnegButton.UseVisualStyleBackColor = true;
            posnegButton.Click += posnegButton_Click;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Fill;
            addButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.Location = new Point(270, 214);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(83, 49);
            addButton.TabIndex = 19;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // threeButton
            // 
            threeButton.Dock = DockStyle.Fill;
            threeButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            threeButton.Location = new Point(181, 214);
            threeButton.Margin = new Padding(3, 2, 3, 2);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(83, 49);
            threeButton.TabIndex = 18;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = true;
            threeButton.Click += NumberButton_Click;
            // 
            // twoButton
            // 
            twoButton.Dock = DockStyle.Fill;
            twoButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            twoButton.Location = new Point(92, 214);
            twoButton.Margin = new Padding(3, 2, 3, 2);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(83, 49);
            twoButton.TabIndex = 17;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = true;
            twoButton.Click += NumberButton_Click;
            // 
            // oneButton
            // 
            oneButton.Dock = DockStyle.Fill;
            oneButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oneButton.Location = new Point(3, 214);
            oneButton.Margin = new Padding(3, 2, 3, 2);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(83, 49);
            oneButton.TabIndex = 16;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = true;
            oneButton.Click += NumberButton_Click;
            // 
            // minButton
            // 
            minButton.Dock = DockStyle.Fill;
            minButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minButton.Location = new Point(270, 161);
            minButton.Margin = new Padding(3, 2, 3, 2);
            minButton.Name = "minButton";
            minButton.Size = new Size(83, 49);
            minButton.TabIndex = 15;
            minButton.Text = "−";
            minButton.UseVisualStyleBackColor = true;
            minButton.Click += minButton_Click;
            // 
            // sixButton
            // 
            sixButton.Dock = DockStyle.Fill;
            sixButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sixButton.Location = new Point(181, 161);
            sixButton.Margin = new Padding(3, 2, 3, 2);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(83, 49);
            sixButton.TabIndex = 14;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = true;
            sixButton.Click += NumberButton_Click;
            // 
            // fiveButton
            // 
            fiveButton.Dock = DockStyle.Fill;
            fiveButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fiveButton.Location = new Point(92, 161);
            fiveButton.Margin = new Padding(3, 2, 3, 2);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(83, 49);
            fiveButton.TabIndex = 13;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = true;
            fiveButton.Click += NumberButton_Click;
            // 
            // fourButton
            // 
            fourButton.Dock = DockStyle.Fill;
            fourButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fourButton.Location = new Point(3, 161);
            fourButton.Margin = new Padding(3, 2, 3, 2);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(83, 49);
            fourButton.TabIndex = 12;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = true;
            fourButton.Click += NumberButton_Click;
            // 
            // multButton
            // 
            multButton.Dock = DockStyle.Fill;
            multButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            multButton.Location = new Point(270, 108);
            multButton.Margin = new Padding(3, 2, 3, 2);
            multButton.Name = "multButton";
            multButton.Size = new Size(83, 49);
            multButton.TabIndex = 11;
            multButton.Text = "×";
            multButton.UseVisualStyleBackColor = true;
            multButton.Click += multButton_Click;
            // 
            // nineButton
            // 
            nineButton.Dock = DockStyle.Fill;
            nineButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nineButton.Location = new Point(181, 108);
            nineButton.Margin = new Padding(3, 2, 3, 2);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(83, 49);
            nineButton.TabIndex = 10;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = true;
            nineButton.Click += NumberButton_Click;
            // 
            // eightButton
            // 
            eightButton.Dock = DockStyle.Fill;
            eightButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eightButton.Location = new Point(92, 108);
            eightButton.Margin = new Padding(3, 2, 3, 2);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(83, 49);
            eightButton.TabIndex = 9;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = true;
            eightButton.Click += NumberButton_Click;
            // 
            // sevenButton
            // 
            sevenButton.Dock = DockStyle.Fill;
            sevenButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sevenButton.Location = new Point(3, 108);
            sevenButton.Margin = new Padding(3, 2, 3, 2);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(83, 49);
            sevenButton.TabIndex = 8;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = true;
            sevenButton.Click += NumberButton_Click;
            // 
            // divButton
            // 
            divButton.Dock = DockStyle.Fill;
            divButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divButton.Location = new Point(270, 55);
            divButton.Margin = new Padding(3, 2, 3, 2);
            divButton.Name = "divButton";
            divButton.Size = new Size(83, 49);
            divButton.TabIndex = 7;
            divButton.Text = "÷";
            divButton.UseVisualStyleBackColor = true;
            divButton.Click += divButton_Click;
            // 
            // rootButton
            // 
            rootButton.Dock = DockStyle.Fill;
            rootButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rootButton.Location = new Point(181, 55);
            rootButton.Margin = new Padding(3, 2, 3, 2);
            rootButton.Name = "rootButton";
            rootButton.Size = new Size(83, 49);
            rootButton.TabIndex = 6;
            rootButton.Text = "√";
            rootButton.UseVisualStyleBackColor = true;
            rootButton.Click += rootButton_Click;
            // 
            // sqrButton
            // 
            sqrButton.Dock = DockStyle.Fill;
            sqrButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sqrButton.Location = new Point(92, 55);
            sqrButton.Margin = new Padding(3, 2, 3, 2);
            sqrButton.Name = "sqrButton";
            sqrButton.Size = new Size(83, 49);
            sqrButton.TabIndex = 5;
            sqrButton.Text = "x²";
            sqrButton.UseVisualStyleBackColor = true;
            sqrButton.Click += sqrButton_Click;
            // 
            // recipButton
            // 
            recipButton.Dock = DockStyle.Fill;
            recipButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recipButton.Location = new Point(3, 55);
            recipButton.Margin = new Padding(3, 2, 3, 2);
            recipButton.Name = "recipButton";
            recipButton.Size = new Size(83, 49);
            recipButton.TabIndex = 4;
            recipButton.Text = "xˉ¹";
            recipButton.UseVisualStyleBackColor = true;
            recipButton.Click += recipButton_Click;
            // 
            // delButton
            // 
            delButton.Dock = DockStyle.Fill;
            delButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delButton.Location = new Point(270, 2);
            delButton.Margin = new Padding(3, 2, 3, 2);
            delButton.Name = "delButton";
            delButton.Size = new Size(83, 49);
            delButton.TabIndex = 3;
            delButton.Text = "DEL";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // clrButton
            // 
            clrButton.Dock = DockStyle.Fill;
            clrButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clrButton.Location = new Point(181, 2);
            clrButton.Margin = new Padding(3, 2, 3, 2);
            clrButton.Name = "clrButton";
            clrButton.Size = new Size(83, 49);
            clrButton.TabIndex = 2;
            clrButton.Text = "C";
            clrButton.UseVisualStyleBackColor = true;
            clrButton.Click += clrButton_Click;
            // 
            // clrallButton
            // 
            clrallButton.Dock = DockStyle.Fill;
            clrallButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clrallButton.Location = new Point(92, 2);
            clrallButton.Margin = new Padding(3, 2, 3, 2);
            clrallButton.Name = "clrallButton";
            clrallButton.Size = new Size(83, 49);
            clrallButton.TabIndex = 1;
            clrallButton.Text = "CE";
            clrallButton.UseVisualStyleBackColor = true;
            clrallButton.Click += clrallButton_Click;
            // 
            // pcentButton
            // 
            pcentButton.Dock = DockStyle.Fill;
            pcentButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pcentButton.Location = new Point(3, 2);
            pcentButton.Margin = new Padding(3, 2, 3, 2);
            pcentButton.Name = "pcentButton";
            pcentButton.Size = new Size(83, 49);
            pcentButton.TabIndex = 0;
            pcentButton.Text = "%";
            pcentButton.UseVisualStyleBackColor = true;
            pcentButton.Click += pcentButton_Click;
            // 
            // memButtons
            // 
            memButtons.AutoSize = true;
            memButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            memButtons.ColumnCount = 6;
            memButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            memButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            memButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            memButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            memButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            memButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            memButtons.Controls.Add(memdwn, 5, 0);
            memButtons.Controls.Add(memS, 4, 0);
            memButtons.Controls.Add(memmin, 3, 0);
            memButtons.Controls.Add(memplus, 2, 0);
            memButtons.Controls.Add(memR, 1, 0);
            memButtons.Controls.Add(memC, 0, 0);
            memButtons.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            memButtons.Location = new Point(0, 116);
            memButtons.Margin = new Padding(3, 2, 3, 2);
            memButtons.Name = "memButtons";
            memButtons.RowCount = 1;
            memButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            memButtons.Size = new Size(366, 30);
            memButtons.TabIndex = 1;
            // 
            // memdwn
            // 
            memdwn.Dock = DockStyle.Fill;
            memdwn.Location = new Point(308, 2);
            memdwn.Margin = new Padding(3, 2, 3, 2);
            memdwn.Name = "memdwn";
            memdwn.Size = new Size(55, 26);
            memdwn.TabIndex = 7;
            memdwn.Text = "M˅";
            memdwn.UseVisualStyleBackColor = true;
            // 
            // memS
            // 
            memS.Dock = DockStyle.Fill;
            memS.Location = new Point(247, 2);
            memS.Margin = new Padding(3, 2, 3, 2);
            memS.Name = "memS";
            memS.Size = new Size(55, 26);
            memS.TabIndex = 6;
            memS.Text = "MS";
            memS.UseVisualStyleBackColor = true;
            // 
            // memmin
            // 
            memmin.Dock = DockStyle.Fill;
            memmin.Location = new Point(186, 2);
            memmin.Margin = new Padding(3, 2, 3, 2);
            memmin.Name = "memmin";
            memmin.Size = new Size(55, 26);
            memmin.TabIndex = 5;
            memmin.Text = "M-";
            memmin.UseVisualStyleBackColor = true;
            // 
            // memplus
            // 
            memplus.Dock = DockStyle.Fill;
            memplus.Location = new Point(125, 2);
            memplus.Margin = new Padding(3, 2, 3, 2);
            memplus.Name = "memplus";
            memplus.Size = new Size(55, 26);
            memplus.TabIndex = 4;
            memplus.Text = "M+";
            memplus.UseVisualStyleBackColor = true;
            // 
            // memR
            // 
            memR.Dock = DockStyle.Fill;
            memR.Location = new Point(64, 2);
            memR.Margin = new Padding(3, 2, 3, 2);
            memR.Name = "memR";
            memR.Size = new Size(55, 26);
            memR.TabIndex = 3;
            memR.Text = "MR";
            memR.UseVisualStyleBackColor = true;
            // 
            // memC
            // 
            memC.Dock = DockStyle.Fill;
            memC.Location = new Point(3, 2);
            memC.Margin = new Padding(3, 2, 3, 2);
            memC.Name = "memC";
            memC.Size = new Size(55, 26);
            memC.TabIndex = 2;
            memC.Text = "MC";
            memC.UseVisualStyleBackColor = true;
            memC.Click += memC_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 118);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(9, 51);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(342, 64);
            textBox1.TabIndex = 3;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(363, 473);
            Controls.Add(panel1);
            Controls.Add(memButtons);
            Controls.Add(operatButtons);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "CalculatorApp";
            TransparencyKey = SystemColors.ActiveCaption;
            Load += Form1_Load;
            operatButtons.ResumeLayout(false);
            memButtons.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel operatButtons;
        private TableLayoutPanel memButtons;
        private Button memS;
        private Button memmin;
        private Button memplus;
        private Button memR;
        private Button memC;
        private Button memdwn;
        private Button pcentButton;
        private Button eqlButton;
        private Button decmlButton;
        private Button zeroButton;
        private Button posnegButton;
        private Button addButton;
        private Button threeButton;
        private Button twoButton;
        private Button oneButton;
        private Button minButton;
        private Button sixButton;
        private Button fiveButton;
        private Button fourButton;
        private Button multButton;
        private Button nineButton;
        private Button eightButton;
        private Button sevenButton;
        private Button divButton;
        private Button rootButton;
        private Button sqrButton;
        private Button recipButton;
        private Button delButton;
        private Button clrButton;
        private Button clrallButton;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
    }
}
