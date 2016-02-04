namespace VisualSorting {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if(disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numOfPillars = new System.Windows.Forms.NumericUpDown();
            this.btnAddPillar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPillarAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfPillars)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Adaptive Merge Sort (std::stable_sort)",
            "Bitonic Sort",
            "Bogo Sort",
            "Bozo Sort",
            "Bubble Sort",
            "Cocktail Shaker Sort",
            "Comb Sort",
            "Cycle Sort",
            "Gnome Sort",
            "Heap Sort",
            "Insertion Sort",
            "Introsort (std::sort from STL)",
            "Merge Sort",
            "Odd-Even Merge Sort",
            "Odd-Even Sort",
            "Quick Sort (LR pointers)",
            "Quick Sort (LL pointers)",
            "Quick Sort (Ternary split)",
            "Radix Sort (LSD)",
            "Radix Sort (MSD)",
            "Selection Sort",
            "Shell Sort",
            "Slow Sort",
            "Smooth Sort",
            "Stooge Sort",
            "Tim Sort"});
            this.comboBox1.Location = new System.Drawing.Point(6, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPillarAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numOfPillars);
            this.groupBox1.Controls.Add(this.btnAddPillar);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(1303, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 716);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // numOfPillars
            // 
            this.numOfPillars.Location = new System.Drawing.Point(6, 133);
            this.numOfPillars.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numOfPillars.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numOfPillars.Name = "numOfPillars";
            this.numOfPillars.Size = new System.Drawing.Size(97, 20);
            this.numOfPillars.TabIndex = 5;
            this.numOfPillars.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // btnAddPillar
            // 
            this.btnAddPillar.Location = new System.Drawing.Point(9, 19);
            this.btnAddPillar.Name = "btnAddPillar";
            this.btnAddPillar.Size = new System.Drawing.Size(97, 23);
            this.btnAddPillar.TabIndex = 4;
            this.btnAddPillar.Text = "Add pillar";
            this.btnAddPillar.UseVisualStyleBackColor = true;
            this.btnAddPillar.Click += new System.EventHandler(this.btnAddPillar_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(109, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(6, 668);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 42);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of algorythm + # of iterations + # of comparisons + Time elapsed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "PillarsDrawn: ";
            // 
            // btnPillarAdd
            // 
            this.btnPillarAdd.Location = new System.Drawing.Point(9, 48);
            this.btnPillarAdd.Name = "btnPillarAdd";
            this.btnPillarAdd.Size = new System.Drawing.Size(97, 23);
            this.btnPillarAdd.TabIndex = 7;
            this.btnPillarAdd.Text = "Add pillar";
            this.btnPillarAdd.UseVisualStyleBackColor = true;
            this.btnPillarAdd.Click += new System.EventHandler(this.btnPillarAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 740);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sorting visualizer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfPillars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAddPillar;
        private System.Windows.Forms.NumericUpDown numOfPillars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPillarAdd;
    }
}

