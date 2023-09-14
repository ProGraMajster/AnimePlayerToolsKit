namespace AnimePlayerToolsKit
{
    partial class FormStart
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
            label1 = new Label();
            buttonTAT = new Button();
            panel1 = new Panel();
            button1 = new Button();
            buttonToolNewsCreator = new Button();
            buttonDefinitions = new Button();
            buttonPageItemData = new Button();
            buttonToolEpisode = new Button();
            buttonSendFileToDiscord = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 35);
            label1.Name = "label1";
            label1.Size = new Size(189, 26);
            label1.TabIndex = 0;
            label1.Text = "AnimePlayerToolsKit";
            // 
            // buttonTAT
            // 
            buttonTAT.BackColor = Color.FromArgb(28, 28, 28);
            buttonTAT.FlatAppearance.BorderSize = 0;
            buttonTAT.FlatStyle = FlatStyle.Flat;
            buttonTAT.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTAT.ForeColor = Color.White;
            buttonTAT.Location = new Point(615, 350);
            buttonTAT.Name = "buttonTAT";
            buttonTAT.Size = new Size(161, 35);
            buttonTAT.TabIndex = 1;
            buttonTAT.Text = "Tool TitleCreator";
            buttonTAT.UseVisualStyleBackColor = false;
            buttonTAT.Visible = false;
            buttonTAT.Click += buttonTAT_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(20, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 25, 25);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(765, 0);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 6;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonToolNewsCreator
            // 
            buttonToolNewsCreator.BackColor = Color.FromArgb(28, 28, 28);
            buttonToolNewsCreator.FlatAppearance.BorderSize = 0;
            buttonToolNewsCreator.FlatStyle = FlatStyle.Flat;
            buttonToolNewsCreator.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonToolNewsCreator.ForeColor = Color.White;
            buttonToolNewsCreator.Location = new Point(431, 350);
            buttonToolNewsCreator.Name = "buttonToolNewsCreator";
            buttonToolNewsCreator.Size = new Size(161, 35);
            buttonToolNewsCreator.TabIndex = 2;
            buttonToolNewsCreator.Text = "Tool NewsCreator";
            buttonToolNewsCreator.UseVisualStyleBackColor = false;
            buttonToolNewsCreator.Visible = false;
            buttonToolNewsCreator.Click += buttonToolNewsCreator_Click;
            // 
            // buttonDefinitions
            // 
            buttonDefinitions.BackColor = Color.FromArgb(28, 28, 28);
            buttonDefinitions.FlatAppearance.BorderSize = 0;
            buttonDefinitions.FlatStyle = FlatStyle.Flat;
            buttonDefinitions.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDefinitions.ForeColor = Color.White;
            buttonDefinitions.Location = new Point(451, 90);
            buttonDefinitions.Name = "buttonDefinitions";
            buttonDefinitions.Size = new Size(161, 35);
            buttonDefinitions.TabIndex = 4;
            buttonDefinitions.Text = "Dodaj definicje";
            buttonDefinitions.UseVisualStyleBackColor = false;
            buttonDefinitions.Click += buttonDefinitions_Click;
            // 
            // buttonPageItemData
            // 
            buttonPageItemData.BackColor = Color.FromArgb(28, 28, 28);
            buttonPageItemData.FlatAppearance.BorderSize = 0;
            buttonPageItemData.FlatStyle = FlatStyle.Flat;
            buttonPageItemData.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPageItemData.ForeColor = Color.White;
            buttonPageItemData.Location = new Point(221, 90);
            buttonPageItemData.Name = "buttonPageItemData";
            buttonPageItemData.Size = new Size(201, 35);
            buttonPageItemData.TabIndex = 5;
            buttonPageItemData.Text = "Dodaj informacje o tytule";
            buttonPageItemData.UseVisualStyleBackColor = false;
            buttonPageItemData.Click += buttonPageItemData_Click;
            // 
            // buttonToolEpisode
            // 
            buttonToolEpisode.BackColor = Color.FromArgb(28, 28, 28);
            buttonToolEpisode.FlatAppearance.BorderSize = 0;
            buttonToolEpisode.FlatStyle = FlatStyle.Flat;
            buttonToolEpisode.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonToolEpisode.ForeColor = Color.White;
            buttonToolEpisode.Location = new Point(35, 90);
            buttonToolEpisode.Name = "buttonToolEpisode";
            buttonToolEpisode.Size = new Size(161, 35);
            buttonToolEpisode.TabIndex = 3;
            buttonToolEpisode.Text = "Dodaj odcinek";
            buttonToolEpisode.UseVisualStyleBackColor = false;
            buttonToolEpisode.Click += buttonToolEpisode_Click;
            // 
            // buttonSendFileToDiscord
            // 
            buttonSendFileToDiscord.BackColor = Color.FromArgb(45, 45, 45);
            buttonSendFileToDiscord.FlatAppearance.BorderSize = 0;
            buttonSendFileToDiscord.FlatStyle = FlatStyle.Flat;
            buttonSendFileToDiscord.ForeColor = Color.White;
            buttonSendFileToDiscord.Location = new Point(35, 259);
            buttonSendFileToDiscord.Name = "buttonSendFileToDiscord";
            buttonSendFileToDiscord.Size = new Size(189, 44);
            buttonSendFileToDiscord.TabIndex = 7;
            buttonSendFileToDiscord.Text = "Prześlij pliki na discord'a";
            buttonSendFileToDiscord.UseVisualStyleBackColor = false;
            buttonSendFileToDiscord.Click += buttonSendFileToDiscord_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(28, 28, 28);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(35, 150);
            button2.Name = "button2";
            button2.Size = new Size(206, 35);
            button2.TabIndex = 8;
            button2.Text = "Dodaj powiązanie tytułów";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(buttonSendFileToDiscord);
            Controls.Add(buttonToolEpisode);
            Controls.Add(buttonPageItemData);
            Controls.Add(buttonDefinitions);
            Controls.Add(buttonToolNewsCreator);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(buttonTAT);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnimePlayerToolsKit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonTAT;
        private Panel panel1;
        private Button button1;
        private Button buttonToolNewsCreator;
        private Button buttonDefinitions;
        private Button buttonPageItemData;
        private Button buttonToolEpisode;
        private Button buttonSendFileToDiscord;
        private Button button2;
    }
}