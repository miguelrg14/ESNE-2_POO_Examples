
namespace Miguel_Rodríguez_01
{
    partial class Ej01Form
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCharacterTypePlayer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayerDamage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pgbEnSpear = new System.Windows.Forms.ProgressBar();
            this.pgbEnAxe = new System.Windows.Forms.ProgressBar();
            this.pgbEnSword = new System.Windows.Forms.ProgressBar();
            this.lblEnSpearName = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblEnAxeName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pbEnSpear = new System.Windows.Forms.PictureBox();
            this.pbEnAxe = new System.Windows.Forms.PictureBox();
            this.lblEnSwordName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCharacterTypeEnemy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbEnSword = new System.Windows.Forms.PictureBox();
            this.tmrCrono = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnSpear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnAxe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnSword)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbPlayer);
            this.groupBox1.Controls.Add(this.lblPlayerName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblCharacterTypePlayer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblPlayerDamage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAttack);
            this.groupBox1.Controls.Add(this.pbPlayer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Select Character";
            // 
            // cbPlayer
            // 
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Location = new System.Drawing.Point(19, 335);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(212, 28);
            this.cbPlayer.TabIndex = 10;
            this.cbPlayer.SelectedIndexChanged += new System.EventHandler(this.cbPlayer_SelectedIndexChanged);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(377, 204);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(12, 20);
            this.lblPlayerName.TabIndex = 9;
            this.lblPlayerName.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // lblCharacterTypePlayer
            // 
            this.lblCharacterTypePlayer.AutoSize = true;
            this.lblCharacterTypePlayer.Location = new System.Drawing.Point(377, 279);
            this.lblCharacterTypePlayer.Name = "lblCharacterTypePlayer";
            this.lblCharacterTypePlayer.Size = new System.Drawing.Size(12, 20);
            this.lblCharacterTypePlayer.TabIndex = 7;
            this.lblCharacterTypePlayer.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Character Type";
            // 
            // lblPlayerDamage
            // 
            this.lblPlayerDamage.AutoSize = true;
            this.lblPlayerDamage.Location = new System.Drawing.Point(377, 242);
            this.lblPlayerDamage.Name = "lblPlayerDamage";
            this.lblPlayerDamage.Size = new System.Drawing.Size(12, 20);
            this.lblPlayerDamage.TabIndex = 5;
            this.lblPlayerDamage.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Damage";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(263, 319);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(148, 58);
            this.btnAttack.TabIndex = 3;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.attackPlayer_Click);
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(144, 44);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(172, 145);
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblTimer);
            this.groupBox2.Controls.Add(this.pgbEnSpear);
            this.groupBox2.Controls.Add(this.pgbEnAxe);
            this.groupBox2.Controls.Add(this.pgbEnSword);
            this.groupBox2.Controls.Add(this.lblEnSpearName);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.lblEnAxeName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.pbEnSpear);
            this.groupBox2.Controls.Add(this.pbEnAxe);
            this.groupBox2.Controls.Add(this.lblEnSwordName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblCharacterTypeEnemy);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pbEnSword);
            this.groupBox2.Location = new System.Drawing.Point(508, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 383);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enemy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Time";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(71, 335);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(12, 20);
            this.lblTimer.TabIndex = 27;
            this.lblTimer.Text = ".";
            // 
            // pgbEnSpear
            // 
            this.pgbEnSpear.Location = new System.Drawing.Point(458, 231);
            this.pgbEnSpear.Name = "pgbEnSpear";
            this.pgbEnSpear.Size = new System.Drawing.Size(96, 20);
            this.pgbEnSpear.TabIndex = 26;
            // 
            // pgbEnAxe
            // 
            this.pgbEnAxe.Location = new System.Drawing.Point(269, 231);
            this.pgbEnAxe.Name = "pgbEnAxe";
            this.pgbEnAxe.Size = new System.Drawing.Size(96, 20);
            this.pgbEnAxe.TabIndex = 25;
            // 
            // pgbEnSword
            // 
            this.pgbEnSword.Location = new System.Drawing.Point(82, 231);
            this.pgbEnSword.Name = "pgbEnSword";
            this.pgbEnSword.Size = new System.Drawing.Size(96, 20);
            this.pgbEnSword.TabIndex = 24;
            // 
            // lblEnSpearName
            // 
            this.lblEnSpearName.AutoSize = true;
            this.lblEnSpearName.Location = new System.Drawing.Point(512, 193);
            this.lblEnSpearName.Name = "lblEnSpearName";
            this.lblEnSpearName.Size = new System.Drawing.Size(12, 20);
            this.lblEnSpearName.TabIndex = 23;
            this.lblEnSpearName.Text = ".";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(399, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(512, 268);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = ".";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(399, 268);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 20);
            this.label17.TabIndex = 20;
            this.label17.Text = "Character Type";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(399, 231);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 20);
            this.label19.TabIndex = 18;
            this.label19.Text = "Health";
            // 
            // lblEnAxeName
            // 
            this.lblEnAxeName.AutoSize = true;
            this.lblEnAxeName.Location = new System.Drawing.Point(323, 193);
            this.lblEnAxeName.Name = "lblEnAxeName";
            this.lblEnAxeName.Size = new System.Drawing.Size(12, 20);
            this.lblEnAxeName.TabIndex = 17;
            this.lblEnAxeName.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = ".";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(210, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Character Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(210, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Health";
            // 
            // pbEnSpear
            // 
            this.pbEnSpear.Image = global::Miguel_Rodríguez_01.Properties.Resources.SpearSoldier01;
            this.pbEnSpear.Location = new System.Drawing.Point(399, 26);
            this.pbEnSpear.Name = "pbEnSpear";
            this.pbEnSpear.Size = new System.Drawing.Size(172, 145);
            this.pbEnSpear.TabIndex = 11;
            this.pbEnSpear.TabStop = false;
            // 
            // pbEnAxe
            // 
            this.pbEnAxe.Image = global::Miguel_Rodríguez_01.Properties.Resources.AxeSoldier02;
            this.pbEnAxe.Location = new System.Drawing.Point(210, 26);
            this.pbEnAxe.Name = "pbEnAxe";
            this.pbEnAxe.Size = new System.Drawing.Size(172, 145);
            this.pbEnAxe.TabIndex = 10;
            this.pbEnAxe.TabStop = false;
            // 
            // lblEnSwordName
            // 
            this.lblEnSwordName.AutoSize = true;
            this.lblEnSwordName.Location = new System.Drawing.Point(136, 193);
            this.lblEnSwordName.Name = "lblEnSwordName";
            this.lblEnSwordName.Size = new System.Drawing.Size(12, 20);
            this.lblEnSwordName.TabIndex = 9;
            this.lblEnSwordName.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name";
            // 
            // lblCharacterTypeEnemy
            // 
            this.lblCharacterTypeEnemy.AutoSize = true;
            this.lblCharacterTypeEnemy.Location = new System.Drawing.Point(136, 268);
            this.lblCharacterTypeEnemy.Name = "lblCharacterTypeEnemy";
            this.lblCharacterTypeEnemy.Size = new System.Drawing.Size(12, 20);
            this.lblCharacterTypeEnemy.TabIndex = 7;
            this.lblCharacterTypeEnemy.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Character Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Health";
            // 
            // pbEnSword
            // 
            this.pbEnSword.Image = global::Miguel_Rodríguez_01.Properties.Resources.SwordSoldier01;
            this.pbEnSword.Location = new System.Drawing.Point(6, 26);
            this.pbEnSword.Name = "pbEnSword";
            this.pbEnSword.Size = new System.Drawing.Size(172, 145);
            this.pbEnSword.TabIndex = 0;
            this.pbEnSword.TabStop = false;
            // 
            // tmrCrono
            // 
            this.tmrCrono.Interval = 1000;
            // 
            // Ej01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ej01Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ej01Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnSpear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnAxe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnSword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbEnSword;
        private System.Windows.Forms.Label lblPlayerDamage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCharacterTypePlayer;
        private System.Windows.Forms.Label lblCharacterTypeEnemy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPlayer;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEnSwordName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbEnSpear;
        private System.Windows.Forms.PictureBox pbEnAxe;
        private System.Windows.Forms.Label lblEnSpearName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblEnAxeName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar pgbEnSpear;
        private System.Windows.Forms.ProgressBar pgbEnAxe;
        private System.Windows.Forms.ProgressBar pgbEnSword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmrCrono;
    }
}

