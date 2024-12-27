namespace Calc_IP_gui;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        title_label = new System.Windows.Forms.Label();
        label_in_ip = new System.Windows.Forms.Label();
        label_mask_in = new System.Windows.Forms.Label();
        tb_ip = new System.Windows.Forms.TextBox();
        tb_mask = new System.Windows.Forms.TextBox();
        mask_label = new System.Windows.Forms.Label();
        adres_label = new System.Windows.Forms.Label();
        adresR_label = new System.Windows.Forms.Label();
        host_label = new System.Windows.Forms.Label();
        min_label = new System.Windows.Forms.Label();
        max_label = new System.Windows.Forms.Label();
        ip_dec = new System.Windows.Forms.Label();
        mask_dec = new System.Windows.Forms.Label();
        adres_dec = new System.Windows.Forms.Label();
        adresR_dec = new System.Windows.Forms.Label();
        host_dec = new System.Windows.Forms.Label();
        min_dec = new System.Windows.Forms.Label();
        max_dec = new System.Windows.Forms.Label();
        ip_bin = new System.Windows.Forms.Label();
        mask_bin = new System.Windows.Forms.Label();
        adres_bin = new System.Windows.Forms.Label();
        adresR_bin = new System.Windows.Forms.Label();
        host_bin = new System.Windows.Forms.Label();
        min_bin = new System.Windows.Forms.Label();
        max_bin = new System.Windows.Forms.Label();
        btn_policz = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        ip_label = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        klasa_label = new System.Windows.Forms.Label();
        klasa_out = new System.Windows.Forms.Label();
        shadowm = new System.Windows.Forms.Label();
        shadowip = new System.Windows.Forms.Label();
        shadow_title = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // title_label
        // 
        title_label.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
        title_label.BackColor = System.Drawing.Color.Firebrick;
        title_label.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        title_label.ForeColor = System.Drawing.Color.Yellow;
        title_label.Location = new System.Drawing.Point(250, 9);
        title_label.Name = "title_label";
        title_label.Size = new System.Drawing.Size(300, 30);
        title_label.TabIndex = 0;
        title_label.Text = "IP Calculator";
        title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label_in_ip
        // 
        label_in_ip.BackColor = System.Drawing.Color.LightSteelBlue;
        label_in_ip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        label_in_ip.ForeColor = System.Drawing.Color.Yellow;
        label_in_ip.Location = new System.Drawing.Point(15, 50);
        label_in_ip.Name = "label_in_ip";
        label_in_ip.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        label_in_ip.Size = new System.Drawing.Size(290, 35);
        label_in_ip.TabIndex = 1;
        label_in_ip.Text = "IP adres";
        label_in_ip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label_mask_in
        // 
        label_mask_in.BackColor = System.Drawing.Color.LightSteelBlue;
        label_mask_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        label_mask_in.ForeColor = System.Drawing.Color.Yellow;
        label_mask_in.Location = new System.Drawing.Point(15, 90);
        label_mask_in.Name = "label_mask_in";
        label_mask_in.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        label_mask_in.Size = new System.Drawing.Size(290, 35);
        label_mask_in.TabIndex = 2;
        label_mask_in.Text = "Maska";
        label_mask_in.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tb_ip
        // 
        tb_ip.BackColor = System.Drawing.Color.Yellow;
        tb_ip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        tb_ip.ForeColor = System.Drawing.Color.Firebrick;
        tb_ip.Location = new System.Drawing.Point(112, 56);
        tb_ip.MaxLength = 15;
        tb_ip.Name = "tb_ip";
        tb_ip.Size = new System.Drawing.Size(186, 23);
        tb_ip.TabIndex = 3;
        // 
        // tb_mask
        // 
        tb_mask.BackColor = System.Drawing.Color.Yellow;
        tb_mask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        tb_mask.ForeColor = System.Drawing.Color.Firebrick;
        tb_mask.Location = new System.Drawing.Point(112, 96);
        tb_mask.MaxLength = 15;
        tb_mask.Name = "tb_mask";
        tb_mask.Size = new System.Drawing.Size(186, 23);
        tb_mask.TabIndex = 4;
        // 
        // mask_label
        // 
        mask_label.BackColor = System.Drawing.Color.Gainsboro;
        mask_label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        mask_label.ForeColor = System.Drawing.Color.Firebrick;
        mask_label.Location = new System.Drawing.Point(15, 209);
        mask_label.Name = "mask_label";
        mask_label.Size = new System.Drawing.Size(150, 45);
        mask_label.TabIndex = 6;
        mask_label.Text = "mask";
        mask_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // adres_label
        // 
        adres_label.BackColor = System.Drawing.Color.Gainsboro;
        adres_label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        adres_label.ForeColor = System.Drawing.Color.Firebrick;
        adres_label.Location = new System.Drawing.Point(15, 255);
        adres_label.Name = "adres_label";
        adres_label.Size = new System.Drawing.Size(150, 45);
        adres_label.TabIndex = 7;
        adres_label.Text = "adres sieci";
        adres_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // adresR_label
        // 
        adresR_label.BackColor = System.Drawing.Color.Gainsboro;
        adresR_label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        adresR_label.ForeColor = System.Drawing.Color.Firebrick;
        adresR_label.Location = new System.Drawing.Point(15, 301);
        adresR_label.Name = "adresR_label";
        adresR_label.Size = new System.Drawing.Size(150, 45);
        adresR_label.TabIndex = 8;
        adresR_label.Text = "adres rozgloszeniowy";
        adresR_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // host_label
        // 
        host_label.BackColor = System.Drawing.Color.Gainsboro;
        host_label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        host_label.ForeColor = System.Drawing.Color.Firebrick;
        host_label.Location = new System.Drawing.Point(15, 347);
        host_label.Name = "host_label";
        host_label.Size = new System.Drawing.Size(150, 45);
        host_label.TabIndex = 9;
        host_label.Text = "hostow w sieci";
        host_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // min_label
        // 
        min_label.BackColor = System.Drawing.Color.Gainsboro;
        min_label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        min_label.ForeColor = System.Drawing.Color.Firebrick;
        min_label.Location = new System.Drawing.Point(15, 393);
        min_label.Name = "min_label";
        min_label.Size = new System.Drawing.Size(150, 45);
        min_label.TabIndex = 10;
        min_label.Text = "host min";
        min_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // max_label
        // 
        max_label.BackColor = System.Drawing.Color.Gainsboro;
        max_label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        max_label.ForeColor = System.Drawing.Color.Firebrick;
        max_label.Location = new System.Drawing.Point(15, 439);
        max_label.Name = "max_label";
        max_label.Size = new System.Drawing.Size(150, 45);
        max_label.TabIndex = 11;
        max_label.Text = "host max";
        max_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // ip_dec
        // 
        ip_dec.BackColor = System.Drawing.Color.Gainsboro;
        ip_dec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        ip_dec.ForeColor = System.Drawing.Color.Firebrick;
        ip_dec.Location = new System.Drawing.Point(166, 163);
        ip_dec.Name = "ip_dec";
        ip_dec.Size = new System.Drawing.Size(160, 45);
        ip_dec.TabIndex = 12;
        ip_dec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // mask_dec
        // 
        mask_dec.BackColor = System.Drawing.Color.Gainsboro;
        mask_dec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        mask_dec.ForeColor = System.Drawing.Color.Firebrick;
        mask_dec.Location = new System.Drawing.Point(166, 209);
        mask_dec.Name = "mask_dec";
        mask_dec.Size = new System.Drawing.Size(160, 45);
        mask_dec.TabIndex = 13;
        mask_dec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // adres_dec
        // 
        adres_dec.BackColor = System.Drawing.Color.Gainsboro;
        adres_dec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        adres_dec.ForeColor = System.Drawing.Color.Firebrick;
        adres_dec.Location = new System.Drawing.Point(166, 255);
        adres_dec.Name = "adres_dec";
        adres_dec.Size = new System.Drawing.Size(160, 45);
        adres_dec.TabIndex = 14;
        adres_dec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // adresR_dec
        // 
        adresR_dec.BackColor = System.Drawing.Color.Gainsboro;
        adresR_dec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        adresR_dec.ForeColor = System.Drawing.Color.Firebrick;
        adresR_dec.Location = new System.Drawing.Point(166, 301);
        adresR_dec.Name = "adresR_dec";
        adresR_dec.Size = new System.Drawing.Size(160, 45);
        adresR_dec.TabIndex = 15;
        adresR_dec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // host_dec
        // 
        host_dec.BackColor = System.Drawing.Color.Gainsboro;
        host_dec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        host_dec.ForeColor = System.Drawing.Color.Firebrick;
        host_dec.Location = new System.Drawing.Point(166, 347);
        host_dec.Name = "host_dec";
        host_dec.Size = new System.Drawing.Size(160, 45);
        host_dec.TabIndex = 16;
        host_dec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // min_dec
        // 
        min_dec.BackColor = System.Drawing.Color.Gainsboro;
        min_dec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        min_dec.ForeColor = System.Drawing.Color.Firebrick;
        min_dec.Location = new System.Drawing.Point(166, 393);
        min_dec.Name = "min_dec";
        min_dec.Size = new System.Drawing.Size(160, 45);
        min_dec.TabIndex = 17;
        min_dec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // max_dec
        // 
        max_dec.BackColor = System.Drawing.Color.Gainsboro;
        max_dec.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        max_dec.ForeColor = System.Drawing.Color.Firebrick;
        max_dec.Location = new System.Drawing.Point(166, 439);
        max_dec.Name = "max_dec";
        max_dec.Size = new System.Drawing.Size(160, 45);
        max_dec.TabIndex = 18;
        max_dec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // ip_bin
        // 
        ip_bin.BackColor = System.Drawing.Color.Gainsboro;
        ip_bin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        ip_bin.ForeColor = System.Drawing.Color.Firebrick;
        ip_bin.Location = new System.Drawing.Point(327, 163);
        ip_bin.Name = "ip_bin";
        ip_bin.Size = new System.Drawing.Size(370, 45);
        ip_bin.TabIndex = 19;
        ip_bin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // mask_bin
        // 
        mask_bin.BackColor = System.Drawing.Color.Gainsboro;
        mask_bin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        mask_bin.ForeColor = System.Drawing.Color.Firebrick;
        mask_bin.Location = new System.Drawing.Point(327, 209);
        mask_bin.Name = "mask_bin";
        mask_bin.Size = new System.Drawing.Size(370, 45);
        mask_bin.TabIndex = 20;
        mask_bin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // adres_bin
        // 
        adres_bin.BackColor = System.Drawing.Color.Gainsboro;
        adres_bin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        adres_bin.ForeColor = System.Drawing.Color.Firebrick;
        adres_bin.Location = new System.Drawing.Point(327, 255);
        adres_bin.Name = "adres_bin";
        adres_bin.Size = new System.Drawing.Size(370, 45);
        adres_bin.TabIndex = 21;
        adres_bin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // adresR_bin
        // 
        adresR_bin.BackColor = System.Drawing.Color.Gainsboro;
        adresR_bin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        adresR_bin.ForeColor = System.Drawing.Color.Firebrick;
        adresR_bin.Location = new System.Drawing.Point(327, 301);
        adresR_bin.Name = "adresR_bin";
        adresR_bin.Size = new System.Drawing.Size(370, 45);
        adresR_bin.TabIndex = 22;
        adresR_bin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // host_bin
        // 
        host_bin.BackColor = System.Drawing.Color.Gainsboro;
        host_bin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        host_bin.ForeColor = System.Drawing.Color.Firebrick;
        host_bin.Location = new System.Drawing.Point(327, 347);
        host_bin.Name = "host_bin";
        host_bin.Size = new System.Drawing.Size(370, 45);
        host_bin.TabIndex = 23;
        host_bin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // min_bin
        // 
        min_bin.BackColor = System.Drawing.Color.Gainsboro;
        min_bin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        min_bin.ForeColor = System.Drawing.Color.Firebrick;
        min_bin.Location = new System.Drawing.Point(327, 393);
        min_bin.Name = "min_bin";
        min_bin.Size = new System.Drawing.Size(370, 45);
        min_bin.TabIndex = 24;
        min_bin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // max_bin
        // 
        max_bin.BackColor = System.Drawing.Color.Gainsboro;
        max_bin.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        max_bin.ForeColor = System.Drawing.Color.Firebrick;
        max_bin.Location = new System.Drawing.Point(327, 439);
        max_bin.Name = "max_bin";
        max_bin.Size = new System.Drawing.Size(370, 45);
        max_bin.TabIndex = 25;
        max_bin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btn_policz
        // 
        btn_policz.BackColor = System.Drawing.Color.LightSteelBlue;
        btn_policz.FlatAppearance.BorderColor = System.Drawing.Color.White;
        btn_policz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
        btn_policz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
        btn_policz.ForeColor = System.Drawing.Color.Yellow;
        btn_policz.Location = new System.Drawing.Point(15, 131);
        btn_policz.Margin = new System.Windows.Forms.Padding(0);
        btn_policz.Name = "btn_policz";
        btn_policz.Size = new System.Drawing.Size(86, 28);
        btn_policz.TabIndex = 26;
        btn_policz.Text = "Prześlij";
        btn_policz.UseVisualStyleBackColor = false;
        btn_policz.Click += btn_policz_Click;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.Black;
        label1.Location = new System.Drawing.Point(27, 175);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(679, 320);
        label1.TabIndex = 27;
        // 
        // ip_label
        // 
        ip_label.BackColor = System.Drawing.Color.Gainsboro;
        ip_label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        ip_label.ForeColor = System.Drawing.Color.Firebrick;
        ip_label.Location = new System.Drawing.Point(15, 163);
        ip_label.Name = "ip_label";
        ip_label.Size = new System.Drawing.Size(150, 45);
        ip_label.TabIndex = 29;
        ip_label.Text = "IP adres";
        ip_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.BackColor = System.Drawing.Color.Black;
        label3.Location = new System.Drawing.Point(24, 510);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(138, 37);
        label3.TabIndex = 30;
        // 
        // klasa_label
        // 
        klasa_label.BackColor = System.Drawing.Color.Firebrick;
        klasa_label.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        klasa_label.ForeColor = System.Drawing.Color.Yellow;
        klasa_label.Location = new System.Drawing.Point(20, 507);
        klasa_label.Name = "klasa_label";
        klasa_label.Size = new System.Drawing.Size(67, 33);
        klasa_label.TabIndex = 31;
        klasa_label.Text = "Klasa:";
        klasa_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // klasa_out
        // 
        klasa_out.BackColor = System.Drawing.Color.Firebrick;
        klasa_out.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        klasa_out.ForeColor = System.Drawing.Color.Yellow;
        klasa_out.Location = new System.Drawing.Point(87, 507);
        klasa_out.Margin = new System.Windows.Forms.Padding(0);
        klasa_out.Name = "klasa_out";
        klasa_out.Size = new System.Drawing.Size(67, 33);
        klasa_out.TabIndex = 32;
        klasa_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // shadowm
        // 
        shadowm.BackColor = System.Drawing.Color.Black;
        shadowm.ForeColor = System.Drawing.Color.Yellow;
        shadowm.Location = new System.Drawing.Point(19, 94);
        shadowm.Name = "shadowm";
        shadowm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        shadowm.Size = new System.Drawing.Size(290, 35);
        shadowm.TabIndex = 33;
        shadowm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // shadowip
        // 
        shadowip.BackColor = System.Drawing.Color.Black;
        shadowip.ForeColor = System.Drawing.Color.Yellow;
        shadowip.Location = new System.Drawing.Point(19, 54);
        shadowip.Name = "shadowip";
        shadowip.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        shadowip.Size = new System.Drawing.Size(290, 35);
        shadowip.TabIndex = 34;
        shadowip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // shadow_title
        // 
        shadow_title.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        shadow_title.BackColor = System.Drawing.Color.Yellow;
        shadow_title.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        shadow_title.ForeColor = System.Drawing.Color.Yellow;
        shadow_title.Location = new System.Drawing.Point(245, 4);
        shadow_title.Name = "shadow_title";
        shadow_title.Size = new System.Drawing.Size(310, 40);
        shadow_title.TabIndex = 35;
        shadow_title.Text = "IP Calculator";
        shadow_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Form1
        // 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        BackColor = System.Drawing.Color.Blue;
        ClientSize = new System.Drawing.Size(784, 561);
        Controls.Add(title_label);
        Controls.Add(shadow_title);
        Controls.Add(tb_mask);
        Controls.Add(klasa_out);
        Controls.Add(klasa_label);
        Controls.Add(label3);
        Controls.Add(ip_label);
        Controls.Add(btn_policz);
        Controls.Add(max_bin);
        Controls.Add(min_bin);
        Controls.Add(host_bin);
        Controls.Add(adresR_bin);
        Controls.Add(adres_bin);
        Controls.Add(mask_bin);
        Controls.Add(ip_bin);
        Controls.Add(max_dec);
        Controls.Add(min_dec);
        Controls.Add(host_dec);
        Controls.Add(adresR_dec);
        Controls.Add(adres_dec);
        Controls.Add(mask_dec);
        Controls.Add(ip_dec);
        Controls.Add(max_label);
        Controls.Add(min_label);
        Controls.Add(host_label);
        Controls.Add(adresR_label);
        Controls.Add(adres_label);
        Controls.Add(mask_label);
        Controls.Add(tb_ip);
        Controls.Add(label_mask_in);
        Controls.Add(label_in_ip);
        Controls.Add(shadowm);
        Controls.Add(shadowip);
        Controls.Add(label1);
        Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        ForeColor = System.Drawing.SystemColors.ControlText;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Location = new System.Drawing.Point(22, 22);
        Margin = new System.Windows.Forms.Padding(4);
        MaximizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label shadow_title;

    private System.Windows.Forms.Label shadowip;

    private System.Windows.Forms.Label shadowm;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button btn_policz;

    private System.Windows.Forms.TextBox tb_mask;

    private System.Windows.Forms.Label label_in_ip;

    private System.Windows.Forms.Label ip_dec;
    private System.Windows.Forms.Label ip_bin;
    private System.Windows.Forms.Label mask_label;
    private System.Windows.Forms.Label mask_dec;
    private System.Windows.Forms.Label mask_bin;
    private System.Windows.Forms.Label adres_label;
    private System.Windows.Forms.Label adres_dec;
    private System.Windows.Forms.Label adres_bin;
    private System.Windows.Forms.Label adresR_label;
    private System.Windows.Forms.Label adresR_dec;
    private System.Windows.Forms.Label adresR_bin;
    private System.Windows.Forms.Label host_label;
    private System.Windows.Forms.Label host_dec;
    private System.Windows.Forms.Label host_bin;
    private System.Windows.Forms.Label min_bin;
    private System.Windows.Forms.Label max_bin;
    private System.Windows.Forms.Label max_dec;
    private System.Windows.Forms.Label min_dec;
    private System.Windows.Forms.Label min_label;
    private System.Windows.Forms.Label max_label;
    private System.Windows.Forms.TextBox tb_ip;
    private System.Windows.Forms.Label label_mask_in;
    private System.Windows.Forms.Label title_label;

    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.Label label22;
    private System.Windows.Forms.Label label23;
    private System.Windows.Forms.Label label24;

    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Label label18;

    private System.Windows.Forms.Label label11;

    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label klasa_label;
    private System.Windows.Forms.Label klasa_out;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label ip_label;

    #endregion
}