namespace assignment_
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_word = new System.Windows.Forms.Label();
            this.textBox_guess = new System.Windows.Forms.TextBox();
            this.button_next = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.ReactionImage = new System.Windows.Forms.Panel();
            this.moodimage = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_word
            // 
            this.label_word.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label_word.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_word.Location = new System.Drawing.Point(99, 33);
            this.label_word.Name = "label_word";
            this.label_word.Size = new System.Drawing.Size(638, 54);
            this.label_word.TabIndex = 0;
            this.label_word.Text = "Word";
            this.label_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_guess
            // 
            this.textBox_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_guess.Location = new System.Drawing.Point(99, 90);
            this.textBox_guess.Name = "textBox_guess";
            this.textBox_guess.Size = new System.Drawing.Size(638, 38);
            this.textBox_guess.TabIndex = 1;
            this.textBox_guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.DarkCyan;
            this.button_next.Enabled = false;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_next.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.ForeColor = System.Drawing.SystemColors.Window;
            this.button_next.Location = new System.Drawing.Point(99, 134);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(638, 50);
            this.button_next.TabIndex = 2;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.LightSalmon;
            this.button_start.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.ForeColor = System.Drawing.Color.White;
            this.button_start.Location = new System.Drawing.Point(99, 190);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(638, 51);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_result
            // 
            this.label_result.BackColor = System.Drawing.Color.Silver;
            this.label_result.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(99, 244);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(638, 76);
            this.label_result.TabIndex = 4;
            this.label_result.Text = "Result";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_result.Click += new System.EventHandler(this.label_result_Click);
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.SeaShell;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_score.Location = new System.Drawing.Point(477, 340);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(62, 42);
            this.label_score.TabIndex = 5;
            this.label_score.Text = "00";
            this.label_score.Click += new System.EventHandler(this.label_score_Click);
            // 
            // ReactionImage
            // 
            this.ReactionImage.Location = new System.Drawing.Point(109, 340);
            this.ReactionImage.Name = "ReactionImage";
            this.ReactionImage.Size = new System.Drawing.Size(168, 131);
            this.ReactionImage.TabIndex = 6;
            // 
            // moodimage
            // 
            this.moodimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("moodimage.ImageStream")));
            this.moodimage.TransparentColor = System.Drawing.Color.Transparent;
            this.moodimage.Images.SetKeyName(0, "1f625.png");
            this.moodimage.Images.SetKeyName(1, "istockphoto-1041299888-612x612.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(315, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "SCORE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReactionImage);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.textBox_guess);
            this.Controls.Add(this.label_word);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_word;
        private System.Windows.Forms.TextBox textBox_guess;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Panel ReactionImage;
        private System.Windows.Forms.ImageList moodimage;
        private System.Windows.Forms.Label label1;
    }
}

