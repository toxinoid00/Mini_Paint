namespace Mini_Paint
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_native = new System.Windows.Forms.RadioButton();
            this.cb_aa_circle = new System.Windows.Forms.CheckBox();
            this.rb_bresenham = new System.Windows.Forms.RadioButton();
            this.rb_dda = new System.Windows.Forms.RadioButton();
            this.nud_polygon = new System.Windows.Forms.NumericUpDown();
            this.rb_polygon = new System.Windows.Forms.RadioButton();
            this.rb_star = new System.Windows.Forms.RadioButton();
            this.rb_elips = new System.Windows.Forms.RadioButton();
            this.rb_circle = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.l_y2 = new System.Windows.Forms.Label();
            this.l_x2 = new System.Windows.Forms.Label();
            this.l_x1 = new System.Windows.Forms.Label();
            this.l_y1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_zoom = new System.Windows.Forms.TextBox();
            this.rb_shearing = new System.Windows.Forms.RadioButton();
            this.rb_rotasi = new System.Windows.Forms.RadioButton();
            this.rb_dilatasi = new System.Windows.Forms.RadioButton();
            this.rb_translasi = new System.Windows.Forms.RadioButton();
            this.tb_shearing_y = new System.Windows.Forms.TextBox();
            this.tb_translasi_y = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tb_shearing_x = new System.Windows.Forms.TextBox();
            this.tb_rotasi = new System.Windows.Forms.TextBox();
            this.tb_dilatasi = new System.Windows.Forms.TextBox();
            this.tb_translasi_x = new System.Windows.Forms.TextBox();
            this.rb_floodfill = new System.Windows.Forms.RadioButton();
            this.btnff = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_polygon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_native);
            this.groupBox1.Controls.Add(this.cb_aa_circle);
            this.groupBox1.Controls.Add(this.rb_bresenham);
            this.groupBox1.Controls.Add(this.rb_dda);
            this.groupBox1.Controls.Add(this.nud_polygon);
            this.groupBox1.Controls.Add(this.rb_polygon);
            this.groupBox1.Controls.Add(this.rb_star);
            this.groupBox1.Controls.Add(this.rb_elips);
            this.groupBox1.Controls.Add(this.rb_circle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toolbox";
            // 
            // rb_native
            // 
            this.rb_native.AutoSize = true;
            this.rb_native.Location = new System.Drawing.Point(18, 28);
            this.rb_native.Name = "rb_native";
            this.rb_native.Size = new System.Drawing.Size(85, 17);
            this.rb_native.TabIndex = 0;
            this.rb_native.TabStop = true;
            this.rb_native.Text = "Line - Native";
            this.rb_native.UseVisualStyleBackColor = true;
            // 
            // cb_aa_circle
            // 
            this.cb_aa_circle.AutoSize = true;
            this.cb_aa_circle.Location = new System.Drawing.Point(75, 97);
            this.cb_aa_circle.Name = "cb_aa_circle";
            this.cb_aa_circle.Size = new System.Drawing.Size(82, 17);
            this.cb_aa_circle.TabIndex = 2;
            this.cb_aa_circle.Text = "Anti-aliasing";
            this.cb_aa_circle.UseVisualStyleBackColor = true;
            // 
            // rb_bresenham
            // 
            this.rb_bresenham.AutoSize = true;
            this.rb_bresenham.Location = new System.Drawing.Point(18, 51);
            this.rb_bresenham.Name = "rb_bresenham";
            this.rb_bresenham.Size = new System.Drawing.Size(107, 17);
            this.rb_bresenham.TabIndex = 1;
            this.rb_bresenham.TabStop = true;
            this.rb_bresenham.Text = "Line - Bresenham";
            this.rb_bresenham.UseVisualStyleBackColor = true;
            // 
            // rb_dda
            // 
            this.rb_dda.AutoSize = true;
            this.rb_dda.Location = new System.Drawing.Point(18, 74);
            this.rb_dda.Name = "rb_dda";
            this.rb_dda.Size = new System.Drawing.Size(77, 17);
            this.rb_dda.TabIndex = 2;
            this.rb_dda.TabStop = true;
            this.rb_dda.Text = "Line - DDA";
            this.rb_dda.UseVisualStyleBackColor = true;
            // 
            // nud_polygon
            // 
            this.nud_polygon.Location = new System.Drawing.Point(87, 166);
            this.nud_polygon.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nud_polygon.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_polygon.Name = "nud_polygon";
            this.nud_polygon.Size = new System.Drawing.Size(37, 20);
            this.nud_polygon.TabIndex = 2;
            this.nud_polygon.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // rb_polygon
            // 
            this.rb_polygon.AutoSize = true;
            this.rb_polygon.Location = new System.Drawing.Point(18, 166);
            this.rb_polygon.Name = "rb_polygon";
            this.rb_polygon.Size = new System.Drawing.Size(63, 17);
            this.rb_polygon.TabIndex = 6;
            this.rb_polygon.TabStop = true;
            this.rb_polygon.Text = "Polygon";
            this.rb_polygon.UseVisualStyleBackColor = true;
            // 
            // rb_star
            // 
            this.rb_star.AutoSize = true;
            this.rb_star.Location = new System.Drawing.Point(18, 143);
            this.rb_star.Name = "rb_star";
            this.rb_star.Size = new System.Drawing.Size(44, 17);
            this.rb_star.TabIndex = 5;
            this.rb_star.TabStop = true;
            this.rb_star.Text = "Star";
            this.rb_star.UseVisualStyleBackColor = true;
            // 
            // rb_elips
            // 
            this.rb_elips.AutoSize = true;
            this.rb_elips.Location = new System.Drawing.Point(18, 120);
            this.rb_elips.Name = "rb_elips";
            this.rb_elips.Size = new System.Drawing.Size(47, 17);
            this.rb_elips.TabIndex = 4;
            this.rb_elips.TabStop = true;
            this.rb_elips.Text = "Elips";
            this.rb_elips.UseVisualStyleBackColor = true;
            // 
            // rb_circle
            // 
            this.rb_circle.AutoSize = true;
            this.rb_circle.Location = new System.Drawing.Point(18, 97);
            this.rb_circle.Name = "rb_circle";
            this.rb_circle.Size = new System.Drawing.Size(51, 17);
            this.rb_circle.TabIndex = 3;
            this.rb_circle.TabStop = true;
            this.rb_circle.Text = "Circle";
            this.rb_circle.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(221, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 447);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.l_y2);
            this.groupBox3.Controls.Add(this.l_x2);
            this.groupBox3.Controls.Add(this.l_x1);
            this.groupBox3.Controls.Add(this.l_y1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tb_zoom);
            this.groupBox3.Location = new System.Drawing.Point(12, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 101);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // l_y2
            // 
            this.l_y2.AutoSize = true;
            this.l_y2.Location = new System.Drawing.Point(139, 73);
            this.l_y2.Name = "l_y2";
            this.l_y2.Size = new System.Drawing.Size(20, 13);
            this.l_y2.TabIndex = 13;
            this.l_y2.Text = "Y2";
            // 
            // l_x2
            // 
            this.l_x2.AutoSize = true;
            this.l_x2.Location = new System.Drawing.Point(98, 73);
            this.l_x2.Name = "l_x2";
            this.l_x2.Size = new System.Drawing.Size(20, 13);
            this.l_x2.TabIndex = 12;
            this.l_x2.Text = "X2";
            // 
            // l_x1
            // 
            this.l_x1.AutoSize = true;
            this.l_x1.Location = new System.Drawing.Point(15, 73);
            this.l_x1.Name = "l_x1";
            this.l_x1.Size = new System.Drawing.Size(20, 13);
            this.l_x1.TabIndex = 11;
            this.l_x1.Text = "X1";
            // 
            // l_y1
            // 
            this.l_y1.AutoSize = true;
            this.l_y1.Location = new System.Drawing.Point(58, 73);
            this.l_y1.Name = "l_y1";
            this.l_y1.Size = new System.Drawing.Size(20, 13);
            this.l_y1.TabIndex = 10;
            this.l_y1.Text = "Y1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Y2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "X2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zoom :";
            // 
            // tb_zoom
            // 
            this.tb_zoom.Location = new System.Drawing.Point(61, 19);
            this.tb_zoom.Name = "tb_zoom";
            this.tb_zoom.Size = new System.Drawing.Size(35, 20);
            this.tb_zoom.TabIndex = 0;
            this.tb_zoom.Text = "3";
            // 
            // rb_shearing
            // 
            this.rb_shearing.AutoSize = true;
            this.rb_shearing.Location = new System.Drawing.Point(32, 283);
            this.rb_shearing.Name = "rb_shearing";
            this.rb_shearing.Size = new System.Drawing.Size(67, 17);
            this.rb_shearing.TabIndex = 34;
            this.rb_shearing.TabStop = true;
            this.rb_shearing.Text = "Shearing";
            this.rb_shearing.UseVisualStyleBackColor = true;
            // 
            // rb_rotasi
            // 
            this.rb_rotasi.AutoSize = true;
            this.rb_rotasi.Location = new System.Drawing.Point(31, 257);
            this.rb_rotasi.Name = "rb_rotasi";
            this.rb_rotasi.Size = new System.Drawing.Size(55, 17);
            this.rb_rotasi.TabIndex = 33;
            this.rb_rotasi.TabStop = true;
            this.rb_rotasi.Text = "Rotasi";
            this.rb_rotasi.UseVisualStyleBackColor = true;
            // 
            // rb_dilatasi
            // 
            this.rb_dilatasi.AutoSize = true;
            this.rb_dilatasi.Location = new System.Drawing.Point(30, 231);
            this.rb_dilatasi.Name = "rb_dilatasi";
            this.rb_dilatasi.Size = new System.Drawing.Size(59, 17);
            this.rb_dilatasi.TabIndex = 32;
            this.rb_dilatasi.TabStop = true;
            this.rb_dilatasi.Text = "Dilatasi";
            this.rb_dilatasi.UseVisualStyleBackColor = true;
            // 
            // rb_translasi
            // 
            this.rb_translasi.AutoSize = true;
            this.rb_translasi.Location = new System.Drawing.Point(30, 205);
            this.rb_translasi.Name = "rb_translasi";
            this.rb_translasi.Size = new System.Drawing.Size(67, 17);
            this.rb_translasi.TabIndex = 31;
            this.rb_translasi.TabStop = true;
            this.rb_translasi.Text = "Translasi";
            this.rb_translasi.UseVisualStyleBackColor = true;
            // 
            // tb_shearing_y
            // 
            this.tb_shearing_y.Location = new System.Drawing.Point(138, 282);
            this.tb_shearing_y.Name = "tb_shearing_y";
            this.tb_shearing_y.Size = new System.Drawing.Size(31, 20);
            this.tb_shearing_y.TabIndex = 30;
            // 
            // tb_translasi_y
            // 
            this.tb_translasi_y.Location = new System.Drawing.Point(138, 204);
            this.tb_translasi_y.Name = "tb_translasi_y";
            this.tb_translasi_y.Size = new System.Drawing.Size(31, 20);
            this.tb_translasi_y.TabIndex = 29;
            this.tb_translasi_y.Text = "0";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(96, 308);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 28;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // tb_shearing_x
            // 
            this.tb_shearing_x.Location = new System.Drawing.Point(99, 282);
            this.tb_shearing_x.Name = "tb_shearing_x";
            this.tb_shearing_x.Size = new System.Drawing.Size(31, 20);
            this.tb_shearing_x.TabIndex = 27;
            // 
            // tb_rotasi
            // 
            this.tb_rotasi.Location = new System.Drawing.Point(99, 256);
            this.tb_rotasi.Name = "tb_rotasi";
            this.tb_rotasi.Size = new System.Drawing.Size(70, 20);
            this.tb_rotasi.TabIndex = 26;
            this.tb_rotasi.Text = "0";
            this.tb_rotasi.TextChanged += new System.EventHandler(this.tb_rotasi_TextChanged);
            // 
            // tb_dilatasi
            // 
            this.tb_dilatasi.Location = new System.Drawing.Point(99, 230);
            this.tb_dilatasi.Name = "tb_dilatasi";
            this.tb_dilatasi.Size = new System.Drawing.Size(70, 20);
            this.tb_dilatasi.TabIndex = 25;
            this.tb_dilatasi.Text = "0";
            // 
            // tb_translasi_x
            // 
            this.tb_translasi_x.Location = new System.Drawing.Point(99, 204);
            this.tb_translasi_x.Name = "tb_translasi_x";
            this.tb_translasi_x.Size = new System.Drawing.Size(31, 20);
            this.tb_translasi_x.TabIndex = 24;
            this.tb_translasi_x.Text = "0";
            // 
            // rb_floodfill
            // 
            this.rb_floodfill.AutoSize = true;
            this.rb_floodfill.Location = new System.Drawing.Point(32, 442);
            this.rb_floodfill.Name = "rb_floodfill";
            this.rb_floodfill.Size = new System.Drawing.Size(60, 17);
            this.rb_floodfill.TabIndex = 35;
            this.rb_floodfill.TabStop = true;
            this.rb_floodfill.Text = "Floodfill";
            this.rb_floodfill.UseVisualStyleBackColor = true;
            // 
            // btnff
            // 
            this.btnff.Location = new System.Drawing.Point(99, 439);
            this.btnff.Name = "btnff";
            this.btnff.Size = new System.Drawing.Size(75, 23);
            this.btnff.TabIndex = 36;
            this.btnff.Text = "OK";
            this.btnff.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 477);
            this.Controls.Add(this.btnff);
            this.Controls.Add(this.rb_floodfill);
            this.Controls.Add(this.rb_shearing);
            this.Controls.Add(this.rb_rotasi);
            this.Controls.Add(this.rb_dilatasi);
            this.Controls.Add(this.rb_translasi);
            this.Controls.Add(this.tb_shearing_y);
            this.Controls.Add(this.tb_translasi_y);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_shearing_x);
            this.Controls.Add(this.tb_rotasi);
            this.Controls.Add(this.tb_dilatasi);
            this.Controls.Add(this.tb_translasi_x);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Mini Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_polygon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_elips;
        private System.Windows.Forms.RadioButton rb_circle;
        private System.Windows.Forms.RadioButton rb_polygon;
        private System.Windows.Forms.RadioButton rb_star;
        private System.Windows.Forms.CheckBox cb_aa_circle;
        private System.Windows.Forms.NumericUpDown nud_polygon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_zoom;
        private System.Windows.Forms.Label l_y2;
        private System.Windows.Forms.Label l_x2;
        private System.Windows.Forms.Label l_x1;
        private System.Windows.Forms.Label l_y1;
        private System.Windows.Forms.RadioButton rb_native;
        private System.Windows.Forms.RadioButton rb_bresenham;
        private System.Windows.Forms.RadioButton rb_dda;
        private System.Windows.Forms.RadioButton rb_shearing;
        private System.Windows.Forms.RadioButton rb_rotasi;
        private System.Windows.Forms.RadioButton rb_dilatasi;
        private System.Windows.Forms.RadioButton rb_translasi;
        private System.Windows.Forms.TextBox tb_shearing_y;
        private System.Windows.Forms.TextBox tb_translasi_y;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox tb_shearing_x;
        private System.Windows.Forms.TextBox tb_rotasi;
        private System.Windows.Forms.TextBox tb_dilatasi;
        private System.Windows.Forms.TextBox tb_translasi_x;
        private System.Windows.Forms.RadioButton rb_floodfill;
        private System.Windows.Forms.Button btnff;
    }
}

