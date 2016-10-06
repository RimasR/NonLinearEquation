namespace EquationSolverForms
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBisectionSolve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEpsilon = new System.Windows.Forms.TextBox();
            this.textBoxHigher = new System.Windows.Forms.TextBox();
            this.textBoxLower = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxNewton = new System.Windows.Forms.TextBox();
            this.buttonSolveNewton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBoxNewtonsEpsilon = new System.Windows.Forms.TextBox();
            this.textBoxNewtonsArtinys = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(407, 391);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.buttonBisectionSolve);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxEpsilon);
            this.tabPage1.Controls.Add(this.textBoxHigher);
            this.tabPage1.Controls.Add(this.textBoxLower);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(399, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bisection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 119);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(387, 240);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Sveiki atvyke į pusiaukirtos metodo skaičiuoklę. Prašome suvesti reikalingus duom" +
    "enis.";
            // 
            // buttonBisectionSolve
            // 
            this.buttonBisectionSolve.Location = new System.Drawing.Point(130, 84);
            this.buttonBisectionSolve.Name = "buttonBisectionSolve";
            this.buttonBisectionSolve.Size = new System.Drawing.Size(75, 23);
            this.buttonBisectionSolve.TabIndex = 6;
            this.buttonBisectionSolve.Text = "Solve!";
            this.buttonBisectionSolve.UseVisualStyleBackColor = true;
            this.buttonBisectionSolve.Click += new System.EventHandler(this.buttonBisectionSolve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Epsilon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Higher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lower";
            // 
            // textBoxEpsilon
            // 
            this.textBoxEpsilon.Location = new System.Drawing.Point(105, 58);
            this.textBoxEpsilon.Name = "textBoxEpsilon";
            this.textBoxEpsilon.Size = new System.Drawing.Size(100, 20);
            this.textBoxEpsilon.TabIndex = 2;
            // 
            // textBoxHigher
            // 
            this.textBoxHigher.Location = new System.Drawing.Point(105, 32);
            this.textBoxHigher.Name = "textBoxHigher";
            this.textBoxHigher.Size = new System.Drawing.Size(100, 20);
            this.textBoxHigher.TabIndex = 1;
            // 
            // textBoxLower
            // 
            this.textBoxLower.Location = new System.Drawing.Point(105, 6);
            this.textBoxLower.Name = "textBoxLower";
            this.textBoxLower.Size = new System.Drawing.Size(100, 20);
            this.textBoxLower.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxNewton);
            this.tabPage2.Controls.Add(this.buttonSolveNewton);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label);
            this.tabPage2.Controls.Add(this.textBoxNewtonsEpsilon);
            this.tabPage2.Controls.Add(this.textBoxNewtonsArtinys);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(399, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Newtons";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(413, 22);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(972, 605);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // textBoxNewton
            // 
            this.textBoxNewton.Location = new System.Drawing.Point(6, 119);
            this.textBoxNewton.Multiline = true;
            this.textBoxNewton.Name = "textBoxNewton";
            this.textBoxNewton.Size = new System.Drawing.Size(387, 240);
            this.textBoxNewton.TabIndex = 15;
            this.textBoxNewton.Text = "Sveiki atvyke į Niutono metodo skaičiuoklę. Prašome suvesti reikalingus duomenis." +
    "";
            // 
            // buttonSolveNewton
            // 
            this.buttonSolveNewton.Location = new System.Drawing.Point(130, 58);
            this.buttonSolveNewton.Name = "buttonSolveNewton";
            this.buttonSolveNewton.Size = new System.Drawing.Size(75, 23);
            this.buttonSolveNewton.TabIndex = 14;
            this.buttonSolveNewton.Text = "Solve!";
            this.buttonSolveNewton.UseVisualStyleBackColor = true;
            this.buttonSolveNewton.Click += new System.EventHandler(this.buttonSolveNewton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Epsilon";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(8, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 13);
            this.label.TabIndex = 11;
            this.label.Text = "Artinys";
            // 
            // textBoxNewtonsEpsilon
            // 
            this.textBoxNewtonsEpsilon.Location = new System.Drawing.Point(105, 32);
            this.textBoxNewtonsEpsilon.Name = "textBoxNewtonsEpsilon";
            this.textBoxNewtonsEpsilon.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewtonsEpsilon.TabIndex = 10;
            // 
            // textBoxNewtonsArtinys
            // 
            this.textBoxNewtonsArtinys.Location = new System.Drawing.Point(105, 6);
            this.textBoxNewtonsArtinys.Name = "textBoxNewtonsArtinys";
            this.textBoxNewtonsArtinys.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewtonsArtinys.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 639);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonBisectionSolve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEpsilon;
        private System.Windows.Forms.TextBox textBoxHigher;
        private System.Windows.Forms.TextBox textBoxLower;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxNewton;
        private System.Windows.Forms.Button buttonSolveNewton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxNewtonsEpsilon;
        private System.Windows.Forms.TextBox textBoxNewtonsArtinys;
    }
}

