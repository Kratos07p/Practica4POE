namespace FormPractica4
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
            horaInicioComboBox = new ComboBox();
            horaFinComboBox = new ComboBox();
            amPmComboBox = new ComboBox();
            nombreMateriaTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            guardarButton = new Button();
            horariosListBox = new ListBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // horaInicioComboBox
            // 
            horaInicioComboBox.FormattingEnabled = true;
            horaInicioComboBox.Location = new Point(539, 210);
            horaInicioComboBox.Margin = new Padding(3, 4, 3, 4);
            horaInicioComboBox.Name = "horaInicioComboBox";
            horaInicioComboBox.Size = new Size(138, 27);
            horaInicioComboBox.TabIndex = 0;
            // 
            // horaFinComboBox
            // 
            horaFinComboBox.FormattingEnabled = true;
            horaFinComboBox.Location = new Point(49, 309);
            horaFinComboBox.Margin = new Padding(3, 4, 3, 4);
            horaFinComboBox.Name = "horaFinComboBox";
            horaFinComboBox.Size = new Size(138, 27);
            horaFinComboBox.TabIndex = 1;
            // 
            // amPmComboBox
            // 
            amPmComboBox.FormattingEnabled = true;
            amPmComboBox.Location = new Point(539, 309);
            amPmComboBox.Margin = new Padding(3, 4, 3, 4);
            amPmComboBox.Name = "amPmComboBox";
            amPmComboBox.Size = new Size(138, 27);
            amPmComboBox.TabIndex = 2;
            // 
            // nombreMateriaTextBox
            // 
            nombreMateriaTextBox.Location = new Point(49, 210);
            nombreMateriaTextBox.Margin = new Padding(3, 4, 3, 4);
            nombreMateriaTextBox.Name = "nombreMateriaTextBox";
            nombreMateriaTextBox.Size = new Size(138, 27);
            nombreMateriaTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 176);
            label1.Name = "label1";
            label1.Size = new Size(123, 19);
            label1.TabIndex = 6;
            label1.Text = "Nombre Materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(566, 176);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 7;
            label2.Text = "Hora Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 276);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 8;
            label3.Text = "Hora de Fin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(566, 276);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 9;
            label4.Text = "A.M/P.M";
            // 
            // guardarButton
            // 
            guardarButton.BackColor = Color.Red;
            guardarButton.FlatStyle = FlatStyle.Popup;
            guardarButton.ForeColor = SystemColors.ButtonFace;
            guardarButton.Location = new Point(329, 252);
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(75, 28);
            guardarButton.TabIndex = 10;
            guardarButton.Text = "Guardar";
            guardarButton.UseVisualStyleBackColor = false;
            guardarButton.Click += guardarButton_Click;
            // 
            // horariosListBox
            // 
            horariosListBox.BackColor = Color.RosyBrown;
            horariosListBox.FormattingEnabled = true;
            horariosListBox.ItemHeight = 19;
            horariosListBox.Location = new Point(12, 402);
            horariosListBox.Name = "horariosListBox";
            horariosListBox.Size = new Size(688, 156);
            horariosListBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(235, 49);
            label5.Name = "label5";
            label5.Size = new Size(259, 39);
            label5.TabIndex = 12;
            label5.Text = "Horarios de Clases";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(712, 570);
            Controls.Add(label5);
            Controls.Add(horariosListBox);
            Controls.Add(guardarButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nombreMateriaTextBox);
            Controls.Add(amPmComboBox);
            Controls.Add(horaFinComboBox);
            Controls.Add(horaInicioComboBox);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox horaInicioComboBox;
        private ComboBox horaFinComboBox;
        private ComboBox amPmComboBox;
        private TextBox nombreMateriaTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button guardarButton;
        private ListBox horariosListBox;
        private Label label5;
    }
}