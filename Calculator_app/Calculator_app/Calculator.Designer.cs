namespace Calculator_app
{
    partial class Calculator
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
            TxtBox = new TextBox();
            sevenBtn = new Button();
            fourBtn = new Button();
            oneBtn = new Button();
            zeroBtn = new Button();
            dotBtn = new Button();
            twoBtn = new Button();
            fiveBtn = new Button();
            eightBtn = new Button();
            equalBtn = new Button();
            threeBtn = new Button();
            sixBtn = new Button();
            nineBtn = new Button();
            moduleBtn = new Button();
            multiplyBtn = new Button();
            plusBtn = new Button();
            minusPlusBtn = new Button();
            devideBtn = new Button();
            minusBtn = new Button();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Font = new Font("DS-Digital", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBox.Location = new Point(12, 16);
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(500, 40);
            TxtBox.TabIndex = 0;
            TxtBox.Text = "0";
            TxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // sevenBtn
            // 
            sevenBtn.Font = new Font("Segoe UI", 12F);
            sevenBtn.Location = new Point(12, 92);
            sevenBtn.Name = "sevenBtn";
            sevenBtn.Size = new Size(83, 80);
            sevenBtn.TabIndex = 1;
            sevenBtn.Text = "7";
            sevenBtn.UseVisualStyleBackColor = true;
            sevenBtn.Click += sevenBtn_Click;
            // 
            // fourBtn
            // 
            fourBtn.Font = new Font("Segoe UI", 12F);
            fourBtn.Location = new Point(12, 178);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(83, 80);
            fourBtn.TabIndex = 2;
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = true;
            fourBtn.Click += fourBtn_Click;
            // 
            // oneBtn
            // 
            oneBtn.Font = new Font("Segoe UI", 12F);
            oneBtn.Location = new Point(12, 264);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(83, 80);
            oneBtn.TabIndex = 3;
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = true;
            oneBtn.Click += oneBtn_Click;
            // 
            // zeroBtn
            // 
            zeroBtn.Font = new Font("Segoe UI", 12F);
            zeroBtn.Location = new Point(12, 350);
            zeroBtn.Name = "zeroBtn";
            zeroBtn.Size = new Size(83, 80);
            zeroBtn.TabIndex = 4;
            zeroBtn.Text = "0";
            zeroBtn.UseVisualStyleBackColor = true;
            zeroBtn.Click += zeroBtn_Click;
            // 
            // dotBtn
            // 
            dotBtn.Font = new Font("Segoe UI", 12F);
            dotBtn.Location = new Point(101, 350);
            dotBtn.Name = "dotBtn";
            dotBtn.Size = new Size(83, 80);
            dotBtn.TabIndex = 8;
            dotBtn.Text = ".";
            dotBtn.UseVisualStyleBackColor = true;
            dotBtn.Click += dotBtn_Click;
            // 
            // twoBtn
            // 
            twoBtn.Font = new Font("Segoe UI", 12F);
            twoBtn.Location = new Point(101, 264);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(83, 80);
            twoBtn.TabIndex = 7;
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = true;
            twoBtn.Click += twoBtn_Click;
            // 
            // fiveBtn
            // 
            fiveBtn.Font = new Font("Segoe UI", 12F);
            fiveBtn.Location = new Point(101, 178);
            fiveBtn.Name = "fiveBtn";
            fiveBtn.Size = new Size(83, 80);
            fiveBtn.TabIndex = 6;
            fiveBtn.Text = "5";
            fiveBtn.UseVisualStyleBackColor = true;
            fiveBtn.Click += fiveBtn_Click;
            // 
            // eightBtn
            // 
            eightBtn.Font = new Font("Segoe UI", 12F);
            eightBtn.Location = new Point(101, 92);
            eightBtn.Name = "eightBtn";
            eightBtn.Size = new Size(83, 80);
            eightBtn.TabIndex = 5;
            eightBtn.Text = "8";
            eightBtn.UseVisualStyleBackColor = true;
            eightBtn.Click += eightBtn_Click;
            // 
            // equalBtn
            // 
            equalBtn.Font = new Font("Segoe UI", 12F);
            equalBtn.Location = new Point(190, 350);
            equalBtn.Name = "equalBtn";
            equalBtn.Size = new Size(83, 80);
            equalBtn.TabIndex = 12;
            equalBtn.Text = "=";
            equalBtn.UseVisualStyleBackColor = true;
            equalBtn.Click += equalBtn_Click;
            // 
            // threeBtn
            // 
            threeBtn.Font = new Font("Segoe UI", 12F);
            threeBtn.Location = new Point(190, 264);
            threeBtn.Name = "threeBtn";
            threeBtn.Size = new Size(83, 80);
            threeBtn.TabIndex = 11;
            threeBtn.Text = "3";
            threeBtn.UseVisualStyleBackColor = true;
            threeBtn.Click += threeBtn_Click;
            // 
            // sixBtn
            // 
            sixBtn.Font = new Font("Segoe UI", 12F);
            sixBtn.Location = new Point(190, 178);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(83, 80);
            sixBtn.TabIndex = 10;
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = true;
            sixBtn.Click += sixBtn_Click;
            // 
            // nineBtn
            // 
            nineBtn.Font = new Font("Segoe UI", 12F);
            nineBtn.Location = new Point(190, 92);
            nineBtn.Name = "nineBtn";
            nineBtn.Size = new Size(83, 80);
            nineBtn.TabIndex = 9;
            nineBtn.Text = "9";
            nineBtn.UseVisualStyleBackColor = true;
            nineBtn.Click += nineBtn_Click;
            // 
            // moduleBtn
            // 
            moduleBtn.Font = new Font("Segoe UI", 12F);
            moduleBtn.Location = new Point(429, 350);
            moduleBtn.Name = "moduleBtn";
            moduleBtn.Size = new Size(83, 80);
            moduleBtn.TabIndex = 20;
            moduleBtn.Text = "%";
            moduleBtn.UseVisualStyleBackColor = true;
            moduleBtn.Click += moduleBtn_Click;
            // 
            // multiplyBtn
            // 
            multiplyBtn.Font = new Font("Segoe UI", 12F);
            multiplyBtn.Location = new Point(429, 264);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(83, 80);
            multiplyBtn.TabIndex = 19;
            multiplyBtn.Text = "x";
            multiplyBtn.UseVisualStyleBackColor = true;
            multiplyBtn.Click += multiplyBtn_Click;
            // 
            // plusBtn
            // 
            plusBtn.Font = new Font("Segoe UI", 12F);
            plusBtn.Location = new Point(429, 178);
            plusBtn.Name = "plusBtn";
            plusBtn.Size = new Size(83, 80);
            plusBtn.TabIndex = 18;
            plusBtn.Text = "+";
            plusBtn.UseVisualStyleBackColor = true;
            plusBtn.Click += plusBtn_Click;
            // 
            // minusPlusBtn
            // 
            minusPlusBtn.Font = new Font("Segoe UI", 12F);
            minusPlusBtn.Location = new Point(340, 350);
            minusPlusBtn.Name = "minusPlusBtn";
            minusPlusBtn.Size = new Size(83, 80);
            minusPlusBtn.TabIndex = 16;
            minusPlusBtn.Text = "-/+";
            minusPlusBtn.UseVisualStyleBackColor = true;
            minusPlusBtn.Click += minusPlusBtn_Click;
            // 
            // devideBtn
            // 
            devideBtn.Font = new Font("Segoe UI", 12F);
            devideBtn.Location = new Point(340, 264);
            devideBtn.Name = "devideBtn";
            devideBtn.Size = new Size(83, 80);
            devideBtn.TabIndex = 15;
            devideBtn.Text = "/";
            devideBtn.UseVisualStyleBackColor = true;
            devideBtn.Click += devideBtn_Click;
            // 
            // minusBtn
            // 
            minusBtn.Font = new Font("Segoe UI", 12F);
            minusBtn.Location = new Point(340, 178);
            minusBtn.Name = "minusBtn";
            minusBtn.Size = new Size(83, 80);
            minusBtn.TabIndex = 14;
            minusBtn.Text = "-";
            minusBtn.UseVisualStyleBackColor = true;
            minusBtn.Click += minusBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Segoe UI", 12F);
            clearBtn.Location = new Point(340, 92);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(172, 80);
            clearBtn.TabIndex = 13;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 438);
            Controls.Add(moduleBtn);
            Controls.Add(multiplyBtn);
            Controls.Add(plusBtn);
            Controls.Add(minusPlusBtn);
            Controls.Add(devideBtn);
            Controls.Add(minusBtn);
            Controls.Add(clearBtn);
            Controls.Add(equalBtn);
            Controls.Add(threeBtn);
            Controls.Add(sixBtn);
            Controls.Add(nineBtn);
            Controls.Add(dotBtn);
            Controls.Add(twoBtn);
            Controls.Add(fiveBtn);
            Controls.Add(eightBtn);
            Controls.Add(zeroBtn);
            Controls.Add(oneBtn);
            Controls.Add(fourBtn);
            Controls.Add(sevenBtn);
            Controls.Add(TxtBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Calculator";
            Text = "Calculator app";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Button sevenBtn;
        private Button fourBtn;
        private Button oneBtn;
        private Button zeroBtn;
        private Button dotBtn;
        private Button twoBtn;
        private Button fiveBtn;
        private Button eightBtn;
        private Button equalBtn;
        private Button threeBtn;
        private Button sixBtn;
        private Button nineBtn;
        private Button moduleBtn;
        private Button multiplyBtn;
        private Button plusBtn;
        private Button minusPlusBtn;
        private Button devideBtn;
        private Button minusBtn;
        private Button clearBtn;
    }
}
